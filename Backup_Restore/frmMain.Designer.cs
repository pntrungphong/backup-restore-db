namespace Backup_Restore
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label backup_start_dateLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiGian = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ds = new Backup_Restore.DataSet();
            this.bdsDB = new System.Windows.Forms.BindingSource(this.components);
            this.taDB = new Backup_Restore.DataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new Backup_Restore.DataSetTableAdapters.TableAdapterManager();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView_DB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsListBackup = new System.Windows.Forms.BindingSource(this.components);
            this.taListBackup = new Backup_Restore.DataSetTableAdapters.DataTable1TableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtDB = new System.Windows.Forms.ToolStripTextBox();
            this.txtBanSaoLuu = new System.Windows.Forms.ToolStripTextBox();
            this.dataTable1GridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemDienGiai = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChinhSuaDienGiai = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaDienGiai = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_ListBackup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDevices = new System.Windows.Forms.BindingSource(this.components);
            this.taDevices = new Backup_Restore.DataSetTableAdapters.backup_devicesTableAdapter();
            this.checkINIT = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeStop = new DevExpress.XtraEditors.TimeEdit();
            this.dateStop = new DevExpress.XtraEditors.DateEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.labelDienGiai = new System.Windows.Forms.Label();
            backup_start_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListBackup)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1GridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ListBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // backup_start_dateLabel
            // 
            backup_start_dateLabel.AutoSize = true;
            backup_start_dateLabel.Location = new System.Drawing.Point(73, 35);
            backup_start_dateLabel.Name = "backup_start_dateLabel";
            backup_start_dateLabel.Size = new System.Drawing.Size(503, 32);
            backup_start_dateLabel.TabIndex = 28;
            backup_start_dateLabel.Text = "Ngày giờ để phục hồi tới thời điểm đó : ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.btnTaoDevice,
            this.btnXoaBackup,
            this.btnThoat,
            this.btnThoiGian});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaoLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoiGian, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoDevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaBackup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 0;
            this.btnSaoLuu.ImageOptions.Image = global::Backup_Restore.Properties.Resources.icons8_data_backup_16;
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 1;
            this.btnPhucHoi.ImageOptions.Image = global::Backup_Restore.Properties.Resources.icons8_database_restore_16;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnThoiGian
            // 
            this.btnThoiGian.Caption = "Tham số phục hồi theo thời gian";
            this.btnThoiGian.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btnThoiGian.Id = 7;
            this.btnThoiGian.ImageOptions.Image = global::Backup_Restore.Properties.Resources.icons8_clock_16;
            this.btnThoiGian.Name = "btnThoiGian";
            this.btnThoiGian.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoiGian_CheckedChanged);
            // 
            // btnTaoDevice
            // 
            this.btnTaoDevice.Caption = "Tạo Device sao lưu";
            this.btnTaoDevice.Id = 4;
            this.btnTaoDevice.ImageOptions.Image = global::Backup_Restore.Properties.Resources.icons8_save_16;
            this.btnTaoDevice.Name = "btnTaoDevice";
            this.btnTaoDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDevice_ItemClick);
            // 
            // btnXoaBackup
            // 
            this.btnXoaBackup.Caption = "Xóa bản Backup";
            this.btnXoaBackup.Id = 5;
            this.btnXoaBackup.ImageOptions.Image = global::Backup_Restore.Properties.Resources.icons8_delete_16;
            this.btnXoaBackup.Name = "btnXoaBackup";
            this.btnXoaBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaBackup_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = global::Backup_Restore.Properties.Resources.icons8_exit_16;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(2154, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1184);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2154, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1110);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2154, 74);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1110);
            // 
            // ds
            // 
            this.ds.DataSetName = "DataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDB
            // 
            this.bdsDB.DataMember = "databases";
            this.bdsDB.DataSource = this.ds;
            // 
            // taDB
            // 
            this.taDB.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Backup_Restore.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.bdsDB;
            this.databasesGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.databasesGridControl.Location = new System.Drawing.Point(0, 74);
            this.databasesGridControl.MainView = this.gridView_DB;
            this.databasesGridControl.MenuManager = this.barManager1;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(402, 1110);
            this.databasesGridControl.TabIndex = 5;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DB});
            // 
            // gridView_DB
            // 
            this.gridView_DB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.coldatabase_id});
            this.gridView_DB.GridControl = this.databasesGridControl;
            this.gridView_DB.Name = "gridView_DB";
            this.gridView_DB.OptionsView.ShowGroupPanel = false;
            this.gridView_DB.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_DB_FocusedRowChanged);
            // 
            // colname
            // 
            this.colname.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colname.AppearanceCell.Options.UseBackColor = true;
            this.colname.AppearanceHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.colname.AppearanceHeader.Options.UseBackColor = true;
            this.colname.AppearanceHeader.Options.UseTextOptions = true;
            this.colname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname.Caption = "Cơ sở dữ liệu";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 50;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 187;
            // 
            // coldatabase_id
            // 
            this.coldatabase_id.FieldName = "database_id";
            this.coldatabase_id.MinWidth = 50;
            this.coldatabase_id.Name = "coldatabase_id";
            this.coldatabase_id.Width = 187;
            // 
            // bdsListBackup
            // 
            this.bdsListBackup.DataMember = "DataTable1";
            this.bdsListBackup.DataSource = this.ds;
            // 
            // taListBackup
            // 
            this.taListBackup.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.txtDB,
            this.txtBanSaoLuu});
            this.fillToolStrip.Location = new System.Drawing.Point(402, 74);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1752, 47);
            this.fillToolStrip.TabIndex = 6;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(249, 44);
            this.dBNAMEToolStripLabel.Text = "Tên cơ sở dữ liệu:";
            // 
            // txtDB
            // 
            this.txtDB.Name = "txtDB";
            this.txtDB.ReadOnly = true;
            this.txtDB.Size = new System.Drawing.Size(400, 47);
            // 
            // txtBanSaoLuu
            // 
            this.txtBanSaoLuu.Name = "txtBanSaoLuu";
            this.txtBanSaoLuu.ReadOnly = true;
            this.txtBanSaoLuu.Size = new System.Drawing.Size(100, 47);
            // 
            // dataTable1GridControl
            // 
            this.dataTable1GridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.dataTable1GridControl.DataSource = this.bdsListBackup;
            this.dataTable1GridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataTable1GridControl.Location = new System.Drawing.Point(402, 121);
            this.dataTable1GridControl.MainView = this.gridView_ListBackup;
            this.dataTable1GridControl.MenuManager = this.barManager1;
            this.dataTable1GridControl.Name = "dataTable1GridControl";
            this.dataTable1GridControl.Size = new System.Drawing.Size(1752, 481);
            this.dataTable1GridControl.TabIndex = 6;
            this.dataTable1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ListBackup});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemDienGiai,
            this.btnChinhSuaDienGiai,
            this.btnXoaDienGiai});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(349, 142);
            // 
            // btnThemDienGiai
            // 
            this.btnThemDienGiai.Name = "btnThemDienGiai";
            this.btnThemDienGiai.Size = new System.Drawing.Size(348, 46);
            this.btnThemDienGiai.Text = "Thêm diễn giải";
            // 
            // btnChinhSuaDienGiai
            // 
            this.btnChinhSuaDienGiai.Name = "btnChinhSuaDienGiai";
            this.btnChinhSuaDienGiai.Size = new System.Drawing.Size(348, 46);
            this.btnChinhSuaDienGiai.Text = "Chỉnh sửa diễn giải";
            // 
            // btnXoaDienGiai
            // 
            this.btnXoaDienGiai.Name = "btnXoaDienGiai";
            this.btnXoaDienGiai.Size = new System.Drawing.Size(348, 46);
            this.btnXoaDienGiai.Text = "Xóa diễn giải";
            // 
            // gridView_ListBackup
            // 
            this.gridView_ListBackup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView_ListBackup.GridControl = this.dataTable1GridControl;
            this.gridView_ListBackup.Name = "gridView_ListBackup";
            this.gridView_ListBackup.OptionsView.ShowGroupPanel = false;
            this.gridView_ListBackup.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_ListBackup_FocusedRowChanged);
            // 
            // colposition
            // 
            this.colposition.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colposition.AppearanceCell.Options.UseBackColor = true;
            this.colposition.AppearanceCell.Options.UseTextOptions = true;
            this.colposition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.colposition.AppearanceHeader.Options.UseBackColor = true;
            this.colposition.AppearanceHeader.Options.UseTextOptions = true;
            this.colposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colposition.Caption = "Bản sao lưu thứ #";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 50;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.ReadOnly = true;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 250;
            // 
            // colname1
            // 
            this.colname1.AppearanceCell.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colname1.AppearanceCell.Options.UseBackColor = true;
            this.colname1.AppearanceCell.Options.UseTextOptions = true;
            this.colname1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname1.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.colname1.AppearanceHeader.Options.UseBackColor = true;
            this.colname1.AppearanceHeader.Options.UseTextOptions = true;
            this.colname1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname1.Caption = "Diễn giải";
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 50;
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.ReadOnly = true;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 485;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colbackup_start_date.AppearanceCell.Options.UseBackColor = true;
            this.colbackup_start_date.AppearanceCell.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.colbackup_start_date.AppearanceHeader.Options.UseBackColor = true;
            this.colbackup_start_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colbackup_start_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbackup_start_date.Caption = "Ngày giờ sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 50;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.ReadOnly = true;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 485;
            // 
            // coluser_name
            // 
            this.coluser_name.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.coluser_name.AppearanceCell.Options.UseBackColor = true;
            this.coluser_name.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.coluser_name.AppearanceHeader.Options.UseBackColor = true;
            this.coluser_name.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_name.Caption = "User sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 50;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.ReadOnly = true;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 300;
            // 
            // bdsDevices
            // 
            this.bdsDevices.DataMember = "backup_devices";
            this.bdsDevices.DataSource = this.ds;
            // 
            // taDevices
            // 
            this.taDevices.ClearBeforeFill = true;
            // 
            // checkINIT
            // 
            this.checkINIT.AutoSize = true;
            this.checkINIT.Location = new System.Drawing.Point(832, 678);
            this.checkINIT.Name = "checkINIT";
            this.checkINIT.Size = new System.Drawing.Size(823, 36);
            this.checkINIT.TabIndex = 28;
            this.checkINIT.Text = "Xóa tất cả các bản sao cũ trong File trước khi sao lưu bản mới";
            this.checkINIT.UseVisualStyleBackColor = true;
            this.checkINIT.CheckedChanged += new System.EventHandler(this.checkINIT_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeStop);
            this.panel1.Controls.Add(this.dateStop);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(backup_start_dateLabel);
            this.panel1.Location = new System.Drawing.Point(662, 810);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 300);
            this.panel1.TabIndex = 36;
            // 
            // timeStop
            // 
            this.timeStop.EditValue = new System.DateTime(2020, 4, 15, 0, 0, 0, 0);
            this.timeStop.Location = new System.Drawing.Point(838, 27);
            this.timeStop.MenuManager = this.barManager1;
            this.timeStop.Name = "timeStop";
            this.timeStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeStop.Size = new System.Drawing.Size(250, 50);
            this.timeStop.TabIndex = 40;
            // 
            // dateStop
            // 
            this.dateStop.EditValue = null;
            this.dateStop.Location = new System.Drawing.Point(582, 27);
            this.dateStop.MenuManager = this.barManager1;
            this.dateStop.Name = "dateStop";
            this.dateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Size = new System.Drawing.Size(250, 50);
            this.dateStop.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1009, 129);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Hướng dẫn: Ngày giờ ta nhập vào là thời điểm ta muốn phục hồi cơ sở dữ liệu về đó" +
    ".Thời điểm này phải sau thời điểm đã sao lưu mà ta đã chọn ở trên lưới, và trước" +
    " thời điểm hiện tại ít nhất là 1 phút";
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(949, 744);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(801, 38);
            this.txtDienGiai.TabIndex = 41;
            // 
            // labelDienGiai
            // 
            this.labelDienGiai.AutoSize = true;
            this.labelDienGiai.Location = new System.Drawing.Point(730, 750);
            this.labelDienGiai.Name = "labelDienGiai";
            this.labelDienGiai.Size = new System.Drawing.Size(213, 32);
            this.labelDienGiai.TabIndex = 42;
            this.labelDienGiai.Text = "Nhập diễn giải: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2154, 1184);
            this.Controls.Add(this.labelDienGiai);
            this.Controls.Add(this.txtDienGiai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkINIT);
            this.Controls.Add(this.dataTable1GridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.databasesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu - Phục hồi cơ sở dữ liệu trong SQL SERVER";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListBackup)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1GridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ListBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaoDevice;
        private DevExpress.XtraBars.BarButtonItem btnXoaBackup;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarCheckItem btnThoiGian;
        private System.Windows.Forms.BindingSource bdsDB;
        private DataSet ds;
        private DataSetTableAdapters.databasesTableAdapter taDB;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dBNAMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtDB;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DB;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
        private System.Windows.Forms.BindingSource bdsListBackup;
        private DataSetTableAdapters.DataTable1TableAdapter taListBackup;
        private DevExpress.XtraGrid.GridControl dataTable1GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ListBackup;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.ToolStripTextBox txtBanSaoLuu;
        private System.Windows.Forms.BindingSource bdsDevices;
        private DataSetTableAdapters.backup_devicesTableAdapter taDevices;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TimeEdit timeStop;
        private DevExpress.XtraEditors.DateEdit dateStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkINIT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemDienGiai;
        private System.Windows.Forms.ToolStripMenuItem btnChinhSuaDienGiai;
        private System.Windows.Forms.ToolStripMenuItem btnXoaDienGiai;
        private System.Windows.Forms.Label labelDienGiai;
        private System.Windows.Forms.TextBox txtDienGiai;
    }
}