using System;

namespace Alons_CloverByte_Test
{
    public class Stage1
    {
        private int _exerciseNum = 0;
        public int ExerciseNum { get => _exerciseNum; set => _exerciseNum = value; }


        private int[] _arrayToInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int[] ArrayToInput { get => _arrayToInput; set => _arrayToInput = value; }


        #region Exercise 1

        // 1.1, 1.2, 1.3, 1.4
        public int[] ReverseArray(int[] inputArray)
        {
            int[] tempArray = inputArray;
            int[] reversedArray;

            /* "reversedArray" was made only to change the name of the returned array to "reversedArray",
               if counts as a second array for this exercise then instead I would return "inputArray"      */

            switch (_exerciseNum)
            {
                // 1.1 Prints it in reverse.
                case 1:
                    Array.Reverse(tempArray);
                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        Console.WriteLine(tempArray[i]);
                    }
                    reversedArray = null;
                    break;

                // 1.2 Returns an int[] reversedArray of inputArray (the same values, but 	reversed).
                case 2:
                    Array.Reverse(tempArray);
                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        Console.WriteLine(tempArray[i]);
                    }
                    reversedArray = tempArray;

                    Console.WriteLine();
                    Console.WriteLine($"The method returned {reversedArray} with {reversedArray.Length} items inside");
                    break;

                /* 1.3 Returns a reversed array of inputArray, but you can only use 1 simple variable
                   (you can create 1 simple int or bool, but you can’t create another array!). */
                case 3:
                    for (int i = 0; i < inputArray.Length / 2; i++)
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[inputArray.Length - i - 1];
                        inputArray[inputArray.Length - i - 1] = temp;
                    }

                    foreach (int item in inputArray)
                    {
                        Console.WriteLine(item);
                    }

                    reversedArray = inputArray;
                    break;

                /* 1.4 Same as before, returns an int[] reversedArray… but now you can’t use any other
                   variables(you can use a for loop, which technically adds an int, but that is it!). */
                case 4:

                    Array.Reverse(inputArray);
                    reversedArray = inputArray;

                    for (int i = 0; i < reversedArray.Length; i++)
                    {
                        Console.WriteLine(reversedArray[i]);
                    }
                    break;

