namespace ÖV4_U
{
    partial class MainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSubmitBoard = new System.Windows.Forms.Button();
            this.tbxdepartureBoard = new System.Windows.Forms.ComboBox();
            this.dgvRoot = new System.Windows.Forms.DataGridView();
            this.fromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxToStation = new System.Windows.Forms.ComboBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.Submit = new System.Windows.Forms.Button();
            this.tbxFromStation = new System.Windows.Forms.ComboBox();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.trainInfoView = new System.Windows.Forms.DataGridView();
            this.colRail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputSwitch = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoot)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSwitch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 55);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖV4-U";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.btnSubmitBoard);
            this.tabPage2.Controls.Add(this.tbxdepartureBoard);
            this.tabPage2.Controls.Add(this.dgvRoot);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel ";
            // 
            // btnSubmitBoard
            // 
            this.btnSubmitBoard.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitBoard.Location = new System.Drawing.Point(581, 52);
            this.btnSubmitBoard.Name = "btnSubmitBoard";
            this.btnSubmitBoard.Size = new System.Drawing.Size(76, 32);
            this.btnSubmitBoard.TabIndex = 23;
            this.btnSubmitBoard.Text = "Submit";
            this.btnSubmitBoard.UseVisualStyleBackColor = true;
            this.btnSubmitBoard.Click += new System.EventHandler(this.departureBoard);
            // 
            // tbxdepartureBoard
            // 
            this.tbxdepartureBoard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxdepartureBoard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbxdepartureBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbxdepartureBoard.FormattingEnabled = true;
            this.tbxdepartureBoard.Location = new System.Drawing.Point(272, 52);
            this.tbxdepartureBoard.Name = "tbxdepartureBoard";
            this.tbxdepartureBoard.Size = new System.Drawing.Size(286, 23);
            this.tbxdepartureBoard.TabIndex = 22;
            this.tbxdepartureBoard.TextChanged += new System.EventHandler(this.autoCompleteDepartureBoard);
            // 
            // dgvRoot
            // 
            this.dgvRoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromStation,
            this.Ort,
            this.abfahrt});
            this.dgvRoot.Location = new System.Drawing.Point(0, 128);
            this.dgvRoot.Name = "dgvRoot";
            this.dgvRoot.RowTemplate.Height = 25;
            this.dgvRoot.Size = new System.Drawing.Size(981, 465);
            this.dgvRoot.TabIndex = 0;
            // 
            // fromStation
            // 
            this.fromStation.HeaderText = "von";
            this.fromStation.Name = "fromStation";
            this.fromStation.ReadOnly = true;
            // 
            // Ort
            // 
            this.Ort.HeaderText = "Ort";
            this.Ort.Name = "Ort";
            this.Ort.ReadOnly = true;
            // 
            // abfahrt
            // 
            this.abfahrt.HeaderText = "Abfahrt";
            this.abfahrt.Name = "abfahrt";
            this.abfahrt.ReadOnly = true;
            this.abfahrt.Width = 150;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.tbxToStation);
            this.tabPage1.Controls.Add(this.datepicker);
            this.tabPage1.Controls.Add(this.Submit);
            this.tabPage1.Controls.Add(this.tbxFromStation);
            this.tabPage1.Controls.Add(this.timepicker);
            this.tabPage1.Controls.Add(this.trainInfoView);
            this.tabPage1.Controls.Add(this.inputSwitch);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            // 
            // tbxToStation
            // 
            this.tbxToStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxToStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbxToStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbxToStation.FormattingEnabled = true;
            this.tbxToStation.Location = new System.Drawing.Point(506, 37);
            this.tbxToStation.Name = "tbxToStation";
            this.tbxToStation.Size = new System.Drawing.Size(286, 23);
            this.tbxToStation.TabIndex = 20;
            this.tbxToStation.TextChanged += new System.EventHandler(this.autoCompleteTo);
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(266, 86);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(200, 23);
            this.datepicker.TabIndex = 16;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit.Location = new System.Drawing.Point(840, 28);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(82, 34);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.btnSubmit);
            // 
            // tbxFromStation
            // 
            this.tbxFromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxFromStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbxFromStation.DisplayMember = "von";
            this.tbxFromStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbxFromStation.FormattingEnabled = true;
            this.tbxFromStation.Location = new System.Drawing.Point(97, 39);
            this.tbxFromStation.Name = "tbxFromStation";
            this.tbxFromStation.Size = new System.Drawing.Size(286, 23);
            this.tbxFromStation.TabIndex = 21;
            this.tbxFromStation.TextChanged += new System.EventHandler(this.autoCompleteFrom);
            // 
            // timepicker
            // 
            this.timepicker.CustomFormat = "hh:mm";
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker.Location = new System.Drawing.Point(472, 86);
            this.timepicker.Name = "timepicker";
            this.timepicker.ShowUpDown = true;
            this.timepicker.Size = new System.Drawing.Size(60, 23);
            this.timepicker.TabIndex = 11;
            // 
            // trainInfoView
            // 
            this.trainInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainInfoView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRail,
            this.colFromStation,
            this.colToStation,
            this.colDeparture,
            this.colArrive,
            this.colDurration});
            this.trainInfoView.Location = new System.Drawing.Point(0, 126);
            this.trainInfoView.Name = "trainInfoView";
            this.trainInfoView.RowTemplate.Height = 25;
            this.trainInfoView.Size = new System.Drawing.Size(981, 442);
            this.trainInfoView.TabIndex = 12;
            // 
            // colRail
            // 
            this.colRail.HeaderText = "Gleis";
            this.colRail.Name = "colRail";
            this.colRail.ReadOnly = true;
            this.colRail.Width = 80;
            // 
            // colFromStation
            // 
            this.colFromStation.HeaderText = "von Station";
            this.colFromStation.MinimumWidth = 10;
            this.colFromStation.Name = "colFromStation";
            this.colFromStation.ReadOnly = true;
            this.colFromStation.Width = 280;
            // 
            // colToStation
            // 
            this.colToStation.HeaderText = "zur Station";
            this.colToStation.MinimumWidth = 10;
            this.colToStation.Name = "colToStation";
            this.colToStation.ReadOnly = true;
            this.colToStation.Width = 280;
            // 
            // colDeparture
            // 
            this.colDeparture.HeaderText = "Abfahrt";
            this.colDeparture.MinimumWidth = 10;
            this.colDeparture.Name = "colDeparture";
            this.colDeparture.ReadOnly = true;
            // 
            // colArrive
            // 
            this.colArrive.HeaderText = "Ankunft";
            this.colArrive.MinimumWidth = 10;
            this.colArrive.Name = "colArrive";
            this.colArrive.ReadOnly = true;
            // 
            // colDurration
            // 
            this.colDurration.HeaderText = "Dauer";
            this.colDurration.MinimumWidth = 10;
            this.colDurration.Name = "colDurration";
            this.colDurration.ReadOnly = true;
            // 
            // inputSwitch
            // 
            this.inputSwitch.BackColor = System.Drawing.Color.Transparent;
            this.inputSwitch.Image = global::ÖV4_U.Properties.Resources.circle_arrow;
            this.inputSwitch.Location = new System.Drawing.Point(416, 8);
            this.inputSwitch.Name = "inputSwitch";
            this.inputSwitch.Size = new System.Drawing.Size(50, 54);
            this.inputSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inputSwitch.TabIndex = 14;
            this.inputSwitch.TabStop = false;
            this.inputSwitch.Click += new System.EventHandler(this.SwitchFromToStation);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 607);
            this.tabControl1.TabIndex = 15;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(989, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrom";
            this.Text = "ÖV4-U";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoot)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSwitch)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnEnter;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button btnSubmitBoard;
        private ComboBox tbxdepartureBoard;
        private DataGridView dgvRoot;
        private DataGridViewTextBoxColumn fromStation;
        private DataGridViewTextBoxColumn Ort;
        private DataGridViewTextBoxColumn abfahrt;
        private TabPage tabPage1;
        private ComboBox tbxToStation;
        private DateTimePicker datepicker;
        private Button Submit;
        private ComboBox tbxFromStation;
        private DateTimePicker timepicker;
        private DataGridView trainInfoView;
        private DataGridViewTextBoxColumn colRail;
        private DataGridViewTextBoxColumn colFromStation;
        private DataGridViewTextBoxColumn colToStation;
        private DataGridViewTextBoxColumn colDeparture;
        private DataGridViewTextBoxColumn colArrive;
        private DataGridViewTextBoxColumn colDurration;
        private PictureBox inputSwitch;
        private TabControl tabControl1;
    }
}