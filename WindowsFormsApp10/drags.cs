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
    public partial class drags : Form
    {
        public drags()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        string[] txt_phone = new string[2]; // מחבר בין קידומת פלאפון לשאר הספרות

        Dictionary<string, string> search = new Dictionary<string, string>(); //מילון לקטגוריית חיפוש לנוחיות הלקוח 

        private string search_by(string a) // פונקציית המרה לקטגוריה חיפוש
        {
            string b = "";
            search.TryGetValue(a, out b);
            return b;
        }

        public void choose(ComboBox a, ComboBox b, ComboBox c) // COMBOBOX פונקציית הכנסת מידע ל 
        {
            a.Items.Clear();
            b.Items.Clear();
            c.Items.Clear();
            using (SqlConnection coni = new SqlConnection(con))
            {
                string qry = "SELECT event_code FROM events_";
                string item;
                var cmd = new SqlCommand(qry, coni);
                cmd.CommandType = CommandType.Text;
                coni.Open();
                using (SqlDataReader objReader = cmd.ExecuteReader())
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
            }
            b.Items.Add("054");
            b.Items.Add("052");
            b.Items.Add("053");
            b.Items.Add("058");
            b.Items.Add("050");
            c.Items.Add("חברת גרירה");
            c.Items.Add("קוד גרירה");
            c.Items.Add("קוד אירוע");
            search["חברת גרירה"] = "company";
            search["קוד גרירה"] = "drag_code";
            search["קוד אירוע"] = "event_code";
        }

        private void updatefields(object sender, EventArgs e)
        {
            choose(txt_event_code, txt_first_phone, txt_find_how);
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string queryString = "Select * from drag";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("גרירות");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
            clean_Click(sender, e);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO drag (company, phone, profit, price, distinction, event_code)" +
                " VALUES( '" + txt_company.Text + "', '" + txt_first_phone.Text + txt_last_phone.Text + "', " + txt_profit.Text
                + ", " + txt_price.Text + ", '" + txt_distinction.Text + "', " + txt_event_code.Text + ")";
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                log.Text = "the drag event saved";
            }
            catch (Exception eeee)
            {
                log.Text = "erorr, the drag event was not save";
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "UPDATE drag SET company = '" + txt_company.Text + ", phone ='" + txt_first_phone.Text + txt_last_phone.Text +
                "', profit =" + txt_profit.Text + ", price =" + txt_price.Text + ", distinction ='" + txt_distinction.Text +
                ", event_code =" + txt_event_code.Text +
                " WHERE drag_code = " + txt_code_drag.Text;

                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                log.Text = "update Succeeded";
            }
            catch (Exception ee) { log.Text = "update faild"; }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string queryString = "DELETE FROM drag WHERE drag_code =" + txt_code_drag.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "drag deleted";
            }
            catch (Exception ee)
            {
                log.Text = "erroe! the drag eas not deleted";
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            txt_code_drag.Text = "";
            txt_event_code.Text = "";
            txt_company.Text = "";
            txt_distinction.Text = "";
            txt_last_phone.Text = "";
            txt_first_phone.Text = "";
            txt_price.Text = "";
            txt_profit.Text = "";
            txt_find_how.Enabled = false;
            txt_find.Enabled = false;
            txt_find_how.Visible = false;
            txt_find.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void click_event(object sender, DataGridViewCellEventArgs e) // פונקציית הצגת מידע של שורה בטבלה שהמשתמש לחץ עליה
        {
            string a = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["drag_code"].Value);
            }
            string queryString = "Select * from drag where drag_code = "+ a.Trim(' ');
            try
            {
                string[] phone = new string[2];
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("גרירות");
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_code_drag.Text = dt.Rows[0]["drag_code"].ToString();
                    txt_event_code.Text = dt.Rows[0]["event_code"].ToString();
                    txt_company.Text = dt.Rows[0]["company"].ToString();
                    txt_distinction.Text = dt.Rows[0]["distinction"].ToString();
                    phone[0] = dt.Rows[0]["phone"].ToString().Trim(' ').Substring(0,3);
                    phone[1] = dt.Rows[0]["phone"].ToString().Trim(' ').Substring(3);
                    txt_first_phone.Text = phone[0];
                    txt_last_phone.Text = phone[1];
                    txt_price.Text = dt.Rows[0]["price"].ToString();
                    txt_profit.Text = dt.Rows[0]["profit"].ToString();
                }
                log.Text = "drag appeared";
            }
            catch (Exception eee)
            { log.Text = "error"; } 
        }
    
        private void txt_phone_TextChanged(object sender, EventArgs e) // התאמת תקינות פלאפון 
        {
            if (txt_last_phone.Text.Length != 7) 
                logphone.Text = "error lengh";
            else
                logphone.Text = "";
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            txt_find.Enabled = true;
            txt_find.Visible = true;
            txt_find_how.Visible = true;
            txt_find_how.Enabled = true;

        }

        private void txt_find_text_changed(object sender, EventArgs e) //מציאת שורה/ות לפי קטגוריה לבחירת המשתמש 
        {
            string queryString = "Select * from drag where " + search_by(txt_find_how.Text) + "= " + txt_find.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("גרירות");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_code_drag.Text = dt.Rows[0]["drag_code"].ToString();
                    txt_event_code.Text = dt.Rows[0]["event_code"].ToString();
                    txt_company.Text = dt.Rows[0]["company"].ToString();
                    txt_distinction.Text = dt.Rows[0]["distinction"].ToString();
                    txt_phone = dt.Rows[0]["phone"].ToString().Split('-');
                    txt_first_phone.Text = txt_phone[0] + "-";
                    txt_last_phone.Text = txt_phone[1];
                    txt_price.Text = dt.Rows[0]["price"].ToString();
                    txt_profit.Text = dt.Rows[0]["profit"].ToString();
                }
                catch (Exception eee) { }
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

        private void אירועים_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new events().Show();

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
    }
}
