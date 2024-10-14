namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };

            BtnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomerView;

        private void BtnPayMode_Click(object sender, EventArgs e)
        {
            PayModeView payModeView = new PayModeView();
            payModeView.Show();

            BtnExit.Click += delegate { this.Close(); };
        }
    }
}
