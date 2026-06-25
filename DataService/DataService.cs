using System;
using System.Collections.Generic;
using System.Text;

namespace DataService
{
    public class DataService
    {
        public class CustomStack<T>
        {
            private T[] array;
            private int size;
            private int capacity;

            public CustomStack()
            {
                array = new T[2];
                size = 0;
                capacity = 2;
            }
            private void Resize()
            {
                int newCapacity = capacity * 2;
                T[] newArray = new T[newCapacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                capacity = newCapacity;
            }
            public void Push(T element)
            {
                if (size >= capacity)
                {
                    Resize();
                }
                array[size] = element;
                size++;
            }

            public T Pop()
            {
                if (size == 0)
                {
                    throw new IndexOutOfRangeException("pop из пустого стека");
                }
                size--;
                return array[size];
            }

            public T Top()
            {
                if (size == 0)
                {
                    throw new IndexOutOfRangeException("top из пустого стека");
                }
                return array[size - 1];
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public int Size => size;
        }

        public class ExpressionConverter
        {
            public static bool CheckBrackets(string expression)
            {
                CustomStack<char> stack = new CustomStack<char>();
                Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
                HashSet<char> openBrackets = new HashSet<char> { '(', '[', '{' };
                HashSet<char> closeBrackets = new HashSet<char> { ')', ']', '}' };

                foreach (char c in expression)
                {
                    if (openBrackets.Contains(c))
                    {
                        stack.Push(c);
                    }
                    else if (closeBrackets.Contains(c))
                    {
                        if (stack.IsEmpty()) return false;
                        char top = stack.Pop();
                        if (pairs[c] != top) return false;
                    }
                }
                return stack.IsEmpty();
            }
            public static string InfixToPostfix(string expression)
            {
                StringBuilder output = new StringBuilder();
                CustomStack<char> stack = new CustomStack<char>();

                var tokens = Tokenize(expression);

                foreach (var token in tokens)
                {
                    if (IsOperand(token))
                    {
                        output.Append(token).Append(" ");
                    }
                    else if (token == "(")
                    {
                        stack.Push('(');
                    }
                    else if (token == ")")
                    {
                        while (!stack.IsEmpty() && stack.Top() != '(')
                        {
                            output.Append(stack.Pop()).Append(" ");
                        }
                        if (!stack.IsEmpty()) stack.Pop();
                    }
                    else if (IsOperator(token))
                    {
                        while (!stack.IsEmpty() && GetPriority(stack.Top()) >= GetPriority(token[0]))
                        {
                            output.Append(stack.Pop()).Append(" ");
                        }
                        stack.Push(token[0]);
                    }
                }

                while (!stack.IsEmpty())
                {
                    output.Append(stack.Pop()).Append(" ");
                }

                return output.ToString().Trim();
            }
            public static string InfixToPrefix(string expression)
            {
                var tokens = Tokenize(expression);
                tokens.Reverse();

                StringBuilder reversedExpr = new StringBuilder();
                foreach (var token in tokens)
                {
                    if (token == "(") reversedExpr.Append(") ");
                    else if (token == ")") reversedExpr.Append("( ");
                    else reversedExpr.Append(token).Append(" ");
                }

                string postfix = InfixToPostfix(reversedExpr.ToString());
                var postfixTokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var prefixTokens = new List<string>(postfixTokens);
                prefixTokens.Reverse();

                return string.Join(" ", prefixTokens);
            }

            private static int GetPriority(char c)
            {
                if (c == '(') return 0;
                if (c == '+' || c == '-') return 1;
                if (c == '*' || c == '/') return 2;
                return 3;
            }
            private static List<string> Tokenize(string expression)
            {
                var tokens = new List<string>();
                StringBuilder current = new StringBuilder();
                foreach (char c in expression)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        if (current.Length > 0)
                        {
                            tokens.Add(current.ToString());
                            current.Clear();
                        }
                    }
                    else if ("+-*/()".Contains(c))
                    {
                        if (current.Length > 0)
                        {
                            tokens.Add(current.ToString());
                            current.Clear();
                        }
                        tokens.Add(c.ToString());
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
                if (current.Length > 0) tokens.Add(current.ToString());
                return tokens;
            }

            private static bool IsOperand(string token)
            {
                return !IsOperator(token) && token != "(" && token != ")";
            }

            private static bool IsOperator(string token)
            {
                return token.Length == 1 && "+-*/".Contains(token[0]);
            }
        }
    }
}

