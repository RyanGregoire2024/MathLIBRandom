using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace RandomMathDLL
{
    public class RandomNum
    {
        public static List<string> opAdd = new List<string>();
        public static List<string> names = new List<string>();
        public static List<string> wordName = new List<string>();
        public static Random r = new Random();



        public int Add(int a, int b)
        {
            return Math.Abs(a + b);
        }

        public int Sub(int a, int b)
        {
            return Math.Abs(a - b);
        }

        public int Mul(int a, int b)
        {
            return Math.Abs(a * b);
        }

        public int Div(int a, int b)
        {
            return Math.Abs(a / b);
        }

        public string GetHelloMessage(string message)
        {

            return message.ToUpper();
        }

        public String ProjectName(string name, string x1)
        {
      
              return name +  " " + x1;
        }

        public string getOperator()
        {

            int n = 0;

            opAdd.Add("+");
            opAdd.Add("-");
            opAdd.Add("*");
            opAdd.Add("/");

            n = r.Next(opAdd.Count);

            foreach (var ops in opAdd)
            {
                n = r.Next(opAdd.Count);


                return opAdd[n];

            }

            return opAdd[n];
        }

        public int getRandomNum(int a, int b)
        {
            return r.Next(a, b);
        }




        public static int SetNumber(int num)
        {
            return num;
        }


        public string SetName(string name)
        {

            return name;

        }

        public string WordName(string wordName)
        {
            return wordName;

        }

    }

}
