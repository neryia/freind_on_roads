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
    public partial class Volunteers : Form
    {
        public Volunteers()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        string [] txt_phone = new string[2]; // פלאפון מורכב מקידומת ומספר

        public void phone_number()// COMBOBOX הוספת מידע ל 
        {
            txt_first_phone.Items.Add("054-");
            txt_first_phone.Items.Add("052-");
            txt_first_phone.Items.Add("053-");
            txt_first_phone.Items.Add("058-");
            txt_first_phone.Items.Add("050-");
        }

        private void load(object sender, EventArgs e)
        {
            txtstartdate.MaxSelectionCount = 1;
            txtstartdate.MaxDate = DateTime.Now;
            phone_number();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clean_Click(sender, e);
            string a = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                a = Convert.ToString(selectedRow.Cells["Id"].Value);
            }
            string queryString = "Select * from Volunteers where " + a + "= Id";
            using (SqlConnection connection = new SqlConnection(con))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("כוננים");
                try
                {
                    datadp.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    datadp.Update(dt);
                    txt_phone = dt.Rows[0]["phone"].ToString().Split('-');
                    txt_first_phone.Text = txt_phone[0] + "-";
                    txt_last_phone.Text = txt_phone[1];
                    txtstatus.Checked = Convert.ToBoolean(dt.Rows[0]["status_availability"].ToString());
                    txtfirstname.Text = dt.Rows[0]["first_name"].ToString();
                    txtId.Text = dt.Rows[0]["Id"].ToString();
                    txtlastname.Text = dt.Rows[0]["last_name"].ToString();
                    txtcoordinatex.Text = dt.Rows[0]["coordiant_x"].ToString();
                    txtcoordinatey.Text = dt.Rows[0]["coordiant_y"].ToString();
                    txtstartdate.SetDate(DateTime.Parse(dt.Rows[0]["start_date_"].ToString()));
                    txt_code_val.Text = dt.Rows[0]["code_Volunteers"].ToString();
                    log.Text = "Volunteer appeared!";
                }
                catch (Exception eee)
                { log.Text = "error!!"; }
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string queryString = "Select * from Volunteers";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("כוננים");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length != 9)
            {
                log.Text = "error Id";
                return;
            }
            if (txt_last_phone.Text.Length != 11)
            {
                log.Text = "error phone";
                return;
            }
            try
            {
                int txtstatus;
                if (this.txtstatus.Checked == true)
                    txtstatus = 1;
                else
                    txtstatus = 0;
                string queryString = "INSERT INTO Volunteers (phone, status_availability, first_name, Id, last_name, coordiant_x, coordiant_y, start_date_) " +
                    "VALUES( '" + txt_first_phone.Text + txt_last_phone.Text + "', " + txtstatus + " , '" + txtfirstname.Text + "' ," + txtId.Text + " , '" 
                    + txtlastname.Text + "', '" + txtcoordinatey.Text + "', '" + txtcoordinatex.Text + "', '" + txtstartdate.SelectionRange.Start.ToString() + "')";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                log.Text = "the Volunteer saved!";
            }
            catch (Exception eeee)
            {
                log.Text = "erorr, the Volunteer not save";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkupdate(object sender, EventArgs e)
        {
            if (txt_code_val.Text != "")
            {
                string queryString = "Select * from Volunteers where " + txt_code_val.Text + "= Code_Volunteers";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataAdapter datadp = new SqlDataAdapter(command);
                    DataTable dt = new DataTable("כוננים");
                    try
                    {
                        datadp.Fill(dt);
                        dataGridView1.DataSource = dt.DefaultView;
                        datadp.Update(dt);
                        txt_phone = dt.Rows[0]["phone"].ToString().Split('-');
                        txt_first_phone.Text = txt_phone[0] + "-";
                        txt_last_phone.Text = txt_phone[1]; txtstatus.Checked = Convert.ToBoolean(dt.Rows[0]["status_availability"].ToString());
                        txtfirstname.Text = dt.Rows[0]["first_name"].ToString();
                        txtId.Text = dt.Rows[0]["Id"].ToString();
                        txtlastname.Text = dt.Rows[0]["last_name"].ToString();
                        txtcoordinatex.Text = dt.Rows[0]["coordiant_x"].ToString();
                        txtcoordinatey.Text = dt.Rows[0]["coordiant_y"].ToString();
                        txtstartdate.SetDate(DateTime.Parse(dt.Rows[0]["start_date_"].ToString()));
                    }
                    catch (Exception eee) { }
                    }
                }
            }

        private void update_Click(object sender, EventArgs e)
        {
            int txtstatus;
            if (this.txtstatus.Checked == true)
                txtstatus = 1;
            else
                txtstatus = 0;
            if (txtId.Text.Length != 9)
            {
                log.Text = "error Id";
                return;
            }
            if (txt_last_phone.Text.Length != 11)
            {
                log.Text = "error phone";
                return;
            }
            string queryString = "UPDATE Volunteers SET phone = '" + txt_first_phone.Text + txt_last_phone.Text + " ', status_availability = " + txtstatus + 
                " , first_name = '" + txtfirstname.Text + "' , Id = " + txtId.Text + "," +
                " last_name = '" + txtlastname.Text + "', coordiant_x = '" + txtcoordinatey.Text + "' ,coordiant_y = '" + txtcoordinatex.Text +
                "' WHERE code_Volunteers = " + txt_code_val.Text;

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    log.Text = "the details of Volunteer number " + txt_code_val.Text;
                }      
                catch (Exception ee) { }
            }

        }

        private void idcheck(object sender, EventArgs e) // בדיקת תקינות מייל 
        {
            if (txtId.Text.Length != 9)
                logid.Text = "ID Length error";
            else
                logid.Text = "";
        }

        private void clean_Click(object sender, EventArgs e)
        {
            txt_last_phone.Text = "";
            txtstatus.Checked = false;
            txtfirstname.Text = "";
            txtId.Text = "";
            txtlastname.Text = "";
            txt_first_phone.Text = "";
            txtcoordinatex.Text = "";
            txtcoordinatey.Text = "";
            txt_code_val.Text = "";
            txtstartdate.SetDate(txtstartdate.TodayDate);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string queryString = " DELETE FROM Volunteers WHERE code_Volunteers = " + txt_code_val.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                clean_Click(sender, e);
                log.Text = "the Volunteer was deleted";
            }
            catch (Exception ee) { log.Text = "error! the volunteer wasn't deleted"; }
        }

        private void phone_check(object sender, EventArgs e)// בדיקת תקינות פלאפון
        {
            if (txt_last_phone.Text.Length != 7)
                logphone.Text = "error lengh";
            else
                logphone.Text = "";
        }

        private void prof_Click(object sender, EventArgs e)
        {
            if (txt_code_val.Text == "")
                new Form2(0).Show();
            else
                new Form2(int.Parse(txt_code_val.Text.ToString())).Show();
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
