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
            this.components = new System.ComponentModel.Container();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFromStation = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbxToStation = new System.Windows.Forms.ComboBox();
            this.InputdateTime = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainInfoView = new System.Windows.Forms.DataGridView();
            this.colRail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRoot = new System.Windows.Forms.DataGridView();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Location = new System.Drawing.Point(862, 218);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(76, 73);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "button1";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(36, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖV4-U";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "00:00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbxFromStation
            // 
            this.tbxFromStation.AutoCompleteCustomSource.AddRange(new string[] {
            "test"});
            this.tbxFromStation.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFromStation.FormattingEnabled = true;
            this.tbxFromStation.ItemHeight = 30;
            this.tbxFromStation.Location = new System.Drawing.Point(36, 202);
            this.tbxFromStation.Name = "tbxFromStation";
            this.tbxFromStation.Size = new System.Drawing.Size(796, 38);
            this.tbxFromStation.TabIndex = 8;
            this.tbxFromStation.DropDown += new System.EventHandler(this.to_SelectedIndexChanged);
            this.tbxFromStation.SelectedIndexChanged += new System.EventHandler(this.to_SelectedIndexChanged);
            this.tbxFromStation.Click += new System.EventHandler(this.to_SelectedIndexChanged);
            // 
            // tbxToStation
            // 
            this.tbxToStation.AutoCompleteCustomSource.AddRange(new string[] {
            "test"});
            this.tbxToStation.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxToStation.FormattingEnabled = true;
            this.tbxToStation.Location = new System.Drawing.Point(36, 270);
            this.tbxToStation.Name = "tbxToStation";
            this.tbxToStation.Size = new System.Drawing.Size(796, 38);
            this.tbxToStation.TabIndex = 9;
            this.tbxToStation.DropDown += new System.EventHandler(this.from_SelectedIndexChanged);
            this.tbxToStation.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged);
            this.tbxToStation.Click += new System.EventHandler(this.from_SelectedIndexChanged);
            // 
            // InputdateTime
            // 
            this.InputdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.InputdateTime.Location = new System.Drawing.Point(298, 327);
            this.InputdateTime.Name = "InputdateTime";
            this.InputdateTime.Size = new System.Drawing.Size(200, 23);
            this.InputdateTime.TabIndex = 11;
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
            this.trainInfoView.Location = new System.Drawing.Point(0, 0);
            this.trainInfoView.Name = "trainInfoView";
            this.trainInfoView.RowTemplate.Height = 25;
            this.trainInfoView.Size = new System.Drawing.Size(954, 309);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abfahrtsplan",
            "Karte"});
            this.comboBox1.Location = new System.Drawing.Point(35, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::ÖV4_U.Properties.Resources.circle_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(367, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 355);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 340);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trainInfoView);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRoot);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRoot
            // 
            this.dgvRoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ort,
            this.abfahrt});
            this.dgvRoot.Location = new System.Drawing.Point(3, 3);
            this.dgvRoot.Name = "dgvRoot";
            this.dgvRoot.RowTemplate.Height = 25;
            this.dgvRoot.Size = new System.Drawing.Size(245, 303);
            this.dgvRoot.TabIndex = 0;
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
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(989, 707);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.InputdateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxToStation);
            this.Controls.Add(this.tbxFromStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrom";
            this.Text = "ÖV4-U";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEnter;
        private Panel panel1;
        private Label label1;
        private Label label2;
        protected ComboBox tbxFromStation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected ComboBox tbxToStation;
        private DateTimePicker InputdateTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private BindingSource bindingSource1;
        private DataGridView trainInfoView;
        private DataGridViewTextBoxColumn colRail;
        private DataGridViewTextBoxColumn colFromStation;
        private DataGridViewTextBoxColumn colToStation;
        private DataGridViewTextBoxColumn colDeparture;
        private DataGridViewTextBoxColumn colArrive;
        private DataGridViewTextBoxColumn colDurration;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvRoot;
        private DataGridViewTextBoxColumn Ort;
        private DataGridViewTextBoxColumn abfahrt;
    }
}