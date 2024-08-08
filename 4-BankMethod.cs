// class Bank
// {
//     int? Account;
//     int? Balance = 0;

//     public Bank(int Account, int Balance)
//     {
//         if (Balance < 0)
//         {
//             throw new Exception("Balance must be greater than zero");
//         }
//         else
//         {
//             this.Account = Account;
//             this.Balance += Balance;
//             Console.WriteLine($"Account NO: {Account} Balance: {Balance}");
//         }
//     }
// }
// class Program{
//     static void Main(string[] args){
//     Bank B=new Bank(11111,-96);
//     }
// }