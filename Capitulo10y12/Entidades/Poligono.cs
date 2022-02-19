using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo10y12.Entidades
{
    public class Poligono
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public int LadoD { get; set; }
        public int LadoE { get; set; }

        public Poligono(int ladoA, int ladoB, int ladoC, int ladoD, int ladoE)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
            this.LadoD = ladoD;
            this.LadoE = ladoE;
        }

        public Poligono(int ladoA, int ladoB, int ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        public String ValoresValido(int a, int b, int c)
        {
            if(a <= 0)
            {
                return "El lado A no puede ser menor a 0";
            }
            if (b <= 0)
            {
                return "El lado B no puede ser menor a 0";
            }
            if (c <= 0)
            {
                return "El lado B no puede ser menor a 0";
            }
            return "";
        }

        public override string ToString()
        {
            int resultado = LadoA + LadoB + LadoC;

            return resultado.ToString();
        }
        
    }
}