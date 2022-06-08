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
    public partial class Podsumowanie : Form
    {
        public Podsumowanie(Dictionary<string, Form> windows)
        {
            InitializeComponent();
            windows.Keys.ToList().ForEach(x =>
            {
                switch (x)
                {
                    case "WyborWady":
                        LewaWadaLabel.Text = "Lewa wada: " + (windows[x] as WyborWady).LewaWada.ToString();
                        PrawaWadaLabel.Text = "Prawa wada: " + (windows[x] as WyborWady).PrawaWada.ToString();
                        break;
                    case "TablicaSnellena":
                        WadaSnellenaLabel.Text = "Wada: " + (windows[x] as TablicaSnellena).WadaWzroku.ToString();
                        break;
                    case "BadanieWzrokuBarwa":
                        Dictionary<Bitmap, string> badaniaBarwy = (windows[x] as BadanieWzrokuBarwa).Badania;
                        badaniaBarwy.Keys.ToList().ForEach(x =>
                        {
                            BadanieWynik badanie = new BadanieWynik(x, badaniaBarwy[x])
                            {
                                Width = 200,
                                Height = 220,
                                Parent = BarwaFLP
                            };
                        });
                        break;
                    case "WyborOkularow":
                        MarkaLabel.Text = "Marka: " + (windows[x] as WyborOkularow).WybranaMarka;
                        KolorLabel.Text = "Kolor: " + (windows[x] as WyborOkularow).WybraneKolory;
                        SoczewkiLabel.Text = "Soczewki: " + (windows[x] as WyborOkularow).WybraneSoczewki;
                        break;
                }
            });
        }
    }
}
