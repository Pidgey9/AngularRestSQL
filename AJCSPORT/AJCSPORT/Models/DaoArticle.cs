using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AJCSPORT.Models
{
    public class DaoArticle
    {
        string connectionString = @"Data Source=DESKTOP-F1NS20D;Initial Catalog=ProjetFinalECommerce;Integrated Security=True";
        public bool Delete(int id)
        {
            string sql = "delete Articles where idArticle = " + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Update(Article a)
        {
            string sql = "update articles set article=@article,description=@description,prix=@prix where idArticle=@idArticle ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("idArticle", SqlDbType.Int).Value = a.Id;
            command.Parameters.Add("article", SqlDbType.NVarChar).Value = a.Nom;
            command.Parameters.Add("description", SqlDbType.NVarChar).Value = a.Description;
            command.Parameters.Add("categorie", SqlDbType.NVarChar).Value = a.Categorie;
            command.Parameters.Add("prix", SqlDbType.Float).Value = a.Prix;
            command.Parameters.Add("image", SqlDbType.NVarChar).Value = a.Image;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Insert(Article a)
        {
            string sql = "insert into Articles values(@idArticle,@article,@description,@categorie,@prix,@image)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("idArticle", SqlDbType.Int).Value = a.Id;
            command.Parameters.Add("article", SqlDbType.NVarChar).Value = a.Nom;
            command.Parameters.Add("description", SqlDbType.NVarChar).Value = a.Description;
            command.Parameters.Add("categorie", SqlDbType.NVarChar).Value = a.Categorie;
            command.Parameters.Add("prix", SqlDbType.Float).Value = a.Prix;
            command.Parameters.Add("image", SqlDbType.NVarChar).Value = a.Image;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;

        }
        public List<Article> SelectAll()
        {
            List<Article> liste = new List<Article>();
            string sql = "select * from articles";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
                liste.Add(a);

            }
            connection.Close();

            return liste;
        }

        public Article SelectById(int id)
        {
            Article a = null;
            string sql = "select * from articles where idArticle=" + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
            connection.Close();

            return a;
        }

    }
}