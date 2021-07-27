namespace PTUDTM
{
    partial class frmEpisodeComicCensor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtContentCensor = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefuse = new Guna.UI2.WinForms.Guna2Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnAllow = new Guna.UI2.WinForms.Guna2Button();
            this.lblChapterTitle = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContentCensor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.6074F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.3926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 599F));
            this.tableLayoutPanel1.Controls.Add(this.txtContentCensor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRefuse, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblIntro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAllow, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblChapterTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContentCensor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Separator1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1590, 957);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtContentCensor
            // 
            this.txtContentCensor.AutoScroll = true;
            this.txtContentCensor.BorderRadius = 10;
            this.tableLayoutPanel1.SetColumnSpan(this.txtContentCensor, 2);
            this.txtContentCensor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContentCensor.DefaultText = "";
            this.txtContentCensor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContentCensor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContentCensor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContentCensor.DisabledState.Parent = this.txtContentCensor;
            this.txtContentCensor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContentCensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContentCensor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContentCensor.FocusedState.Parent = this.txtContentCensor;
            this.txtContentCensor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContentCensor.HoverState.Parent = this.txtContentCensor;
            this.txtContentCensor.Location = new System.Drawing.Point(339, 570);
            this.txtContentCensor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContentCensor.Multiline = true;
            this.txtContentCensor.Name = "txtContentCensor";
            this.txtContentCensor.PasswordChar = '\0';
            this.txtContentCensor.PlaceholderText = "";
            this.txtContentCensor.SelectedText = "";
            this.txtContentCensor.ShadowDecoration.Parent = this.txtContentCensor;
            this.txtContentCensor.Size = new System.Drawing.Size(1245, 250);
            this.txtContentCensor.TabIndex = 18;
            // 
            // btnRefuse
            // 
            this.btnRefuse.BorderRadius = 5;
            this.btnRefuse.CheckedState.Parent = this.btnRefuse;
            this.btnRefuse.CustomImages.Parent = this.btnRefuse;
            this.btnRefuse.FillColor = System.Drawing.Color.Red;
            this.btnRefuse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefuse.ForeColor = System.Drawing.Color.White;
            this.btnRefuse.HoverState.Parent = this.btnRefuse;
            this.btnRefuse.Location = new System.Drawing.Point(993, 874);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.ShadowDecoration.Parent = this.btnRefuse;
            this.btnRefuse.Size = new System.Drawing.Size(142, 80);
            this.btnRefuse.TabIndex = 18;
            this.btnRefuse.Text = "Từ chối";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(20, 129);
            this.lblIntro.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(154, 36);
            this.lblIntro.TabIndex = 15;
            this.lblIntro.Text = "Nội dung:";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAllow
            // 
            this.btnAllow.BorderRadius = 5;
            this.btnAllow.CheckedState.Parent = this.btnAllow;
            this.btnAllow.CustomImages.Parent = this.btnAllow;
            this.btnAllow.FillColor = System.Drawing.Color.OrangeRed;
            this.btnAllow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAllow.ForeColor = System.Drawing.Color.White;
            this.btnAllow.HoverState.Parent = this.btnAllow;
            this.btnAllow.Location = new System.Drawing.Point(733, 874);
            this.btnAllow.Margin = new System.Windows.Forms.Padding(400, 3, 3, 3);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.ShadowDecoration.Parent = this.btnAllow;
            this.btnAllow.Size = new System.Drawing.Size(139, 80);
            this.btnAllow.TabIndex = 17;
            this.btnAllow.Text = "Cho phép";
            // 
            // lblChapterTitle
            // 
            this.lblChapterTitle.AutoSize = true;
            this.lblChapterTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChapterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapterTitle.Location = new System.Drawing.Point(20, 0);
            this.lblChapterTitle.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblChapterTitle.Name = "lblChapterTitle";
            this.lblChapterTitle.Size = new System.Drawing.Size(310, 109);
            this.lblChapterTitle.TabIndex = 14;
            this.lblChapterTitle.Text = "Chapter tiêu đề:";
            this.lblChapterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 10;
            this.tableLayoutPanel1.SetColumnSpan(this.txtTitle, 2);
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(339, 6);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(1245, 97);
            this.txtTitle.TabIndex = 13;
            // 
            // lblContentCensor
            // 
            this.lblContentCensor.BackColor = System.Drawing.Color.Transparent;
            this.lblContentCensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContentCensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentCensor.Location = new System.Drawing.Point(3, 567);
            this.lblContentCensor.Name = "lblContentCensor";
            this.lblContentCensor.Size = new System.Drawing.Size(297, 35);
            this.lblContentCensor.TabIndex = 17;
            this.lblContentCensor.Text = "Nội dung kiểm duyệt:";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.guna2Separator1, 3);
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 843);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1584, 10);
            this.guna2Separator1.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.guna2PictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.guna2PictureBox2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1248, 449);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PTUDTM.Properties.Resources.poster_not_available;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(353, 386);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::PTUDTM.Properties.Resources.poster_not_available;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 395);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(353, 386);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmEpisodeComicCensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1007);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEpisodeComicCensor";
            this.Text = "frmEpisodeComicCensor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtContentCensor;
        private Guna.UI2.WinForms.Guna2Button btnRefuse;
        private System.Windows.Forms.Label lblIntro;
        private Guna.UI2.WinForms.Guna2Button btnAllow;
        private System.Windows.Forms.Label lblChapterTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContentCensor;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}