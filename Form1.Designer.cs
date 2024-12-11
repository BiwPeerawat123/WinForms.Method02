namespace WinForms.Method02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCircumference = new Button();
            btnCircleArea = new Button();
            lblResult = new Label();
            txtRadius = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Bisque;
            groupBox1.Controls.Add(btnCircumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(473, 33);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(101, 39);
            btnCircumference.TabIndex = 4;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(366, 33);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(101, 39);
            btnCircleArea.TabIndex = 3;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PaleGreen;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(97, 93);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(253, 64);
            lblResult.TabIndex = 2;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(120, 39);
            txtRadius.Multiline = true;
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(212, 34);
            txtRadius.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 255);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(12, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 367);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(21, 36);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(251, 303);
            txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 618);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Windows Form Method";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRadius;
        private Label label1;
        private Button btnCircumference;
        private Button btnCircleArea;
        private Label lblResult;
        private GroupBox groupBox2;
        private TextBox txtOutput;
    }
}
