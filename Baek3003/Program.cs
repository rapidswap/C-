using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baek3003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] white_chess=new int[6]{1,1,2,2,2,8};
            int needchess=0;
            string input; 
            input = Console.ReadLine();
            string[] find_chess = input.Split(' ');
            for (int i=0; i<6; i++){
                needchess=(int)white_chess[i] - int.Parse(find_chess[i]);
                Console.Write(needchess+" ");
                needchess=0;
            }

        }
    }
}