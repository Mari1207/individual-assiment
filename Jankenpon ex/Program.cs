using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jankenpon_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer player1 = new Computer();
            Man player2 = new Man();
            Judge judge = new Judge(player1, player2);
            //play 5 matches and compete the win total
            for (int times = 1; times <= 5; times++)
            {
                judge.Game(times);

            }
            judge.Winner();
            Console.Read();
        }
    }
    abstract class Player
    {
        public int wincount;
        public String name;
        public String Name
        {
            get { return name; }
        }
        public Player()
        {
            this.wincount = 0;

        }
        public abstract int ShowHand();
        public void Count()
        {
            wincount++;
        }
        public int WinCount
        {
            get { return wincount; }
        }

    }

    internal class Computer : Player
    {
        public Computer()
        {
            this.name = "Computer";

        }
        public override int ShowHand()
        {

            Random rnd = new Random();
            return rnd.Next(0, 3);
        }
    }
    class Man : Player
    {
        public Man()
        {
            Console.Write("Enter Your Name:");
            this.name = Console.ReadLine();
            if (name == "")
            {
                name = "Unknown";
            }
        }
        public override int ShowHand()
        {
            int n;
            do
            {
                Console.Write(this.name + " Command your hand(0:Rock,1:Scissors,2:Paper):");
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter the Number:");
                    n = -1;

                }
            }
            while (n != 0 && n != 1 && n != 2);
            return n;
        }
    }
    class Judge
    {
        public Player player1;
        public Player player2;
        public Judge(Player p1, Player p2)
        {
            this.player1 = p1;
            this. player2 = p2;
            Console.WriteLine(player1.Name + " vs " + player2.Name + " Start\n");

        }
        public int hand1, hand2;
        public void Game(int n )
        {
            Console.WriteLine("**{0}match**", n);
            hand1 = player1.ShowHand();
            hand2 = player2.ShowHand();
            Judgement(hand1, hand2);
        }
        private void Judgement(int h1, int h2)
        {
            Player winner = player1;
            Console.Write(Hand(h1) + " vs " + Hand(h2) + " =");
            if (h1 == h2)
            {
                Console.WriteLine(winner.Name + " Draw ");
                return;
            }
            else if ((3 + h1 - h2) % 3 == 1)
            {
                winner = player2;
            }
            Console.WriteLine(winner.Name + " Win ");
            winner.Count();




        }
        private string Hand(int h)
        {
            string[] hs = { "Rock", "Scissors", "Paper" };
            return hs[h];
        }
        public void Winner()
        {
            int p1, p2;
            p1 = player1.wincount;
            p2 = player2.WinCount;
            Player finalwinner = player1;
            Console.Write("\n**Result**\n{0}vs{1}=", p1, p2);
            if (p1 == p2)
            {
                Console.WriteLine("Draw");
                return;
            }
            else if (p1 < p2)
            {
                finalwinner = player2;
            }
            Console.WriteLine(finalwinner.Name + " Won");
        }
    }
}
