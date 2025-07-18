using System.Diagnostics.CodeAnalysis;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnClWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Color oldColor;
        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnNum1_MouseEnter(object sender, EventArgs e)
        {
            oldColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = Color.Teal;
        }

        private void btnNum1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = oldColor;
        }

        private void chbAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAlwaysOnTop.Checked == true)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
                txtDisplay.Text += "0";
        }

        private void btnMomayes_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                txtDisplay.Text = "0.";
            else if
                (!txtDisplay.Text.Contains(','))
                txtDisplay.Text += ",";

        }
        double num1;
        string op;
        private void btnSum_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtDisplay.Text);
            //num1 = Convert.ToDouble(txtHistory.Text);
            txtDisplay.Text = txtHistory.Text;
            op = ((Button)sender).Text;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    txtHistory.Text = (num1 + Convert.ToDouble(txtDisplay.Text)).ToString();
                    txtDisplay.Clear();
                    break;
                case "-":
                    txtHistory.Text = (num1 - Convert.ToDouble(txtDisplay.Text)).ToString();
                    txtDisplay.Clear();
                    break;
                case "×":
                    txtHistory.Text = (num1 * Convert.ToDouble(txtDisplay.Text)).ToString();
                    txtDisplay.Clear();
                    break;
                case "÷":
                    txtHistory.Text = (num1 / Convert.ToDouble(txtDisplay.Text)).ToString();
                    txtDisplay.Clear();
                    break;
                case "%":
                    txtHistory.Text = (num1 % Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
                case "x2":
                    txtHistory.Text = (num1 * num1, Convert.ToDouble(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void btnCach_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtHistory.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
        private void btnFloatNum_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                txtDisplay.Text = "-";
            else if
                (!txtDisplay.Text.Contains('-'))
                txtDisplay.Text += "-";
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void brnCachDel_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void y(object sender, EventArgs e)
        {

        }
    }
}
