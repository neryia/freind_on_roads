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
    public partial class costumer : Form
    {
        public costumer()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        string[] txt_phone = new string[2]; // מחבר בין קידומת פלאפון לשאר הספרות 

        Dictionary<string, string> search = new Dictionary<string, string>(); //מילון לקטגוריית חיפוש לנוחיות הלקוח 

        private string search_by(string str) // פונקציית המרה לקטגוריה חיפוש
        {
            string a = "";
            search.TryGetValue(str, out a);
            return a;
        }

        private void costumer_Load(object sender, EventArgs e)
        {
            txt_first_phone.Items.Add("054-");
            txt_first_phone.Items.Add("052-");
            txt_first_phone.Items.Add("053-");
            txt_first_phone.Items.Add("058-");
            txt_first_phone.Items.Add("050-");
            txt_find_how.Items.Add("מספר תעודת זהות");
            txt_find_how.Items.Add("סוג רכב");
            txt_find_how.Items.Add("קוד לקוח");
            search["מספר תעודת זהות"] = "Id";
            search["סוג רכב"] = "type_car";
            search["קוד לקוח"] = "code_costumer";

        }

        public bool check() // בדיקת תקינות פלט
        {
            bool flag = true;
            if (int.Parse(txt_age.Text) < 17)
            {
                log.Text = "age error";
                flag = false;
            }
            if (txt_Id.Text.Length != 9)
            {
                log.Text = "error Id";
                flag = false;
            }
            if (txt_last_phone.Text.Length != 7)
            {

                log.Text = "error phone";
                flag = false;
            }
            return flag;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string queryString = "Select * from costumer";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("לקוחות");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
                log.Text = "";
                logid.Text = "";
                logphone.Text = "";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (check().Equals(true))
            {
                try
                {
                    string queryString = "INSERT INTO costumer (email, phone, adress, Id, age, type_car, first_name, last_name)" +
                        "VALUES( '" + txt_email.Text + "', '" + txt_first_phone.Text + txt_last_phone.Text + "' , '" + txt_adress.Text +
                        "' ," + txt_Id.Text + " , " + txt_age.Text + ", '" + txt_type_car.Text + "', '" +
                        txt_first_n.Text + "', '" + txt_last_n.Text + "')";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                    log.Text = "the costumer saved";
                    clean_Click(sender, e);
                }
                catch (Exception eeee)
                {
                    log.Text = "erorr, the costumer was not save";
                }
            }
            else
                log.Text = "one of the details unapropiate";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (check().Equals(true))
                {
                string queryString = "UPDATE costumer SET first_name = '" + txt_first_n.Text + " ', last_name = '" + txt_last_n.Text +
                    "' , email = '" + txt_email.Text + "' , phone = '" + txt_first_phone.Text + txt_last_phone.Text + "'," +
                    " adress = '" + txt_adress.Text + "', Id = " + txt_Id.Text + " , age = " + txt_age.Text + " , type_car = '" + txt_type_car.Text +
                    "' WHERE code_costumer = " + txt_code_cost.Text;

                using (SqlConnection connection = new SqlConnection(con))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        log.Text = "the costumer was update";
                    }
                    catch (Exception ee) { log.Text = "error, the costumer not update"; }

                }
            }
            else
                log.Text = "one of the details unapropiate";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = " DELETE FROM costumer WHERE code_costumer = " + txt_code_cost.Text;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                clean_Click(sender, e);
                log.Text = "the costumer was deleted";
            }
            catch (Exception ee) { log.Text = "error, the costumer was not deleted"; }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            txt_last_phone.Text = "";
            txt_first_phone.Text = "";
            txt_adress.Text = "";
            txt_age.Text = "";
            txt_code_cost.Text = "";
            txt_email.Text = "";
            txt_first_n.Text = "";
            txt_Id.Text = "";
            txt_last_n.Text = "";
            txt_type_car.Text = "";
            txt_find.Text = "";
            txt_find_how.Text = "";
            txt_find_how.Enabled = false;
            logid.Text = "";
            logphone.Text = "";
            txt_find.Enabled = false;
            txt_find_how.Visible = false;
            txt_find.Visible = false;

        }

        private void phonecheck(object sender, EventArgs e) // בדיקת תקינות פלאפון
        {
            if (txt_last_phone.Text.Length != 7)
                logphone.Text = "error lengh";
            else
                logphone.Text = "";
        }

        private void IdCheck(object sender, EventArgs e) // בדיקת תקינות ת.ז
        {
            if (txt_Id.Text.Length != 9)
                logid.Text = "ID Length error";
            else
                logid.Text = "";
        }

        private void choose(object sender, DataGridViewCellEventArgs e) // פעולה שמציגה מידע של שורה בטבלה ע"י לחיצה עליה
        {
            clean_Click(sender, e);
            string a = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["Id"].Value);
            }
            string queryString = "Select * from costumer where Id = " + a;
            using (SqlConnection connection = new SqlConnection(con))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("לקוחות");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    txt_phone = dt.Rows[0]["phone"].ToString().Split('-');
                    txt_first_phone.Text = txt_phone[0] + "-";
                    txt_last_phone.Text = txt_phone[1]; txt_adress.Text = dt.Rows[0]["adress"].ToString();
                    txt_age.Text = dt.Rows[0]["age"].ToString();
                    txt_Id.Text = dt.Rows[0]["Id"].ToString();
                    txt_code_cost.Text = dt.Rows[0]["code_costumer"].ToString();
                    txt_email.Text = dt.Rows[0]["email"].ToString();
                    txt_first_n.Text = dt.Rows[0]["first_name"].ToString();
                    txt_last_n.Text = dt.Rows[0]["last_name"].ToString();
                    txt_type_car.Text = dt.Rows[0]["type_car"].ToString();
                    log.Text = "the cosumer appeared";
                }
                catch (Exception eee)
                { log.Text = "error"; }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_find_text_changed(object sender, EventArgs e) // חיפוש לפי קטגוריה נבחרת
        {
            string queryString;
            if (search_by(txt_find_how.Text).Equals("type_car"))
                 queryString = "Select * from costumer where " + search_by(txt_find_how.Text) + " = '" + txt_find.Text + "'";
            else
                queryString = "Select * from costumer where " + search_by(txt_find_how.Text) + " = " + txt_find.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("לקוחות");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
                    txt_phone = dt.Rows[0]["phone"].ToString().Split('-');
                    txt_first_phone.Text = txt_phone[0] + "-";
                    txt_last_phone.Text = txt_phone[1];
                    txt_adress.Text = dt.Rows[0]["adress"].ToString();
                    txt_age.Text = dt.Rows[0]["age"].ToString();
                    txt_Id.Text = dt.Rows[0]["Id"].ToString();
                    txt_code_cost.Text = dt.Rows[0]["code_costumer"].ToString();
                    txt_email.Text = dt.Rows[0]["email"].ToString();
                    txt_first_n.Text = dt.Rows[0]["first_name"].ToString();
                    txt_last_n.Text = dt.Rows[0]["last_name"].ToString();
                    txt_type_car.Text = dt.Rows[0]["type_car"].ToString();
                    log.Text = "the costumer found";
                }
                catch (Exception eee)
                { log.Text = "the costumer was not found"; }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            txt_find.Visible = true;
            txt_find_how.Visible = true;
            txt_find_how.Enabled = true;
            txt_find.Enabled = true;
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

        private void גרירות_Click(object sender, EventArgs e)
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
