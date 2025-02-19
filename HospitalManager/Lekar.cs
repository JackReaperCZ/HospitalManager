using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HospitalManager
{
    /// <summary>
    /// Represents a doctor (Lekar) entity with properties and database operations.
    /// </summary>
    public class Lekar
    {
        /// <summary>
        /// Gets or sets the unique identifier of the doctor.
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Gets or sets the code of the doctor.
        /// </summary>
        public int Code { get; set; }
        
        /// <summary>
        /// Gets or sets the title of the doctor.
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Gets or sets the first name of the doctor.
        /// </summary>
        public string Jmeno { get; set; }
        
        /// <summary>
        /// Gets or sets the last name of the doctor.
        /// </summary>
        public string Prijmeni { get; set; }
        
        /// <summary>
        /// Gets or sets the email address of the doctor.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Gets or sets the phone number of the doctor.
        /// </summary>
        public int Telefon { get; set; }
        

        /// <summary>
        /// Initializes a new instance of the <see cref="Lekar"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the doctor.</param>
        /// <param name="code">The code of the doctor.</param>
        /// <param name="title">The title of the doctor.</param>
        /// <param name="jmeno">The first name of the doctor.</param>
        /// <param name="prijmeni">The last name of the doctor.</param>
        /// <param name="email">The email address of the doctor.</param>
        /// <param name="telefon">The phone number of the doctor.</param>
        public Lekar(int id, int code, string title, string jmeno, string prijmeni, string email, int telefon)
        {
            ID = id;
            Code = code;
            Title = title;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            Telefon = telefon;
        }

        /// <summary>
        /// Retrieves all doctors from the database.
        /// </summary>
        /// <returns>A list of <see cref="Lekar"/> objects.</returns>
        public static List<Lekar> GetAll()
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            List<Lekar> lekari = new List<Lekar>();
            string query = "SELECT * FROM lekari;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lekari.Add(new Lekar(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetInt32(6)
                        ));
                    }
                }
            }

            return lekari;
        }

        /// <summary>
        /// Inserts or updates a doctor record in the database.
        /// </summary>
        /// <param name="lekar">The <see cref="Lekar"/> object to be submitted.</param>
        public static void Submit(Lekar lekar)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = (lekar.ID == -1)
                ? "INSERT INTO lekari (kod,titul,jmeno,prijmeni,email,tel) VALUES (@kod,@titul,@jmeno,@prijmeni,@email, @tel);"
                : "UPDATE lekari SET titul = @titul, jmeno = @jmeno, prijmeni = @prijmeni, email = @email, tel = @tel WHERE id = @id;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                Random r = new Random();

                if (lekar.ID == -1)
                {
                    cmd.Parameters.AddWithValue("@kod", r.Next(999));
                    cmd.Parameters.AddWithValue("@titul", lekar.Title);
                    cmd.Parameters.AddWithValue("@jmeno", lekar.Jmeno);
                    cmd.Parameters.AddWithValue("@prijmeni", lekar.Prijmeni);
                    cmd.Parameters.AddWithValue("@email", lekar.Email);
                    cmd.Parameters.AddWithValue("@tel", lekar.Telefon);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@titul", lekar.Title);
                    cmd.Parameters.AddWithValue("@jmeno", lekar.Jmeno);
                    cmd.Parameters.AddWithValue("@prijmeni", lekar.Prijmeni);
                    cmd.Parameters.AddWithValue("@email", lekar.Email);
                    cmd.Parameters.AddWithValue("@tel", lekar.Telefon);
                    cmd.Parameters.AddWithValue("@id", lekar.ID);
                }

                cmd.ExecuteNonQuery();
            }
        }
        
        /// <summary>
        /// Deletes a doctor record from the database.
        /// </summary>
        /// <param name="lekar">The <see cref="Lekar"/> object to be deleted.</param>
        public static void Delete(Lekar lekar)
        {
            MySqlConnection conn = Database.Instance.GetConnection();
            string query = $"DELETE FROM lekari WHERE id = @id;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", lekar.ID);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Returns a string representation of the doctor.
        /// </summary>
        /// <returns>A formatted string with the doctor's title and name.</returns>
        public override string ToString()
        {
            return $"{Title}. {Jmeno} {Prijmeni}";
        }
    }
}