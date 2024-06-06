using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
        public class ProductoElectronico
        {

            public string Nombre;
            public double Precio;
            public string Marca;


            public ProductoElectronico(string nombre, double precio, string marca)
            {
                Nombre = nombre;
                Precio = precio;
                Marca = marca;
            }
        }

        public class Telefono : ProductoElectronico
        {

            public string SistemaOperativo;


            public Telefono(string nombre, double precio, string marca, string sistemaOperativo)
                : base(nombre, precio, marca)
            {
                SistemaOperativo = sistemaOperativo;
            }
        }


        public class Laptop : ProductoElectronico
        {

            public int MemoriaRAM;


            public Laptop(string nombre, double precio, string marca, int memoriaRAM)
                : base(nombre, precio, marca)
            {
                MemoriaRAM = memoriaRAM;
            }
        }


        public class Televisor : ProductoElectronico
        {

            public string Resolucion;

            public Televisor(string nombre, double precio, string marca, string resolucion)
                : base(nombre, precio, marca)
            {
                Resolucion = resolucion;
            }
        }
    }

