using System;


   internal class BottleIsEmpty : Exception
    {
        public BottleIsEmpty(string message) : base(message)
        {
            Console.WriteLine("Bottle is empty !!!");
        }

    }
