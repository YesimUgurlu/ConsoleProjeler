﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject40
//Fibonacci Numbers oluşturma projemizi FibonacciNumbers class'ı oluşturarak çözelim
//Yani FibonacciNumbers class'ı,ekranda girilen sayıya kadar olan FibonacciNumbers'lar 
//bizim içinde foreach ile gezebileceğimiz bir collection (koleksiyona)çevirsin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ulaşmak istediğiniz Fibonacci sayısını giriniz");
            int hedefFibonacciSayisi = Convert.ToInt32(Console.ReadLine());

            FibonacciNumbers f = new FibonacciNumbers(hedefFibonacciSayisi);

            foreach(int n in f)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
    class FibonacciNumbers : IEnumerable
    {
        private FibonacciEnumerator iter;

        public FibonacciNumbers(int max)
        {
            iter = new FibonacciEnumerator(max);
        }

        public IEnumerator GetEnumerator()
        {
            return iter;
        }
    }
    class FibonacciEnumerator : IEnumerator
    {
        private int currentNumber, nextNumber, maxNumber;
         public FibonacciEnumerator(int max)
        {
            maxNumber = max;
            Reset();
        }
        public object Current
        {
            get
            {
                return currentNumber;
            }
        }
        public bool MoveNext()
        {
            int newNextNumber = currentNumber + nextNumber;
            currentNumber = nextNumber;
            nextNumber = newNextNumber;

            return currentNumber <= maxNumber;
        }
        public void Reset ()
        {
            currentNumber = 0;
            nextNumber = 1;
        }
    }
}
