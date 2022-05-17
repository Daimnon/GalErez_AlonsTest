using System;

namespace Alons_CloverByte_Test
{
    internal class Program
    {
        static Stage1 stage1 = new Stage1();

        static void Main(string[] args)
        {
            /********* Stage One *********/

            #region Exercise 1.1 - 1.4
            
            // 1.(ExerciseNumber) Prints it in reverse.
            stage1.ExerciseNum = 1;

            // calling the method
            stage1.ReverseArray(stage1.ArrayToInput);

            #endregion

            #region Exercise 2.1 Example

            //StaticClassExample.YouCanReadMe();
            //Console.WriteLine(StaticClassExample.Num); 
            //Console.WriteLine(StaticClassExample.String); 

            #endregion

            #region Exercise 2.3 Example

            //Console.WriteLine(Math.Tan(56.8f));

            #endregion

            #region Exercise 6 Example

            // insert the number you want to start with and then the amount of number to sequence
            //stage1.GetFibonacciSequenceOf(5, 9);

            #endregion

            #region Exercise 7 Drawing

            // write something and it will "type" it for you
            //stage1.DrawSomethingCool("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the...");
            //stage1.DrawSomethingCool2("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 7);

            #endregion

            /******* Stage One End *******/







            /********* Stage Two *********/

            #region Vector2 Example

            //Vector2 myVector = new Vector2(5, 18);
            //Console.WriteLine(myVector);

            //Vector2 myOtherVector = new Vector2(65, -24);
            //Console.WriteLine(myOtherVector);

            //myVector += myOtherVector;
            //Console.WriteLine(myVector);

            //myVector *= myOtherVector;
            //Console.WriteLine(myVector);

            //myVector /= myOtherVector;
            //Console.WriteLine(myVector);

            //myVector -= myOtherVector;
            //Console.WriteLine(myVector);

            //myVector = myOtherVector + new Vector2(22, 22);
            //Console.WriteLine(myVector);

            #endregion

            /******* Stage Two End *******/
        }
    }
}
