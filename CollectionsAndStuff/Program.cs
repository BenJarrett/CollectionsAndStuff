using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            // ALL OF THESE METHODS MUTATE THE ORIGINAL COLLECT //

            // COLLECTION - Any class that can hold a bunch of data // 

            // List<T> //
            // List of String. Or List of Type: String //
            // List<T> is a generic type, a type that requires me to tell it what type of stuff it does/uses //
            // TYPE PERAMETER - In this case, it's a string. Used to tell the List<> how to work //
            var e14Names = new List<string>();

            // ADD SINGLE ITEM TO LIST //
            // Works like push, appends to the end of the list //
            // When we declared it's type as a string, it knows that what you are adding is a string //
            e14Names.Add("Martin");
            e14Names.Add("Chie");
            e14Names.Add("Holly");

            //  ADDING TO SPECIFIC PART OF LIST //
            // .Insert Adding to list to a specific part of the list //
            // Takes in the numeric index of where you want to place the thing and the ?? ReWatch video //
            e14Names.Insert(1, "Chris");

            // Collection Initializer // - curly braces with elements inside //
            var teacherNames = new List<string> { "Nathan", "Jameka", "Dylan", "Tom" };

            // ADD ONE COLLECTION TO ANOTHER //
            e14Names.AddRange(teacherNames);

            // REMOVE ITEM FROM LIST // 
            // Uses something called 'REFERENCE EQUALITY' //
            // Can pass in exactly what you would like to remove //
            e14Names.Remove("Tom");

            // REMOVE BY INDEX //
            // Takes index to remove //
            // Removes Martin from class //
            e14Names.RemoveAt(0);

            // REMOVE BY EXPRESSION //
            // Fat Arrow Function //
            // Creating an inline function and passing a reference to that function to use later // 
            // PREDICATE OF STRINGS //
            e14Names.RemoveAll(name => name.StartsWith("N"));

            // LOOPING OVER LISTS //
            foreach (var name in e14Names)
            {
                Console.WriteLine($"{name} is in e14!");
            }

            // LIST SPECIFIC LOOP, TAKES IN AN ACTION<T> (like a fat arrow function)
            // OPTIMIZED FOR EACH FOR LISTS //
            // ACTIONS OF STRING //
            e14Names.ForEach(name => Console.WriteLine($"{name} is in e14 again!"));

            // GET ITEM AT THE INDEX OF 0 //
            var firstStudent = e14Names[0];

            // DICTIONARY<TKey, TValue> // - Takes in two type perameters // -- OPEN GENERIC (no one has specified what type of thing it is yet //
            // TKey thing to look up by //
            // TValue is the data being stored //
            // ARITY // (`2) -> How many generic type parameters a type has. Dictionaty`2 //
            // Like a physical dictionary, kinda //
            // GOOD FOR WHEN YOU DON'T KNOW THE LOCATION OF SOMETHING AND WANT TO GET IT BACK //
            // Keys have to be unique //
            // Can be keyed by anything //
            // Value you can be any type as well //
            // This dictionary is keyed by strings, and has string values //

            var dictionary = new Dictionary<string, string>(); // CLOSED GENERIC // We have told it how to behave //

            // ADDING TO DICTIONARIES //
            // Requires a key and a value //
            dictionary.Add("Penultimate", "Second to last");
            dictionary.Add("Jib", "The things that stick out of rollercoasters");
            dictionary.Add("Arbitrary", "Someone who doesn't like Arby's");

            // Get one thing based on it's key
            var definition = dictionary["Arbitrary"]; // Case Sensitive // 

            // THIS WILL NOT WORK //
            // Dictionaries require each key to be unique //
            // If a key exists, you can't add that thing again //
            // Causes an exception //
            // Duplicate Key Exception //
            //dictionary.Add("Penultimate", "Things said to many times at the Olympics");

            // DICTIONARY HELPER METHODS //

            // TRY METHODS //
            // Returns bool that specifies indicating success or failure // 

            // If this is not able to be added to the dictionary, then do something else //
            // Expensive way to figure it out // Better way below //
            //if (!dictionary.TryAdd("Penultimate", "Things said to many times at the Olympics"))
            //{
            //    Console.WriteLine("Its already in the dictionary, I couldn't add it");
            //}

            // LESS EXPENSIVE WAY TO DO IT // 
            // If a the key "Penultimate" is there, set this value to the string below //
            if (dictionary.ContainsKey("Penultimate"))
            {
                dictionary["Penultimate"] = "Things said too many times at the olympics";
            }

            // LOOK AT ALL VALUES OF DICTIONARY //

            // Give me all of the Keys in a collection//
            var allThewords = dictionary.Keys;

            // ITERATION OVER DICTIONARIES // 
            // Item is a type that holds two different values // A KEY VALUE PAIR //

            // ONE WAY TO DO THIS //

            //foreach (var item in dictionary)
            //{
            //    // Print the Key and the Value of that key //
            //    Console.WriteLine($"{item.Key}'s definition is {item.Value}");
            //}


            // SECOND WAY TO DO THIS //

            // DESTRUCTURE //
            // Prefer this way to do it //
            // Better Readability //
            // Taking Key Value pairs and turning them into discreet variables inside the ForEach Loop //

            foreach (var (word, def) in dictionary)
            {
                Console.WriteLine($"{word}'s definition is {def}");
            }


            var complicatedDictionary = new Dictionary<string, List<string>>();

            complicatedDictionary.Add("Soup", new List<string> { "Hot or cold liquid you eat." } );
            var soupDefinitions = complicatedDictionary["Soup"];
            soupDefinitions.Add("This is a definition of soup");

            complicatedDictionary.Add("Arity", new List<string> { "A definition of arity" });

            foreach (var (word, definitions) in complicatedDictionary)
            {
                Console.WriteLine(word);
                foreach(var def in definitions)
                {
                    Console.WriteLine($"\t{def}");
                }
            }


            // HASHSET<T>

            // Like a List in that they store a value at an index // 
            // Like a Dictionary in that the value has to be unique //
            // Completely different in that it eliminates non-unique stuff without errors //
            // pretty slow at adding data // 
            // Super Fast GETTING data out, COMPARING data //
            // Uses HASHCODES to figure out UNIQUENESS //

            // Only store UNIQUE VALUES //
            // This will only store two names // 
            // Only stores ONE COPY of something //

            // ADDING //
            // ** Returns true if added, false if it's already there ** //
            var uniqueNames = new HashSet<string>();
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Dylan");
            uniqueNames.Add("Dylan");
            uniqueNames.Add("Dylan");

            // REMOVE // 
            uniqueNames.Remove("Dylan");

            foreach(var name in uniqueNames)
            {
                Console.WriteLine($"{name} is unique");
            }



            // QUEUE<T> //
            // FIFO based collection // - First in, first out. 
            // If I put something in first, I will get it out first //

            var queue = new Queue<int>();

            // ADDING //
            // ALWAYS adds to the end of the line //
            // USED FOR // Things that have to be done in order // 
            // REAL WORLD EXAMPLE // Customer Reports // Queue to make sure the customers get their reports in order //
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(2);
            queue.Enqueue(100);
            queue.Enqueue(6);

            // ITERATION OVER QUEUE (Looping) //
            // Go through the queue until it's empty //
            // While there is still stuff in a queue, take away from the queue // 
            // DEQUEUE // -Removes from the front of the line and makes sure that isn't added or taken away from the queue again //
            while(queue.Count > 0)
            {
                Console.WriteLine($"dequeuing {queue.Dequeue()}");
            }


            // STACK<T> // - OPPOSITE OF QUEUE //
            // LIFO based collections // Last In, Last Out //
            // Thinhs done in order, but with a bias towards recency // 
            // Last thing I put in should be the first thing I deal with //

            var stack = new Stack<int>();

            // ADDING TO STACK //
            stack.Push(2);
            stack.Push(5);
            stack.Push(12);
            stack.Push(24);
            stack.Push(23);
            stack.Push(200);

            // REMOVING FROM STACK // Same thing as Dequeuing, but in the opposite manor // 
            // While the count is greater than 100, 
               
            while(stack.Count > 0)
            {
                Console.WriteLine($"popping {stack.Pop()}");
            }


        }
    }
}
