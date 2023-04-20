namespace EmbeddedReactJS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            webView21.Source = new Uri("http://localhost:44433", UriKind.Absolute);
        }
    }
}
