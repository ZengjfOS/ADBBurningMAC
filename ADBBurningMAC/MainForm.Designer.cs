namespace ADBBurningMAC
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eepromVersion = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.displayType = new System.Windows.Forms.ComboBox();
            this.currentMAC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteAllMac = new System.Windows.Forms.Button();
            this.deleteMac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.macB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMAC = new System.Windows.Forms.Button();
            this.macE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.macLV = new System.Windows.Forms.ListView();
            this.adbCmd = new System.Windows.Forms.Button();
            this.cleanOutputMessage = new System.Windows.Forms.Button();
            this.adbcmdShow = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BurningProgressBar = new System.Windows.Forms.ProgressBar();
            this.BurningStatue = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Display:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version: ";
            // 
            // eepromVersion
            // 
            this.eepromVersion.FormattingEnabled = true;
            this.eepromVersion.Location = new System.Drawing.Point(86, 18);
            this.eepromVersion.Name = "eepromVersion";
            this.eepromVersion.Size = new System.Drawing.Size(49, 22);
            this.eepromVersion.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.displayType);
            this.groupBox5.Controls.Add(this.eepromVersion);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(9, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(631, 48);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Argument";
            // 
            // displayType
            // 
            this.displayType.FormattingEnabled = true;
            this.displayType.Location = new System.Drawing.Point(227, 18);
            this.displayType.Name = "displayType";
            this.displayType.Size = new System.Drawing.Size(69, 22);
            this.displayType.TabIndex = 0;
            // 
            // currentMAC
            // 
            this.currentMAC.AutoSize = true;
            this.currentMAC.Location = new System.Drawing.Point(99, 23);
            this.currentMAC.Name = "currentMAC";
            this.currentMAC.Size = new System.Drawing.Size(126, 14);
            this.currentMAC.TabIndex = 19;
            this.currentMAC.Text = "00:00:00:00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Selected MAC: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.macLV);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(9, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 240);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentMAC);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.deleteAllMac);
            this.groupBox3.Controls.Add(this.deleteMac);
            this.groupBox3.Location = new System.Drawing.Point(400, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 95);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete MAC";
            // 
            // deleteAllMac
            // 
            this.deleteAllMac.Location = new System.Drawing.Point(115, 51);
            this.deleteAllMac.Name = "deleteAllMac";
            this.deleteAllMac.Size = new System.Drawing.Size(101, 33);
            this.deleteAllMac.TabIndex = 20;
            this.deleteAllMac.Text = "Delete All";
            this.deleteAllMac.UseVisualStyleBackColor = true;
            // 
            // deleteMac
            // 
            this.deleteMac.Location = new System.Drawing.Point(10, 51);
            this.deleteMac.Name = "deleteMac";
            this.deleteMac.Size = new System.Drawing.Size(102, 33);
            this.deleteMac.TabIndex = 16;
            this.deleteMac.Text = "Delete";
            this.deleteMac.UseVisualStyleBackColor = true;
            this.deleteMac.Click += new System.EventHandler(this.deleteDB);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.macB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addMAC);
            this.groupBox1.Controls.Add(this.macE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(400, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 111);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add MAC";
            // 
            // macB
            // 
            this.macB.Location = new System.Drawing.Point(82, 18);
            this.macB.Name = "macB";
            this.macB.Size = new System.Drawing.Size(134, 23);
            this.macB.TabIndex = 1;
            this.macB.Text = "00:00:00:00:00:00";
            this.macB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAC Begin:";
            // 
            // addMAC
            // 
            this.addMAC.Location = new System.Drawing.Point(37, 76);
            this.addMAC.Name = "addMAC";
            this.addMAC.Size = new System.Drawing.Size(146, 28);
            this.addMAC.TabIndex = 0;
            this.addMAC.Text = "Add MAC";
            this.addMAC.UseVisualStyleBackColor = true;
            this.addMAC.Click += new System.EventHandler(this.addMACClick);
            // 
            // macE
            // 
            this.macE.Location = new System.Drawing.Point(82, 47);
            this.macE.Name = "macE";
            this.macE.Size = new System.Drawing.Size(134, 23);
            this.macE.TabIndex = 4;
            this.macE.Text = "00:00:00:00:00:00";
            this.macE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "MAC End:";
            // 
            // macLV
            // 
            this.macLV.GridLines = true;
            this.macLV.Location = new System.Drawing.Point(13, 22);
            this.macLV.Name = "macLV";
            this.macLV.Size = new System.Drawing.Size(378, 212);
            this.macLV.TabIndex = 14;
            this.macLV.UseCompatibleStateImageBehavior = false;
            this.macLV.View = System.Windows.Forms.View.Details;
            // 
            // adbCmd
            // 
            this.adbCmd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adbCmd.Location = new System.Drawing.Point(550, 20);
            this.adbCmd.Name = "adbCmd";
            this.adbCmd.Size = new System.Drawing.Size(75, 80);
            this.adbCmd.TabIndex = 7;
            this.adbCmd.Text = "ADB Write";
            this.adbCmd.UseVisualStyleBackColor = true;
            this.adbCmd.Click += new System.EventHandler(this.adbCmdClick);
            // 
            // cleanOutputMessage
            // 
            this.cleanOutputMessage.Location = new System.Drawing.Point(550, 113);
            this.cleanOutputMessage.Name = "cleanOutputMessage";
            this.cleanOutputMessage.Size = new System.Drawing.Size(75, 49);
            this.cleanOutputMessage.TabIndex = 12;
            this.cleanOutputMessage.Text = "Clean";
            this.cleanOutputMessage.UseVisualStyleBackColor = true;
            this.cleanOutputMessage.Click += new System.EventHandler(this.cleanAdbCmdShowClick);
            // 
            // adbcmdShow
            // 
            this.adbcmdShow.Location = new System.Drawing.Point(10, 20);
            this.adbcmdShow.Multiline = true;
            this.adbcmdShow.Name = "adbcmdShow";
            this.adbcmdShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.adbcmdShow.Size = new System.Drawing.Size(534, 142);
            this.adbcmdShow.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BurningStatue);
            this.groupBox2.Controls.Add(this.cleanOutputMessage);
            this.groupBox2.Controls.Add(this.adbcmdShow);
            this.groupBox2.Controls.Add(this.adbCmd);
            this.groupBox2.Controls.Add(this.BurningProgressBar);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(9, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 197);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADB To EEPROM Output Message";
            // 
            // BurningProgressBar
            // 
            this.BurningProgressBar.Location = new System.Drawing.Point(10, 169);
            this.BurningProgressBar.Name = "BurningProgressBar";
            this.BurningProgressBar.Size = new System.Drawing.Size(534, 23);
            this.BurningProgressBar.TabIndex = 13;
            // 
            // BurningStatue
            // 
            this.BurningStatue.Location = new System.Drawing.Point(562, 170);
            this.BurningStatue.Name = "BurningStatue";
            this.BurningStatue.Size = new System.Drawing.Size(52, 23);
            this.BurningStatue.TabIndex = 14;
            this.BurningStatue.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "ADBBurningMAC";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox eepromVersion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox displayType;
        private System.Windows.Forms.Label currentMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView macLV;
        private System.Windows.Forms.Button deleteMac;
        private System.Windows.Forms.Button cleanOutputMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMAC;
        private System.Windows.Forms.TextBox macB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox macE;
        private System.Windows.Forms.TextBox adbcmdShow;
        private System.Windows.Forms.Button adbCmd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteAllMac;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar BurningProgressBar;
        private System.Windows.Forms.Button BurningStatue;
    }
}

