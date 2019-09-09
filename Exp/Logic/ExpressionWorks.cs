using System.Collections.Generic;

namespace ExspressionWorks
{
    public class ExpressionWorks

    {
        private readonly Dictionary<string, byte> Operators = new Dictionary<string, byte>
            {
                { "/", 0 },
                { "*", 1 },
                { "-", 2 },
                { "+", 3 }
            };
        private List<string> ParseExp(string expresion)
        {
            var charArray = expresion.ToCharArray();
            var strList = new List<string>();
            bool isNumber = false;
            bool isFraction = false;
            bool isOperation = false;
            var tempString = "";
            short countBracket = 0;
            Stack<string> stackOperations = new Stack<string>();
            List<string> resultString = new List<string>();

            foreach (char ch in charArray)
            {
                if (char.IsDigit(ch))
                {
                    isNumber = true;
                    isOperation = false;
                    isFraction = false;
                    tempString += ch;
                }
                else if (!char.IsDigit(ch) && (ch == '.' || ch == ',') && isNumber && !isFraction)
                {
                    isFraction = true;
                    isOperation = false;
                    tempString += ',';
                }
                else if (!char.IsDigit(ch) && !(ch == '.' || ch == ','))
                {
                    isFraction = false;
                    isNumber = false;

                    if (tempString != "")
                    {
                        strList.Add(tempString);
                        tempString = "";
                    }
                    if (ch == '(')
                    {
                        strList.Add(ch.ToString());
                        countBracket++;
                    }
                    else if (ch == ')')
                    {
                        if (countBracket == 0)
                        {
                            return null;// "Error! Wrong expression! Check brackets.";
                        }
                        strList.Add(ch.ToString());
                        countBracket--;
                    }
                    else if (Operators.ContainsKey(ch.ToString()))
                    {
                        if (isOperation)
                        {
                            return null;//"Error! Wrong expression! Check operations!";
                        }
                        isOperation = true;
                        strList.Add(ch.ToString());
                    }
                }
            }
            if (isNumber)
            {
                strList.Add(tempString);
                tempString = "";
                isNumber = false;
            }
            if (countBracket != 0)
            {
                return null;//"Error! Wrong expression! Check brackets.";
            }
            strList.Reverse();

            foreach (string element in strList)
            {
                if (float.TryParse(element, out float number))
                {
                    resultString.Add(element);
                }
                else if (element == ")")
                {
                    stackOperations.Push(element);
                }
                else if (element == "(")
                {

                    while (stackOperations.Peek() != ")")
                    {
                        resultString.Add(stackOperations.Pop());
                        if (stackOperations.Count == 0)
                        {
                            break;
                        }
                    }
                    stackOperations.Pop();
                }
                else if (Operators.ContainsKey(element))
                {
                    if (stackOperations.Count != 0 && stackOperations.Peek() == ")")
                    {
                        stackOperations.Push(element);
                        continue;
                    }
                    if (stackOperations.Count != 0 && Operators[element] > Operators[stackOperations.Peek()])
                    {
                        while (stackOperations.Count != 0 && stackOperations.Peek() != "(")
                        {
                            resultString.Add(stackOperations.Pop());
                        }
                        stackOperations.Push(element);
                    }
                    else
                    {
                        stackOperations.Push(element);
                    }
                }
            }
            while (stackOperations.Count != 0)
            {
                resultString.Add(stackOperations.Pop());
            }
            return resultString;

        }
        private float ExecuteOperation(float first, float second, string operatorEx)
        {
            switch (operatorEx)
            {
                case "+": return first + second;
                case "-": return first - second;
                case "*": return first * second;
                case "/": return first / second;
                default: return 0;
            }
        }
        private float CalculateExp(List<string> listStr)
        {
            Stack<float> stackEx = new Stack<float>();
            foreach (string item in listStr)
            {
                if (float.TryParse(item, out float number))
                {
                    stackEx.Push(number);
                }
                else
                {
                    stackEx.Push(ExecuteOperation(stackEx.Pop(), stackEx.Pop(), item));
                }
            }
            return stackEx.Pop();
        }
        public string GetResult(string expression)
        {
            var listStrings = ParseExp(expression);
            return CalculateExp(listStrings).ToString();
        }
    }
}
