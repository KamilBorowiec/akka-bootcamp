using System;
using Akka.Actor;
using WinTail.Messages;

namespace WinTail.Actors
{
    /// <summary>
    /// Actor responsible for serializing message writes to the console.
    /// (write one message at a time, champ :)
    /// </summary>
    class ConsoleWriterActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            if (message is InputError error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Reason);
            }
            else if (message is InputSuccess success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(success.Reason);
            }
            else
            {
                Console.WriteLine(message);
            }

            Console.ResetColor();
        }
    }
}
