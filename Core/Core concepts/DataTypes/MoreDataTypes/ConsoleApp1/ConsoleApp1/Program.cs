using System;
using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

long total = 0;
for (int i = 0; i < int.MaxValue; i++) {
    total += i;
}
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
Console.WriteLine(stopwatch.ElapsedMilliseconds);
Console.WriteLine(stopwatch.ElapsedTicks);