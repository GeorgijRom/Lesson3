namespace Lesson3Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            
            Console.WriteLine("Введите номер месяца для первого задания");
            string? monthNumberSwitch = Console.ReadLine();
            Console.WriteLine(seasonCalculateSwitch(monthNumberSwitch));
            
            // Второе задание
            
            Console.WriteLine("Введите номер месяца для второго задания");
            string? monthNumberIf  = Console.ReadLine();
            Console.WriteLine(seasonCalculateIf(monthNumberIf));
            
            // Третье задание
            
            Console.WriteLine("Введите число для проверки на четность");
            string? stringToCheckEven = Console.ReadLine();
            bool succes = int.TryParse( stringToCheckEven, out int numberTocheckeven);
            if(succes == false)
            {
                Console.WriteLine("введены неправильные данные");
            }
            else
            {
                Console.WriteLine(isNumberEven(numberTocheckeven));
            }
            
            // Четвертое задание
            
            Console.WriteLine("Введите температуру на улице");
            string? temperatureStr = Console.ReadLine();
            bool succesPars = double.TryParse(temperatureStr, out double temperature);
            if (succesPars == false)
            {
                Console.WriteLine("введены неправильные данные");
            }
            else
            {
                Console.WriteLine(getTemperatureRating(temperature));
            }
            
            // Задание 5
            Console.WriteLine("Введите номер цвета радуги");
            string rainbowStr = Console.ReadLine();
            bool succesIntPars = int.TryParse(rainbowStr, out int rainbowNum);
            if (succesIntPars == true & rainbowNum <=7 & rainbowNum >=1 )
            {
                Console.WriteLine(getRainvowColour(rainbowNum));
            }
            else
            {
                Console.WriteLine("введены неправильные данные");
            }
            Console.ReadKey();
        }
        static string seasonCalculateSwitch(string monthNumber) //Метод для первого задания
        {
            switch (monthNumber)
            {
                case "1":
                    return "январь";
                case "2":
                    return "февраль";
                case "3":
                    return "март";
                case "4":
                    return "апрель";
                case "5":
                    return "май";
                case "6":
                    return "июнь";
                case "7":
                    return "июль";
                case "8":
                    return "август";
                case "9":
                    return "сентябрь";
                case "10":
                    return "октябрь";
                case "11":
                    return "ноябрь";
                case "12":
                    return "декабрь";
                default:
                    return "введены неверные данные";
            }
        }
        static string seasonCalculateIf(string monthNumber) // Метод для второго задания
        {
            if (monthNumber == "1")
            {
                return "январь";
            }
            else
            {
                if (monthNumber == "2")
                {
                    return "февраль";
                }
                else
                {
                    if (monthNumber == "3")
                    {
                        return "март";
                    }
                    else
                    {
                        if (monthNumber == "4")
                        {
                            return "апрель";
                        }
                        else
                        {
                            if (monthNumber == "5")
                            {
                                return "май";
                            }
                            else
                            {
                                if (monthNumber == "6")
                                {
                                    return "июнь";
                                }
                                else
                                {
                                    if(monthNumber == "7")
                                    {
                                        return "июль";
                                    }
                                    else
                                    {
                                        if (monthNumber == "8")
                                        {
                                            return "август";
                                        }
                                        else
                                        {
                                            if (monthNumber == "9")
                                            {
                                                return "сентябрь";
                                            }
                                            else
                                            {
                                                if (monthNumber == "10") 
                                                {
                                                    return "октябрь";
                                                }
                                                else
                                                {
                                                    if (monthNumber =="11")
                                                    {
                                                        return "ноябрь";
                                                    }
                                                    else
                                                    {
                                                        if (monthNumber == "12")
                                                        {
                                                            return "декабрь";
                                                        }
                                                        else
                                                            return "некорректное значение";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        static string isNumberEven(int number) //метод для третьего задания
        {
            if (number % 2 == 0)
                return "число четное";
            else
                return "число нечетное";
        }
        static string getTemperatureRating(double temperature) // метод для четвертого задания
        {
            if (temperature >-5)
            {
                return "Тепло";
            }
            else
            {
                if (temperature <= -5 & temperature > -20)
                {
                    return "Нормально";
                }
                else
                {
                    if (temperature >= -20)
                    {
                        return "Холодно";
                    }
                    else
                        return "Введенное значение некорректно";
                }
            }
        }
        static string getRainvowColour(int rainbowNum) // метод для пятого задания
        {
            string[] rainbowColours = new string[7] {"красный", "оранжевый", "желтый", "зеленый","голубой","синий","фиолетовый" };
            return rainbowColours[rainbowNum - 1];
        }
    }
    
}