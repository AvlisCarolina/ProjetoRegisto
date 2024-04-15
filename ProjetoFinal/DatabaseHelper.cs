﻿using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class DatabaseHelper
{
    public static string connectionString = @"Data Source =..\..\Files\psicoproject.db;Version=3;";

    public static void InicializeDatabase()
    {
        if (!File.Exists(@"..\..\Files\psicoproject.db"))
        {
            SQLiteConnection.CreateFile(@"..\..\Files\psicoproject.db");

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Database Tables

                string createRolesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS acessos (
                        idAcesso INTEGER PRIMARY KEY AUTOINCREMENT,
                        nivelAcesso TEXT UNIQUE NOT NULL
                    );";


                string createUsersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS utilizadores (
                        idUtilizador INTEGER PRIMARY KEY AUTOINCREMENT,
                        email TEXT UNIQUE NOT NULL,
                        userName TEXT UNIQUE NOT NULL,
                        password TEXT NOT NULL,
                        idAcesso INTEGER NOT NULL,
                        CONSTRAINT fk_acessos
                            FOREIGN KEY (idAcesso) REFERENCES acessos(idAcesso)
                    );";

                string createDoctorTableQuery = @"
                    CREATE TABLE IF NOT EXISTS terapeutas (
                        idTerapeuta INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL,
                        especializacao TEXT NOT NULL,
                        telefone TEXT NOT NULL,
                        apresentacao TEXT,
                        idUtilizador INTEGER, 
                        CONSTRAINT fk_users
                            FOREIGN KEY (idUtilizador) REFERENCES utilizadores(idUtilizador) ON DELETE CASCADE
                    );";

                string createPacientTableQuery = @"
                    CREATE TABLE IF NOT EXISTS pacientes (
                        idPaciente INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL,
                        genero TEXT NOT NULL,
                        dataNascimento TEXT NOT NULL,
                        telefone TEXT NOT NULL,
                        idUtilizador INTEGER, 
                        idTerapeuta INTEGER, 
                        CONSTRAINT fk_utilizadores
                            FOREIGN KEY (idUtilizador) REFERENCES utilizadores(idUtilizador) ON DELETE CASCADE,
                        CONSTRAINT fk_terapeutas
                            FOREIGN KEY (idTerapeuta) REFERENCES terapeutas(idTerapeuta)
                    );";

                string createSensesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS sensacoes (
                        idSensacao INTEGER PRIMARY KEY AUTOINCREMENT,
                        descricao TEXT UNIQUE NOT NULL
                    );";

                string createFellingsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS sentimentos (
                        idSentimento INTEGER PRIMARY KEY AUTOINCREMENT,
                        descricao TEXT UNIQUE NOT NULL
                    );";

                string createCriseTableQuery = @"
                    CREATE TABLE IF NOT EXISTS crises (
                        idCrise INTEGER PRIMARY KEY AUTOINCREMENT,
                        dataHora TEXT NOT NULL,
                        duracaoCrise TEXT,
                        nivelAnsiedade INTEGER NOT NULL,
                        nivelDepressao INTEGER NOT NULL,
                        descricaoSituacao TEXT,
                        pensamentosImagens TEXT,
                        idPaciente INTEGER NOT NULL,
                        CONSTRAINT fk_pacientes
                            FOREIGN KEY (idPaciente) REFERENCES pacientes(idPaciente)
                        );";

                string createCriseSencesListTableQuery = @"
                    CREATE TABLE IF NOT EXISTS criseListaSensacoes (
                        idCrise INTEGER NOT NULL,
                        idSensacao INTEGER NOT NULL,
                        CONSTRAINT fk_idCrise
                           FOREIGN KEY (idCrise) REFERENCES crises(idCrise),
                        CONSTRAINT fk_idSensacao
                           FOREIGN KEY (idSensacao) REFERENCES sensacoes(idSensacao)
                        );";

                string createCriseFelingsListTableQuery = @"
                    CREATE TABLE IF NOT EXISTS criseListaSentimentos (
                        idCrise INTEGER NOT NULL,
                        idSentimento INTEGER NOT NULL,
                        CONSTRAINT fk_idCrise
                           FOREIGN KEY (idCrise) REFERENCES crises(idCrise),
                        CONSTRAINT fk_idSentimento
                           FOREIGN KEY (idSentimento) REFERENCES sentimentos(idSentimento)
                        );";

                string createDiaryTableQuery = @"
                    CREATE TABLE IF NOT EXISTS diario (
                        idDiario INTEGER PRIMARY KEY AUTOINCREMENT,
                        data TEXT NOT NULL,
                        sono TEXT NOT NULL,
                        alimentacao TEXT NOT NULL,
                        atividadeFisica TEXT NOT NULL,
                        convivioSocial TEXT NOT NULL,
                        detalhes TEXT,
                        idCrise INTEGER,
                        idPaciente INTEGER NOT NULL,
                        CONSTRAINT fk_crises
                            FOREIGN KEY (idCrise) REFERENCES crises(idCrise),
                        CONSTRAINT fk_pacientes
                            FOREIGN KEY (idPaciente) REFERENCES pacientes(idPaciente)
                        );";

                string createDiarioSencesListTableQuery = @"
                    CREATE TABLE IF NOT EXISTS DiarioListaSensacoes (
                        idDiario INTEGER NOT NULL,
                        idSensacao INTEGER NOT NULL,
                        CONSTRAINT fk_idDiario
                           FOREIGN KEY (idDiario) REFERENCES diario(idDiario),
                        CONSTRAINT fk_idSensacao
                           FOREIGN KEY (idSensacao) REFERENCES sensacoes(idSensacao)
                        );";

                string createDiarioFelingsListTableQuery = @"
                    CREATE TABLE IF NOT EXISTS DiarioListaSentimentos (
                        idDiario INTEGER NOT NULL,
                        idSentimento INTEGER NOT NULL,
                        CONSTRAINT fk_idDiario
                           FOREIGN KEY (idDiario) REFERENCES diario(idDiario),
                        CONSTRAINT fk_idSentimento
                           FOREIGN KEY (idSentimento) REFERENCES sentimentos(idSentimento)
                        );";

                string insertSensesDataQuery = @"
                    INSERT INTO sensacoes (descricao) VALUES
                        ('Respiração ofegante'),
                        ('Falta de ar'),
                        ('Palpitações'),
                        ('Formigamento'),
                        ('Dormência'),
                        ('Falta de apetite'),
                        ('Suor excessivo'),
                        ('Mãos frias'),
                        ('Ondas de calor'),
                        ('Visão turva'),
                        ('Sensação de engasgo'),
                        ('Dores no peito'),
                        ('Taquicardia'),
                        ('Fala acelerada'),
                        ('Sensação de tremor'),
                        ('Vontade de roer as unhas'),
                        ('Dor de barriga'),
                        ('Dores abdominais'),
                        ('Agitação nas pernas'),
                        ('Agitação nos braços'),
                        ('Tensão muscular'),
                        ('Dores nas costas'),
                        ('Dores nos músculos'),
                        ('Cansaço extremo'),
                        ('Tonturas'),
                        ('Desmaio'),
                        ('Enjoo'),
                        ('Vómitos'),
                        ('Zumbidos no ouvido'),
                        ('Ruídos na cabeça'),
                        ('Dores de cabeça'),
                        ('Boca seca'),
                        ('Dificuldade em respirar'),
                        ('Hipersensibilidade visual'),
                        ('Hipersensibilidade auditiva'),
                        ('Hipersensibilidade de paladar'),
                        ('Hipersensibilidade ao tacto'),
                        ('Hipersensibilidade olfativa');";

                string insertFeelingsDataQuery = @"
                    INSERT INTO sentimentos (descricao) VALUES
                        ('Alegria'),
                        ('Tristeza'),
                        ('Medo'),
                        ('Raiva'),
                        ('Nojo'),
                        ('Desprezo'),
                        ('Surpresa'),
                        ('Melancolia'),
                        ('Gratidão'),
                        ('Amor'),
                        ('Felicidade'),
                        ('Compaixão'),
                        ('Decepção'),
                        ('Curiosidade'),
                        ('Solidão'),
                        ('Culpa'),
                        ('Remorso'),
                        ('Prazer'),
                        ('Irritabilidade'),
                        ('Calma'),
                        ('Aflição'),
                        ('Derrota'),
                        ('Desconforto'),
                        ('Impaciência'),
                        ('Frustração'),
                        ('Infelicidade'),
                        ('Luto'),
                        ('Mágoa'),
                        ('Nostalgia'),
                        ('Pânico'),
                        ('Tédio'),
                        ('Tranquilidade'),
                        ('Vergonha'),
                        ('Repulsa'),
                        ('Ódio'),
                        ('Orgulho'),
                        ('Força'),
                        ('Equilíbrio'),
                        ('Alívio'),
                        ('Entusiasmo'),
                        ('Realização'),
                        ('Paciência'),
                        ('Tolerância'),
                        ('Intolerância');";

                string insertRolesDataQuery = @"
                    INSERT INTO acessos (nivelAcesso) VALUES 
                        ('Administrador'),
                        ('Terapeuta'),
                        ('Paciente');";
                
                // Data inputs for inicial tests
                string insertUsersDataQuery = @"
                    INSERT INTO utilizadores (email,userName,password,idAcesso) VALUES
                        ('ana_silva@admin.pt', 'AdministradorTeste', '1234', 1),
                        ('matt_al@terapia.pt', 'Terapeuta1', '4321', 2),
                        ('mari_alice@gmail.pt', 'Paciente1', '1111', 3);";

                string insertTerapeutaDataQuery = @"
                    INSERT INTO terapeutas (nome, telefone, especializacao, apresentacao, idUtilizador) VALUES
                        ('Mattheus Silva', '962333444', 'Psicologia Clínica', 'Terapeuta de renome.', '2');";

                string insertPacienteDataQuery = @"
                    INSERT INTO pacientes (nome, genero, dataNascimento, telefone, idUtilizador, idTerapeuta) VALUES
                        ('Maria Alice', 'Feminino', '01/01/2001', '916542333', '3','1');";




                using (var command = new SQLiteCommand(connection))
                {
                    //Create Tables commands
                    command.CommandText = createRolesTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createUsersTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createDoctorTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createPacientTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createSensesTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createFellingsTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createCriseTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createCriseFelingsListTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createCriseSencesListTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createDiaryTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createDiarioFelingsListTableQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = createDiarioSencesListTableQuery;
                    command.ExecuteNonQuery();

                    //Insert Data commands
                    command.CommandText = insertSensesDataQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = insertFeelingsDataQuery;
                    command.ExecuteNonQuery();
                    
                    command.CommandText = insertRolesDataQuery;
                    command.ExecuteNonQuery();
                    
                    //Insert query for test
                    command.CommandText = insertUsersDataQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = insertTerapeutaDataQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = insertPacienteDataQuery;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

