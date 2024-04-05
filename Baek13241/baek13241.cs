using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baek13241
{
    class baek13241
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string[] num=input.Split(' ');
            long Answer=1;

            long [] numbers = Array.ConvertAll(num, long.Parse);
            long minvalue=numbers.Min();
            while(true){
                bool found=false;
                for(long i=2;i<=minvalue;i++){
                    if(numbers[0] % i == 0 && numbers[1] % i == 0){
                        numbers[0] = numbers[0]/i;
                        numbers[1] = numbers[1]/i;
                        Answer*=i;
                        found=true;
                        minvalue= numbers.Min();
                        break;
                    }
                }
                if(!found){
                        break;
                    }
            }

            Answer = Answer * numbers[0] * numbers[1];
            Console.WriteLine(Answer);

        }
    }
}