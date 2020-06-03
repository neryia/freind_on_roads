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
    public partial class val_form : Form
    {
        public val_form()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        private Dictionary<string, string> search = new Dictionary<string, string>(); // מילון לחיפוש לפי קטגוריה לנוחיות הלקוח
        private Dictionary<string, int> error_to_int = new Dictionary<string, int>(); // מילון שממיר משם תקלה לקוד תקלה
        private Dictionary<int, string> error_to_string = new Dictionary<int, string>(); // מילון שממיר משם תקלה לקוד תקלה

        private void x() // הכנסת מידע למילונים
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
                    error_to_int[dt1.Rows[i]["name_error"].ToString()] = int.Parse(dt1.Rows[i]["error_code"].ToString());
                    error_to_string[int.Parse(dt1.Rows[i]["error_code"].ToString())] = dt1.Rows[i]["name_error"].ToString();
                }
                search["קוד כונן"] = "code_Volunteers";
                search["מספר טופס"] = "Num_of_val_form";
                search["מספר תקלה"] = "error_code";

            }
        }

        private string search_by(string str) // פעולה שממירה את מה שהמשתמש בחר לקטגוריה בבסיס נתונים
        {
            string a = "";
            search.TryGetValue(str, out a);
            return a;
        }

        private int to_int(string str) // פעולה שממירה את שם התקלה לקוד תקלה 
        {
            int outa = 0;
            error_to_int.TryGetValue(str, out outa);
            return outa;
        }

        private string to_string(int a) //  פעולה שממירה את קוד תקלה שם התקלה
        {
            string str;
            error_to_string.TryGetValue(a, out str);
            return str;
        }

        public string out_vis_damage() // פעולה שממירה את התאים המסומנים בנזק חיצוני למחרוזת 
        {
            string stri = " ";

            for (int i = 0; i < txt_damage_visible.Items.Count; i++)
            {
                if (txt_damage_visible.GetItemChecked(i))
                {
                    stri += i + @"/";
                }
            }
            return stri;
        }

        public void in_vis_damage(string str)  // פעולה שמסמנת את התאים בנזק חיצוני שמופיעים במחרוזת 
        {
            string[] srr = str.Split('/');
            for (int i = 0; i < txt_damage_visible.Items.Count; i++)
            {
                txt_damage_visible.SetItemChecked(i, false);
            }
            try
            {
                if (srr.Length > 0)
                {
                    for (int i = 0; i < srr.Length; i++)
                    {
                        txt_damage_visible.SetItemChecked(int.Parse(srr[i]), true);
                    }
                }
            }
            catch (Exception ee) { }
        }

        private string change_starter() // פעולה שמחזירה אמת אם התנעה מסומן 
        {
            string start;
            if (txt_starter.Checked == true)
                start = "true";
            else
                start = "false";
            return start;
        }

        private string change_voice() // פעולה שמחזירה אמת אם רעש מסומן 
        {
            string voice;
            if (txt_sound.Checked == true)
                voice = "true";
            else
                voice = "false";
            return voice;
        }

        public void choose(ComboBox a, ComboBox b, CheckedListBox c, ComboBox d) // COMBOBOX הכנבת מידע ל
        {
            a.Items.Clear();
            b.Items.Clear();
            c.Items.Clear();
            d.Items.Clear();

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
                try
                {
                    string[] aa = new string[2];
                    Dictionary<string, Bitmap> lists = new Dictionary<string, Bitmap>();
                    DirectoryInfo e = new DirectoryInfo(@"PICK");//Assuming Test is your Folder
                    FileInfo[] Files = e.GetFiles("*.png"); //Getting Text files
                    foreach (FileInfo file in Files)
                    {
                        aa = file.Name.Split('.');
                        c.Items.Add(aa[0]);
                    }
                    d.Items.Add("מספר טופס");
                    d.Items.Add("קוד כונן");
                    d.Items.Add("מספר תקלה");
                }
                catch (Exception e) { }

            }

        }

        private void updatefields(object sender, EventArgs e)
        {

            choose(txt_real, txt_val_code, txt_light, txt_find_how);
            x();
        }

        private string To_ligth() // פעולה שממירה את שמות הנורות הדולקות למחרוזת 
        {
            string litgh = "";
            for (int i = 0; i < txt_light.Items.Count; i++)
            {
                if (txt_light.GetItemCheckState(i) == CheckState.Checked)
                {
                    litgh += txt_light.Items[i].ToString();
                    litgh += ".png";
                    litgh += ",";
                }
            }
            return litgh;
        }

        private void from_ligth(string light) // פעולה שמסמנת תאים בנורות שמופיעות במחרוזת 
        {
            int b = 0;
            for (int i = 0; i < light.Length; i++)
            {
                if (light[i] == ',')
                    b++;
            }
            string[] aa = new string[b + 1];
            string[] bb = new string[2];
            aa = light.Split(',');
            for (int i = 0; i < b + 1; i++)
            {
                for (int j = 0; j < txt_light.Items.Count; j++)
                {
                    bb = aa[i].Split('.');
                    if (txt_light.Items[j].ToString().Contains(bb[0]))
                        txt_light.SetItemChecked(j, true);

                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_form_code.Text == "")
            {
                try
                {
                    string queryString = "INSERT INTO val_form (start, sound, see, light, error_code, code_Volunteers) " +
                   "VALUES('" + change_starter() + "', '" + change_voice() + "', '" + out_vis_damage() + "', '" + To_ligth() +
                   "'," + to_int(txt_real.Text) + "," + txt_val_code.Text + ")";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                    log.Text = "the form saved";
                }
                catch (Exception eeee)
                {
                    log.Text = "erorr, the form not save";
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE val_form SET start = '" + change_starter() + "', sound = '" + change_voice() +
            "', see ='" + out_vis_damage() + "', light ='" + To_ligth() + "', error_code ="
            + to_int(txt_real.Text) + ", code_Volunteers =" + txt_val_code.Text +
            " WHERE Num_of_val_form =" + txt_form_code.Text;

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    log.Text = "the val form updated";
                }
                catch (Exception ee) { log.Text = "error! the form was not update"; }

            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            try
            {
                in_vis_damage("");
                txt_real.Text = "";
                txt_form_code.Text = "";
                for (int i = 0; i < txt_light.Items.Count; i++)
                {
                    txt_light.SetItemChecked(i, false);
                }
                txt_light.Text = "";
                txt_sound.Checked = false;
                txt_starter.Checked = false;
                txt_val_code.Text = "";
                txt_find_form.Text = "";
                txt_find_how.Text = "";
                txt_find_how.Enabled = false;
                txt_find_form.Enabled = false;
                txt_find_how.Visible = false;
                txt_find_form.Visible = false;
                log.Text = "cleaning sucsseed";
            }
            catch (Exception ee) { log.Text = "error"; }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "DELETE FROM val_form WHERE Num_of_val_form = " + txt_form_code.Text;

                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "the form deleted";
            }
            catch (Exception ee)
            {
                log.Text = "error, the number of valunteer form is not proper";
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {

            string queryString = "select * from val_form";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("טופס כונן");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
        }

        private void click_event(object sender, DataGridViewCellEventArgs e)
        {
            string a = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["Num_of_val_form"].Value);
            }
            string queryString = "Select * from val_form where Num_of_val_form = " + a;
            using (SqlConnection connection = new SqlConnection(con))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("טופס כונן");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_val_code.Text = dt.Rows[0]["code_Volunteers"].ToString();
                    txt_sound.Checked = Convert.ToBoolean(dt.Rows[0]["sound"].ToString());
                    txt_real.Text = to_string(int.Parse(dt.Rows[0]["error_code"].ToString()));
                    from_ligth(dt.Rows[0]["light"].ToString());
                    txt_starter.Checked = Convert.ToBoolean(dt.Rows[0]["start"].ToString());
                    txt_form_code.Text = dt.Rows[0]["Num_of_val_form"].ToString();
                    in_vis_damage(dt.Rows[0]["see"].ToString());
                    log.Text = "form appeared";
                }
                catch (Exception eee)
                { log.Text = "error"; }
            }
        }

        private void txt_light_SelectedIndexChanged(object sender, EventArgs e)
        {
            light_show.Image = new Bitmap(@"PICK/" + txt_light.Text + ".png");
            light_show.SizeMode = PictureBoxSizeMode.StretchImage;
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
            string how = "" ;
            search.TryGetValue(txt_find_how.Text, out how);
            string queryString = "Select * from val_form where " + how + " = " + txt_find_form.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("טופס לקוח");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_val_code.Text = dt.Rows[0]["code_Volunteers"].ToString();
                    txt_sound.Checked = Convert.ToBoolean(dt.Rows[0]["sound"].ToString());
                    txt_real.Text = to_string(int.Parse(dt.Rows[0]["error_code"].ToString()));
                    from_ligth(dt.Rows[0]["light"].ToString());
                    txt_starter.Checked = Convert.ToBoolean(dt.Rows[0]["start"].ToString());
                    txt_form_code.Text = dt.Rows[0]["Num_of_val_form"].ToString();
                    in_vis_damage(dt.Rows[0]["see"].ToString());
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
