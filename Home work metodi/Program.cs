using System;

namespace Home_work_metodi
{
    class Program
    {
        static void Main(string[] args)
        {


            static string AskName1()
            {
                Console.WriteLine("Укажите имя первого пользователя:");
                string nameUser1 = " ";
                int test;
                bool temp = true;
                while (temp == true)
                {
                    nameUser1 = Console.ReadLine();
                    for (int j = 0; j < nameUser1.Length; j++)
                    {
                        temp = Int32.TryParse(nameUser1[j].ToString(), out test);
                        if (temp == true)
                        {
                            Console.WriteLine("Имя содежит цифру, укажите правильно.");
                            break;

                        }
                        else
                        {
                            temp = false;
                        }
                    }
                }
                return nameUser1;
            }



            static int AskAge1()
            {
                Console.WriteLine("Укажите возраст первого пользователя:");
                int ageUser1 = 0;
                for (; ; )
                {
                    string read1 = (Console.ReadLine());
                    ageUser1 = 0;
                    int.TryParse(read1, out ageUser1);
                    if (ageUser1 <= 0)
                    {
                        Console.WriteLine("Не правильный возраст, укажите правильную информацию.");
                    }
                    else
                    {
                        break;
                    }
                }
                return ageUser1;
            }



            static string AskName2()
            {
                Console.WriteLine("Укажите имя второго пользователя:");
                string nameUser2 = " ";
                bool temp = true;
                int test;
                while (temp == true)
                {
                    nameUser2 = Console.ReadLine();
                    for (int i = 0; i < nameUser2.Length; i++)
                    {

                        temp = Int32.TryParse(nameUser2[i].ToString(), out test);

                        if (temp == true)
                        {
                            Console.WriteLine("В строке есть цифры, укажите верно");
                            break;
                        }
                        else
                        {
                            temp = false;
                        }
                    }
                }
                return nameUser2;
            }



            static int AskAge2()
            {
                Console.WriteLine("Укажите возраст второго пользователя:");
                int ageUser2 = 0;
                for (int i = 0; ; i++)
                {
                    string read2 = (Console.ReadLine());
                    ageUser2 = 0;
                    int.TryParse(read2, out ageUser2);
                    if (ageUser2 <= 0)
                    {
                        Console.WriteLine("Не правильный возраст, укажите правильную информацию.");
                    }
                    else
                    {
                        break;
                    }
                }
                return ageUser2;
            }

            static void AskOlder(string nameUser1, string nameUser2, int ageUser1, int ageUser2)
            {
                string result = " ";
                string peers = "Они ровесники";
                int ageRes = 0;
                string msg = ".";

                if (ageUser1 > ageUser2)
                {
                    result = nameUser1;
                    ageRes = ageUser1 - ageUser2;
                }
                else if (ageUser2 > ageUser1)
                {
                    result = nameUser2;
                    ageRes = ageUser2 - ageUser1;
                }



                Console.Write($"Укажите имя пользователя который старше или ");
                Console.Write($"'{peers}'");
                Console.WriteLine(", если они ровесники.");


                while (msg != result)
                {
                    msg = Console.ReadLine();
                    if (msg == peers && ageRes == 0)
                    {
                        Console.WriteLine("Да, они равесники.");
                        break;
                    }
                    else if (ageRes == 0 && msg == nameUser2 || msg == nameUser1)
                    {
                        Console.WriteLine("Не правильно, они равесники.");
                        break;
                    }
                    else if (ageUser1 > ageUser2 && msg == nameUser2 || msg == peers)
                    {
                        Console.WriteLine($"Не правильный ответ. Пользователь {result} старше на {ageRes}.");
                        break;
                    }
                    else if (ageUser2 > ageUser1 && msg == nameUser1 || msg == peers)
                    {
                        Console.WriteLine($"Не правильный ответ. Пользователь {result} старше на {ageRes}.");
                        break;
                    }
                    else if (msg == result)
                    {
                        Console.WriteLine($"Правильный ответ. Пользователь {result} старше на {ageRes}.");
                        break;
                    }
                    else if (msg != result)
                    {
                        Console.WriteLine($"Такого пользователя нет, укажите точное имя.");
                    }
                }
                Console.ReadKey();
            }




            string userName1 = AskName1();
            int userAge1 = AskAge1();
            string userName2 = AskName2();
            int userAge2 = AskAge2();
            AskOlder(userName1,userName2,userAge1,userAge2);









        
        }
    }
}
