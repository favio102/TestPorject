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

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

/* string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/



// -------------------------------------------------------------
// Implement the foreach statement
// --------------------------------------------

// sample
/*string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
  sum += items;
  bin++;
  Console.WriteLine($"bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in the inventory.");*/


// ----------------------------------------------
// Complete a challenge activity for nested iteration and selection statements

/*string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string orderID in orderIDs)
{
  if (orderID.StartsWith("B")){
    Console.WriteLine($"Potentially fraudulent Order IDs are: {orderID}");
  }
}*/


// ----------------------------------------------
// Create readable code with conventions, whitespace, and comments in C#

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
 */
/* Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
} */

// Use whitespace to make your code easier to read

/* Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
 */


// Complete a challenge activity to improve code readability

/*
   This code reverses a message, counts the number of times
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
