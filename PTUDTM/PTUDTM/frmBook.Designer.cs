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
            this.pnlButton = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.flowPnlBooklist = new System.Windows.Forms.FlowLayoutPanel();
            this.bookList2 = new PTUDTM.component.BookList();
            this.bookList1 = new PTUDTM.component.BookList();
            this.pnlButton.SuspendLayout();
            this.flowPnlBooklist.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnStatistic);
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Location = new System.Drawing.Point(1, 5);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.ShadowDecoration.Parent = this.pnlButton;
            this.pnlButton.Size = new System.Drawing.Size(1481, 107);
            this.pnlButton.TabIndex = 0;
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
            this.btnStatistic.Location = new System.Drawing.Point(256, 19);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.ShadowDecoration.Parent = this.btnStatistic;
            this.btnStatistic.Size = new System.Drawing.Size(137, 66);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.Text = "Thống kê";
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
            // flowPnlBooklist
            // 
            this.flowPnlBooklist.AutoScroll = true;
            this.flowPnlBooklist.Controls.Add(this.bookList2);
            this.flowPnlBooklist.Controls.Add(this.bookList1);
            this.flowPnlBooklist.Location = new System.Drawing.Point(1, 118);
            this.flowPnlBooklist.Name = "flowPnlBooklist";
            this.flowPnlBooklist.Size = new System.Drawing.Size(1481, 835);
            this.flowPnlBooklist.TabIndex = 1;
            // 
            // bookList2
            // 
            this.bookList2.Author = "Tác giả:";
            this.bookList2.AuthorName = "Nguyễn Nhật Ánh";
            this.bookList2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookList2.Category = "Thể loại:";
            this.bookList2.CategoryName = "Truyện chữ";
            this.bookList2.DatePost = "Ngày đăng:";
            this.bookList2.Location = new System.Drawing.Point(3, 2);
            this.bookList2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.bookList1.Location = new System.Drawing.Point(3, 423);
            this.bookList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Controls.Add(this.flowPnlBooklist);
            this.Controls.Add(this.pnlButton);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.Shown += new System.EventHandler(this.frmBook_Shown);
            this.pnlButton.ResumeLayout(false);
            this.flowPnlBooklist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlButton;
        private Guna.UI2.WinForms.Guna2Button btnStatistic;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowPnlBooklist;
        private component.BookList bookList2;
        private component.BookList bookList1;
    }
}