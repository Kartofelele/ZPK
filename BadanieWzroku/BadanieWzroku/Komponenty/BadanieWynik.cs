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
    public partial class BadanieWynik : UserControl
    {
        public BadanieWynik(Image tablica, string odpowiedz)
        {
            InitializeComponent();
            pb.Image = tablica;
            Label.Text = odpowiedz;
        }
    }
}
