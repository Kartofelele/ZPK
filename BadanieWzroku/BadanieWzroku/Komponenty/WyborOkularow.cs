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
    public partial class WyborOkularow : Form
    {
        private List<string> _Marki = new List<string>() { "Firmowe" };
        private List<string> _Kolory = new List<string>() { "Czarny" };
        private List<string> _Soczewki = new List<string>() { "Brak" };
        public List<string> Marki
        {
            get => _Marki;
            set
            {
                _Marki = value;
                LoadDataToComboBox(MarkiComboBox, _Marki);
            }
        }
        public List<string> Kolory
        {
            get => _Kolory;
            set
            {
                _Kolory = value;
                LoadDataToComboBox(MarkiComboBox, _Kolory);
            }
        }
        public List<string> Soczewki
        {
            get => _Soczewki;
            set
            {
                _Soczewki = value;
                LoadDataToComboBox(MarkiComboBox, _Soczewki);
            }
        }
        public string WybranaMarka { get; private set; }
        public string WybraneKolory { get; private set; }
        public string WybraneSoczewki { get; private set; }
        public WyborOkularow()
        {
            InitializeComponent();
            LoadDataToComboBox(MarkiComboBox, Marki);
            LoadDataToComboBox(KoloryComboBox, Kolory);
            LoadDataToComboBox(SoczewkiComboBox, Soczewki);
        }

        private void LoadDataToComboBox(ComboBox comboBox, List<string> data)
        {
            comboBox.Items.Clear();
            data.ForEach(x =>
            {
                comboBox.Items.Add(x);
            });
            comboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (sender as ComboBox).Text;
            switch ((sender as ComboBox).Name)
            {
                case "MarkiComboBox":
                    WybranaMarka = value;
                    break;
                case "KoloryComboBox":
                    WybraneKolory = value;
                    break;
                case "SoczewkiComboBox":
                    WybraneSoczewki = value;
                    break;
            }
        }
    }
}
