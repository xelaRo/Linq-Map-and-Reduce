// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Map with Select 
Console.WriteLine("Map with Select");
string[] strings = { "1", "2", "3", "4", "5" };

IEnumerable<int> squared =
    strings
    .Select(int.Parse)
    .Select(x => x * x);

foreach (var item in squared)
{
    Console.WriteLine(item);
}


//Map with SelectMany 
Console.WriteLine("Map with SelectMany");

List<List<int>> numbers = new List<List<int>>() {
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 }
};

IEnumerable<int> flattened =
    numbers
    .SelectMany(innerList => innerList);

foreach (var item in flattened)
{
    Console.WriteLine(item);
}

//Reduce with Aggregate 
Console.WriteLine("Reduce with Aggregate");

int[] reduceNumbers = { 1, 2, 3, 4, 5 };
int sum = reduceNumbers.Aggregate((acc, x) => acc + x);

Console.WriteLine(sum);

Console.ReadKey();
