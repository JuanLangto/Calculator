namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        float num1;
        float num2;
        string option;
        float result;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
                txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(txtTotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtTotal.Text = txtTotal.Text + "0";
        }
    }
}
