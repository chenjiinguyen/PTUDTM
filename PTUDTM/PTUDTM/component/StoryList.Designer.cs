using System.ComponentModel;
using System.Drawing;
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

        [Description("Picture Poster"), Category("Custom")]
        public Image Poster
        {
            get { return picturePoster.Image; }
            set { picturePoster.Image = value; }
        }

        [Description("Text in Title"), Category("Custom")]
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        [Description("Text in Author"), Category("Custom")]
        public string Author
        {
            get { return lblAuthor.Text; }
            set { lblAuthor.Text = value; }
        }

        [Description("Text in AuthorName"), Category("Custom")]
        public string AuthorName
        {
            get { return lblAuthorName.Text; }
            set { lblAuthorName.Text = value; }
        }

        [Description("Text in Category"), Category("Custom")]
        public string Category
        {
            get { return lblCategory.Text; }
            set { lblCategory.Text = value; }
        }

        [Description("Text in CategoryName"), Category("Custom")]
        public string CategoryName
        {
            get { return lblCateName.Text; }
            set { lblCateName.Text = value; }
        }

        [Description("Text in DatePost"), Category("Custom")]
        public string DatePost
        {
            get { return lblDatePost.Text; }
            set { lblDatePost.Text = value; }
        }

        [Description("Text in Time"), Category("Custom")]
        public string Time
        {
            get { return lblTime.Text; }
            set { lblTime.Text = value; }
        }

        [Description("Text in View"), Category("Custom")]
        public string View
        {
            get { return lblView.Text; }
            set { lblView.Text = value; }
        }

        [Description("Text in ViewNumber"), Category("Custom")]
        public string ViewNumber
        {
            get { return lblViewNumber.Text; }
            set { lblViewNumber.Text = value; }
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCateName = new System.Windows.Forms.Label();
            this.lblDatePost = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picturePoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblViewNumber, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthorName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCategory, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCateName, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDatePost, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTime, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblView, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.picturePoster, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.49738F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.07853F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(529, 310);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // lblViewNumber
            // 
            this.lblViewNumber.AutoSize = true;
            this.lblViewNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewNumber.Location = new System.Drawing.Point(347, 248);
            this.lblViewNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewNumber.Name = "lblViewNumber";
            this.lblViewNumber.Size = new System.Drawing.Size(301, 47);
            this.lblViewNumber.TabIndex = 12;
            this.lblViewNumber.Text = "100";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(232, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(416, 85);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MẮT BIẾC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(232, 85);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(111, 54);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Tác giả:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(347, 85);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(301, 54);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Nguyễn Nhật Ánh";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(232, 139);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(111, 55);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Thể loại:";
            // 
            // lblCateName
            // 
            this.lblCateName.AutoSize = true;
            this.lblCateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateName.Location = new System.Drawing.Point(347, 139);
            this.lblCateName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCateName.Name = "lblCateName";
            this.lblCateName.Size = new System.Drawing.Size(301, 55);
            this.lblCateName.TabIndex = 5;
            this.lblCateName.Text = "Truyện chữ";
            // 
            // lblDatePost
            // 
            this.lblDatePost.AutoSize = true;
            this.lblDatePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(232, 194);
            this.lblDatePost.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(111, 54);
            this.lblDatePost.TabIndex = 6;
            this.lblDatePost.Text = "Ngày đăng:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(347, 194);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(301, 54);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "16/07/2021";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(232, 248);
            this.lblView.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(111, 47);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "Lượt xem:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 3);
            this.panel1.Location = new System.Drawing.Point(2, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 1);
            this.panel1.TabIndex = 13;
            // 
            // picturePoster
            // 
            this.picturePoster.BorderRadius = 14;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePoster.Image = global::PTUDTM.Properties.Resources.poster_not_available;
            this.picturePoster.Location = new System.Drawing.Point(15, 16);
            this.picturePoster.Margin = new System.Windows.Forms.Padding(15, 16, 2, 16);
            this.picturePoster.Name = "picturePoster";
            this.tableLayoutPanel2.SetRowSpan(this.picturePoster, 5);
            this.picturePoster.ShadowDecoration.Parent = this.picturePoster;
            this.picturePoster.Size = new System.Drawing.Size(200, 263);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePoster.TabIndex = 14;
            this.picturePoster.TabStop = false;
            // 
            // StoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StoryList";
            this.Size = new System.Drawing.Size(529, 310);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private Guna.UI2.WinForms.Guna2PictureBox picturePoster;
    }
}
