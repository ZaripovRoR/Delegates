using Delegates;
Console.WriteLine("привет");
DoubleChainList<string> arr=new DoubleChainList<string>();
arr.Add("1");
arr.Add("2");
arr.Add("3"); 
arr.Add("4");
arr.Add("5");
Predicate<int> predicate = Methods.per;
var newar=arr.SearchCell(2);
Console.WriteLine(newar);
arr.Print();

