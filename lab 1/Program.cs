using cs_lab1_main;

internal class Program
{
    private static void Main(string[] args)
    {
        Methods methods = new Methods();
        Random random = new Random();

        //1.1
        Console.WriteLine("1.1 Введите вещественное x ");
        double double_num = Convert.ToDouble(Console.ReadLine());    
        Console.WriteLine(methods.fraction(double_num));

        //1.3
        Console.WriteLine("1.3 Введите символ (0-9) ");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        char symb = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        int answer = methods.charToNum(symb);
        Console.WriteLine(answer.GetType().Name + ' ' +  answer);

        //1.5
        Console.WriteLine("1.5 Введите число x ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x);
        Console.WriteLine(methods.is2Digits(x));

        //1.7
        Console.WriteLine("1.7 Последовательно введите a, b и num");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.isInRange(a, b, num));

        //1.9
        Console.WriteLine("1.9 Последовательно введите a, b и c");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.isEqual(a, b, c));

        //2.1
        Console.WriteLine("2.1 Введите x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.abs(x));

        //2.3
        Console.WriteLine("2.3 Введите x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.is35(x));

        //2.5
        Console.WriteLine("2.5 Последовательно введите x, y и z ");
        x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.max3(x, y, z));

        //2.7
        Console.WriteLine("2.7 Последовательно введите x и y ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.sum2(x, y));

        //2.9
        Console.WriteLine("2.9 Введите номер дня недели: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.day(x));

        ////3.1
        Console.WriteLine("3.1 Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.listNums(x));

        //3.3
        Console.WriteLine("3.3 Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.chet(x));

        //3.5
        Console.WriteLine("3.5 Введите x ");
        long long_num = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(methods.numLen(long_num));

        //3.7
        Console.WriteLine("3.7 Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        methods.square(x);

        //3.9
        Console.WriteLine("3.9 Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        methods.rightTriangle(x);

        //4.1
        Console.WriteLine("4.1 Введите длину массивa");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Случайно сгенерированный массив");
        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 10);
            Console.Write(arr[i]);
            Console.Write(' ');
        }
        Console.WriteLine();
        Console.WriteLine("Введите число x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(methods.findFirst(arr, x));

        //4.3
        Console.WriteLine("4.3 Введите длину массивa");
        length = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[length];
        Console.WriteLine("Случайно сгенерированный массив");

        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = random.Next(-20, 20);
            Console.Write(arr2[i]);
            Console.Write(' ');
        }

        Console.WriteLine();
        Console.WriteLine(methods.maxAbs(arr2));

        //4.5
        Console.WriteLine("4.5 Введите длину первого массива");
        length = Convert.ToInt32(Console.ReadLine());
        int[] arr3 = new int[length];
        Console.WriteLine("Случайно сгенерированный первый массив");

        for (int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = random.Next(1, 10);
            Console.Write(arr3[i]);
            Console.Write(' ');
        }
        Console.WriteLine();

        Console.WriteLine("Введите длинну второго массива");
        length = Convert.ToInt32(Console.ReadLine());
        int[] ins = new int[length];
        Console.WriteLine("Случайно сгенерированный второй массив");

        for (int i = 0; i < ins.Length; i++)
        {
            ins[i] = random.Next(1, 10);
            Console.Write(ins[i]);
            Console.Write(' ');
        }
        Console.WriteLine() ;

        Console.WriteLine("Введите позицию первого массива в которую хотите вставить второй");
        int pos = Convert.ToInt32(Console.ReadLine());
        int[] answerArr =  methods.add(arr3, ins, pos);
        for (int i = 0; i < answerArr.Length; i++)
        {
            Console.Write(answerArr[i]);
            Console.Write(' ');
        }
        Console.WriteLine();

        //4.7
        Console.WriteLine("4.7 Введите длину массива");
        length = Convert.ToInt32(Console.ReadLine());
        int[] arr4 = new int[length];
        Console.WriteLine("Случайно сгенерированный массив");

        for (int i = 0; i < arr4.Length; i++)
        {
            arr4[i] = random.Next(1, 10);
            Console.Write(arr4[i]);
            Console.Write(' ');
        }

        Console.WriteLine();
        int[] answerArr2 = methods.reverseBack(arr4);
        Console.WriteLine("Перевернутый массив");
        for (int i = 0;i < answerArr2.Length; i++) { Console.Write(answerArr2[i]); Console.Write(" "); }
        Console.WriteLine();

        //4.9
        Console.WriteLine("4.9 Введите длину массива");
        length = Convert.ToInt32(Console.ReadLine());
        int[] arr5 = new int[length];

        Console.WriteLine("Случайно сгенерированный массив");
        for (int i = 0; i < arr5.Length; i++)
        {
            arr5[i] = random.Next(1,10);
            Console.Write(arr5[i]);
            Console.Write(" ");
        }
        Console.WriteLine();

        Console.WriteLine("Введите x");
        x = Convert.ToInt32(Console.ReadLine());
        int[] answerArr3 = methods.findAll(arr5, x);
        Console.WriteLine("Массив вхождений x в arr");
        for (int i = 0; i < answerArr3.Length; i++)
        {
            Console.Write(answerArr3[i]);
            Console.Write(" ");
        }
    }
}