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
    public partial class InputStudentForm : Form
    {
        public InputStudentForm()
        {
            InitializeComponent();

            this.Resize += new EventHandler(LoginForm_Resize);
         //   this.WindowState = FormWindowState.Maximized;


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
    }
}
