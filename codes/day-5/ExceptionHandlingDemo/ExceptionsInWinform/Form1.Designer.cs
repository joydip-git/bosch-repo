
namespace ExceptionsInWinform
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.richTxtErrors = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(103, 59);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(83, 17);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Value: ";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(223, 53);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(215, 22);
            this.txtFirst.TabIndex = 1;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(223, 99);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(215, 22);
            this.txtSecond.TabIndex = 3;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(103, 105);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(104, 17);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "Second Value: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(200, 155);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 48);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // richTxtErrors
            // 
            this.richTxtErrors.Location = new System.Drawing.Point(106, 226);
            this.richTxtErrors.Name = "richTxtErrors";
            this.richTxtErrors.Size = new System.Drawing.Size(538, 193);
            this.richTxtErrors.TabIndex = 5;
            this.richTxtErrors.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTxtErrors);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox richTxtErrors;
    }
}

