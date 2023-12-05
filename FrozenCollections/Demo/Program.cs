using System.Collections.Frozen;
using System.Collections.Immutable;

var list = new List<int> { 1, 2, 2, 3 };

var hashSet = list.ToHashSet();

var immutableHashSet = list.ToImmutableHashSet();

var frozenSet = list.ToFrozenSet();

Console.WriteLine("Hello, World!");