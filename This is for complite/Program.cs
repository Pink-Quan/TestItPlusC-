using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace This_is_for_complite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //fibonachi();
            Bai234();
            Console.ReadKey();
        }
        static void fibonachi()
        {
            Console.Write("Imput 1 number: ");
            int n;
            repeat:
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Pleas, imput right number");
                goto repeat;
            }
            int f1 = 1,f2 = 1,f3 = 0,count=1;
            while(f3<n)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                count++;
            }
            Console.WriteLine("Smallest Fibonachi number larger than your Number: F({0}) = {1}",count,f3);
        }
        static void Bai234()
        {
            //Lion lion1 = new Lion(1, "Simba", true, 34.3f);
            //Lion lion2 = new Lion(2, "Wakaa", true, 29.9f);
            //Deer deer1 = new Deer(3, "Coco", false, 44.6f);
            //Deer deer2 = new Deer(4, "AAAA", false, 34.4f);
            //Deer deer3 = new Deer(5, "BBBB", false, 30.4f);
            //Deer deer4 = new Deer(6, "CCCC", false, 24.5f);
            //Deer deer5 = new Deer(7, "DDDD", false, 29.9f);
            //Deer deer6 = new Deer(8, "EEEE", false, 34.4f);
            //Deer deer8 = new Deer(10, "FFFF", false, 30.4f);
            //Deer deer9 = new Deer(11, "GGGG", false, 24.5f);
            //Deer deer10 = new Deer(12, "IIII", false, 29.9f);
            List<Lion> lLion = new List<Lion>(2);
            List<Deer> lDeer = new List<Deer>(10);
            for (int i=0;i<2;i++) //khởi tạo sư tử
            {
                Lion lion = new Lion(i, $"Lion{i+1}", true, 24.5f+i*10);
                lLion.Add(lion);
            }
            for (int i = 0; i < 10; i++) //khởi tạo hươu
            {
                Deer deer = new Deer(i, $"Deer{i + 1}", false, 29.5f + i);
                lDeer.Add(deer);
            }
            bool check = false;
            for(int i=0;i<lDeer.Count;i++) //các hành động săn mồi
            {
                if(check)
                {
                    i--;
                    check = false;
                }    
                if (lLion[0].velocity > lDeer[i].velocity && lLion[0].velocity * 1.1 > lDeer[i].velocity)
                {
                    Console.WriteLine(lLion[0].eat($"{lDeer[i].name}"));
                    lDeer.RemoveAt(i);j
                    check = true;
                }
                else 
                {
                    Console.WriteLine($"{lLion[0].name} can not catch {lDeer[i].name}");
                }
                if (lLion[1].velocity > lDeer[i].velocity && lLion[1].velocity * 1.1 > lDeer[i].velocity)
                {
                    Console.WriteLine(lLion[1].eat($"{lDeer[i].name}"));
                    lDeer.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine($"{lLion[1].name} can not catch {lDeer[i].name}");
                }
            }    
        }
    }
}