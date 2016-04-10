namespace Lab_1
{
    partial class Lab_1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_1));
            this.LabNum = new System.Windows.Forms.Label();
            this.studentGroup = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabNum
            // 
            this.LabNum.AutoSize = true;
            this.LabNum.BackColor = System.Drawing.Color.Transparent;
            this.LabNum.Font = new System.Drawing.Font("Times New Roman", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabNum.ForeColor = System.Drawing.Color.Red;
            this.LabNum.Location = new System.Drawing.Point(44, 33);
            this.LabNum.Name = "LabNum";
            this.LabNum.Size = new System.Drawing.Size(585, 58);
            this.LabNum.TabIndex = 0;
            this.LabNum.Text = "Лабораторна робота №1";
            // 
            // studentGroup
            // 
            this.studentGroup.AutoSize = true;
            this.studentGroup.BackColor = System.Drawing.Color.Transparent;
            this.studentGroup.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentGroup.ForeColor = System.Drawing.Color.GreenYellow;
            this.studentGroup.Location = new System.Drawing.Point(78, 118);
            this.studentGroup.Name = "studentGroup";
            this.studentGroup.Size = new System.Drawing.Size(518, 43);
            this.studentGroup.TabIndex = 1;
            this.studentGroup.Text = "Виконав студент групи ІА-22";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.BackColor = System.Drawing.Color.Transparent;
            this.studentName.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentName.ForeColor = System.Drawing.Color.Blue;
            this.studentName.Location = new System.Drawing.Point(167, 183);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(321, 49);
            this.studentName.TabIndex = 2;
            this.studentName.Text = "Дзюбак Андрій";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(145, 281);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(375, 118);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Lab_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 427);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentGroup);
            this.Controls.Add(this.LabNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(677, 466);
            this.MinimumSize = new System.Drawing.Size(677, 466);
            this.Name = "Lab_1";
            this.Text = "ООП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNum;
        private System.Windows.Forms.Label studentGroup;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Button Exit;
    }
}

