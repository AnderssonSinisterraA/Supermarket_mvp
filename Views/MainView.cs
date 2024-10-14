namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };

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

        private void BtnProduct_Click(object sender, EventArgs e)
        {
                ProductView productView = new ProductView();
                productView.Show();

                BtnExit.Click += delegate { this.Close(); };            
        }
    }
}
