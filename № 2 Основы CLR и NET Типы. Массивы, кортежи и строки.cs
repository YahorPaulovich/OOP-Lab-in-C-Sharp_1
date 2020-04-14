using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Account
    {
        public object Id { get; set; }
        public int Sum { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор: Павлович Егор Дмитриевич \nИСиТ, второй курс, группа 1821 \nВариант 14 \n");
            ///////////////////////////////////////// 1) Типы ////////////////////////////////////////////
            //a).переменные всех возможных примитивных типов С#    
            bool alive = true; bool isDead = false;
            byte bit1 = 1;
            sbyte bit2 = 102;
            short n1 = -128;
            ushort n2 = 0;
            int a = 10;
            uint b = 10;
            long Bignum = a;
            ulong c = 0b101;
            float d = 11.1F;
            double e = 11.11;
            decimal f = 10000;
            char ch = 'A';
            string h = "Hello";
            object ii = "µ";

            Console.WriteLine($"/////////////////////////1) Типы \na).Переменные всех возможных примитивных типов С# \n \nbool: {alive} and {isDead}  (логические литералы);" +
            $"\nbyte: {bit1} (хранит целое число от 0 до 255 и занимает 1 байт); \nsbyte {bit2} (хранит целое число от -128 до 127 и занимает 1 байт);" +
            $"\nshort: {n1} (хранит целое число от -32768 до 32767 и зан" +
            $"имает 2 байта); \nushort {n2} (хранит целое число от -32768 до 32767 и занимает 2 байта); " +
            $"\nint: {a} (хранит целое число от -2147483648 до 2147483647 и занимает 4 байта); \nuint {b} (хранит целое число от 0 до 4294967295 и занимает 4 байта); " +
            $"\nlong: {Bignum} (хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт); " +
            $"\nulong: {c} (хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт); " +
            $"\nfloat: {d} (хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта); " +
            $"\ndouble: {e} (хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта); " +
            $"\ndecimal: {f} ( хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт); " +
            $"\nchar: {ch} (хранит одиночный символ в кодировке Unicode и занимает 2 байта); " +
            $"\nstring: {h} (хранит набор символов Unicode); " +
            $"\nobject: {ii} (может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе). \n");
            Console.ReadKey();

            //b).5 операций явного и 5 неявного приведения         
            int int_a = 4;
            int int_b = 6;
            byte byte_a = (byte)(int_a + int_b);
            byte byte_b = 0;
            short short_a = (short)(byte_a + byte_b);
            short short_b = 5;
            int int_c = (int)(short_a + short_b);
            long long_a = (long)(int_a + int_c);
            long long_b = 100;
            float float_a = (float)(long_a + long_b);
            float float_b = 5.5F;
            double double_a = (double)(float_a + float_b);

            Console.WriteLine($"b).5 операций явного и 5 неявного приведения \n \n(byte)(int a = 4 + int b = 6) = byte a = {byte_a}; " +
            $"\n(short)(byte a = {byte_a} + byte b = 0) short a = {short_a}; \n(int)(short {short_a} + short {short_b}) = {int_c} " +
            $"(long)(int {int_a} + int {int_c}) = {long_a}; \n(float)(long {long_a} + long {long_b}) = {float_a} " +
            $"\n(double)(float {float_a} + float {float_b}) = {double_a} \n");
            Console.ReadKey();

            bit1 = 4; // 00001000
            n2 = bit1; // 000000000000100           

            bit2 = 4; // 0000100
            n1 = bit2; // 000000000000100           

            sbyte bit3 = -4; // 1111100
            n1 = bit3; // 111111111111100

            sbyte bit4 = -6; // 
            n1 = bit4; //

            Bignum = 5;
            d = Bignum;

            Console.WriteLine($"byte = {bit1} конверитируем byte в ushort = {bit1}; " +
            $"\nконверитируем sbyte в short = {bit2} \nконверитируем sbyte в short = {bit3};" +
            $"\nконверитируем sbyte в short = {bit4}; \nконверитируем long в float = {Bignum}; \n");

            //c).Упаковка и распаковка значимых типов.           
            Account account1 = new Account { Sum = 5000 };
            Account account2 = new Account { Sum = 4000 };
            account1.Id = 2;// упаковка в значения int в тип Object
            account2.Id = "4356";
            int id1 = (int)account1.Id;// Распаковка в тип int
            string id2 = (string)account2.Id;
            Console.WriteLine($"c).Упаковка и распаковка значимых типов. \n{id1} (упаковка в значения int в тип Object);");
            Console.WriteLine($"{id2} (Распаковка в тип int).\n");

            //d).Работа с неявно типизированной переменной.
            var hello = "Hell to World";
            var CC = 20;
            Console.WriteLine("d).Работа с неявно типизированной переменной.");
            Console.WriteLine(CC.GetType().ToString());
            Console.WriteLine(hello.GetType().ToString());

            //e).Продемонстрируйте пример работы с Nullable переменной.
            Console.WriteLine($"\ne).Пример работы с Nullable переменной");
            int? x1 = null;
            int? x2 = null;
            if (x1 == x2)
                Console.WriteLine("Объекты равны");
            else
                Console.WriteLine("Объекты неравны");

            /////////////////////////////////////// 2) Строки ////////////////////////////////////////////
            //a.)Объявление строковых литералов. Сравнение их.
            string s1 = "hello";
            string s2 = "world";
            int result_ = String.Compare(s1, s2);

            Console.WriteLine($"\n/////////////////////////2) Строки \na.)Объявление строковых литералов. Сравнение их.");
            if (result_ < 0)
            {
                Console.WriteLine("\nСтрока s1 перед строкой s2");
            }
            else if (result_ > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
                Console.ReadKey();
            }
            /*b).Сцепление,
            копирование, выделение подстроки, разделение строки на слова,
            вставки подстроки в заданную позицию, удаление заданной
            подстроки.*/

            string s3 = s1 + " " + s2;//сцепление
            string s4 = s3 + "!!!";
            Console.WriteLine($"\n(Сцепление) \n{s1} + {s2} = {s3} \n{s3} + !!! = {s4}\n");
            Console.ReadKey();

            //разделение строки на слова
            Console.WriteLine("(разделение строки на слова)");
            string text = "Строку нужно разделить!";
            Console.WriteLine($"текст : {text}");
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s); Console.ReadKey();
            }
            //вставки подстроки в заданную позицию
            Console.WriteLine($"\n(вставки подстроки в заданную позицию) " +
            $"\nХороший день! \nзамечательный просто!!!");
            text = "Хороший день!";
            string subString = "замечательный просто!!!";
            text = text.Insert(8, subString);
            Console.WriteLine(text);
            Console.ReadKey();

            //удаление заданной подстроки           
            text = "Хороший день";
            Console.WriteLine($"\n(удаление заданной подстроки) \n{text}");
            int ind = text.Length - 1;// индекс последнего символа
            text = text.Remove(ind);
            Console.WriteLine($"{text} (вырезаем последний символ)");
            Console.ReadKey();
            text = text.Remove(0, 2);// вырезаем первые два символа
            Console.WriteLine($"{text} (вырезаем первые два символа)");
            Console.ReadKey();

            // выделение подстроки
            hello = "Hello world!!!";
            Console.WriteLine($"\n(выделение подстроки)");
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());

            //копирование(замена)
            Console.WriteLine($"\n(копирование)");
            string text1 = "хороший день";
            text = text1.Replace("хороший день", "плохой");
            Console.WriteLine(text);
            text = text.Replace("о", "");
            Console.WriteLine(text);
            Console.ReadKey();

            //c).Создание пустой и null строки. Демонстрация того, что можно выполнить с такими строками
            string message1 = null;
            string message2 = String.Empty;
            string message3 = message1 + message2;
            Console.WriteLine("\nc).Создание пустой и null строки. Демонстрация того, что можно выполнить с такими строками");
            Console.WriteLine(message3);
            Console.ReadKey();

            /*d). Создание строки на основе StringBuilder. 
            Удаление определенных позиций и добавление новых символ в начало и конец строки*/

            Console.WriteLine($"d). Создание строки на основе StringBuilder. " +
            $"\nУдаление определенных позиций и добавление новых символ в начало и конец строки");
            string[] myStr = { "One", "Two", "THree", "Four", };
            StringBuilder str = new StringBuilder("WE Are We Are!!!...").AppendLine();
            foreach (string item in myStr)
            {
                str.Append(item).AppendLine();
            }
            Console.WriteLine(str.ToString());
            int len = str.Length;
            Console.WriteLine("Length = " + len);
            str.Clear();
            int len2 = str.Length;
            int len3 = str.Length;
            Console.WriteLine(len3 + "Length after using Clear = " + len2);
            Console.ReadKey();

            ////////////////////////////////////// 3) Массивы //////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////3) Массивы\n");
            /*a. Создайте целый двумерный массив и выведите его на консоль в
                 отформатированном виде (матрица).*/

            Console.WriteLine($"a). Создание целого двумерного массива и вывод его на консоль в " +
            $"отформатированном виде(матрица). \n");
            int[,] nums = { { 0, 1, 2 }, { 3, 4, 5 } };
            for (int N = 0; N < nums.GetLength(0); N++)
            {
                for (int V = 0; V < nums.GetLength(1); V++)
                    Console.Write(" {0} ", nums[N, V]);
                Console.WriteLine();
            }
            Console.ReadKey();

            /*b). Создание одномерного массива строк. Вывод на консоль его
            содержимого, длины массива. Замена произвольного элемента
            (пользователь определяет позицию и значение).*/

            Console.WriteLine($"\nb). Создание одномерного массива строк. " +
            $"Вывод на консоль его содержимого, длины массива. " +
            $"Замена произвольного элемента \n(пользователь определяет позицию и значение). \n");
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int ji in numbers)
            {
                Console.WriteLine(numbers[ji]);
            }
            Console.WriteLine($" длина массива = {numbers.Length};");
            Console.WriteLine($"ВВЕДИТЕ номер произвольного элемента(от 1 и до 10):");
            int arbitrary_element = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nВВЕДИТЕ произвольное значение массива:");
            int array_value = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"\n(после замены произвольного элемента)");
            numbers[arbitrary_element] = array_value;
            foreach (int ji in numbers)
            {
                Console.WriteLine(numbers[ji]);
            }
            Console.ReadKey();

            /*c). Создание ступечатого (не выровненного) массива вещественных чисел с 3-мя строками, 
            в каждой из которых 2, 3 и 4 столбцов соответственно. 
            Значения массива вводятся с консоли.*/

            Console.WriteLine($"\nc). Создание ступечатого (не выровненного) " +
            $"массива вещественных чисел с 3-мя строками, " +
            $"в каждой из которых 2, 3 и 4 столбцов соответственно. " +
            $"Значения массива вводятся с консоли.\n");
            int[][] geararray = new int[3][];
            int i = 0;
            geararray[0] = new int[2];
            geararray[1] = new int[3];
            geararray[2] = new int[4];

            Console.WriteLine("ВВЕДИТЕ 1-ые значения подмассива:");
            for (; i < 2; i++)
            {
                int Value1 = Convert.ToInt32(Console.ReadLine());
                geararray[0][i] = Value1;               
            }            
            Console.WriteLine($"\nВВЕДИТЕ 2-ые значения подмассива:");
            for (i = 0; i < 3; i++)
            {
                int Value2 = Convert.ToInt32(Console.ReadLine());
                geararray[1][i] = Value2;               
            }           
            Console.WriteLine($"\nВВЕДИТЕ 3-ые значения подмассива:");

            for (i = 0; i < 4; i++)
            {
                int Value3 = Convert.ToInt32(Console.ReadLine());
                geararray[2][i] = Value3;               
            }

            Console.WriteLine($"\n(Зубчатый/ступенчатый массив)");
            foreach (int[] row in geararray)
            {
                foreach(int number in row)
                {
                    Console.Write($"{number} "," \t");
                }
                Console.WriteLine();
            }                     

            //d). Создание неявно типизированных переменных для хранения массива и строки.
            var a_ = new[] { 1, 10, 100, 1000 }; //int[]
            var b_ = new[] { "hello", null, "world" };// string[]

            //single-dimension jagged array
            var c_= new[]
            {
            new[]{ 1, 2, 3, 4 },
            new[]{ 5, 6, 7, 8 }
            };
            //jagged array of strings
            var d_ = new[]
            {
            new[]{"Luca","Mads","Luke","Denish"},
            new[]{ "Karen","Suma","Frances"}
            };
            Console.ReadKey();

            ////////////////////////////////////// 4) Кортежи /////////////////////////////////////////////
            //a). Задание кортежа из 5 элементов с типами int, string, char, string, ulong.
            Console.WriteLine("\n//////////////////////////////4) Кортежи");

            Console.WriteLine("a). Задание кортежа из 5 элементов с типами int, string, char, string, ulong. \n");           
            var (int_1, string_1, char_, string_2, ulong_) = (5, "String1", '¶', "String2", 0);
            Console.WriteLine($"{Convert.ToString(int_1)} \n{ string_1 } \n{ char_} \n{ string_2} \n{ ulong_}");

            //(1, 3, 4 элементы)
            Console.WriteLine($"\n(1, 3, 4 элементы) \n \n{Convert.ToString(int_1)} \n{ char_} \n{ string_2}");

            //d). Выполните распаковку кортежа в переменные.
            Console.WriteLine("\na). Распаковка кортежа в переменные \n");

            var population = new Tuple<string, int, int, int, int, int, int>(
                           "New York", 7891957, 7781984,
                           7894862, 7071639, 7322564, 8008278);
                          // первый и последний элементы.
            Console.WriteLine("Population of {0} in 2000: {1:N0}",
                              population.Item1, population.Item7);

            var tuple = new Tuple<string, int, int, int, int, int, int>(
                          "Minsk", 1666, 1670, 1674, 1676, 1681, 1683);
            string Minsk = tuple.Item1;
            int a7 = tuple.Item7; 
            Console.WriteLine("Population of {0} in 2000: {1:N0}",
                              Minsk, a7);
           
            //e). Сравните два кортежа.
            Console.WriteLine("\ne). Сравнение двух кортежей.\n");
            if (population.Item7 > tuple.Item7)
                Console.WriteLine("Численность населения Ньюёрка и в 2000-ых годах была больше чем в Минске \n");
            else
                Console.WriteLine("New York - мегаполис!!!");
            Console.ReadKey();

