namespace RabbitMQSample
{
    class Program
    {
        private static readonly string _queueName = "GOKHANGOKALP";
        private static Publisher _publisher;
        private static Consumer _consumer;

        static void Main(string[] args)
        {
            _publisher = new Publisher(_queueName, "Hello RabbitMQ World!");

            _consumer = new Consumer(_queueName);
        }
    }
}