// See https://aka.ms/new-console-template for more information
using System;
using projetoCotas.Models;

namespace projetoCotas
{
    class Program
    {
        public static void Main(string[] args)
        {
            //caminho do arquivo a ser lido
            var path = @"C:\TOA\IMPORT_BUZIOS.csv";

            //acessar arquivo
            var reader = new StreamReader(File.OpenRead(path));

            //ler a 1a linha do arquivo (onde estarão titulos dos atributos)
            var line = reader.ReadLine();

            //separa os itens das colunas com um  ','
            var columns = line.Split(';');
            

            //atributos referenciados no metodo Set Columns Index
            (int indexCidade, int indexCategoria, int indexJanela, int indexSegmento, int indexData, int indexCota, int indexAtReservada, int indexUsado, int indexData2, int indexCota2, int indexAtReservada2, int indexUsado2, int indexData3, int indexCota3, int indexAtReservada3, int indexUsado3, int indexData4, int indexCota4, int indexAtReservada4, int indexUsado4, int indexData5, int indexCota5, int indexAtReservada5, int indexUsado5, int indexData6, int indexCota6, int indexAtReservada6, int indexUsado6, int indexData7, int indexCota7, int indexAtReservada7, int indexUsado7) = SetColumnsIndex(columns);

            var painel = BuildPainelList(reader, indexCidade, indexCategoria, indexJanela, indexSegmento, indexData, indexCota, indexAtReservada, indexUsado, indexData2, indexCota2, indexAtReservada2, indexUsado2, indexData3, indexCota3, indexAtReservada3, indexUsado3, indexData4, indexCota4, indexAtReservada4, indexUsado4, indexData5, indexCota5, indexAtReservada5, indexUsado5, indexData6, indexCota6, indexAtReservada6, indexUsado6, indexData7, indexCota7, indexAtReservada7, indexUsado7);

            foreach (var item in painel)
            {
                Console.WriteLine($"Cidade:                  {item.cidade}");
                Console.WriteLine($"Categoria:               {item.categoriasDaCap}");
                Console.WriteLine($"Janela:                  {item.janela}");
                Console.WriteLine($"Segmento:                {item.segmento}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data1:                   {item.data}");
                Console.WriteLine($"Cota:                    {item.cota}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas}");
                Console.WriteLine($"Usado:                   {item.usado}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data2:                   {item.data2}");
                Console.WriteLine($"Cota:                    {item.cota2}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas2}");
                Console.WriteLine($"Usado:                   {item.usado2}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data3:                   {item.data3}");
                Console.WriteLine($"Cota:                    {item.cota3}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas3}");
                Console.WriteLine($"Usado:                   {item.usado3}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data4:                   {item.data4}");
                Console.WriteLine($"Cota:                    {item.cota4}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas4}");
                Console.WriteLine($"Usado:                   {item.usado4}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data5:                   {item.data5}");
                Console.WriteLine($"Cota:                    {item.cota5}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas5}");
                Console.WriteLine($"Usado:                   {item.usado5}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data6:                   {item.data6}");
                Console.WriteLine($"Cota:                    {item.cota6}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas6}");
                Console.WriteLine($"Usado:                   {item.usado6}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Data7:                   {item.data7}");
                Console.WriteLine($"Cota:                    {item.cota7}");
                Console.WriteLine($"Atividades Reservadas:   {item.atividadesReservadas7}");
                Console.WriteLine($"Usado:                   {item.usado7}");
                Console.WriteLine("----------------------------------------");               

            }
        }

