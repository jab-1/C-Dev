using System;
using System.Collections.Generic;
using System.Collections;
namespace ObjectComparison_Collections;


public class Program
{
    public static void Main(String[] args)
    {
        #region comparing objects
        //var BobOne = new Person("Bob", "Builder") { Age = 25 };
        //var bobTwo = BobOne;
        //var areSame = BobOne.Equals(bobTwo);
        //var bobThree = new Person("Bob", "Builder") { Age = 25 };

        //List<Person> personList = new List<Person>()
        //{
        //    new Person("Cath", "Cookson"),
        //    new Person("Bob", "Builder"){ Age = 25 },
        //    new Person("Dan", "Dare"),
        //    new Person("Amy", "Andrew") { Age = 32 },
        //    new Person("Bob", "Andrew") { Age = 32 },
        //};

        //var hasBob = personList.Contains(BobOne);
        //personList.Sort();
        //personList.ForEach(x => Console.WriteLine(x));
        #endregion

        #region Collections
        var helen = new Person("Helen", "Troy") { Age = 22 };
        var will = new Person("Willian", "Shakespeare") { Age = 457 };

        //-----------------LIST<>-----------------------

        //List<Person> thePeople = new List<Person>()
        //{
        //    helen,
        //    will
        //};
        //thePeople.Add(new Person("Nish", "Mandal"));
        //thePeople.Count();

        //Person[] arr = thePeople.ToArray();

        //var numList = new List<int> { 5, 4, 3, 9, 0 };

        //numList.Add(8);
        //numList.Sort();
        //numList.RemoveRange(1, 2);
        //numList.Insert(2, 1);
        //numList.Reverse();
        //int remove = numList.IndexOf(9);
        //numList.RemoveAt(remove);

        //foreach(int i in numList)
        //{
        //    Console.WriteLine(i);
        //}


        //-----------------LINKED LISTS-----------------------


        //LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
        //thePeopleLinked.AddFirst(helen);
        //thePeopleLinked.AddFirst(will);
        //thePeopleLinked.AddLast(new Person("Nish","Mandal"));

        //foreach(var person in thePeopleLinked)
        //{
        //    Console.WriteLine(person);
        //}


        //-----------------QUEUES-----------------------

        //var myQueue = new Queue<Person>();
        //myQueue.Enqueue(helen);
        //myQueue.Enqueue(will);
        //myQueue.Enqueue(new Person("Jab", "Khan"));

        //foreach (var item in myQueue)
        //{
        //    Console.WriteLine(item);
        //}

        //var first = myQueue.Peek();
        //var serve = myQueue.Dequeue();

        //foreach (var item in myQueue)
        //{
        //    Console.WriteLine(item);
        //}




        //int[] original = new int[] { 1, 2, 3, 4, 5 };
        //int[] reversed = new int[original.Length];
        //var stack = new Stack<int>();
        //foreach (var n in original)
        //{
        //    stack.Push(n);
        //}

        //pop off the stack, which will be fine and continue until our array is full
        //for (int i = 0; i < original.Length; i++)
        //{
        //    reversed[i] = stack.Pop();
        //}

        //-----------------HASHSET-----------------------


        //var peopleSet = new HashSet<Person>()
        //{
        //    helen,new Person("Jasmin","Mandal"), new Person("Andrei", "Aggassi")
        //};
        //foreach (var person in  peopleSet)
        //{
        //    Console.WriteLine(person);
        //}

        //var successMartin = peopleSet.Add(new Person("Martin", "Beard"));
        //var successHelen = peopleSet.Add(new Person("Helen", "Troy") {Age = 22});

        //var morePeople = new HashSet<Person>() { new Person("Cathy", "French"), new Person("Jasmin", "Mandal") };
        //peopleSet.IntersectWith(morePeople);
        //foreach (var person in peopleSet) {

        //    Console.WriteLine(person);
        //}

        //-----------------DICTIONARIES-----------------------

        //var personDictionary = new Dictionary<string, Person>()
        //{
        //    {"helen", helen},
        //    {"sherlock", new Person("Sherlock","Holmes"){Age = 40} }
        //};

        //Person p = personDictionary["sherlock"];

        //string input = "The cat in the hat comes back";
        //input = input.Trim().ToLower();
        //var countDict = new Dictionary<char, int>();

        //foreach (char c in input)
        //{
        //    if (countDict.ContainsKey(c))
        //    {
        //        countDict[c]++;
        //    }
        //    else
        //    {
        //        countDict.Add(c, 1);
        //    }
        //}
        //Console.WriteLine("Dictionary Problem");

        //foreach (var KeyValuePair in countDict)
        //{
        //    Console.WriteLine(KeyValuePair);
        //}

        var theBeatles = new Dictionary<int, string>() { {1, "John" }, { 2, "Paul" } , { 3, "Ringo" }, { 4, "George" } };
        bool isAdded = theBeatles.TryAdd(3, "Nish");
        var beatlesList = theBeatles.Values.ToList();
        var c = theBeatles.Remove(1);
        var d = theBeatles.Keys.Where(x => x % 2 == 0).Sum();



        var test = new Dictionary<string, string>() { { "hello", "yes" }, { "no", "hello" } };

        String test2 = test["hello"];
        Console.WriteLine(test2);
        //[t,3]
        //[h,3]

        //-----------------ARRAYLIST (depreciated)-----------------------

        //do not use arraylists. taken over by list<>;
        //ArrayList al = new ArrayList() { 1, "hello", helen };
        //foreach(var item in al)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

    }


}