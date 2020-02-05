using System;
using Lab0_1223319_1003519.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab0_1223319_1003519.Helpers
{
    public class MetododeOrdenamiento
    {

        public  List<Cliente> OrdenarNombre(List<Cliente> p1){
            bool swap = true;
            string temp ;
            int tel;
            while (swap)
            {

                swap = false;

                for (int i = 0; i < p1.Count - 1; i++)
                {
                    if (p1[i].Nombre.ToLower().CompareTo(p1[i + 1].Nombre.ToLower())>0)
                    {
                        
                        temp = p1[i].Nombre;
                        p1[i].Nombre = p1[i + 1].Nombre;
                        p1[i + 1].Nombre = temp;

                        temp = p1[i].Apellido;
                        p1[i]. Apellido = p1[i + 1].Apellido;
                        p1[i + 1].Apellido = temp;

                        temp = p1[i].Descripcion;
                        p1[i].Descripcion = p1[i + 1].Descripcion;
                        p1[i + 1].Descripcion = temp;

                        tel = p1[i].Telefono;
                        p1[i].Telefono = p1[i + 1].Telefono;
                        p1[i + 1].Telefono = tel;


                        swap = true;
                    }
                }
            }
            return  p1;
        }

        public List<Cliente> OrdenarApe(List<Cliente> p1)
        {
            bool swap = true;
            string temp;
            int tel;
            while (swap)
            {

                swap = false;

                for (int i = 0; i < p1.Count - 1; i++)
                {
                    if (p1[i].Apellido.ToLower().CompareTo(p1[i + 1].Apellido.ToLower()) > 0)
                    {

                        temp = p1[i].Nombre;
                        p1[i].Nombre = p1[i + 1].Nombre;
                        p1[i + 1].Nombre = temp;

                        temp = p1[i].Apellido;
                        p1[i].Apellido = p1[i + 1].Apellido;
                        p1[i + 1].Apellido = temp;

                        temp = p1[i].Descripcion;
                        p1[i].Descripcion = p1[i + 1].Descripcion;
                        p1[i + 1].Descripcion = temp;

                        tel = p1[i].Telefono;
                        p1[i].Telefono = p1[i + 1].Telefono;
                        p1[i + 1].Telefono = tel;


                        swap = true;
                    }
                }
            }
            return p1;
        }


    }
}