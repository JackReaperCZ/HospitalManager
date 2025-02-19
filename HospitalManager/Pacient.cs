using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HospitalManager
{
    /// <summary>
    /// Represents a patient in the hospital system.
    /// </summary>
    public class Pacient
    {
        /// <summary>
        /// Gets or sets the patient ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the patient's first name.
        /// </summary>
        public string Jmeno { get; set; }

        /// <summary>
        /// Gets or sets the patient's last name.
        /// </summary>
        public string Prijmeni { get; set; }

        /// <summary>
        /// Gets or sets the patient's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the patient's phone number.
        /// </summary>
        public int Telefon { get; set; }

        /// <summary>
        /// Gets or sets the patient's date of birth.
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pacient"/> class.
        /// </summary>
        /// <param name="id">The patient ID.</param>
        /// <param name="jmeno">The patient's first name.</param>
        /// <param name="prijmeni">The patient's last name.</param>
        /// <param name="email">The patient's email address.</param>
        /// <param name="telefon">The patient's phone number.</param>
        /// <param name="birthday">The patient's date of birth.</param>
        public Pacient(int id, string jmeno, string prijmeni, string email, int telefon, DateTime birthday)
        {
            ID = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            Telefon = telefon;
            Birthday = birthday;
        }

        /// <summary>
        /// Inserts or updates a patient record in the database.
        /// </summary>
        /// <param name="pacient">The patient object to submit.</param>
        public static void Submit(Pacient pacient)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = (pacient.ID == -1)
                ? "INSERT INTO pacienti (jmeno,prijmeni,email,tel,dat_nar) VALUES (@jmeno,@prijmeni,@email,@tel,@dat_nar);"
                : "UPDATE pacienti SET jmeno = @jmeno, prijmeni = @prijmeni, email = @email, tel = @tel, dat_nar = @dat_nar WHERE id = @id;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@jmeno", pacient.Jmeno);
                cmd.Parameters.AddWithValue("@prijmeni", pacient.Prijmeni);
                cmd.Parameters.AddWithValue("@email", pacient.Email);
                cmd.Parameters.AddWithValue("@tel", pacient.Telefon);
                cmd.Parameters.AddWithValue("@dat_nar", pacient.Birthday.ToString("yyyy-MM-dd"));

                if (pacient.ID != -1)
                {
                    cmd.Parameters.AddWithValue("@id", pacient.ID);
                }

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retrieves all patients from the database.
        /// </summary>
        /// <returns>A list of all patients.</returns>
        public static List<Pacient> GetAll()
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            List<Pacient> pacienti = new List<Pacient>();
            string query = "SELECT * FROM pacienti;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pacienti.Add(new Pacient(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetDateTime(5)
                        ));
                    }
                }
            }

            return pacienti;
        }

        /// <summary>
        /// Deletes a patient record from the database.
        /// </summary>
        /// <param name="pacient">The patient object to delete.</param>
        public static void Delete(Pacient pacient)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = "DELETE FROM pacienti WHERE id = @id;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", pacient.ID);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Returns a string representation of the patient.
        /// </summary>
        /// <returns>A string in the format "FirstName LastName".</returns>
        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni}";
        }
    }
}
