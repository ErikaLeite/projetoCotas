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

        //semana
        public string? data                   { get; set; }
        public int    cota                    { get; set; }
        public int    atividadesReservadas    { get; set; }
        public int    usado                   { get; set; }


        //DIA 2
        public string? data2                   { get; set; }
        public int    cota2                    { get; set; }
        public int    atividadesReservadas2    { get; set; }
        public int    usado2                   { get; set; }


        //DIA 3
        public string? data3                   { get; set; }
        public int    cota3                    { get; set; }
        public int    atividadesReservadas3    { get; set; }
        public int    usado3                   { get; set; }


        //DIA 4
        public string? data4                   { get; set; }
        public int    cota4                    { get; set; }
        public int    atividadesReservadas4    { get; set; }
        public int    usado4                   { get; set; }


        //DIA 5
        public string? data5                   { get; set; }
        public int    cota5                    { get; set; }
        public int    atividadesReservadas5    { get; set; }
        public int    usado5                   { get; set; }



        //DIA 6
        public string? data6                   { get; set; }
        public int    cota6                    { get; set; }
        public int    atividadesReservadas6    { get; set; }
        public int    usado6                   { get; set; }



        //DIA 7
        public string? data7                   { get; set; }
        public int    cota7                    { get; set; }
        public int    atividadesReservadas7    { get; set; }
        public int    usado7                   { get; set; }

        
    }
}