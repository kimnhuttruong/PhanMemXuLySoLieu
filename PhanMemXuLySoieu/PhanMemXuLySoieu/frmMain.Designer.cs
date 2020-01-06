namespace PhanMemXuLySoieu
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
            this.btnFileText = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKiTu = new DevExpress.XtraEditors.TextEdit();
            this.btnChuyenFile = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridLookup = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLook = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSaveDSLoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveDS = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuLy = new DevExpress.XtraEditors.SimpleButton();
            this.btnFileExcel = new DevExpress.XtraEditors.ButtonEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.gridLoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PhanMemXuLySoieu.frmWait), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.btnFileText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileText
            // 
            this.btnFileText.Location = new System.Drawing.Point(56, 37);
            this.btnFileText.Name = "btnFileText";
            this.btnFileText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnFileText.Properties.Click += new System.EventHandler(this.btnFileText_Properties_Click);
            this.btnFileText.Size = new System.Drawing.Size(591, 20);
            this.btnFileText.TabIndex = 0;
            this.btnFileText.EditValueChanged += new System.EventHandler(this.btnFileText_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kí Tự Phân Chia";
            // 
            // txtKiTu
            // 
            this.txtKiTu.Location = new System.Drawing.Point(93, 69);
            this.txtKiTu.Name = "txtKiTu";
            this.txtKiTu.Size = new System.Drawing.Size(38, 20);
            this.txtKiTu.TabIndex = 2;
            // 
            // btnChuyenFile
            // 
            this.btnChuyenFile.Location = new System.Drawing.Point(173, 67);
            this.btnChuyenFile.Name = "btnChuyenFile";
            this.btnChuyenFile.Size = new System.Drawing.Size(118, 23);
            this.btnChuyenFile.TabIndex = 3;
            this.btnChuyenFile.Text = "Preview";
            this.btnChuyenFile.Click += new System.EventHandler(this.btnChuyenFile_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnChuyenFile);
            this.groupControl1.Controls.Add(this.btnFileText);
            this.groupControl1.Controls.Add(this.txtKiTu);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(652, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chuyển File";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridLookup);
            this.groupControl2.Controls.Add(this.gridLook);
            this.groupControl2.Controls.Add(this.btnSaveDSLoi);
            this.groupControl2.Controls.Add(this.btnSaveDS);
            this.groupControl2.Controls.Add(this.btnXuLy);
            this.groupControl2.Controls.Add(this.btnFileExcel);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Location = new System.Drawing.Point(655, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(526, 100);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Lọc Dữ Liệu File Excel";
            // 
            // gridLookup
            // 
            this.gridLookup.Location = new System.Drawing.Point(6, 40);
            this.gridLookup.MainView = this.gridView2;
            this.gridLookup.Name = "gridLookup";
            this.gridLookup.Size = new System.Drawing.Size(0, 0);
            this.gridLookup.TabIndex = 5;
            this.gridLookup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridLookup;
            this.gridView2.Name = "gridView2";
            // 
            // gridLook
            // 
            this.gridLook.EditValue = "";
            this.gridLook.Location = new System.Drawing.Point(86, 70);
            this.gridLook.Name = "gridLook";
            this.gridLook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLook.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLook.Size = new System.Drawing.Size(257, 20);
            this.gridLook.TabIndex = 4;
            this.gridLook.EditValueChanged += new System.EventHandler(this.gridLook_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnSaveDSLoi
            // 
            this.btnSaveDSLoi.Location = new System.Drawing.Point(430, 68);
            this.btnSaveDSLoi.Name = "btnSaveDSLoi";
            this.btnSaveDSLoi.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDSLoi.TabIndex = 3;
            this.btnSaveDSLoi.Text = "Save DS Lỗi";
            this.btnSaveDSLoi.Click += new System.EventHandler(this.btnSaveDSLoi_Click);
            // 
            // btnSaveDS
            // 
            this.btnSaveDS.Location = new System.Drawing.Point(349, 68);
            this.btnSaveDS.Name = "btnSaveDS";
            this.btnSaveDS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDS.TabIndex = 3;
            this.btnSaveDS.Text = "Save DS";
            this.btnSaveDS.Click += new System.EventHandler(this.btnSaveDS_Click);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(5, 67);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 23);
            this.btnXuLy.TabIndex = 3;
            this.btnXuLy.Text = "Xử Lý";
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnFileExcel
            // 
            this.btnFileExcel.Location = new System.Drawing.Point(61, 37);
            this.btnFileExcel.Name = "btnFileExcel";
            this.btnFileExcel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnFileExcel.Properties.Click += new System.EventHandler(this.buttonEdit2_Properties_Click);
            this.btnFileExcel.Size = new System.Drawing.Size(459, 20);
            this.btnFileExcel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "File";
            // 
            // gridLoc
            // 
            this.gridLoc.Location = new System.Drawing.Point(2, 108);
            this.gridLoc.MainView = this.gridView1;
            this.gridLoc.Name = "gridLoc";
            this.gridLoc.Size = new System.Drawing.Size(1179, 407);
            this.gridLoc.TabIndex = 2;
            this.gridLoc.UseEmbeddedNavigator = true;
            this.gridLoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridLoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 518);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridLoc);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMain";
            this.Text = "Phần Mền Xử Lý Số Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.btnFileText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit btnFileText;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKiTu;
        private DevExpress.XtraEditors.SimpleButton btnChuyenFile;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXuLy;
        private DevExpress.XtraGrid.GridControl gridLoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ButtonEdit btnFileExcel;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GridLookUpEdit gridLook;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnSaveDS;
        private DevExpress.XtraEditors.SimpleButton btnSaveDSLoi;
        private DevExpress.XtraGrid.GridControl gridLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}