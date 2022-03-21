using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace 練習
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyin;  //user key in 猜的數字
            int guess;  //電腦亂數產生的數字
            int count;  //猜了幾次
            int min;    //猜完數字後的範圍最小值
            int max;    //猜完數字後的範圍最大值

            count = 0;  //初始化猜的次數
            min = 1;
            max = 100;
                
            Random rm = new Random();//建立亂數
            guess = rm.Next(1, 100);
            Console.WriteLine("=====猜數字嚕!!=====");
            Console.WriteLine();
            do
            {
                Console.Write("猜數字範圍 {0} < ? < {1}：", min, max);
                keyin = int.Parse(Console.ReadLine());
               
            if (keyin >= min && keyin < max) //將驗證範圍鎖定在輸入的上下限值內)
            {
                count += 1; //進入猜數字紀錄猜的次數(在正確的範圍內才計數!)
                if (keyin == guess)
                {
                    Console.WriteLine("\n 恭喜你，命中目標!!!答案是{0}，一共猜了{1}次", guess, count);
                    break; //結束迴圈
                }
            else if (keyin > guess)
            {
                     max = keyin; //將錯誤的數字指定給最大值
                     Console.Write("\n 要在小一點唷!");
             }
            else if (keyin < guess)
            {
                      min = keyin; //將錯誤的數字指定給最小值
                      Console.Write("\n 要再大一點唷!");
            }
                      Console.WriteLine(" 你猜了{0}次嚕!!", count);
                      Console.WriteLine();
            }
            else
            {
                      Console.WriteLine("\n 請輸入提示範圍內的數字唷!!");
            }
            }
            while (true); //注意!!指定do...while(true) 是無窮迴圈..(一定要指定break;讓程式跳出)

                Console.Read();
            }
        }
    }