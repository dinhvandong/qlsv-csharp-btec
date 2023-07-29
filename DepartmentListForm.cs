using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_Database
{
    public partial class DepartmentListForm : Form
    {
        public DepartmentListForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // this.WindowState = FormWindowState.Minimized;
            this.MaximizeBox = false;
            // Set the FlowDirection to TopDown
            // panel1.MaximumSize = new Size(this.Width, 0);
            // panel1.Dock = DockStyle.Fill;
            dataGridView1.Dock = DockStyle.Fill;

            LoadData();
        }



        public void LoadData()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ThucTap;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SelectAllDepartment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void DepartmentListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
