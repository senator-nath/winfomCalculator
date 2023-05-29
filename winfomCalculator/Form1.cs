using System;
using System.Windows.Forms;

namespace winfomCalculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void NumberOperators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);
            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;
                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    if (enterSecondValue == 0)
                    {
                        txtResult.Text = "Error";
                    }
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "%":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "x^n":
                    txtResult.Text = Math.Pow(enterFirstValue, enterSecondValue).ToString();
                    break;
                case "nthRT":
                    txtResult.Text = Math.Pow(enterFirstValue, 1.0 / enterSecondValue).ToString();
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            string f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);
            f = "";
            s = "";
        }

        private void btnPlusAndMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text.Length == 0)
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 328;
            this.Height = 396;
            txtResult.Width = 306;

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 638;
            txtResult.Width = 615;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("confirm if you want to exit", "scientificcal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.14159265359";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {

            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double y;
            y = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(y);
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {

            double root = Convert.ToDouble(txtResult.Text);
            root = Math.Pow(root, (1.0 / 3)); ;
            txtResult.Text = Convert.ToString(root);
        }

        private void btnNthPower_Click(object sender, EventArgs e)
        {
            double cube = Convert.ToDouble(txtResult.Text);
            cube = Math.Pow(enterFirstValue, enterSecondValue);
            txtResult.Text = Convert.ToString(cube);
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {

            double Sqrt = Convert.ToDouble(txtResult.Text);
            Sqrt = Math.Sqrt(Sqrt);
            txtResult.Text = Convert.ToString(Sqrt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 330;
            txtResult.Width = 306;
        }
    }
}
