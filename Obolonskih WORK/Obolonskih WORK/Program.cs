using System;

namespace ConsoleApplication1

{
    // Конструктор, формирует пустой массив, состоящий из
    // определенного числа элементов (size) и запоминающий
    // количество элементов массива в скрытом поле length
    class SafeArray
    {
        public SafeArray(int size)
        {
            a = new int[size];

            length = size;
        }

        // Конструктор, заполняющий формируемый массив

        // конкретными числами и запоминающий

        // количество элементов массива в скрытом поле length

        public SafeArray(params int[] arr)
        {
            length = arr.Length;

            a = new int[length];

            for (int i = 0; i < length; ++i) a[i] = arr[i];
        }

        // Метод, выполняющий поэлементное сложение двух

        // массивов. Количество складываемых элементов

        // определяется длиной меньшего массива (т.е. массива,

        // содержащего меньше элементов)
        public static SafeArray operator +(SafeArray x, SafeArray y)
        {
            int len = x.length < y.length ? x.length : y.length;

            SafeArray temp = new SafeArray(len);

            for (int i = 0; i < len; ++i) temp[i] = x[i] + y[i];

            return temp;
        }
        // Метод, выполняющий сложение массива с числом
        public static SafeArray operator +(SafeArray x, int y)
        {
            SafeArray temp = new SafeArray(x.length);
            for (int i = 0; i < x.length; ++i) temp[i] = x[i] + y;
            return temp;
        }
        // Метод, выполняющий сложение числа с массивом
        public static SafeArray operator +(int x, SafeArray y)
        {
            SafeArray temp = new SafeArray(y.length);

            for (int i = 0; i < y.length; ++i) temp[i] = x + y[i];

            return temp;
        }
        // Метод, выполняющий увеличение на единицу каждого
        // элемента массива
        public static SafeArray operator ++(SafeArray x)
        {
            SafeArray temp = new SafeArray(x.length);

            for (int i = 0; i < x.length; ++i) temp[i] = ++x[i];

            return temp;
        }
        // Индексатор для получения i-го элемента массива (get)
        // или для присвоения i-му элементу массива значения
        // value.
        // Если значение индекса недопустимо, обрабатывается
        // ошибочная ситуация
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < length) return a[i];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (i >= 0 && i < length) a[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        // Метод для вывода массива на экран
        public void Print(string name)
        {
            Console.WriteLine(name + ":");
            for (int i = 0; i < length; ++i) Console.Write("\t" + a[i]);
            Console.WriteLine();
        }
        // скрытые поля
        int[] a; // массив
        int length; // количество элементов в массиве
    }
    // Консольное приложение
    class Class1
    {
        // Метод, которому передается управление после
        // запуска программы
        static void Main()
        {
            try
            {
                // создание массива, состоящего из 5 элементов

                SafeArray a1 = new SafeArray(5, 2, -1, 1, -2);

                // вывод массива 1на экран

                a1.Print("Массив 1");

                // создание массива, состоящего из 3 элементов

                SafeArray a2 = new SafeArray(1, 0, 3);

                // вывод массива 2 на экран

                a2.Print("Массив 2");

                // Сложение двух массивов

                SafeArray a3 = a1 + a2;

                // вывод на экран массива, полученного в результате

                // сложения массивов 1 и 2

                a3.Print("Массив 3");

                // к каждому элементу массива 1 прибавляется число 100

                a1 = a1 + 100;

                // вывод на экран преобразованного массива 1

                a1.Print("100 + Массив 1");

                //каждый элемент массива увеличивается на 1,    

                // удваивается и к результату прибавляется 1

                // (правда, не в том порядке как описано выше)

                a2 += ++a2 + 1;

                // вывод на экран преобразованного массива 2

                a2.Print("++a2, a2 + a2 + 1");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}