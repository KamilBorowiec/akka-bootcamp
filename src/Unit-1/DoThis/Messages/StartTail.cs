using Akka.Actor;

namespace WinTail.Messages
{
    public class StartTail
    {
        public StartTail(string filePath, IActorRef reporterActor)
        {
            FilePath = filePath;
            ReporterActor = reporterActor;
        }

        public string FilePath { get; private set; }

        public IActorRef ReporterActor { get; private set; }
    }
}