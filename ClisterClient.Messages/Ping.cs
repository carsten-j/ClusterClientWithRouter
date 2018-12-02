namespace ClisterClient.Messages
{
    public class Ping
    {
        public Ping(string msg)
        {
            Msg = msg;
        }

        public string Msg { get; }
    }
}
