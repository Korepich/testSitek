namespace testSitek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstChoice = new System.Windows.Forms.Button();
            this.secondChoice = new System.Windows.Forms.Button();
            this.speedAlg = new System.Windows.Forms.TextBox();
            this.choiceSorting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textFirstPath = new System.Windows.Forms.TextBox();
            this.textSecondPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstChoice
            // 
            this.firstChoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firstChoice.Location = new System.Drawing.Point(12, 15);
            this.firstChoice.Name = "firstChoice";
            this.firstChoice.Size = new System.Drawing.Size(142, 23);
            this.firstChoice.TabIndex = 0;
            this.firstChoice.Text = "загрузить первый файл";
            this.firstChoice.UseVisualStyleBackColor = false;
            this.firstChoice.Click += new System.EventHandler(this.firstChoice_Click);
            // 
            // secondChoice
            // 
            this.secondChoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondChoice.Location = new System.Drawing.Point(12, 44);
            this.secondChoice.Name = "secondChoice";
            this.secondChoice.Size = new System.Drawing.Size(142, 23);
            this.secondChoice.TabIndex = 1;
            this.secondChoice.Text = "загрузить второй файл";
            this.secondChoice.UseVisualStyleBackColor = false;
            this.secondChoice.Click += new System.EventHandler(this.secondChoice_Click);
            // 
            // speedAlg
            // 
            this.speedAlg.Location = new System.Drawing.Point(179, 202);
            this.speedAlg.Name = "speedAlg";
            this.speedAlg.Size = new System.Drawing.Size(100, 20);
            this.speedAlg.TabIndex = 2;
            // 
            // choiceSorting
            // 
            this.choiceSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceSorting.FormattingEnabled = true;
            this.choiceSorting.Items.AddRange(new object[] {
            "По фамилии исполнителя",
            "По количеству РКК",
            "По обращениям",
            "По общему количеству"});
            this.choiceSorting.Location = new System.Drawing.Point(12, 109);
            this.choiceSorting.MaxDropDownItems = 4;
            this.choiceSorting.Name = "choiceSorting";
            this.choiceSorting.Size = new System.Drawing.Size(159, 21);
            this.choiceSorting.TabIndex = 3;
            this.choiceSorting.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сортировать:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(175, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textFirstPath
            // 
            this.textFirstPath.Location = new System.Drawing.Point(231, 18);
            this.textFirstPath.Name = "textFirstPath";
            this.textFirstPath.Size = new System.Drawing.Size(656, 20);
            this.textFirstPath.TabIndex = 7;
            // 
            // textSecondPath
            // 
            this.textSecondPath.Location = new System.Drawing.Point(231, 44);
            this.textSecondPath.Name = "textSecondPath";
            this.textSecondPath.Size = new System.Drawing.Size(656, 20);
            this.textSecondPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время выполнения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(175, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Путь:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSecondPath);
            this.Controls.Add(this.textFirstPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choiceSorting);
            this.Controls.Add(this.speedAlg);
            this.Controls.Add(this.secondChoice);
            this.Controls.Add(this.firstChoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cоздание отчета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstChoice;
        private System.Windows.Forms.Button secondChoice;
        private System.Windows.Forms.TextBox speedAlg;
        private System.Windows.Forms.ComboBox choiceSorting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textFirstPath;
        private System.Windows.Forms.TextBox textSecondPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

