List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};

var max = list.Max();



 
list.RemoveAll(n=>n);
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
if(list==0)
list.Sort();