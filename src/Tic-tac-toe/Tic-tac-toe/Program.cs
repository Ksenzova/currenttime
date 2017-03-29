using System;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            Field field = new Field(size);
            Human human = new Human(Symbol.X,size);
            Computer computer = new Computer(Symbol.O,size);
            ArrayFormater<Symbol> formater = new ArrayFormater<Symbol>(field.Positions);
            Judge judge = new Judge(field, size);
            try
            {
                while (!field.IsAllFieldFull())
                {
                    human.Play(field);
                    if (judge.FindWinner(formater))
                    {
                        break;
                    }
                    computer.Play(field);
                    if (judge.FindWinner(formater))
                    {
                        break;
                    }
                    Console.WriteLine(field.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);              
            }    
            finally
            {
                Console.WriteLine(field.ToString());
            }    
            Console.ReadKey();
        }
    }
}
