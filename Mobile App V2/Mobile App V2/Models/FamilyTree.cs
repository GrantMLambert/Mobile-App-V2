using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_App_V2.Models
{
    public class FamilyTree
    {
        abstract class Individual
        {
            public string Name { get; set; }
        }

        class Child : Individual { }

        class Parent : Individual { public List<Individual> Children { get; set; } }

        class Ancestor : Parent { }

        private static void DisplayFamilyTree(Individual individual, int indent = 0)
        {
            var indentLines = new string(' ', indent);

            if (individual is Parent)
            {
                Console.WriteLine(indentLines + "*" + individual.Name);
                var parent = individual as Parent;
                foreach (var child in parent.Children)
                {
                    DisplayFamilyTree(child, indent + 2);
                }
            }
            else
            {
                Console.WriteLine(indentLines + "-" + individual.Name);
            }
        }
    }
}
