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
    public partial class errors : Form
    {
        public errors()
        {
            InitializeComponent();
        }
        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        private void clean_Click(object sender, EventArgs e)
        {
            txt_description.Text = "";
            txt_error_code.Text = "";
            txt_name_error.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE errors SET name_error = '" + txt_name_error.Text +
            "', description_ ='" + txt_description.Text + "' WHERE error_code =" + txt_error_code.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                log.Text = "malfunction update!";
            }
            catch (Exception ee) { log.Text = "error! the malfunction was not update"; }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_error_code.Text == "")
            {
                try
                {
                    string queryString = "INSERT INTO errors(name_error, description_)" +
                    " VALUES('" + txt_name_error.Text + "', '" + txt_description.Text + "')";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                    log.Text = "malfunction saved";
                }
                catch (Exception eeee)
                {
                    log.Text = "erorr, the malfunction was not saved";
                }
            }
            else
                log.Text = "erorr, the malfunction code already exist";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string queryString = "DELETE FROM errors WHERE error_code = " + txt_error_code.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "malfunction deleted";
            }
            catch(Exception ee)
            {
                log.Text = "error! the malfunction was not deleted";
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string queryString = "Select * from errors";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("תקלות");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
            log.Text = "";
        }

        private void click_event(object sender, DataGridViewCellEventArgs e)  // פעולה שמציגה מידע של שורה בטבלה ע"י לחיצה עליה
        {
            string a = "";
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    a = Convert.ToString(selectedRow.Cells["error_code"].Value);
                }
                string queryString = "Select * from errors where error_code = " + a + "";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("תקלות");
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_description.Text = dt.Rows[0]["description_"].ToString();
                    txt_error_code.Text = dt.Rows[0]["error_code"].ToString();
                    txt_name_error.Text = dt.Rows[0]["name_error"].ToString();
                }
                log.Text = "malfunction appeared";
            }
            catch (Exception eee)
            { log.Text = "error! the malfunction was not appeared"; }
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
