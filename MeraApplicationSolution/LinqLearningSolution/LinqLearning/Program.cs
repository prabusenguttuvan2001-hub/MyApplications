
Console.WriteLine("Hello, World!");
int[] arr = { 21,28, 8, 4, 2001, 2003};
var dates = from dt in arr
           where dt == 28
           select dt;
foreach (var dt in dates)
    Console.WriteLine(dt);
