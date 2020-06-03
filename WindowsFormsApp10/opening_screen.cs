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
    public partial class opening_screen : Form
    {
        public opening_screen()
        {
            InitializeComponent();
            txt_password.PasswordChar = '#';
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user,password, queryString = "select * from User_ where UserName = '" + txt_User_Name.Text + "' AND PassWord_ = '" + inc(txt_password.Text) + "'"; // שאילתה המעלה את פרטי המשתמש המשווה
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("כוננים");
                    datadp.Fill(dt);
                    user = dt.Rows[0]["UserName"].ToString();
                    password = dt.Rows[0]["PassWord_"].ToString();
                    if (func(password.Trim(' ')).Equals(txt_password.Text.Trim(' ')) && user.Trim(' ').Equals(txt_User_Name.Text.Trim(' ')))
                    {
                        new menu().Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("UserName or PassWord Incorrect");
                    }
                }
            }
            catch (Exception ee) { MessageBox.Show("UserName or PassWord Incorrect"); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_User_Name.Text = "";
        }
    
        private char changeto(char a, int n) //  פונקציית ההצפנה הערך האסקי
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

        private string inc(string str) // פונקציית ההצפנה
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
            catch (Exception ee) {
                MessageBox.Show("error! try again");
                return "";
            }
        }

        private string func(string str) // פונקצייה המחזירה מהצפנה 
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

        private char changefrom(char a, int n) //  החזרה מהצפנה הערך ההאסקי
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

        private void opening_screen_Enter(object sender, EventArgs e) // לחיצה על מקש ENTER
        {
            button2_Click(sender, e);
        }

       
    }
}
