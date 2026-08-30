namespace Mosaic
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.pnlDevInfo = new System.Windows.Forms.Panel();
            this.lblDevURL1 = new System.Windows.Forms.LinkLabel();
            this.lblDevAM1 = new System.Windows.Forms.Label();
            this.lblDevFullName1 = new System.Windows.Forms.Label();
            this.lblDevName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDevURL2 = new System.Windows.Forms.LinkLabel();
            this.lblDevAM2 = new System.Windows.Forms.Label();
            this.lblDevFullName2 = new System.Windows.Forms.Label();
            this.headerControl1 = new Mosaic.HeaderControl();
            this.pnlDevInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(33, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 48);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Πίσω";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnExit.Location = new System.Drawing.Point(858, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 48);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Έξοδος";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblTitle.Location = new System.Drawing.Point(437, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 37);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Σχετικά";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDescription.Location = new System.Drawing.Point(29, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(2290, 20);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDevTitle.Location = new System.Drawing.Point(428, 209);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(138, 31);
            this.lblDevTitle.TabIndex = 31;
            this.lblDevTitle.Text = "Δημιουργοί";
            // 
            // pnlDevInfo
            // 
            this.pnlDevInfo.BackColor = System.Drawing.Color.White;
            this.pnlDevInfo.Controls.Add(this.lblDevURL1);
            this.pnlDevInfo.Controls.Add(this.lblDevAM1);
            this.pnlDevInfo.Controls.Add(this.lblDevFullName1);
            this.pnlDevInfo.Location = new System.Drawing.Point(278, 265);
            this.pnlDevInfo.Name = "pnlDevInfo";
            this.pnlDevInfo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDevInfo.Size = new System.Drawing.Size(216, 159);
            this.pnlDevInfo.TabIndex = 32;
            // 
            // lblDevURL1
            // 
            this.lblDevURL1.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblDevURL1.AutoSize = true;
            this.lblDevURL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDevURL1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevURL1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblDevURL1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.lblDevURL1.Location = new System.Drawing.Point(22, 112);
            this.lblDevURL1.Name = "lblDevURL1";
            this.lblDevURL1.Size = new System.Drawing.Size(64, 20);
            this.lblDevURL1.TabIndex = 38;
            this.lblDevURL1.TabStop = true;
            this.lblDevURL1.Text = "LinkedIn";
            this.lblDevURL1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDevURL1_LinkClicked);
            // 
            // lblDevAM1
            // 
            this.lblDevAM1.AutoSize = true;
            this.lblDevAM1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevAM1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDevAM1.Location = new System.Drawing.Point(22, 66);
            this.lblDevAM1.Name = "lblDevAM1";
            this.lblDevAM1.Size = new System.Drawing.Size(119, 20);
            this.lblDevAM1.TabIndex = 36;
            this.lblDevAM1.Text = "ΑΜ: ΜΠΠΛ2530";
            // 
            // lblDevFullName1
            // 
            this.lblDevFullName1.AutoSize = true;
            this.lblDevFullName1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevFullName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDevFullName1.Location = new System.Drawing.Point(22, 23);
            this.lblDevFullName1.Name = "lblDevFullName1";
            this.lblDevFullName1.Size = new System.Drawing.Size(162, 20);
            this.lblDevFullName1.TabIndex = 35;
            this.lblDevFullName1.Text = "Παπαδάκη Αναστασία";
            // 
            // lblDevName
            // 
            this.lblDevName.AutoSize = true;
            this.lblDevName.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDevName.Location = new System.Drawing.Point(-652, 215);
            this.lblDevName.Name = "lblDevName";
            this.lblDevName.Size = new System.Drawing.Size(76, 20);
            this.lblDevName.TabIndex = 33;
            this.lblDevName.Text = "Το MOSAI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(-652, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Το MOSAIC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDevURL2);
            this.panel1.Controls.Add(this.lblDevAM2);
            this.panel1.Controls.Add(this.lblDevFullName2);
            this.panel1.Location = new System.Drawing.Point(518, 265);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(216, 159);
            this.panel1.TabIndex = 39;
            // 
            // lblDevURL2
            // 
            this.lblDevURL2.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblDevURL2.AutoSize = true;
            this.lblDevURL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDevURL2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevURL2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblDevURL2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.lblDevURL2.Location = new System.Drawing.Point(22, 112);
            this.lblDevURL2.Name = "lblDevURL2";
            this.lblDevURL2.Size = new System.Drawing.Size(64, 20);
            this.lblDevURL2.TabIndex = 38;
            this.lblDevURL2.TabStop = true;
            this.lblDevURL2.Text = "LinkedIn";
            this.lblDevURL2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDevURL2_LinkClicked);
            // 
            // lblDevAM2
            // 
            this.lblDevAM2.AutoSize = true;
            this.lblDevAM2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevAM2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDevAM2.Location = new System.Drawing.Point(22, 66);
            this.lblDevAM2.Name = "lblDevAM2";
            this.lblDevAM2.Size = new System.Drawing.Size(117, 20);
            this.lblDevAM2.TabIndex = 36;
            this.lblDevAM2.Text = "ΑΜ: ΜΠΠΛ2516";
            // 
            // lblDevFullName2
            // 
            this.lblDevFullName2.AutoSize = true;
            this.lblDevFullName2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevFullName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDevFullName2.Location = new System.Drawing.Point(22, 23);
            this.lblDevFullName2.Name = "lblDevFullName2";
            this.lblDevFullName2.Size = new System.Drawing.Size(118, 20);
            this.lblDevFullName2.TabIndex = 35;
            this.lblDevFullName2.Text = "Δάφνη Κοντέλα";
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.headerControl1.Location = new System.Drawing.Point(-1, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(989, 71);
            this.headerControl1.TabIndex = 7;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(986, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDevName);
            this.Controls.Add(this.pnlDevInfo);
            this.Controls.Add(this.lblDevTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.headerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.pnlDevInfo.ResumeLayout(false);
            this.pnlDevInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HeaderControl headerControl1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.Panel pnlDevInfo;
        private System.Windows.Forms.Label lblDevName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDevFullName1;
        private System.Windows.Forms.LinkLabel lblDevURL1;
        private System.Windows.Forms.Label lblDevAM1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblDevURL2;
        private System.Windows.Forms.Label lblDevAM2;
        private System.Windows.Forms.Label lblDevFullName2;
    }
}