namespace PTUDTM
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlNumber = new System.Windows.Forms.Panel();
            this.widgetNumber4 = new PTUDTM.component.WidgetNumber();
            this.widgetNumber3 = new PTUDTM.component.WidgetNumber();
            this.widgetNumber2 = new PTUDTM.component.WidgetNumber();
            this.widgetNumber1 = new PTUDTM.component.WidgetNumber();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userList1 = new PTUDTM.component.UserList();
            this.userList2 = new PTUDTM.component.UserList();
            this.userList3 = new PTUDTM.component.UserList();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStory = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.storyList1 = new PTUDTM.component.StoryList();
            this.storyList2 = new PTUDTM.component.StoryList();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNumber.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlStory.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNumber
            // 
            this.pnlNumber.Controls.Add(this.widgetNumber4);
            this.pnlNumber.Controls.Add(this.widgetNumber3);
            this.pnlNumber.Controls.Add(this.widgetNumber2);
            this.pnlNumber.Controls.Add(this.widgetNumber1);
            this.pnlNumber.Location = new System.Drawing.Point(1, 2);
            this.pnlNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNumber.Name = "pnlNumber";
            this.pnlNumber.Size = new System.Drawing.Size(1136, 137);
            this.pnlNumber.TabIndex = 0;
            // 
            // widgetNumber4
            // 
            this.widgetNumber4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.widgetNumber4.Location = new System.Drawing.Point(860, 17);
            this.widgetNumber4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widgetNumber4.Name = "widgetNumber4";
            this.widgetNumber4.Number = "0";
            this.widgetNumber4.Size = new System.Drawing.Size(258, 105);
            this.widgetNumber4.TabIndex = 3;
            this.widgetNumber4.Title = "Tổng thành viên";
            // 
            // widgetNumber3
            // 
            this.widgetNumber3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.widgetNumber3.Location = new System.Drawing.Point(583, 17);
            this.widgetNumber3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widgetNumber3.Name = "widgetNumber3";
            this.widgetNumber3.Number = "0";
            this.widgetNumber3.Size = new System.Drawing.Size(258, 105);
            this.widgetNumber3.TabIndex = 2;
            this.widgetNumber3.Title = "Tổng lượt xem";
            // 
            // widgetNumber2
            // 
            this.widgetNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.widgetNumber2.Location = new System.Drawing.Point(301, 17);
            this.widgetNumber2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widgetNumber2.Name = "widgetNumber2";
            this.widgetNumber2.Number = "0";
            this.widgetNumber2.Size = new System.Drawing.Size(258, 105);
            this.widgetNumber2.TabIndex = 1;
            this.widgetNumber2.Title = "Sách chưa kiểm duyệt";
            // 
            // widgetNumber1
            // 
            this.widgetNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.widgetNumber1.Location = new System.Drawing.Point(20, 17);
            this.widgetNumber1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widgetNumber1.Name = "widgetNumber1";
            this.widgetNumber1.Number = "35";
            this.widgetNumber1.Size = new System.Drawing.Size(258, 105);
            this.widgetNumber1.TabIndex = 0;
            this.widgetNumber1.Title = "Tổng số sách ";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.flowLayoutPanel1);
            this.pnlUser.Controls.Add(this.label1);
            this.pnlUser.Location = new System.Drawing.Point(1, 143);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(422, 684);
            this.pnlUser.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userList1);
            this.flowLayoutPanel1.Controls.Add(this.userList2);
            this.flowLayoutPanel1.Controls.Add(this.userList3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 78);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 604);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // userList1
            // 
            this.userList1.Avatar = global::PTUDTM.Properties.Resources._51376355_554018558417057_2054804331131043840_n;
            this.userList1.Location = new System.Drawing.Point(2, 2);
            this.userList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userList1.Name = "userList1";
            this.userList1.NameUser = "Diệp Hạ Nhi";
            this.userList1.Role = "Member";
            this.userList1.Size = new System.Drawing.Size(338, 120);
            this.userList1.TabIndex = 0;
            // 
            // userList2
            // 
            this.userList2.Avatar = ((System.Drawing.Image)(resources.GetObject("userList2.Avatar")));
            this.userList2.Location = new System.Drawing.Point(2, 126);
            this.userList2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userList2.Name = "userList2";
            this.userList2.NameUser = "Diệp Hạ Nhi";
            this.userList2.Role = "Member";
            this.userList2.Size = new System.Drawing.Size(338, 120);
            this.userList2.TabIndex = 1;
            // 
            // userList3
            // 
            this.userList3.Avatar = ((System.Drawing.Image)(resources.GetObject("userList3.Avatar")));
            this.userList3.Location = new System.Drawing.Point(2, 250);
            this.userList3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userList3.Name = "userList3";
            this.userList3.NameUser = "Duy khùng";
            this.userList3.Role = "Member";
            this.userList3.Size = new System.Drawing.Size(338, 120);
            this.userList3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách người dùng";
            // 
            // pnlStory
            // 
            this.pnlStory.AutoScroll = true;
            this.pnlStory.Controls.Add(this.flowLayoutPanel2);
            this.pnlStory.Controls.Add(this.label2);
            this.pnlStory.Location = new System.Drawing.Point(428, 143);
            this.pnlStory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlStory.Name = "pnlStory";
            this.pnlStory.Size = new System.Drawing.Size(709, 684);
            this.pnlStory.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.storyList1);
            this.flowLayoutPanel2.Controls.Add(this.storyList2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 78);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(682, 606);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // storyList1
            // 
            this.storyList1.Author = "Tác giả:";
            this.storyList1.AuthorName = "Nguyễn Nhật Ánh";
            this.storyList1.Category = "Thể loại:";
            this.storyList1.CategoryName = "Truyện chữ";
            this.storyList1.DatePost = "Ngày đăng:";
            this.storyList1.Location = new System.Drawing.Point(2, 2);
            this.storyList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyList1.Name = "storyList1";
            this.storyList1.Poster = ((System.Drawing.Image)(resources.GetObject("storyList1.Poster")));
            this.storyList1.Size = new System.Drawing.Size(651, 310);
            this.storyList1.TabIndex = 0;
            this.storyList1.Time = "16/07/2021";
            this.storyList1.Title = "MẮT BIẾC";
            this.storyList1.View = "Lượt xem:";
            this.storyList1.ViewNumber = "100";
            // 
            // storyList2
            // 
            this.storyList2.Author = "Tác giả:";
            this.storyList2.AuthorName = "Nguyễn Nhật Ánh";
            this.storyList2.Category = "Thể loại:";
            this.storyList2.CategoryName = "Truyện chữ";
            this.storyList2.DatePost = "Ngày đăng:";
            this.storyList2.Location = new System.Drawing.Point(2, 316);
            this.storyList2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyList2.Name = "storyList2";
            this.storyList2.Poster = ((System.Drawing.Image)(resources.GetObject("storyList2.Poster")));
            this.storyList2.Size = new System.Drawing.Size(651, 310);
            this.storyList2.TabIndex = 1;
            this.storyList2.Time = "16/07/2021";
            this.storyList2.Title = "MẮT BIẾC";
            this.storyList2.View = "Lượt xem:";
            this.storyList2.ViewNumber = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách truyện mới nhất";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 830);
            this.Controls.Add(this.pnlStory);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.pnlNumber.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlStory.ResumeLayout(false);
            this.pnlStory.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNumber;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlStory;
        private component.WidgetNumber widgetNumber1;
        private component.WidgetNumber widgetNumber4;
        private component.WidgetNumber widgetNumber3;
        private component.WidgetNumber widgetNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private component.UserList userList1;
        private component.UserList userList2;
        private component.UserList userList3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private component.StoryList storyList1;
        private component.StoryList storyList2;
    }
}