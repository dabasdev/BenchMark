namespace BenchMark
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNet = new System.Windows.Forms.TextBox();
            this.TxtCore = new System.Windows.Forms.TextBox();
            this.BtnNet = new System.Windows.Forms.Button();
            this.BtnCore = new System.Windows.Forms.Button();
            this.lblCountNet = new System.Windows.Forms.Label();
            this.lblCountCore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dal .Net FrameWork:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dal .Core FrameWork:";
            // 
            // TxtNet
            // 
            this.TxtNet.BackColor = System.Drawing.Color.DarkSalmon;
            this.TxtNet.Location = new System.Drawing.Point(241, 21);
            this.TxtNet.Name = "TxtNet";
            this.TxtNet.ReadOnly = true;
            this.TxtNet.Size = new System.Drawing.Size(397, 29);
            this.TxtNet.TabIndex = 2;
            this.TxtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCore
            // 
            this.TxtCore.BackColor = System.Drawing.Color.DarkSalmon;
            this.TxtCore.Location = new System.Drawing.Point(246, 149);
            this.TxtCore.Name = "TxtCore";
            this.TxtCore.ReadOnly = true;
            this.TxtCore.Size = new System.Drawing.Size(397, 29);
            this.TxtCore.TabIndex = 3;
            this.TxtCore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNet
            // 
            this.BtnNet.Location = new System.Drawing.Point(663, 23);
            this.BtnNet.Name = "BtnNet";
            this.BtnNet.Size = new System.Drawing.Size(152, 29);
            this.BtnNet.TabIndex = 4;
            this.BtnNet.Text = ".Net Framework Load";
            this.BtnNet.UseVisualStyleBackColor = true;
            this.BtnNet.Click += new System.EventHandler(this.BtnNet_Click);
            // 
            // BtnCore
            // 
            this.BtnCore.Location = new System.Drawing.Point(663, 149);
            this.BtnCore.Name = "BtnCore";
            this.BtnCore.Size = new System.Drawing.Size(152, 29);
            this.BtnCore.TabIndex = 5;
            this.BtnCore.Text = ".Net Core Load";
            this.BtnCore.UseVisualStyleBackColor = true;
            this.BtnCore.Click += new System.EventHandler(this.BtnCore_Click);
            // 
            // lblCountNet
            // 
            this.lblCountNet.AutoSize = true;
            this.lblCountNet.Location = new System.Drawing.Point(241, 66);
            this.lblCountNet.Name = "lblCountNet";
            this.lblCountNet.Size = new System.Drawing.Size(53, 21);
            this.lblCountNet.TabIndex = 6;
            this.lblCountNet.Text = "label3";
            // 
            // lblCountCore
            // 
            this.lblCountCore.AutoSize = true;
            this.lblCountCore.Location = new System.Drawing.Point(242, 210);
            this.lblCountCore.Name = "lblCountCore";
            this.lblCountCore.Size = new System.Drawing.Size(53, 21);
            this.lblCountCore.TabIndex = 7;
            this.lblCountCore.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 326);
            this.Controls.Add(this.lblCountCore);
            this.Controls.Add(this.lblCountNet);
            this.Controls.Add(this.BtnCore);
            this.Controls.Add(this.BtnNet);
            this.Controls.Add(this.TxtCore);
            this.Controls.Add(this.TxtNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNet;
        private System.Windows.Forms.TextBox TxtCore;
        private System.Windows.Forms.Button BtnNet;
        private System.Windows.Forms.Button BtnCore;
        private System.Windows.Forms.Label lblCountNet;
        private System.Windows.Forms.Label lblCountCore;
    }
}

