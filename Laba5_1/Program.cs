using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laba5_1
{
  public class Program
    {
        static void Main(string[] args)
        {


            List<Second> list = new List<Second>();

            using (StreamReader sr = File.OpenText(@"D:\111.txt"))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(new Second(sr.ReadLine()));
                }
            }
 

            while (true) {



                Console.Write("Введiть дiю" + " \n");
                Console.WriteLine("Сортувати 'A'");
                Console.WriteLine("Показати всi данi нажми 'B'");
                Console.WriteLine("Сумарна кiлькiсть вiдвiдувачiв 'C'");
                Console.WriteLine("Пошук за назвою 'D'");
                Console.WriteLine("Видалення 'Delete'");
                Console.WriteLine("Почистити конколь 'Enter'/Назад");

                switch (Console.ReadKey().Key) 
                {
                    case ConsoleKey.A:
                        list.Sort(delegate (Second t1,Second t2)   // sort
                        {
                            return t2.nubmers.CompareTo(t1.nubmers);

                        });

                        foreach (Second el in list)
                        {
                            Console.WriteLine("День з найбiльшою кiлькiстю вiдвiдувачiв=" + el.day+"\n"+"__________________________________________________________");
                            break;
                        }

                        list.Sort(delegate (Second t1, Second t2)   // sort
                        {
                            return t1.comment.CompareTo(t2.comment);

                        });

                        foreach (Second el in list)
                        {
                            Console.WriteLine("день з найбiльшою кiлькістю слiв у коментарi=" + el.day + "\n" + "__________________________________________________________");
                            break;
                        }

                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Name" + "\t" + "Comment" + "\t" + "SName" + "\t" + "How" + "\t" + "Day");
                        foreach (Second item in list)
                        {

                            Console.WriteLine(item.name + "\t" + item.comment + "\t" + item.secondname + "\t" + item.nubmers + "\t" + item.day);
                        }

                        break;

                    case ConsoleKey.C:

                        int sum = 0;
                        foreach (Second item in list)
                        {
                            sum += item.nubmers;

                        }
                        Console.WriteLine("Сумарна кiлькiсть вiдвiдувачiв = " + sum);

                        break;


                    case ConsoleKey.Enter:


                        Console.Clear();

                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);

                        break;

                        case ConsoleKey.D: 
                        Console.WriteLine("Введіть назву  для пошуку");
                        string s1 = Console.ReadLine();
                        var found = list.Find(item => item.name == s1);
                        Console.WriteLine("Назва =" + found.name + " " + found.secondname);
                        break;

                    case ConsoleKey.Delete:

                        Console.WriteLine("Введить номер елемента який хочете видалити");
                        int s = int.Parse(Console.ReadLine());
                        list.RemoveAt(s);
                        foreach (First el in list)
                        {
                            Console.WriteLine(el);
                        }
                        break;
                      

                }
                 

                


               

            }
        }
    }
}
