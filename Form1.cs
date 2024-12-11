﻿namespace WinForms.Method02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            double r = 0;
            if(!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            //lblResult.TabIndex = CircleArea(Radius);
            CircleArea(r);


        }

        void CircleArea (double radius)
        {
            double area = Math.PI * radius * radius;
            lblResult.Text = area.ToString();
        }
    }
}
