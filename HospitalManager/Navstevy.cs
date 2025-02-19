using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HospitalManager
{
    /// <summary>
    /// Represents a visit record between a patient and a doctor.
    /// </summary>
    public class Navstevy(int id, Pacient pacient, Lekar lekar, DateTime datum, string poznamka)
    {
        /// <summary>
        /// Gets or sets the ID of the visit.
        /// </summary>
        public int ID { get; set; } = id;

        /// <summary>
        /// Gets or sets the patient associated with the visit.
        /// </summary>
        public Pacient Pacient { get; set; } = pacient;

        /// <summary>
        /// Gets or sets the doctor associated with the visit.
        /// </summary>
        public Lekar Lekar { get; set; } = lekar;

        /// <summary>
        /// Gets or sets the date of the visit.
        /// </summary>
        public DateTime Datum { get; set; } = datum;

        /// <summary>
        /// Gets or sets the notes related to the visit.
        /// </summary>
        public string Poznamka { get; set; } = poznamka;

        /// <summary>
        /// Submits a new visit record to the database.
        /// </summary>
        /// <param name="navstevy">The visit record to submit.</param>
        public static void Submit(Navstevy navstevy)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = "INSERT INTO navstevy (id_pac,id_lek,dat_nav,pozn) VALUES (@id_pac,@id_lek,@dat_nav,@pozn);";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_pac", navstevy.Pacient.ID);
                cmd.Parameters.AddWithValue("@id_lek", navstevy.Lekar.ID);
                cmd.Parameters.AddWithValue("@dat_nav", navstevy.Datum);
                cmd.Parameters.AddWithValue("@pozn", navstevy.Poznamka);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retrieves all visit records for a specified patient.
        /// </summary>
        /// <param name="pacient">The patient whose visits to retrieve.</param>
        /// <returns>A list of visit records for the specified patient.</returns>
        public static List<Navstevy> GetAll(Pacient pacient)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            List<Navstevy> navstevy = new List<Navstevy>();
            string query = "SELECT * FROM navstevy n JOIN lekari l ON n.id_lek = l.id WHERE id_pac = @id_pac;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_pac", pacient.ID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        navstevy.Add(new Navstevy(
                            reader.GetInt32(0),
                            pacient,
                            new Lekar(reader.GetInt32(5),
                                reader.GetInt32(6),
                                reader.GetString(7),
                                reader.GetString(8),
                                reader.GetString(9),
                                reader.GetString(10),
                                reader.GetInt32(11)
                            ),
                            reader.GetDateTime(3),
                            reader.GetString(4)
                        ));
                    }
                }
            }

            return navstevy;
        }
    }
}
