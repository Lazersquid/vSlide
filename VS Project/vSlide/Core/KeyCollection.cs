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
        public IEnumerable<Keys> KeyNames
        {
            get { return keyToNameDict.Keys; }
        }

        private Dictionary<Keys, string> keyToNameDict = new Dictionary<Keys, string>();
        public IEnumerable<string> Keys
        {
            get { return nameToKeyDict.Keys; }
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
