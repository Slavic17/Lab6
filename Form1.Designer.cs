namespace Lab6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtLowerBound = new TextBox();
            txtUpperBound = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
         
            txtLowerBound.Location = new Point(169, 41);
            txtLowerBound.Margin = new Padding(4, 5, 4, 5);
            txtLowerBound.Name = "txtLowerBound";
            txtLowerBound.Size = new Size(132, 27);
            txtLowerBound.TabIndex = 0;
           
            txtUpperBound.Location = new Point(169, 104);
            txtUpperBound.Margin = new Padding(4, 5, 4, 5);
            txtUpperBound.Name = "txtUpperBound";
            txtUpperBound.Size = new Size(132, 27);
            txtUpperBound.TabIndex = 1;
           
            btnCalculate.Location = new Point(168, 168);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(133, 35);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
         
            lblResult.AutoSize = true;
            lblResult.Location = new Point(67, 231);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 384);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtUpperBound);
            Controls.Add(txtLowerBound);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Lab6";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtLowerBound;
        private System.Windows.Forms.TextBox txtUpperBound;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
