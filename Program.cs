using DateTimeAndGeneric_Non_Generic;
DateTime tarix = new DateTime(2002, 10, 4);
Console.WriteLine(tarix.TimeOfDay);

//MyList<int> myIntList = new();
//myIntList.Name = 1; ;

//MyList<int[]> myIntArrList = new();
//Array.Sort();

List<int> list = new ();
list.Add (1);
list.Add((int)15);
list.Add (2);
list.Add (3);
list.Add (4);
list.Add (5);
list[5] = 12;
foreach (int i in list)
{
    Console.WriteLine(i);
}



