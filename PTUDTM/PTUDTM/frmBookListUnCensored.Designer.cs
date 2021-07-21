namespace PTUDTM
{
    partial class frmBookListUnCensored
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookListUncensored1 = new PTUDTM.component.BookListUncensored();
            this.bookListUncensored2 = new PTUDTM.component.BookListUncensored();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 44);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(624, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "DANH SÁCH SÁCH CHƯA KIỂM DUYỆT";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bookListUncensored1);
            this.flowLayoutPanel1.Controls.Add(this.bookListUncensored2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1578, 793);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bookListUncensored1
            // 
            this.bookListUncensored1.Location = new System.Drawing.Point(3, 3);
            this.bookListUncensored1.Name = "bookListUncensored1";
            this.bookListUncensored1.Size = new System.Drawing.Size(1457, 417);
            this.bookListUncensored1.TabIndex = 0;
            // 
            // bookListUncensored2
            // 
            this.bookListUncensored2.Location = new System.Drawing.Point(3, 426);
            this.bookListUncensored2.Name = "bookListUncensored2";
            this.bookListUncensored2.Size = new System.Drawing.Size(1457, 417);
            this.bookListUncensored2.TabIndex = 1;
            // 
            // frmCensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 899);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "frmCensor";
            this.Text = "frmCensor";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private component.BookListUncensored bookListUncensored1;
        private component.BookListUncensored bookListUncensored2;


    }
}