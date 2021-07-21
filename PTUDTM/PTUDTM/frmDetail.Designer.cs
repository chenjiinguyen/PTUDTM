namespace PTUDTM
{
    partial class frmDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetail));
            this.pnlTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblCateName = new System.Windows.Forms.Label();
            this.btnStatus = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAddEpisode = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleEpi = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.episodeList1 = new PTUDTM.component.EpisodeList();
            this.episodeList2 = new PTUDTM.component.EpisodeList();
            this.episodeList3 = new PTUDTM.component.EpisodeList();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblAuthorName);
            this.pnlTop.Controls.Add(this.lblCateName);
            this.pnlTop.Controls.Add(this.btnStatus);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.txtDetail);
            this.pnlTop.Location = new System.Drawing.Point(281, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.Parent = this.pnlTop;
            this.pnlTop.Size = new System.Drawing.Size(1241, 323);
            this.pnlTop.TabIndex = 0;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblAuthorName.Location = new System.Drawing.Point(195, 276);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(214, 29);
            this.lblAuthorName.TabIndex = 9;
            this.lblAuthorName.Text = "Nguyễn Nhật Ánh";
            // 
            // lblCateName
            // 
            this.lblCateName.AutoSize = true;
            this.lblCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCateName.Location = new System.Drawing.Point(23, 276);
            this.lblCateName.Name = "lblCateName";
            this.lblCateName.Size = new System.Drawing.Size(142, 29);
            this.lblCateName.TabIndex = 8;
            this.lblCateName.Text = "Truyện chữ";
            // 
            // btnStatus
            // 
            this.btnStatus.BorderRadius = 5;
            this.btnStatus.CheckedState.Parent = this.btnStatus;
            this.btnStatus.CustomImages.Parent = this.btnStatus;
            this.btnStatus.Enabled = false;
            this.btnStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.HoverState.Parent = this.btnStatus;
            this.btnStatus.Location = new System.Drawing.Point(1031, 11);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.ShadowDecoration.Parent = this.btnStatus;
            this.btnStatus.Size = new System.Drawing.Size(180, 69);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Chào anh";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MẮT BIẾC";
            // 
            // txtDetail
            // 
            this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(9, 96);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(1211, 164);
            this.txtDetail.TabIndex = 1;
            this.txtDetail.Text = resources.GetString("txtDetail.Text");
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnAddEpisode);
            this.pnlLeft.Controls.Add(this.btnDelete);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.guna2PictureBox1);
            this.pnlLeft.Location = new System.Drawing.Point(-2, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.ShadowDecoration.Parent = this.pnlLeft;
            this.pnlLeft.Size = new System.Drawing.Size(277, 782);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnAddEpisode
            // 
            this.btnAddEpisode.BorderRadius = 5;
            this.btnAddEpisode.CheckedState.Parent = this.btnAddEpisode;
            this.btnAddEpisode.CustomImages.Parent = this.btnAddEpisode;
            this.btnAddEpisode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddEpisode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddEpisode.ForeColor = System.Drawing.Color.White;
            this.btnAddEpisode.HoverState.Parent = this.btnAddEpisode;
            this.btnAddEpisode.Location = new System.Drawing.Point(50, 522);
            this.btnAddEpisode.Name = "btnAddEpisode";
            this.btnAddEpisode.ShadowDecoration.Parent = this.btnAddEpisode;
            this.btnAddEpisode.Size = new System.Drawing.Size(180, 69);
            this.btnAddEpisode.TabIndex = 3;
            this.btnAddEpisode.Text = "Thêm chương";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(50, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(180, 69);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(50, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(180, 69);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 14;
            this.guna2PictureBox1.Image = global::PTUDTM.Properties.Resources.mat_biec_bia_cung_2019;
            this.guna2PictureBox1.Location = new System.Drawing.Point(14, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(260, 297);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.87265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.12735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitleEpi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.episodeList1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.episodeList2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.episodeList3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.02778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.97222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1199, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitleEpi
            // 
            this.lblTitleEpi.AutoSize = true;
            this.lblTitleEpi.BackColor = System.Drawing.Color.LightGray;
            this.lblTitleEpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleEpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEpi.Location = new System.Drawing.Point(3, 0);
            this.lblTitleEpi.Name = "lblTitleEpi";
            this.lblTitleEpi.Size = new System.Drawing.Size(463, 52);
            this.lblTitleEpi.TabIndex = 0;
            this.lblTitleEpi.Text = "Tiêu đề chương";
            this.lblTitleEpi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.LightGray;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(472, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(216, 52);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(694, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(222, 52);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Trạng thái";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(922, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 52);
            this.label1.TabIndex = 3;
            // 
            // episodeList1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.episodeList1, 4);
            this.episodeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.episodeList1.Episode = "Chương 1";
            this.episodeList1.Location = new System.Drawing.Point(3, 55);
            this.episodeList1.Name = "episodeList1";
            this.episodeList1.Size = new System.Drawing.Size(1193, 96);
            this.episodeList1.Status = "Thành công";
            this.episodeList1.TabIndex = 4;
            this.episodeList1.Time = "17/07/2021";
            // 
            // episodeList2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.episodeList2, 4);
            this.episodeList2.Episode = "Chương 2";
            this.episodeList2.Location = new System.Drawing.Point(3, 157);
            this.episodeList2.Name = "episodeList2";
            this.episodeList2.Size = new System.Drawing.Size(1193, 94);
            this.episodeList2.Status = "Thành công";
            this.episodeList2.TabIndex = 5;
            this.episodeList2.Time = "16/07/2021";
            // 
            // episodeList3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.episodeList3, 4);
            this.episodeList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.episodeList3.Episode = "Chương 1";
            this.episodeList3.Location = new System.Drawing.Point(3, 257);
            this.episodeList3.Name = "episodeList3";
            this.episodeList3.Size = new System.Drawing.Size(1193, 92);
            this.episodeList3.Status = "Thành công";
            this.episodeList3.TabIndex = 6;
            this.episodeList3.Time = "17/07/2021";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(281, 324);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1241, 459);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 783);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmDetail";
            this.Text = "frmDetail";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlTop;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlLeft;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAddEpisode;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnStatus;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblCateName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitleEpi;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private component.EpisodeList episodeList1;
        private component.EpisodeList episodeList2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private component.EpisodeList episodeList3;
    }
}