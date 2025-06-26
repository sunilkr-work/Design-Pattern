using LiskovSubstitution.HistoryConstraint;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var nonWithdrawableList = new List<NonWithdrawableAccount>();
            var withdrawableList = new List<WithdrawableAccount>();

            FixedDepositAccount fx = new FixedDepositAccount();
            FixedDepositAccount fx1 = new FixedDepositAccount();
            nonWithdrawableList.Add(fx);
            nonWithdrawableList.Add(fx1);
            CurrentAccount cur = new CurrentAccount();
            withdrawableList.Add(cur);
            var client = new Client(nonWithdrawableList, withdrawableList);
            client.processTransaction();
        }
    }
}
