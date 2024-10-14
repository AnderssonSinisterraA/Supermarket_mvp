using Microsoft.Data.SqlClient;
using System.Data;

namespace Supermarket_mvp.Models
{
    internal interface IPayModeRepository
    {
        string connectionString { get; }

        void Add(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PayMode VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.ExecuteNonQuery();
            }
        }
        void Edit(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE PayMode
                                         SET Pay_Mode_Name =@name,
                                         Pay_Mode_Observation = @observation
                                         WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeModel.Id;
                command.ExecuteNonQuery();
            }
        }
        void Delete(int id);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
