// using System;
// class BalanceWithdraw{
// int Balance { get; set; }
// int Withdraw { get; set; }

//     public BalanceWithdraw(int Balance,int Withdraw)
//     {
//         if (Balance <=0 || Withdraw <=0)
//         throw new Exception("Balance or Withdraw <= Zero wont be accepted");
//         else{
//         this.Balance = Balance;
//         this.Withdraw = Withdraw;
//         if(this.Balance>=this.Withdraw){
// this.Balance-=this.Withdraw;
// Console.WriteLine($"Remeaning Balance after Withdraw : {this.Balance}");
//         }
//         else
//         throw new ApplicationException("Balance less than Withdraw amount");
//         }
//     }

    
// }
// class Program{
//     static void Main(string[] args){
//         Console.WriteLine("Enter the Balance :- ");
//         int Balance =Convert.ToInt32(Console.ReadLine());
    
//         Console.WriteLine("Enter the Withdraw :- ");
//         int Withdraw = Convert.ToInt32(Console.ReadLine());
//         BalanceWithdraw balance = new BalanceWithdraw(Balance,Withdraw);
//     }
// }