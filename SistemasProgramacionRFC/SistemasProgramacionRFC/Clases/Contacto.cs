using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasProgramacionRFC.Clases
{
    class Contacto : Persona
    {
        private long telefono;
        private string correo;

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        //Método constructor
        public Contacto(string nombrePersona,
                        string apPaternoPersona,
                        string apMaternoPersona,
                        DateTime fechaNacimientoPersona,
                        long telefonoPersona,
                        string correoPersona)
            : base(nombrePersona, apPaternoPersona, apMaternoPersona, fechaNacimientoPersona)
        {
            this.Telefono = telefonoPersona;
            this.Correo = correoPersona;
        }
    }
}
