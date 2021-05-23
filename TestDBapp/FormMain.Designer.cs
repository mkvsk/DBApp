
namespace TestDBapp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxFullNameSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelDetailedInfo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelMessageBox = new System.Windows.Forms.Panel();
            this.buttonYesMessBox = new Guna.UI2.WinForms.Guna2Button();
            this.buttonNoMessBox = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxMessageDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.checkBoxDetailedInfoStatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBoxCat = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textBoxDetailedTariffPlan = new Guna.UI2.WinForms.Guna2TextBox();
            this.textTariffPlan = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonEditDetailedInfo = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSaveDetailedInfo = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDeleteDetailedInfo = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimeDetailedRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDetailedPassportNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPassportNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDetailedActivity = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDetailedSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDetailedRegistrationDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDetailedInfoCancel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textActivity = new Guna.UI2.WinForms.Guna2TextBox();
            this.textRegistrationDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDetailedMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDetailedFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDetailedPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.textFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumbermainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TestDBapp.DataSet();
            this.panelDataHeader = new System.Windows.Forms.Panel();
            this.panelFullNameData = new System.Windows.Forms.Panel();
            this.pictureBoxArrowFullName = new System.Windows.Forms.PictureBox();
            this.buttonFullNameDataSort = new Guna.UI2.WinForms.Guna2Button();
            this.panelTariffPlan = new System.Windows.Forms.Panel();
            this.pictureBoxArrowTariffPlan = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonTariffPlanDataSort = new Guna.UI2.WinForms.Guna2Button();
            this.panelPhoneNumberMainData = new System.Windows.Forms.Panel();
            this.pictureBoxArrowNumberMain = new System.Windows.Forms.PictureBox();
            this.textBoxNumberMainSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonNumberMainDataSort = new Guna.UI2.WinForms.Guna2Button();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.pictureBoxArrowActivity = new System.Windows.Forms.PictureBox();
            this.textBoxActivitySearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonActivityDataSort = new Guna.UI2.WinForms.Guna2Button();
            this.panelRegistrationDate = new System.Windows.Forms.Panel();
            this.pictureBoxArrowRegistrationDate = new System.Windows.Forms.PictureBox();
            this.textBoxRegistrationDateSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonRegistrationDateDataSort = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.PanelTotalActive = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.textBoxActiveAbonentsCount = new System.Windows.Forms.Label();
            this.textBoxTotalAbonentsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddNewAbonent = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelHelper = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonHelper = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentsTableAdapter = new TestDBapp.DataSetTableAdapters.abonentsTableAdapter();
            this.ShadowPanel.SuspendLayout();
            this.panelDetailedInfo.SuspendLayout();
            this.panelMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessageDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panelDataHeader.SuspendLayout();
            this.panelFullNameData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowFullName)).BeginInit();
            this.panelTariffPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowTariffPlan)).BeginInit();
            this.panelPhoneNumberMainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowNumberMain)).BeginInit();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowActivity)).BeginInit();
            this.panelRegistrationDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRegistrationDate)).BeginInit();
            this.PanelTotalActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panelHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFullNameSearch
            // 
            this.textBoxFullNameSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxFullNameSearch.BorderRadius = 3;
            this.textBoxFullNameSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFullNameSearch.DefaultText = "";
            this.textBoxFullNameSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFullNameSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFullNameSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFullNameSearch.DisabledState.Parent = this.textBoxFullNameSearch;
            this.textBoxFullNameSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFullNameSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxFullNameSearch.FocusedState.Parent = this.textBoxFullNameSearch;
            this.textBoxFullNameSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullNameSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFullNameSearch.HoverState.Parent = this.textBoxFullNameSearch;
            this.textBoxFullNameSearch.Location = new System.Drawing.Point(10, 43);
            this.textBoxFullNameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFullNameSearch.Name = "textBoxFullNameSearch";
            this.textBoxFullNameSearch.PasswordChar = '\0';
            this.textBoxFullNameSearch.PlaceholderText = "";
            this.textBoxFullNameSearch.SelectedText = "";
            this.textBoxFullNameSearch.ShadowDecoration.BorderRadius = 110;
            this.textBoxFullNameSearch.ShadowDecoration.Parent = this.textBoxFullNameSearch;
            this.textBoxFullNameSearch.Size = new System.Drawing.Size(469, 28);
            this.textBoxFullNameSearch.TabIndex = 1;
            this.textBoxFullNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFullNameSearch_KeyDown);
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.Controls.Add(this.panelDetailedInfo);
            this.ShadowPanel.Controls.Add(this.dataGridView);
            this.ShadowPanel.Controls.Add(this.panelDataHeader);
            this.ShadowPanel.FillColor = System.Drawing.Color.White;
            this.ShadowPanel.Location = new System.Drawing.Point(29, 200);
            this.ShadowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ShadowPanel.Radius = 3;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ShadowPanel.ShadowShift = 6;
            this.ShadowPanel.Size = new System.Drawing.Size(1362, 789);
            this.ShadowPanel.TabIndex = 11;
            // 
            // panelDetailedInfo
            // 
            this.panelDetailedInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelDetailedInfo.Controls.Add(this.panelMessageBox);
            this.panelDetailedInfo.Controls.Add(this.checkBoxDetailedInfoStatus);
            this.panelDetailedInfo.Controls.Add(this.pictureBoxCat);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedTariffPlan);
            this.panelDetailedInfo.Controls.Add(this.textTariffPlan);
            this.panelDetailedInfo.Controls.Add(this.buttonEditDetailedInfo);
            this.panelDetailedInfo.Controls.Add(this.buttonSaveDetailedInfo);
            this.panelDetailedInfo.Controls.Add(this.buttonDeleteDetailedInfo);
            this.panelDetailedInfo.Controls.Add(this.dateTimeDetailedRegistrationDate);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedPassportNumber);
            this.panelDetailedInfo.Controls.Add(this.textPassportNumber);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedActivity);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedSecondName);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedRegistrationDate);
            this.panelDetailedInfo.Controls.Add(this.buttonDetailedInfoCancel);
            this.panelDetailedInfo.Controls.Add(this.label2);
            this.panelDetailedInfo.Controls.Add(this.textActivity);
            this.panelDetailedInfo.Controls.Add(this.textRegistrationDate);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedMiddleName);
            this.panelDetailedInfo.Controls.Add(this.textMiddleName);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedFirstName);
            this.panelDetailedInfo.Controls.Add(this.textSecondName);
            this.panelDetailedInfo.Controls.Add(this.textBoxDetailedPhoneNumber);
            this.panelDetailedInfo.Controls.Add(this.textPhoneNumber);
            this.panelDetailedInfo.Controls.Add(this.textFirstName);
            this.panelDetailedInfo.FillColor = System.Drawing.Color.White;
            this.panelDetailedInfo.Location = new System.Drawing.Point(440, 35);
            this.panelDetailedInfo.Name = "panelDetailedInfo";
            this.panelDetailedInfo.Radius = 3;
            this.panelDetailedInfo.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelDetailedInfo.ShadowDepth = 150;
            this.panelDetailedInfo.Size = new System.Drawing.Size(533, 578);
            this.panelDetailedInfo.TabIndex = 16;
            // 
            // panelMessageBox
            // 
            this.panelMessageBox.Controls.Add(this.buttonYesMessBox);
            this.panelMessageBox.Controls.Add(this.buttonNoMessBox);
            this.panelMessageBox.Controls.Add(this.pictureBoxMessageDelete);
            this.panelMessageBox.Location = new System.Drawing.Point(301, 316);
            this.panelMessageBox.Name = "panelMessageBox";
            this.panelMessageBox.Size = new System.Drawing.Size(179, 165);
            this.panelMessageBox.TabIndex = 33;
            this.panelMessageBox.Visible = false;
            // 
            // buttonYesMessBox
            // 
            this.buttonYesMessBox.BackColor = System.Drawing.Color.Transparent;
            this.buttonYesMessBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.buttonYesMessBox.BorderRadius = 3;
            this.buttonYesMessBox.BorderThickness = 2;
            this.buttonYesMessBox.CheckedState.Parent = this.buttonYesMessBox;
            this.buttonYesMessBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYesMessBox.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonYesMessBox.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonYesMessBox.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonYesMessBox.CustomImages.Parent = this.buttonYesMessBox;
            this.buttonYesMessBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.buttonYesMessBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonYesMessBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.buttonYesMessBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.buttonYesMessBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonYesMessBox.HoverState.Parent = this.buttonYesMessBox;
            this.buttonYesMessBox.Location = new System.Drawing.Point(18, 77);
            this.buttonYesMessBox.Name = "buttonYesMessBox";
            this.buttonYesMessBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.buttonYesMessBox.ShadowDecoration.Parent = this.buttonYesMessBox;
            this.buttonYesMessBox.Size = new System.Drawing.Size(61, 36);
            this.buttonYesMessBox.TabIndex = 35;
            this.buttonYesMessBox.Tag = "";
            this.buttonYesMessBox.Text = "YES";
            this.buttonYesMessBox.Click += new System.EventHandler(this.buttonYesMessBox_Click);
            // 
            // buttonNoMessBox
            // 
            this.buttonNoMessBox.BackColor = System.Drawing.Color.Transparent;
            this.buttonNoMessBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(188)))), ((int)(((byte)(108)))));
            this.buttonNoMessBox.BorderRadius = 3;
            this.buttonNoMessBox.BorderThickness = 2;
            this.buttonNoMessBox.CheckedState.Parent = this.buttonNoMessBox;
            this.buttonNoMessBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNoMessBox.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonNoMessBox.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonNoMessBox.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonNoMessBox.CustomImages.Parent = this.buttonNoMessBox;
            this.buttonNoMessBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.buttonNoMessBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonNoMessBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(188)))), ((int)(((byte)(108)))));
            this.buttonNoMessBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(188)))), ((int)(((byte)(108)))));
            this.buttonNoMessBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonNoMessBox.HoverState.Parent = this.buttonNoMessBox;
            this.buttonNoMessBox.Location = new System.Drawing.Point(98, 77);
            this.buttonNoMessBox.Name = "buttonNoMessBox";
            this.buttonNoMessBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(188)))), ((int)(((byte)(108)))));
            this.buttonNoMessBox.ShadowDecoration.Parent = this.buttonNoMessBox;
            this.buttonNoMessBox.Size = new System.Drawing.Size(61, 36);
            this.buttonNoMessBox.TabIndex = 36;
            this.buttonNoMessBox.Tag = "";
            this.buttonNoMessBox.Text = "NO";
            this.buttonNoMessBox.Click += new System.EventHandler(this.buttonNoMessBox_Click);
            // 
            // pictureBoxMessageDelete
            // 
            this.pictureBoxMessageDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMessageDelete.Image = global::TestDBapp.Properties.Resources.mess_box;
            this.pictureBoxMessageDelete.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMessageDelete.Name = "pictureBoxMessageDelete";
            this.pictureBoxMessageDelete.ShadowDecoration.Parent = this.pictureBoxMessageDelete;
            this.pictureBoxMessageDelete.Size = new System.Drawing.Size(179, 165);
            this.pictureBoxMessageDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMessageDelete.TabIndex = 33;
            this.pictureBoxMessageDelete.TabStop = false;
            this.pictureBoxMessageDelete.UseTransparentBackground = true;
            // 
            // checkBoxDetailedInfoStatus
            // 
            this.checkBoxDetailedInfoStatus.AutoSize = true;
            this.checkBoxDetailedInfoStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.checkBoxDetailedInfoStatus.CheckedState.BorderRadius = 0;
            this.checkBoxDetailedInfoStatus.CheckedState.BorderThickness = 2;
            this.checkBoxDetailedInfoStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.checkBoxDetailedInfoStatus.Enabled = false;
            this.checkBoxDetailedInfoStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDetailedInfoStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.checkBoxDetailedInfoStatus.Location = new System.Drawing.Point(326, 456);
            this.checkBoxDetailedInfoStatus.Name = "checkBoxDetailedInfoStatus";
            this.checkBoxDetailedInfoStatus.Size = new System.Drawing.Size(69, 25);
            this.checkBoxDetailedInfoStatus.TabIndex = 32;
            this.checkBoxDetailedInfoStatus.Text = "active";
            this.checkBoxDetailedInfoStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.checkBoxDetailedInfoStatus.UncheckedState.BorderRadius = 0;
            this.checkBoxDetailedInfoStatus.UncheckedState.BorderThickness = 2;
            this.checkBoxDetailedInfoStatus.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCat.Image = global::TestDBapp.Properties.Resources.cat;
            this.pictureBoxCat.Location = new System.Drawing.Point(154, 436);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.ShadowDecoration.Parent = this.pictureBoxCat;
            this.pictureBoxCat.Size = new System.Drawing.Size(192, 139);
            this.pictureBoxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCat.TabIndex = 17;
            this.pictureBoxCat.TabStop = false;
            this.pictureBoxCat.UseTransparentBackground = true;
            // 
            // textBoxDetailedTariffPlan
            // 
            this.textBoxDetailedTariffPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedTariffPlan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedTariffPlan.DefaultText = "";
            this.textBoxDetailedTariffPlan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedTariffPlan.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedTariffPlan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedTariffPlan.DisabledState.Parent = this.textBoxDetailedTariffPlan;
            this.textBoxDetailedTariffPlan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedTariffPlan.Enabled = false;
            this.textBoxDetailedTariffPlan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedTariffPlan.FocusedState.Parent = this.textBoxDetailedTariffPlan;
            this.textBoxDetailedTariffPlan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedTariffPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedTariffPlan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedTariffPlan.HoverState.Parent = this.textBoxDetailedTariffPlan;
            this.textBoxDetailedTariffPlan.Location = new System.Drawing.Point(216, 394);
            this.textBoxDetailedTariffPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedTariffPlan.Name = "textBoxDetailedTariffPlan";
            this.textBoxDetailedTariffPlan.PasswordChar = '\0';
            this.textBoxDetailedTariffPlan.PlaceholderText = "";
            this.textBoxDetailedTariffPlan.SelectedText = "";
            this.textBoxDetailedTariffPlan.ShadowDecoration.Parent = this.textBoxDetailedTariffPlan;
            this.textBoxDetailedTariffPlan.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedTariffPlan.TabIndex = 31;
            this.textBoxDetailedTariffPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTariffPlan
            // 
            this.textTariffPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textTariffPlan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTariffPlan.DefaultText = "Tariff plan:";
            this.textTariffPlan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textTariffPlan.DisabledState.FillColor = System.Drawing.Color.White;
            this.textTariffPlan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textTariffPlan.DisabledState.Parent = this.textTariffPlan;
            this.textTariffPlan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTariffPlan.Enabled = false;
            this.textTariffPlan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTariffPlan.FocusedState.Parent = this.textTariffPlan;
            this.textTariffPlan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textTariffPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textTariffPlan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTariffPlan.HoverState.Parent = this.textTariffPlan;
            this.textTariffPlan.Location = new System.Drawing.Point(27, 394);
            this.textTariffPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTariffPlan.Name = "textTariffPlan";
            this.textTariffPlan.PasswordChar = '\0';
            this.textTariffPlan.PlaceholderText = "";
            this.textTariffPlan.ReadOnly = true;
            this.textTariffPlan.SelectedText = "";
            this.textTariffPlan.SelectionStart = 12;
            this.textTariffPlan.ShadowDecoration.Parent = this.textTariffPlan;
            this.textTariffPlan.Size = new System.Drawing.Size(190, 50);
            this.textTariffPlan.TabIndex = 30;
            this.textTariffPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEditDetailedInfo
            // 
            this.buttonEditDetailedInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditDetailedInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonEditDetailedInfo.BorderRadius = 3;
            this.buttonEditDetailedInfo.BorderThickness = 2;
            this.buttonEditDetailedInfo.CheckedState.Parent = this.buttonEditDetailedInfo;
            this.buttonEditDetailedInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditDetailedInfo.CustomImages.Image = global::TestDBapp.Properties.Resources.edit;
            this.buttonEditDetailedInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonEditDetailedInfo.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonEditDetailedInfo.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonEditDetailedInfo.CustomImages.Parent = this.buttonEditDetailedInfo;
            this.buttonEditDetailedInfo.FillColor = System.Drawing.Color.White;
            this.buttonEditDetailedInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonEditDetailedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonEditDetailedInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonEditDetailedInfo.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonEditDetailedInfo.HoverState.Parent = this.buttonEditDetailedInfo;
            this.buttonEditDetailedInfo.Location = new System.Drawing.Point(251, 26);
            this.buttonEditDetailedInfo.Name = "buttonEditDetailedInfo";
            this.buttonEditDetailedInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonEditDetailedInfo.ShadowDecoration.Parent = this.buttonEditDetailedInfo;
            this.buttonEditDetailedInfo.Size = new System.Drawing.Size(50, 50);
            this.buttonEditDetailedInfo.TabIndex = 29;
            this.buttonEditDetailedInfo.Tag = "";
            this.buttonEditDetailedInfo.Click += new System.EventHandler(this.buttonEditDetailedInfo_Click);
            // 
            // buttonSaveDetailedInfo
            // 
            this.buttonSaveDetailedInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveDetailedInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSaveDetailedInfo.BorderRadius = 3;
            this.buttonSaveDetailedInfo.BorderThickness = 2;
            this.buttonSaveDetailedInfo.CheckedState.Parent = this.buttonSaveDetailedInfo;
            this.buttonSaveDetailedInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDetailedInfo.CustomImages.Image = global::TestDBapp.Properties.Resources.ok1;
            this.buttonSaveDetailedInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSaveDetailedInfo.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonSaveDetailedInfo.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonSaveDetailedInfo.CustomImages.Parent = this.buttonSaveDetailedInfo;
            this.buttonSaveDetailedInfo.Enabled = false;
            this.buttonSaveDetailedInfo.FillColor = System.Drawing.Color.White;
            this.buttonSaveDetailedInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonSaveDetailedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSaveDetailedInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSaveDetailedInfo.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDetailedInfo.HoverState.Parent = this.buttonSaveDetailedInfo;
            this.buttonSaveDetailedInfo.Location = new System.Drawing.Point(312, 26);
            this.buttonSaveDetailedInfo.Name = "buttonSaveDetailedInfo";
            this.buttonSaveDetailedInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonSaveDetailedInfo.ShadowDecoration.Parent = this.buttonSaveDetailedInfo;
            this.buttonSaveDetailedInfo.Size = new System.Drawing.Size(50, 50);
            this.buttonSaveDetailedInfo.TabIndex = 28;
            this.buttonSaveDetailedInfo.Tag = "";
            this.buttonSaveDetailedInfo.Click += new System.EventHandler(this.buttonSaveDetailedInfo_Click);
            // 
            // buttonDeleteDetailedInfo
            // 
            this.buttonDeleteDetailedInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteDetailedInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonDeleteDetailedInfo.BorderRadius = 3;
            this.buttonDeleteDetailedInfo.BorderThickness = 2;
            this.buttonDeleteDetailedInfo.CheckedState.Parent = this.buttonDeleteDetailedInfo;
            this.buttonDeleteDetailedInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteDetailedInfo.CustomImages.Image = global::TestDBapp.Properties.Resources.delete;
            this.buttonDeleteDetailedInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonDeleteDetailedInfo.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonDeleteDetailedInfo.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonDeleteDetailedInfo.CustomImages.Parent = this.buttonDeleteDetailedInfo;
            this.buttonDeleteDetailedInfo.FillColor = System.Drawing.Color.White;
            this.buttonDeleteDetailedInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteDetailedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonDeleteDetailedInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonDeleteDetailedInfo.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteDetailedInfo.HoverState.Parent = this.buttonDeleteDetailedInfo;
            this.buttonDeleteDetailedInfo.Location = new System.Drawing.Point(374, 26);
            this.buttonDeleteDetailedInfo.Name = "buttonDeleteDetailedInfo";
            this.buttonDeleteDetailedInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonDeleteDetailedInfo.ShadowDecoration.Parent = this.buttonDeleteDetailedInfo;
            this.buttonDeleteDetailedInfo.Size = new System.Drawing.Size(50, 50);
            this.buttonDeleteDetailedInfo.TabIndex = 27;
            this.buttonDeleteDetailedInfo.Tag = "";
            this.buttonDeleteDetailedInfo.Click += new System.EventHandler(this.buttonDeleteDetailedInfo_Click);
            // 
            // dateTimeDetailedRegistrationDate
            // 
            this.dateTimeDetailedRegistrationDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeDetailedRegistrationDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dateTimeDetailedRegistrationDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeDetailedRegistrationDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.dateTimeDetailedRegistrationDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dateTimeDetailedRegistrationDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dateTimeDetailedRegistrationDate.Checked = false;
            this.dateTimeDetailedRegistrationDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeDetailedRegistrationDate.Enabled = false;
            this.dateTimeDetailedRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeDetailedRegistrationDate.Location = new System.Drawing.Point(270, 358);
            this.dateTimeDetailedRegistrationDate.Name = "dateTimeDetailedRegistrationDate";
            this.dateTimeDetailedRegistrationDate.Size = new System.Drawing.Size(194, 29);
            this.dateTimeDetailedRegistrationDate.TabIndex = 10;
            // 
            // textBoxDetailedPassportNumber
            // 
            this.textBoxDetailedPassportNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedPassportNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedPassportNumber.DefaultText = "";
            this.textBoxDetailedPassportNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedPassportNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedPassportNumber.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedPassportNumber.DisabledState.Parent = this.textBoxDetailedPassportNumber;
            this.textBoxDetailedPassportNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedPassportNumber.Enabled = false;
            this.textBoxDetailedPassportNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedPassportNumber.FocusedState.Parent = this.textBoxDetailedPassportNumber;
            this.textBoxDetailedPassportNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedPassportNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedPassportNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedPassportNumber.HoverState.Parent = this.textBoxDetailedPassportNumber;
            this.textBoxDetailedPassportNumber.Location = new System.Drawing.Point(216, 294);
            this.textBoxDetailedPassportNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedPassportNumber.Name = "textBoxDetailedPassportNumber";
            this.textBoxDetailedPassportNumber.PasswordChar = '\0';
            this.textBoxDetailedPassportNumber.PlaceholderText = "";
            this.textBoxDetailedPassportNumber.SelectedText = "";
            this.textBoxDetailedPassportNumber.ShadowDecoration.Parent = this.textBoxDetailedPassportNumber;
            this.textBoxDetailedPassportNumber.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedPassportNumber.TabIndex = 26;
            this.textBoxDetailedPassportNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPassportNumber
            // 
            this.textPassportNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textPassportNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassportNumber.DefaultText = "Passport number:";
            this.textPassportNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textPassportNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.textPassportNumber.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textPassportNumber.DisabledState.Parent = this.textPassportNumber;
            this.textPassportNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassportNumber.Enabled = false;
            this.textPassportNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassportNumber.FocusedState.Parent = this.textPassportNumber;
            this.textPassportNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textPassportNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textPassportNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassportNumber.HoverState.Parent = this.textPassportNumber;
            this.textPassportNumber.Location = new System.Drawing.Point(27, 294);
            this.textPassportNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassportNumber.Name = "textPassportNumber";
            this.textPassportNumber.PasswordChar = '\0';
            this.textPassportNumber.PlaceholderText = "";
            this.textPassportNumber.ReadOnly = true;
            this.textPassportNumber.SelectedText = "";
            this.textPassportNumber.SelectionStart = 16;
            this.textPassportNumber.ShadowDecoration.Parent = this.textPassportNumber;
            this.textPassportNumber.Size = new System.Drawing.Size(190, 50);
            this.textPassportNumber.TabIndex = 25;
            this.textPassportNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDetailedActivity
            // 
            this.textBoxDetailedActivity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedActivity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedActivity.DefaultText = "";
            this.textBoxDetailedActivity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedActivity.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedActivity.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedActivity.DisabledState.Parent = this.textBoxDetailedActivity;
            this.textBoxDetailedActivity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedActivity.Enabled = false;
            this.textBoxDetailedActivity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedActivity.FocusedState.Parent = this.textBoxDetailedActivity;
            this.textBoxDetailedActivity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedActivity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedActivity.HoverState.Parent = this.textBoxDetailedActivity;
            this.textBoxDetailedActivity.Location = new System.Drawing.Point(216, 444);
            this.textBoxDetailedActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedActivity.Name = "textBoxDetailedActivity";
            this.textBoxDetailedActivity.PasswordChar = '\0';
            this.textBoxDetailedActivity.PlaceholderText = "";
            this.textBoxDetailedActivity.SelectedText = "";
            this.textBoxDetailedActivity.ShadowDecoration.Parent = this.textBoxDetailedActivity;
            this.textBoxDetailedActivity.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedActivity.TabIndex = 11;
            this.textBoxDetailedActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDetailedSecondName
            // 
            this.textBoxDetailedSecondName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedSecondName.DefaultText = "";
            this.textBoxDetailedSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedSecondName.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedSecondName.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedSecondName.DisabledState.Parent = this.textBoxDetailedSecondName;
            this.textBoxDetailedSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedSecondName.Enabled = false;
            this.textBoxDetailedSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedSecondName.FocusedState.Parent = this.textBoxDetailedSecondName;
            this.textBoxDetailedSecondName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedSecondName.HoverState.Parent = this.textBoxDetailedSecondName;
            this.textBoxDetailedSecondName.Location = new System.Drawing.Point(216, 94);
            this.textBoxDetailedSecondName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedSecondName.Name = "textBoxDetailedSecondName";
            this.textBoxDetailedSecondName.PasswordChar = '\0';
            this.textBoxDetailedSecondName.PlaceholderText = "";
            this.textBoxDetailedSecondName.SelectedText = "";
            this.textBoxDetailedSecondName.ShadowDecoration.Parent = this.textBoxDetailedSecondName;
            this.textBoxDetailedSecondName.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedSecondName.TabIndex = 1;
            this.textBoxDetailedSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDetailedRegistrationDate
            // 
            this.textBoxDetailedRegistrationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedRegistrationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedRegistrationDate.DefaultText = "";
            this.textBoxDetailedRegistrationDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedRegistrationDate.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedRegistrationDate.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedRegistrationDate.DisabledState.Parent = this.textBoxDetailedRegistrationDate;
            this.textBoxDetailedRegistrationDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedRegistrationDate.Enabled = false;
            this.textBoxDetailedRegistrationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedRegistrationDate.FocusedState.Parent = this.textBoxDetailedRegistrationDate;
            this.textBoxDetailedRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedRegistrationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedRegistrationDate.HoverState.Parent = this.textBoxDetailedRegistrationDate;
            this.textBoxDetailedRegistrationDate.Location = new System.Drawing.Point(216, 344);
            this.textBoxDetailedRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedRegistrationDate.Name = "textBoxDetailedRegistrationDate";
            this.textBoxDetailedRegistrationDate.PasswordChar = '\0';
            this.textBoxDetailedRegistrationDate.PlaceholderText = "";
            this.textBoxDetailedRegistrationDate.SelectedText = "";
            this.textBoxDetailedRegistrationDate.ShadowDecoration.Parent = this.textBoxDetailedRegistrationDate;
            this.textBoxDetailedRegistrationDate.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedRegistrationDate.TabIndex = 23;
            this.textBoxDetailedRegistrationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDetailedInfoCancel
            // 
            this.buttonDetailedInfoCancel.AutoSize = true;
            this.buttonDetailedInfoCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonDetailedInfoCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDetailedInfoCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonDetailedInfoCancel.Location = new System.Drawing.Point(468, 26);
            this.buttonDetailedInfoCancel.Name = "buttonDetailedInfoCancel";
            this.buttonDetailedInfoCancel.Size = new System.Drawing.Size(36, 32);
            this.buttonDetailedInfoCancel.TabIndex = 17;
            this.buttonDetailedInfoCancel.Text = "✕";
            this.buttonDetailedInfoCancel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonDetailedInfoCancel.Click += new System.EventHandler(this.buttonDetailedInfoCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Abonent info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textActivity
            // 
            this.textActivity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textActivity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textActivity.DefaultText = "Activity";
            this.textActivity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textActivity.DisabledState.FillColor = System.Drawing.Color.White;
            this.textActivity.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textActivity.DisabledState.Parent = this.textActivity;
            this.textActivity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textActivity.Enabled = false;
            this.textActivity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textActivity.FocusedState.Parent = this.textActivity;
            this.textActivity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textActivity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textActivity.HoverState.Parent = this.textActivity;
            this.textActivity.Location = new System.Drawing.Point(27, 444);
            this.textActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textActivity.Name = "textActivity";
            this.textActivity.PasswordChar = '\0';
            this.textActivity.PlaceholderText = "";
            this.textActivity.ReadOnly = true;
            this.textActivity.SelectedText = "";
            this.textActivity.SelectionStart = 8;
            this.textActivity.ShadowDecoration.Parent = this.textActivity;
            this.textActivity.Size = new System.Drawing.Size(190, 50);
            this.textActivity.TabIndex = 10;
            this.textActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textRegistrationDate
            // 
            this.textRegistrationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textRegistrationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRegistrationDate.DefaultText = "Registration date:";
            this.textRegistrationDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textRegistrationDate.DisabledState.FillColor = System.Drawing.Color.White;
            this.textRegistrationDate.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textRegistrationDate.DisabledState.Parent = this.textRegistrationDate;
            this.textRegistrationDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRegistrationDate.Enabled = false;
            this.textRegistrationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRegistrationDate.FocusedState.Parent = this.textRegistrationDate;
            this.textRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textRegistrationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRegistrationDate.HoverState.Parent = this.textRegistrationDate;
            this.textRegistrationDate.Location = new System.Drawing.Point(27, 344);
            this.textRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRegistrationDate.Name = "textRegistrationDate";
            this.textRegistrationDate.PasswordChar = '\0';
            this.textRegistrationDate.PlaceholderText = "";
            this.textRegistrationDate.ReadOnly = true;
            this.textRegistrationDate.SelectedText = "";
            this.textRegistrationDate.SelectionStart = 18;
            this.textRegistrationDate.ShadowDecoration.Parent = this.textRegistrationDate;
            this.textRegistrationDate.Size = new System.Drawing.Size(190, 50);
            this.textRegistrationDate.TabIndex = 8;
            this.textRegistrationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDetailedMiddleName
            // 
            this.textBoxDetailedMiddleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedMiddleName.DefaultText = "";
            this.textBoxDetailedMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedMiddleName.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedMiddleName.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedMiddleName.DisabledState.Parent = this.textBoxDetailedMiddleName;
            this.textBoxDetailedMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedMiddleName.Enabled = false;
            this.textBoxDetailedMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedMiddleName.FocusedState.Parent = this.textBoxDetailedMiddleName;
            this.textBoxDetailedMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedMiddleName.HoverState.Parent = this.textBoxDetailedMiddleName;
            this.textBoxDetailedMiddleName.Location = new System.Drawing.Point(216, 194);
            this.textBoxDetailedMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedMiddleName.Name = "textBoxDetailedMiddleName";
            this.textBoxDetailedMiddleName.PasswordChar = '\0';
            this.textBoxDetailedMiddleName.PlaceholderText = "";
            this.textBoxDetailedMiddleName.SelectedText = "";
            this.textBoxDetailedMiddleName.ShadowDecoration.Parent = this.textBoxDetailedMiddleName;
            this.textBoxDetailedMiddleName.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedMiddleName.TabIndex = 7;
            this.textBoxDetailedMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMiddleName
            // 
            this.textMiddleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMiddleName.DefaultText = "Middle name:";
            this.textMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textMiddleName.DisabledState.FillColor = System.Drawing.Color.White;
            this.textMiddleName.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textMiddleName.DisabledState.Parent = this.textMiddleName;
            this.textMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMiddleName.Enabled = false;
            this.textMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMiddleName.FocusedState.Parent = this.textMiddleName;
            this.textMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMiddleName.HoverState.Parent = this.textMiddleName;
            this.textMiddleName.Location = new System.Drawing.Point(27, 194);
            this.textMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.PasswordChar = '\0';
            this.textMiddleName.PlaceholderText = "";
            this.textMiddleName.ReadOnly = true;
            this.textMiddleName.SelectedText = "";
            this.textMiddleName.SelectionStart = 12;
            this.textMiddleName.ShadowDecoration.Parent = this.textMiddleName;
            this.textMiddleName.Size = new System.Drawing.Size(190, 50);
            this.textMiddleName.TabIndex = 6;
            this.textMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDetailedFirstName
            // 
            this.textBoxDetailedFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedFirstName.DefaultText = "";
            this.textBoxDetailedFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedFirstName.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedFirstName.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedFirstName.DisabledState.Parent = this.textBoxDetailedFirstName;
            this.textBoxDetailedFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedFirstName.Enabled = false;
            this.textBoxDetailedFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedFirstName.FocusedState.Parent = this.textBoxDetailedFirstName;
            this.textBoxDetailedFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedFirstName.HoverState.Parent = this.textBoxDetailedFirstName;
            this.textBoxDetailedFirstName.Location = new System.Drawing.Point(216, 144);
            this.textBoxDetailedFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedFirstName.Name = "textBoxDetailedFirstName";
            this.textBoxDetailedFirstName.PasswordChar = '\0';
            this.textBoxDetailedFirstName.PlaceholderText = "";
            this.textBoxDetailedFirstName.SelectedText = "";
            this.textBoxDetailedFirstName.ShadowDecoration.Parent = this.textBoxDetailedFirstName;
            this.textBoxDetailedFirstName.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedFirstName.TabIndex = 5;
            this.textBoxDetailedFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSecondName
            // 
            this.textSecondName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSecondName.DefaultText = "Second name:";
            this.textSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textSecondName.DisabledState.FillColor = System.Drawing.Color.White;
            this.textSecondName.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textSecondName.DisabledState.Parent = this.textSecondName;
            this.textSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSecondName.Enabled = false;
            this.textSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSecondName.FocusedState.Parent = this.textSecondName;
            this.textSecondName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSecondName.HoverState.Parent = this.textSecondName;
            this.textSecondName.Location = new System.Drawing.Point(27, 94);
            this.textSecondName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.PasswordChar = '\0';
            this.textSecondName.PlaceholderText = "";
            this.textSecondName.ReadOnly = true;
            this.textSecondName.SelectedText = "";
            this.textSecondName.SelectionStart = 12;
            this.textSecondName.ShadowDecoration.Parent = this.textSecondName;
            this.textSecondName.Size = new System.Drawing.Size(190, 50);
            this.textSecondName.TabIndex = 4;
            this.textSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDetailedPhoneNumber
            // 
            this.textBoxDetailedPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailedPhoneNumber.DefaultText = "";
            this.textBoxDetailedPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxDetailedPhoneNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.textBoxDetailedPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textBoxDetailedPhoneNumber.DisabledState.Parent = this.textBoxDetailedPhoneNumber;
            this.textBoxDetailedPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDetailedPhoneNumber.Enabled = false;
            this.textBoxDetailedPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedPhoneNumber.FocusedState.Parent = this.textBoxDetailedPhoneNumber;
            this.textBoxDetailedPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDetailedPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textBoxDetailedPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxDetailedPhoneNumber.HoverState.Parent = this.textBoxDetailedPhoneNumber;
            this.textBoxDetailedPhoneNumber.Location = new System.Drawing.Point(216, 244);
            this.textBoxDetailedPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDetailedPhoneNumber.Name = "textBoxDetailedPhoneNumber";
            this.textBoxDetailedPhoneNumber.PasswordChar = '\0';
            this.textBoxDetailedPhoneNumber.PlaceholderText = "";
            this.textBoxDetailedPhoneNumber.SelectedText = "";
            this.textBoxDetailedPhoneNumber.ShadowDecoration.Parent = this.textBoxDetailedPhoneNumber;
            this.textBoxDetailedPhoneNumber.Size = new System.Drawing.Size(290, 50);
            this.textBoxDetailedPhoneNumber.TabIndex = 3;
            this.textBoxDetailedPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhoneNumber.DefaultText = "Phone number:";
            this.textPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textPhoneNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.textPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textPhoneNumber.DisabledState.Parent = this.textPhoneNumber;
            this.textPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPhoneNumber.Enabled = false;
            this.textPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPhoneNumber.FocusedState.Parent = this.textPhoneNumber;
            this.textPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPhoneNumber.HoverState.Parent = this.textPhoneNumber;
            this.textPhoneNumber.Location = new System.Drawing.Point(27, 244);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.PasswordChar = '\0';
            this.textPhoneNumber.PlaceholderText = "";
            this.textPhoneNumber.ReadOnly = true;
            this.textPhoneNumber.SelectedText = "";
            this.textPhoneNumber.SelectionStart = 13;
            this.textPhoneNumber.ShadowDecoration.Parent = this.textPhoneNumber;
            this.textPhoneNumber.Size = new System.Drawing.Size(190, 50);
            this.textPhoneNumber.TabIndex = 2;
            this.textPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFirstName
            // 
            this.textFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFirstName.DefaultText = "First name:";
            this.textFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textFirstName.DisabledState.FillColor = System.Drawing.Color.White;
            this.textFirstName.DisabledState.ForeColor = System.Drawing.Color.White;
            this.textFirstName.DisabledState.Parent = this.textFirstName;
            this.textFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textFirstName.Enabled = false;
            this.textFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textFirstName.FocusedState.Parent = this.textFirstName;
            this.textFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.textFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textFirstName.HoverState.Parent = this.textFirstName;
            this.textFirstName.Location = new System.Drawing.Point(27, 144);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.PasswordChar = '\0';
            this.textFirstName.PlaceholderText = "";
            this.textFirstName.ReadOnly = true;
            this.textFirstName.SelectedText = "";
            this.textFirstName.SelectionStart = 11;
            this.textFirstName.ShadowDecoration.Parent = this.textFirstName;
            this.textFirstName.Size = new System.Drawing.Size(190, 50);
            this.textFirstName.TabIndex = 0;
            this.textFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.phonenumbermainDataGridViewTextBoxColumn,
            this.registrationdateDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn,
            this.tariffplanDataGridViewTextBoxColumn,
            this.passport_number,
            this.id});
            this.dataGridView.DataSource = this.abonentsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(50, 117);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 60;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dataGridView.RowTemplate.Height = 50;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1264, 633);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridView.ThemeStyle.ReadOnly = true;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.fullnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fullnameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // phonenumbermainDataGridViewTextBoxColumn
            // 
            this.phonenumbermainDataGridViewTextBoxColumn.DataPropertyName = "phone_number_main";
            this.phonenumbermainDataGridViewTextBoxColumn.FillWeight = 26F;
            this.phonenumbermainDataGridViewTextBoxColumn.HeaderText = "phone_number_main";
            this.phonenumbermainDataGridViewTextBoxColumn.Name = "phonenumbermainDataGridViewTextBoxColumn";
            this.phonenumbermainDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumbermainDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // registrationdateDataGridViewTextBoxColumn
            // 
            this.registrationdateDataGridViewTextBoxColumn.DataPropertyName = "registration_date";
            this.registrationdateDataGridViewTextBoxColumn.FillWeight = 26F;
            this.registrationdateDataGridViewTextBoxColumn.HeaderText = "registration_date";
            this.registrationdateDataGridViewTextBoxColumn.Name = "registrationdateDataGridViewTextBoxColumn";
            this.registrationdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationdateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "activity";
            this.activityDataGridViewTextBoxColumn.FillWeight = 19F;
            this.activityDataGridViewTextBoxColumn.HeaderText = "activity";
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            this.activityDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tariffplanDataGridViewTextBoxColumn
            // 
            this.tariffplanDataGridViewTextBoxColumn.DataPropertyName = "tariff_plan";
            this.tariffplanDataGridViewTextBoxColumn.FillWeight = 26F;
            this.tariffplanDataGridViewTextBoxColumn.HeaderText = "tariff_plan";
            this.tariffplanDataGridViewTextBoxColumn.Name = "tariffplanDataGridViewTextBoxColumn";
            this.tariffplanDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariffplanDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passport_number
            // 
            this.passport_number.DataPropertyName = "passport_number";
            this.passport_number.FillWeight = 1F;
            this.passport_number.HeaderText = "passport_number";
            this.passport_number.Name = "passport_number";
            this.passport_number.ReadOnly = true;
            this.passport_number.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // abonentsBindingSource
            // 
            this.abonentsBindingSource.DataMember = "abonents";
            this.abonentsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelDataHeader
            // 
            this.panelDataHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelDataHeader.Controls.Add(this.panelFullNameData);
            this.panelDataHeader.Controls.Add(this.panelTariffPlan);
            this.panelDataHeader.Controls.Add(this.panelPhoneNumberMainData);
            this.panelDataHeader.Controls.Add(this.panelActivity);
            this.panelDataHeader.Controls.Add(this.panelRegistrationDate);
            this.panelDataHeader.Location = new System.Drawing.Point(50, 35);
            this.panelDataHeader.Name = "panelDataHeader";
            this.panelDataHeader.Size = new System.Drawing.Size(1264, 83);
            this.panelDataHeader.TabIndex = 25;
            // 
            // panelFullNameData
            // 
            this.panelFullNameData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelFullNameData.Controls.Add(this.pictureBoxArrowFullName);
            this.panelFullNameData.Controls.Add(this.textBoxFullNameSearch);
            this.panelFullNameData.Controls.Add(this.buttonFullNameDataSort);
            this.panelFullNameData.Location = new System.Drawing.Point(0, 0);
            this.panelFullNameData.Name = "panelFullNameData";
            this.panelFullNameData.Size = new System.Drawing.Size(498, 83);
            this.panelFullNameData.TabIndex = 14;
            // 
            // pictureBoxArrowFullName
            // 
            this.pictureBoxArrowFullName.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowFullName.Image = global::TestDBapp.Properties.Resources.arrow_template;
            this.pictureBoxArrowFullName.Location = new System.Drawing.Point(83, 20);
            this.pictureBoxArrowFullName.Name = "pictureBoxArrowFullName";
            this.pictureBoxArrowFullName.Size = new System.Drawing.Size(17, 15);
            this.pictureBoxArrowFullName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrowFullName.TabIndex = 15;
            this.pictureBoxArrowFullName.TabStop = false;
            // 
            // buttonFullNameDataSort
            // 
            this.buttonFullNameDataSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonFullNameDataSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonFullNameDataSort.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFullNameDataSort.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonFullNameDataSort.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.buttonFullNameDataSort.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFullNameDataSort.CheckedState.Parent = this.buttonFullNameDataSort;
            this.buttonFullNameDataSort.CustomImages.Parent = this.buttonFullNameDataSort;
            this.buttonFullNameDataSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFullNameDataSort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonFullNameDataSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFullNameDataSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonFullNameDataSort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonFullNameDataSort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonFullNameDataSort.HoverState.Parent = this.buttonFullNameDataSort;
            this.buttonFullNameDataSort.Location = new System.Drawing.Point(0, 0);
            this.buttonFullNameDataSort.Name = "buttonFullNameDataSort";
            this.buttonFullNameDataSort.PressedColor = System.Drawing.Color.Transparent;
            this.buttonFullNameDataSort.PressedDepth = 0;
            this.buttonFullNameDataSort.ShadowDecoration.Parent = this.buttonFullNameDataSort;
            this.buttonFullNameDataSort.Size = new System.Drawing.Size(498, 83);
            this.buttonFullNameDataSort.TabIndex = 19;
            this.buttonFullNameDataSort.Text = "Full name";
            this.buttonFullNameDataSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonFullNameDataSort.TextOffset = new System.Drawing.Point(-3, -15);
            this.buttonFullNameDataSort.Click += new System.EventHandler(this.buttonFullNameDataSort_Click);
            // 
            // panelTariffPlan
            // 
            this.panelTariffPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelTariffPlan.Controls.Add(this.pictureBoxArrowTariffPlan);
            this.panelTariffPlan.Controls.Add(this.guna2TextBox1);
            this.panelTariffPlan.Controls.Add(this.buttonTariffPlanDataSort);
            this.panelTariffPlan.Location = new System.Drawing.Point(1048, 0);
            this.panelTariffPlan.Name = "panelTariffPlan";
            this.panelTariffPlan.Size = new System.Drawing.Size(216, 83);
            this.panelTariffPlan.TabIndex = 24;
            // 
            // pictureBoxArrowTariffPlan
            // 
            this.pictureBoxArrowTariffPlan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowTariffPlan.Image = global::TestDBapp.Properties.Resources.arrow_template;
            this.pictureBoxArrowTariffPlan.Location = new System.Drawing.Point(86, 20);
            this.pictureBoxArrowTariffPlan.Name = "pictureBoxArrowTariffPlan";
            this.pictureBoxArrowTariffPlan.Size = new System.Drawing.Size(17, 15);
            this.pictureBoxArrowTariffPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrowTariffPlan.TabIndex = 15;
            this.pictureBoxArrowTariffPlan.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.guna2TextBox1.BorderRadius = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(10, 43);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.BorderRadius = 110;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(174, 28);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // buttonTariffPlanDataSort
            // 
            this.buttonTariffPlanDataSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonTariffPlanDataSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonTariffPlanDataSort.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonTariffPlanDataSort.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonTariffPlanDataSort.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.buttonTariffPlanDataSort.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTariffPlanDataSort.CheckedState.Parent = this.buttonTariffPlanDataSort;
            this.buttonTariffPlanDataSort.CustomImages.Parent = this.buttonTariffPlanDataSort;
            this.buttonTariffPlanDataSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTariffPlanDataSort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonTariffPlanDataSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTariffPlanDataSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonTariffPlanDataSort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonTariffPlanDataSort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonTariffPlanDataSort.HoverState.Parent = this.buttonTariffPlanDataSort;
            this.buttonTariffPlanDataSort.Location = new System.Drawing.Point(0, 0);
            this.buttonTariffPlanDataSort.Name = "buttonTariffPlanDataSort";
            this.buttonTariffPlanDataSort.PressedColor = System.Drawing.Color.Transparent;
            this.buttonTariffPlanDataSort.PressedDepth = 0;
            this.buttonTariffPlanDataSort.ShadowDecoration.Parent = this.buttonTariffPlanDataSort;
            this.buttonTariffPlanDataSort.Size = new System.Drawing.Size(216, 83);
            this.buttonTariffPlanDataSort.TabIndex = 19;
            this.buttonTariffPlanDataSort.Text = "Tariff plan";
            this.buttonTariffPlanDataSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonTariffPlanDataSort.TextOffset = new System.Drawing.Point(-4, -15);
            this.buttonTariffPlanDataSort.Click += new System.EventHandler(this.buttonTariffPlanDataSort_Click);
            // 
            // panelPhoneNumberMainData
            // 
            this.panelPhoneNumberMainData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelPhoneNumberMainData.Controls.Add(this.pictureBoxArrowNumberMain);
            this.panelPhoneNumberMainData.Controls.Add(this.textBoxNumberMainSearch);
            this.panelPhoneNumberMainData.Controls.Add(this.buttonNumberMainDataSort);
            this.panelPhoneNumberMainData.Location = new System.Drawing.Point(499, 0);
            this.panelPhoneNumberMainData.Name = "panelPhoneNumberMainData";
            this.panelPhoneNumberMainData.Size = new System.Drawing.Size(200, 83);
            this.panelPhoneNumberMainData.TabIndex = 20;
            // 
            // pictureBoxArrowNumberMain
            // 
            this.pictureBoxArrowNumberMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowNumberMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxArrowNumberMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArrowNumberMain.Image = global::TestDBapp.Properties.Resources.arrow_template;
            this.pictureBoxArrowNumberMain.Location = new System.Drawing.Point(122, 20);
            this.pictureBoxArrowNumberMain.Name = "pictureBoxArrowNumberMain";
            this.pictureBoxArrowNumberMain.Size = new System.Drawing.Size(17, 15);
            this.pictureBoxArrowNumberMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrowNumberMain.TabIndex = 15;
            this.pictureBoxArrowNumberMain.TabStop = false;
            // 
            // textBoxNumberMainSearch
            // 
            this.textBoxNumberMainSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxNumberMainSearch.BorderRadius = 3;
            this.textBoxNumberMainSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumberMainSearch.DefaultText = "";
            this.textBoxNumberMainSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNumberMainSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNumberMainSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNumberMainSearch.DisabledState.Parent = this.textBoxNumberMainSearch;
            this.textBoxNumberMainSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNumberMainSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxNumberMainSearch.FocusedState.Parent = this.textBoxNumberMainSearch;
            this.textBoxNumberMainSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberMainSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNumberMainSearch.HoverState.Parent = this.textBoxNumberMainSearch;
            this.textBoxNumberMainSearch.Location = new System.Drawing.Point(10, 43);
            this.textBoxNumberMainSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumberMainSearch.Name = "textBoxNumberMainSearch";
            this.textBoxNumberMainSearch.PasswordChar = '\0';
            this.textBoxNumberMainSearch.PlaceholderText = "";
            this.textBoxNumberMainSearch.SelectedText = "";
            this.textBoxNumberMainSearch.ShadowDecoration.BorderRadius = 110;
            this.textBoxNumberMainSearch.ShadowDecoration.Parent = this.textBoxNumberMainSearch;
            this.textBoxNumberMainSearch.Size = new System.Drawing.Size(174, 28);
            this.textBoxNumberMainSearch.TabIndex = 1;
            this.textBoxNumberMainSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumberMainSearch_KeyDown);
            // 
            // buttonNumberMainDataSort
            // 
            this.buttonNumberMainDataSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonNumberMainDataSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonNumberMainDataSort.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonNumberMainDataSort.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonNumberMainDataSort.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.buttonNumberMainDataSort.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNumberMainDataSort.CheckedState.Parent = this.buttonNumberMainDataSort;
            this.buttonNumberMainDataSort.CustomImages.Parent = this.buttonNumberMainDataSort;
            this.buttonNumberMainDataSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberMainDataSort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonNumberMainDataSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNumberMainDataSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonNumberMainDataSort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonNumberMainDataSort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonNumberMainDataSort.HoverState.Parent = this.buttonNumberMainDataSort;
            this.buttonNumberMainDataSort.Location = new System.Drawing.Point(0, 0);
            this.buttonNumberMainDataSort.Name = "buttonNumberMainDataSort";
            this.buttonNumberMainDataSort.PressedColor = System.Drawing.Color.Transparent;
            this.buttonNumberMainDataSort.PressedDepth = 0;
            this.buttonNumberMainDataSort.ShadowDecoration.Parent = this.buttonNumberMainDataSort;
            this.buttonNumberMainDataSort.Size = new System.Drawing.Size(200, 83);
            this.buttonNumberMainDataSort.TabIndex = 19;
            this.buttonNumberMainDataSort.Text = "Phone number";
            this.buttonNumberMainDataSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonNumberMainDataSort.TextOffset = new System.Drawing.Point(-4, -15);
            this.buttonNumberMainDataSort.Click += new System.EventHandler(this.buttonNumberMainDataSort_Click);
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelActivity.Controls.Add(this.pictureBoxArrowActivity);
            this.panelActivity.Controls.Add(this.textBoxActivitySearch);
            this.panelActivity.Controls.Add(this.buttonActivityDataSort);
            this.panelActivity.Location = new System.Drawing.Point(898, 0);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(149, 83);
            this.panelActivity.TabIndex = 23;
            // 
            // pictureBoxArrowActivity
            // 
            this.pictureBoxArrowActivity.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowActivity.Image = global::TestDBapp.Properties.Resources.arrow_template;
            this.pictureBoxArrowActivity.Location = new System.Drawing.Point(70, 20);
            this.pictureBoxArrowActivity.Name = "pictureBoxArrowActivity";
            this.pictureBoxArrowActivity.Size = new System.Drawing.Size(17, 15);
            this.pictureBoxArrowActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrowActivity.TabIndex = 15;
            this.pictureBoxArrowActivity.TabStop = false;
            // 
            // textBoxActivitySearch
            // 
            this.textBoxActivitySearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxActivitySearch.BorderRadius = 3;
            this.textBoxActivitySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxActivitySearch.DefaultText = "";
            this.textBoxActivitySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxActivitySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxActivitySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxActivitySearch.DisabledState.Parent = this.textBoxActivitySearch;
            this.textBoxActivitySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxActivitySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxActivitySearch.FocusedState.Parent = this.textBoxActivitySearch;
            this.textBoxActivitySearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxActivitySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxActivitySearch.HoverState.Parent = this.textBoxActivitySearch;
            this.textBoxActivitySearch.Location = new System.Drawing.Point(10, 43);
            this.textBoxActivitySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxActivitySearch.Name = "textBoxActivitySearch";
            this.textBoxActivitySearch.PasswordChar = '\0';
            this.textBoxActivitySearch.PlaceholderText = "";
            this.textBoxActivitySearch.SelectedText = "";
            this.textBoxActivitySearch.ShadowDecoration.BorderRadius = 110;
            this.textBoxActivitySearch.ShadowDecoration.Parent = this.textBoxActivitySearch;
            this.textBoxActivitySearch.Size = new System.Drawing.Size(125, 28);
            this.textBoxActivitySearch.TabIndex = 1;
            // 
            // buttonActivityDataSort
            // 
            this.buttonActivityDataSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonActivityDataSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonActivityDataSort.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonActivityDataSort.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonActivityDataSort.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.buttonActivityDataSort.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonActivityDataSort.CheckedState.Parent = this.buttonActivityDataSort;
            this.buttonActivityDataSort.CustomImages.Parent = this.buttonActivityDataSort;
            this.buttonActivityDataSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActivityDataSort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonActivityDataSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActivityDataSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonActivityDataSort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonActivityDataSort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonActivityDataSort.HoverState.Parent = this.buttonActivityDataSort;
            this.buttonActivityDataSort.Location = new System.Drawing.Point(0, 0);
            this.buttonActivityDataSort.Name = "buttonActivityDataSort";
            this.buttonActivityDataSort.PressedColor = System.Drawing.Color.Transparent;
            this.buttonActivityDataSort.PressedDepth = 0;
            this.buttonActivityDataSort.ShadowDecoration.Parent = this.buttonActivityDataSort;
            this.buttonActivityDataSort.Size = new System.Drawing.Size(149, 83);
            this.buttonActivityDataSort.TabIndex = 19;
            this.buttonActivityDataSort.Text = "Activity";
            this.buttonActivityDataSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonActivityDataSort.TextOffset = new System.Drawing.Point(-4, -15);
            this.buttonActivityDataSort.Click += new System.EventHandler(this.buttonActivityDataSort_Click);
            // 
            // panelRegistrationDate
            // 
            this.panelRegistrationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelRegistrationDate.Controls.Add(this.pictureBoxArrowRegistrationDate);
            this.panelRegistrationDate.Controls.Add(this.textBoxRegistrationDateSearch);
            this.panelRegistrationDate.Controls.Add(this.buttonRegistrationDateDataSort);
            this.panelRegistrationDate.Location = new System.Drawing.Point(700, 0);
            this.panelRegistrationDate.Name = "panelRegistrationDate";
            this.panelRegistrationDate.Size = new System.Drawing.Size(197, 83);
            this.panelRegistrationDate.TabIndex = 22;
            // 
            // pictureBoxArrowRegistrationDate
            // 
            this.pictureBoxArrowRegistrationDate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowRegistrationDate.Image = global::TestDBapp.Properties.Resources.arrow_template;
            this.pictureBoxArrowRegistrationDate.Location = new System.Drawing.Point(140, 20);
            this.pictureBoxArrowRegistrationDate.Name = "pictureBoxArrowRegistrationDate";
            this.pictureBoxArrowRegistrationDate.Size = new System.Drawing.Size(17, 15);
            this.pictureBoxArrowRegistrationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrowRegistrationDate.TabIndex = 15;
            this.pictureBoxArrowRegistrationDate.TabStop = false;
            // 
            // textBoxRegistrationDateSearch
            // 
            this.textBoxRegistrationDateSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBoxRegistrationDateSearch.BorderRadius = 3;
            this.textBoxRegistrationDateSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRegistrationDateSearch.DefaultText = "";
            this.textBoxRegistrationDateSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxRegistrationDateSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxRegistrationDateSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRegistrationDateSearch.DisabledState.Parent = this.textBoxRegistrationDateSearch;
            this.textBoxRegistrationDateSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRegistrationDateSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxRegistrationDateSearch.FocusedState.Parent = this.textBoxRegistrationDateSearch;
            this.textBoxRegistrationDateSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegistrationDateSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRegistrationDateSearch.HoverState.Parent = this.textBoxRegistrationDateSearch;
            this.textBoxRegistrationDateSearch.Location = new System.Drawing.Point(10, 43);
            this.textBoxRegistrationDateSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRegistrationDateSearch.Name = "textBoxRegistrationDateSearch";
            this.textBoxRegistrationDateSearch.PasswordChar = '\0';
            this.textBoxRegistrationDateSearch.PlaceholderText = "";
            this.textBoxRegistrationDateSearch.SelectedText = "";
            this.textBoxRegistrationDateSearch.ShadowDecoration.BorderRadius = 110;
            this.textBoxRegistrationDateSearch.ShadowDecoration.Parent = this.textBoxRegistrationDateSearch;
            this.textBoxRegistrationDateSearch.Size = new System.Drawing.Size(176, 28);
            this.textBoxRegistrationDateSearch.TabIndex = 1;
            // 
            // buttonRegistrationDateDataSort
            // 
            this.buttonRegistrationDateDataSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrationDateDataSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonRegistrationDateDataSort.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonRegistrationDateDataSort.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonRegistrationDateDataSort.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.buttonRegistrationDateDataSort.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRegistrationDateDataSort.CheckedState.Parent = this.buttonRegistrationDateDataSort;
            this.buttonRegistrationDateDataSort.CustomImages.Parent = this.buttonRegistrationDateDataSort;
            this.buttonRegistrationDateDataSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegistrationDateDataSort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.buttonRegistrationDateDataSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrationDateDataSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.buttonRegistrationDateDataSort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonRegistrationDateDataSort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonRegistrationDateDataSort.HoverState.Parent = this.buttonRegistrationDateDataSort;
            this.buttonRegistrationDateDataSort.Location = new System.Drawing.Point(0, 0);
            this.buttonRegistrationDateDataSort.Name = "buttonRegistrationDateDataSort";
            this.buttonRegistrationDateDataSort.PressedColor = System.Drawing.Color.Transparent;
            this.buttonRegistrationDateDataSort.PressedDepth = 0;
            this.buttonRegistrationDateDataSort.ShadowDecoration.Parent = this.buttonRegistrationDateDataSort;
            this.buttonRegistrationDateDataSort.Size = new System.Drawing.Size(197, 83);
            this.buttonRegistrationDateDataSort.TabIndex = 19;
            this.buttonRegistrationDateDataSort.Text = "Registration date";
            this.buttonRegistrationDateDataSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonRegistrationDateDataSort.TextOffset = new System.Drawing.Point(-4, -15);
            this.buttonRegistrationDateDataSort.Click += new System.EventHandler(this.buttonRegistrationDateDataSort_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelTotal.Location = new System.Drawing.Point(157, 71);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 25);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total: ";
            // 
            // PanelTotalActive
            // 
            this.PanelTotalActive.BackColor = System.Drawing.Color.Transparent;
            this.PanelTotalActive.Controls.Add(this.textBoxActiveAbonentsCount);
            this.PanelTotalActive.Controls.Add(this.textBoxTotalAbonentsCount);
            this.PanelTotalActive.Controls.Add(this.label3);
            this.PanelTotalActive.Controls.Add(this.buttonAddNewAbonent);
            this.PanelTotalActive.Controls.Add(this.label1);
            this.PanelTotalActive.Controls.Add(this.pictureBox1);
            this.PanelTotalActive.Controls.Add(this.labelTotal);
            this.PanelTotalActive.FillColor = System.Drawing.Color.White;
            this.PanelTotalActive.Location = new System.Drawing.Point(29, 23);
            this.PanelTotalActive.Name = "PanelTotalActive";
            this.PanelTotalActive.Radius = 3;
            this.PanelTotalActive.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.PanelTotalActive.ShadowDepth = 40;
            this.PanelTotalActive.ShadowShift = 6;
            this.PanelTotalActive.Size = new System.Drawing.Size(460, 156);
            this.PanelTotalActive.TabIndex = 13;
            // 
            // textBoxActiveAbonentsCount
            // 
            this.textBoxActiveAbonentsCount.AutoSize = true;
            this.textBoxActiveAbonentsCount.BackColor = System.Drawing.Color.Transparent;
            this.textBoxActiveAbonentsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxActiveAbonentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxActiveAbonentsCount.Location = new System.Drawing.Point(225, 102);
            this.textBoxActiveAbonentsCount.Name = "textBoxActiveAbonentsCount";
            this.textBoxActiveAbonentsCount.Size = new System.Drawing.Size(63, 25);
            this.textBoxActiveAbonentsCount.TabIndex = 37;
            this.textBoxActiveAbonentsCount.Text = "active";
            // 
            // textBoxTotalAbonentsCount
            // 
            this.textBoxTotalAbonentsCount.AutoSize = true;
            this.textBoxTotalAbonentsCount.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTotalAbonentsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalAbonentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.textBoxTotalAbonentsCount.Location = new System.Drawing.Point(212, 71);
            this.textBoxTotalAbonentsCount.Name = "textBoxTotalAbonentsCount";
            this.textBoxTotalAbonentsCount.Size = new System.Drawing.Size(52, 25);
            this.textBoxTotalAbonentsCount.TabIndex = 36;
            this.textBoxTotalAbonentsCount.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(157, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Active: ";
            // 
            // buttonAddNewAbonent
            // 
            this.buttonAddNewAbonent.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewAbonent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonAddNewAbonent.BorderRadius = 3;
            this.buttonAddNewAbonent.BorderThickness = 2;
            this.buttonAddNewAbonent.CheckedState.Parent = this.buttonAddNewAbonent;
            this.buttonAddNewAbonent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewAbonent.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonAddNewAbonent.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonAddNewAbonent.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonAddNewAbonent.CustomImages.Parent = this.buttonAddNewAbonent;
            this.buttonAddNewAbonent.FillColor = System.Drawing.Color.White;
            this.buttonAddNewAbonent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewAbonent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonAddNewAbonent.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonAddNewAbonent.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewAbonent.HoverState.Parent = this.buttonAddNewAbonent;
            this.buttonAddNewAbonent.Image = global::TestDBapp.Properties.Resources.new_abonent;
            this.buttonAddNewAbonent.ImageOffset = new System.Drawing.Point(18, 13);
            this.buttonAddNewAbonent.ImageSize = new System.Drawing.Size(50, 50);
            this.buttonAddNewAbonent.Location = new System.Drawing.Point(347, 30);
            this.buttonAddNewAbonent.Name = "buttonAddNewAbonent";
            this.buttonAddNewAbonent.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonAddNewAbonent.ShadowDecoration.Parent = this.buttonAddNewAbonent;
            this.buttonAddNewAbonent.Size = new System.Drawing.Size(90, 97);
            this.buttonAddNewAbonent.TabIndex = 33;
            this.buttonAddNewAbonent.Tag = "";
            this.buttonAddNewAbonent.Text = "Add new";
            this.buttonAddNewAbonent.TextOffset = new System.Drawing.Point(-13, -25);
            this.buttonAddNewAbonent.Click += new System.EventHandler(this.buttonAddNewAbonent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(156, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Abonents";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panelHelper);
            this.guna2ShadowPanel1.Controls.Add(this.buttonHelper);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(510, 23);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 3;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.ShadowShift = 6;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(881, 156);
            this.guna2ShadowPanel1.TabIndex = 14;
            // 
            // panelHelper
            // 
            this.panelHelper.Controls.Add(this.label7);
            this.panelHelper.Controls.Add(this.label6);
            this.panelHelper.Controls.Add(this.label5);
            this.panelHelper.Controls.Add(this.label4);
            this.panelHelper.Controls.Add(this.guna2PictureBox5);
            this.panelHelper.Controls.Add(this.guna2PictureBox4);
            this.panelHelper.Controls.Add(this.guna2PictureBox3);
            this.panelHelper.Controls.Add(this.guna2PictureBox2);
            this.panelHelper.Location = new System.Drawing.Point(122, 30);
            this.panelHelper.Name = "panelHelper";
            this.panelHelper.ShadowDecoration.Parent = this.panelHelper;
            this.panelHelper.Size = new System.Drawing.Size(356, 97);
            this.panelHelper.TabIndex = 36;
            this.panelHelper.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(201, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "- sort in category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(46, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "- save changes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(201, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "- delete data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(46, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "- edit data";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = global::TestDBapp.Properties.Resources.arrow_template;
            this.guna2PictureBox5.InitialImage = null;
            this.guna2PictureBox5.Location = new System.Drawing.Point(168, 63);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.ShadowDecoration.Parent = this.guna2PictureBox5;
            this.guna2PictureBox5.Size = new System.Drawing.Size(22, 37);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 3;
            this.guna2PictureBox5.TabStop = false;
            this.guna2PictureBox5.UseTransparentBackground = true;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::TestDBapp.Properties.Resources.delete;
            this.guna2PictureBox4.InitialImage = null;
            this.guna2PictureBox4.Location = new System.Drawing.Point(158, 0);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 2;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::TestDBapp.Properties.Resources.ok1;
            this.guna2PictureBox3.InitialImage = null;
            this.guna2PictureBox3.Location = new System.Drawing.Point(0, 57);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::TestDBapp.Properties.Resources.edit;
            this.guna2PictureBox2.InitialImage = null;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // buttonHelper
            // 
            this.buttonHelper.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelper.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonHelper.BorderRadius = 3;
            this.buttonHelper.BorderThickness = 2;
            this.buttonHelper.CheckedState.Parent = this.buttonHelper;
            this.buttonHelper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelper.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonHelper.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.buttonHelper.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonHelper.CustomImages.Parent = this.buttonHelper;
            this.buttonHelper.FillColor = System.Drawing.Color.White;
            this.buttonHelper.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonHelper.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonHelper.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonHelper.HoverState.Parent = this.buttonHelper;
            this.buttonHelper.Location = new System.Drawing.Point(25, 30);
            this.buttonHelper.Name = "buttonHelper";
            this.buttonHelper.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonHelper.ShadowDecoration.BorderRadius = 30;
            this.buttonHelper.ShadowDecoration.Color = System.Drawing.Color.White;
            this.buttonHelper.ShadowDecoration.Parent = this.buttonHelper;
            this.buttonHelper.Size = new System.Drawing.Size(90, 97);
            this.buttonHelper.TabIndex = 34;
            this.buttonHelper.Tag = "";
            this.buttonHelper.Text = "?";
            this.buttonHelper.MouseEnter += new System.EventHandler(this.buttonHelper_MouseEnter);
            this.buttonHelper.MouseLeave += new System.EventHandler(this.buttonHelper_MouseLeave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 6;
            this.guna2PictureBox1.Image = global::TestDBapp.Properties.Resources.boom2;
            this.guna2PictureBox1.Location = new System.Drawing.Point(383, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(492, 142);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 35;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // abonentsTableAdapter
            // 
            this.abonentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1424, 1019);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.PanelTotalActive);
            this.Controls.Add(this.ShadowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonents data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ShadowPanel.ResumeLayout(false);
            this.panelDetailedInfo.ResumeLayout(false);
            this.panelDetailedInfo.PerformLayout();
            this.panelMessageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessageDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panelDataHeader.ResumeLayout(false);
            this.panelFullNameData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowFullName)).EndInit();
            this.panelTariffPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowTariffPlan)).EndInit();
            this.panelPhoneNumberMainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowNumberMain)).EndInit();
            this.panelActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowActivity)).EndInit();
            this.panelRegistrationDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRegistrationDate)).EndInit();
            this.PanelTotalActive.ResumeLayout(false);
            this.PanelTotalActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panelHelper.ResumeLayout(false);
            this.panelHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textBoxFullNameSearch;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private System.Windows.Forms.Panel panelFullNameData;
        private Guna.UI2.WinForms.Guna2Button buttonFullNameDataSort;
        private System.Windows.Forms.Panel panelPhoneNumberMainData;
        private System.Windows.Forms.PictureBox pictureBoxArrowNumberMain;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNumberMainSearch;
        private Guna.UI2.WinForms.Guna2Button buttonNumberMainDataSort;
        private System.Windows.Forms.Panel panelRegistrationDate;
        private System.Windows.Forms.PictureBox pictureBoxArrowRegistrationDate;
        private Guna.UI2.WinForms.Guna2TextBox textBoxRegistrationDateSearch;
        private Guna.UI2.WinForms.Guna2Button buttonRegistrationDateDataSort;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.PictureBox pictureBoxArrowActivity;
        private Guna.UI2.WinForms.Guna2TextBox textBoxActivitySearch;
        private Guna.UI2.WinForms.Guna2Button buttonActivityDataSort;
        private System.Windows.Forms.Panel panelTariffPlan;
        private System.Windows.Forms.PictureBox pictureBoxArrowTariffPlan;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button buttonTariffPlanDataSort;
        private System.Windows.Forms.PictureBox pictureBoxArrowFullName;
        private System.Windows.Forms.Label labelTotal;
        private Guna.UI2.WinForms.Guna2ShadowPanel PanelTotalActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panelDataHeader;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelDetailedInfo;
        private Guna.UI2.WinForms.Guna2TextBox textFirstName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedMiddleName;
        private Guna.UI2.WinForms.Guna2TextBox textMiddleName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedFirstName;
        private Guna.UI2.WinForms.Guna2TextBox textSecondName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox textPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedSecondName;
        private System.Windows.Forms.Label buttonDetailedInfoCancel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedActivity;
        private Guna.UI2.WinForms.Guna2TextBox textActivity;
        private Guna.UI2.WinForms.Guna2TextBox textRegistrationDate;
        private System.Windows.Forms.DateTimePicker dateTimeDetailedRegistrationDate;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedRegistrationDate;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedPassportNumber;
        private Guna.UI2.WinForms.Guna2TextBox textPassportNumber;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource abonentsBindingSource;
        private DataSetTableAdapters.abonentsTableAdapter abonentsTableAdapter;
        private Guna.UI2.WinForms.Guna2Button buttonEditDetailedInfo;
        private Guna.UI2.WinForms.Guna2Button buttonSaveDetailedInfo;
        private Guna.UI2.WinForms.Guna2Button buttonDeleteDetailedInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumbermainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDetailedTariffPlan;
        private Guna.UI2.WinForms.Guna2TextBox textTariffPlan;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxDetailedInfoStatus;
        private Guna.UI2.WinForms.Guna2Button buttonAddNewAbonent;
        private Guna.UI2.WinForms.Guna2Button buttonHelper;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxCat;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxMessageDelete;
        private Guna.UI2.WinForms.Guna2Button buttonYesMessBox;
        private Guna.UI2.WinForms.Guna2Button buttonNoMessBox;
        private System.Windows.Forms.Panel panelMessageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textBoxActiveAbonentsCount;
        private System.Windows.Forms.Label textBoxTotalAbonentsCount;
        private Guna.UI2.WinForms.Guna2Panel panelHelper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}

