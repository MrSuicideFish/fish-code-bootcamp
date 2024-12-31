using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IAnimal
{

}

// Cat MUST implement the contents of IAnimal
public class Cat : IAnimal
{

}

// Animal base class
public class Animal
{

}

/* Multiple-Inheirtance
 * 
 * Lion -------- Tiger
 *         |
 *         |
 *       Liger
 *       
 * - Not Valid in C# -
 * public class Dog : Animal , Cat
 * {
 *
 * }
 * 
 */