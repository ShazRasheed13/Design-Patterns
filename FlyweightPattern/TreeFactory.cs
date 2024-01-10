using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // Flyweight Factory
    public class TreeFactory
    {
        private Dictionary<string,TreeType> treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string name, string color)
        {
            string key = name + color;
            if (!treeTypes.ContainsKey(key))
            {
                treeTypes.Add(key, new TreeType(name, color));
            }
            return treeTypes[key];
        }
    }
}
