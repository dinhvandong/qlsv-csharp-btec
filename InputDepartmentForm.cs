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
    public partial class InputDepartmentForm : Form
    {
        public InputDepartmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string makhoa = tbx_makhoa.Text;
            string tenkhoa = tbx_tenkhoa.Text;  
            string sodienthoai = tbx_sodienthoai.Text;

            LoadData(makhoa, tenkhoa, sodienthoai);

        }


        public void LoadData(String makhoa, String tenkhoa, String sodienthoai)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ThucTap;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT_KHOA", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NAME", makhoa));
                    cmd.Parameters.Add(new SqlParameter("@DETAIL", tenkhoa));
                    cmd.Parameters.Add(new SqlParameter("@PHONE", sodienthoai));

                    con.Open();
                    cmd.ExecuteNonQuery();
                   /* DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);*/
                  /*  dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
                }
            }
        }

    }
}
