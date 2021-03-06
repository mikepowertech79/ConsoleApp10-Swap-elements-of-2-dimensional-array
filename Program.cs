﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_Swap_elements_of_2_dimensional_array
{


    //source https://social.msdn.microsoft.com/Forums/en-US/a6548856-8828-40c5-8dba-a4ad037f1fff/swap-elements-of-2dimensional-array?forum=csharplanguage

    //ok
    public class Sample
    {
        private double[,] data;

        public double this[int i, int j]
        {
            get
            {
                return data[i, j];
            }
            set
            {
                data[i, j] = value;
            }
        }

        public Sample()
        {
            data = new double[10, 10];
        }

        static void Main(string[] args)
        {
            var p1 = new Sample();
            var p2 = new Sample();

            //https://www.youtube.com/watch?v=T8ErAYobcbc


            //p1[0, 0] = 0;

            int m = 10;
            int n = 10;

            int ii = 0;//row
            int jj = 0;//column

            //for (int k = 0; k < m - 1; k++)
            //{
            //    ii = k;
            //    jj = 0;
            //    while (ii >= 0)
            //    {

            //        Console.WriteLine("P1[0,0] = {0} \nP2[0,0] = {1}\n", p1[0, 0], p2[0, 0]); 

            //    }
            //    {
                    
            //    }

            //}




            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    p2[i, j] = 5;

                }

            }
            p2[0, 0] = 10;




            Console.WriteLine("P1[0,0] = {0} \nP2[0,0] = {1}\n", p1[0, 0], p2[0, 0]);
            Swap(p1, p2, 0, 0, 0, 0);
            Console.WriteLine("P1[0,0] = {0} \nP2[0,0] = {1}", p1[0, 0], p2[0, 0]);
            Console.ReadKey();
        }

        public static void Swap(Sample a1, Sample a2, int x1, int y1, int x2, int y2)
        {
            double temp = a1[x1, y1];
            a1[x1, y1] = a2[x2, y2];
            a2[x2, y2] = temp;
        }

        
    }
}