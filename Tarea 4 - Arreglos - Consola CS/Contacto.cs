using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2___Segundo_Semestre
{
    internal class Contacto : Persona
    {
        private string telefono;
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value.Replace(" ", "").ToLower(); }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }

        public Contacto() : base()
        {
            telefono = string.Empty;
        }
        public Contacto(string nombre, DateTime? fechaNacimiento, string telefono) : base(nombre, fechaNacimiento)
        {
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "---" + " TELEFONO: " + telefono + " " + "---" + " CORREO: " + Correo.ToUpper();
        }
    }
}
