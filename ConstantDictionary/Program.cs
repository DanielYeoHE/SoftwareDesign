using System;
using System.Collections.Generic;

namespace ICT2106.ConstantDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a test dictionary
            IDictionary<int, String> mutableDict = new Dictionary<int, String>();
            mutableDict.Add(1, "cricket");
            mutableDict.Add(2, "mosquito");
            mutableDict.Add(3, "fly");

            // create an immutable dictionary
            IConstantDictionary<int, String> immutableDict = new ConstantDictionaryAdapter<int, String>(mutableDict);

            // Testing Code
            String value;
            Console.WriteLine("check key '1' " + immutableDict.ContainsKey(1));
            Console.WriteLine("check value 'fly' " + immutableDict.ContainsValue("fly"));
            Console.WriteLine("check tryGetValue key '3' " + immutableDict.TryGetValue(3, out value));
            Console.WriteLine("check tryGetvalue Result: " + value);
            Console.WriteLine("try to modify key 1 value to " + (mutableDict[1] = "Test1"));
            Console.WriteLine("try to modify key 2 value to " + (mutableDict[2] = "Test2"));

            // print the contents of the dictionary
            foreach (KeyValuePair<int, String> keypair in immutableDict)
            {
                Console.WriteLine(keypair.ToString());
            }

            Console.WriteLine();
        }
    }
}
