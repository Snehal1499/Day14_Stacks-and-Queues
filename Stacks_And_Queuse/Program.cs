using System;

namespace Stacks_And_Queuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pushing values to Stack");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();

        }
    }
}
