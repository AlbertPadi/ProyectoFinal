using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Data;
namespace BLL
{
    public class RegistroUsuarios : ClaseMaestra
    {
        Conexion con = new Conexion();
        public string  Nombre { get; set; }
        public string Apellido { get; set; }
        public string  Telefono { get; set; }
        public string Direccion { get; set; }
        public int sexo { get; set; }
        public string Cedula { get; set; }
        public string Clave { get; set; }


        public RegistroUsuarios()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Telefono = "";
            this.Direccion = "";
          
            this.Cedula = "";
            this.Clave = "";
        }
        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                
            retorno = con.Ejecutar(String.Format("Insert Into RegistroUsuarios(Nombre, Apellido, Telefono, Direccion, Cedula, sexo, Clave) values('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}')", this.Nombre, this.Apellido, this.Telefono, this.Direccion, this.Cedula, this.sexo, this.Clave));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

         public override bool Eliminar()
                {
                    throw new NotImplementedException();
                }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