//---------------------------------------------------------------------------------------------------//
            /*5) Создайте локальную функцию в main и вызовите ее. 
            Формальные параметры функции – массив целых и строка. 
            Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, 
            сумму элементов массива и первую букву строки .*/
            Console.WriteLine("\n//////////////////////////////5) Создание локальной функции в main\n");
                      
            ((string, int), (string, int), (string, int), (string, string)) ReturnTuple()
            {

                int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                string line = "Массив : ";

                //вывод массива
                void array_output(int[] arr_)
                {
                    int[] arr = arr_;
                    for (i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]} ");
                        if (i != arr.Length)
                        {
                            Console.Write("");
                        }
                    }
                }

                //вывод строки
                void string_output(string line_)
                {
                    line = line_;
                    for (i = 0; i < line.Length; i++)
                    {
                        Console.Write(line[i]);
                        if (i != line.Length)
                        {
                            Console.Write("");
                        }
                    }
                }

                //поиск максимального элемента массива            
                (string, int) search_max(int[] arr)
                {
                    byte mx = 0; int max = arr[mx];
                    for (byte p = 1; p < arr.Length; p++)
                    {
                        if (arr[p] > max)
                        {
                            max = arr[p];
                            mx = p;
                        }
                    }
                    var resultMAX = ("\nмаксимальный элемент массива = ", max);
                    //return max;
                    return resultMAX;
                }

                //поиск минимального элемента массива
                (string, int) search_min(int[] arr)
                {
                    byte mn = 0; int min = arr[mn];
                    for (byte p = 1; p < arr.Length; p++)
                    {
                        if (arr[p] < min)
                        {
                            min = arr[p];
                            mn = p;
                        }
                    }
                    var resultMIN = ("\nминимальный элемент массива = ", min);
                    //return min;
                    return resultMIN;
                }

                //поиск суммы элементов массива
                (string, int) search_sum(int[] arr)
                {
                    int sum = 0;
                    for (i = 1; i < arr.Length; i++)
                        sum = sum + arr[i];
                    var resultSUM = ("\nсумма элементов массива = ", sum);
                    //return sum;
                    return resultSUM;
                }

                //выделение первой буквы строки
                (string, string) output_first_letter(string line_)
                {
                    line = line_;
                    line = line.Substring(0, 1);
                    var result_firstLetter = ("\nпервая буква строки — это ", line);
                    //return line;
                    return result_firstLetter;
                }

                string_output(line);
                array_output(array);

                var result = (search_max(array), search_min(array), search_sum(array), output_first_letter(line));               
                return result;

            }

            Console.WriteLine(ReturnTuple());

            //string_output(line); 
            //array_output(array);
            //Console.WriteLine($"\nмаксимальный элемент массива = {search_max(array)}");
            //Console.WriteLine($"\nминимальный элемент массива = {search_min(array)}");
            //Console.WriteLine($"\nсумма элементов массива = {search_sum(array)}");
            //Console.WriteLine($"\nпервая буква строки — это '{output_first_letter(line)}'");          

            Console.ReadKey();
        }

    }
}
