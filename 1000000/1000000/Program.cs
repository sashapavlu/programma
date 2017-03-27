using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000000
{
    class Program
    {
        static void million()
        {
            Console.WriteLine("Это программа которая показывает миллион чисел\nНажми Enter чтобы продолжить");
            Console.ReadLine();
            Console.WriteLine("Введи число\nОт какого числа показать");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("До какого числа показать");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Нажимайте и удерживвайте Enter для показа чисел");
            for(int i = 0; i < 1000; i++)
            {
                int x;
                Random num = new Random();
                x = num.Next(a, b);
                Console.WriteLine(x);
                Console.ReadLine();
            }
            Console.WriteLine("Нажми 1 для выхода в главное меню");
            Console.ReadLine();
        }
        static void city()
        {
            Console.WriteLine("Это игра в города тебе нужно называть слово начинающееся на последнюю букву предыдущего\nКаждые 5 слов тебе будет предложено выйти\nНажми Enter чтобы продолжить.");
            Console.ReadLine();
            Console.WriteLine("Введи слово");
            int i = 0;
            while (true)
            {
                string sityans = Console.ReadLine();
                if (sityans.EndsWith("а") == true)
                {
                    writesity("Абакан", "Азов", "Архангельск", "Арзамас", "Астрахань", "Ачинск");
                }
                else if (sityans.EndsWith("б") == true)
                {
                    writesity("Барнаул", "Белгород", "Бийск", "Благовещенск", "Братск", "Брянск");
                }
                else if (sityans.EndsWith("в") == true)
                {
                    writesity("Владивосток", "Владикавказ", "Владимир", "Волгоград", "Воркута", "Воронеж");
                }
                else if (sityans.EndsWith("г") == true)
                {
                    writesity("Гаврилов-ям", "Галич", "Гатчина", "Геленжик", "Голицино", "Горняк");
                }
                else if (sityans.EndsWith("д") == true)
                {
                    writesity("Демидов", "Дмитров", "Дно", "Домодедово", "Донской", "Донецк");
                }
                else if (sityans.EndsWith("е") == true)
                {
                    writesity("Ейск", "Елец", "Елабуга", "Екатеринбург", "Ельня", "Ершов");
                }
                else if (sityans.EndsWith("ж") == true)
                {
                    writesity("Жуков", "Жуковка", "Жуковский", "Жиздра", "Жигулёвск", "Жержевка");
                }
                else if (sityans.EndsWith("з") == true)
                {
                    writesity("Задонск", "Заинск", "Зарайск", "Заречный", "Зима", "Зея");
                }
                else if (sityans.EndsWith("и") == true)
                {
                    writesity("Ивантеевка", "Инза", "Инта", "Иркутск", "Истра", "Ишим");
                }
                else if (sityans.EndsWith("") == true)
                {
                    writesity("Йошкар-Ола", "Йошкар-Ола", "Йошкар-Ола", "Йошкар-Ола", "Йошкар-Ола", "Йошкар-Ола");
                }
                else if (sityans.EndsWith("к") == true)
                {
                    writesity("Казань", "Кашин", "Киржач", "Королев", "Клин", "Конаково");
                }
                else if (sityans.EndsWith("л") == true)
                {
                    writesity("Липецк", "Лобня", "Любим", "Люберцы", "Лысково", "Лысьва");
                }
                else if (sityans.EndsWith("м") == true)
                {
                    writesity("Магас", "Москва", "Мураши", "Мышкин", "Мытищи", "Муром");
                }
                else if (sityans.EndsWith("н") == true)
                {
                    writesity("Новосибирск", "Ногинск", "Норильск", "Неман", "Невель", "Нальчик");
                }
                else if (sityans.EndsWith("о") == true)
                {
                    writesity("Обь", "Омск", "Орел", "Оса", "Остров", "Орлов");
                }
                else if (sityans.EndsWith("п") == true)
                {
                    writesity("Пермь", "Печора", "Печоры", "Плёс", "Покров", "Псков");
                }
                else if (sityans.EndsWith("р") == true)
                {
                    writesity("Раменское", "Реж", "Рославль", "Ростов", "Ростов-н -Дону", "Руза");
                }
                else if (sityans.EndsWith("с") == true)
                {
                    writesity("Салехард", "Самара", "Санкт-Петербург", "Саратов", "Саров", "Сергиев Посад");
                }
                else if (sityans.EndsWith("т") == true)
                {
                    writesity("Тайга", "Татарск", "Тверь", "Тула", "Тында", "Тюмень");
                }
                else if (sityans.EndsWith("у") == true)
                {
                    writesity("Углич", "Урай", "Уфа", "Уссурийск", "Усолье", "Усинск");
                }
                else if (sityans.EndsWith("ф") == true)
                {
                    writesity("Фрязино", "Фролово", "Фокино", "Фатеж", "Фурманов", "Фокино");
                }
                else if (sityans.EndsWith("х") == true)
                {
                    writesity("Хабаровск", "Химки", "Холм", "Холмск", "Хотьково", "Хилок");
                }
                else if (sityans.EndsWith("ц") == true)
                {
                    writesity("Цивильск", "Цивильск", "Цивильск", "Цимлянск", "Цимлянск", "Цимлянск");
                }
                else if (sityans.EndsWith("ч") == true)
                {
                    writesity("Челябинск", "Чердынь", "Череповец", "Чехов", "Чудово", "Чулым");
                }
                else if (sityans.EndsWith("ш") == true)
                {
                    writesity("Шатура", "Шахты", "Шацк", "Шиханы", "Щелково", "Щучье");
                }
                else if (sityans.EndsWith("э") == true)
                {
                    writesity("Электросталь", "Элиста", "Энгельск", "Эртиль", "Электрогорск", "Электроугли");
                }
                else if (sityans.EndsWith("ю") == true)
                {
                    writesity("Южа", "Юрга", "Юрьевец", "Юхнов", "Южнуральск", "Югорск");
                }
                else if (sityans.EndsWith("я") == true)
                {
                    writesity("Якутск", "Ядрин", "Яросльвль", "Ясный", "Яхрома", "Ярцево");
                }
                i++;
                if (i == 5)
                {
                    Console.WriteLine("1 - выйти в главное меню, другое - продолжить");
                    int resh = Int32.Parse(Console.ReadLine());
                    if (resh == 1)
                    {
                        break;
                    }
                }
            }
        }
        static void writesity(string sity1, string sity2, string sity3, string sity4, string sity5, string sity6)
        {
            int x;
            Random num = new Random();
            x = num.Next(1, 7);
            if (x == 1)
            {
                string sity = sity1;
                Console.WriteLine(sity1);
            }
            else if (x == 2)
            {
                string sity = sity2;
                Console.WriteLine(sity2);
            }
            else if (x == 3)
            {
                string sity = sity3;
                Console.WriteLine(sity3);
            }
            else if (x == 4)
            {
                string sity = sity4;
                Console.WriteLine(sity4);
            }
            else if (x == 5)
            {
                string sity = sity5;
                Console.WriteLine(sity5);
            }
            else if (x == 6)
            {
                string sity = sity6;
                Console.WriteLine(sity6);
            }





        }
        static void tanswer(int a, int write, int ask)
        {
            if (a == ask)
            {
                Console.WriteLine(write);
            }
        }
        static void cas()
        {
            int money = 1000;
            Console.WriteLine("Это казино.");
            while (true)
            {
                if (money <= 100)
                {
                    Console.WriteLine("На вашем счете менее ста едениц. Вы  проиграли\nНажмите Enter чтобы выйти в главное меню.");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Введите \n1 - Угадать число от 1 до 10\n2 - Угадать число от 1 до 5 ");
                int play = Int32.Parse(Console.ReadLine());
                Console.WriteLine("У вас на счету: " + money + "\nСделайте ставку:");
                int stavka = Int32.Parse(Console.ReadLine());
                while (true)
                {
                    if (stavka > money)
                    {
                        Console.WriteLine("Ставка больше чем у вас есть денег на счету.\nВведите ставку:");
                        stavka = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                if (play == 1)
                {
                    Console.WriteLine("Угадайте число от 1 до 10");
                    int y = Int32.Parse(Console.ReadLine());
                    int x;
                    Random num = new Random();
                    x = num.Next(1, 10);
                    if (x == y)
                    {
                        money = money + (stavka * 10);
                        Console.WriteLine("Вы угадали!\nВаш баланс: " + money);
                    }
                    else
                    {
                        money = money - stavka;
                        Console.WriteLine("Вы не угадали!\nВаш баланс: " + money);
                    }
                } 
                else if (play == 2)
                {
                    Console.WriteLine("Угадайте число от 1 до 5");
                    int y = Int32.Parse(Console.ReadLine());
                    int x;
                    Random num = new Random();
                    x = num.Next(1, 5);
                    if (x == y)
                    {
                        money = money + (stavka * 5);
                        Console.WriteLine("Вы угадали!\nВаш баланс: " + money);
                    }
                    else
                    {
                        money = money - stavka;
                        Console.WriteLine("Вы не угадали!\nВаш баланс: " + money);
                    }
                }
                Console.WriteLine("Введи 1 чтобы выйти в главное меню, другое - продолжить.");
                int a = Int32.Parse(Console.ReadLine());
                if (a == 1)
                {
                    break;
                }
            }
        }
        static void f()
        {
            for (int i = 0; i <= 10000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void calk()
        {
            Console.WriteLine("Это калькулятор\nНажми Enter чтобы продолжить.");
            Console.ReadLine();
            Console.WriteLine("Введи число А: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Выбери действие (введи цифру)\n1 - +\n2 - -\n3 - *\n4 - /\n5 - а^2\n6 - а^3\n7 - a^4");
            int act = Int32.Parse(Console.ReadLine());
            if (act == 1)
            {
                Console.WriteLine("Введи число B: ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine(a + " + " + b + " = " + a + b);
            } 
            else if (act == 2)
            {
                Console.WriteLine("Введи число B: ");
                double b = Double.Parse(Console.ReadLine());
                double ab = a - b;
                Console.WriteLine(a + " - " + b + " = " + ab);
            }
            else if (act == 3)
            {
                Console.WriteLine("Введи число B: ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine(a + " * " + b + " = " + a * b);
            }
            else if (act == 4)
            {
                Console.WriteLine("Введи число B: ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine(a + " / " + b + " = " + a / b);
            }
            else if (act == 5)
            {
                Console.WriteLine(a + "^2 = " + a * a );
            }
            else if (act == 6)
            {
                Console.WriteLine(a + "^3 = " + a * a * a);
            }
            else if (act == 7)
            {
                Console.WriteLine(a + "^4 = " + a * a * a * a);
            }
            Console.WriteLine("Нажми Enter чтобы выйти в главное меню");
            Console.ReadLine();
        }
        static void cont()
        {
            Console.WriteLine("Эта программа считает сумму вклада через несколько лет.\nНажми Enter чтобы продолжить.");
            Console.ReadLine();
            Console.WriteLine("Сумма вклада:");
            double depos = Double.Parse(Console.ReadLine());
            Console.WriteLine("Проценты:");
            double pers = Double.Parse(Console.ReadLine());
            Console.WriteLine("Лет:");
            double ears = Double.Parse(Console.ReadLine());
            int i = 0;
            while (i <= ears)
            {
                depos = depos / 100 * (100 + pers);
                i++;
            }
            Console.WriteLine("Сумма вклада через " + ears + " лет - " + depos);
            Console.WriteLine("Нажми Enter чтобы выйти в главное меню.");
            Console.ReadLine();
        }
        static void question()
        {
            Console.WriteLine("Эта программа задаст вам 10 вопросов и в конце выведет количество правильных ответов.\nВводи число от 1 до 4.\nНажми Enter чтобы продолжить.");
            Console.ReadLine();
            int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
            int i = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int a6 = 0;
            int a7 = 0;
            int a8 = 0;
            int a9 = 0;
            int a10 = 0;
            Console.WriteLine("1.Сколько планет в солнечной системе.\n1) 1\n2) 2\n3) 8\n4) 67 ");
            p1 = Int32.Parse(Console.ReadLine());
            if (p1 == 3)
            {
                Console.WriteLine("Правильно!");
                i++;
                a1++;
            } else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("2.Сколько звезд в солнечной системе.\n1)1\n2)2\n3)8\n4)67");
            p2 = Int32.Parse(Console.ReadLine());
            if (p2 == 1)
            {
                Console.WriteLine("Правильно!");
                i++;
                a2++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("3.Какая скорость света в вакууме.\n1)290т.км/с\n2)300т.км/с\n3)400т.км/с\n4)150т.км/с ");
            p3 = Int32.Parse(Console.ReadLine());
            if (p3 == 2)
            {
                Console.WriteLine("Правильно!");
                i++;
                a3++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("4.Сколько спутников у Юпитера.\n1)1 \n2)2 \n3)16 \n4)67 ");
            p4 = Int32.Parse(Console.ReadLine());
            if (p4 == 4)
            {
                Console.WriteLine("Правильно!");
                i++;
                a4++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("5.Спутник Земли.\n1)Ганимед \n2)Луна \n3)Титан \n4)Нибиру ");
            p5 = Int32.Parse(Console.ReadLine());
            if (p5 == 2)
            {
                Console.WriteLine("Правильно!");
                i++;
                a5++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("6.Диаметр Земли по экватору.\n1)1300км \n2)12568км \n3)12742км \n4)13024км ");
            p6 = Int32.Parse(Console.ReadLine());
            if (p6 == 3)
            {
                Console.WriteLine("Правильно!");
                i++;
                a6++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("7.Самый большой объект солнечной системы.\n1)Солнце \n2)Юпитер \n3)Сатурн \n4)Земля ");
            p7 = Int32.Parse(Console.ReadLine());
            if (p7 == 1)
            {
                Console.WriteLine("Правильно!");
                i++;
                a7++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("8.Что такое Великий Аттрактор.\n1)Звезда \n2)Стоянка тракторов \n3)Скопление галактик \n4)Сверхскопление галактик ");
            p8 = Int32.Parse(Console.ReadLine());
            if (p8 == 4)
            {
                Console.WriteLine("Правильно!");
                i++;
                a8++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("9.Что такое млечный путь.\n1)Звезда \n2)Галактика \n3)Планета \n4)Скопление галактик ");
            p9 = Int32.Parse(Console.ReadLine());
            if (p9 == 2)
            {
                Console.WriteLine("Правильно!");
                i++;
                a9++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("10.Где находится галактика Млечный путь.\n1)В Скоплении Девы \n2)В Скоплении Великиго Аттрактора \n3)В Сверхскоплении Девы \n4)В Сверхскоплении Великиго Аттрактора ");
            p10 = Int32.Parse(Console.ReadLine());
            if (p10 == 3)
            {
                Console.WriteLine("Правильно!");
                i++;
                a10++;
            }
            else
            {
                Console.WriteLine("Неправильно.");
            }
            Console.WriteLine("Правильных ответов: " + i + "\nПравильные ответы были в номерах: ");
            tanswer(a1, 1, 1);
            tanswer(a2, 2, 1);
            tanswer(a3, 3, 1);
            tanswer(a4, 4, 1);
            tanswer(a5, 5, 1);
            tanswer(a6, 6, 1);
            tanswer(a7, 7, 1);
            tanswer(a8, 8, 1);
            tanswer(a9, 9, 1);
            tanswer(a10, 10, 1);
            Console.WriteLine("Неправильные ответы были в номерах: ");
            tanswer(a1, 1, 0);
            tanswer(a2, 2, 0);
            tanswer(a3, 3, 0);
            tanswer(a4, 4, 0);
            tanswer(a5, 5, 0);
            tanswer(a6, 6, 0);
            tanswer(a7, 7, 0);
            tanswer(a8, 8, 0);
            tanswer(a9, 9, 0);
            tanswer(a10, 10, 0);
            Console.WriteLine("Нажми Enter чтобы выйти в главное меню.");
            Console.ReadLine();
        }
        static void val()
        {
            Console.WriteLine("Это конвертер валют\nНажми Enter чтобы продолжить");
            double eur = 61.968;
            double usd = 57.336;
            Console.ReadLine();
            Console.WriteLine("1 - Изменить курс, другое - оставить по умолчанию (доллар - 57,336 евро - 61,968)");
            int resh = Int32.Parse(Console.ReadLine());
            if (resh == 1)
            {
                Console.WriteLine("Введи курс доллара: ");
                usd = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введи курс евро: ");
                eur = Double.Parse(Console.ReadLine());
                Console.WriteLine("Курс изменен");
            }
            else if (resh != 1)
            {
                Console.WriteLine("Курс оставлен по умолчанию");
            }
            Console.WriteLine("Сумма в рублях: ");
            int rub = Int32.Parse(Console.ReadLine());
            Console.WriteLine(rub + " рублей = " + rub/usd + " долларов = " + rub/eur + " евро");
            Console.WriteLine("Для выхода в главное меню нажми Enter.");
            Console.ReadLine();
        }
        static void mil()
        {
            Console.WriteLine("Эта программа считает от 1 до 10000, нажми Enter чтобы продолжить.");
            Console.ReadLine();
            f();
            while (true)
            {
                Console.WriteLine("Если хочешь продолжить введи 1, другое - выходв главное меню.");
                int a = Int32.Parse(Console.ReadLine());
                if (a == 1)
                {
                    f();  
                }
                else
                {
                    Console.WriteLine("Для выхода в главное меню нажми Enter.");
                    break;
                }
            }
            Console.ReadLine();
        }
        static void rul()
        {
            Console.WriteLine("Эта программа стреляет себе в голову, попадает с вероятностью 1/6.");
            Console.ReadLine();
            int x = 0;
            int resh = 1;
            while (resh == 1)
            {
                Random num = new Random();
                x = num.Next(1, 6);
                if (x == 1)
                {
                    Console.WriteLine("Мертв. Нажми Enter чтобы выйти в главное меню.");
                    break;
                } else
                {
                    Console.WriteLine("Введи 1 чтобы продолжить, другое - выход в главное меню.");
                    resh = Int32.Parse(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет у тебя есть выбор из семи прорамм.");
            while (true)
            {
                Console.WriteLine("ГЛАВНОЕ МЕНЮ.");
                Console.WriteLine("Введи: \n1 - программа которая считает от 1 до 10000.\n2 - программа которая стреляет себе в голову.\n3 - Конвертер валют.\n4 - Вопросы.\n5 - Вклад\n6 - Калькулятор\n7 - Казино\n8 - Города России\n9 - Программа которая показывает 1000 чисел\nДругое - чтобы выйти.");
                int prog = Int32.Parse(Console.ReadLine());
                if (prog == 1)
                {
                    mil();
                }
                else if (prog == 2)
                {
                    rul();
                }
                else if (prog == 3)
                {
                    val();
                }
                else if (prog == 4)
                {
                    question();
                }
                else if (prog == 5)
                {
                    cont();
                }
                else if (prog == 6)
                {
                        calk();
                }
                else if (prog == 7)
                {
                    cas();
                }
                else if (prog == 8)
                {
                    city();
                }
                else if (prog == 9)
                {
                    million();
                }
                else
                {
                    Console.WriteLine("Нажми Enter чтобы выйти.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
