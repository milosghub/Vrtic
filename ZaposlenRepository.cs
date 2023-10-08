using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ZaposlenRepository
    {
        public List<Zaposlen> GetAllEmployees()
        {
            List<Zaposlen> listaZaposlenih = new List<Zaposlen>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM ZAPOSLENI";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Zaposlen z = new Zaposlen();
                    z.id_zaposlenog = dataReader.GetInt32(0);
                    z.ime = dataReader.GetString(1);
                    z.prezime = dataReader.GetString(2);
                    z.username = dataReader.GetString(3);
                    z.password = dataReader.GetString(4);

                    listaZaposlenih.Add(z);


                }

            }
            return listaZaposlenih;
        }
    }
}
