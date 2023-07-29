using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;


            this.Resize += new EventHandler(LoginForm_Resize);

            this.BackgroundImageLayout = ImageLayout.Stretch;


        }


        private void LoginForm_Resize(object sender, EventArgs e)
        {

            CentralPanel();

        }

        private void CentralPanel()
        {
            panel1.Location = new Point(
               (this.ClientSize.Width - panel1.Width) / 2,
               (this.ClientSize.Height - panel1.Height) / 2
           );

        }

        private void button1_Click(object sender, EventArgs e)
        {


            InputStudentForm myForm = new InputStudentForm();
            myForm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {


            InputDepartmentForm inputDepartmentForm = new InputDepartmentForm();
            inputDepartmentForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DepartmentListForm departmentForm = new DepartmentListForm();
            departmentForm.ShowDialog();
        }
    }
}
