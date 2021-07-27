
namespace PTUDTM.form
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.charUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartBook = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.wnMembers = new PTUDTM.component.WidgetNumber();
            this.wnView = new PTUDTM.component.WidgetNumber();
            this.wnCensorBook = new PTUDTM.component.WidgetNumber();
            this.wnTongSach = new PTUDTM.component.WidgetNumber();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1202, 891);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.charUser);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(604, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 735);
            this.panel4.TabIndex = 5;
            // 
            // charUser
            // 
            this.charUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charUser.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.charUser.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charUser.Legends.Add(legend1);
            this.charUser.Location = new System.Drawing.Point(83, 96);
            this.charUser.Name = "charUser";
            this.charUser.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charUser.Series.Add(series1);
            this.charUser.Size = new System.Drawing.Size(487, 578);
            this.charUser.TabIndex = 2;
            this.charUser.Text = "chart1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Sách Đăng Trong 7 Ngày";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.wnMembers);
            this.panel1.Controls.Add(this.wnView);
            this.panel1.Controls.Add(this.wnCensorBook);
            this.panel1.Controls.Add(this.wnTongSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 146);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartBook);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 735);
            this.panel2.TabIndex = 4;
            // 
            // chartBook
            // 
            this.chartBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBook.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.chartBook.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBook.Legends.Add(legend2);
            this.chartBook.Location = new System.Drawing.Point(69, 109);
            this.chartBook.Name = "chartBook";
            this.chartBook.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBook.Series.Add(series2);
            this.chartBook.Size = new System.Drawing.Size(487, 578);
            this.chartBook.TabIndex = 0;
            this.chartBook.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phân Bố Thể Loại Sách";
            // 
            // wnMembers
            // 
            this.wnMembers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wnMembers.Location = new System.Drawing.Point(617, 19);
            this.wnMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wnMembers.Name = "wnMembers";
            this.wnMembers.Number = "0";
            this.wnMembers.Size = new System.Drawing.Size(239, 92);
            this.wnMembers.TabIndex = 3;
            this.wnMembers.Title = "Tổng thành viên";
            // 
            // wnView
            // 
            this.wnView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wnView.Location = new System.Drawing.Point(886, 19);
            this.wnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wnView.Name = "wnView";
            this.wnView.Number = "0";
            this.wnView.Size = new System.Drawing.Size(239, 92);
            this.wnView.TabIndex = 2;
            this.wnView.Title = "Tổng lượt xem";
            this.wnView.Load += new System.EventHandler(this.wnView_Load);
            // 
            // wnCensorBook
            // 
            this.wnCensorBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wnCensorBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wnCensorBook.Location = new System.Drawing.Point(341, 19);
            this.wnCensorBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wnCensorBook.Name = "wnCensorBook";
            this.wnCensorBook.Number = "0";
            this.wnCensorBook.Size = new System.Drawing.Size(239, 92);
            this.wnCensorBook.TabIndex = 1;
            this.wnCensorBook.Title = "Sách chưa kiểm duyệt";
            // 
            // wnTongSach
            // 
            this.wnTongSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wnTongSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wnTongSach.Location = new System.Drawing.Point(77, 19);
            this.wnTongSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wnTongSach.Name = "wnTongSach";
            this.wnTongSach.Number = "0";
            this.wnTongSach.Size = new System.Drawing.Size(239, 92);
            this.wnTongSach.TabIndex = 0;
            this.wnTongSach.Title = "Tổng số sách ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1288, 989);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private component.WidgetNumber wnMembers;
        private component.WidgetNumber wnView;
        private component.WidgetNumber wnCensorBook;
        private component.WidgetNumber wnTongSach;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart charUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}
