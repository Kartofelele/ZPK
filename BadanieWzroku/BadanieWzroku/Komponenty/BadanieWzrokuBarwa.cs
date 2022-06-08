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
    public partial class BadanieWzrokuBarwa : Form
    {
        public Dictionary<Bitmap, string> Badania { get; private set; } = new Dictionary<Bitmap, string>();
        public BadanieWzrokuBarwa()
        {
            InitializeComponent();
            Dictionary<Bitmap, string[]> badania = new Dictionary<Bitmap, string[]>()
            {
                { Properties.Resources._01, new string[] { "15", "9", "12", "21" } },
                { Properties.Resources._02, new string[] { "3", "8", "6", "5" } },
                { Properties.Resources._03, new string[] { "16", "26", "5", "6" } },
                { Properties.Resources._04, new string[] { "29", "18", "19", "25" } },
                { Properties.Resources._05, new string[] { "61", "57", "73", "37" } }
            };
            badania.Keys.ToList().ForEach(x =>
            {
                BadanieWzrokuBarwaTablica tablica = new BadanieWzrokuBarwaTablica(x, badania[x][0], badania[x][1], badania[x][2], badania[x][3]);
                tablica.ShowDialog();
                if (Badania.TryAdd(x, tablica.Odpowiedz) == false)
                {
                    Badania[x] = tablica.Odpowiedz;
                }
                BadanieWynik wynik = new BadanieWynik(x, tablica.Odpowiedz);
                wynik.Dock = DockStyle.Left;
                wynik.Width = 200;
                wynik.Height = 220;
                wynik.Parent = this;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
