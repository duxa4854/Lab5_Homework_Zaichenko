//void SayHello() => Console.WriteLine("Hello");
//SayHello();
//
//void Game()
//{
//    string myGame = "GTA V";
//    Console.WriteLine(myGame);
//}
//Game();
//
//Console.Write("Введите своё имя: ");
//string? name = Console.ReadLine();
//Console.Write("Введите ваш язык (русский, немецкий, английский): ");
//string language = Console.ReadLine().ToLower();
//
//void SayHelloRu() => Console.WriteLine($"Привет {name}!");
//void SayHelloEn() => Console.WriteLine($"Hello {name}!");
//void SayHelloDe() => Console.WriteLine($"Guten Tag {name}!");
//
//switch (language)
//{
//    case "английский": SayHelloEn(); break;
//    case "русский": SayHelloRu(); break;
//    case "немецкий": SayHelloDe(); break;
//    default: Console.WriteLine("Язык не найден!"); break;
//}
//
//void Print(string message)
//{
//    Console.WriteLine(message);
//}
//
//Print(message:"Привет");
//Console.WriteLine("Как тебя зовут?");
//Console.Write("Введите своё имя: ");
//string? name2 = Console.ReadLine();
//Print(message:$"Твоё имя : {name2}");
//
//void Sum(int x, int y)
//{
//    int result = x + y;
//    Console.WriteLine($"{x} + {y} = {result}");
//}
//
//Sum(10, 20);
//
//Console.Write("Введите переменную x: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите переменную y: ");
//int y = Convert.ToInt32(Console.ReadLine());
//Sum(x, y);
//
//void PrintPerson(string personName, int age)
//{
//    Console.WriteLine($"Имя: {personName}, возраст: {age}");
//}
//
//PrintPerson("Владимир", 32);
//
//void Person(string name, int age = 18, string vuz = "B0 ВолГУ") =>
//    Console.WriteLine($"Имя: {name} \nВозраст: {age} \nВуз: {vuz}");
//
//Person(name:"Александр");
//Person(name:"Иван", age: 30);
//Person(name:"Дмитрий", age: 20, vuz: "МГУ");
//
//Person(age: 30, name: "Иван");
//Person(vuz: "МГУ", age: 20, name: "Дмитрий");
//
//string GetMessage()
//{
//    return "Hello";
//}
//
//Console.WriteLine(GetMessage());
//
//int Sum2(int a, int b)
//{
//    return a + b;
//}
//
//Sum2(10, 20);
//
//int number = Convert.ToInt32(Console.ReadLine());
//void CheckValue(int number)
//{
//    if (number < 0)
//    {
//        Console.WriteLine("Отрицательное число");
//        return;
//    }
//    Console.WriteLine("Положительное число");
//}
//
//CheckValue(number);
//
//string GetMessage2()
//{
//    return "Hello";
//}
//
//string message = GetMessage2();
//Console.WriteLine(message);
//
//string GetMessage3()
//{
//    return "Hello";
//}
//
//void PrintMessage(string message)
//{
//    Console.WriteLine(message);
//}
//
//PrintMessage(GetMessage3());
//
//string GetMessage4() => "hello";
//int Sum3(int x, int y) => x + y;
//
//string GetHello()
//{
//    return "Hello";
//    Console.WriteLine("After return");
//}
//
//void PrintPerson2(string name, int age)
//{
//    if (age > 120 || age < 1)
//    {
//        Console.WriteLine("Недопустимый возраст");
//        return;
//    }
//    Console.WriteLine($"Имя: {name} Возраст: {age}");
//}
//
//PrintPerson2(name:"Алексей", age:32);
//PrintPerson2(name:"Dunkan", age:1234);
//
//Random random = new Random();
//int number2 = random.Next(0, 100);
//Console.WriteLine($"Случайное число: {number2}");
//double randomDouble = random.NextDouble();
//Console.WriteLine($"Случайное число: {randomDouble}");
//
//void ShowWelcomeMessage() => Console.WriteLine("Добро пожаловать в консольный прогноз погоды!");
//void ShowGoodbyeMessage() => Console.WriteLine("Спасибо за использование нашего прогноза! Хорошего дня!");
//
//string GetWeather()
//{
//    string[] weathers = ["Солнечно", "Облачно", "Дождь", "Снег", "Гроза"];
//    Random random = new Random();
//    int index = random.Next(weathers.Length);
//    return weathers[index];
//}
//
//ShowWelcomeMessage();
//string currentWeather = GetWeather();
//Console.WriteLine($"Погода на сегодня: {currentWeather}");
//ShowGoodbyeMessage();
//
//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}
//
//int factorial = Factorial(4);
//int factorial2 = Factorial(5);
//int factorial3 = Factorial(6);
//Console.WriteLine($"Факториал числа 4 = {factorial}");
//Console.WriteLine($"Факториал числа 5 = {factorial2}");
//Console.WriteLine($"Факториал числа 6 = {factorial3}");
//
//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = 0;
//    int numbers2Sum = 0;
//    foreach (int number in numbers1)
//        numbers1Sum += number;
//    foreach (int number in numbers2)
//        numbers2Sum += number;
//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else if (numbers1Sum < numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers2 больше");
//    else
//        Console.WriteLine("суммы чисел обоих массивов равны");
//}
//
//int[] numbers1 = [1, 2, 3];
//int[] numbers2 = [3, 4, 5, 6, 7];
//Compare(numbers1, numbers2);
//
//void Compare2(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = Sum(numbers1);
//    int numbers2Sum = Sum(numbers2);
//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else if (numbers1Sum < numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers2 больше");
//    else
//        Console.WriteLine("суммы чисел обоих массивов равны");
//    
//    int Sum(int[] numbers)
//    {
//        int result = 0;
//        foreach (int number in numbers)
//            result += number;
//        return result;
//    }
//}
//
//int Sum4(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    
//    bool IsPassed(int number)
//    {
//        return number > limit;
//    }
//    
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number)) result += number;
//    }
//    return result;
//}
//
//int[] numbers3 = [-3, -2, -1, 0, 1, 2, 3];
//int[] numbers4 = [3, -4, 5, -6, 7];
//Console.WriteLine(Sum4(numbers3));
//Console.WriteLine(Sum4(numbers4));
//
//int Sum5(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    
//    static bool IsPassed(int number, int lim)
//    {
//        return number > lim;
//    }
//    
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number, limit)) result += number;
//    }
//    return result;
//}