// See https://aka.ms/new-console-template for more information



//Დაწერეთ პროგრამა რომელიც მასივში დაითვლის თითოეული  ელემენტი რამდენჯერ გვხვდება.

using System.Security.Cryptography.X509Certificates;

int[] numbers = new int [] { 1, 4, 5, 6, 34, 34, 1, 4 };

var groupNumbers =numbers.GroupBy(x => x);

foreach(var groupNumber in groupNumbers)
{
    Console.WriteLine($"number {groupNumber.Key} accurs {groupNumber.Count()} times");
}


Console.ReadKey();

//Დაწერეთ პროგრამა რომელიც დაითვლის სტრინგში თითოეული სიმბოლო რამდენჯერ გვხვდება.


string someText = "anikoShaverda";
var letters = someText.GroupBy(y => y);

foreach(var letter in letters)
{
    Console.WriteLine($"Letter {letter.Key} occurs {letter.Count()} times");
}


Console.ReadKey();


//Დაწერეთ პროგრამა რომელიც სტრინგში (წინადადებაში იპოვნის uppercase-იან სიტყვბს და დაბეჭდავს მათ)


string someString = "SOME string";

var upperCaseLetters = someString.Split(' ').Where(x => string.Equals(x, x.ToUpper()));
foreach(var upperCaseLetter in upperCaseLetters)
{
    Console.WriteLine(upperCaseLetter);
}


//Დაწერეთ პროგრამა რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს.


List<int> intList = new List<int>() { 1, 24, 56, 3, 345, 1, 2, 34, 234, 56, 2, 1, 1, 23, 45, 56 };

var selectNumbers= intList.Skip(5).Take(9).ToList();

foreach(var selectNumber in selectNumbers)
{
    Console.WriteLine(selectNumber);
}



Console.ReadKey();


//Დაწერეთ პროგრამა რომელიც დაბეჭდავს სტრინგში ყველაზე განმეორებად სიმბოლოს.


string myStr = "WednesdayAddams";

var frequentCharacter = myStr.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

Console.WriteLine(frequentCharacter);   