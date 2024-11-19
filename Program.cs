namespace loop_task_simple_calcouloter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char choice;
            int number1;
            int number2;
            while (true)
            {

                Console.WriteLine("Choice your operation :\r\nA- Add\r\nB- Sub\r\nC - Mut\r\nD- Divison\r\nE- Exit  ");

                choice = char.Parse(Console.ReadLine());
                switch(choice)
                {


                    case 'A':
                        Console.WriteLine("Enter number one : ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number two : ");
                        number2 = int.Parse(Console.ReadLine());
                              Console.WriteLine( number1 + number2 );

                        break;

                    case 'B':
                        Console.WriteLine("Enter number one : ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number two : ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(number1 - number2);
                        break;

                    case 'C':
                        Console.WriteLine("Enter number one : ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number two : ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(number1 * number2);
                        break;


                    case 'D':
                        Console.WriteLine("Enter number one : ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number two : ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(number1 / number2);
                        break;

                    case 'E': return;
                        break;
                    default: Console.WriteLine("invalid input "); break;
                }




            }

        }
    }
}