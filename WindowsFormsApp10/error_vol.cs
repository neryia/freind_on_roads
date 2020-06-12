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
    public partial class Form2 : Form
    {
        int val_code;
        public Form2(int a)
        {
            val_code = a;
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        Dictionary<string, string> search = new Dictionary<string, string>(); //מילון לקטגוריית חיפוש לנוחיות הלקוח
        private Dictionary<string, int> error_to_int = new Dictionary<string, int>(); //מילון שממיר שם תקלה לקוד תקלה
        private Dictionary<int, string> error_to_string = new Dictionary<int, string>(); // מילון שממיר קוד תקלה לשם תקלה

        public string search_by(string a) // פעולה שמחזירה את קטגוריית החיפוש הנבחרת ע"י המשתמש כהכנה לשאילתה
        {
            string b = "";
            search.TryGetValue(a, out b);
            return b;
        }

        private void x() // פעולת הכנסת מידע למילונים
        {
            int a;
            string query = "select name_error, error_code from errors";
            string query1 = "SELECT COUNT(*) from errors";
            using (SqlConnection connectioni = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connectioni);
                SqlCommand command1 = new SqlCommand(query1, connectioni);
                connectioni.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command1);
                DataTable dt = new DataTable("חדש");
                datadp.Fill(dt);
                a = int.Parse(dt.Rows[0]["column1"].ToString());
                SqlDataAdapter datadp1 = new SqlDataAdapter(command);
                DataTable dt1 = new DataTable("תקלות");
                datadp1.Fill(dt1);
                for (int i = 0; i < a; i++)
                {
                    error_to_int[dt1.Rows[i]["name_error"].ToString().Trim()] = int.Parse(dt1.Rows[i]["error_code"].ToString().Trim());
                    error_to_string[int.Parse(dt1.Rows[i]["error_code"].ToString().Trim())] = dt1.Rows[i]["name_error"].ToString().Trim();
                }
                search["שם תקלה"] = "error_code";
                search["קוד כונן"] = "code_Volunteers";
            }
        }

        private int to_int(string str) //פעולה שמחזירה את קוד התקלה בנתינת שם תקלה 
        {
            int outa = 0;
            error_to_int.TryGetValue(str, out outa);
            return outa;
        }

        private string to_string(int a)//פעולה שמחזירה את שם התקלה בנתינת קוד תקלה
        {
            string str;
            error_to_string.TryGetValue(a, out str);
            return str;
        }

        public void choose(ComboBox a, ComboBox b, ComboBox c) // COMBOBOX פעולת הכנסת מידע ל 
        {
            a.Items.Clear();
            b.Items.Clear();
            c.Items.Clear();

            using (SqlConnection coni = new SqlConnection(con))
            {
                string qry_errors = "SELECT name_error FROM errors order by name_error ASC";
                string qry_val = "SELECT code_Volunteers FROM Volunteers order by code_Volunteers ASC";
                string item;
                var cmd_errors = new SqlCommand(qry_errors, coni);
                var cmd_val = new SqlCommand(qry_val, coni);
                cmd_errors.CommandType = CommandType.Text;
                cmd_val.CommandType = CommandType.Text;
                coni.Open();
                using (SqlDataReader objReader = cmd_errors.ExecuteReader())
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
                c.Items.Add("שם תקלה");
                c.Items.Add("קוד כונן");
            }
        }

        private void load(object sender, EventArgs e)
        {
            txt_code_val.Text = val_code.ToString();
            x();
            choose(txt_name_error, txt_code_val, txt_find_how);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE vol_errors SET code_Volunteers = " + txt_code_val.Text + "error_code = " + txt_name_error.Text +
                "where code_Volunteers = " + txt_code_val.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                log.Text = "profession update!";
            }
            catch (Exception ee) { log.Text = "error! the profession was not update"; }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            txt_code_val.Text = "";
            txt_name_error.Text = "";
            txt_find_how.Enabled = false;
            txt_find.Enabled = false;
            txt_find_how.Visible = false;
            txt_find.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO vol_errors (code_Volunteers, error_code) VALUES (" + int.Parse(txt_code_val.Text) + ", " + to_int(txt_name_error.Text.Trim()) + " )";
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                log.Text = "profession saved";
            }
            catch (Exception eeee) { log.Text = "error! profession was not saved"; }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string queryString = " DELETE FROM vol_errors WHERE code_Volunteers = " + txt_code_val.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "the profession deleted";
            }
            catch(Exception ee)
            {
                log.Text = "error! the profession was not not deleted";
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string queryString = "Select * from vol_errors";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("תקלות-כוננים");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
            log.Text = "";
        }

        private void txt_find_Text_changed(object sender, EventArgs e)
        {
            string queryString = "";
            if (search_by(txt_find_how.Text) == "error_code")
                queryString = "Select * from vol_errors where " + search_by(txt_find_how.Text) + " = " + to_int(txt_find.Text);
            else
                queryString = "Select * from vol_errors where " + search_by(txt_find_how.Text) + " = " + txt_find.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("לקוחות");
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                }
                log.Text = "the profession found";
            }
            catch (Exception eee)
            { log.Text = "error! the profession was not found"; }
        }

        private void click(object sender, DataGridViewCellEventArgs e)  // פעולה שמציגה מידע של שורה בטבלה ע"י לחיצה עליה 
        {
            clean_Click(sender, e);
            string a = "";
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    a = Convert.ToString(selectedRow.Cells["code_Volunteers"].Value);
                }
                string queryString = "Select * from vol_errors where code_Volunteers = " + a;
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("לקוחות");
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    txt_code_val.Text = dt.Rows[0]["code_Volunteers"].ToString();
                    txt_name_error.Text = to_string(int.Parse(dt.Rows[0]["error_code"].ToString()));
                }
                log.Text = "profession appeared";
            }
            catch (Exception ee)
            { log.Text = "error! the professionwas not appeared"; }   
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
    }
}

