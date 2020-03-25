namespace TimetableSource
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.Week = new System.Windows.Forms.Label();
            this.mon = new System.Windows.Forms.Label();
            this.tue = new System.Windows.Forms.Label();
            this.wed = new System.Windows.Forms.Label();
            this.thu = new System.Windows.Forms.Label();
            this.fri = new System.Windows.Forms.Label();
            this.satur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Week, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.wed, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.thu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fri, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.satur, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "19-ИД-3 \"А\"",
            "19-ИД-3 \"Б\""});
            this.comboBox1.Location = new System.Drawing.Point(17, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(857, 14);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 25);
            this.Date.TabIndex = 2;
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Week.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Week.Location = new System.Drawing.Point(289, 0);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(280, 53);
            this.Week.TabIndex = 1;
            this.Week.Text = "Неделя: ";
            this.Week.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mon
            // 
            this.mon.AutoSize = true;
            this.mon.BackColor = System.Drawing.SystemColors.Control;
            this.mon.Dock = System.Windows.Forms.DockStyle.Top;
            this.mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mon.Location = new System.Drawing.Point(3, 53);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(280, 24);
            this.mon.TabIndex = 3;
            this.mon.Text = "Понедельник";
            // 
            // tue
            // 
            this.tue.AutoSize = true;
            this.tue.BackColor = System.Drawing.SystemColors.Control;
            this.tue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tue.Location = new System.Drawing.Point(289, 53);
            this.tue.Name = "tue";
            this.tue.Size = new System.Drawing.Size(280, 24);
            this.tue.TabIndex = 4;
            this.tue.Text = "Вторник";
            // 
            // wed
            // 
            this.wed.AutoSize = true;
            this.wed.BackColor = System.Drawing.SystemColors.Menu;
            this.wed.Dock = System.Windows.Forms.DockStyle.Top;
            this.wed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wed.Location = new System.Drawing.Point(575, 53);
            this.wed.Name = "wed";
            this.wed.Size = new System.Drawing.Size(282, 24);
            this.wed.TabIndex = 5;
            this.wed.Text = "Среда";
            // 
            // thu
            // 
            this.thu.AutoSize = true;
            this.thu.BackColor = System.Drawing.SystemColors.Control;
            this.thu.Dock = System.Windows.Forms.DockStyle.Top;
            this.thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thu.Location = new System.Drawing.Point(3, 294);
            this.thu.Name = "thu";
            this.thu.Size = new System.Drawing.Size(280, 24);
            this.thu.TabIndex = 6;
            this.thu.Text = "Четверг";
            // 
            // fri
            // 
            this.fri.AutoSize = true;
            this.fri.BackColor = System.Drawing.SystemColors.Control;
            this.fri.Dock = System.Windows.Forms.DockStyle.Top;
            this.fri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fri.Location = new System.Drawing.Point(289, 294);
            this.fri.Name = "fri";
            this.fri.Size = new System.Drawing.Size(280, 24);
            this.fri.TabIndex = 7;
            this.fri.Text = "Пятница";
            // 
            // satur
            // 
            this.satur.AutoSize = true;
            this.satur.BackColor = System.Drawing.SystemColors.Control;
            this.satur.Dock = System.Windows.Forms.DockStyle.Top;
            this.satur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.satur.Location = new System.Drawing.Point(575, 294);
            this.satur.Name = "satur";
            this.satur.Size = new System.Drawing.Size(282, 24);
            this.satur.TabIndex = 8;
            this.satur.Text = "Суббота";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Расписание";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Week;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label mon;
        private System.Windows.Forms.Label tue;
        private System.Windows.Forms.Label wed;
        private System.Windows.Forms.Label thu;
        private System.Windows.Forms.Label fri;
        private System.Windows.Forms.Label satur;
    }
}

