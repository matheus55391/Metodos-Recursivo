using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvonale
{
    class Recursivo
    {
        public static double Media(int[] nums, int tamanho)
        {
            //Recursivo que imprima a média dos elementos de uma lista de inteiros e o número de elementos maiores do que a média.

            if (tamanho > 0)
            {
                return (double)((double)nums[tamanho] + ((tamanho + 1) - 1) * Media(nums, tamanho - 1)) / (tamanho + 1);
            }
            else
            {
                return (double)nums[0];
            }

        }


        public static List<object> InverterLista(List<object> lista, List<object> listaGenerica, int tamanho)
        {
            //Recursivo que retorne uma lista de forma invertida.
            if (tamanho < 0)
            {
                lista = listaGenerica;

                return lista;
            }
            else
            {
                listaGenerica.Add(lista[tamanho]);
                tamanho--;
                return InverterLista(lista, listaGenerica, tamanho);
            }
        }   
    }
}
