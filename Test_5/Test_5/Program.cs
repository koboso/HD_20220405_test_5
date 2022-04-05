using System;

class Program{
    static void Main(string[] args){
/*
6. 반복문을 이용하여 아래 별을 출력하세요
        *   *
         * *
          *
         * *
        *   *
*/

        for(int i= 0; i< 5; i++){
            for(int k = 0; k < 5; k++){
                /*
                if (i == k)Console.Write(i + k);
                else if(k+i == 4) Console.Write(i + k);
                else Console.Write(" ");
                */

                if (i == k)
                {
                    Console.Write("*");
                }
                else if((i+k)%2 ==0){
                    if((i + k) == 6){
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }


    }
}
