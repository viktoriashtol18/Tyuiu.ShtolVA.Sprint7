
namespace Tyuiu.ShtolVA.Sprint7.Project.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonОк_SVA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SVA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SVA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Location = new System.Drawing.Point(193, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(341, 174);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonОк_SVA
            // 
            this.buttonОк_SVA.AutoSize = true;
            this.buttonОк_SVA.Location = new System.Drawing.Point(449, 213);
            this.buttonОк_SVA.MaximumSize = new System.Drawing.Size(85, 27);
            this.buttonОк_SVA.MinimumSize = new System.Drawing.Size(85, 27);
            this.buttonОк_SVA.Name = "buttonОк_SVA";
            this.buttonОк_SVA.Size = new System.Drawing.Size(85, 27);
            this.buttonОк_SVA.TabIndex = 1;
            this.buttonОк_SVA.Text = "Ок";
            this.buttonОк_SVA.UseVisualStyleBackColor = true;
            this.buttonОк_SVA.Click += new System.EventHandler(this.buttonОк_SVA_Click);
            // 
            // pictureBoxAvatar_SVA
            // 
            this.pictureBoxAvatar_SVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SVA.Image")));
            this.pictureBoxAvatar_SVA.Location = new System.Drawing.Point(12, 21);
            this.pictureBoxAvatar_SVA.Name = "pictureBoxAvatar_SVA";
            this.pictureBoxAvatar_SVA.Size = new System.Drawing.Size(175, 206);
            this.pictureBoxAvatar_SVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SVA.TabIndex = 2;
            this.pictureBoxAvatar_SVA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(559, 250);
            this.Controls.Add(this.pictureBoxAvatar_SVA);
            this.Controls.Add(this.buttonОк_SVA);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(577, 297);
            this.MinimumSize = new System.Drawing.Size(577, 297);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonОк_SVA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SVA;
    }
}