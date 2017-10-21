namespace Прогр1_1_
{
    partial class FKitchen
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
            this.FWaterTab = new System.Windows.Forms.GroupBox();
            this.FOpen = new System.Windows.Forms.RadioButton();
            this.FClose = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FOn = new System.Windows.Forms.RadioButton();
            this.FOff = new System.Windows.Forms.RadioButton();
            this.FWash = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FSalt = new System.Windows.Forms.CheckBox();
            this.FButter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FCountEggs = new System.Windows.Forms.NumericUpDown();
            this.FHit = new System.Windows.Forms.Button();
            this.FCook = new System.Windows.Forms.Button();
            this.FGet = new System.Windows.Forms.Button();
            this.FOK = new System.Windows.Forms.Button();
            this.FWaterTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCountEggs)).BeginInit();
            this.SuspendLayout();
            // 
            // FWaterTab
            // 
            this.FWaterTab.Controls.Add(this.FOpen);
            this.FWaterTab.Controls.Add(this.FClose);
            this.FWaterTab.Location = new System.Drawing.Point(331, 34);
            this.FWaterTab.Name = "FWaterTab";
            this.FWaterTab.Size = new System.Drawing.Size(201, 135);
            this.FWaterTab.TabIndex = 0;
            this.FWaterTab.TabStop = false;
            this.FWaterTab.Text = "Кран";
            this.FWaterTab.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FOpen
            // 
            this.FOpen.AutoSize = true;
            this.FOpen.Location = new System.Drawing.Point(27, 83);
            this.FOpen.Name = "FOpen";
            this.FOpen.Size = new System.Drawing.Size(101, 24);
            this.FOpen.TabIndex = 1;
            this.FOpen.Text = "Открыть";
            this.FOpen.UseVisualStyleBackColor = true;
            this.FOpen.CheckedChanged += new System.EventHandler(this.FOpen_CheckedChanged);
            // 
            // FClose
            // 
            this.FClose.AutoSize = true;
            this.FClose.Checked = true;
            this.FClose.Location = new System.Drawing.Point(27, 40);
            this.FClose.Name = "FClose";
            this.FClose.Size = new System.Drawing.Size(91, 24);
            this.FClose.TabIndex = 0;
            this.FClose.TabStop = true;
            this.FClose.Text = "Закрыт";
            this.FClose.UseVisualStyleBackColor = true;
            this.FClose.CheckedChanged += new System.EventHandler(this.FClose_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FOn);
            this.groupBox1.Controls.Add(this.FOff);
            this.groupBox1.Location = new System.Drawing.Point(599, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Плита";
            // 
            // FOn
            // 
            this.FOn.AutoSize = true;
            this.FOn.Location = new System.Drawing.Point(27, 84);
            this.FOn.Name = "FOn";
            this.FOn.Size = new System.Drawing.Size(63, 24);
            this.FOn.TabIndex = 2;
            this.FOn.Text = "Вкл";
            this.FOn.UseVisualStyleBackColor = true;
            this.FOn.CheckedChanged += new System.EventHandler(this.FOn_CheckedChanged);
            // 
            // FOff
            // 
            this.FOff.AutoSize = true;
            this.FOff.Checked = true;
            this.FOff.Location = new System.Drawing.Point(27, 35);
            this.FOff.Name = "FOff";
            this.FOff.Size = new System.Drawing.Size(74, 24);
            this.FOff.TabIndex = 1;
            this.FOff.TabStop = true;
            this.FOff.Text = "Выкл";
            this.FOff.UseVisualStyleBackColor = true;
            this.FOff.CheckedChanged += new System.EventHandler(this.FOff_CheckedChanged);
            // 
            // FWash
            // 
            this.FWash.Location = new System.Drawing.Point(48, 267);
            this.FWash.Name = "FWash";
            this.FWash.Size = new System.Drawing.Size(150, 36);
            this.FWash.TabIndex = 2;
            this.FWash.Text = "Мыть яйца";
            this.FWash.UseVisualStyleBackColor = true;
            this.FWash.Click += new System.EventHandler(this.FWash_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FOK);
            this.groupBox2.Controls.Add(this.FSalt);
            this.groupBox2.Controls.Add(this.FButter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.FCountEggs);
            this.groupBox2.Location = new System.Drawing.Point(36, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ингредиенты";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // FSalt
            // 
            this.FSalt.AutoSize = true;
            this.FSalt.Location = new System.Drawing.Point(69, 118);
            this.FSalt.Name = "FSalt";
            this.FSalt.Size = new System.Drawing.Size(74, 24);
            this.FSalt.TabIndex = 9;
            this.FSalt.Text = "Соль";
            this.FSalt.UseVisualStyleBackColor = true;
            this.FSalt.CheckedChanged += new System.EventHandler(this.FSalt_CheckedChanged);
            // 
            // FButter
            // 
            this.FButter.AutoSize = true;
            this.FButter.Location = new System.Drawing.Point(69, 81);
            this.FButter.Name = "FButter";
            this.FButter.Size = new System.Drawing.Size(84, 24);
            this.FButter.TabIndex = 8;
            this.FButter.Text = "Масло";
            this.FButter.UseVisualStyleBackColor = true;
            this.FButter.CheckedChanged += new System.EventHandler(this.FButter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Яйца";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FCountEggs
            // 
            this.FCountEggs.Location = new System.Drawing.Point(29, 47);
            this.FCountEggs.Name = "FCountEggs";
            this.FCountEggs.Size = new System.Drawing.Size(56, 26);
            this.FCountEggs.TabIndex = 4;
            this.FCountEggs.ValueChanged += new System.EventHandler(this.FCountEggs_ValueChanged);
            // 
            // FHit
            // 
            this.FHit.Location = new System.Drawing.Point(48, 331);
            this.FHit.Name = "FHit";
            this.FHit.Size = new System.Drawing.Size(150, 36);
            this.FHit.TabIndex = 4;
            this.FHit.Text = "Разбить яйца";
            this.FHit.UseVisualStyleBackColor = true;
            this.FHit.Click += new System.EventHandler(this.FHit_Click);
            // 
            // FCook
            // 
            this.FCook.Location = new System.Drawing.Point(48, 394);
            this.FCook.Name = "FCook";
            this.FCook.Size = new System.Drawing.Size(150, 36);
            this.FCook.TabIndex = 5;
            this.FCook.Text = "Готовить";
            this.FCook.UseVisualStyleBackColor = true;
            this.FCook.Click += new System.EventHandler(this.FCook_Click);
            // 
            // FGet
            // 
            this.FGet.Location = new System.Drawing.Point(426, 343);
            this.FGet.Name = "FGet";
            this.FGet.Size = new System.Drawing.Size(274, 60);
            this.FGet.TabIndex = 6;
            this.FGet.Text = "Положить яичницу на тарелку";
            this.FGet.UseVisualStyleBackColor = true;
            this.FGet.Click += new System.EventHandler(this.FGet_Click);
            // 
            // FOK
            // 
            this.FOK.Location = new System.Drawing.Point(154, 41);
            this.FOK.Name = "FOK";
            this.FOK.Size = new System.Drawing.Size(88, 32);
            this.FOK.TabIndex = 10;
            this.FOK.Text = "OK";
            this.FOK.UseVisualStyleBackColor = true;
            this.FOK.Click += new System.EventHandler(this.FOK_Click);
            // 
            // FKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 722);
            this.Controls.Add(this.FGet);
            this.Controls.Add(this.FCook);
            this.Controls.Add(this.FHit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FWash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FWaterTab);
            this.Name = "FKitchen";
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FWaterTab.ResumeLayout(false);
            this.FWaterTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCountEggs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FWaterTab;
        private System.Windows.Forms.RadioButton FOpen;
        private System.Windows.Forms.RadioButton FClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FOff;
        private System.Windows.Forms.RadioButton FOn;
        private System.Windows.Forms.Button FWash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown FCountEggs;
        private System.Windows.Forms.CheckBox FButter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FSalt;
        private System.Windows.Forms.Button FHit;
        private System.Windows.Forms.Button FCook;
        private System.Windows.Forms.Button FGet;
        private System.Windows.Forms.Button FOK;
    }
}

