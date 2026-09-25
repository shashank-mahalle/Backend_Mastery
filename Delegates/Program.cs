
// Two methods that match that signature
decimal ApplyTax(decimal amount)      => amount * 1.18m;
decimal ApplyDiscount(decimal amount) => amount * 0.90m;

// Use the delegate — plug in whichever method you want
Calculator calc = ApplyTax;
Console.WriteLine(calc(1000m)); // 1180

calc = ApplyDiscount;           // swap the method out
Console.WriteLine(calc(1000m)); // 900

// Define delegate — this is the "task slot"
// "I need a method that takes a decimal and returns a decimal"
delegate decimal Calculator(decimal amount);