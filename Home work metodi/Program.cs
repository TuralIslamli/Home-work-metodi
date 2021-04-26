using System;

namespace Home_work_metodi
{
    class Program
    {
        static string AskName()
        {
            Console.WriteLine("Укажите имя пользователя:");
            string nameUser = " ";
            int test;
            bool temp = true;
            while (temp == true)
            {
                nameUser = Console.ReadLine();
                for (int j = 0; j < nameUser.Length; j++)
                {
                    temp = Int32.TryParse(nameUser[j].ToString(), out test);
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
            return nameUser;
        }










        static int AskAge()
        {
            Console.WriteLine("Укажите возраст пользователя:");
            int ageUser = 0;
            for (; ; )
            {
                string read1 = (Console.ReadLine());
                ageUser = 0;
                int.TryParse(read1, out ageUser);
                if (ageUser <= 0)
                {
                    Console.WriteLine("Не правильный возраст, укажите правильную информацию.");
                }
                else
                {
                    break;
                }
            }
            return ageUser;
        }











 
        static void AskOlder(string nameUser, string nameUser2, int ageUser, int ageUser2)
        {
            string result = " ";
            string peers = "Они ровесники";
            int ageRes = 0;
            string msg = ".";

            if (ageUser > ageUser2)
            {
                result = nameUser;
                ageRes = ageUser - ageUser2;
            }
            else if (ageUser2 > ageUser)
            {
                result = nameUser2;
                ageRes = ageUser2 - ageUser;
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
                else if (ageRes == 0 && msg == nameUser2)
                {
                    Console.WriteLine("Не правильно, они равесники.");
                    break;
                }
                else if (ageRes == 0 && msg == nameUser)
                {
                    Console.WriteLine("Не правильно, они равесники.");
                    break;
                }
                else if (ageUser > ageUser2 && msg == nameUser2 || msg == peers)
                {
                    Console.WriteLine($"Не правильный ответ. Пользователь {result} старше на {ageRes}.");
                    break;
                }
                else if (ageUser2 > ageUser && msg == nameUser || msg == peers)
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
        static void Main(string[] args)
        {


            




            string userName1 = AskName();
            int userAge1 = AskAge();
            string userName2 = AskName();
            int userAge2 = AskAge();
            AskOlder(userName1,userName2,userAge1,userAge2);









        
        }
    }
}
