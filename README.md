# HospitalManager

A simple hospital management system built with C# and Windows Forms. This application helps manage patient records, doctor visits, and prescriptions with MySQL database integration.

## Features

- **Patient Management:**
  - Add, update, and delete patient information (name, contact details, birthday).
- **Doctor Visits:**
  - Record doctor visits with the corresponding doctor, date, and notes.
- **Prescriptions:**
  - Manage prescriptions by assigning medications to patients.
- **Database Integration:**
  - Store and retrieve data using MySQL database.

## Technologies Used

- C# (Windows Forms)
- MySQL (via MySql.Data library)
- .NET Framework

## Prerequisites

Ensure you have the following installed:

- .NET Framework 4.+
- MySQL Server
- MySql.Data package (for MySQL database connection)

## Installation

1. Clone the repository:

   ```bash
   git clone [https://github.com/yourusername/HospitalManager](https://github.com/JackReaperCZ/HospitalManager.git)
   cd HospitalManager
   ```

2. Set up the MySQL database using the provided schema:

   ```sql
    CREATE DATABASE IF NOT EXISTS hospital;
    USE hospital;

    CREATE TABLE IF NOT EXISTS lekari (
      id INT(11) NOT NULL AUTO_INCREMENT,
      kod INT(11) NOT NULL DEFAULT -1,
      titul VARCHAR(50) NOT NULL,
      jmeno VARCHAR(50) NOT NULL,
      prijmeni VARCHAR(50) NOT NULL,
      email VARCHAR(255) NOT NULL,
      tel INT(9) NOT NULL,
      PRIMARY KEY (id),
      UNIQUE KEY kod (kod)
    ) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    CREATE TABLE IF NOT EXISTS leky (
      id INT(11) NOT NULL AUTO_INCREMENT,
      nazev VARCHAR(255) NOT NULL,
      cena FLOAT(10,2) NOT NULL,
      popis LONGTEXT NOT NULL,
      vyrobce VARCHAR(50) NOT NULL,
      PRIMARY KEY (id)
    ) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    CREATE TABLE IF NOT EXISTS pacienti (
      id INT(11) NOT NULL AUTO_INCREMENT,
      jmeno VARCHAR(50) NOT NULL,
      prijmeni VARCHAR(50) NOT NULL,
      email VARCHAR(255) NOT NULL,
      tel INT(9) NOT NULL,
	    dat_nar DATE NOT NULL,
      PRIMARY KEY (id)
    ) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    CREATE TABLE IF NOT EXISTS navstevy (
      id INT(11) NOT NULL AUTO_INCREMENT,
      id_pac INT(11) NOT NULL,
      id_lek INT(11) NOT NULL,
      dat_nav DATETIME DEFAULT NULL,
      pozn LONGTEXT DEFAULT NULL,
      PRIMARY KEY (id),
      CONSTRAINT FK_navstevy_lekari FOREIGN KEY (id_lek) REFERENCES lekari (id) ON DELETE CASCADE ON UPDATE NO ACTION,
      CONSTRAINT FK_navstevy_pacienti FOREIGN KEY (id_pac) REFERENCES pacienti (id) ON DELETE CASCADE ON UPDATE NO ACTION
    ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    CREATE TABLE IF NOT EXISTS predpisy (
      id INT(11) NOT NULL AUTO_INCREMENT,
      id_lekar INT(11) NOT NULL,
      id_lek INT(11) NOT NULL,
      id_pac INT(11) NOT NULL,
      davka_den INT(11) NOT NULL,
      PRIMARY KEY (id),
      CONSTRAINT FK_predpisy_lekari FOREIGN KEY (id_lekar) REFERENCES lekari (id) ON DELETE CASCADE ON UPDATE NO ACTION,
      CONSTRAINT FK_predpisy_leky FOREIGN KEY (id_lek) REFERENCES leky (id) ON DELETE CASCADE ON UPDATE NO ACTION,
      CONSTRAINT FK_predpisy_pacienti FOREIGN KEY (id_pac) REFERENCES pacienti (id) ON DELETE CASCADE ON UPDATE NO ACTION
    ) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
   ```

3. Update the database connection in the `AppSettings` file.

## Usage

- **Add Patient:** Use the patient form to enter patient details.
- **Add Doctor Visit:** Record doctor visits and link them to patients.
- **Manage Prescriptions:** Assign medications and dosage to patients.
