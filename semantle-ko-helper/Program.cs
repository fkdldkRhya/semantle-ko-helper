using Moda.Korean.TwitterKoreanProcessorCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semantle_ko_helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("꼬맨틀 단어 메크로");
            Console.WriteLine("=== [ v1.0.0 ]=================================");
            Console.WriteLine("실행 대기 중... (5초)");
            Thread.Sleep(1000);
            Console.WriteLine("실행 대기 중... (4초)");
            Thread.Sleep(1000);
            Console.WriteLine("실행 대기 중... (3초)");
            Thread.Sleep(1000);
            Console.WriteLine("실행 대기 중... (2초)");
            Thread.Sleep(1000);
            Console.WriteLine("실행 대기 중... (1초)");
            Thread.Sleep(1000);
               
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("형태소 분석 및 파일 읽는 중...");

            try
            {
                var tokens = TwitterKoreanProcessorCS.Tokenize(System.IO.File.ReadAllText("dic.txt"));

                Console.WriteLine("===============================================");

                foreach (var token in tokens)
                {
                    try
                    {
                        SendKeys.SendWait(token.Text);
                        SendKeys.SendWait("{Enter}");
                        Console.WriteLine(string.Format("단어 입력 완료 --> {0}", token.Text));
                    }
                    catch (Exception) {}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("===============================================");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("메크로 종료!");
            Console.ReadLine();
        }
    }
}
