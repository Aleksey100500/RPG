class Program
{
    static void SelectRase()           // это функция с названием SelectRase
    {
        string[] nameRase = {"Люди","Эльфы","Гномы","Орки","Гоблины"};
        Console.WriteLine("Выбери свою расу");
        Select(nameRase);
        string RaseHero = nameRase[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали расу " + RaseHero);
        Console.WriteLine(new string('-', 50));
    }

    static void SelectSex()          
    {
        string[] nameSex = {"Женский","Мужской"};
        Console.WriteLine("Выберете свой пол");
        Select(nameSex);
        string SexHero = nameSex[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine($"Вы выбрали {SexHero} пол");
        Console.WriteLine(new string('-', 50));
    }

     static void SelectClass()           
    {
        string[] nameClass = {"Воин","Разбойник","Маг","Вор"};
        Console.WriteLine("Выберете свой класс");
        Select(nameClass);
        string ClassHero = nameClass[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        Console.WriteLine(new string('-', 50));
    }

    static void Select(string[] words)
    {
        for( int i = 0; i < words.Length; i++)
        {
            Console.Write(i + 1 + " - " + words[i] + "| ");
        }
        Console.WriteLine("");
    }
    static void Main(string[] args)
    {
        SelectRase(); 
        SelectSex();
        SelectClass();
    }
} 