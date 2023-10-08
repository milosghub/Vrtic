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
    public class DecaRepository
    {
        public List<Deca> GetAllChildren()
        {
            List<Deca> listaDece = new List<Deca>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM DECA";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Deca d = new Deca();
                    d.id_deteta = dataReader.GetInt32(0);
                    d.ime = dataReader.GetString(1);
                    d.prezime = dataReader.GetString(2);
                    d.ime_majke = dataReader.GetString(3);
                    d.ime_oca = dataReader.GetString(4);
                    d.datum_rodjenja = dataReader.GetString(5);
                    d.mesto_rodjenja = dataReader.GetString(6);

                    listaDece.Add(d);
                }

            }
            return listaDece;
        }
        public int InsertChildren(Deca d)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO DECA " +
                    "VALUES('{0}','{1}','{2}', '{3}', '{4}', '{5}')", d.ime, d.prezime, d.ime_majke, d.ime_oca, d.datum_rodjenja, d.mesto_rodjenja);

                return command.ExecuteNonQuery();

            }

        }
        public int UpdateChildren(Deca d)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("UPDATE DECA SET ime='{0}', prezime='{1}', ime_majke='{2}', ime_oca='{3}', datum_rodjenja='{4}', mesto_rodjenja='{5}'" +
                    "WHERE id_deteta={6}", d.ime, d.prezime, d.ime_majke, d.ime_oca, d.datum_rodjenja, d.mesto_rodjenja, d.id_deteta);

                return command.ExecuteNonQuery();

            }

        }
        public int DeleteChildren(Deca d)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = string.Format("DELETE FROM DECA WHERE id_deteta = {0}", d.id_deteta);

                    return command.ExecuteNonQuery();
                }
            }


        }
    }
}
