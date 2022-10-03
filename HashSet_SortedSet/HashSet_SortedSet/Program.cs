// HashSet
HashSet<string> hashSet = new HashSet<string>();

hashSet.Add("TV");
hashSet.Add("Notebook");
hashSet.Add("Tablet");

//Console.WriteLine(hashSet.Contains("Notebook"));

// SortedSet
SortedSet<int> firstSortedSet = new SortedSet<int>() { 0, 2, 4, 5, 7, 8, 9, 11 };
SortedSet<int> secondSortedSet = new SortedSet<int>() { 5, 11, 22, 25, 2 };

// Union
SortedSet<int> unionSortedSet = new SortedSet<int>();
unionSortedSet.UnionWith(firstSortedSet);
unionSortedSet.UnionWith(secondSortedSet);

// Intersection
SortedSet<int> intersectionSet = new SortedSet<int>(firstSortedSet);
intersectionSet.IntersectWith(secondSortedSet);

// Difference
SortedSet<int> diferrenceSet = new SortedSet<int>(firstSortedSet);
diferrenceSet.ExceptWith(secondSortedSet);

// Print here your hashset or sortedset
PrintCollection(diferrenceSet);

static void PrintCollection<T>(IEnumerable<T> collection)
{
	foreach (T obj in collection)
	{
		Console.Write(obj + " ");
	}
	Console.WriteLine();
}