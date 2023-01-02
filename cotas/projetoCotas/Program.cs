// See https://aka.ms/new-console-template for more information
using System;
using projetoCotas.Controllers;
using projetoCotas.Models;

namespace projetoCotas
{
    class Program
    {
        public static void Main(string[] args)
        {
            PainelController painelP = new PainelController();
            painelP.MostrarPainel();
        }
    }
}