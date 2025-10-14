using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cs_lab1_main
{
    internal class Methods
    {
        public double fraction(double x)
        {
            return x - Math.Floor(x);
        }

        public int charToNum(char x)
        {
            return x - '0';
        }

        public bool is2Digits(int x)
        {
            return x > 9 && x < 100;
        }

        public bool isInRange(int a, int b, int num)
        {
            int max = Math.Max(a, b);
            int min = (a + b) - max;
            return num > min && num < max;
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && a == c;
        }

        public int abs(int x)
        {
            if (x > 0)
            {
                return x;
            }

            else
            {
                return x * -1;
            }
        }

        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            }
            return x % 3 == 0 || x % 5 == 0;
        }

        public int max3(int x, int y, int z)
        {
            if (x > y && x > z) 
            {
                return x;
            }

            if (y > z && y > x)
            {
                return y;
            }

            else
            {
                return z;
            }
        }

        public int sum2(int x, int y)
        {
            if ((x + y) < 20 && (x + y) > 9)
            {
                return 20;
            }
            return x + y;
        }

        public string day(int x)
        {
            string answer;
            switch(x)
            {
                case 1: answer = "понедельник"; break;
                
                case 2: answer = "вторник"; break;
                
                case 3: answer = "среда"; break;
                
                case 4: answer = "четверг"; break;
                
                case 5: answer = "пятница"; break;
                
                case 6: answer = "суббота"; break;
                
                case 7: answer = "воскресение"; break;

                default: answer = "день не найден"; break;
            }

            return answer;
        }

        public string listNums(int x)
        {
            string answer = "";
            
            for (int i = 0; i <= x; i++)
            {
                answer += Convert.ToString(i) + ' ';
            }

            return answer;
        }

        public String chet(int x)
        {
            string answer = "";

            for (int i = 0; i <= x; i += 2)
            {
                answer += Convert.ToString(i) + ' ';
            }

            return answer;
        }

        public int numLen(long x)
        {
            if (x == 0)
            {
                return 1;
            }
            
            int answer = 0;
            int d = 1;

            while (x / d != 0)
            {
                answer++;
                d *= 10;
            }

            return answer;
        }

        public void square(int x)
        {
            for (int _ = 0; _ < x; _++)
            {
                Console.WriteLine(new string('*', x));
            }
        }

        public void rightTriangle(int x)
        {
            int emptys = x - 1;
            int symbols = 1;
            
            for (int _ = 0; _ < x; _++)
            {
                Console.WriteLine(new string(' ', emptys) + new string('*', symbols));
                symbols++;
                emptys--;
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max = 0;
            int ans = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    ans = arr[i];
                }

                if (arr[i] * -1 > max)
                {
                    max = arr[i] * -1;
                    ans = arr[i];
                }
            }

            return ans;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[ins.Length + arr.Length];
            int offset = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pos)
                {
                    for (int j = 0; j < ins.Length; j++)
                    {
                        result[i+j] = ins[j];
                    }

                    offset = ins.Length;
                }

                result[i + offset] = arr[i];
            }

            return result;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] res_arr = new int[arr.Length];
            int counter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                res_arr[i] = arr[arr.Length-counter];
                counter++;
            }

            return res_arr;
        }


        public int[] findAll(int[] arr, int x)
        {
            int counter = 0;

            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i] == x)
                {  counter++; }
            }

            int[] res_arr = new int[counter];
            int idx = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == x)
                { 
                    res_arr[idx] = i;
                    idx++;
                }
            }

            return res_arr;
        }
    }
}
