﻿namespace Прогр2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FShark = new System.Windows.Forms.Button();
            this.FBands = new System.Windows.Forms.CheckBox();
            this.FTigerSark = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FSpeed = new System.Windows.Forms.TextBox();
            this.FWeight = new System.Windows.Forms.TextBox();
            this.FColor1 = new System.Windows.Forms.Button();
            this.FColor2 = new System.Windows.Forms.Button();
            this.FAge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 414);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // FShark
            // 
            this.FShark.Location = new System.Drawing.Point(410, 481);
            this.FShark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FShark.Name = "FShark";
            this.FShark.Size = new System.Drawing.Size(93, 22);
            this.FShark.TabIndex = 5;
            this.FShark.Text = "Shark";
            this.FShark.UseVisualStyleBackColor = true;
            this.FShark.Click += new System.EventHandler(this.FShark_Click);
            // 
            // FBands
            // 
            this.FBands.AutoSize = true;
            this.FBands.Location = new System.Drawing.Point(648, 481);
            this.FBands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FBands.Name = "FBands";
            this.FBands.Size = new System.Drawing.Size(70, 21);
            this.FBands.TabIndex = 7;
            this.FBands.Text = "Bands";
            this.FBands.UseVisualStyleBackColor = true;
            this.FBands.CheckedChanged += new System.EventHandler(this.FBands_CheckedChanged);
            // 
            // FTigerSark
            // 
            this.FTigerSark.Location = new System.Drawing.Point(764, 488);
            this.FTigerSark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FTigerSark.Name = "FTigerSark";
            this.FTigerSark.Size = new System.Drawing.Size(117, 22);
            this.FTigerSark.TabIndex = 8;
            this.FTigerSark.Text = "TigerShark";
            this.FTigerSark.UseVisualStyleBackColor = true;
            this.FTigerSark.Click += new System.EventHandler(this.FTigerSark_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1010, 466);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 63);
            this.button3.TabIndex = 9;
            this.button3.Text = "Move";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FSpeed
            // 
            this.FSpeed.Location = new System.Drawing.Point(139, 467);
            this.FSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FSpeed.Name = "FSpeed";
            this.FSpeed.Size = new System.Drawing.Size(62, 22);
            this.FSpeed.TabIndex = 10;
            this.FSpeed.TextChanged += new System.EventHandler(this.FSpeed_TextChanged);
            // 
            // FWeight
            // 
            this.FWeight.Location = new System.Drawing.Point(139, 503);
            this.FWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FWeight.Name = "FWeight";
            this.FWeight.Size = new System.Drawing.Size(62, 22);
            this.FWeight.TabIndex = 11;
            this.FWeight.TextChanged += new System.EventHandler(this.FWeight_TextChanged);
            // 
            // FColor1
            // 
            this.FColor1.Location = new System.Drawing.Point(251, 470);
            this.FColor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FColor1.Name = "FColor1";
            this.FColor1.Size = new System.Drawing.Size(79, 26);
            this.FColor1.TabIndex = 12;
            this.FColor1.Text = "Color1";
            this.FColor1.UseVisualStyleBackColor = true;
            this.FColor1.Click += new System.EventHandler(this.FColor1_Click);
            // 
            // FColor2
            // 
            this.FColor2.Location = new System.Drawing.Point(641, 511);
            this.FColor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FColor2.Name = "FColor2";
            this.FColor2.Size = new System.Drawing.Size(79, 26);
            this.FColor2.TabIndex = 13;
            this.FColor2.Text = "Color2";
            this.FColor2.UseVisualStyleBackColor = true;
            this.FColor2.Click += new System.EventHandler(this.FColor2_Click);
            // 
            // FAge
            // 
            this.FAge.Location = new System.Drawing.Point(310, 500);
            this.FAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FAge.Name = "FAge";
            this.FAge.Size = new System.Drawing.Size(62, 22);
            this.FAge.TabIndex = 14;
            this.FAge.TextChanged += new System.EventHandler(this.FAge_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 546);
            this.Controls.Add(this.FAge);
            this.Controls.Add(this.FColor2);
            this.Controls.Add(this.FColor1);
            this.Controls.Add(this.FWeight);
            this.Controls.Add(this.FSpeed);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FTigerSark);
            this.Controls.Add(this.FBands);
            this.Controls.Add(this.FShark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FShark;
        private System.Windows.Forms.CheckBox FBands;
        private System.Windows.Forms.Button FTigerSark;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox FSpeed;
        private System.Windows.Forms.TextBox FWeight;
        private System.Windows.Forms.Button FColor1;
        private System.Windows.Forms.Button FColor2;
        private System.Windows.Forms.TextBox FAge;
    }
}

