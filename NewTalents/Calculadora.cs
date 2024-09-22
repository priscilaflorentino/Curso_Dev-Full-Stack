using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> lista;
        private string data;
        
        public Calculadora(string data)
        {
            this.data = data;
            lista = new List<string>();
        }

        public int Somar(int x, int y){
            lista.Insert(0, $"{x}+{y} = {x+y} - Data {data}");
            return x+y;
        }
        public int Subtrair(int x, int y){
            lista.Insert(0, $"{x}-{y} = {x-y} - Data {data}");
            return x-y;
        }
        public int Multiplicar(int x, int y){
            lista.Insert(0, $"{x}*{y} = {x*y} - Data {data}");
            return x*y;
        }
        public float Dividir(int x, int y){
            if (y == 0) {
                throw new DivideByZeroException();
            }
            float resultado = float.Parse(x.ToString()) / float.Parse(y.ToString());
            lista.Insert(0, $"{x}/{y} = {resultado} - Data {data}");
            return resultado;
        }
        public List<string> Historico(){
            int tam = lista.Count;
            if (tam >3){ 
                tam = 3;
                lista.RemoveRange(3, lista.Count - 3);
            }

            return lista.GetRange(0,tam);
        }
    }
}