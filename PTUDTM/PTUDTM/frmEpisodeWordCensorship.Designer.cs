namespace PTUDTM
{
    partial class frmEpisodeWordCensorship
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
            this.txtContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblChapterTitle = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnAllow = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefuse = new Guna.UI2.WinForms.Guna2Button();
            this.lblContentCensor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtContentCensor = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.AutoScroll = true;
            this.txtContent.BorderRadius = 10;
            this.tableLayoutPanel1.SetColumnSpan(this.txtContent, 2);
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultText = "";
            this.txtContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.DisabledState.Parent = this.txtContent;
            this.txtContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.FocusedState.Parent = this.txtContent;
            this.txtContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.HoverState.Parent = this.txtContent;
            this.txtContent.Location = new System.Drawing.Point(339, 105);
            this.txtContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderText = "";
            this.txtContent.SelectedText = "";
            this.txtContent.ShadowDecoration.Parent = this.txtContent;
            this.txtContent.Size = new System.Drawing.Size(1245, 389);
            this.txtContent.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.6074F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.3926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 597F));
            this.tableLayoutPanel1.Controls.Add(this.txtContentCensor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRefuse, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblIntro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAllow, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblChapterTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblContentCensor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Separator1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.83122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.16878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1590, 957);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(20, 119);
            this.lblIntro.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(154, 36);
            this.lblIntro.TabIndex = 15;
            this.lblIntro.Text = "Nội dung:";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChapterTitle
            // 
            this.lblChapterTitle.AutoSize = true;
            this.lblChapterTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChapterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapterTitle.Location = new System.Drawing.Point(20, 0);
            this.lblChapterTitle.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblChapterTitle.Name = "lblChapterTitle";
            this.lblChapterTitle.Size = new System.Drawing.Size(310, 99);
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
            this.txtTitle.Size = new System.Drawing.Size(1245, 87);
            this.txtTitle.TabIndex = 13;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.guna2Separator1, 3);
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 842);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1584, 10);
            this.guna2Separator1.TabIndex = 16;
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
            this.btnAllow.Location = new System.Drawing.Point(733, 873);
            this.btnAllow.Margin = new System.Windows.Forms.Padding(400, 3, 3, 3);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.ShadowDecoration.Parent = this.btnAllow;
            this.btnAllow.Size = new System.Drawing.Size(139, 81);
            this.btnAllow.TabIndex = 17;
            this.btnAllow.Text = "Cho phép";
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
            this.btnRefuse.Location = new System.Drawing.Point(995, 873);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.ShadowDecoration.Parent = this.btnRefuse;
            this.btnRefuse.Size = new System.Drawing.Size(142, 81);
            this.btnRefuse.TabIndex = 18;
            this.btnRefuse.Text = "Từ chối";
            // 
            // lblContentCensor
            // 
            this.lblContentCensor.BackColor = System.Drawing.Color.Transparent;
            this.lblContentCensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContentCensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentCensor.Location = new System.Drawing.Point(3, 503);
            this.lblContentCensor.Name = "lblContentCensor";
            this.lblContentCensor.Size = new System.Drawing.Size(297, 35);
            this.lblContentCensor.TabIndex = 17;
            this.lblContentCensor.Text = "Nội dung kiểm duyệt:";
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
            this.txtContentCensor.Location = new System.Drawing.Point(339, 506);
            this.txtContentCensor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContentCensor.Multiline = true;
            this.txtContentCensor.Name = "txtContentCensor";
            this.txtContentCensor.PasswordChar = '\0';
            this.txtContentCensor.PlaceholderText = "";
            this.txtContentCensor.SelectedText = "";
            this.txtContentCensor.ShadowDecoration.Parent = this.txtContentCensor;
            this.txtContentCensor.Size = new System.Drawing.Size(1245, 313);
            this.txtContentCensor.TabIndex = 18;
            // 
            // frmEpisodeWordCensorship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 957);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEpisodeWordCensorship";
            this.Text = "frmEpisodeWordCensorship";
            this.Load += new System.EventHandler(this.frmEpisodeWordCensorship_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtContentCensor;
        private Guna.UI2.WinForms.Guna2Button btnRefuse;
        private System.Windows.Forms.Label lblIntro;
        private Guna.UI2.WinForms.Guna2Button btnAllow;
        private System.Windows.Forms.Label lblChapterTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContentCensor;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}