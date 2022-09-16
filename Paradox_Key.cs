using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Paradox_Key
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            //variaveis
            char q1, q2, q3, q4, q5, q6;

            Console.WriteLine("PARADOX KEY"+"                           "+"By Sii");

            do
            {
                Console.WriteLine("Are all possible explanations for the paradox contradictory*? Y/N/*");
                q1 = char.Parse(Console.ReadLine());


                if (q1 == 'Y' || q1 == 'y')
                {
                    Console.WriteLine("This is a LOGICAL CONTRADICTION");

                }
                else if (q1 == '*')
                {
                    Console.WriteLine("*All possible explanations being contradictory means the situation itself is impossible\n");

                }
                else if (q1 == 'N' || q1 == 'n')
                {
                    Console.WriteLine("Does a known correct explanation exist? Y/N");
                    q2 = char.Parse(Console.ReadLine());

                    if (q2 == 'N' || q2 == 'n')
                    {
                        Console.WriteLine("This is a NORMAL IMPOSSIBLE QUESTION");
                    }
                    else if (q2 == 'y' || q2 == 'Y')
                    {
                        Console.WriteLine("Is that explanation/information secret? Y/N");
                        q3 = char.Parse(Console.ReadLine());

                        if (q3 == 'Y' || q3 == 'y')
                        {
                            Console.WriteLine("This is NOT a paradox");
                        }
                        else if (q3 == 'N' || q3 == 'n')
                        {
                            Console.WriteLine("Does the correct information appear to be counterintuitive? Y/N");
                            q4 = char.Parse(Console.ReadLine());

                            if (q4 == 'Y' || q4 == 'y')
                            {
                                Console.WriteLine("This is a COUNTERINTUITIVE FACT");
                            }
                            else if (q4 == 'N' || q4 == 'n')
                            {
                                Console.WriteLine("Does a common,incorrect explanation appear to be contradictory? Y/N");
                                q5 = char.Parse(Console.ReadLine());

                                if (q5 == 'Y' || q5 == 'y')
                                {
                                    Console.WriteLine("This is a MATH PRANK");
                                }
                                else if (q5 == 'N' || q5 == 'n')
                                {
                                    Console.WriteLine("Do people call this a «paradox»?");
                                    q6 = char.Parse(Console.ReadLine());

                                    if (q6 == 'Y' || q6 == 'y')
                                    {
                                        Console.WriteLine("This is ONE GUY GETTING VERY CONFUSED, WRITING IT DOWN AND GETTING IT PUBLISHED");

                                    }
                                    else if (q6 == 'N' || q6 == 'n')
                                    {
                                        Console.WriteLine("This is not a Paradox");
                                    }
                                }
                            }
                        }
                    }

                }
            } while (q1 == '*');



            Console.ReadLine();
        }
    }
}
