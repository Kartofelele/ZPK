using BadanieWzroku.Properties;
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
    public partial class BadanieWzrokuBarwaTablica : Form
    {
        public string Odpowiedz { get; private set; }

        public BadanieWzrokuBarwaTablica(Bitmap tablica, string odpowiedzPierwsza, string odpowiedzDruga, string odpowiedzTrzecia, string odpowiedzCzwarta)
        {
            InitializeComponent();
            AnswerOneButton.Text = odpowiedzPierwsza;
            AnswerTwoButton.Text = odpowiedzDruga;
            AnswerThreeButton.Text = odpowiedzTrzecia;
            AnswerFourButton.Text = odpowiedzCzwarta;
            TablicaPictureBox.Image = tablica;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Odpowiedz = (sender as Button).Text;
            this.Close();
        }
    }
}
