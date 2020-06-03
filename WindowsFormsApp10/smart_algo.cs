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
    public partial class smart_algo : Form
    {
        public smart_algo()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        string format = "yyyy-MM-dd";// פורמט תאריך
        Dictionary<int, int> code_to_error_to_code = new Dictionary<int, int>(); // מילון שמחזיר את המיקום של קוד תקלה
        Dictionary<int, int> code_to_error_to_index = new Dictionary<int, int>(); // מילון שמחזיר את קוד התקלה שבמיקום מסויים
        private Dictionary<string, int> error_to_int = new Dictionary<string, int>(); // מילון שממיר שם תקלה לקוד תקלה
        private Dictionary<int, string> error_to_string = new Dictionary<int, string>(); // מילון שממיר קוד תקלה לשם תקלה
        Dictionary<string, string> search = new Dictionary<string, string>(); // חיפוש לפי קטגוריה קלה למשתמש

        private string search_by(string str) // פונקצייה שעושה שימוש במילון חיפוש
        {
            string a = "";
            search.TryGetValue(str, out a);
            return a;
        }

        private void update_code_to_error() // מכניס מידע למילונים של מיקום - קוד תקלה
        {
            string query = "Select error_code from errors";
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("תקלות-כוננים");
                datadp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    code_to_error_to_code[int.Parse(dt.Rows[i]["error_code"].ToString())] = i;
                    code_to_error_to_index[i] = int.Parse(dt.Rows[i]["error_code"].ToString());
                }
            }

        }

        public void choose(ComboBox a) // COMBOBOX הכנסת מידע ל
        {
            a.Items.Clear();

            using (SqlConnection coni = new SqlConnection(con))
            {
                string qry_errors = "SELECT Num_of_costumer_form FROM costumer_form";
                string item;
                var cmd_errors = new SqlCommand(qry_errors, coni);
                cmd_errors.CommandType = CommandType.Text;
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
            }
        } 

        private void btn_expected_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "Select * from costumer_form where Num_of_costumer_form = " + txt_num_form.Text;
                int[] errors = new int[count_errors()];
                for (int i = 0; i < errors.Length; i++)
                {
                    errors[i] = 0;
                }
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("תקלות-כוננים");
                    datadp.Fill(dt);
                    string queryString1 = "Select * from val_form";
                    SqlCommand command1 = new SqlCommand(queryString1, connection);
                    SqlDataAdapter datadp1 = new SqlDataAdapter(command1);
                    DataTable dt1 = new DataTable("טופס כונן");
                    datadp1.Fill(dt1);
                    string sound, start, see, light;
                    sound = dt.Rows[0]["sound"].ToString().Trim(' ');
                    start = dt.Rows[0]["start"].ToString().Trim(' ');
                    see = dt.Rows[0]["see"].ToString().Trim(' ');
                    light = dt.Rows[0]["light"].ToString().Trim(' ');
                    int y = 0;
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if ((sound == dt1.Rows[i]["sound"].ToString().Trim(' ')) && (start == dt1.Rows[i]["start"].ToString().Trim(' '))
                            && (see == dt1.Rows[i]["see"].ToString().Trim(' ')) && (light == dt1.Rows[i]["light"].ToString().Trim(' ')))
                        {
                            code_to_error_to_code.TryGetValue(int.Parse(dt1.Rows[i]["error_code"].ToString()), out y);
                            errors[y]++;
                        }
                    }
                    int j = 0;
                    if (y != 0)
                    {
                        code_to_error_to_index.TryGetValue(return_index(errors), out j);
                        expected.Text = to_string(j);
                    }
                    else
                    {
                        code_to_error_to_index.TryGetValue(errors.Length - 1, out j);
                        expected.Text = to_string(j);
                    }
                    error[] num_errors = new error[count_errors()];
                    for (int i = 0; i < count_errors(); i++)
                    {
                        num_errors[i] = new error(count_errors()); 
                        num_errors[i].setNUMError_();
                    }
                    string query7 = "select error_Prediction.error_code as smart_error_code, error_Prediction.Num_of_costumer_form, events_.Num_of_costumer_form, events_.Num_of_val_form, val_form.Num_of_val_form, val_form.error_code from error_Prediction inner join events_ on error_Prediction.Num_of_costumer_form = events_.Num_of_costumer_form inner join val_form on events_.Num_of_val_form = val_form.Num_of_val_form";
                    SqlCommand command7 = new SqlCommand(query7, connection);
                    SqlDataAdapter datadp6 = new SqlDataAdapter(command7);
                    DataTable dt6 = new DataTable("תקלות-כוננים");
                    datadp6.Fill(dt6);
                    for (int i = 0; i < dt6.Rows.Count; i++)
                    {
                        code_to_error_to_code.TryGetValue(int.Parse(dt6.Rows[i]["smart_error_code"].ToString()), out int smart);
                        code_to_error_to_code.TryGetValue(int.Parse(dt6.Rows[i]["error_code"].ToString()), out int real);
                        num_errors[smart].setNUMError_plus(real);
                    }
                    code_to_error_to_code.TryGetValue(j, out int a);
                    int code_error_index = eee(num_errors[a].GET_num_errors());
                    code_to_error_to_index.TryGetValue(code_error_index, out int o);
                    string d = to_string(o);
                    secondery.Text = d;
                    int val_code;
                    if (check_if() == true)
                    {
                        string queryString4 = "Insert Into error_Prediction(error_code, Num_of_costumer_form) VALUES (" + j + ", " + int.Parse(txt_num_form.Text) + ")";
                        SqlCommand command4 = new SqlCommand(queryString4, connection);
                        SqlDataAdapter datadp3 = new SqlDataAdapter(command4);
                        DataTable dt3 = new DataTable("תקלות-כוננים");
                        datadp3.Fill(dt3);
                        dataGridView1.DataSource = dt3.DefaultView;
                        datadp3.Update(dt3);
                        string queryString3 = "select Volunteers.first_name , Volunteers.last_name, Volunteers.code_Volunteers from Volunteers join (select code_Volunteers from vol_errors where error_code = " + j + " or error_code = " + o +  ") as t on t.code_Volunteers = Volunteers.code_Volunteers";
                        SqlCommand command3 = new SqlCommand(queryString3, connection);
                        SqlDataAdapter datadp2 = new SqlDataAdapter(command3);
                        DataTable dt2 = new DataTable("תקלות-כוננים");
                        datadp2.Fill(dt2);
                        last.Text = dt2.Rows[0]["last_name"].ToString();
                        code_mach.Text = dt2.Rows[0]["First_name"].ToString();
                        val_code = int.Parse(dt2.Rows[0]["code_Volunteers"].ToString());
                        int va_form_code;
                        string queryString5 = "INSERT INTO val_form(start, sound, see, light, error_code, code_Volunteers) output INSERTED.Num_of_val_form" +
                        " VALUES('false', 'false', 'false', '', 3001," + val_code + ")";
                        SqlCommand command5 = new SqlCommand(queryString5, connection);
                        SqlDataAdapter datadp4 = new SqlDataAdapter(command5);
                        DataTable dt4 = new DataTable("תקלות-כוננים");
                        datadp4.Fill(dt4);
                        va_form_code = int.Parse(dt4.Rows[0]["Num_of_val_form"].ToString());
                        string queryString6 = "INSERT INTO events_ (date, coordiant_x, coordiant_y, status_, Num_of_costumer_form, Num_of_val_form) " +
                        "VALUES( '" + DateTime.Now.ToString(format) +"',0 , 0 ,0"+ 
                        ", " + txt_num_form.Text + ", " + va_form_code + ")";
                        SqlCommand command6 = new SqlCommand(queryString6, connection);
                        SqlDataAdapter datadp5 = new SqlDataAdapter(command6);
                        DataTable dt5 = new DataTable("תקלות-כוננים");
                        datadp5.Fill(dt5);
                    }
                    else { log.Text = "there is already"; }
                }

            }
            catch (Exception eee) { log.Text = "error"; }
        }

        private bool check_if() // פונקציה הבודקת אם הפעולה של האלגוריתם החכם כבר נעשתה על טופס זה
        {
            bool flag; 
            string query = "select count (*) as c from error_Prediction where Num_of_costumer_form = " + int.Parse(txt_num_form.Text);
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("תקלות-כוננים");
                datadp.Fill(dt);
                if (int.Parse(dt.Rows[0]["c"].ToString()) > 0)
                {
                    flag = false;
                    label5.Text = "false";
                }
                else
                {
                    flag = true;
                    label5.Text = "true";
                }
                return flag;
            }
        }

        private void load(object sender, EventArgs e)
        {
            choose(txt_num_form);
            x();
            update_code_to_error();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            txt_num_form.Text = "";
            code_mach.Text = "";
            expected.Text = "";
            last.Text = "";
            log.Text = "";
            secondery.Text = "";
        }

        private int to_int(string str) // פונקצייה שממירה שם תקלה לקוד תקלה
        {
            int outa = 0;
            error_to_int.TryGetValue(str, out outa);
            return outa;
        }

        private string to_string(int a) // פונקצייה שממירה קוד תקלה לשם תקלה 
        {
            string str;
            error_to_string.TryGetValue(a, out str);
            return str;
        }

        private int count_errors() // פעולה שמחזירה את מספר התקלות שיש במערכת 

        {
            int a = 0;
            string query_count_error = "select count(error_code) as num from errors";
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query_count_error, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("תקלות-כוננים");
                datadp.Fill(dt);
                a = int.Parse(dt.Rows[0]["num"].ToString());
                return a;
            }

        }

        private void x() // הכנסת מידע למילון חיפוש לפי קטגוריה
        {
            string query = "select name_error, error_code from errors";
            using (SqlConnection connectioni = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connectioni);
                connectioni.Open();
                SqlDataAdapter datadp1 = new SqlDataAdapter(command);
                DataTable dt1 = new DataTable("תקלות");
                datadp1.Fill(dt1);
                datadp1.Update(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    error_to_int[dt1.Rows[i]["name_error"].ToString()] = int.Parse(dt1.Rows[i]["error_code"].ToString());
                    error_to_string[int.Parse(dt1.Rows[i]["error_code"].ToString())] = dt1.Rows[i]["name_error"].ToString();
                }
            }
            search["תקלה צפויה"] = "error_code";
            search["קוד טופס לקוח"] = "Num_of_costumer_form";
        }

        private int return_index(int[] errors) // מציאת הערך המקסימלי במערך
        {
            int maxValue = errors.Max();
            int maxIndex = errors.ToList().IndexOf(maxValue);
            return maxIndex;
        }
        private int eee(int[] errors)
        {
            int maxValue = errors[0];
            int to_max = errors[0];
            for (int i = 1; i < errors.Length; i++)
            {
                if (errors[i] > maxValue)
                    maxValue = errors[i];
                else if (errors[i] < maxValue)
                {
                    if (errors[i] > to_max)
                        to_max = errors[i];
                }

            }
            int maxIndex = errors.ToList().IndexOf(to_max);
            return maxIndex;
        }

        private void btn_show_all_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "select * from error_Prediction";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command4 = new SqlCommand(queryString, connection);
                    SqlDataAdapter datadp3 = new SqlDataAdapter(command4);
                    DataTable dt3 = new DataTable("תקלות-כוננים");
                    datadp3.Fill(dt3);
                    dataGridView1.DataSource = dt3.DefaultView;
                    datadp3.Update(dt3);
                }
                clean_Click(sender, e);
            }
            catch (Exception ee)
            {
                log.Text = "error!!";
            }
        }

        private void txt_find_text_changed(object sender, EventArgs e)
        {
            try
            {
                string queryString = "select * from error_Prediction where " + search_by(txt_find_how.Text) + " = " + int.Parse(txt_find.Text);
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command4 = new SqlCommand(queryString, connection);
                    SqlDataAdapter datadp3 = new SqlDataAdapter(command4);
                    DataTable dt3 = new DataTable("תקלות-כוננים");
                    datadp3.Fill(dt3);
                    dataGridView1.DataSource = dt3.DefaultView;
                    datadp3.Update(dt3);
                }
            }
            catch (Exception ee)
            {
               
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            txt_find_how.Enabled = true;
            txt_find_how.Visible = true;
            txt_find.Visible = true;
            txt_find.Enabled = true;
            clean_Click(sender, e);
        }

        private void txt_num_form_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_if();
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
