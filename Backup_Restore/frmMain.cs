using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Restore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.taDevices.Connection.ConnectionString = Program.connstr;
            this.taDevices.Fill(this.ds.backup_devices);

            this.taDB.Connection.ConnectionString = Program.connstr;
            this.taDB.Fill(this.ds.databases);

            dateStop.DateTime = DateTime.Now.Date;
            timeStop.Time = DateTime.Now;
        }

        private void loadbackup()
        {
            if (txtDB.Text.Trim() == "") return;

            try
            {
                this.taListBackup.Connection.ConnectionString = Program.connstr;
                this.taListBackup.Fill(this.ds.DataTable1, txtDB.Text);

                if (bdsListBackup.Count == 0)
                {
                    txtBanSaoLuu.Text = "0";

                    btnPhucHoi.Enabled = btnThoiGian.Enabled = btnThoiGian.Checked = btnXoaBackup.Enabled = false;
                    checkINIT.Visible = false;
                    txtDienGiai.Visible = labelDienGiai.Visible = false;
                }
                else
                {
                    txtBanSaoLuu.Text = ((DataRowView)bdsListBackup[0])["position"].ToString();

                    checkINIT.Visible = true;
                    txtDienGiai.Visible = labelDienGiai.Visible = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private bool KtraDeviceTrenView(string name)
        {
            for (int index = 0; index < bdsDevices.Count; index++)
            {
                if (((DataRowView)bdsDevices[index])["name"].ToString().Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void disable()
        {
            btnSaoLuu.Enabled = btnPhucHoi.Enabled = btnThoiGian.Enabled = btnXoaBackup.Enabled = false;
            checkINIT.Enabled = false; txtDienGiai.Enabled = labelDienGiai.Enabled = false;
            btnThoiGian.Checked = false;
            checkINIT.Checked = false;
            panel1.Visible = true;
            btnTaoDevice.Enabled = btnThoat.Enabled = true;
        }

        private void enable()
        {
            btnSaoLuu.Enabled = btnPhucHoi.Enabled = btnThoiGian.Enabled = btnThoat.Enabled = btnXoaBackup.Enabled = true;
            btnTaoDevice.Enabled = false;
            btnThoiGian.Checked = false;
            checkINIT.Checked = false;
            checkINIT.Enabled = true;  txtDienGiai.Enabled = labelDienGiai.Enabled = true;
            panel1.Visible = false;
        }

        private void gridView_DB_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtDB.Text = ((DataRowView)bdsDB[bdsDB.Position])["name"].ToString();
                string temp = "DEVICE_" + txtDB.Text.Trim();
                if (KtraDeviceTrenView(temp))
                {
                    enable();

                    dataTable1GridControl.DataSource = bdsListBackup;
                    loadbackup();
                }
                else
                {
                    disable();
                    panel1.Visible = false;

                    dataTable1GridControl.DataSource = null;
                    txtBanSaoLuu.Text = "0";
                }
            }
            catch (Exception)
            {
                txtDB.Text = "";
            }
        }

        private void gridView_ListBackup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsListBackup.Position == -1 || bdsListBackup.Count == 0 || dataTable1GridControl.DataSource == null)
            {
                txtBanSaoLuu.Text = "0";
            }
            else
            {
                txtBanSaoLuu.Text = ((DataRowView)bdsListBackup[bdsListBackup.Position])["position"].ToString();
            }
        }

        private void btnTaoDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh;
            strLenh = "EXEC Sp_addumpdevice 'disk' , 'DEVICE_" + txtDB.Text.Trim() + "','" + Program.strDefaultPath + "\\DEVICE_" + txtDB.Text.Trim() + ".bak'";
            int err = Program.ExecSqlNonQuery(strLenh, Program.connstr, "Loi tao Device backup cho csdl" + txtDB.Text);
            if (err == 0)
            {
                btnPhucHoi.Enabled = btnTaoDevice.Enabled = false;
                btnSaoLuu.Enabled = true;

                this.taDevices.Fill(this.ds.backup_devices);

                MessageBox.Show("Đã tạo Device thành công !");
            }
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strBackup;
            if (txtDB.Text.Trim() == "") return;

            strBackup = "BACKUP DATABASE " + txtDB.Text.Trim() + " TO " + "DEVICE_" + txtDB.Text.Trim() + " WITH NAME = " + "'"+txtDienGiai.Text.Trim()+"'";
            if (checkINIT.Checked == true)
            {
                if (MessageBox.Show("Bạn thật sự muốn xóa tất cả các bản sao lưu cũ ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    strBackup = strBackup + " ,INIT"; 
                }
            }
            
            int err = Program.ExecSqlNonQuery(strBackup, Program.connstr, "");
            if (err == 1)
            {
                MessageBox.Show("Lỗi Backup cơ sở dữ liệu !" + txtDB.Text);
                return;
            }

            MessageBox.Show("Đã Backup xong cơ sở dữ liệu !");
            loadbackup();
            txtDienGiai.Text = " ";
        }

        private void btnThoiGian_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(btnThoiGian.Checked)
            {
                panel1.Visible = true;

                btnTaoDevice.Enabled = btnSaoLuu.Enabled = btnXoaBackup.Enabled = false;
                checkINIT.Enabled = false; txtDienGiai.Enabled = labelDienGiai.Enabled = false;
            } 
            else
            {
                panel1.Visible = false;

                btnTaoDevice.Enabled = false;
                btnSaoLuu.Enabled = btnXoaBackup.Enabled = true;
                checkINIT.Enabled = true; txtDienGiai.Enabled = labelDienGiai.Enabled = true;
            }
        }
                
        private void checkINIT_CheckedChanged(object sender, EventArgs e)
        {
            btnPhucHoi.Enabled = btnThoiGian.Enabled = btnXoaBackup.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsListBackup.Count == 0)
            {
                //MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                //return;
                btnPhucHoi.Enabled = false;
            }

            if (txtBanSaoLuu.Text == "0")
            {
                //MessageBox.Show("Chưa chọn bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                //return;
                btnPhucHoi.Enabled = false;
            }

            int err;
            String strRestore;
            strRestore = "ALTER DATABASE " + txtDB.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + " USE tempdb ";

            if (btnThoiGian.Checked == false)
            {
                string temp = "DEVICE_" + txtDB.Text.Trim();
                strRestore += "RESTORE DATABASE " + txtDB.Text + " FROM " + temp + " WITH FILE= " + txtBanSaoLuu.Text + " , REPLACE " +
                              "ALTER DATABASE " + txtDB.Text + " SET MULTI_USER ";
                err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                if (err != 0)
                {
                    MessageBox.Show("Lỗi phục hồi cơ sở dữ liệu !" + txtDB.Text);
                    return;
                }
            }

            else
            {
                DateTime ngaygioBK = (DateTime)((DataRowView)bdsListBackup[bdsListBackup.Position])["backup_start_date"];

                string strNgaygioStopat = dateStop.Text.Trim() + " " + timeStop.Text.Trim();
                DateTime NgaygioStopat = DateTime.Parse(strNgaygioStopat);

                if (NgaygioStopat < ngaygioBK)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu đã chọn.", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                DateTime timeNow = (DateTime.Now).AddMinutes(-3);
                if (NgaygioStopat > timeNow)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại.", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                string temp = "DEVICE_" + txtDB.Text.Trim();
                strRestore += "BACKUP LOG " + txtDB.Text + " TO DISK = '" + Program.strDefaultPath + "/" + txtDB.Text + ".trn' WITH INIT, NORECOVERY;"
                            + " USE tempdb SET DATEFORMAT YMD "
                            + " RESTORE DATABASE " + txtDB.Text + " FROM " + temp + " WITH FILE = " + txtBanSaoLuu.Text + ", NORECOVERY"
                            + " RESTORE DATABASE " + txtDB.Text + " FROM DISK = '" + Program.strDefaultPath + "/" + txtDB.Text + ".trn' WITH STOPAT = '" + NgaygioStopat + "', RECOVERY"
                            + " ALTER DATABASE " + txtDB.Text + " SET MULTI_USER ";

                err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                if (err != 0)
                {
                    MessageBox.Show("Lỗi phục hồi cơ sở dữ liệu !" + txtDB.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (err == 0)
            {
                MessageBox.Show("Đã phục hồi xong CSDL");
                Program.KetNoi();
            }
        }

        private void btnXoaBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int err;
            String strRestore;
            strRestore = "EXECUTE master.dbo.xp_delete_file 0,N'" + Program.strDefaultPath + "\\DEVICE_" + txtDB.Text.Trim() + ".bak'";

            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "");

            if(err == 0)
            {
                MessageBox.Show("Đã xóa xong file Backup");

                //bdsListBackup.DataSource = null;
                this.taListBackup.Fill(this.ds.DataTable1, txtDB.Text);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
