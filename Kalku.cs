namespace Kalku_Pake_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string caltotal;
        float float1;
        float float2;
        string option;
        float result;

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2" ;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "+";
            float1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            float1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "x";
            float1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = ":";
            float1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float2 = float.Parse(txtDisplay.Text);

            if (option.Equals("+"))
                result = float1 + float2;

            if (option.Equals("-"))
                result = float1 - float2;

            if (option.Equals("x"))
                result = float1 * float2;

            if (option.Equals(":"))
                result = float1 / float2;
            txtDisplay.Text = result + "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            float1 = (0);
            float2 = (0);
        }
    }
}