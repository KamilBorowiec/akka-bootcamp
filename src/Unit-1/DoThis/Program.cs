using System;
using Akka.Actor;
using WinTail.Actors;

namespace WinTail
{
    internal class Program
    {
        public static ActorSystem MyActorSystem;

        private static void Main(string[] args)
        {
            // initialize MyActorSystem
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            var consoleWriterActor = MyActorSystem.ActorOf(Props.Create<ConsoleWriterActor>(), "consoleWriterActor");

            IActorRef tailCoordinatorActor = MyActorSystem.ActorOf(Props.Create<TailCoordinatorActor>(),
                "tailCoordinatorActor");

            // pass tailCoordinatorActor to fileValidatorActorProps (just adding one extra arg)

            IActorRef validationActor = MyActorSystem.ActorOf(Props.Create<FileValidatorActor>(consoleWriterActor),
                "validationActor");
            var consoleReaderActor = MyActorSystem.ActorOf(Props.Create<ConsoleReaderActor>(), "consoleReaderActor");
            // tell console reader to begin
            consoleReaderActor.Tell(ConsoleReaderActor.StartCommand);

            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.WhenTerminated.Wait();
        }
    }
}