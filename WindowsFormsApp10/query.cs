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
    public partial class query : Form
    {
        public query(string a)
        {
            InitializeComponent();
            queryyuyu = a;
        }

        string queryyuyu;
        string con = "Data Source=DESKTOP-CJS9RE8;Initial Catalog=project;Integrated Security=True";

        private void load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(queryyuyu, connection);
                connection.Open();
                SqlDataAdapter datadp = new SqlDataAdapter(command);
                DataTable dt = new DataTable("שאילתה");
                datadp.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                datadp.Update(dt);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
