using System.ComponentModel;
using System.Drawing;
namespace PTUDTM.component
{
    partial class UserInfoDetail
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

        [Description("Picture Avatar"), Category("Custom")]
        public Image Avatar
        {
            get { return pictureAvt.Image; }
            set { pictureAvt.Image = value; }
        }

        [Description("Text in Name"), Category("Custom")]
        public string Title
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        [Description("Text in Role"), Category("Custom")]
        public string Role
        {
            get { return lblRole.Text; }
            set { lblRole.Text = value; }
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBirth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 7);
            this.panel1.Location = new System.Drawing.Point(3, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 1);
            this.panel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.56189F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.43811F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Controls.Add(this.pictureAvt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRole, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBirth, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblGender, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMail, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 6, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.59761F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.40239F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1590, 296);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.lblName, 3);
            this.lblName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(246, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 39);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Diệp Hạ Nhi";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(246, 153);
            this.lblRole.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(101, 33);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Member\r\n";
            this.lblRole.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirth
            // 
            this.lblBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(510, 143);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(124, 33);
            this.lblBirth.TabIndex = 21;
            this.lblBirth.Text = "07/11/200";
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(694, 143);
            this.lblGender.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(38, 33);
            this.lblGender.TabIndex = 22;
            this.lblGender.Text = "Nữ";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(871, 143);
            this.lblMail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(272, 33);
            this.lblMail.TabIndex = 23;
            this.lblMail.Text = "nhuquynh@gmail.com";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(1329, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(127, 77);
            this.btnDelete.TabIndex = 17;
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
            this.btnEdit.Location = new System.Drawing.Point(1462, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(123, 77);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sửa";
            // 
            // pictureAvt
            // 
            this.pictureAvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAvt.Location = new System.Drawing.Point(10, 3);
            this.pictureAvt.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureAvt.Name = "pictureAvt";
            this.tableLayoutPanel2.SetRowSpan(this.pictureAvt, 2);
            this.pictureAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureAvt.ShadowDecoration.Parent = this.pictureAvt;
            this.pictureAvt.Size = new System.Drawing.Size(223, 257);
            this.pictureAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvt.TabIndex = 0;
            this.pictureAvt.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(10, 3);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(224, 257);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UserInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UserInfoDetail";
            this.Size = new System.Drawing.Size(1590, 296);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureAvt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBirth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMail;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
