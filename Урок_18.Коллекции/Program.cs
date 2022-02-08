using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_18.Коллекции
{
    //Дана строка, содержащая скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы.
    //Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{ })[] скобки расставлены корректно, а в строке([]] — нет.
    //Указание: задача решается однократным проходом по символам заданной строки слева направо;
    //для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
    //каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека(при этом скобка с вершины стека снимается);
    //в конце прохода стек должен быть пуст.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку содержащую скобки (), {}, []:");
            string s = Console.ReadLine();
            Console.WriteLine(Chek(s));
            Console.ReadKey();
        }

        static bool Chek(string s)
        {
            Dictionary<char, char> key = new Dictionary<char, char>();
            key.Add('(', ')');
            key.Add('[', ']');
            key.Add('{', '}');
            Stack<char> st = new Stack<char>();
            Console.WriteLine();
            Console.WriteLine("Результат:");
            foreach (char c in s)
            {
                if (c== '(' || c == '[' || c == '{')
                {
                    st.Push(key[c]);
                    
                }
                if (c== ')' || c== ']' || c == '}')
                {

                    if (st.Count == 0||st.Pop() != c) 
                    {   
                        return false;
                    }
                }
            }
            if (st.Count == 0)
            {  
                return true;
            }
            else
            {  
                return false;
            }
        }
    }
}
