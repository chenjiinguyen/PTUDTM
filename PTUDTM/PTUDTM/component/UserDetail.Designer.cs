
using System.ComponentModel;
using System.Drawing;

namespace PTUDTM.component
{
    partial class UserDetail
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
            get { return picterposter.Image; }
            set { picterposter.Image = value; }
        }

        [Description("Text in Name"), Category("Custom")]
        public string NameTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        [Description("Text in Role"), Category("Custom")]
        public string Role
        {
            get { return lblRoleName.Text; }
            set { lblRoleName.Text = value; }
        }

        [Description("Text in Birthday"), Category("Custom")]
        public string Birthday
        {
            get { return lblBirth.Text; }
            set { lblBirth.Text = value; }
        }

        [Description("Text in Gender"), Category("Custom")]
        public string Gender
        {
            get { return lblGender.Text; }
            set { lblGender.Text = value; }
        }

        [Description("Text in Email"), Category("Custom")]
        public string Email
        {
            get { return lblMail.Text; }
            set { lblMail.Text = value; }
        }



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAuthor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRoleName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBirth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblView = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDatePost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picterposter = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picterposter)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.85662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.14338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 529F));
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRoleName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMail, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBirth, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDatePost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGender, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.picterposter, 0, 0);
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
            this.tableLayoutPanel1.TabIndex = 15;
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
            this.btnEdit.Location = new System.Drawing.Point(1275, 170);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(141, 72);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(361, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(20, 30, 3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1055, 59);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "NGUYỄN DUY";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(361, 93);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(135, 73);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Vai trò:";
            this.lblAuthor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(502, 93);
            this.lblRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(384, 73);
            this.lblRoleName.TabIndex = 3;
            this.lblRoleName.Text = "Admin";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(361, 170);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(135, 72);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Ngày sinh:";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(502, 318);
            this.lblMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(384, 62);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "nhuquynh@gmail.com";
            // 
            // lblBirth
            // 
            this.lblBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(502, 170);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(384, 72);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "20/10/2000";
            // 
            // lblView
            // 
            this.lblView.BackColor = System.Drawing.Color.Transparent;
            this.lblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(361, 318);
            this.lblView.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(135, 62);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "Email:";
            // 
            // lblDatePost
            // 
            this.lblDatePost.BackColor = System.Drawing.Color.Transparent;
            this.lblDatePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(361, 246);
            this.lblDatePost.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(135, 68);
            this.lblDatePost.TabIndex = 6;
            this.lblDatePost.Text = "Giới tính:";
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(502, 246);
            this.lblGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(384, 68);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Nữ";
            // 
            // picterposter
            // 
            this.picterposter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picterposter.Image = global::PTUDTM.Properties.Resources.Screenshot_2021_07_22_145349;
            this.picterposter.Location = new System.Drawing.Point(3, 3);
            this.picterposter.Name = "picterposter";
            this.tableLayoutPanel1.SetRowSpan(this.picterposter, 5);
            this.picterposter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picterposter.ShadowDecoration.Parent = this.picterposter;
            this.picterposter.Size = new System.Drawing.Size(335, 376);
            this.picterposter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picterposter.TabIndex = 14;
            this.picterposter.TabStop = false;
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserDetail";
            this.Size = new System.Drawing.Size(1419, 418);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picterposter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAuthor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoleName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBirth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblView;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDatePost;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGender;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picterposter;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}
