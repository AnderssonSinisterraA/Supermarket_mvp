namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductPrice { get; set; }
        string ProductStock { get; set; }
        string ProductCategoryId { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        Action<object?, EventArgs> ShowProductView { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBindingSource(BindingSource productList);
        void Show();
    }
}
