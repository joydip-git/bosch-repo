using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    partial class MyForm
    {
        private Button btnClick;
        private void Init()
        {
            this.btnClick = new Button();
            this.btnClick.Text = "Click Me!!!";
            this.btnClick.Name ="btnClick";
            this.btnClick.Size = new System.Drawing.Size(100,50);
            this.btnClick.Location = new System.Drawing.Point(100, 200);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.Name = "MyForm";
            this.Text = "Data Entry Form";

            this.Controls.Add(this.btnClick);
            this.ResumeLayout(false);
        }
    }
}
