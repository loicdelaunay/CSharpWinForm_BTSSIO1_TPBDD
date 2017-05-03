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
        private OracleConnection oracleCnx;
        public Application()
        {
            InitializeComponent();
        }

        private Connection MaConnection = new Connection();

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaConnection.Show();
        }

        public void connectiondatebase(string cnx)
        {
            try
            {
                oracleCnx = new OracleConnection(cnx);
                oracleCnx.Open();
                MessageBox.Show("ça marche", "ça marche");
            }
            catch
            {
                MessageBox.Show("ça marche pas", "ça marche pas");
            }

        }
    }
}
