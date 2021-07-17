namespace PTUDTM
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookList2 = new PTUDTM.component.BookList();
            this.bookList1 = new PTUDTM.component.BookList();
            this.guna2GradientPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnStatistic);
            this.guna2GradientPanel1.Controls.Add(this.btnAdd);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1, 5);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1481, 107);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(82, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(137, 66);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            // 
            // btnStatistic
            // 
            this.btnStatistic.BorderRadius = 5;
            this.btnStatistic.CheckedState.Parent = this.btnStatistic;
            this.btnStatistic.CustomImages.Parent = this.btnStatistic;
            this.btnStatistic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.HoverState.Parent = this.btnStatistic;
            this.btnStatistic.Location = new System.Drawing.Point(1274, 19);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.ShadowDecoration.Parent = this.btnStatistic;
            this.btnStatistic.Size = new System.Drawing.Size(137, 66);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.Text = "Thống kê";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bookList2);
            this.flowLayoutPanel1.Controls.Add(this.bookList1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1481, 835);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bookList2
            // 
            this.bookList2.Author = "Tác giả:";
            this.bookList2.AuthorName = "Nguyễn Nhật Ánh";
            this.bookList2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookList2.Category = "Thể loại:";
            this.bookList2.CategoryName = "Truyện chữ";
            this.bookList2.DatePost = "Ngày đăng:";
            this.bookList2.Location = new System.Drawing.Point(3, 3);
            this.bookList2.Name = "bookList2";
            this.bookList2.Poster = ((System.Drawing.Image)(resources.GetObject("bookList2.Poster")));
            this.bookList2.Size = new System.Drawing.Size(1419, 417);
            this.bookList2.TabIndex = 1;
            this.bookList2.Time = "16/07/2021";
            this.bookList2.Title = "MẮT BIẾC\r\n";
            this.bookList2.View = "Lượt xem:";
            this.bookList2.ViewNumber = "100";
            // 
            // bookList1
            // 
            this.bookList1.Author = "Tác giả:";
            this.bookList1.AuthorName = "Nguyễn Nhật Ánh";
            this.bookList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookList1.Category = "Thể loại:";
            this.bookList1.CategoryName = "Truyện chữ";
            this.bookList1.DatePost = "Ngày đăng:";
            this.bookList1.Location = new System.Drawing.Point(3, 426);
            this.bookList1.Name = "bookList1";
            this.bookList1.Poster = ((System.Drawing.Image)(resources.GetObject("bookList1.Poster")));
            this.bookList1.Size = new System.Drawing.Size(1419, 417);
            this.bookList1.TabIndex = 2;
            this.bookList1.Time = "16/07/2021";
            this.bookList1.Title = "MẮT BIẾC\r\n";
            this.bookList1.View = "Lượt xem:";
            this.bookList1.ViewNumber = "100";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 965);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnStatistic;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private component.BookList bookList2;
        private component.BookList bookList1;
    }
}