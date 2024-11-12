using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Cliente
    {
        public int Id {  get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? TipoDoc { get; set; }
        public string? NroDoc { get; set; }
        public string? Documento { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public bool Socio { get; set; }
        public bool FichaMedica { get; set; }
        public DateTime FechaIngreso { get; set; }


        public E_Cliente()
        { }

        public E_Cliente(int id, string nombre, string apellido, string documento, string telefono, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento = documento;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Id = id;

        }


    }
}
