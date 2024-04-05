internal class Baek1037
{
    private static void Main(string[] args)
    {
        string input=Console.ReadLine();
        int N = int.Parse(input);
        int cnt=0;
        int mult=2;
        int maxnumcnt;
        string yn=Console.ReadLine();
        string[] num=yn.Split(' ');
        int [] numbers = Array.ConvertAll(num, int.Parse);

        int Maxnum=numbers.Max();
        while(true){
                maxnumcnt=-2;

            for(int i =1; i<= Maxnum*mult; i++){
                if((Maxnum*mult)%i == 0){
                    maxnumcnt++;
                }
            }
            for(int i=0; i<N; i++){
                if(Maxnum*mult % numbers[i] == 0){
                    cnt++;
                }
            }
            if(cnt == maxnumcnt){
                Console.WriteLine(Maxnum*mult);
                break;
            }
            else{
                mult++;
                cnt=0;
            }
        }

    }
}