                default:
                    Console.WriteLine("The exercies number should be 1.(ExerciseNumber) in 'Program' class");
                    reversedArray = null;
                    break;
            }

            return reversedArray;
        }

        #endregion

        #region Exercise 2

        // 2.1
        /* using a static modifier in a public class would make the class, it's methods & it's variables visable 
         * and usable directly by using the class's name throughout the namespace if they are also public & static without making a reference
         * which means we are accesing the same exact script an not an instant of it.
         * 
         * I have commented out an example in "Program" class to visualize it :) */

        // 2.2
        /* another use of a static modifier is to be used as a container for a sets of methods that you would like to have globaly,
         * just like the "Math" class */

        // 2.3
        /* a static class's members must be initialized so it would be very easy to use it as a class that
         * uses methods, that do certain reoccuring behaviour while also using pre-defined values to do calculations on an argument.
         * 
         * Example from the "Math" class is commented out in "Program" class :) */

        #endregion

        #region Exercise 3

        // 3
        /* the most impactful differance is that members of classes are of reference type,
         * while members of structs are of value type.
         * 
         * value types contains the value written in memory while reference types
         * contains a reference (a pointer) to a different location in memory where the value is held.
         * 
         * also, value types always need to have a value while reference type can be null, so if:
         * 
         * I copy the content of a value type array and paste it into another variable it means I am now
         * creating a whole new array which is unique and different from the one I copied from. (changes in the old wont affect the new & vice versa)
         * 
         * I copy the content of a reference type array and paste it into another variable it means I am now
         * creating another reference or pointer to the same value as the other, which means making changes to one will affect the other */

        #endregion

        #region Exercise 4

        // 4
        /* an array is used to hold a set of a known amount of items which requires simple behaviours right of the bat
         * such as adding items to the array, removing items from the list, accessing an item inside the array and get or set it's value
         * 
         * a list is used to hold a set of an unkown amount of items or when you would want a more comlex behaviour while
         * manipulating the list such as sorting the list, finding an idex of a value in the list, finding an item by it's value
         * plus all the array's behaviour */

        /*** list example 1:
         * if you would like to create a list of cards in a deck of cards which holds a starting amount
         * of 25 cards and later on you would add cards to that list, instead of creating enough slots in the array to hold all of
         * those expected cards you could create a list with 25 slots instansiated and the list would duplicate itself every other
         * 25 slots, making it more flexible and reduce memory useage when undeed
         * 
         *** list example 2:
         * if you would want to use the Linq list behaviours which could save a lot of time and have an even more complex behaviour
         * then that of the list while also keeps expanding while needed and don't need a set amount of items to expect to.
         * 
         *** array example:
         * if you would like to create a list of cards in a deck of cards which holds a starting amount
         * of 25 cards and later on you will not add more cards then that to the list, you might want to take cards out or place them
         * in a certain order or maybe loop through them and see which cards are there */

        #endregion

        #region Exercise 5

        // 5
        // an int[,] is a two dimentional array while an int[][] is an array that hold arrays (called jagged array).

        #endregion

        #region Exercise 6

        // 6
        /* Fibonacci sequence is working by this equation:
         * Fn = fn-1 + fn-2.
         * 
         * Test is commented out in "Program" class*/

        public void GetFibonacciSequenceOf(int n, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                int number = n - 1;
                int[] Fib = new int[number + 1];

                Fib[0] = 0;
                Fib[1] = 1;

                for (int j = 2; j <= number; j++)
                {
                    Fib[j] = Fib[j - 2] + Fib[j - 1];
                }

                Console.WriteLine(Fib[number]);
                n++;
            }
        }

        #endregion

        #region Exercise 7

        // 7
        // example is commented out in "Program" class
        public void DrawSomethingCool(string text)
        {
            foreach (char character in text)
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(60);
            }

            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
        }

        public void DrawSomethingCool2(string text, int wordsInLine)
        {
            char space = ' ';
            int spacesCount = 0;
            foreach (char character in text)
            {
                if (character == space)
                {
                    spacesCount++;
                }

                if (spacesCount == wordsInLine)
                { 
                    Console.WriteLine();
                    spacesCount = 0;
                }
                else
                {
                    Console.Write(character);
                    System.Threading.Thread.Sleep(60);
                }
            }

            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
        }

        #endregion

        #region Exersice 8

        // 8
        /* I really enjoyd learning about polymorphism in C# class with Dor Ben-Dor in relation to object-oriented programming,
         * it helped me realize part of the power and capabilites of c#.
         * 
         * I really came to experience polymorphism while making the 2D Game-Engine project from Dor, what I was doing is that
         * I have created a class name "GameObject" and made most of the classes inherit from it, after that I made a "Ship" class
         * and an "Projectile" class, which was implemented with my own physics class.
         * 
         * So in order to get a certain behaviour from a specific "GameObject" type through their components (that inherit from a "Component" class)
         * just like in unity, I made generic methods in order to find the type of "Component" I'm currently dealing with which looked like this:
         * 
         * public T GetComponent<T>() where T : Component
            {
                Console.WriteLine("Trying to get component");
                if (typeof(T) == null)
                {
                    Console.WriteLine("Did not find component");
                    Console.WriteLine();
                }

                //SearchComponent
                foreach (Component item in _components)
                {
                    if (item.GetType() == typeof(T))
                    {
                        Console.WriteLine($"Found component {item}");
                        return item as T;
                    }
                }

                return null;
            }
         *  
         *  after I got the "GameObject" I had to figure out if they are a "Ship" or a "Projectile" in order to get the specific behaviour
         *  I look for, after that I would determine if the "Spaceship" was of an "Enemy" type or of a "Player" type.
         *  
         *  it came very handy while I was making the collisions, so I would do stuff like this:
         *  
         *  public void CollidesWith(BoxCollider2 anotherCollider)
            {
                GameObject playerObject = GameObjectManager.Instance.FindGameObjectByName("Player");
                Spaceship playerShip = GameObjectManager.Instance.FindGameObjectByName("Player") as Spaceship;

                //be spesific about what type of object I collide with
                if (anotherCollider.GameObjectP as Spaceship == null)
                    return;

                //player projectile dont hits enemy projectile
                if (!(IsPlayerProjectile && (anotherCollider.GameObjectP as Spaceship).IsPlayer && !IsPlayerProjectile && !(anotherCollider.GameObjectP as Spaceship).IsPlayer))
                  {
                    //enemy projectile hits player
                    if (!IsPlayerProjectile && (anotherCollider.GameObjectP is Spaceship) && (anotherCollider.GameObjectP as Spaceship).IsPlayer)
                    {
                        CombatManager.DamagedByEnemyShot((anotherCollider.GameObjectP as Spaceship).SpaceShipProjectile);
                        GameObjectManager.Instance.DestroyGameObject(this);

                        //if player died
                        if ((anotherCollider.GameObjectP as Spaceship).Health <= 0)
                        {
                            (anotherCollider.GameObjectP as Spaceship).IsDefeatedByEnemy = true;
                            GameObjectManager.Instance.DestroyGameObject(anotherCollider.GameObjectP);
                            (anotherCollider.GameObjectP as Spaceship).GameOver();
                            return;
                        }
                    }

                    //enemy projectile hit enemy spaceship
                    else if (!IsPlayerProjectile && (anotherCollider.GameObjectP is Spaceship) && !(anotherCollider.GameObjectP as Spaceship).IsPlayer)
                        GameObjectManager.Instance.DestroyGameObject(this);

                    //player projectile hit enemy spaceship
                    else if (IsPlayerProjectile && (anotherCollider.GameObjectP is Spaceship) && !(anotherCollider.GameObjectP as Spaceship).IsPlayer)
                    {
                        CombatManager.DamagedByPlayerShot((GameObjectP as Spaceship).CurrentWeapon, (anotherCollider.GameObjectP as Spaceship));
                        GameObjectManager.Instance.DestroyGameObject(this);

                        //if enemy died
                        if ((anotherCollider.GameObjectP as Spaceship).Health <= 0)
                        {
                            (anotherCollider.GameObjectP as Spaceship).IsDefeatedByPlayer = true;
                            GameObjectManager.Instance.DestroyGameObject(anotherCollider.GameObjectP);
                            return;
                        }
                    }

                    //player projectile hits player
                    else if (IsPlayerProjectile && (anotherCollider.GameObjectP is Spaceship) && (anotherCollider.GameObjectP as Spaceship).IsPlayer)
                    {

                    }
                }
            }
         * 
         * it's a bit messy and probably could've done it better but I had way less knowledge then.
         *
         */

        #endregion
    }
}
