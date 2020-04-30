using System;

using System.Collections.Generic;

using System.Linq;



namespace strings

{

    class Program

    {

        static void Main(string[] args)

        {

            string helloWorld = "Hello World!";

            System.Console.WriteLine(helloWorld.Substring(6));

            //Substring (startIndex, length)

            System.Console.WriteLine(helloWorld.Substring(6, 5));



            //Strings son inmutables

            string a = "AAA";

            string b = "BBB";



            //Concatenar strings

            a += b; //a = a + b;

            System.Console.WriteLine(a);



            string pineapple = "pineapple";

            string apple = "apple";

            string pen = "pen";



            System.Console.WriteLine(pineapple + apple + pen);



            //Replace

            System.Console.WriteLine("\n\nReplace");

            apple = apple.Replace("a", "A");



            System.Console.WriteLine((pineapple + apple + pen).Replace("apple", "Apple (tm)", true, null));



            System.Console.WriteLine(apple);



            //Split

            System.Console.WriteLine("\n\nSplit");

            string nombres = "John,Johnny,Jason,Jimmy";



            string[] nombresArray = nombres.Split(",");

            foreach (string nombre in nombresArray)

            {

                System.Console.WriteLine($"nombre => {nombre}");

            }



            //Join

            System.Console.WriteLine("\n\nJoin");

            string nombresJoined = String.Join("-", nombresArray);

            System.Console.WriteLine(nombresJoined);





            //Formatting

            System.Console.WriteLine("\n\nFormatting");

            System.Console.WriteLine("[" + nombresArray[0] + ", " + nombresArray[1] + "]");



            //Interpolation

            System.Console.WriteLine($"[{nombresArray[0]}, {nombresArray[1]}]");



            //String.Format

            System.Console.WriteLine(String.Format("[{0}, {1}]", nombresArray[0], nombresArray[1]));

            System.Console.WriteLine(String.Format("[{0}, {1}, {2}, {3}]", nombresArray));



            //Escaped chars

            System.Console.WriteLine("\n\nEscaped chars");

            System.Console.WriteLine("System.Console.WriteLine(\"\\n\\nFormatting\");");



            //Verbatim

            System.Console.WriteLine("\n\nVerbatim");

            System.Console.WriteLine(@"C:\Projects\Program.cs");

            System.Console.WriteLine(@"Línea 1

Línea 2

Línea 3");



            //Padding

            System.Console.WriteLine("\n\nPadding");

            System.Console.WriteLine("8.00".PadLeft(7));

            System.Console.WriteLine("10.00".PadLeft(7));

            System.Console.WriteLine("123.00".PadLeft(7));

            System.Console.WriteLine("1056.00".PadLeft(7));





            //Contains

            System.Console.WriteLine("\n\nContains");

            System.Console.WriteLine(nombres.Contains("John"));

            List<string> nombresList = new List<string>(nombresArray);

            System.Console.WriteLine(nombresList.Contains("Jimmy"));



            //IndexOf

            System.Console.WriteLine("\n\nIndexOf");

            //string nombres = "John,Johnny,Jason,Jimmy";

            int indexOfJimmy = nombres.IndexOf("Jimmy");

            System.Console.WriteLine($"indexOfJimmy => {indexOfJimmy}");

            

            //LastIndexOf

            System.Console.WriteLine("\n\nLastIndexOf");

            int lastIndexOfn = nombres.LastIndexOf("n");

            System.Console.WriteLine($"lastIndexOfJ => {lastIndexOfn}");





            //Case

            System.Console.WriteLine("\n\nCase");



            //Upper case

            System.Console.WriteLine(nombres.ToUpper());

            //Lower case

            System.Console.WriteLine(nombres.ToLower());





            //Convert to array & invert

            System.Console.WriteLine("\n\nConvert to array & invert");



            char[] helloWorldCharArray = helloWorld.ToCharArray();



            Array.Reverse(helloWorldCharArray);



            System.Console.WriteLine(new String(helloWorldCharArray));



            //Simple Invert

            System.Console.WriteLine(new String(helloWorld.Reverse().ToArray()));

            System.Console.WriteLine(String.Concat(helloWorld.Reverse()));

        }

    }

}