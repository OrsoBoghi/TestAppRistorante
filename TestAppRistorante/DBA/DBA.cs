using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Wisej.Web;

internal class DBA
{
    const string STRINGA_DI_CONNESSIONE = @"Server=ANDREIPC\MSSQLSERVER01; Database=TestRistoranteApp; Trusted_Connection=True;";
    public List<Prodotto> GetMenu() {
        List<Prodotto> list = new List<Prodotto>();
        try
        {
            using (SqlConnection connection = new SqlConnection(STRINGA_DI_CONNESSIONE))
            {
                // Qui puoi aprire la connessione, eseguire comandi, ecc.
                connection.Open();
                
                // Esempio: Esecuzione di un comando SQL
                string sql = "SELECT * FROM TabellaProdotto";
                SqlCommand command = new SqlCommand(sql, connection);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Prodotto p=new Prodotto
                        {
                            IDProdotto = int.Parse(reader["IDProdotto"].ToString()),
                            IDCategoria = int.Parse(reader["IDCategoria"].ToString()),
                            Prezzo = int.Parse(reader["Prezzo"].ToString()),
                            Sconto = reader["Sconto"] as decimal?,
                            Descrizione = reader["Descrizione"].ToString(),
                            Immagine = reader["Immagine"].ToString(),
                        };
                        list.Add(p);
                    }
                }

                // Chiudi la connessione
                connection.Close();
            }
          
        }
        catch (Exception)
        {
            return null;
        }
        return list;
    }
}