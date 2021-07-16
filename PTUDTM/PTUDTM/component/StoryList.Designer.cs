namespace PTUDTM.component
{
    partial class StoryList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCateName = new System.Windows.Forms.Label();
            this.lblDatePost = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.lblViewNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.00543F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05978F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93478F));
            this.tableLayoutPanel2.Controls.Add(this.lblViewNumber, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthorName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCategory, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCateName, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDatePost, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTime, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblView, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.26453F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.64457F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(745, 354);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::PTUDTM.Properties.Resources.mat_biec_bia_cung_2019;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox2, 5);
            this.pictureBox2.Size = new System.Drawing.Size(262, 334);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(271, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(471, 76);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MẮC BIẾC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(271, 76);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(150, 59);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Tác giả:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(427, 76);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(315, 59);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Nguyễn Nhật Ánh";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(271, 135);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(150, 65);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Thể loại:";
            // 
            // lblCateName
            // 
            this.lblCateName.AutoSize = true;
            this.lblCateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateName.Location = new System.Drawing.Point(427, 135);
            this.lblCateName.Name = "lblCateName";
            this.lblCateName.Size = new System.Drawing.Size(315, 65);
            this.lblCateName.TabIndex = 5;
            this.lblCateName.Text = "Truyện chữ";
            // 
            // lblDatePost
            // 
            this.lblDatePost.AutoSize = true;
            this.lblDatePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(271, 200);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(150, 72);
            this.lblDatePost.TabIndex = 6;
            this.lblDatePost.Text = "Ngày đăng:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(427, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(315, 72);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "16/07/2021";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(271, 272);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(150, 68);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "Lượt xem:";
            // 
            // lblViewNumber
            // 
            this.lblViewNumber.AutoSize = true;
            this.lblViewNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewNumber.Location = new System.Drawing.Point(427, 272);
            this.lblViewNumber.Name = "lblViewNumber";
            this.lblViewNumber.Size = new System.Drawing.Size(315, 68);
            this.lblViewNumber.TabIndex = 12;
            this.lblViewNumber.Text = "100";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 3);
            this.panel1.Location = new System.Drawing.Point(3, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 1);
            this.panel1.TabIndex = 13;
            // 
            // StoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "StoryList";
            this.Size = new System.Drawing.Size(745, 354);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblViewNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCateName;
        private System.Windows.Forms.Label lblDatePost;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Panel panel1;
    }
}
