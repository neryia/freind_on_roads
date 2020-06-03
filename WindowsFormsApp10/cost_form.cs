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
    public partial class cost_form : Form
    {
        public cost_form()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        private Dictionary<string, string> search = new Dictionary<string, string>(); // ממיר את תחום החיפוש לשם שבסיס הנתונים מכיר

        private string search_by(string str) // פונקציית ההמרה של החיפוש לפי
        {
            string a = "";
            search.TryGetValue(str, out a);
            return a;
        }

        private string To_ligth() // פונקצייה המאגדת את כל התאים המסומנים בנורות
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

        private void from_ligth(string light) // פונקצייה שמסמנת את התאים מהשורה בבסיס הנתנים
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

        public string out_vis_damage() // פןנקצייה שמחזירה מחרוזת שבה יש את כל התאים המסומנים בנזקים חיצוניים
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

        public void in_vis_damage(string str) // פונקצייה שמסמנת את הנזקים החיצוניים משורה בבסיס הנתונים
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

        public void choose(ComboBox a, ComboBox b, CheckedListBox c, ComboBox d) // בנתונים מראש COMBO BOX מילוי 
        {
            a.Items.Clear();
            b.Items.Clear();
            c.Items.Clear();
            d.Items.Clear();

            using (SqlConnection coni = new SqlConnection(con))
            {
                string qry = "SELECT code_costumer FROM costumer order by code_costumer ASC";
                string qry1 = "SELECT name_error FROM errors order by error_code ASC";
                string item;
                var cmd = new SqlCommand(qry, coni);
                var cmd1 = new SqlCommand(qry1, coni);
                cmd.CommandType = CommandType.Text;
                cmd1.CommandType = CommandType.Text;
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
                using (SqlDataReader objReader = cmd1.ExecuteReader())
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
                    string[] aas = new string[2];
                    Dictionary<string, Bitmap> lists = new Dictionary<string, Bitmap>();
                    DirectoryInfo e = new DirectoryInfo(@"PICK");//Assuming Test is your Folder
                    FileInfo[] Files = e.GetFiles("*.png"); //Getting Text files
                    foreach (FileInfo file in Files)
                    {
                        aas = file.Name.Split('.');
                        c.Items.Add(aas[0]);
                    }

                    d.Items.Add("מספר טופס");
                    d.Items.Add("קוד לקוח");
                    search["קוד לקוח"] = "code_costumer";
                    search["מספר טופס"] = "Num_of_costumer_form";
                }
                catch (Exception e) { }

            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cost_code.Text = "";
                in_vis_damage("");
                txt_dengerous.Checked = false;
                txt_form_code.Text = "";
                txt_knowledge.Text = "";
                for (int i = 0; i < txt_light.Items.Count; i++)
                {
                    txt_light.SetItemChecked(i, false);
                }
                txt_sound.Checked = false;
                txt_starter.Checked = false;
                txt_find.Text = "";
                txt_find_how.Text = "";
                txt_find_how.Enabled = false;
                txt_find.Enabled = false;
                txt_find_how.Visible = false;
                txt_find.Visible = false;
                log.Text = "cleaning succeed";
            }
            catch (Exception ee) { log.Text = "No cleaning was performed"; }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "DELETE FROM costumer_form WHERE Num_of_costumer_form = " + txt_form_code.Text;

                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "The form was deleted";
            }
            catch (Exception eee)
            {
                log.Text = "error! The form was not deleted";
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string queryString = "Select * from costumer_form";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("טופס לקוח");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
                log.Text = "";
            }
        }

        private string change_starter() // ממיר את הסימון של התנעה למחרוזת
        {
            string start;
            if (txt_starter.Checked == true)
                start = "true";
            else
                start = "false";
            return start;
        }

        private string change_voice() // ממיר את הסימון של שומע למחרוזת
        {
            string voice;
            if (txt_sound.Checked == true)
                voice = "true";
            else
                voice = "false";
            return voice;
        }

        private string change_dengerous() // ממיר את הסימון של מסוכן למחרוזת
        {
            string dengerous;
            if (txt_dengerous.Checked == true)
                dengerous = "true";
            else
                dengerous = "false";
            return dengerous;
        }

        private void click_event(object sender, DataGridViewCellEventArgs e)
        {
            string a = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["Num_of_costumer_form"].Value);
            }
            string queryString = "Select * from costumer_form where Num_of_costumer_form = " + a;
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
                    txt_cost_code.Text = dt.Rows[0]["code_costumer"].ToString();
                    txt_dengerous.Checked = Convert.ToBoolean(dt.Rows[0]["dengerous"].ToString());
                    txt_knowledge.Text = dt.Rows[0]["knowledge"].ToString();
                    from_ligth(dt.Rows[0]["light"].ToString());
                    txt_sound.Checked = Convert.ToBoolean(dt.Rows[0]["sound"].ToString());
                    txt_starter.Checked = Convert.ToBoolean(dt.Rows[0]["start"].ToString());
                    in_vis_damage(dt.Rows[0]["see"].ToString());
                    txt_form_code.Text = dt.Rows[0]["Num_of_costumer_form"].ToString();
                    log.Text = "the form selected appeared!";
                }
                catch (Exception ee)
                {
                    log.Text = "error!";
                }
            }
        }

        private void updatefields(object sender, EventArgs e)
        {
            choose(txt_cost_code, txt_knowledge, txt_light, txt_find_how);
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "UPDATE costumer_form SET start = '" + change_starter() + "', sound ='" + change_voice() +
                "' , dengerous = '" + change_dengerous() + "', code_costumer ='" + txt_cost_code.Text + "' , see ='" +
                out_vis_damage() + "', light ='" + To_ligth() + "' , knowledge ='" + txt_knowledge.Text + "' WHERE Num_of_costumer_form = " + txt_form_code.Text;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "The form was update";
            }
            catch (Exception ee) { log.Text = "error! the form was not update"; }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_form_code.Text == "")
            {
                try
                {
                    string queryString = "INSERT INTO costumer_form (start, sound, dengerous, knowledge, see, light, code_costumer)" +
                    "VALUES( '" + change_starter() + "', '" + change_voice() + "', '" + change_dengerous() + "', '" + txt_knowledge.Text + "', '" +
                    out_vis_damage() + "', '" + To_ligth() + "', " + txt_cost_code.Text + ")";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    clean_Click(sender, e);
                    log.Text = "the form saved";
                }
                catch (Exception eeee) { log.Text = "error! the form was not saved"; }
            }
            else
                log.Text = "error! the form was not saved";

        }

        private void txt_find_text_changed(object sender, EventArgs e)
        {
           string queryString = "Select * from costumer_form where " + search_by(txt_find_how.Text) + " = " + txt_find.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("טופס לקוח");

                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_cost_code.Text = dt.Rows[0]["code_costumer"].ToString();
                    txt_dengerous.Checked = Convert.ToBoolean(dt.Rows[0]["dengerous"].ToString());
                    txt_knowledge.Text = dt.Rows[0]["knowledge"].ToString();
                    from_ligth(dt.Rows[0]["light"].ToString());
                    txt_sound.Checked = Convert.ToBoolean(dt.Rows[0]["sound"].ToString());
                    txt_starter.Checked = Convert.ToBoolean(dt.Rows[0]["start"].ToString());
                    txt_form_code.Text = dt.Rows[0]["Num_of_costumer_form"].ToString();
                    in_vis_damage(dt.Rows[0]["see"].ToString());
                    log.Text = "the form found";
                }
                catch (Exception eee) { log.Text = "the form was not found"; }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            txt_find_how.Visible = true;
            txt_find_how.Enabled = true;
            txt_find.Enabled = true;
            txt_find.Visible = true;
        }

        private void txt_light_SelectedIndexChanged_1(object sender, EventArgs e) // פונקצייה שברגע לחיצה על נורות התמונה שלהם מופיע 
        {
            light_show.Image = new Bitmap(@"PICK/" + txt_light.Text + ".png");
            light_show.SizeMode = PictureBoxSizeMode.StretchImage;
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
