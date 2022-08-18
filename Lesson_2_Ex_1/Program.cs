class Hero
{
    public string Name;

    public string Sex;
    public string Rase;
    public string Class;
    Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила", 0},
        {"Удача", 0},
        {"Ловкость", 0},
        {"Харизма", 0},
        {"Симпатия", 0},
        {"Красноречие", 0}
    };
}


class Program
{
    static void SelectRase(Hero myHero)           // это функция с названием SelectRase
    {
        string[] nameRase = {"Люди","Эльфы","Гномы","Орки","Гоблины"};
        Console.WriteLine("Выбери свою расу");
        Select(nameRase);
        string RaseHero = nameRase[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали расу " + RaseHero);
        Console.WriteLine(new string('-', 50));
        myHero.Rase = RaseHero;
    }

    static void SelectSex(Hero myHero)          
    {
        string[] nameSex = {"Женский","Мужской"};
        Console.WriteLine("Выберете свой пол");
        Select(nameSex);
        string SexHero = nameSex[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine($"Вы выбрали {SexHero} пол");
        Console.WriteLine(new string('-', 50));
        myHero.Sex = SexHero;
    }

     static void SelectClass(Hero myHero)           
    {
        string[] nameClass = {"Воин","Разбойник","Маг","Вор"};
        Console.WriteLine("Выберете свой класс");
        Select(nameClass);
        string ClassHero = nameClass[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        Console.WriteLine(new string('-', 50));
        myHero.Class = ClassHero;
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
        Hero myHero = new Hero();
        Console.WriteLine("Введите ваше имя: ");
        myHero.Name = Console.ReadLine();
        SelectRase(myHero); 
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Все наши характеристики");
        Console.WriteLine("Ваше имя " + myHero.Name);
        Console.WriteLine("Ваш пол " + myHero.Sex);
        Console.WriteLine("Ваша раса " + myHero.Rase);
        Console.WriteLine("Ваш класс " + myHero.Class);
    }
} 