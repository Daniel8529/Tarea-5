using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo10y12.Entidades
{
    public class Escuela
    {
       public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }

        public Escuela(int matricula, string nombre, string apellido, string curso)
        {
            this.Matricula = matricula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Curso = curso;
        }

        
    }
}