using System.ComponentModel;
using System.Drawing;
namespace PTUDTM.component
{
    partial class BookList
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAuthor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAuthorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCateName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDatePost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblView = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblViewNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picturePoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(328, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(20, 30, 3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MẮT BIẾC\r\n";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(328, 93);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(97, 31);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Tác giả:";
            this.lblAuthor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(466, 93);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(189, 31);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Nguyễn Nhật Ánh";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(328, 170);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(106, 31);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Thể loại:";
            // 
            // lblCateName
            // 
            this.lblCateName.BackColor = System.Drawing.Color.Transparent;
            this.lblCateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateName.Location = new System.Drawing.Point(466, 170);
            this.lblCateName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCateName.Name = "lblCateName";
            this.lblCateName.Size = new System.Drawing.Size(122, 31);
            this.lblCateName.TabIndex = 5;
            this.lblCateName.Text = "Truyện chữ";
            // 
            // lblDatePost
            // 
            this.lblDatePost.BackColor = System.Drawing.Color.Transparent;
            this.lblDatePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(328, 246);
            this.lblDatePost.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(135, 31);
            this.lblDatePost.TabIndex = 6;
            this.lblDatePost.Text = "Ngày đăng:";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(466, 246);
            this.lblTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 31);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "16/07/2021";
            // 
            // lblView
            // 
            this.lblView.BackColor = System.Drawing.Color.Transparent;
            this.lblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(328, 318);
            this.lblView.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(115, 31);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "Lượt xem:";
            // 
            // lblViewNumber
            // 
            this.lblViewNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblViewNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewNumber.Location = new System.Drawing.Point(466, 318);
            this.lblViewNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblViewNumber.Name = "lblViewNumber";
            this.lblViewNumber.Size = new System.Drawing.Size(42, 31);
            this.lblViewNumber.TabIndex = 9;
            this.lblViewNumber.Text = "100";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.guna2Panel1, 4);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 399);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1396, 1);
            this.guna2Panel1.TabIndex = 10;
            // 
            // btnDetail
            // 
            this.btnDetail.BorderRadius = 5;
            this.btnDetail.CheckedState.Parent = this.btnDetail;
            this.btnDetail.CustomImages.Parent = this.btnDetail;
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.Parent = this.btnDetail;
            this.btnDetail.Location = new System.Drawing.Point(1275, 246);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ShadowDecoration.Parent = this.btnDetail;
            this.btnDetail.Size = new System.Drawing.Size(141, 68);
            this.btnDetail.TabIndex = 11;
            this.btnDetail.Text = "Chi tiết";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(1275, 93);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(141, 73);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(1275, 170);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(141, 72);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.99681F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.00319F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 514F));
            this.tableLayoutPanel1.Controls.Add(this.picturePoster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDetail, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthorName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblViewNumber, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCateName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDatePost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.3956F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.6044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1419, 418);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // picturePoster
            // 
            this.picturePoster.BorderRadius = 14;
            this.picturePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePoster.Image = global::PTUDTM.Properties.Resources.mat_biec_bia_cung_2019;
            this.picturePoster.Location = new System.Drawing.Point(20, 20);
            this.picturePoster.Margin = new System.Windows.Forms.Padding(20, 20, 3, 2);
            this.picturePoster.Name = "picturePoster";
            this.tableLayoutPanel1.SetRowSpan(this.picturePoster, 5);
            this.picturePoster.ShadowDecoration.Parent = this.picturePoster;
            this.picturePoster.Size = new System.Drawing.Size(285, 360);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePoster.TabIndex = 0;
            this.picturePoster.TabStop = false;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookList";
            this.Size = new System.Drawing.Size(1419, 418);
            this.Load += new System.EventHandler(this.BookList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picturePoster;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAuthor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAuthorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCateName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDatePost;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblView;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblViewNumber;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
