using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        string connectionString { get; }

        void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product (Product_Name, Price, Stock, Category_Id) VALUES (@name, @price, @stock, @categoryId)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@categoryId", SqlDbType.Int).Value = productModel.CategoryId;
                command.ExecuteNonQuery();
            }
        }

        void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product
                                         SET Product_Name = @name,
                                             Price = @price,
                                             Stock = @stock,
                                             Category_Id = @categoryId
                                         WHERE Product_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@categoryId", SqlDbType.Int).Value = productModel.CategoryId;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }

        void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM Product", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Price = (int)reader["Price"],
                            Stock = (int)reader["Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }

        IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM Product WHERE Product_Name LIKE @value", connection))
            {
                connection.Open();
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = $"%{value}%";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Price = (int)reader["Price"],
                            Stock = (int)reader["Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }
    }
}
