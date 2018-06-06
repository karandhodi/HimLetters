namespace HimLetters
{
    partial class MainForm
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
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.menuItemTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaskSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuStrip = new System.Windows.Forms.Panel();
            this.panelTblLayout = new System.Windows.Forms.Panel();
            this.tblLayoutPanelMainFormLower = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrintLettersFor = new System.Windows.Forms.Label();
            this.dataGridViewPhysicians = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Paper = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Physician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPhysiciansExclude = new System.Windows.Forms.DataGridView();
            this.PhysicianExclude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.lblDenotePhysician = new System.Windows.Forms.Label();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripItemReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDoNotPrint = new System.Windows.Forms.Label();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.tblLayoutPanelMainFormUpper = new System.Windows.Forms.TableLayoutPanel();
            this.lblLetterType = new System.Windows.Forms.Label();
            this.lblLetterTypeAsterisk = new System.Windows.Forms.Label();
            this.cmbBoxLetterType = new System.Windows.Forms.ComboBox();
            this.lblLetterDetails = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.listViewDocumentType = new System.Windows.Forms.ListView();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblFacilityAsterisk = new System.Windows.Forms.Label();
            this.cmbBoxFacility = new System.Windows.Forms.ComboBox();
            this.btnRetrievePhysicians = new System.Windows.Forms.Button();
            this.btnDistributeLetters = new System.Windows.Forms.Button();
            this.panelLetterType = new System.Windows.Forms.Panel();
            this.tblLayoutPanelLetterType = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxPrintForPhysicians = new System.Windows.Forms.CheckBox();
            this.lblPrintForPhysicians = new System.Windows.Forms.Label();
            this.checkBoxPrintDeficiencies = new System.Windows.Forms.CheckBox();
            this.lblPrintDeficiencies = new System.Windows.Forms.Label();
            this.checkBoxPrintExpectedDeficiencies = new System.Windows.Forms.CheckBox();
            this.lblPrintExpectedDeficiencies = new System.Windows.Forms.Label();
            this.checkBoxPrintPhysician = new System.Windows.Forms.CheckBox();
            this.lblPrintPhysician = new System.Windows.Forms.Label();
            this.checkBoxAllocatedCharts = new System.Windows.Forms.CheckBox();
            this.lblAllocatedCharts = new System.Windows.Forms.Label();
            this.lblSortPrinted = new System.Windows.Forms.Label();
            this.radioBtnSortProviderName = new System.Windows.Forms.RadioButton();
            this.lblSortProviderName = new System.Windows.Forms.Label();
            this.radioBtnSortMedicalService = new System.Windows.Forms.RadioButton();
            this.lblSortMedicalService = new System.Windows.Forms.Label();
            this.lblGroupExpected = new System.Windows.Forms.Label();
            this.panelRadioBtnGroup = new System.Windows.Forms.Panel();
            this.tblLayoutPanelRadioBtn = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnProviderName = new System.Windows.Forms.RadioButton();
            this.radioBtnEncounter = new System.Windows.Forms.RadioButton();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblEncounter = new System.Windows.Forms.Label();
            this.tblLayoutPanelLetterDetails = new System.Windows.Forms.TableLayoutPanel();
            this.panelLetterDetailsFirst = new System.Windows.Forms.Panel();
            this.tblLayoutPanelLetterDetailsFirst = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeficientDayRange = new System.Windows.Forms.Label();
            this.lblIncludeDocuments = new System.Windows.Forms.Label();
            this.lblChartOnHold = new System.Windows.Forms.Label();
            this.lblPhysiciansToInclude = new System.Windows.Forms.Label();
            this.lblChartsToInclude = new System.Windows.Forms.Label();
            this.lblDeficienciesToInclude = new System.Windows.Forms.Label();
            this.lblIncludeVisits = new System.Windows.Forms.Label();
            this.panelLetterDetailsSecond = new System.Windows.Forms.Panel();
            this.tblLayoutPanelLetterDetailsSecond = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeficiencyDayRangeValue = new System.Windows.Forms.Label();
            this.lblIncludeDocumentsValue = new System.Windows.Forms.Label();
            this.lblChartOnHoldValue = new System.Windows.Forms.Label();
            this.lblPhysiciansToIncludeValue = new System.Windows.Forms.Label();
            this.lblChartsToIncludeValue = new System.Windows.Forms.Label();
            this.lblDeficienciesToIncludeValue = new System.Windows.Forms.Label();
            this.lblIncludeVisitsValue = new System.Windows.Forms.Label();
            this.printDocumentPrintList = new System.Drawing.Printing.PrintDocument();
            this.printDocumentDistributeLetters = new System.Drawing.Printing.PrintDocument();
            this.printDocumentDistributeLettersMenu = new System.Drawing.Printing.PrintDocument();
            this.menuStripMainForm.SuspendLayout();
            this.panelMenuStrip.SuspendLayout();
            this.panelTblLayout.SuspendLayout();
            this.tblLayoutPanelMainFormLower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhysicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhysiciansExclude)).BeginInit();
            this.statusStripMainForm.SuspendLayout();
            this.tblLayoutPanelMainFormUpper.SuspendLayout();
            this.panelLetterType.SuspendLayout();
            this.tblLayoutPanelLetterType.SuspendLayout();
            this.panelRadioBtnGroup.SuspendLayout();
            this.tblLayoutPanelRadioBtn.SuspendLayout();
            this.tblLayoutPanelLetterDetails.SuspendLayout();
            this.panelLetterDetailsFirst.SuspendLayout();
            this.tblLayoutPanelLetterDetailsFirst.SuspendLayout();
            this.panelLetterDetailsSecond.SuspendLayout();
            this.tblLayoutPanelLetterDetailsSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTask,
            this.menuItemEdit,
            this.menuItemView,
            this.menuItemHelp});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMainForm.Size = new System.Drawing.Size(1571, 42);
            this.menuStripMainForm.TabIndex = 2;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // menuItemTask
            // 
            this.menuItemTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPrint,
            this.menuItemTaskSeparator,
            this.menuItemExit});
            this.menuItemTask.Name = "menuItemTask";
            this.menuItemTask.Size = new System.Drawing.Size(57, 38);
            this.menuItemTask.Text = "Task";
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Name = "menuItemPrint";
            this.menuItemPrint.Size = new System.Drawing.Size(203, 30);
            this.menuItemPrint.Text = "Print...  Ctrl+P";
            this.menuItemPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
            // 
            // menuItemTaskSeparator
            // 
            this.menuItemTaskSeparator.Name = "menuItemTaskSeparator";
            this.menuItemTaskSeparator.Size = new System.Drawing.Size(200, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(203, 30);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEmail,
            this.menuItemPaper});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(54, 38);
            this.menuItemEdit.Text = "Edit";
            // 
            // menuItemEmail
            // 
            this.menuItemEmail.Name = "menuItemEmail";
            this.menuItemEmail.Size = new System.Drawing.Size(206, 30);
            this.menuItemEmail.Text = "Email    Ctrl+E";
            this.menuItemEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuItemEmail.Click += new System.EventHandler(this.menuItemEmail_Click);
            // 
            // menuItemPaper
            // 
            this.menuItemPaper.Name = "menuItemPaper";
            this.menuItemPaper.Size = new System.Drawing.Size(206, 30);
            this.menuItemPaper.Text = "Paper   Ctrl+R";
            this.menuItemPaper.Click += new System.EventHandler(this.menuItemPaper_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStatusBar});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(61, 38);
            this.menuItemView.Text = "View";
            // 
            // menuItemStatusBar
            // 
            this.menuItemStatusBar.Name = "menuItemStatusBar";
            this.menuItemStatusBar.Size = new System.Drawing.Size(174, 30);
            this.menuItemStatusBar.Text = "Status Bar";
            this.menuItemStatusBar.Click += new System.EventHandler(this.menuItemStatusBar_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(61, 38);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(146, 30);
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // panelMenuStrip
            // 
            this.panelMenuStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuStrip.Controls.Add(this.menuStripMainForm);
            this.panelMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.panelMenuStrip.Name = "panelMenuStrip";
            this.panelMenuStrip.Size = new System.Drawing.Size(1573, 44);
            this.panelMenuStrip.TabIndex = 3;
            // 
            // panelTblLayout
            // 
            this.panelTblLayout.Controls.Add(this.tblLayoutPanelMainFormLower);
            this.panelTblLayout.Controls.Add(this.panelMainForm);
            this.panelTblLayout.Controls.Add(this.tblLayoutPanelMainFormUpper);
            this.panelTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTblLayout.Location = new System.Drawing.Point(0, 44);
            this.panelTblLayout.Name = "panelTblLayout";
            this.panelTblLayout.Size = new System.Drawing.Size(1573, 1000);
            this.panelTblLayout.TabIndex = 4;
            // 
            // tblLayoutPanelMainFormLower
            // 
            this.tblLayoutPanelMainFormLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanelMainFormLower.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblLayoutPanelMainFormLower.ColumnCount = 7;
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMainFormLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblLayoutPanelMainFormLower.Controls.Add(this.lblPrintLettersFor, 1, 1);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.dataGridViewPhysicians, 1, 2);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.dataGridViewPhysiciansExclude, 5, 2);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.btnMove, 3, 3);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.btnSelectAll, 3, 5);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.btnPrintList, 3, 7);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.lblDenotePhysician, 1, 9);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.statusStripMainForm, 0, 10);
            this.tblLayoutPanelMainFormLower.Controls.Add(this.lblDoNotPrint, 5, 1);
            this.tblLayoutPanelMainFormLower.Location = new System.Drawing.Point(0, 556);
            this.tblLayoutPanelMainFormLower.Name = "tblLayoutPanelMainFormLower";
            this.tblLayoutPanelMainFormLower.RowCount = 11;
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutPanelMainFormLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelMainFormLower.Size = new System.Drawing.Size(1573, 444);
            this.tblLayoutPanelMainFormLower.TabIndex = 2;
            // 
            // lblPrintLettersFor
            // 
            this.lblPrintLettersFor.AutoSize = true;
            this.lblPrintLettersFor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrintLettersFor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrintLettersFor.Location = new System.Drawing.Point(15, 10);
            this.lblPrintLettersFor.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPrintLettersFor.Name = "lblPrintLettersFor";
            this.lblPrintLettersFor.Size = new System.Drawing.Size(116, 20);
            this.lblPrintLettersFor.TabIndex = 0;
            this.lblPrintLettersFor.Text = "Print letters for:";
            // 
            // dataGridViewPhysicians
            // 
            this.dataGridViewPhysicians.AllowUserToAddRows = false;
            this.dataGridViewPhysicians.AllowUserToResizeColumns = false;
            this.dataGridViewPhysicians.AllowUserToResizeRows = false;
            this.dataGridViewPhysicians.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPhysicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhysicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Fax,
            this.Paper,
            this.Physician});
            this.dataGridViewPhysicians.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhysicians.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewPhysicians.Location = new System.Drawing.Point(18, 33);
            this.dataGridViewPhysicians.Name = "dataGridViewPhysicians";
            this.dataGridViewPhysicians.ReadOnly = true;
            this.dataGridViewPhysicians.RowHeadersVisible = false;
            this.tblLayoutPanelMainFormLower.SetRowSpan(this.dataGridViewPhysicians, 7);
            this.dataGridViewPhysicians.RowTemplate.Height = 10;
            this.dataGridViewPhysicians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhysicians.Size = new System.Drawing.Size(687, 327);
            this.dataGridViewPhysicians.TabIndex = 1;
            this.dataGridViewPhysicians.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhysicians_CellClick);
            this.dataGridViewPhysicians.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewPhysicians_CellPainting);
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.FillWeight = 200F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Email.Width = 200;
            // 
            // Fax
            // 
            this.Fax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Paper
            // 
            this.Paper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Paper.HeaderText = "Paper";
            this.Paper.Name = "Paper";
            this.Paper.ReadOnly = true;
            this.Paper.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Paper.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Physician
            // 
            this.Physician.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Physician.FillWeight = 300F;
            this.Physician.HeaderText = "Physician";
            this.Physician.Name = "Physician";
            this.Physician.ReadOnly = true;
            this.Physician.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Physician.Width = 300;
            // 
            // dataGridViewPhysiciansExclude
            // 
            this.dataGridViewPhysiciansExclude.AllowUserToAddRows = false;
            this.dataGridViewPhysiciansExclude.AllowUserToResizeColumns = false;
            this.dataGridViewPhysiciansExclude.AllowUserToResizeRows = false;
            this.dataGridViewPhysiciansExclude.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPhysiciansExclude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhysiciansExclude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhysicianExclude});
            this.dataGridViewPhysiciansExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhysiciansExclude.Location = new System.Drawing.Point(867, 33);
            this.dataGridViewPhysiciansExclude.Name = "dataGridViewPhysiciansExclude";
            this.dataGridViewPhysiciansExclude.ReadOnly = true;
            this.dataGridViewPhysiciansExclude.RowHeadersVisible = false;
            this.tblLayoutPanelMainFormLower.SetRowSpan(this.dataGridViewPhysiciansExclude, 7);
            this.dataGridViewPhysiciansExclude.RowTemplate.Height = 28;
            this.dataGridViewPhysiciansExclude.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhysiciansExclude.Size = new System.Drawing.Size(687, 327);
            this.dataGridViewPhysiciansExclude.TabIndex = 2;
            this.dataGridViewPhysiciansExclude.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhysiciansExclude_CellClick);
            // 
            // PhysicianExclude
            // 
            this.PhysicianExclude.HeaderText = "Physician";
            this.PhysicianExclude.Name = "PhysicianExclude";
            this.PhysicianExclude.ReadOnly = true;
            this.PhysicianExclude.Width = 800;
            // 
            // btnMove
            // 
            this.btnMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMove.Location = new System.Drawing.Point(716, 130);
            this.btnMove.Margin = new System.Windows.Forms.Padding(0);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(140, 39);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAll.Location = new System.Drawing.Point(716, 177);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(140, 39);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnPrintList
            // 
            this.btnPrintList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintList.Location = new System.Drawing.Point(716, 224);
            this.btnPrintList.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(140, 39);
            this.btnPrintList.TabIndex = 5;
            this.btnPrintList.Text = "Print List";
            this.btnPrintList.UseVisualStyleBackColor = true;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // lblDenotePhysician
            // 
            this.lblDenotePhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDenotePhysician.AutoSize = true;
            this.lblDenotePhysician.Location = new System.Drawing.Point(18, 368);
            this.lblDenotePhysician.Name = "lblDenotePhysician";
            this.lblDenotePhysician.Size = new System.Drawing.Size(291, 20);
            this.lblDenotePhysician.TabIndex = 6;
            this.lblDenotePhysician.Text = "(*) denotes physician is currently on hold";
            // 
            // statusStripMainForm
            // 
            this.tblLayoutPanelMainFormLower.SetColumnSpan(this.statusStripMainForm, 7);
            this.statusStripMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStripMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemReady});
            this.statusStripMainForm.Location = new System.Drawing.Point(3, 393);
            this.statusStripMainForm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(1567, 30);
            this.statusStripMainForm.TabIndex = 7;
            this.statusStripMainForm.Text = "statusStrip1";
            // 
            // toolStripItemReady
            // 
            this.toolStripItemReady.Name = "toolStripItemReady";
            this.toolStripItemReady.Size = new System.Drawing.Size(60, 25);
            this.toolStripItemReady.Text = "Ready";
            // 
            // lblDoNotPrint
            // 
            this.lblDoNotPrint.AutoSize = true;
            this.lblDoNotPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDoNotPrint.Location = new System.Drawing.Point(864, 10);
            this.lblDoNotPrint.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblDoNotPrint.Name = "lblDoNotPrint";
            this.lblDoNotPrint.Size = new System.Drawing.Size(167, 20);
            this.lblDoNotPrint.TabIndex = 8;
            this.lblDoNotPrint.Text = "Do not print letters for:";
            // 
            // panelMainForm
            // 
            this.panelMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(1573, 36);
            this.panelMainForm.TabIndex = 1;
            // 
            // tblLayoutPanelMainFormUpper
            // 
            this.tblLayoutPanelMainFormUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanelMainFormUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutPanelMainFormUpper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblLayoutPanelMainFormUpper.ColumnCount = 12;
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblLayoutPanelMainFormUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.lblLetterType, 1, 1);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.lblLetterTypeAsterisk, 0, 1);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.cmbBoxLetterType, 1, 2);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.lblLetterDetails, 5, 2);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.lblDocumentType, 10, 2);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.listViewDocumentType, 10, 3);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.lblFacility, 1, 5);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.lblFacilityAsterisk, 0, 5);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.cmbBoxFacility, 1, 6);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.btnRetrievePhysicians, 3, 6);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.btnDistributeLetters, 7, 6);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.panelLetterType, 1, 3);
            this.tblLayoutPanelMainFormUpper.Controls.Add(this.tblLayoutPanelLetterDetails, 5, 3);
            this.tblLayoutPanelMainFormUpper.Location = new System.Drawing.Point(0, 29);
            this.tblLayoutPanelMainFormUpper.Name = "tblLayoutPanelMainFormUpper";
            this.tblLayoutPanelMainFormUpper.RowCount = 7;
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelMainFormUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblLayoutPanelMainFormUpper.Size = new System.Drawing.Size(1583, 529);
            this.tblLayoutPanelMainFormUpper.TabIndex = 0;
            // 
            // lblLetterType
            // 
            this.lblLetterType.AutoSize = true;
            this.lblLetterType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLetterType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLetterType.Location = new System.Drawing.Point(15, 10);
            this.lblLetterType.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblLetterType.Name = "lblLetterType";
            this.lblLetterType.Size = new System.Drawing.Size(93, 20);
            this.lblLetterType.TabIndex = 0;
            this.lblLetterType.Text = "Letter Type:";
            // 
            // lblLetterTypeAsterisk
            // 
            this.lblLetterTypeAsterisk.AutoSize = true;
            this.lblLetterTypeAsterisk.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLetterTypeAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblLetterTypeAsterisk.Location = new System.Drawing.Point(3, 10);
            this.lblLetterTypeAsterisk.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLetterTypeAsterisk.Name = "lblLetterTypeAsterisk";
            this.lblLetterTypeAsterisk.Size = new System.Drawing.Size(12, 20);
            this.lblLetterTypeAsterisk.TabIndex = 1;
            this.lblLetterTypeAsterisk.Text = "*";
            // 
            // cmbBoxLetterType
            // 
            this.tblLayoutPanelMainFormUpper.SetColumnSpan(this.cmbBoxLetterType, 3);
            this.cmbBoxLetterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoxLetterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLetterType.FormattingEnabled = true;
            this.cmbBoxLetterType.Location = new System.Drawing.Point(18, 33);
            this.cmbBoxLetterType.Name = "cmbBoxLetterType";
            this.cmbBoxLetterType.Size = new System.Drawing.Size(392, 28);
            this.cmbBoxLetterType.TabIndex = 2;
            this.cmbBoxLetterType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLetterType_SelectedIndexChanged);
            // 
            // lblLetterDetails
            // 
            this.lblLetterDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLetterDetails.AutoSize = true;
            this.lblLetterDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLetterDetails.Location = new System.Drawing.Point(426, 45);
            this.lblLetterDetails.Name = "lblLetterDetails";
            this.lblLetterDetails.Size = new System.Drawing.Size(105, 20);
            this.lblLetterDetails.TabIndex = 4;
            this.lblLetterDetails.Text = "Letter details:";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDocumentType.Location = new System.Drawing.Point(1003, 45);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(121, 20);
            this.lblDocumentType.TabIndex = 6;
            this.lblDocumentType.Text = "Document type:";
            // 
            // listViewDocumentType
            // 
            this.listViewDocumentType.CheckBoxes = true;
            this.listViewDocumentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDocumentType.Location = new System.Drawing.Point(1003, 68);
            this.listViewDocumentType.Name = "listViewDocumentType";
            this.listViewDocumentType.Size = new System.Drawing.Size(555, 394);
            this.listViewDocumentType.TabIndex = 7;
            this.listViewDocumentType.UseCompatibleStateImageBehavior = false;
            this.listViewDocumentType.View = System.Windows.Forms.View.List;
            this.listViewDocumentType.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewDocumentType_ItemChecked);
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFacility.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFacility.Location = new System.Drawing.Point(15, 470);
            this.lblFacility.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(61, 20);
            this.lblFacility.TabIndex = 8;
            this.lblFacility.Text = "Facility:";
            // 
            // lblFacilityAsterisk
            // 
            this.lblFacilityAsterisk.AutoSize = true;
            this.lblFacilityAsterisk.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFacilityAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblFacilityAsterisk.Location = new System.Drawing.Point(3, 470);
            this.lblFacilityAsterisk.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFacilityAsterisk.Name = "lblFacilityAsterisk";
            this.lblFacilityAsterisk.Size = new System.Drawing.Size(12, 20);
            this.lblFacilityAsterisk.TabIndex = 9;
            this.lblFacilityAsterisk.Text = "*";
            // 
            // cmbBoxFacility
            // 
            this.cmbBoxFacility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoxFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFacility.FormattingEnabled = true;
            this.cmbBoxFacility.Location = new System.Drawing.Point(18, 493);
            this.cmbBoxFacility.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cmbBoxFacility.Name = "cmbBoxFacility";
            this.cmbBoxFacility.Size = new System.Drawing.Size(297, 28);
            this.cmbBoxFacility.TabIndex = 10;
            this.cmbBoxFacility.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFacility_SelectedIndexChanged);
            // 
            // btnRetrievePhysicians
            // 
            this.tblLayoutPanelMainFormUpper.SetColumnSpan(this.btnRetrievePhysicians, 3);
            this.btnRetrievePhysicians.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetrievePhysicians.Location = new System.Drawing.Point(323, 490);
            this.btnRetrievePhysicians.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnRetrievePhysicians.Name = "btnRetrievePhysicians";
            this.btnRetrievePhysicians.Size = new System.Drawing.Size(280, 39);
            this.btnRetrievePhysicians.TabIndex = 11;
            this.btnRetrievePhysicians.Text = "Retrieve Physicians";
            this.btnRetrievePhysicians.UseVisualStyleBackColor = true;
            this.btnRetrievePhysicians.Click += new System.EventHandler(this.btnRetrievePhysicians_Click);
            // 
            // btnDistributeLetters
            // 
            this.btnDistributeLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDistributeLetters.Location = new System.Drawing.Point(611, 490);
            this.btnDistributeLetters.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDistributeLetters.Name = "btnDistributeLetters";
            this.btnDistributeLetters.Size = new System.Drawing.Size(280, 39);
            this.btnDistributeLetters.TabIndex = 12;
            this.btnDistributeLetters.Text = "Distribute Letters";
            this.btnDistributeLetters.UseVisualStyleBackColor = true;
            this.btnDistributeLetters.Click += new System.EventHandler(this.btnDistributeLetters_Click);
            // 
            // panelLetterType
            // 
            this.panelLetterType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblLayoutPanelMainFormUpper.SetColumnSpan(this.panelLetterType, 3);
            this.panelLetterType.Controls.Add(this.tblLayoutPanelLetterType);
            this.panelLetterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLetterType.Location = new System.Drawing.Point(18, 68);
            this.panelLetterType.Name = "panelLetterType";
            this.panelLetterType.Size = new System.Drawing.Size(392, 394);
            this.panelLetterType.TabIndex = 13;
            // 
            // tblLayoutPanelLetterType
            // 
            this.tblLayoutPanelLetterType.ColumnCount = 3;
            this.tblLayoutPanelLetterType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLayoutPanelLetterType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLetterType.Controls.Add(this.checkBoxPrintForPhysicians, 1, 1);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblPrintForPhysicians, 2, 1);
            this.tblLayoutPanelLetterType.Controls.Add(this.checkBoxPrintDeficiencies, 1, 3);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblPrintDeficiencies, 2, 3);
            this.tblLayoutPanelLetterType.Controls.Add(this.checkBoxPrintExpectedDeficiencies, 1, 5);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblPrintExpectedDeficiencies, 2, 5);
            this.tblLayoutPanelLetterType.Controls.Add(this.checkBoxPrintPhysician, 1, 7);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblPrintPhysician, 2, 7);
            this.tblLayoutPanelLetterType.Controls.Add(this.checkBoxAllocatedCharts, 1, 9);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblAllocatedCharts, 2, 9);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblSortPrinted, 2, 11);
            this.tblLayoutPanelLetterType.Controls.Add(this.radioBtnSortProviderName, 1, 13);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblSortProviderName, 2, 13);
            this.tblLayoutPanelLetterType.Controls.Add(this.radioBtnSortMedicalService, 1, 15);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblSortMedicalService, 2, 15);
            this.tblLayoutPanelLetterType.Controls.Add(this.lblGroupExpected, 2, 17);
            this.tblLayoutPanelLetterType.Controls.Add(this.panelRadioBtnGroup, 0, 19);
            this.tblLayoutPanelLetterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelLetterType.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelLetterType.Name = "tblLayoutPanelLetterType";
            this.tblLayoutPanelLetterType.RowCount = 24;
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelLetterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelLetterType.Size = new System.Drawing.Size(390, 392);
            this.tblLayoutPanelLetterType.TabIndex = 14;
            // 
            // checkBoxPrintForPhysicians
            // 
            this.checkBoxPrintForPhysicians.AutoSize = true;
            this.checkBoxPrintForPhysicians.Checked = true;
            this.checkBoxPrintForPhysicians.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrintForPhysicians.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPrintForPhysicians.Location = new System.Drawing.Point(15, 8);
            this.checkBoxPrintForPhysicians.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPrintForPhysicians.Name = "checkBoxPrintForPhysicians";
            this.checkBoxPrintForPhysicians.Size = new System.Drawing.Size(25, 25);
            this.checkBoxPrintForPhysicians.TabIndex = 0;
            this.checkBoxPrintForPhysicians.Text = "checkBox1";
            this.checkBoxPrintForPhysicians.UseVisualStyleBackColor = true;
            // 
            // lblPrintForPhysicians
            // 
            this.lblPrintForPhysicians.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrintForPhysicians.AutoSize = true;
            this.lblPrintForPhysicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintForPhysicians.Location = new System.Drawing.Point(43, 10);
            this.lblPrintForPhysicians.Name = "lblPrintForPhysicians";
            this.lblPrintForPhysicians.Size = new System.Drawing.Size(177, 20);
            this.lblPrintForPhysicians.TabIndex = 1;
            this.lblPrintForPhysicians.Text = "Print for physicians only:";
            // 
            // checkBoxPrintDeficiencies
            // 
            this.checkBoxPrintDeficiencies.AutoSize = true;
            this.checkBoxPrintDeficiencies.Checked = true;
            this.checkBoxPrintDeficiencies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrintDeficiencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPrintDeficiencies.Location = new System.Drawing.Point(15, 46);
            this.checkBoxPrintDeficiencies.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPrintDeficiencies.Name = "checkBoxPrintDeficiencies";
            this.checkBoxPrintDeficiencies.Size = new System.Drawing.Size(25, 25);
            this.checkBoxPrintDeficiencies.TabIndex = 2;
            this.checkBoxPrintDeficiencies.Text = "Print deficiencies:";
            this.checkBoxPrintDeficiencies.UseVisualStyleBackColor = true;
            // 
            // lblPrintDeficiencies
            // 
            this.lblPrintDeficiencies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrintDeficiencies.AutoSize = true;
            this.lblPrintDeficiencies.Location = new System.Drawing.Point(43, 48);
            this.lblPrintDeficiencies.Name = "lblPrintDeficiencies";
            this.lblPrintDeficiencies.Size = new System.Drawing.Size(132, 20);
            this.lblPrintDeficiencies.TabIndex = 3;
            this.lblPrintDeficiencies.Text = "Print deficiencies:";
            // 
            // checkBoxPrintExpectedDeficiencies
            // 
            this.checkBoxPrintExpectedDeficiencies.AutoSize = true;
            this.checkBoxPrintExpectedDeficiencies.Checked = true;
            this.checkBoxPrintExpectedDeficiencies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrintExpectedDeficiencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPrintExpectedDeficiencies.Location = new System.Drawing.Point(15, 84);
            this.checkBoxPrintExpectedDeficiencies.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPrintExpectedDeficiencies.Name = "checkBoxPrintExpectedDeficiencies";
            this.checkBoxPrintExpectedDeficiencies.Size = new System.Drawing.Size(25, 25);
            this.checkBoxPrintExpectedDeficiencies.TabIndex = 4;
            this.checkBoxPrintExpectedDeficiencies.Text = "checkBox1";
            this.checkBoxPrintExpectedDeficiencies.UseVisualStyleBackColor = true;
            // 
            // lblPrintExpectedDeficiencies
            // 
            this.lblPrintExpectedDeficiencies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrintExpectedDeficiencies.AutoSize = true;
            this.lblPrintExpectedDeficiencies.Location = new System.Drawing.Point(60, 86);
            this.lblPrintExpectedDeficiencies.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblPrintExpectedDeficiencies.Name = "lblPrintExpectedDeficiencies";
            this.lblPrintExpectedDeficiencies.Size = new System.Drawing.Size(201, 20);
            this.lblPrintExpectedDeficiencies.TabIndex = 5;
            this.lblPrintExpectedDeficiencies.Text = "Print expected deficiencies:";
            // 
            // checkBoxPrintPhysician
            // 
            this.checkBoxPrintPhysician.AutoSize = true;
            this.checkBoxPrintPhysician.Checked = true;
            this.checkBoxPrintPhysician.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrintPhysician.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPrintPhysician.Location = new System.Drawing.Point(15, 122);
            this.checkBoxPrintPhysician.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPrintPhysician.Name = "checkBoxPrintPhysician";
            this.checkBoxPrintPhysician.Size = new System.Drawing.Size(25, 25);
            this.checkBoxPrintPhysician.TabIndex = 6;
            this.checkBoxPrintPhysician.Text = "checkBox1";
            this.checkBoxPrintPhysician.UseVisualStyleBackColor = true;
            // 
            // lblPrintPhysician
            // 
            this.lblPrintPhysician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrintPhysician.AutoSize = true;
            this.lblPrintPhysician.Location = new System.Drawing.Point(43, 124);
            this.lblPrintPhysician.Name = "lblPrintPhysician";
            this.lblPrintPhysician.Size = new System.Drawing.Size(225, 20);
            this.lblPrintPhysician.TabIndex = 7;
            this.lblPrintPhysician.Text = "Print physician medical service:";
            // 
            // checkBoxAllocatedCharts
            // 
            this.checkBoxAllocatedCharts.AutoSize = true;
            this.checkBoxAllocatedCharts.Checked = true;
            this.checkBoxAllocatedCharts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllocatedCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAllocatedCharts.Location = new System.Drawing.Point(15, 160);
            this.checkBoxAllocatedCharts.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAllocatedCharts.Name = "checkBoxAllocatedCharts";
            this.checkBoxAllocatedCharts.Size = new System.Drawing.Size(25, 25);
            this.checkBoxAllocatedCharts.TabIndex = 8;
            this.checkBoxAllocatedCharts.Text = "checkBox1";
            this.checkBoxAllocatedCharts.UseVisualStyleBackColor = true;
            // 
            // lblAllocatedCharts
            // 
            this.lblAllocatedCharts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllocatedCharts.AutoSize = true;
            this.lblAllocatedCharts.Location = new System.Drawing.Point(43, 162);
            this.lblAllocatedCharts.Name = "lblAllocatedCharts";
            this.lblAllocatedCharts.Size = new System.Drawing.Size(155, 20);
            this.lblAllocatedCharts.TabIndex = 9;
            this.lblAllocatedCharts.Text = "Allocated charts only";
            // 
            // lblSortPrinted
            // 
            this.lblSortPrinted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSortPrinted.AutoSize = true;
            this.lblSortPrinted.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSortPrinted.Location = new System.Drawing.Point(43, 198);
            this.lblSortPrinted.Name = "lblSortPrinted";
            this.lblSortPrinted.Size = new System.Drawing.Size(144, 20);
            this.lblSortPrinted.TabIndex = 10;
            this.lblSortPrinted.Text = "Sort printed letters:";
            // 
            // radioBtnSortProviderName
            // 
            this.radioBtnSortProviderName.AutoSize = true;
            this.radioBtnSortProviderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtnSortProviderName.Location = new System.Drawing.Point(15, 226);
            this.radioBtnSortProviderName.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnSortProviderName.Name = "radioBtnSortProviderName";
            this.radioBtnSortProviderName.Size = new System.Drawing.Size(25, 25);
            this.radioBtnSortProviderName.TabIndex = 11;
            this.radioBtnSortProviderName.TabStop = true;
            this.radioBtnSortProviderName.Text = "radioButton1";
            this.radioBtnSortProviderName.UseVisualStyleBackColor = true;
            // 
            // lblSortProviderName
            // 
            this.lblSortProviderName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSortProviderName.AutoSize = true;
            this.lblSortProviderName.Location = new System.Drawing.Point(60, 228);
            this.lblSortProviderName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblSortProviderName.Name = "lblSortProviderName";
            this.lblSortProviderName.Size = new System.Drawing.Size(163, 20);
            this.lblSortProviderName.TabIndex = 12;
            this.lblSortProviderName.Text = "Sort by provider name";
            // 
            // radioBtnSortMedicalService
            // 
            this.radioBtnSortMedicalService.AutoSize = true;
            this.radioBtnSortMedicalService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtnSortMedicalService.Location = new System.Drawing.Point(15, 264);
            this.radioBtnSortMedicalService.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnSortMedicalService.Name = "radioBtnSortMedicalService";
            this.radioBtnSortMedicalService.Size = new System.Drawing.Size(25, 25);
            this.radioBtnSortMedicalService.TabIndex = 13;
            this.radioBtnSortMedicalService.TabStop = true;
            this.radioBtnSortMedicalService.Text = "radioButton1";
            this.radioBtnSortMedicalService.UseVisualStyleBackColor = true;
            // 
            // lblSortMedicalService
            // 
            this.lblSortMedicalService.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSortMedicalService.AutoSize = true;
            this.lblSortMedicalService.Location = new System.Drawing.Point(60, 266);
            this.lblSortMedicalService.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblSortMedicalService.Name = "lblSortMedicalService";
            this.lblSortMedicalService.Size = new System.Drawing.Size(170, 20);
            this.lblSortMedicalService.TabIndex = 14;
            this.lblSortMedicalService.Text = "Sort by medical service";
            // 
            // lblGroupExpected
            // 
            this.lblGroupExpected.AutoSize = true;
            this.lblGroupExpected.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGroupExpected.Location = new System.Drawing.Point(43, 302);
            this.lblGroupExpected.Name = "lblGroupExpected";
            this.lblGroupExpected.Size = new System.Drawing.Size(261, 20);
            this.lblGroupExpected.TabIndex = 15;
            this.lblGroupExpected.Text = "Group expected deficiency letter by:";
            // 
            // panelRadioBtnGroup
            // 
            this.tblLayoutPanelLetterType.SetColumnSpan(this.panelRadioBtnGroup, 3);
            this.panelRadioBtnGroup.Controls.Add(this.tblLayoutPanelRadioBtn);
            this.panelRadioBtnGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadioBtnGroup.Location = new System.Drawing.Point(0, 330);
            this.panelRadioBtnGroup.Margin = new System.Windows.Forms.Padding(0);
            this.panelRadioBtnGroup.Name = "panelRadioBtnGroup";
            this.tblLayoutPanelLetterType.SetRowSpan(this.panelRadioBtnGroup, 3);
            this.panelRadioBtnGroup.Size = new System.Drawing.Size(390, 63);
            this.panelRadioBtnGroup.TabIndex = 20;
            // 
            // tblLayoutPanelRadioBtn
            // 
            this.tblLayoutPanelRadioBtn.ColumnCount = 3;
            this.tblLayoutPanelRadioBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLayoutPanelRadioBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelRadioBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelRadioBtn.Controls.Add(this.radioBtnProviderName, 1, 0);
            this.tblLayoutPanelRadioBtn.Controls.Add(this.radioBtnEncounter, 1, 2);
            this.tblLayoutPanelRadioBtn.Controls.Add(this.lblProviderName, 2, 0);
            this.tblLayoutPanelRadioBtn.Controls.Add(this.lblEncounter, 2, 2);
            this.tblLayoutPanelRadioBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelRadioBtn.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelRadioBtn.Name = "tblLayoutPanelRadioBtn";
            this.tblLayoutPanelRadioBtn.RowCount = 5;
            this.tblLayoutPanelRadioBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelRadioBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelRadioBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelRadioBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tblLayoutPanelRadioBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelRadioBtn.Size = new System.Drawing.Size(390, 63);
            this.tblLayoutPanelRadioBtn.TabIndex = 0;
            // 
            // radioBtnProviderName
            // 
            this.radioBtnProviderName.AutoSize = true;
            this.radioBtnProviderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtnProviderName.Location = new System.Drawing.Point(15, 0);
            this.radioBtnProviderName.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnProviderName.Name = "radioBtnProviderName";
            this.radioBtnProviderName.Size = new System.Drawing.Size(25, 25);
            this.radioBtnProviderName.TabIndex = 0;
            this.radioBtnProviderName.TabStop = true;
            this.radioBtnProviderName.Text = "radioButton1";
            this.radioBtnProviderName.UseVisualStyleBackColor = true;
            // 
            // radioBtnEncounter
            // 
            this.radioBtnEncounter.AutoSize = true;
            this.radioBtnEncounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtnEncounter.Location = new System.Drawing.Point(15, 38);
            this.radioBtnEncounter.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnEncounter.Name = "radioBtnEncounter";
            this.radioBtnEncounter.Size = new System.Drawing.Size(25, 25);
            this.radioBtnEncounter.TabIndex = 1;
            this.radioBtnEncounter.TabStop = true;
            this.radioBtnEncounter.Text = "radioButton2";
            this.radioBtnEncounter.UseVisualStyleBackColor = true;
            // 
            // lblProviderName
            // 
            this.lblProviderName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(60, 2);
            this.lblProviderName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(112, 20);
            this.lblProviderName.TabIndex = 2;
            this.lblProviderName.Text = "Provider Name";
            // 
            // lblEncounter
            // 
            this.lblEncounter.AutoSize = true;
            this.lblEncounter.Location = new System.Drawing.Point(60, 38);
            this.lblEncounter.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblEncounter.Name = "lblEncounter";
            this.lblEncounter.Size = new System.Drawing.Size(83, 20);
            this.lblEncounter.TabIndex = 3;
            this.lblEncounter.Text = "Encounter";
            // 
            // tblLayoutPanelLetterDetails
            // 
            this.tblLayoutPanelLetterDetails.ColumnCount = 2;
            this.tblLayoutPanelMainFormUpper.SetColumnSpan(this.tblLayoutPanelLetterDetails, 4);
            this.tblLayoutPanelLetterDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelLetterDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelLetterDetails.Controls.Add(this.panelLetterDetailsFirst, 0, 0);
            this.tblLayoutPanelLetterDetails.Controls.Add(this.panelLetterDetailsSecond, 1, 0);
            this.tblLayoutPanelLetterDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelLetterDetails.Location = new System.Drawing.Point(426, 68);
            this.tblLayoutPanelLetterDetails.Name = "tblLayoutPanelLetterDetails";
            this.tblLayoutPanelLetterDetails.RowCount = 1;
            this.tblLayoutPanelLetterDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLetterDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tblLayoutPanelLetterDetails.Size = new System.Drawing.Size(561, 394);
            this.tblLayoutPanelLetterDetails.TabIndex = 14;
            // 
            // panelLetterDetailsFirst
            // 
            this.panelLetterDetailsFirst.BackColor = System.Drawing.SystemColors.Control;
            this.panelLetterDetailsFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLetterDetailsFirst.Controls.Add(this.tblLayoutPanelLetterDetailsFirst);
            this.panelLetterDetailsFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLetterDetailsFirst.Location = new System.Drawing.Point(0, 0);
            this.panelLetterDetailsFirst.Margin = new System.Windows.Forms.Padding(0);
            this.panelLetterDetailsFirst.Name = "panelLetterDetailsFirst";
            this.panelLetterDetailsFirst.Size = new System.Drawing.Size(280, 394);
            this.panelLetterDetailsFirst.TabIndex = 0;
            // 
            // tblLayoutPanelLetterDetailsFirst
            // 
            this.tblLayoutPanelLetterDetailsFirst.ColumnCount = 1;
            this.tblLayoutPanelLetterDetailsFirst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblDeficientDayRange, 0, 1);
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblIncludeDocuments, 0, 3);
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblChartOnHold, 0, 5);
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblPhysiciansToInclude, 0, 7);
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblChartsToInclude, 0, 9);
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblDeficienciesToInclude, 0, 11);
            this.tblLayoutPanelLetterDetailsFirst.Controls.Add(this.lblIncludeVisits, 0, 13);
            this.tblLayoutPanelLetterDetailsFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelLetterDetailsFirst.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelLetterDetailsFirst.Name = "tblLayoutPanelLetterDetailsFirst";
            this.tblLayoutPanelLetterDetailsFirst.RowCount = 15;
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLetterDetailsFirst.Size = new System.Drawing.Size(278, 392);
            this.tblLayoutPanelLetterDetailsFirst.TabIndex = 0;
            // 
            // lblDeficientDayRange
            // 
            this.lblDeficientDayRange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeficientDayRange.AutoSize = true;
            this.lblDeficientDayRange.Location = new System.Drawing.Point(64, 8);
            this.lblDeficientDayRange.Name = "lblDeficientDayRange";
            this.lblDeficientDayRange.Size = new System.Drawing.Size(211, 20);
            this.lblDeficientDayRange.TabIndex = 0;
            this.lblDeficientDayRange.Text = "Deficient day range for visits:";
            // 
            // lblIncludeDocuments
            // 
            this.lblIncludeDocuments.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIncludeDocuments.AutoSize = true;
            this.lblIncludeDocuments.Location = new System.Drawing.Point(68, 65);
            this.lblIncludeDocuments.Name = "lblIncludeDocuments";
            this.lblIncludeDocuments.Size = new System.Drawing.Size(207, 20);
            this.lblIncludeDocuments.TabIndex = 1;
            this.lblIncludeDocuments.Text = "Include documents that are:";
            // 
            // lblChartOnHold
            // 
            this.lblChartOnHold.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChartOnHold.AutoSize = true;
            this.lblChartOnHold.Location = new System.Drawing.Point(103, 122);
            this.lblChartOnHold.Name = "lblChartOnHold";
            this.lblChartOnHold.Size = new System.Drawing.Size(172, 20);
            this.lblChartOnHold.TabIndex = 2;
            this.lblChartOnHold.Text = "Chart on hold indicator:";
            // 
            // lblPhysiciansToInclude
            // 
            this.lblPhysiciansToInclude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhysiciansToInclude.AutoSize = true;
            this.lblPhysiciansToInclude.Location = new System.Drawing.Point(116, 179);
            this.lblPhysiciansToInclude.Name = "lblPhysiciansToInclude";
            this.lblPhysiciansToInclude.Size = new System.Drawing.Size(159, 20);
            this.lblPhysiciansToInclude.TabIndex = 3;
            this.lblPhysiciansToInclude.Text = "Physicians to include:";
            // 
            // lblChartsToInclude
            // 
            this.lblChartsToInclude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChartsToInclude.AutoSize = true;
            this.lblChartsToInclude.Location = new System.Drawing.Point(143, 236);
            this.lblChartsToInclude.Name = "lblChartsToInclude";
            this.lblChartsToInclude.Size = new System.Drawing.Size(132, 20);
            this.lblChartsToInclude.TabIndex = 4;
            this.lblChartsToInclude.Text = "Charts to include:";
            // 
            // lblDeficienciesToInclude
            // 
            this.lblDeficienciesToInclude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeficienciesToInclude.AutoSize = true;
            this.lblDeficienciesToInclude.Location = new System.Drawing.Point(104, 293);
            this.lblDeficienciesToInclude.Name = "lblDeficienciesToInclude";
            this.lblDeficienciesToInclude.Size = new System.Drawing.Size(171, 20);
            this.lblDeficienciesToInclude.TabIndex = 5;
            this.lblDeficienciesToInclude.Text = "Deficiencies to include:";
            // 
            // lblIncludeVisits
            // 
            this.lblIncludeVisits.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIncludeVisits.AutoSize = true;
            this.lblIncludeVisits.Location = new System.Drawing.Point(113, 350);
            this.lblIncludeVisits.Name = "lblIncludeVisits";
            this.lblIncludeVisits.Size = new System.Drawing.Size(162, 20);
            this.lblIncludeVisits.TabIndex = 6;
            this.lblIncludeVisits.Text = "Include visits that are:";
            // 
            // panelLetterDetailsSecond
            // 
            this.panelLetterDetailsSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLetterDetailsSecond.Controls.Add(this.tblLayoutPanelLetterDetailsSecond);
            this.panelLetterDetailsSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLetterDetailsSecond.Location = new System.Drawing.Point(280, 0);
            this.panelLetterDetailsSecond.Margin = new System.Windows.Forms.Padding(0);
            this.panelLetterDetailsSecond.Name = "panelLetterDetailsSecond";
            this.panelLetterDetailsSecond.Size = new System.Drawing.Size(281, 394);
            this.panelLetterDetailsSecond.TabIndex = 1;
            // 
            // tblLayoutPanelLetterDetailsSecond
            // 
            this.tblLayoutPanelLetterDetailsSecond.ColumnCount = 1;
            this.tblLayoutPanelLetterDetailsSecond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblDeficiencyDayRangeValue, 0, 1);
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblIncludeDocumentsValue, 0, 3);
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblChartOnHoldValue, 0, 5);
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblPhysiciansToIncludeValue, 0, 7);
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblChartsToIncludeValue, 0, 9);
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblDeficienciesToIncludeValue, 0, 11);
            this.tblLayoutPanelLetterDetailsSecond.Controls.Add(this.lblIncludeVisitsValue, 0, 13);
            this.tblLayoutPanelLetterDetailsSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelLetterDetailsSecond.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelLetterDetailsSecond.Name = "tblLayoutPanelLetterDetailsSecond";
            this.tblLayoutPanelLetterDetailsSecond.RowCount = 16;
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelLetterDetailsSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLetterDetailsSecond.Size = new System.Drawing.Size(279, 392);
            this.tblLayoutPanelLetterDetailsSecond.TabIndex = 0;
            // 
            // lblDeficiencyDayRangeValue
            // 
            this.lblDeficiencyDayRangeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDeficiencyDayRangeValue.AutoSize = true;
            this.lblDeficiencyDayRangeValue.Location = new System.Drawing.Point(3, 8);
            this.lblDeficiencyDayRangeValue.Name = "lblDeficiencyDayRangeValue";
            this.lblDeficiencyDayRangeValue.Size = new System.Drawing.Size(0, 20);
            this.lblDeficiencyDayRangeValue.TabIndex = 0;
            // 
            // lblIncludeDocumentsValue
            // 
            this.lblIncludeDocumentsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncludeDocumentsValue.AutoSize = true;
            this.lblIncludeDocumentsValue.Location = new System.Drawing.Point(3, 65);
            this.lblIncludeDocumentsValue.Name = "lblIncludeDocumentsValue";
            this.lblIncludeDocumentsValue.Size = new System.Drawing.Size(0, 20);
            this.lblIncludeDocumentsValue.TabIndex = 1;
            // 
            // lblChartOnHoldValue
            // 
            this.lblChartOnHoldValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChartOnHoldValue.AutoSize = true;
            this.lblChartOnHoldValue.Location = new System.Drawing.Point(3, 122);
            this.lblChartOnHoldValue.Name = "lblChartOnHoldValue";
            this.lblChartOnHoldValue.Size = new System.Drawing.Size(0, 20);
            this.lblChartOnHoldValue.TabIndex = 2;
            // 
            // lblPhysiciansToIncludeValue
            // 
            this.lblPhysiciansToIncludeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhysiciansToIncludeValue.AutoSize = true;
            this.lblPhysiciansToIncludeValue.Location = new System.Drawing.Point(3, 179);
            this.lblPhysiciansToIncludeValue.Name = "lblPhysiciansToIncludeValue";
            this.lblPhysiciansToIncludeValue.Size = new System.Drawing.Size(0, 20);
            this.lblPhysiciansToIncludeValue.TabIndex = 3;
            // 
            // lblChartsToIncludeValue
            // 
            this.lblChartsToIncludeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChartsToIncludeValue.AutoSize = true;
            this.lblChartsToIncludeValue.Location = new System.Drawing.Point(3, 236);
            this.lblChartsToIncludeValue.Name = "lblChartsToIncludeValue";
            this.lblChartsToIncludeValue.Size = new System.Drawing.Size(0, 20);
            this.lblChartsToIncludeValue.TabIndex = 4;
            // 
            // lblDeficienciesToIncludeValue
            // 
            this.lblDeficienciesToIncludeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDeficienciesToIncludeValue.AutoSize = true;
            this.lblDeficienciesToIncludeValue.Location = new System.Drawing.Point(3, 293);
            this.lblDeficienciesToIncludeValue.Name = "lblDeficienciesToIncludeValue";
            this.lblDeficienciesToIncludeValue.Size = new System.Drawing.Size(0, 20);
            this.lblDeficienciesToIncludeValue.TabIndex = 5;
            // 
            // lblIncludeVisitsValue
            // 
            this.lblIncludeVisitsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncludeVisitsValue.AutoSize = true;
            this.lblIncludeVisitsValue.Location = new System.Drawing.Point(3, 350);
            this.lblIncludeVisitsValue.Name = "lblIncludeVisitsValue";
            this.lblIncludeVisitsValue.Size = new System.Drawing.Size(0, 20);
            this.lblIncludeVisitsValue.TabIndex = 6;
            // 
            // printDocumentPrintList
            // 
            this.printDocumentPrintList.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDocumentDistributeLetters
            // 
            this.printDocumentDistributeLetters.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDistributeLetters_PrintPage);
            // 
            // printDocumentDistributeLettersMenu
            // 
            this.printDocumentDistributeLettersMenu.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDistributeLettersMenu_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 1044);
            this.Controls.Add(this.panelTblLayout);
            this.Controls.Add(this.panelMenuStrip);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ProFile: Letters";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.panelMenuStrip.ResumeLayout(false);
            this.panelMenuStrip.PerformLayout();
            this.panelTblLayout.ResumeLayout(false);
            this.tblLayoutPanelMainFormLower.ResumeLayout(false);
            this.tblLayoutPanelMainFormLower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhysicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhysiciansExclude)).EndInit();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.tblLayoutPanelMainFormUpper.ResumeLayout(false);
            this.tblLayoutPanelMainFormUpper.PerformLayout();
            this.panelLetterType.ResumeLayout(false);
            this.tblLayoutPanelLetterType.ResumeLayout(false);
            this.tblLayoutPanelLetterType.PerformLayout();
            this.panelRadioBtnGroup.ResumeLayout(false);
            this.tblLayoutPanelRadioBtn.ResumeLayout(false);
            this.tblLayoutPanelRadioBtn.PerformLayout();
            this.tblLayoutPanelLetterDetails.ResumeLayout(false);
            this.panelLetterDetailsFirst.ResumeLayout(false);
            this.tblLayoutPanelLetterDetailsFirst.ResumeLayout(false);
            this.tblLayoutPanelLetterDetailsFirst.PerformLayout();
            this.panelLetterDetailsSecond.ResumeLayout(false);
            this.tblLayoutPanelLetterDetailsSecond.ResumeLayout(false);
            this.tblLayoutPanelLetterDetailsSecond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuItemTask;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrint;
        private System.Windows.Forms.ToolStripSeparator menuItemTaskSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmail;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaper;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemStatusBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.Panel panelMenuStrip;
        private System.Windows.Forms.Panel panelTblLayout;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMainFormUpper;
        private System.Windows.Forms.Label lblLetterType;
        private System.Windows.Forms.Label lblLetterTypeAsterisk;
        private System.Windows.Forms.ComboBox cmbBoxLetterType;
        private System.Windows.Forms.Label lblLetterDetails;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.ListView listViewDocumentType;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblFacilityAsterisk;
        private System.Windows.Forms.ComboBox cmbBoxFacility;
        private System.Windows.Forms.Button btnRetrievePhysicians;
        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMainFormLower;
        private System.Windows.Forms.Label lblPrintLettersFor;
        public System.Windows.Forms.Button btnDistributeLetters;
        private System.Windows.Forms.DataGridView dataGridViewPhysicians;
        private System.Windows.Forms.DataGridView dataGridViewPhysiciansExclude;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Label lblDenotePhysician;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripItemReady;
        private System.Windows.Forms.Panel panelLetterType;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLetterType;
        private System.Windows.Forms.CheckBox checkBoxPrintForPhysicians;
        private System.Windows.Forms.Label lblPrintForPhysicians;
        private System.Windows.Forms.CheckBox checkBoxPrintDeficiencies;
        private System.Windows.Forms.Label lblPrintDeficiencies;
        private System.Windows.Forms.CheckBox checkBoxPrintExpectedDeficiencies;
        private System.Windows.Forms.Label lblPrintExpectedDeficiencies;
        private System.Windows.Forms.CheckBox checkBoxPrintPhysician;
        private System.Windows.Forms.Label lblPrintPhysician;
        private System.Windows.Forms.CheckBox checkBoxAllocatedCharts;
        private System.Windows.Forms.Label lblAllocatedCharts;
        private System.Windows.Forms.Label lblSortPrinted;
        private System.Windows.Forms.RadioButton radioBtnSortProviderName;
        private System.Windows.Forms.Label lblSortProviderName;
        private System.Windows.Forms.RadioButton radioBtnSortMedicalService;
        private System.Windows.Forms.Label lblSortMedicalService;
        private System.Windows.Forms.Label lblGroupExpected;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLetterDetails;
        private System.Windows.Forms.Panel panelLetterDetailsFirst;
        private System.Windows.Forms.Panel panelLetterDetailsSecond;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLetterDetailsFirst;
        private System.Windows.Forms.Label lblDeficientDayRange;
        private System.Windows.Forms.Label lblIncludeDocuments;
        private System.Windows.Forms.Label lblChartOnHold;
        private System.Windows.Forms.Label lblPhysiciansToInclude;
        private System.Windows.Forms.Label lblChartsToInclude;
        private System.Windows.Forms.Label lblDeficienciesToInclude;
        private System.Windows.Forms.Label lblIncludeVisits;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLetterDetailsSecond;
        private System.Windows.Forms.Label lblDeficiencyDayRangeValue;
        private System.Windows.Forms.Label lblIncludeDocumentsValue;
        private System.Windows.Forms.Label lblChartOnHoldValue;
        private System.Windows.Forms.Label lblPhysiciansToIncludeValue;
        private System.Windows.Forms.Label lblChartsToIncludeValue;
        private System.Windows.Forms.Label lblDeficienciesToIncludeValue;
        private System.Windows.Forms.Label lblIncludeVisitsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicianExclude;
        private System.Windows.Forms.Label lblDoNotPrint;
        private System.Windows.Forms.Panel panelRadioBtnGroup;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelRadioBtn;
        private System.Windows.Forms.RadioButton radioBtnProviderName;
        private System.Windows.Forms.RadioButton radioBtnEncounter;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.Label lblEncounter;
        private System.Drawing.Printing.PrintDocument printDocumentPrintList;
        private System.Drawing.Printing.PrintDocument printDocumentDistributeLetters;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Fax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Paper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physician;
        private System.Drawing.Printing.PrintDocument printDocumentDistributeLettersMenu;
    }
}

