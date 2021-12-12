namespace ТРПО._1
{
    partial class mainForm
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
            this.niD = new System.Windows.Forms.TextBox();
            this.vrD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.poschitB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_1 = new System.Windows.Forms.TextBox();
            this.del_2 = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // niD
            // 
            this.niD.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.niD.Location = new System.Drawing.Point(244, 54);
            this.niD.Name = "niD";
            this.niD.Size = new System.Drawing.Size(66, 22);
            this.niD.TabIndex = 0;
            this.niD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // vrD
            // 
            this.vrD.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.vrD.Location = new System.Drawing.Point(232, 61);
            this.vrD.Name = "vrD";
            this.vrD.Size = new System.Drawing.Size(66, 22);
            this.vrD.TabIndex = 1;
            this.vrD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // poschitB
            // 
            this.poschitB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.poschitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poschitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poschitB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.poschitB.Location = new System.Drawing.Point(304, 154);
            this.poschitB.Name = "poschitB";
            this.poschitB.Size = new System.Drawing.Size(258, 25);
            this.poschitB.TabIndex = 3;
            this.poschitB.Text = "Расчёт";
            this.poschitB.UseVisualStyleBackColor = false;
            this.poschitB.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нахождение минимального и максимального числа кратного                           " +
    " и";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите верхнюю границу диапазона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите нижнюю границу диапазона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Минимальное кратное число:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Максимальное кратное число:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 43);
            this.panel1.TabIndex = 10;
            // 
            // del_1
            // 
            this.del_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.del_1.Location = new System.Drawing.Point(364, 4);
            this.del_1.Name = "del_1";
            this.del_1.Size = new System.Drawing.Size(64, 22);
            this.del_1.TabIndex = 11;
            this.del_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.del_1_KeyPress);
            // 
            // del_2
            // 
            this.del_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.del_2.Location = new System.Drawing.Point(452, 4);
            this.del_2.Name = "del_2";
            this.del_2.Size = new System.Drawing.Size(67, 22);
            this.del_2.TabIndex = 12;
            this.del_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.del_2_KeyPress);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.history.Location = new System.Drawing.Point(316, 45);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(258, 116);
            this.history.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.info);
            this.panel2.Controls.Add(this.del_2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.del_1);
            this.panel2.Controls.Add(this.vrD);
            this.panel2.Controls.Add(this.poschitB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 188);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(184, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Очистка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info.Location = new System.Drawing.Point(21, 154);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(100, 25);
            this.info.TabIndex = 13;
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(593, 213);
            this.Controls.Add(this.history);
            this.Controls.Add(this.niD);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МОК и БОК";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox niD;
        private System.Windows.Forms.TextBox vrD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button poschitB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox del_1;
        private System.Windows.Forms.TextBox del_2;
        private System.Windows.Forms.TreeView history;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button button1;
    }
}

