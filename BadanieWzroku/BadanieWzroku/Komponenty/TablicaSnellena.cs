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
    public partial class TablicaSnellena : Form
    {
        public double WadaWzroku { get; private set; }
        private List<double> _WadyWzroku = new List<double>() {
            0, 0.1, 0.2, 0.3, 0.4, 0.5,
            0.6, 0.7, 0.8, 0.9, 1.0, 1.5, 2.0
        };
        public List<double> WadyWzroku
        {
            get => _WadyWzroku;
            set
            {
                _WadyWzroku = value;
                LoadDataToComboBox(WadaComboBox, _WadyWzroku);
            }
        }
        public TablicaSnellena()
        {
            InitializeComponent();
            LoadDataToComboBox(WadaComboBox, _WadyWzroku);
        }

        private void LoadDataToComboBox(ComboBox comboBox, List<double> data)
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

        private void WadaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WadaWzroku = Convert.ToDouble(WadaComboBox.Items[WadaComboBox.SelectedIndex]);
        }
    }
}
