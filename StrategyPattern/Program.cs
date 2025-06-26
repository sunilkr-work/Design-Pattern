namespace StrategyPattern
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            PhonePe phonePe = new PhonePe();
            UpiTransaction transaction = new UpiTransaction();
            List<IOnlineTransaction> users = new List<IOnlineTransaction>();
            users.Add(phonePe);
            users.Add(transaction);
            User user = new User(users);
            user.Execute();
        }
    }
}
