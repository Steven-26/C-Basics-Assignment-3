#region Question 1
// Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.

string titleQ1 = "clean code";
string upperTitle = titleQ1.ToUpper();

Console.WriteLine(titleQ1);
Console.WriteLine(upperTitle);

#endregion
#region Question 2
// Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

string title1 = "Clean Code";
string title2 = "Clean Code";

Console.WriteLine(object.ReferenceEquals(title1, title2));

#endregion
#region Question 3
// Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result.

System.Text.StringBuilder sb = new System.Text.StringBuilder();

sb.Append("Book List");
sb.Append(" - Updated");

Console.WriteLine(sb);

#endregion
#region Question 8
// Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".

int pages = 464;

if (pages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}

#endregion
#region Question 9
// Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator.

bool isAvailable = true;

if (pages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}

#endregion
#region Question 10
// Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

string title = "Refactoring";

switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}

#endregion
#region Question 11
// Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300).

string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

Console.WriteLine(sizeLabel);

#endregion
#region Question 12
// Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code.

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}

#endregion
#region Question 13
// Using the same books array, use a while loop to print every book title.

int index = 0;

while (index < books.Length)
{
    Console.WriteLine(books[index]);
    index++;
}
#endregion
#region Question 14
// Write a do-while loop that prints "Checking book..." exactly 3 times.

int count = 0;

do
{
    Console.WriteLine("Checking book...");
    count++;
}
while (count < 3);

#endregion
#region Question 15
// Using the same books array, use a foreach loop to print every book title.

foreach (string book in books)
{
    Console.WriteLine(book);
}

#endregion
#region Question 16
// Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".

foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }

    Console.WriteLine(book);
}

#endregion
#region Question 17
// Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).

foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }

    Console.WriteLine(book);
}

#endregion
#region Question 18
// Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.

void PrintFirstBook()
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine(books[0]);
}

PrintFirstBook();

#endregion
