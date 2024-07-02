using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDateTime
{
    public static class ExercicioDateTime
    {
        public static void CalcularIdade()
        {
            Console.WriteLine("Digite sua data de nacimento");
            string data = Console.ReadLine();
            DateTime data2 = DateTime.Parse(data);

            int idade = DateTime.Now.Year - data2.Year;

            if (DateTime.Now.Month < data2.Month)
            {
                idade = idade - 1;
            }
            else if (DateTime.Now.Month == data2.Month
                 && DateTime.Now.Day < data2.Day)
            {
                idade = idade - 1;
            }

            Console.WriteLine(idade);
        }

        public static void VerificaAniversario()
        {
            Console.WriteLine("Digite sua data de nacimento");
            string data = Console.ReadLine();
            DateTime data2 = DateTime.Parse(data);

            if(data2.Month == DateTime.Now.Month
               && data2.Day == DateTime.Now.Day){
                Console.WriteLine("Parabéns é seu aniversário!!");
            }
            else
            {
                Console.WriteLine("Não é seu aniversário!!");
            }
        }
        public static void FormatarDataHora()
        {
            Console.WriteLine("Digite sua data de nacimento");
            string data = Console.ReadLine();
            DateTime data2 = DateTime.Parse(data);
            Console.WriteLine(data2.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
