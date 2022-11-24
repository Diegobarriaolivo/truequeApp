using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace truequeApp

    internal class Articulo
    {
        int codigo;
        string nombre;


        public Articulo(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        private void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        private void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public override bool Equals(object? obj)
        {
            return obj is Articulo articulo &&
                   codigo == articulo.codigo &&
                   nombre == articulo.nombre &&
                   EqualityComparer<TextWriter>.Default.Equals(archivo, articulo.archivo) &&
                   mensaje == articulo.mensaje;
        }
    }
}
