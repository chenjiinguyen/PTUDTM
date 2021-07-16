namespace PTUDTM.component
{
    partial class UserList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.circulaImageBox1 = new PTUDTM.component.CirculaImageBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.circulaImageBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Location = new System.Drawing.Point(3, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 1);
            this.panel1.TabIndex = 0;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(115, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(332, 75);
            this.lblNameUser.TabIndex = 2;
            this.lblNameUser.Text = "Diệp Hạ Nhi";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRule.Location = new System.Drawing.Point(115, 75);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(332, 37);
            this.lblRule.TabIndex = 3;
            this.lblRule.Text = "Member";
            // 
            // circulaImageBox1
            // 
            this.circulaImageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circulaImageBox1.Image = global::PTUDTM.Properties.Resources._51376355_554018558417057_2054804331131043840_n;
            this.circulaImageBox1.Location = new System.Drawing.Point(3, 3);
            this.circulaImageBox1.Name = "circulaImageBox1";
            this.tableLayoutPanel1.SetRowSpan(this.circulaImageBox1, 2);
            this.circulaImageBox1.Size = new System.Drawing.Size(106, 106);
            this.circulaImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circulaImageBox1.TabIndex = 4;
            this.circulaImageBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblRule, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNameUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.circulaImageBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 150);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(450, 150);
            ((System.ComponentModel.ISupportInitialize)(this.circulaImageBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblRule;
        private CirculaImageBox circulaImageBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
