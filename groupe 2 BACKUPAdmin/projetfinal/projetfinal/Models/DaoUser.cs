using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace projetfinal.Models
{
  public class DaoUser
  {
        string connectionString = @"Data Source=DESKTOP-F1NS20D;Initial Catalog=ProjetFinalECommerce;Integrated Security=True";
        public bool Delete(string id)
        {
            string sql = "delete Utilisateurs where login = '" + id + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Update(User u)
        {
            string sql = "update Utilisateurs set password=@password,nom=@nom,prenom=@prenom," +
                "adresse=@adresse,date_naissance=@date_naissance,e_mail=@email,isAdmin=@isAdmin where login=@id ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.NVarChar).Value = u.Id;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = u.Password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = u.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = u.Prenom;
            command.Parameters.Add("adresse", SqlDbType.NVarChar).Value = u.Adresse;
            command.Parameters.Add("date_naissance", SqlDbType.DateTime).Value = u.Naissance;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = u.Email;
            command.Parameters.Add("isAdmin", SqlDbType.Bit).Value = u.IsAdmin;


            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Insert(User u)
        {
            string sql = "insert into Utilisateurs values(@id,@password,@nom,@prenom,@adresse,@date_naissance,0,@email)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.NVarChar).Value = u.Id;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = u.Password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = u.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = u.Prenom;
            command.Parameters.Add("adresse", SqlDbType.NVarChar).Value = u.Adresse;
            command.Parameters.Add("date_naissance", SqlDbType.DateTime).Value = u.Naissance;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = u.Email;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;

        }
        public List<User> SelectAll()
        {
            List<User> liste = new List<User>();
            string sql = "select * from Utilisateurs";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User u = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetDateTime(5), reader.GetBoolean(6), reader.GetString(7));
                liste.Add(u);

            }
            connection.Close();

            return liste;
        }

        public User SelectById(int id)
        {
            User u = null;
            string sql = "select * from Utilisateurs where login='" + id + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                u = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetDateTime(5), reader.GetBoolean(6), reader.GetString(7));

            }
            connection.Close();

            return u;
        }

    }
}
