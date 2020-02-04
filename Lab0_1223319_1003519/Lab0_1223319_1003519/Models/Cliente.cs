using System;
using Lab0_1223319_1003519.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab0_1223319_1003519.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Descripcion { get; set; }

        public bool Save()
        {
            try
            {
                Storage.Instance.clienteList.Add(this);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}