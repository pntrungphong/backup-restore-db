using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backup_Restore
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtserver.Text = Program.servername;
            txtserver.Enabled = false;

            txtlogin.Text = "sa";
            txtlogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Program.servername = txtserver.Text;
            Program.mlogin = txtlogin.Text;
            Program.password = txtpass.Text;

            if (Program.KetNoi() == 0) return;
            Program.conn.Close();

            frmMain formMain = new frmMain();
            formMain.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
