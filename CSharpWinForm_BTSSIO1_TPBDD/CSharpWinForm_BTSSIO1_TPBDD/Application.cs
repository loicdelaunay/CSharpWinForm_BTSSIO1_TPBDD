using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace CSharpWinForm_BTSSIO1_TPBDD
{
    public partial class Application : Form
    {
        private OracleConnection oracleConn;
        private Connection MaConnection = new Connection();
        public Application()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaConnection.Show();
        }
    }
}
