using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinForm_BTSSIO1_TPBDD
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        Application monApplication = new Application();

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string cnx = @"DATA SOURCE=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.10.2.10)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = SLAM)));User Id=" + txtBox_login.Text + ";Password=" + txtBox_mdp.Text + ";";
            MessageBox.Show(cnx, "test");
            monApplication.connectiondatebase(cnx);
        }
    }
}
