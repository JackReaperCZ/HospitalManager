using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HospitalManager
{
    /// <summary>
    /// Represents a medication (Lek) entity with properties and database operations.
    /// </summary>
    public class Lek(int id, string name, float cena, string popis, string vyrobce)
    {
        /// <summary>
        /// Gets or sets the unique identifier of the medication.
        /// </summary>
        public int ID { get; set; } = id;
        
        /// <summary>
        /// Gets or sets the name of the medication.
        /// </summary>
        public string Name { get; set; } = name;
        
        /// <summary>
        /// Gets or sets the price of the medication.
        /// </summary>
        public float Cena { get; set; } = cena;
        
        /// <summary>
        /// Gets or sets the description of the medication.
        /// </summary>
        public string Popis { get; set; } = popis;
        
        /// <summary>
        /// Gets or sets the manufacturer of the medication.
        /// </summary>
        public string Vyrobce { get; set; } = vyrobce;

        /// <summary>
        /// Retrieves all medications from the database.
        /// </summary>
        /// <returns>A list of <see cref="Lek"/> objects.</returns>
        public static List<Lek> GetAll()
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            List<Lek> leky = new List<Lek>();
            string query = "SELECT * FROM leky;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        leky.Add(new Lek(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3),
                            reader.GetString(4)
                        ));
                    }
                }
            }

            return leky;
        }
        
        /// <summary>
        /// Inserts or updates a medication record in the database.
        /// </summary>
        /// <param name="lek">The <see cref="Lek"/> object to be submitted.</param>
        public static void Submit(Lek lek)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = (lek.ID == -1)
                ? "INSERT INTO leky (nazev,cena,popis,vyrobce) VALUES (@nazev,@cena,@popis,@vyrobce);"
                : "UPDATE leky SET nazev = @nazev, cena = @cena, popis = @popis, vyrobce = @vyrobce WHERE id = @id;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                Random r = new Random();

                if (lek.ID == -1)
                {
                    cmd.Parameters.AddWithValue("@nazev", lek.Name);
                    cmd.Parameters.AddWithValue("@cena", lek.Cena);
                    cmd.Parameters.AddWithValue("@popis", lek.Popis);
                    cmd.Parameters.AddWithValue("@vyrobce", lek.Vyrobce);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nazev", lek.Name);
                    cmd.Parameters.AddWithValue("@cena", lek.Cena);
                    cmd.Parameters.AddWithValue("@popis", lek.Popis);
                    cmd.Parameters.AddWithValue("@vyrobce", lek.Vyrobce);
                    cmd.Parameters.AddWithValue("@id", lek.ID);
                }

                cmd.ExecuteNonQuery();
            }
        }
        
        /// <summary>
        /// Deletes a medication record from the database.
        /// </summary>
        /// <param name="lek">The <see cref="Lek"/> object to be deleted.</param>
        public static void Delete(Lek lek)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = $"DELETE FROM leky WHERE id = @id;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", lek.ID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}