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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        private void btn_save_Click(object sender, EventArgs e)
        {

            string query = "Insert into User_ (UserName, PassWord_) VALUES('" + txt_username.Text.Trim(' ') + "', '" + inc(txt_password.Text.Trim(' ')) + "')";
            try
            {
                if (check_password(txt_password.Text.Trim(' ')) == true && check_password(txt_username.Text.Trim(' ')) == true)
                {
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    log.Text = "the user saved";
                }
                else
                    log.Text = "username or password incorrect syntaxt";
            }
            catch (Exception eeee)
            {
                log.Text = "erorr, the user was not save";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_password(txt_password.Text.Trim(' ')) == true && check_password(txt_username.Text.Trim(' ')) == true)
                     {
                    string queryString = "update User_ set UserName = '" + txt_username.Text.Trim(' ') + "', PassWord_  = '" + inc(txt_password.Text.Trim(' ')) +
                    "where UserName = " + txt_username.Text.Trim(' ');

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
                    log.Text = "update Succeeded";
                }
                else
                    log.Text = "username or password incorrect syntaxt";
            }
            catch (Exception ee) { log.Text = "update faild"; }
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "select * from User_";

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

            }
            catch (Exception ee) { log.Text = "error!"; }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            log.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "delete from User_ where UserName = '" + txt_username.Text.Trim(' ') + "'";

                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                log.Text = "user deleted";
            }
            catch (Exception ee) { log.Text = "deleted faild"; }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (check_password(txt_username.Text) == true)
                {
                    check_user.Text = "true";
                    string queryString = "select * from User_ where UserName = '" + txt_username.Text.Trim(' ') + "'"; // שאילתת הצגה לפי משתנה

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        SqlDataAdapter datadp = new SqlDataAdapter(command);
                        DataTable dt = new DataTable("גרירות");
                        datadp.Fill(dt);
                        dataGridView1.DataSource = dt.DefaultView;
                        datadp.Update(dt);
                        txt_username.Text = dt.Rows[0]["UserName"].ToString();
                        txt_password.Text = func(dt.Rows[0]["PassWord_"].ToString());
                    }
                }
                else
                    check_user.Text = "false";

            }
            catch (Exception ee) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_clean_Click(sender, e);
            string a = ""; // מחזיק את שם המשתמש של השורה שנלחצה
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["UserName"].Value);
            }
            string queryString = "Select * from User_ where UserName = '" + a.Trim(' ') + "'";
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("גרירות");
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_username.Text = (dt.Rows[0]["UserName"].ToString()).Trim(' ');
                    txt_password.Text = func(dt.Rows[0]["PassWord_"].ToString().Trim(' '));

                }
                log.Text = "drag appeared";
            }
            catch (Exception eee)
            { log.Text = "error"; }
        }

        private bool check_password(string a) // פונקציית בדיקת תקינות הקלט
        {
            bool flag = false;
            string b = a;
            for(int i  = 0; i< b.Length;i++)
            {
                if (b[i] > 96 && b[i] < 123)
                    flag = true;
                else if (b[i] > 64 && b[i] < 91)
                    flag = true;
                else if (b[i] > 47 && b[i] < 58)
                    flag = true;
                else
                    flag = false;
            }
            return flag;
        }

        private void txt_password_TextChanged(object sender, EventArgs e) //בדיקת קלט לכל תו שנקלט
        {
            if (check_password(txt_password.Text) == true)
                check_pass.Text = "true";
            else
                check_pass.Text = "false";

        }

        private char changeto(char a, int n) // פונקציית הצפנה האסקי
        {
            if (a > 96 && a < 123)
            {
                if ((int)(a + n) > 122)
                    return (char)(97 + ((a + n) - 122));
                else
                    return (char)(a + n);
            }
            else if (a > 64 && a < 91)
            {
                if ((int)(a + n) > 90)
                    return (char)(65 + ((a + n) - 90));
                else
                    return (char)(a + n);
            }
            else if (a > 47 && a < 58)
            {
                if ((int)(a + n) > 57)
                    return (char)(48 + ((a + n) - 58));
                else
                    return (char)(a + n);
            }
            else
                return '!';
        }

        private string inc(string str) // פונקציית הצפנה מלאה
        {
            try
            {
                string s = "", a = "";
                string[] g;
                int b = str.Length / 5;
                if (str.Length % 5 == 0)
                    g = new string[(str.Length / 5)];
                else
                    g = new string[(str.Length / 5) + 1];
                for (int i = 0; i < str.Length - 5; i += 5)
                {
                    g[i] = str.Substring(i, i + 5);
                }
                g[b] = str.Substring((b * 5), str.Length - (b * 5));

                for (int i = 0; i < g.Length; i++)
                {
                    s = "";
                    for (int j = 0; j < g[i].Length; j++)
                    {
                         if (changeto(g[i][j], 5).Equals('!'))
                        {
                            MessageBox.Show("one or more of the characters illigle");
                            return "";
                        }
                        else
                        {
                            s += changeto(g[i][j], 5);
                        }
                    }
                    g[i] = s;
                }
                for (int i = 0; i < g.Length; i++)
                {
                    a += g[i];
                }
                //string s2 = str[str.Length - 1] + str.Substring(0, str.Length - 1);
                return a;
            }
            catch (Exception ee)
            {
                MessageBox.Show("error! try again");
                return "";
            }
        }

        private string func(string str) // פונקציית מחזור הצפנה מלאה
        {
            str = str.Trim(' ');
            try
            {
                string s = "", a = "";
                string[] g;
                int b = str.Length / 5;
                if (str.Length % 5 == 0)
                    g = new string[(str.Length / 5)];
                else
                    g = new string[(str.Length / 5) + 1];
                for (int i = 0; i < str.Length - 5; i += 5)
                {
                    g[i] = str.Substring(i, i + 5);
                }
                g[b] = str.Substring((b * 5), str.Length - (b * 5));

                for (int i = 0; i < g.Length; i++)
                {
                    s = "";
                    for (int j = 0; j < g[i].Length; j++)
                    {
                        if (changefrom(g[i][j], 5).Equals('!'))
                        {
                            MessageBox.Show("error please try again!");
                            return "";
                        }
                        s += changefrom(g[i][j], 5);
                    }
                    g[i] = s;
                }
                for (int i = 0; i < g.Length; i++)
                {
                    a += g[i];
                }
                //string s2 = str[str.Length - 1] + str.Substring(0, str.Length - 1);
                return a;
            }
            catch (Exception ee)
            {
                MessageBox.Show("error please try again!");
                return "";
            }
        }

        private char changefrom(char a, int n) // פונקציית מחזור הצפנה האסקי
        {
            if (a > 96 && a < 123)
            {
                if ((int)(a - n) < 97)
                    return (char)(122 - (97 - (a - n)));
                else
                    return (char)(a - n);
            }
            else if (a > 64 && a < 91)
            {
                if ((int)(a - n) < 65)
                    return (char)(90 - (65 - (a - n)));
                else
                    return (char)(a - n);
            }
            else if (a > 46 && a < 58)
            {
                if ((int)(a - n) < 48)
                    return (char)(58 - (48 - (a - n)));
                else
                    return (char)(a - n);
            }
            else
                return '!';
        }

        private void טופסלקוח_Click(object sender, EventArgs e)
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

        private void התנתקות_Click(object sender, EventArgs e)
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
