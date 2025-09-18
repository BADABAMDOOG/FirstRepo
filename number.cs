using System;



namespace Number
{

    class Program
    {
        static void Main()
        {
            int secret = 66;               
            Console.WriteLine("1~100 숫자를 맞혀보세요!");

            while (true)
            {
                Console.Write("입력: ");
                int Num = int.Parse(Console.ReadLine()); 

                if (Num == secret) { Console.WriteLine("정답!"); break; }
                else if (Num < secret) Console.WriteLine("UP! 더 큰 수예요.");
                else Console.WriteLine("DOWN! 더 작은 수예요.");
            }
        }
    }


}





