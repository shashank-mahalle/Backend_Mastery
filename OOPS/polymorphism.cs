// public class PaymentMethod
// {
//     public virtual void Process(decimal amount)
//         => Console.WriteLine($"Processing ₹{amount:N2}");
// }

// public class CreditCard : PaymentMethod
// {
//     public override void Process(decimal amount)
//         => Console.WriteLine($"💳 CC charged ₹{amount:N2} + ₹{amount * 0.025m:N2} fee");
// }

// public class UPI : PaymentMethod
// {
//     public override void Process(decimal amount)
//         => Console.WriteLine($"📱 UPI transferred ₹{amount:N2} — zero fee");
// }

// // ONE method, ALL types — polymorphism in action
// // void ExecutePayment(PaymentMethod method, decimal amount)
// //     => method.Process(amount);  // runtime picks correct version

// ExecutePayment(new CreditCard(), 10000m);
// ExecutePayment(new UPI(), 5000m);
// // Add BNPL tomorrow → one new class, zero changes here