namespace Calculator
{
    internal class Program
    {
        public static int exitDefenition = 2;
        static void Main(string[] args)
        {   
            calculation();
            while (exitDefenition==1)
            {
                exitDefenition = 2;
                calculation();
            }
        }
        static decimal numInput(string inputStr)
        {
            bool succesIntPars = false;
            decimal inputDec =0;
            while (!succesIntPars) 
            {
                Console.WriteLine("Введите число");
                inputStr = Console.ReadLine();
                succesIntPars = decimal.TryParse(inputStr, out inputDec);
                if (succesIntPars == false)
                    Console.WriteLine("Введены неправильные параметры, повторите ввод числа");
            }
            return inputDec;
        }
        static string operatorInput(string inputStr, decimal num1)
        {
            bool isRightOperator = false;
            while (!isRightOperator)
            {
                Console.WriteLine("Введите оператор");
                inputStr = Console.ReadLine();
                switch (inputStr)
                {
                    case "+":
                        isRightOperator = true;
                        break;
                    case "-":
                        isRightOperator = true;
                        break;
                    case "/":
                        isRightOperator= true;
                        break;
                    case "%":
                        isRightOperator= true;
                        break;
                    case "=":
                        {
                            isRightOperator = true;
                            Console.WriteLine("Результат: " + num1);
                            Console.WriteLine("Для продолжения работы нажмите клавишу\"Exit\" \n Для продолжения работы введите любую другую клавишу ");

                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                exitDefenition = 0;
                                return "=";
                            }
                            else
                            {
                                exitDefenition = 1;
                                return "=";
                            }
                        }
                    default:
                        Console.WriteLine("Введены неверные параметры");
                        break;
                }
            }
            return inputStr;
        }
        static void calculation() 
        {
            string inputStr = "";
            int countInput = 1;
            decimal num1 = 0, num2 = 0, result = 0;
            while (exitDefenition == 2)
            {
                if (countInput % 2 == 1)
                {
                    num1 = numInput(inputStr);
                    if (countInput != 1)
                    {
                        result = operatorDec(result, num1, inputStr);
                    }
                    else
                    {
                        result = num1;
                    }
                }
                else
                {
                    inputStr = operatorInput(inputStr, result);
                }
                countInput++;
            }
        }
        static decimal operatorDec(decimal num1, decimal num2, string inputStr)
        {
            switch (inputStr)
            {
                case "+":
                    num1 += num2;
                    return num1;
                case "-":
                    num1 -= num2;
                    return num1;
                case "/":
                    {
                        if(num2 != 0)
                            num1 /= num2;
                        else
                        {
                            while (num2 == 0)
                            {
                                Console.WriteLine("Деление на ноль невозможно");
                                num2 = numInput(inputStr);
                            }
                            num1 /= num2;
                        }
                    }
                    return num1;
                case "%":
                    num1 = (num1 / 100) * num2;
                    return num1;
                case "=":
                    {
                        return num1;
                    }
                default:
                    {
                        Console.WriteLine("Введены неверные параметры, повторите ввод операции");
                        inputStr = Console.ReadLine();
                        return operatorDec(num1, num2, inputStr);
                    }
            }
        }
    }
}