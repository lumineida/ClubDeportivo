using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Cuota
    {
        public int Id { get; set; }
        public int IdSocio { get; set; }
        public decimal Monto { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public string NombreSocio { get; set; }
        public string ApellidoSocio { get; set; }
        public string TelefonoSocio { get; set; }


        public bool EsCuotaImpaga()
        {
            return !FechaPago.HasValue && FechaVencimiento <= DateTime.Now;
        }
    }
}
