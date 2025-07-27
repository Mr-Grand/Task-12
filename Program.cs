namespace Task_12;

class Program
{
    static void Main(string[] args)
    {
        Enclosure enclosure1 = new("Тигры", 3, "Рррр");
        Enclosure enclosure2 = new("Медведи", 2, "Грараа");
        Enclosure enclosure3 = new("Лягушки", 10, "Ква");
        Enclosure enclosure4 = new("Змеи", 6, "Шшш");
        bool ifStop = true;
        do
        {
            Console.WriteLine("Добро пожаловать в зоопарк! " +
                              "К какому зверинцу вы хотите подойти?" +
                              "\n1) С тиграми" +
                              "\n2) С медведями" +
                              "\n3) С лягушками" +
                              "\n4) Со змеями");
            ConsoleKey input = Console.ReadKey(true).Key;

            Console.WriteLine("Информация о вальере:");
            switch (input)
            {
                case ConsoleKey.D1:
                    enclosure1.ShowEnclosureInfo();
                    break;
                case ConsoleKey.D2:
                    enclosure2.ShowEnclosureInfo();
                    break;
                case ConsoleKey.D3:
                    enclosure3.ShowEnclosureInfo();
                    break;
                case ConsoleKey.D4:
                    enclosure4.ShowEnclosureInfo();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        } while (ifStop);
    }
}