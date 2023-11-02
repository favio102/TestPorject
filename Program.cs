// See https://aka.ms/new-console-template for more information
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(1);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");
// Console.WriteLine(Int32.MinValue);
// Console.WriteLine(Int32.MaxValue);

// unit 5 0f 8

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// -----------Decision logic game 1st version

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // test the code
// // roll1 = 4;
// // roll2 = 6;
// // roll3 = 5;
// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//   if ((roll1 == roll2) && (roll2 == roll3)) {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
//   } else {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
//   }
// }

// if (total >= 15) {
//   Console.WriteLine($"Score: {total}\nYou win!");
//   }
// else {
//   Console.WriteLine($"Score: {total}\nSorry, you lose.");
// }
// -----------Decision logic game 2nd version

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // // test the code
// // roll1 = 4;
// // roll2 = 2;
// // roll3 = 1;

// int total = roll1 + roll2 + roll3;

// // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//   if ((roll1 == roll2) && (roll2 == roll3)) {
//     // Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
//   } else {
//     // Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
//   }
// }

// if (total >= 16) {
//   // Console.WriteLine("You win a car!");
//   } else if (total >= 10) {
//   // Console.WriteLine("You win a laptop!");
//   } else if (total == 7) {
//     // Console.WriteLine("You win a trip!");
//   } else {
//     // Console.WriteLine("You win a kitten!");
//   }


// ----  Complete a challenge activity to apply business rules

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;
//   Console.WriteLine(daysUntilExpiration);
// // Your code goes here
// // daysUntilExpiration = 11;
// if (daysUntilExpiration == 0) {
//   Console.WriteLine("Your subscription has expired.");
// } else if (daysUntilExpiration == 1) {
//   discountPercentage = 20;
//   Console.WriteLine($"Your subscription expires within a day!");
// } else if (daysUntilExpiration <= 5) {
//   discountPercentage = 10;
//   Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
// } else if (daysUntilExpiration <= 10) {
//   Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0) {
//   Console.WriteLine($"Renew now and save {discountPercentage}%!");
// }




// ----------------------------------------------------------
// Store and iterate through sequences of data using Arrays and the foreach statement in C#

/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";*/
// fraudulentOrderIDs[3] = "D000";

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reasign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
