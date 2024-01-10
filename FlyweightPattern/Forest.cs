using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Forest
    {
        private List<(int x, int y, TreeType treeType)> trees = new List<(int x, int y, TreeType treeType)>();
        private TreeFactory treeFactory = new TreeFactory();

        public void PlantTree(int x, int y, string name, string color)
        {
            trees.Add((x, y, treeFactory.GetTreeType(name, color)));
        }

        public void Display()

        {
            foreach (var tree in trees)
            {
                tree.treeType.Display(tree.x, tree.y);
            }
        }
    }
}
