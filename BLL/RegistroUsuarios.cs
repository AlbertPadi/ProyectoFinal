﻿using System;
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
        public int  Telefono { get; set; }
        public string Direccion { get; set; }
        public string  FechaNacimiento { get; set; }
        public int Cedula { get; set; }
        public string Clave { get; set; }


        public RegistroUsuarios()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Telefono = 0;
            this.Direccion = "";
            this.FechaNacimiento = "";
            this.Cedula = 0;
            this.Clave = "";
        }
        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}