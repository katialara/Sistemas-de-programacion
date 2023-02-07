using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasProgramacionRFC.Clases
{
    class Persona
    {
        public static string nombre;
        public static string apellidopaterno;
        public static string apellidomaterno;
        public static DateTime fechanacimiento;
        public static string rfc = "";

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidopaterno; }
            set { apellidopaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidomaterno; }
            set { apellidomaterno = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }

        //Método constructor
        public Persona(string nombrePersona,
            string apPaternoPersona,
            string apMaternoPersona,
            DateTime fechaNacimientoPersona)
        {
            this.Nombre = nombrePersona;
            this.ApellidoPaterno = apPaternoPersona;
            this.ApellidoMaterno = apMaternoPersona;
            this.FechaNacimiento = fechaNacimientoPersona;
        }
        
        //Propiedad de solo lectura que regresa el rfc
        public static string RFC
        {
            get
            {
                string digito1 = apellidopaterno.Substring(0, 1);
                char digito2 = apellidopaterno[1];
                string digito3 = apellidomaterno.Substring(0, 1);
                string digito4 = nombre.Substring(0, 1);

                //Si el digito es una Ñ, reemplaza por una X
                if (digito1 == "Ñ")
                {
                    digito1 = "X";
                }
                if (digito2 == 'Ñ')
                {
                    digito2 = 'X';
                }
                //Dígito 2: Toma la primera vocal del primer apellido, si no pone una X
                char[] paterno = apellidopaterno.ToCharArray();
                char[] vocales = { 'A', 'E', 'I', 'O', 'U' };

                int j = 1;
                for (int i = 0; i < vocales.Length; i++)
                {
                    if (vocales[i] == digito2)
                    {
                        digito2 = paterno[j];
                    }
                    j++;
                    while (j < paterno.Length && digito2 != 'A' && digito2 != 'E' && digito2 != 'I' && digito2 != 'O' && digito2 != 'U')
                    {
                        if (vocales[i] == paterno[j])
                        {
                            digito2 = paterno[j];
                        }
                        j++;
                    }
                    j = 0;
                }
                return rfc = digito1 + digito2 + digito3 + digito4 + fechanacimiento.ToString("yyMMdd");                
            }
        }
    }
}
