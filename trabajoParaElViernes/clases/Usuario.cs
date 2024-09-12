using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoParaElViernes.clases
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }
        public bool EsClienteRegistrado(List<Usuario> usuariosRegistrados)
        {
            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.Nombre == this.Nombre && usuario.Contraseña == this.Contraseña)
                {
                    return true;

                }
            }
            return false;
        }
    }
}
