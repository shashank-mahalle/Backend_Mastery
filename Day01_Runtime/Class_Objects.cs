// // Blueprint — zero memory used here
// public class BankAccount
// {
//     public string  HolderName { get; set; }
//     public decimal Balance    { get; set; }

//     public void ShowBalance()
//         => Console.WriteLine($"{HolderName}: ₹{Balance:N2}");
// }

// // Objects — each gets OWN heap memory
// // var acc1 = new BankAccount();  // 'new' = heap allocation
// acc1.HolderName = "Shashank";
// acc1.Balance    = 50_000m;

// var acc2 = new BankAccount();  // completely separate object 
// acc2.HolderName = "Rahul";
// acc2.Balance    = 1_20_000m;

// acc1.ShowBalance(); // Shashank: ₹50,000.00
// acc2.ShowBalance(); // Rahul: ₹1,20,000.00