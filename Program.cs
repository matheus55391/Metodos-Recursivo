using System;
using System.Collections.Generic;

//Matheus Felipe Vieira Santiago

namespace ProjetoAvonale
{
    class Program
    {

        static void Main(string[] args)
        {


            int[] array = { 13, 23, 55, 10, 12 };

            double media = Recursivo.Media(array, array.Length - 1);
            Console.Write("Media: "+media + "\n");


            List<object> lista = new List<object>() { 13, 23, 55};

            List<object> lista2 = Recursivo.InverterLista(lista, new List<object>(), lista.Count - 1);
            string resposta = "";
            foreach (object l in lista2)
            {
                resposta = resposta + "/" + l;
            }
            Console.WriteLine(resposta);
        }

    }


}

