using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace quen.Queues
{
    class Que
    {
        Queue ques;
        Stack reverse;
        Queue<string> reversque;
        public Que()
        {
            ques = new Queue();
            reverse = new Stack();
            reversque = new Queue<string>();
        }

        

        public Queue<string> Reserve(Queue<String> word)
        {
            foreach (var item in word)
            {
                reverse.Push(item); 
            }

            foreach (var item in reverse)
            {
                reversque.Enqueue((string)item);
            }
            return reversque;
        }
    }
}
