using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace projetoCotas.Models
{
    public class Painel
    {
        //atributos referenciados no arquivo csv gerado pelo Import TOA
        public string? cidade                 { get; set; }
        public string? categoriasDaCap        { get; set; }
        public string? janela                 { get; set; }
        public string? segmento               { get; set; }
        public string? data                   { get; set; }
        public int    cota                   { get; set; }
        public int    atividadesReservadas   { get; set; }
        public int    usado                  { get; set; }

        
        //localização do arquivo no sistema
        private const string PATH = "C:/TOA/IMPORT_TOA_F109172.CSV";/*canminho teste -- tem que alterar*/

        //Metodo construtor fará a verificalção de existencia da pasta
        //utilizando Split para realizar a separação do caminho
        public Painel()
        {
            //declaramos que a pasta está no indice 0 (array) do diretorio
            string pasta = PATH.Split("/")[0];

            //condicional verifica a existencia da pasta, se não, criaremos.
            //utilizar biblioteca Sistem.IO
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //condicional verifica se o arquivo csv existe, se não, o cria
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }

            //TESTE DE PASTAS OK -- NÃO RETORNOU ERRO

        }

        //Metodo de Leituira de dados
        //Lista criada para receber dados a serem manipulados na Views
        public List<Painel> Ler()
        {
            //lista para armazenamento de dados
            List<Painel> painel = new  List<Painel>();

            //coletar as informações contidas no arquivo CSV
            //criar um modo que leia as linhas do arquivo com um array de string
            string[] linhas = File.ReadAllLines(PATH);
            
            //para cada item 'contido' em 'linhas'...
            foreach(string item in linhas)
            {
                //... Separar atributos pela ","
                string[]                atributos = item.Split(",");

                //Criar um 'painelLista' vazio para incluir na lista 'painel' final
                Painel painelLista = new Painel();

                //Linkar prop com atributos do arquivo
                painelLista.cidade                 = atributos[0];
                painelLista.categoriasDaCap        = atributos[1];
                painelLista.janela                 = atributos[2];
                painelLista.segmento               = atributos[3];
                painelLista.data                   = atributos[4];
                painelLista.cota                   = int.Parse(atributos[5]); /* erro de tipo da variavel, sistema informa que é string */
                painelLista.atividadesReservadas   = int.Parse(atributos[6]);
                painelLista.usado                  = int.Parse(atributos[7]);

                //iremos adicionar ao painel o conteudo armazenado no painelLista
                painel.Add(painelLista);

            }

            return painel;
        }
    }
}