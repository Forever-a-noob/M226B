using System;

namespace Kompetenzen.HZ3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDogNews objInform = new ImplementIDogNews();
            objInform.handler += new EventHandler(Informed);
            objInform.PublishDogNews();
            Console.ReadLine();
        }

        private static void Informed(object sender, EventArgs e)
        {
            Console.WriteLine("Informed");
        }
    }
}
