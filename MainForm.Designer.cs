namespace Mosaic
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnFavorites = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.headerControl1 = new Mosaic.HeaderControl();
            this.footerControl1 = new Mosaic.FooterControl();
            this.lblDescr2 = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDots = new System.Windows.Forms.Panel();
            this.dot2 = new System.Windows.Forms.Label();
            this.dot4 = new System.Windows.Forms.Label();
            this.dot3 = new System.Windows.Forms.Label();
            this.dot1 = new System.Windows.Forms.Label();
            this.pictureSlideshow = new System.Windows.Forms.PictureBox();
            this.slideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFavorites.SuspendLayout();
            this.pnlDots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlideshow)).BeginInit();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFavorites
            // 
            this.btnFavorites.Controls.Add(this.lblHistory);
            this.btnFavorites.Controls.Add(this.btnDiscover);
            this.btnFavorites.Controls.Add(this.btnFavourites);
            this.btnFavorites.Controls.Add(this.headerControl1);
            this.btnFavorites.Controls.Add(this.footerControl1);
            this.btnFavorites.Controls.Add(this.lblDescr2);
            this.btnFavorites.Controls.Add(this.lblDescr);
            this.btnFavorites.Controls.Add(this.lblTitle);
            this.btnFavorites.Controls.Add(this.pnlDots);
            this.btnFavorites.Controls.Add(this.pictureSlideshow);
            this.btnFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavorites.Location = new System.Drawing.Point(0, 0);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(988, 603);
            this.btnFavorites.TabIndex = 6;
            // 
            // lblHistory
            // 
            this.lblHistory.BackColor = System.Drawing.Color.White;
            this.lblHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.lblHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.lblHistory.Image = global::Mosaic.Properties.Resources.info_transp;
            this.lblHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHistory.Location = new System.Drawing.Point(398, 414);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(184, 95);
            this.lblHistory.TabIndex = 28;
            this.lblHistory.Text = "Ιστορικό";
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lblHistory.UseVisualStyleBackColor = false;
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // btnDiscover
            // 
            this.btnDiscover.BackColor = System.Drawing.Color.White;
            this.btnDiscover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnDiscover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnDiscover.Image = global::Mosaic.Properties.Resources.stars_transp;
            this.btnDiscover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiscover.Location = new System.Drawing.Point(668, 414);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(184, 95);
            this.btnDiscover.TabIndex = 27;
            this.btnDiscover.Text = "Ανακάλυψε";
            this.btnDiscover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiscover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscover.UseVisualStyleBackColor = false;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.BackColor = System.Drawing.Color.White;
            this.btnFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavourites.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavourites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btnFavourites.Image = global::Mosaic.Properties.Resources.fav_transp;
            this.btnFavourites.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFavourites.Location = new System.Drawing.Point(102, 414);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(184, 95);
            this.btnFavourites.TabIndex = 26;
            this.btnFavourites.Text = "Αγαπημένα";
            this.btnFavourites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFavourites.UseVisualStyleBackColor = false;
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(989, 71);
            this.headerControl1.TabIndex = 6;
            // 
            // footerControl1
            // 
            this.footerControl1.BackColor = System.Drawing.Color.White;
            this.footerControl1.Location = new System.Drawing.Point(0, 533);
            this.footerControl1.Name = "footerControl1";
            this.footerControl1.Size = new System.Drawing.Size(985, 70);
            this.footerControl1.TabIndex = 5;
            // 
            // lblDescr2
            // 
            this.lblDescr2.AutoSize = true;
            this.lblDescr2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDescr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDescr2.Location = new System.Drawing.Point(29, 236);
            this.lblDescr2.Name = "lblDescr2";
            this.lblDescr2.Size = new System.Drawing.Size(329, 25);
            this.lblDescr2.TabIndex = 4;
            this.lblDescr2.Text = "εκδηλώσεις που ταιριάζουν σε εσένα.";
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDescr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblDescr.Location = new System.Drawing.Point(26, 198);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(348, 25);
            this.lblDescr.TabIndex = 3;
            this.lblDescr.Text = "Ανακάλυψε πολιτιστικές και κοινωνικές";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 135);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Καλωσήρθες στο MOSAIC!";
            // 
            // pnlDots
            // 
            this.pnlDots.Controls.Add(this.dot2);
            this.pnlDots.Controls.Add(this.dot4);
            this.pnlDots.Controls.Add(this.dot3);
            this.pnlDots.Controls.Add(this.dot1);
            this.pnlDots.Location = new System.Drawing.Point(392, 359);
            this.pnlDots.Name = "pnlDots";
            this.pnlDots.Size = new System.Drawing.Size(596, 27);
            this.pnlDots.TabIndex = 1;
            // 
            // dot2
            // 
            this.dot2.AutoSize = true;
            this.dot2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot2.ForeColor = System.Drawing.Color.LightGray;
            this.dot2.Location = new System.Drawing.Point(287, 0);
            this.dot2.Name = "dot2";
            this.dot2.Size = new System.Drawing.Size(19, 15);
            this.dot2.TabIndex = 3;
            this.dot2.Text = "⚫";
            // 
            // dot4
            // 
            this.dot4.AutoSize = true;
            this.dot4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot4.ForeColor = System.Drawing.Color.LightGray;
            this.dot4.Location = new System.Drawing.Point(405, 0);
            this.dot4.Name = "dot4";
            this.dot4.Size = new System.Drawing.Size(19, 15);
            this.dot4.TabIndex = 5;
            this.dot4.Text = "⚫";
            // 
            // dot3
            // 
            this.dot3.AutoSize = true;
            this.dot3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot3.ForeColor = System.Drawing.Color.LightGray;
            this.dot3.Location = new System.Drawing.Point(351, 0);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(19, 15);
            this.dot3.TabIndex = 4;
            this.dot3.Text = "⚫";
            // 
            // dot1
            // 
            this.dot1.AutoSize = true;
            this.dot1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.dot1.Location = new System.Drawing.Point(229, 0);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(19, 15);
            this.dot1.TabIndex = 2;
            this.dot1.Text = "⚫";
            // 
            // pictureSlideshow
            // 
            this.pictureSlideshow.Location = new System.Drawing.Point(392, 87);
            this.pictureSlideshow.Name = "pictureSlideshow";
            this.pictureSlideshow.Size = new System.Drawing.Size(596, 254);
            this.pictureSlideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSlideshow.TabIndex = 0;
            this.pictureSlideshow.TabStop = false;
            // 
            // slideshowTimer
            // 
            this.slideshowTimer.Enabled = true;
            this.slideshowTimer.Interval = 3000;
            this.slideshowTimer.Tick += new System.EventHandler(this.slideshowTimer_Tick);
            // 
            // pnlUsername
            // 
            this.pnlUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsername.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsername.Controls.Add(this.pictureBox1);
            this.pnlUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.pnlUsername.Location = new System.Drawing.Point(906, 12);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(128, 38);
            this.pnlUsername.TabIndex = 11;
            this.pnlUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUsername_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(988, 603);
            this.Controls.Add(this.btnFavorites);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mosaic Homepage";
            this.btnFavorites.ResumeLayout(false);
            this.btnFavorites.PerformLayout();
            this.pnlDots.ResumeLayout(false);
            this.pnlDots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlideshow)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel btnFavorites;
        private System.Windows.Forms.PictureBox pictureSlideshow;
        private System.Windows.Forms.Timer slideshowTimer;
        private System.Windows.Forms.Label dot2;
        private System.Windows.Forms.Panel pnlDots;
        private System.Windows.Forms.Label dot4;
        private System.Windows.Forms.Label dot3;
        private System.Windows.Forms.Label dot1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblDescr2;
        private FooterControl footerControl1;
        private HeaderControl headerControl1;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button lblHistory;
    }
}