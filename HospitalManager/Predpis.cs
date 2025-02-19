using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManager;

/// <summary>
/// Represents a prescription issued by a doctor to a patient.
/// </summary>
public class Predpis
{
    /// <summary>
    /// Gets or sets the unique identifier for the prescription.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the doctor who issued the prescription.
    /// </summary>
    public Lekar Lekar { get; set; }

    /// <summary>
    /// Gets or sets the patient for whom the prescription is issued.
    /// </summary>
    public Pacient Pacient { get; set; }

    /// <summary>
    /// Gets or sets the medication prescribed.
    /// </summary>
    public Lek Lek { get; set; }

    /// <summary>
    /// Gets or sets the daily dosage of the medication.
    /// </summary>
    public int Davka { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Predpis"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the prescription.</param>
    /// <param name="lekar">The doctor who issued the prescription.</param>
    /// <param name="pacient">The patient for whom the prescription is issued.</param>
    /// <param name="lek">The medication prescribed.</param>
    /// <param name="davka">The daily dosage of the medication.</param>
    public Predpis(int id, Lekar lekar, Pacient pacient, Lek lek, int davka)
    {
        ID = id;
        Lekar = lekar;
        Pacient = pacient;
        Lek = lek;
        Davka = davka;
    }

    /// <summary>
    /// Retrieves all prescriptions for a given patient from the database.
    /// </summary>
    /// <param name="pacient">The patient whose prescriptions are to be retrieved.</param>
    /// <returns>A list of prescriptions associated with the specified patient.</returns>
    public static List<Predpis> GetAll(Pacient pacient)
    {
        MySqlConnection conn = Database.Instance.GetConnection();
        List<Predpis> predpisy = new List<Predpis>();

        string query = "SELECT * FROM predpisy p JOIN leky l ON p.id_lek = l.id JOIN lekari le ON p.id_lekar = le.id WHERE p.id_pac = @id;";
        using (MySqlCommand cmd = new MySqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@id", pacient.ID);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Medication prescribed.
                    Lek lek = new Lek(
                        reader.GetInt32(5),
                        reader.GetString(6),
                        reader.GetFloat(7),
                        reader.GetString(8),
                        reader.GetString(9)
                    );

                    // Doctor who issued the prescription.
                    Lekar lekar = new Lekar(
                        reader.GetInt32(10),
                        reader.GetInt32(11),
                        reader.GetString(12),
                        reader.GetString(13),
                        reader.GetString(14),
                        reader.GetString(15),
                        reader.GetInt32(16)
                    );

                    predpisy.Add(new Predpis(
                        reader.GetInt32(0),
                        lekar,
                        pacient,
                        lek,
                        reader.GetInt32(4)
                    ));
                }
            }

            return predpisy;
        }
    }

    /// <summary>
    /// Submits a new prescription to the database.
    /// </summary>
    /// <param name="predpis">The prescription to be added to the database.</param>
    public static void Submit(Predpis predpis)
    {
        MySqlConnection conn = Database.Instance.GetConnection();
        string query = "INSERT INTO predpisy (id_lekar,id_lek,id_pac,davka_den) VALUES (@id_lekar,@id_lek,@id_pac,@davka_den);";
        using (MySqlCommand cmd = new MySqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@id_lekar", predpis.Lekar.ID);
            cmd.Parameters.AddWithValue("@id_lek", predpis.Lek.ID);
            cmd.Parameters.AddWithValue("@id_pac", predpis.Pacient.ID);
            cmd.Parameters.AddWithValue("@davka_den", predpis.Davka);

            cmd.ExecuteNonQuery();
        }
    }
}
