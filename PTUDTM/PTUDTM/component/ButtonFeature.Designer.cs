namespace PTUDTM.component
{
    partial class ButtonFeature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonFeature));
            this.btnFeature = new Guna.UI2.WinForms.Guna2Button();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFeature
            // 
            this.btnFeature.BorderRadius = 5;
            this.btnFeature.CheckedState.Parent = this.btnFeature;
            this.btnFeature.CustomImages.Parent = this.btnFeature;
            this.btnFeature.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeature.ForeColor = System.Drawing.Color.White;
            this.btnFeature.HoverState.Parent = this.btnFeature;
            this.btnFeature.Location = new System.Drawing.Point(82, 5);
            this.btnFeature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeature.Name = "btnFeature";
            this.btnFeature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFeature.ShadowDecoration.Parent = this.btnFeature;
            this.btnFeature.Size = new System.Drawing.Size(210, 70);
            this.btnFeature.TabIndex = 0;
            this.btnFeature.Text = "Home";
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(4, 5);
            this.image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(70, 70);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 5;
            this.image.TabStop = false;
            // 
            // ButtonFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnFeature);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ButtonFeature";
            this.Size = new System.Drawing.Size(300, 80);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        public Guna.UI2.WinForms.Guna2Button btnFeature;
    }
}
