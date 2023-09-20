using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
namespace Practica.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-017;Database=GestionAlumnoss;Trusted_Connection=True;";
        
        public static List<Alumno> SeleccionarAlumnos()
        {
            List<Alumno> ListaAlumnos;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Alumnos";
                ListaAlumnos = db.Query<Alumno>(sql).ToList();
            }
            return ListaAlumnos;
        }
    
        public static Alumno AlumnoElegido(int id)
        {
            Alumno Elegido = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string SQL = "SELECT * FROM Alumnos WHERE id = @alumno";
                Elegido = db.QueryFirstOrDefault<Alumno>(SQL, new { Alumno= id });
            }
            return Elegido;
        }
        public static List<Alumno> SeleccionarAlumnosConMenorASeis()
        {
            List<Alumno> ListaAlumnos;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Alumnos WHERE promedio < 6";
                ListaAlumnos = db.Query<Alumno>(sql).ToList();
            }
            return ListaAlumnos;
        }
        public static List<Alumno> SeleccionarAlumnosConMayorASeis()
        {
            List<Alumno> ListaAlumnos;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Alumnos WHERE promedio >= 6";
                ListaAlumnos = db.Query<Alumno>(sql).ToList();
            }
            return ListaAlumnos;
        }
    }
}