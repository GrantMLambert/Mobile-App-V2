using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_App_V2.Models
{
    
    public class FamilyTree : User
    {
        abstract class Individual
        {
            public string Name { get; set; }
        }

        class Child : Individual { }

        class Parent : Individual { public List<Individual> Children { get; set; } }

        class Ancestor : Parent { }

        private static string DisplayFamilyTree(Individual individual, int generation = 0)
        {
            int newGeneration = generation;

            if (individual is Parent)
            {
                
                var parent = individual as Parent;
                foreach (var child in parent.Children)
                {
                    DisplayFamilyTree(child, generation + 1);
                }
                return newGeneration + individual.Name;
            }
            else
            {
                return newGeneration + individual.Name;
            }
        }
    }
}
