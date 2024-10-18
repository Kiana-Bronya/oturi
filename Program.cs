using System;
using System.Net.Http.Headers;
namespace oturi
{
    class Proguram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("何円のドリンクを買いますか");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("金額をいれてください");
            int b = int.Parse(Console.ReadLine());

            int c = b - a;
            Console.WriteLine("お釣りは{0}です", c);

            int turi500, turi100, turi10;
            turi500 = c / 500;
            c %= 500;
            turi100 = c / 100;
            c %= 100;
            turi10 = c / 10;
            c %= 10;

            Console.WriteLine("500円コインは{0}枚です", turi500);
            Console.WriteLine("100円コインは{0}枚です", turi100);
            Console.WriteLine("10円コインは{0}枚です", turi10);


        }
    }
}