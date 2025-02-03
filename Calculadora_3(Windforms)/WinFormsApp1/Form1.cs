using System;
using System.Drawing.Drawing2D;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public double result { get; set; }
        public double value { get; set; }
        private Operation operationSelected { get; set; }

        private enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            Pot,
            Rad,
            Fat,
            Log,
            Mod
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath shapebntzero = new GraphicsPath();
            shapebntzero.AddEllipse(0, 0, btnZero.Width, btnZero.Height);
            btnZero.Region = new Region(shapebntzero);

            GraphicsPath shapebtnvir = new GraphicsPath();
            shapebtnvir.AddEllipse(0, 0, btnVir.Width, btnVir.Height);
            btnVir.Region = new Region(shapebtnvir);

            GraphicsPath shapebtnone = new GraphicsPath();
            shapebtnone.AddEllipse(0, 0, btnone.Width, btnone.Height);
            btnone.Region = new Region(shapebtnone);

            GraphicsPath shapebtntwo = new GraphicsPath();
            shapebtntwo.AddEllipse(0, 0, btntwo.Width, btntwo.Height);
            btntwo.Region = new Region(shapebtntwo);

            GraphicsPath shapebtnthr = new GraphicsPath();
            shapebtnthr.AddEllipse(0, 0, btnthr.Width, btnthr.Height);
            btnthr.Region = new Region(shapebtnthr);

            GraphicsPath shapebtnfou = new GraphicsPath();
            shapebtnfou.AddEllipse(0, 0, btnfou.Width, btnfou.Height);
            btnfou.Region = new Region(shapebtnfou);

            GraphicsPath shapebtnfiv = new GraphicsPath();
            shapebtnfiv.AddEllipse(0, 0, btnfiv.Width, btnfiv.Height);
            btnfiv.Region = new Region(shapebtnfiv);

            GraphicsPath shapebtnsix = new GraphicsPath();
            shapebtnsix.AddEllipse(0, 0, btnsix.Width, btnsix.Height);
            btnsix.Region = new Region(shapebtnsix);

            GraphicsPath shapebtnsev = new GraphicsPath();
            shapebtnsev.AddEllipse(0, 0, btnsev.Width, btnsev.Height);
            btnsev.Region = new Region(shapebtnsev);

            GraphicsPath shapebtneig = new GraphicsPath();
            shapebtneig.AddEllipse(0, 0, btneig.Width, btneig.Height);
            btneig.Region = new Region(shapebtneig);

            GraphicsPath shapebtnnin = new GraphicsPath();
            shapebtnnin.AddEllipse(0, 0, btnnin.Width, btnnin.Height);
            btnnin.Region = new Region(shapebtnnin);

            GraphicsPath shapebtnce = new GraphicsPath();
            shapebtnce.AddEllipse(0, 0, btnce.Width, btnce.Height);
            btnce.Region = new Region(shapebtnce);

            GraphicsPath shapebtnmor = new GraphicsPath();
            shapebtnmor.AddEllipse(0, 0, btnmor.Width, btnmor.Height);
            btnmor.Region = new Region(shapebtnmor);

            GraphicsPath shapebtnsub = new GraphicsPath();
            shapebtnsub.AddEllipse(0, 0, btnsub.Width, btnsub.Height);
            btnsub.Region = new Region(shapebtnsub);

            GraphicsPath shapebtnmul = new GraphicsPath();
            shapebtnmul.AddEllipse(0, 0, btnmul.Width, btnmul.Height);
            btnmul.Region = new Region(shapebtnmul);

            GraphicsPath shapebtndiv = new GraphicsPath();
            shapebtndiv.AddEllipse(0, 0, btndiv.Width, btndiv.Height);
            btndiv.Region = new Region(shapebtndiv);

            GraphicsPath shapebtnpot = new GraphicsPath();
            shapebtnpot.AddEllipse(0, 0, btnpot.Width, btnpot.Height);
            btnpot.Region = new Region(shapebtnpot);

            GraphicsPath shapebtnrad = new GraphicsPath();
            shapebtnrad.AddEllipse(0, 0, btnrad.Width, btnrad.Height);
            btnrad.Region = new Region(shapebtnrad);

            GraphicsPath shapebtnfat = new GraphicsPath();
            shapebtnfat.AddEllipse(0, 0, btnfat.Width, btnfat.Height);
            btnfat.Region = new Region(shapebtnfat);

        }


        private void zero(object sender, EventArgs e)
        {
            screen.Text += "0";
        }

        private void btnVir_Click(object sender, EventArgs e)
        {
            if (!screen.Text.Contains(","))
                screen.Text += ",";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            screen.Text += "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            screen.Text += "2";
        }

        private void btnthr_Click(object sender, EventArgs e)
        {
            screen.Text += "3";
        }

        private void btnfou_Click(object sender, EventArgs e)
        {
            screen.Text += "4";
        }

        private void btnfiv_Click(object sender, EventArgs e)
        {
            screen.Text += "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            screen.Text += "6";
        }

        private void btnsev_Click(object sender, EventArgs e)
        {
            screen.Text += "7";
        }

        private void btneig_Click(object sender, EventArgs e)
        {
            screen.Text += "8";
        }

        private void btnnin_Click(object sender, EventArgs e)
        {
            screen.Text += "9";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            screen.Text = "";
        }

        private void btnmor_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Add;
            value = Convert.ToDouble(screen.Text);
            screen.Text = "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Sub;
            if (screen.Text == "")
            {
                value = 0;
            }
            else
            {
                value = Convert.ToDouble(screen.Text);
                screen.Text = "";
            }

        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Mul;
            value = Convert.ToDouble(screen.Text);
            screen.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Div;
            value = Convert.ToDouble(screen.Text);
            screen.Text = "";
        }

        private void btnigu_Click(object sender, EventArgs e)
        {
            switch (operationSelected)
            {
                case Operation.Add:
                    result = value + Convert.ToDouble(screen.Text);
                    break;
                case Operation.Sub:
                    result = value - Convert.ToDouble(screen.Text);
                    break;
                case Operation.Mul:
                    result = value * Convert.ToDouble(screen.Text);
                    break;
                case Operation.Div:
                    result = value / Convert.ToDouble(screen.Text);
                    break;
                case Operation.Pot:
                    result = Math.Pow(Convert.ToDouble(value), Convert.ToDouble(screen.Text));
                    break;
                case Operation.Rad:
                    result = Math.Pow(value, 1.0 / Convert.ToDouble(screen.Text));
                    break;
                case Operation.Fat:
                    if (screen.Text == "0" || screen.Text == "1")
                        result = 1;

                    double fatresult = 1;
                    for (int i = 1; i <= Convert.ToDouble(screen.Text); i++)
                    {
                        fatresult *= i;
                    }
                    result = fatresult;
                    break;
                case Operation.Log:
                    result = Math.Log10(Convert.ToDouble(screen.Text));
                    break;
                case Operation.Mod:
                    result = Math.Abs(Convert.ToDouble(screen.Text));
                    break;
            }
            screen.Text = result.ToString();

        }

        private void btnepot_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Pot;
            if (screen.Text == "")
            {
                value = 0;
            }
            else
            {
                value = Convert.ToDouble(screen.Text);
                screen.Text = "";
            }
        }

        private void btnrad_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Rad;
            value = Convert.ToDouble(screen.Text);
            screen.Text = "";
        }

        private void btnfat_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Fat;
            value = Convert.ToDouble(screen.Text);
        }

        private void btnpi1_Click(object sender, EventArgs e)
        {
            screen.Text = (Convert.ToString(Math.PI));
        }

        private void btnlog1_Click(object sender, EventArgs e)
        {
            operationSelected = Operation.Fat;
            value = Convert.ToDouble(screen.Text);
        }
    }
}
