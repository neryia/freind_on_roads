using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        string format = "yyyy-MM-dd"; // פורמט כתיבת התאריך

        bool check_costbool, check_valbool; // משתנים המחזיקים את נכונות בחירת הטפסים של הכונן והלקוח
        Dictionary<string, string> to_query = new Dictionary<string, string>(); //מילון לקטגוריית חיפוש לנוחיות הלקוח

        public void choose(ComboBox a, ComboBox b, ComboBox c) // COMBOBOX פעולת הכנסת מידע ל
        {
            a.Items.Clear();
            b.Items.Clear();
            c.Items.Clear();

            using (SqlConnection coni = new SqlConnection(con))
            {
                string qry_cos = "SELECT Num_of_costumer_form FROM costumer_form";
                string qry_val = "SELECT Num_of_val_form FROM val_form";
                string item;
                var cmd_cos = new SqlCommand(qry_cos, coni);
                var cmd_val = new SqlCommand(qry_val, coni);
                cmd_cos.CommandType = CommandType.Text;
                cmd_val.CommandType = CommandType.Text;
                coni.Open();
                using (SqlDataReader objReader = cmd_cos.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            item = objReader.GetValue(0).ToString();


                            a.Items.Add(item);
                        }
                    }
                }
                using (SqlDataReader objReader = cmd_val.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            item = objReader.GetValue(0).ToString();


                            b.Items.Add(item);
                        }
                    }
                }
                c.Items.Add("סטטוס");
                c.Items.Add("קוד אירוע");
                c.Items.Add("תאריך");
            }

        }

        private void updatefields(object sender, EventArgs e)
        {
            choose(txt_cos_form, txt_val_form, txt_find_how);
            txt_date.MaxSelectionCount = 1;
            txt_date.MaxDate = DateTime.Today;
            txt_find_date.MaxSelectionCount = 1;
            txt_find_date.MaxDate = DateTime.Today;
            to_query["סטטוס"] = "status_";
            to_query["קוד אירוע"] = "event_code";
            to_query["תאריך"] = "date";

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            clean_Click(sender, e);
            string queryString = "Select * from events_";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("אירועים");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (check_costbool == true && check_valbool == true)
            {
                try
                {
                    int txtstatus;
                    if (this.txtstatus.Checked == true)
                        txtstatus = 1;
                    else
                        txtstatus = 0;
                    string queryString = "INSERT INTO events_ (date, coordiant_x, coordiant_y, status_, Num_of_costumer_form, Num_of_val_form) " +
                        "VALUES( '" + txt_date.SelectionRange.Start.ToString(format) + "', " + txt_coordinatex.Text + " , " + txt_coordinatey.Text + " ," + txtstatus +
                        ", " + txt_cos_form.Text + ", " + txt_val_form.Text + ")";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        log.Text = "event saved";
                        clean_Click(sender, e);
                    }
                }
                catch (Exception eeee)
                {
                    log.Text = "erorr, the event not save";
                }
            }
            else
                log.Text = "saving faild, check forms";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string queryString = " DELETE FROM events_ WHERE event_code = " + txt_event_code.Text;

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            clean_Click(sender, e);
        }

        private void clean_Click(object sender, EventArgs e)
        {
            txtstatus.Checked = false;
            txt_coordinatex.Text = "";
            txt_coordinatey.Text = "";
            txt_cos_form.Text = "";
            txt_date.SetDate(DateTime.Today);
            txt_event_code.Text = "";
            txt_val_form.Text = "";
            txt_find_how.Enabled = false;
            txt_find_form.Enabled = false;
            txt_find_how.Visible = false;
            txt_find_form.Visible = false;
            txt_find_date.Enabled = false;
            txt_find_date.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
                int txtstatus;
                if (this.txtstatus.Checked == true)
                    txtstatus = 1;
                else
                    txtstatus = 0;
                string queryString = "UPDATE events_ SET date = '" + txt_date.SelectionRange.Start.ToString(format) + "' , coordiant_x = '" + txt_coordinatex.Text +
                "', coordiant_y = '" + txt_coordinatey.Text + "', status_ = " + txtstatus + ", Num_of_costumer_form = " + txt_cos_form.Text +
                ", Num_of_val_form =" + txt_val_form.Text + " WHERE event_code = " + txt_event_code.Text;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        log.Text = "update suceed";
                        clean_Click(sender, e);
                }
                    catch (Exception ee) { }

                }
            
        }

        private void click_event(object sender, DataGridViewCellEventArgs e) // פעולה שמציגה מידע של שורה בטבלה ע"י לחיצה עליה
        {
            clean_Click(sender, e);
            string a = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["event_code"].Value);
            }
            string queryString = "Select * from events_ where event_code = " + a;
            using (SqlConnection connection = new SqlConnection(con))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("אירועים");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_date.SetDate(DateTime.Parse(dt.Rows[0]["date"].ToString()));
                    txtstatus.Checked = Convert.ToBoolean(dt.Rows[0]["status_"].ToString());
                    txt_coordinatex.Text = dt.Rows[0]["coordiant_x"].ToString();
                    txt_coordinatey.Text = dt.Rows[0]["coordiant_y"].ToString();
                    txt_event_code.Text = dt.Rows[0]["event_code"].ToString();
                    txt_val_form.Text = dt.Rows[0]["Num_of_val_form"].ToString();
                    txt_cos_form.Text = dt.Rows[0]["Num_of_costumer_form"].ToString();
                }
                catch (Exception eee)
                { }
            }
        }

        private void check_cost(object sender, EventArgs e) // פונקציית בדיקה האם יש אירוע שיש לו את אותו מספר טופס לקוח

        {
            string queryString = "Select * from events_ where Num_of_costumer_form = " + txt_cos_form.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("אירועים");

                datadp.Fill(dt);
                if (dt.Rows.Count > 0)
                { 
                    label9.Text = "false";
                    check_costbool = false;
                }
                else
                {
                    check_costbool = true;
                    label9.Text = "true";
                }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            txt_find_form.Enabled = true;
            txt_find_form.Visible = true;
            txt_find_how.Enabled = true;
            txt_find_how.Visible = true;

        }

        private void txt_find_form_TextChanged(object sender, EventArgs e)
        {
                to_query.TryGetValue(txt_find_how.Text.Trim(), out string a);
                string queryString = "Select * from events_ where " + a + " = " + txt_find_form.Text.Trim();
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("אירועים");
                    try
                    {
                        datadp.Fill(dt);
                        dataGridView1.DataSource = dt.DefaultView;
                        datadp.Update(dt);
                        txt_date.SetDate(DateTime.Parse(dt.Rows[0]["date"].ToString()));
                        txtstatus.Checked = Convert.ToBoolean(dt.Rows[0]["status_"].ToString());
                        txt_coordinatex.Text = dt.Rows[0]["coordiant_x"].ToString();
                        txt_coordinatey.Text = dt.Rows[0]["coordiant_y"].ToString();
                        txt_event_code.Text = dt.Rows[0]["event_code"].ToString();
                        txt_val_form.Text = dt.Rows[0]["Num_of_val_form"].ToString();
                        txt_cos_form.Text = dt.Rows[0]["Num_of_costumer_form"].ToString();
                    }
                    catch (Exception eee) { }
                }
        }

        private void txt_find_how_SelectedValueChanged(object sender, EventArgs e) // חיפוש תאריך משתנה
        {
            to_query.TryGetValue(txt_find_how.Text.Trim(), out string a);
            if (a.Equals("date"))
            {
                txt_find_date.Visible = true;
                txt_find_date.Enabled = true;
            }
        }

        private void טופסלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cost_form().Show();
        }

        private void הוספתמשתמש_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new add_user().Show();
        }

        private void לקוחות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new costumer().Show();
        }

        private void שאילתות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new querybtn().Show();
        }

        private void טופסכונן_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new val_form().Show();
        }

        private void אלגוריתםחכם_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new smart_algo().Show();

        }

        private void טופסלקוח_CLICK(object sender, EventArgs e)
        {
            this.Visible = false;
            new drags().Show();

        }

        private void כוננים_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Volunteers().Show();

        }

        private void תקלות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new errors().Show();

        }

        private void חמל_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new op_room().Show();

        }

        private void התנתקותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "opening_screen")
                {
                    Application.OpenForms[i].Close();
                }
            }
            Application.Restart();
        }

        private void גרירות_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new drags().Show();
        }

        private void טפסילקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cost_form().Show();
        }

        private void txt_find_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            to_query.TryGetValue(txt_find_how.Text.Trim(), out string a);
            string queryString = "Select * from events_ where " + a + " = '" + txt_find_date.SelectionRange.Start.ToString(format) + "'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("אירועים");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_date.SetDate(DateTime.Parse(dt.Rows[0]["date"].ToString()));
                    txtstatus.Checked = Convert.ToBoolean(dt.Rows[0]["status_"].ToString());
                    txt_coordinatex.Text = dt.Rows[0]["coordiant_x"].ToString();
                    txt_coordinatey.Text = dt.Rows[0]["coordiant_y"].ToString();
                    txt_event_code.Text = dt.Rows[0]["event_code"].ToString();
                    txt_val_form.Text = dt.Rows[0]["Num_of_val_form"].ToString();
                    txt_cos_form.Text = dt.Rows[0]["Num_of_costumer_form"].ToString();
                }
                catch (Exception eee) { }
            }
        }

        private void check_val(object sender, EventArgs e) // פונקציית בדיקה האם יש אירוע שיש לו את אותו מספר טופס כונן 
        {
            string queryString = "Select * from events_ where Num_of_val_form =" + txt_val_form.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("jk");
                datadp.Fill(dt);
                if (dt.Rows.Count > 0)
                { 
                    label10.Text = "false";
                    check_valbool = false;
                }
                else
                {
                    check_valbool = true;
                    label10.Text = "true";
                }
            }
        }
    }
}
