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
            this.Submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainInfoView = new System.Windows.Forms.DataGridView();
            this.colRail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputSwitch = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRoot = new System.Windows.Forms.DataGridView();
            this.fromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.tbxFromStation = new System.Windows.Forms.ComboBox();
            this.tbxToStation = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSwitch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit.Location = new System.Drawing.Point(882, 201);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(76, 73);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.btnSubmit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(345, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖV4-U";
            // 
            // timepicker
            // 
            this.timepicker.CustomFormat = "hh:mm";
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker.Location = new System.Drawing.Point(544, 290);
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
            // inputSwitch
            // 
            this.inputSwitch.BackColor = System.Drawing.Color.Transparent;
            this.inputSwitch.Image = global::ÖV4_U.Properties.Resources.circle_arrow;
            this.inputSwitch.Location = new System.Drawing.Point(429, 201);
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
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.fromStation,
            this.Ort,
            this.abfahrt});
            this.dgvRoot.Location = new System.Drawing.Point(3, 3);
            this.dgvRoot.Name = "dgvRoot";
            this.dgvRoot.RowTemplate.Height = 25;
            this.dgvRoot.Size = new System.Drawing.Size(951, 303);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(957, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(345, 290);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(200, 23);
            this.datepicker.TabIndex = 16;
            // 
            // tbxFromStation
            // 
            this.tbxFromStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.tbxFromStation.FormattingEnabled = true;
            this.tbxFromStation.Location = new System.Drawing.Point(75, 212);
            this.tbxFromStation.Name = "tbxFromStation";
            this.tbxFromStation.Size = new System.Drawing.Size(286, 23);
            this.tbxFromStation.TabIndex = 21;
            this.tbxFromStation.TextChanged += new System.EventHandler(this.autoCompleteFrom);
            // 
            // tbxToStation
            // 
            this.tbxToStation.FormattingEnabled = true;
            this.tbxToStation.Location = new System.Drawing.Point(544, 212);
            this.tbxToStation.Name = "tbxToStation";
            this.tbxToStation.Size = new System.Drawing.Size(286, 23);
            this.tbxToStation.TabIndex = 20;
            this.tbxToStation.TextChanged += new System.EventHandler(this.autoCompleteTo);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 707);
            this.Controls.Add(this.tbxFromStation);
            this.Controls.Add(this.tbxToStation);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.inputSwitch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.timepicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrom";
            this.Text = "ÖV4-U";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSwitch)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker timepicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private BindingSource bindingSource1;
        private DataGridView trainInfoView;
        private DataGridViewTextBoxColumn colRail;
        private DataGridViewTextBoxColumn colFromStation;
        private DataGridViewTextBoxColumn colToStation;
        private DataGridViewTextBoxColumn colDeparture;
        private DataGridViewTextBoxColumn colArrive;
        private DataGridViewTextBoxColumn colDurration;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvRoot;
        private DataGridViewTextBoxColumn fromStation;
        private DataGridViewTextBoxColumn Ort;
        private DataGridViewTextBoxColumn abfahrt;
        private PictureBox inputSwitch;
        private DateTimePicker datepicker;
        private TabPage tabPage3;
        private Button Submit;
        private ComboBox tbxFromStation;
        private ComboBox tbxToStation;
    }
}