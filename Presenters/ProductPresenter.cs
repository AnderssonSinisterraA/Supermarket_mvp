using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private readonly IProductView productView;
        private readonly string sqlConnectionString;
        private IProductView view;
        private IProductRepository repository;

        public ProductPresenter(IProductView productView, string sqlConnectionString)
        {
            this.productView = productView;
            this.sqlConnectionString = sqlConnectionString;

            this.productView.ShowProductView += ShowProductView;
        }

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((ProductView)productView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
    }
}
