using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public class KeyCollection
    {
        private Dictionary<string, Keys> nameToKeyDict = new Dictionary<string, Keys>();
        public ImmutableArray<Keys> Keys
        {
            get { return keyToNameDict.Keys.ToImmutableArray(); }
        }

        private Dictionary<Keys, string> keyToNameDict = new Dictionary<Keys, string>();
        public ImmutableArray<string> KeyNames
        {
            get { return nameToKeyDict.Keys.ToImmutableArray(); }
        }

        public void Add(Keys key, string keyName)
        {
            keyToNameDict.Add(key, keyName);
            nameToKeyDict.Add(keyName, key);
        }

        public bool ContainsKey(Keys key)
        {
            return keyToNameDict.ContainsKey(key);
        }

        public Keys GetKey(string keyName)
        {
            return nameToKeyDict[keyName];
        }

        public string GetKeyName(Keys key)
        {
            return keyToNameDict[key];
        }
    }
}
