
namespace Tyuiu.ShtolVA.Sprint7.Project.V2
{
    partial class FormCharts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharts));
            this.panelButton_SVA = new System.Windows.Forms.Panel();
            this.buttonAddition_SVA = new System.Windows.Forms.Button();
            this.buttonDelete_SVA = new System.Windows.Forms.Button();
            this.buttonBuildGraf_SVA = new System.Windows.Forms.Button();
            this.buttonDeletGraf_SVA = new System.Windows.Forms.Button();
            this.panelGraf_SVA = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOpenFile_SVA = new System.Windows.Forms.Button();
            this.panelButton_SVA.SuspendLayout();
            this.panelGraf_SVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton_SVA
            // 
            this.panelButton_SVA.BackColor = System.Drawing.Color.MistyRose;
            this.panelButton_SVA.Controls.Add(this.buttonAddition_SVA);
            this.panelButton_SVA.Controls.Add(this.buttonDelete_SVA);
            this.panelButton_SVA.Controls.Add(this.buttonBuildGraf_SVA);
            this.panelButton_SVA.Controls.Add(this.buttonDeletGraf_SVA);
            this.panelButton_SVA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton_SVA.Location = new System.Drawing.Point(0, 509);
            this.panelButton_SVA.Name = "panelButton_SVA";
            this.panelButton_SVA.Size = new System.Drawing.Size(1103, 143);
            this.panelButton_SVA.TabIndex = 2;
            // 
            // buttonAddition_SVA
            // 
            this.buttonAddition_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddition_SVA.Location = new System.Drawing.Point(31, 90);
            this.buttonAddition_SVA.Name = "buttonAddition_SVA";
            this.buttonAddition_SVA.Size = new System.Drawing.Size(144, 32);
            this.buttonAddition_SVA.TabIndex = 3;
            this.buttonAddition_SVA.Text = "Добавить";
            this.buttonAddition_SVA.UseVisualStyleBackColor = true;
            this.buttonAddition_SVA.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete_SVA
            // 
            this.buttonDelete_SVA.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonDelete_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete_SVA.Location = new System.Drawing.Point(31, 36);
            this.buttonDelete_SVA.Name = "buttonDelete_SVA";
            this.buttonDelete_SVA.Size = new System.Drawing.Size(144, 32);
            this.buttonDelete_SVA.TabIndex = 2;
            this.buttonDelete_SVA.Text = "Удалить";
            this.buttonDelete_SVA.UseVisualStyleBackColor = false;
            // 
            // buttonBuildGraf_SVA
            // 
            this.buttonBuildGraf_SVA.BackColor = System.Drawing.Color.Snow;
            this.buttonBuildGraf_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuildGraf_SVA.Location = new System.Drawing.Point(900, 90);
            this.buttonBuildGraf_SVA.Name = "buttonBuildGraf_SVA";
            this.buttonBuildGraf_SVA.Size = new System.Drawing.Size(166, 32);
            this.buttonBuildGraf_SVA.TabIndex = 1;
            this.buttonBuildGraf_SVA.Text = "Построить график";
            this.buttonBuildGraf_SVA.UseVisualStyleBackColor = false;
            // 
            // buttonDeletGraf_SVA
            // 
            this.buttonDeletGraf_SVA.BackColor = System.Drawing.Color.Snow;
            this.buttonDeletGraf_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletGraf_SVA.Location = new System.Drawing.Point(900, 36);
            this.buttonDeletGraf_SVA.Name = "buttonDeletGraf_SVA";
            this.buttonDeletGraf_SVA.Size = new System.Drawing.Size(166, 32);
            this.buttonDeletGraf_SVA.TabIndex = 0;
            this.buttonDeletGraf_SVA.Text = "Удалить график";
            this.buttonDeletGraf_SVA.UseVisualStyleBackColor = false;
            // 
            // panelGraf_SVA
            // 
            this.panelGraf_SVA.BackColor = System.Drawing.Color.RosyBrown;
            this.panelGraf_SVA.Controls.Add(this.button2);
            this.panelGraf_SVA.Controls.Add(this.buttonOpenFile_SVA);
            this.panelGraf_SVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraf_SVA.Location = new System.Drawing.Point(0, 0);
            this.panelGraf_SVA.Name = "panelGraf_SVA";
            this.panelGraf_SVA.Size = new System.Drawing.Size(1103, 509);
            this.panelGraf_SVA.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(148, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_SVA
            // 
            this.buttonOpenFile_SVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SVA.Image")));
            this.buttonOpenFile_SVA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SVA.Name = "buttonOpenFile_SVA";
            this.buttonOpenFile_SVA.Size = new System.Drawing.Size(112, 49);
            this.buttonOpenFile_SVA.TabIndex = 0;
            this.buttonOpenFile_SVA.UseVisualStyleBackColor = true;
            // 
            // FormCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 652);
            this.Controls.Add(this.panelGraf_SVA);
            this.Controls.Add(this.panelButton_SVA);
            this.MaximumSize = new System.Drawing.Size(1121, 699);
            this.MinimumSize = new System.Drawing.Size(1121, 699);
            this.Name = "FormCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            this.Load += new System.EventHandler(this.FormCharts_Load);
            this.panelButton_SVA.ResumeLayout(false);
            this.panelGraf_SVA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButton_SVA;
        private System.Windows.Forms.Panel panelGraf_SVA;
        private System.Windows.Forms.Button buttonAddition_SVA;
        private System.Windows.Forms.Button buttonDelete_SVA;
        private System.Windows.Forms.Button buttonBuildGraf_SVA;
        private System.Windows.Forms.Button buttonDeletGraf_SVA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOpenFile_SVA;
    }
}