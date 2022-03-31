using System;
using System.Collections;
using System.Collections.Generic;
using quen.Queues;
namespace quen
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> que1 = new Queue<string>();
            Que quer = new Que();
            que1.Enqueue("ilkin");
            que1.Enqueue("ehmed");
            que1.Enqueue("ferid");

            foreach (var item in quer.Reserve(que1))
            {
                Console.WriteLine(item);
            } 
        }
    }
}
