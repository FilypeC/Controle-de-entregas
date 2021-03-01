using Controle_de_entregas.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Controle_de_entregas.Infraestrura
{ 
    public class ItensDAO
    {
        public List <Item> ListarItens ()
        {
            var dados = File.ReadAllLines(@"Infraestrutura\Itens.csv");
            var Listas = new List <Item> ();
            for (int I = 0; I < dados.Length; I++)
            {
                var D = dados[I].Split(';');
                var item = new Item();
                item.codigo = Convert.ToInt32( D[0]);
                item.descricao = D[1];
                Listas.Add(item);
            }
            return Listas;
        }
    }



}
