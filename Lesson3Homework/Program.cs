namespace Lesson3Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine(test);
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
                case "12":
                case "1":
                case "2":
                    return "зима";
                case "3":
                case "4":
                case "5":
                    return "весна";
                case "6":
                case "7":
                case "8":
                    return "лето";
                case "9":
                case "10":
                case "11":
                    return "осень";
                default:
                    return "введены неверные данные";
            }
        }
        static string seasonCalculateIf(string monthNumberStr) // Метод для второго задания
        {
            bool succesIntPars = int.TryParse(monthNumberStr, out int monthNumber);
            if (succesIntPars == true & monthNumber <= 12 & monthNumber >= 1)
            {
                if ((monthNumber >= 1 && monthNumber <= 2) | monthNumber == 12)
                {
                    return "зима";
                }
                else
                {
                    if (monthNumber >= 3 && monthNumber <= 5)
                    {
                        return "весна";
                    }
                    else
                    {
                        if (monthNumber >= 6 && monthNumber <= 8)
                        {
                            return "лето";
                        }
                        else
                        {
                            if (monthNumber >= 9 && monthNumber <= 11)
                            {
                                return "осень";
                            }
                            else
                                return "Введено некорректное значение";
                        }
                    }
                }
            }
            else
            {
                return "введены неправильные данные";
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