bool close = false;
List<string> names = new List<string>();
do
{
    Console.Clear();
    Console.WriteLine("1. Voeg naam toe");
    Console.WriteLine("2. Toon alle namen");
    Console.WriteLine("3. Zoek een naam");
    Console.WriteLine("4. Verwijder een naam");
    Console.WriteLine("5. Toon het aantal namen");
    Console.WriteLine("6. Stoppen");
    Console.Write("Kies een optie: ");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Write("Naam: ");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("ongeldige ingaven");
                Console.ReadKey(true);
            }
            else
            {
                names.Add(name);
            }
            break;
        case "2":
            Console.WriteLine(String.Join(Environment.NewLine, names));
            Console.ReadKey(true);
            break;
        case "3":
            Console.Write("Geef de naam die u wil zoeken: ");
            name = Console.ReadLine();

            int index = names.IndexOf(name);

            if (index == -1)
            {
                Console.WriteLine($"{name} niet gevonden.");
            }
            else
            {
                Console.WriteLine($"{name} gevonden op positie {index + 1}!");
            }
            Console.ReadKey(true);
            break;
        case "4":
            Console.Write("Geef de naam die u wilt verwijderen: ");
            name = Console.ReadLine();

            Console.WriteLine($"{name} Verwijderd!");
            names.Remove(name);
            
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine($"De lijst telt {names.Count} namen.");
            Console.ReadKey(true);
            break;
        case "6":
            close = true;
            break;
        
        
    }
}while(close == false);
