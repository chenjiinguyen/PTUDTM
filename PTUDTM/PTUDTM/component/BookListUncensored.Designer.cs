﻿using System.ComponentModel;
using System.Drawing;

namespace PTUDTM.component
{
    partial class BookListUncensored
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAuthor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAuthorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblViewNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCateName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblView = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDatePost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEpisodeCensor = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookCensor = new Guna.UI2.WinForms.Guna2Button();
            this.picturePoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.99681F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.00319F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tableLayoutPanel1.Controls.Add(this.picturePoster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthorName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblViewNumber, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCateName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDatePost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.3956F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.6044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 334);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.guna2Panel1, 4);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Location = new System.Drawing.Point(15, 319);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1076, 1);
            this.guna2Panel1.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(246, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15, 24, 2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MẮT BIẾC\r\n";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(246, 77);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(76, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Tác giả:";
            this.lblAuthor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(356, 77);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(2);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(145, 24);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Nguyễn Nhật Ánh";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(246, 139);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 24);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Thể loại:";
            // 
            // lblViewNumber
            // 
            this.lblViewNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblViewNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewNumber.Location = new System.Drawing.Point(356, 254);
            this.lblViewNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lblViewNumber.Name = "lblViewNumber";
            this.lblViewNumber.Size = new System.Drawing.Size(33, 24);
            this.lblViewNumber.TabIndex = 9;
            this.lblViewNumber.Text = "100";
            // 
            // lblCateName
            // 
            this.lblCateName.BackColor = System.Drawing.Color.Transparent;
            this.lblCateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateName.Location = new System.Drawing.Point(356, 139);
            this.lblCateName.Margin = new System.Windows.Forms.Padding(2);
            this.lblCateName.Name = "lblCateName";
            this.lblCateName.Size = new System.Drawing.Size(94, 24);
            this.lblCateName.TabIndex = 5;
            this.lblCateName.Text = "Truyện chữ";
            // 
            // lblView
            // 
            this.lblView.BackColor = System.Drawing.Color.Transparent;
            this.lblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(246, 254);
            this.lblView.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(90, 24);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "Lượt xem:";
            // 
            // lblDatePost
            // 
            this.lblDatePost.BackColor = System.Drawing.Color.Transparent;
            this.lblDatePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(246, 196);
            this.lblDatePost.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(105, 24);
            this.lblDatePost.TabIndex = 6;
            this.lblDatePost.Text = "Ngày đăng:";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(356, 196);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(93, 24);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "16/07/2021";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEpisodeCensor);
            this.panel1.Controls.Add(this.btnBookCensor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(708, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(383, 173);
            this.panel1.TabIndex = 12;
            // 
            // btnEpisodeCensor
            // 
            this.btnEpisodeCensor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEpisodeCensor.BorderRadius = 5;
            this.btnEpisodeCensor.CheckedState.Parent = this.btnEpisodeCensor;
            this.btnEpisodeCensor.CustomImages.Parent = this.btnEpisodeCensor;
            this.btnEpisodeCensor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEpisodeCensor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEpisodeCensor.ForeColor = System.Drawing.Color.White;
            this.btnEpisodeCensor.HoverState.Parent = this.btnEpisodeCensor;
            this.btnEpisodeCensor.Location = new System.Drawing.Point(145, 94);
            this.btnEpisodeCensor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEpisodeCensor.Name = "btnEpisodeCensor";
            this.btnEpisodeCensor.ShadowDecoration.Parent = this.btnEpisodeCensor;
            this.btnEpisodeCensor.Size = new System.Drawing.Size(172, 62);
            this.btnEpisodeCensor.TabIndex = 12;
            this.btnEpisodeCensor.Text = "Kiểm duyệt chương";
            this.btnEpisodeCensor.Click += new System.EventHandler(this.btnEpisodeCensor_Click);
            // 
            // btnBookCensor
            // 
            this.btnBookCensor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBookCensor.BorderRadius = 5;
            this.btnBookCensor.CheckedState.Parent = this.btnBookCensor;
            this.btnBookCensor.CustomImages.Parent = this.btnBookCensor;
            this.btnBookCensor.FillColor = System.Drawing.Color.Red;
            this.btnBookCensor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBookCensor.ForeColor = System.Drawing.Color.White;
            this.btnBookCensor.HoverState.Parent = this.btnBookCensor;
            this.btnBookCensor.Location = new System.Drawing.Point(145, 19);
            this.btnBookCensor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookCensor.Name = "btnBookCensor";
            this.btnBookCensor.ShadowDecoration.Parent = this.btnBookCensor;
            this.btnBookCensor.Size = new System.Drawing.Size(172, 62);
            this.btnBookCensor.TabIndex = 11;
            this.btnBookCensor.Text = "Kiểm duyệt sách";
            this.btnBookCensor.Click += new System.EventHandler(this.btnBookCensor_Click);
            // 
            // picturePoster
            // 
            this.picturePoster.BorderRadius = 14;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePoster.Image = global::PTUDTM.Properties.Resources.poster_not_available;
            this.picturePoster.Location = new System.Drawing.Point(15, 16);
            this.picturePoster.Margin = new System.Windows.Forms.Padding(15, 16, 2, 2);
            this.picturePoster.Name = "picturePoster";
            this.tableLayoutPanel1.SetRowSpan(this.picturePoster, 5);
            this.picturePoster.ShadowDecoration.Parent = this.picturePoster;
            this.picturePoster.Size = new System.Drawing.Size(214, 287);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePoster.TabIndex = 0;
            this.picturePoster.TabStop = false;
            // 
            // BookListUncensored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookListUncensored";
            this.Size = new System.Drawing.Size(1093, 334);
            this.Load += new System.EventHandler(this.BookListUncensored_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox picturePoster;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnBookCensor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAuthor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAuthorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblViewNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCateName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblView;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDatePost;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEpisodeCensor;
    }
}