        private static (int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int) SetColumnsIndex(string[] columns)
        {
            //Retornando valores
            //Titulo teste
            Console.WriteLine("PAINEL COTAS");

            int indexCidade           = -1;
            int indexCategoria        = -1;
            int indexJanela           = -1;
            int indexSegmento         = -1;

            int indexData             = -1;
            int indexCota             = -1;
            int indexAtReservada      = -1;
            int indexUsado            = -1;

            int indexData2            = -1;
            int indexCota2            = -1;
            int indexAtReservada2     = -1;
            int indexUsado2           = -1;
            
            int indexData3            = -1;
            int indexCota3            = -1;
            int indexAtReservada3     = -1;
            int indexUsado3           = -1;
            
            int indexData4            = -1;
            int indexCota4            = -1;
            int indexAtReservada4     = -1;
            int indexUsado4           = -1;

            int indexData5            = -1;
            int indexCota5            = -1;
            int indexAtReservada5     = -1;
            int indexUsado5           = -1;

            int indexData6            = -1;
            int indexCota6            = -1;
            int indexAtReservada6     = -1;
            int indexUsado6           = -1;

            int indexData7            = -1;
            int indexCota7            = -1;
            int indexAtReservada7     = -1;
            int indexUsado7           = -1;


            for (int i = 0; i < columns.Length; i++)
            {
                if(!string.IsNullOrEmpty(columns[i]))
                    continue;
                if(columns[i].ToLower() == "CIDADE")
                    {
                        indexCidade = i;
                        Console.WriteLine($"Cidade: {indexCidade}");
                    }

                if(columns[i].ToLower() == "Categorias da capacidade")
                    {
                        indexCategoria= i;
                        Console.WriteLine($"Categorias da capacidade: {indexCategoria}");
                    }

                if(columns[i].ToLower() == "JANELA")
                    {
                        indexJanela= i;
                        Console.WriteLine($"JANELA: {indexJanela}");
                    }
                
                if(columns[i].ToLower() == "SEGMENTO")
                    {
                        indexSegmento= i;
                        Console.WriteLine($"SEGMENTO: {indexSegmento}");
                    }

                //semana
                //DIA 1
                if(columns[i].ToLower() == "DATA_1")
                    {
                        indexData= i;
                        Console.WriteLine($"DATA_1: {indexData}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota= i;
                        Console.WriteLine($"Cota: {indexCota}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado= i;
                        Console.WriteLine($"Usado: {indexUsado}");
                    }
                //FIM DIA 1

                //===============================================================================================================

                //DIA 2
                if(columns[i].ToLower() == "DATA2")
                    {
                        indexData2= i;
                        Console.WriteLine($"DATA2: {indexData2}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota2= i;
                        Console.WriteLine($"Cota: {indexCota2}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada2= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada2}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado2= i;
                        Console.WriteLine($"Usado: {indexUsado2}");
                    }

                //FIM DIA 2

                //====================================================================================================================

                //DIA 3

                if(columns[i].ToLower() == "DATA3")
                    {
                        indexData3= i;
                        Console.WriteLine($"DAT3: {indexData3}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota3= i;
                        Console.WriteLine($"Cota: {indexCota2}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada3= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada3}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado3= i;
                        Console.WriteLine($"Usado: {indexUsado3}");
                    }

                //FIM DIA 3

                //====================================================================================================================
            
                //DIA 4
                if(columns[i].ToLower() == "DATA4")
                    {
                        indexData4= i;
                        Console.WriteLine($"DAT4: {indexData4}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota4= i;
                        Console.WriteLine($"Cota: {indexCota4}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada4= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada4}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado4= i;
                        Console.WriteLine($"Usado: {indexUsado4}");
                    }

                //FIM DIA 4

                //====================================================================================================================

                //DIA 5
                if(columns[i].ToLower() == "DATA5")
                    {
                        indexData5= i;
                        Console.WriteLine($"DAT5: {indexData5}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota5= i;
                        Console.WriteLine($"Cota: {indexCota5}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada5= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada5}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado5= i;
                        Console.WriteLine($"Usado: {indexUsado5}");
                    }

                //FIM DIA 5

                //====================================================================================================================

                //DIA 6
                if(columns[i].ToLower() == "DATA6")
                    {
                        indexData6= i;
                        Console.WriteLine($"DAT6: {indexData6}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota6= i;
                        Console.WriteLine($"Cota: {indexCota6}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada6= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada6}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado6= i;
                        Console.WriteLine($"Usado: {indexUsado6}");
                    }

                //FIM DIA 3

                //====================================================================================================================

                //DIA 7
                if(columns[i].ToLower() == "DATA7")
                    {
                        indexData7= i;
                        Console.WriteLine($"DAT7: {indexData7}");
                    }

                if(columns[i].ToLower() == "Cota")
                    {
                        indexCota7= i;
                        Console.WriteLine($"Cota: {indexCota7}");
                    }

                if(columns[i].ToLower() == "Atividades Reservadas")
                    {
                        indexAtReservada7= i;
                        Console.WriteLine($"Atividades Reservadas: {indexAtReservada7}");
                    }

                if(columns[i].ToLower() == "Usado")
                    {
                        indexUsado7= i;
                        Console.WriteLine($"Usado: {indexUsado7}");
                    }

                //FIM DIA 7

                //====================================================================================================================

            }
                return(indexCidade, indexCategoria, indexJanela, indexSegmento, indexData, indexCota, indexAtReservada, indexUsado, indexData2, indexCota2, indexAtReservada2, indexUsado2, indexData3, indexCota3, indexAtReservada3, indexUsado3, indexData4, indexCota4, indexAtReservada4, indexUsado4, indexData5, indexCota5, indexAtReservada5, indexUsado5, indexData6, indexCota6, indexAtReservada6, indexUsado6, indexData7, indexCota7, indexAtReservada7, indexUsado7);
        }


        private static List<Painel> BuildPainelList(StreamReader reader, int indexCidade, int indexCategoria, int indexJanela, int indexSegmento, int indexData, int indexCota, int indexAtReservada, int indexUsado, int indexData2, int indexCota2, int indexAtReservada2, int indexUsado2, int indexData3, int indexCota3, int indexAtReservada3, int indexUsado3, int indexData4, int indexCota4, int indexAtReservada4, int indexUsado4, int indexData5, int indexCota5, int indexAtReservada5, int indexUsado5, int indexData6, int indexCota6, int indexAtReservada6, int indexUsado6, int indexData7, int indexCota7, int indexAtReservada7, int indexUsado7)
        {
            Console.WriteLine("Montando Painel");
            string line;
            var painel = new List<Painel>();

            Painel painelModel;

            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                painelModel = new Painel();

                if (indexCidade != -1)
                {
                    painelModel.cidade = values[indexCidade];
                }

                if (indexCategoria != -1)
                {
                    painelModel.categoriasDaCap = values[indexCategoria];   
                }

                if (indexJanela != -1)
                {
                    painelModel.janela = values[indexJanela];   
                }

                if (indexSegmento != -1)
                {
                    painelModel.segmento = values[indexSegmento];   
                }

                //SEMANA
                //DIA 1
                if (indexData != -1)
                {
                    painelModel.data = values[indexData];   
                }

                if (indexCota != -1)
                {
                    painelModel.cota = Int32.Parse(values[indexCota]) ;
                }

                if (indexAtReservada != -1)
                {
                    painelModel.atividadesReservadas = Int32.Parse(values[indexAtReservada]) ;
                }

                if (indexUsado != 0)
                {
                    painelModel.usado = Int32.Parse(values[indexUsado]) ;
                }

                //FIM DIA 1
                //===================================================================================================

                //DIA 12
                if (indexData2 != -1)
                {
                    painelModel.data2 = values[indexData2];   
                }

                if (indexCota2 != -1)
                {
                    painelModel.cota2 = Int32.Parse(values[indexCota2]) ;
                }

                if (indexAtReservada2 != -1)
                {
                    painelModel.atividadesReservadas2 = Int32.Parse(values[indexAtReservada2]) ;
                }

                if (indexUsado2 != 0)
                {
                    painelModel.usado2 = Int32.Parse(values[indexUsado2]) ;
                }

                //FIM DIA 2
                //===================================================================================================

                //DIA 3
                if (indexData3 != -1)
                {
                    painelModel.data3 = values[indexData3];   
                }

                if (indexCota3 != -1)
                {
                    painelModel.cota3 = Int32.Parse(values[indexCota3]) ;
                }

                if (indexAtReservada3 != -1)
                {
                    painelModel.atividadesReservadas3 = Int32.Parse(values[indexAtReservada3]) ;
                }

                if (indexUsado3 != 0)
                {
                    painelModel.usado3 = Int32.Parse(values[indexUsado3]) ;
                }

                //FIM DIA 3
                //===================================================================================================

                //DIA 4
                if (indexData4 != -1)
                {
                    painelModel.data4 = values[indexData4];   
                }

                if (indexCota4 != -1)
                {
                    painelModel.cota4 = Int32.Parse(values[indexCota4]) ;
                }

                if (indexAtReservada4 != -1)
                {
                    painelModel.atividadesReservadas4 = Int32.Parse(values[indexAtReservada4]) ;
                }

                if (indexUsado4 != 0)
                {
                    painelModel.usado4 = Int32.Parse(values[indexUsado4]) ;
                }

                //FIM DIA 4
                //===================================================================================================

                //DIA 5
                if (indexData5 != -1)
                {
                    painelModel.data5 = values[indexData5];   
                }

                if (indexCota5 != -1)
                {
                    painelModel.cota5 = Int32.Parse(values[indexCota5]) ;
                }

                if (indexAtReservada5 != -1)
                {
                    painelModel.atividadesReservadas5 = Int32.Parse(values[indexAtReservada5]) ;
                }

                if (indexUsado5 != 0)
                {
                    painelModel.usado5 = Int32.Parse(values[indexUsado5]) ;
                }

                //FIM DIA 5
                //===================================================================================================

                //DIA 6
                if (indexData6 != -1)
                {
                    painelModel.data6 = values[indexData6];   
                }

                if (indexCota6 != -1)
                {
                    painelModel.cota6 = Int32.Parse(values[indexCota6]) ;
                }

                if (indexAtReservada6 != -1)
                {
                    painelModel.atividadesReservadas6 = Int32.Parse(values[indexAtReservada6]) ;
                }

                if (indexUsado6 != 0)
                {
                    painelModel.usado6 = Int32.Parse(values[indexUsado6]) ;
                }

                //FIM DIA 6
                //===================================================================================================

                //DIA 7
                if (indexData7 != -1)
                {
                    painelModel.data7 = values[indexData7];   
                }

                if (indexCota7 != -1)
                {
                    painelModel.cota7 = Int32.Parse(values[indexCota7]) ;
                }

                if (indexAtReservada7 != -1)
                {
                    painelModel.atividadesReservadas7 = Int32.Parse(values[indexAtReservada7]) ;
                }

                if (indexUsado7 != 0)
                {
                    painelModel.usado7 = Int32.Parse(values[indexUsado7]) ;
                }

                //FIM DIA 7
                //===================================================================================================

                painel.Add(painelModel);
            }

            return painel;
        }

    }
}