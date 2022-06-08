namespace BadanieWzroku
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Form> windows = new Dictionary<string, Form>();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e) => OpenWindow(new Komponenty.WyborWady());

        private void toolStripLabel2_Click(object sender, EventArgs e) => OpenWindow(new Komponenty.TablicaSnellena());

        private void toolStripLabel3_Click(object sender, EventArgs e) => OpenWindow(new Komponenty.BadanieWzrokuBarwa());

        private void toolStripLabel4_Click(object sender, EventArgs e) => OpenWindow(new Komponenty.WyborOkularow() { Marki = new List<string>() { "test", "test2" } });

        private void toolStripLabel5_Click(object sender, EventArgs e) => OpenWindow(new Komponenty.Podsumowanie(windows));

        private T OpenWindow<T>(T window) where T : Form
        {
            window.StartPosition = FormStartPosition.CenterParent;
            if (window is Komponenty.Podsumowanie)
            {
                window.ShowDialog();
                return window;
            }
            else if (windows.TryGetValue(window.Name, out Form form))
            {
                form.ShowDialog();
                return (T)form;
            }
            else
            {
                window.ShowDialog();
                windows.Add(window.Name, window);
                return window;
            }
        }
    }
}