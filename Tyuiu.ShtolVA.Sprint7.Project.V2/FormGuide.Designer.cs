
namespace Tyuiu.ShtolVA.Sprint7.Project.V2
{
    partial class FormGuide
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
            this.textBoxQuickGuide_SVA = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOk_SVA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuickGuide_SVA
            // 
            this.textBoxQuickGuide_SVA.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxQuickGuide_SVA.Location = new System.Drawing.Point(12, 21);
            this.textBoxQuickGuide_SVA.Multiline = true;
            this.textBoxQuickGuide_SVA.Name = "textBoxQuickGuide_SVA";
            this.textBoxQuickGuide_SVA.ReadOnly = true;
            this.textBoxQuickGuide_SVA.Size = new System.Drawing.Size(265, 29);
            this.textBoxQuickGuide_SVA.TabIndex = 0;
            this.textBoxQuickGuide_SVA.Text = "Руководство пользователя";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox1.Location = new System.Drawing.Point(13, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 112);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1) введение\r\n2)назначение и условие применения\r\n3)подготовка к работе\r\n4)описание" +
    " операций\r\n5)аварийные ситуации\r\n6) рекоминдации по освоению\r\n\r\n";
            // 
            // buttonOk_SVA
            // 
            this.buttonOk_SVA.BackColor = System.Drawing.Color.Snow;
            this.buttonOk_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk_SVA.Location = new System.Drawing.Point(387, 212);
            this.buttonOk_SVA.Name = "buttonOk_SVA";
            this.buttonOk_SVA.Size = new System.Drawing.Size(123, 29);
            this.buttonOk_SVA.TabIndex = 2;
            this.buttonOk_SVA.Text = "Ок";
            this.buttonOk_SVA.UseVisualStyleBackColor = false;
            this.buttonOk_SVA.Click += new System.EventHandler(this.buttonOk_SVA_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(522, 253);
            this.Controls.Add(this.buttonOk_SVA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxQuickGuide_SVA);
            this.MaximumSize = new System.Drawing.Size(540, 300);
            this.MinimumSize = new System.Drawing.Size(540, 300);
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuickGuide_SVA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOk_SVA;
    }
}