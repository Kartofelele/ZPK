using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadanieWzroku.Komponenty
{
    public partial class WyborWady : Form
    {
        public double LewaWada { get; private set; }
        public double PrawaWada { get; private set; }

        public WyborWady()
        {
            InitializeComponent();
        }

        private void LeftDecreaseButton_Click(object sender, EventArgs e)
        {
            LewaWada -= 0.01;
            LeftValueTextBox.Text = LewaWada.ToString("0.00");
        }

        private void LeftIncreaseButton_Click(object sender, EventArgs e)
        {
            LewaWada += 0.01;
            LeftValueTextBox.Text = LewaWada.ToString("0.00");
        }

        private void RightDecreaseButton_Click(object sender, EventArgs e)
        {
            PrawaWada -= 0.01;
            RightValueTextBox.Text = PrawaWada.ToString("0.00");
        }

        private void RightIncreaseButton_Click(object sender, EventArgs e)
        {
            PrawaWada += 0.01;
            RightValueTextBox.Text = PrawaWada.ToString("0.00");
        }

        private void LeftValueTextBox_KeyDown(object sender, KeyEventArgs e) => e.SuppressKeyPress = ValidateTextBox(sender, e);

        private void RightValueTextBox_KeyDown(object sender, KeyEventArgs e) => e.SuppressKeyPress = ValidateTextBox(sender, e);


        private void LeftValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(LeftValueTextBox.Text, out double value))
            {
                LewaWada = value;
            }
        }

        private void RightValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(RightValueTextBox.Text, out double value))
            {
                PrawaWada = value;
            }
        }
        private bool ValidateTextBox(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > (int)'0' || e.KeyValue < (int)'9' || (e.KeyValue == (int)',' && (sender as TextBox).Text.Contains(',') == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
