using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamblergame
{
    public class Gambling
    {
        int money = 100;
        int betAmount = 1;
        int count = 0;
        int wonCount = 0;
        public void Start()
        {
            Console.WriteLine("The bet Start :-");
            Random ran = new Random();
            int bet = ran.Next(0, 2);
            Console.WriteLine(bet);
            if (bet == 1)
            {
                Console.WriteLine("You Have Won Congratulations :- ");
                money = money + 1;
            }
            else
            {
                Console.WriteLine("Sorry you have Lost :-");
                money = money - 1;
            }

        }
      /*  public static void Main(string[] args)
        {
            Gambling gambler = new Gambling();
            gambler.Start();
        }*/
    }
}
