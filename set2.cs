using System;

EmptySet empty = new EmptySet();
EmptySet empty2 = new EmptySet();
EmptySet empty3 = new EmptySet();
EmptySet empty4 = new EmptySet();

PairSet pair = new PairSet();
pair.A = empty;
pair.B = empty2;

PairSet pair2 = new PairSet();
pair.A = empty3;
pair.B = empty4;

Set set = pair.Union(pair2);

Console.WriteLine(pair.IsIn(empty));