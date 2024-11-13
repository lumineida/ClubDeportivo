﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    public class Conexion 
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() {

            bool correcto = false;
            int mensaje;

            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";


            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese clave", "DATOS DE INSTALACIÓN MySQL");


                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
                            T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
                            T_usuario + " CLAVE: " + T_clave,
                        "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (mensaje != 6) 
                        {
                            MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                            correcto = false;
                        }
                        else
                        {
                            correcto = true;
                        }
            }

            this.baseDatos = "Club";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave; // "";

        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}

