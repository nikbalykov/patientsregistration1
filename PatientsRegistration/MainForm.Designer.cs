namespace PatientsRegistration
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.createReportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteMonthButton = new System.Windows.Forms.Button();
            this.startNewMonthButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createReportButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.deleteMonthButton);
            this.panel1.Controls.Add(this.startNewMonthButton);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.monthLabel);
            this.panel1.Controls.Add(this.yearNumericUpDown);
            this.panel1.Controls.Add(this.monthNumericUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 82);
            this.panel1.TabIndex = 0;
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(15, 53);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(130, 23);
            this.createReportButton.TabIndex = 10;
            this.createReportButton.Text = "Сформировать отчёт";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(767, 53);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(607, 53);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(132, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Редактировать запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(452, 53);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(294, 53);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 23);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteMonthButton
            // 
            this.deleteMonthButton.Location = new System.Drawing.Point(452, 9);
            this.deleteMonthButton.Name = "deleteMonthButton";
            this.deleteMonthButton.Size = new System.Drawing.Size(152, 23);
            this.deleteMonthButton.TabIndex = 5;
            this.deleteMonthButton.Text = "Удалить данные за месяц";
            this.deleteMonthButton.UseVisualStyleBackColor = true;
            this.deleteMonthButton.Click += new System.EventHandler(this.deleteMonthButton_Click);
            // 
            // startNewMonthButton
            // 
            this.startNewMonthButton.Location = new System.Drawing.Point(294, 9);
            this.startNewMonthButton.Name = "startNewMonthButton";
            this.startNewMonthButton.Size = new System.Drawing.Size(122, 23);
            this.startNewMonthButton.TabIndex = 4;
            this.startNewMonthButton.Text = "Начать новый месяц";
            this.startNewMonthButton.UseVisualStyleBackColor = true;
            this.startNewMonthButton.Click += new System.EventHandler(this.startNewMonthButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(132, 14);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Год";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(12, 14);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Месяц";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(163, 12);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.yearNumericUpDown.TabIndex = 1;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(58, 12);
            this.monthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.monthNumericUpDown.TabIndex = 0;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 82);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.Size = new System.Drawing.Size(901, 368);
            this.mainDataGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Учёт движения больных и коечного фонда";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteMonthButton;
        private System.Windows.Forms.Button startNewMonthButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

