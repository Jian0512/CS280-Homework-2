using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Console.WriteLine("請輸入一隻Pokemon");

            Console.Write("請輸入Pokemon的名稱:");
            try
            {
                pokemon.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入文字。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Pokemon的編號:");
            try
            {
                pokemon.Number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入數字。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的身高:");
            try
            {
                pokemon.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入數字。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Pokemon的重量:");
            try
            {
                pokemon.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入數字。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Pokemon的類別:");
            {
                pokemon.Category = Console.ReadLine();
            }

            Console.Write("請輸入Pokemon的技能:");
            {
                pokemon.Abilities = Console.ReadLine();
            }

            Console.Write("請輸入Pokemon的性別:");
            {
                pokemon.Gender = Console.ReadLine();
            }

            Console.WriteLine("\n你所輸入的Pokemon資料: ");
            Console.WriteLine(
                "編號:{0},\r\n名稱:{1},\r\n身高:{2},\r\n重量:{3},\r\n類別:{4},\r\n技能:{5},\r\n性別:{6}", pokemon.Number, pokemon.Name, pokemon.Height, pokemon.Weight, pokemon.Category, pokemon.Abilities, pokemon.Gender);
        }
    }
}