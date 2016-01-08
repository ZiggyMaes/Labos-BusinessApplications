using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wishlistr.API.Models;
using Wishlistr.API.Respositories.core;

namespace Wishlistr.API.Respositories
{
    public class SqlRepository : IRepository<Wish>
    {
        public void Delete(Wish item)
        {
            throw new NotImplementedException();
        }

        public void Edit(Wish item)
        {
            throw new NotImplementedException();
        }

        public List<Wish> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["wishlistr"].ConnectionString)) {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * from Wishes";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                connection.Open();
                List<Wish> wishes = new List<Wish>();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    Wish w = new Wish();
                    w.ID = Convert.ToInt32(reader["id"]);
                    w.Title = reader["title"].ToString();
                    w.Description = reader["description"].ToString();
                    w.ImageUrl = reader["ImageUrl"].ToString();
                    w.Link = reader["Link"].ToString();
                    w.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    w.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                    wishes.Add(w);
                }
                return wishes;
            }
        }

        public void Save(Wish item)
        {
            throw new NotImplementedException();
        }

        public void Add(Wish item)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["wishlistr"].ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Wishes ([Title],[Description],[Link],[ImageUrl],[CreatedDate],[ModifiedDate]) VALUES (@title, @description, @link, @imageurl, @createddate, @modifieddate)";
                command.Parameters.AddWithValue("@title", item.Title);
                command.Parameters.AddWithValue("@description", item.Description);
                command.Parameters.AddWithValue("@link", "link");
                command.Parameters.AddWithValue("@imageurl", "url");
                command.Parameters.AddWithValue("@createddate", DateTime.Now);
                command.Parameters.AddWithValue("@modifieddate", DateTime.Now);
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
