using System;
using System.Collections.Generic;

namespace ICT2106.ConstantDictionary
{
    class ConstantDictionaryAdapter<K, V> : IConstantDictionary<int, String>
    {
        private readonly IDictionary<int, string> mutableDict;

        public ConstantDictionaryAdapter(IDictionary<int, string> mutableDict)
        {
            this.mutableDict = new Dictionary<int, String>();
            
            // convert mutableDict to readonly dictionary.
            foreach(KeyValuePair<int, String> keypair in mutableDict) {
                this.mutableDict.Add(keypair.Key, keypair.Value);
            }

        }

        public bool ContainsKey(int key)
        {
            return this.mutableDict.ContainsKey(key);
        }

        public bool ContainsValue(String value)
        {
            // loop through each key value pair to see if the value exist
            foreach(KeyValuePair<int, String> kvp in this.mutableDict) {
                if (kvp.Value == value) {
                    return true;
                }
            }

            return false;
        }

        public Dictionary<int, String>.Enumerator GetEnumerator()
        {
            return (Dictionary<int, String>.Enumerator) this.mutableDict.GetEnumerator();
        }

        public bool TryGetValue(int key, out String defaultValue)
        {
            return this.mutableDict.TryGetValue(key, out defaultValue);
        }

    }
}