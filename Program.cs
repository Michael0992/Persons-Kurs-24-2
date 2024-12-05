using System.ComponentModel.Design;

namespace Persons
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Erstelle ein Programm in dem ein User seinen Namen angeben kann
            //Erstelle zudem eine Klasse Person mit den Feldern Name Alter und Beruf
            //Die Klasse hat zudem auch zwei Methoden, einmal die Methode <Begruessung> die den User mit seinem Namen begrüsst und sich selbst vorstellt.
            //Die zweite Methode heißt <Infos> und gibt im Format Name: ... Alter: ... Beruf: ... die Informationen über das Jeweilige Objekt aus (Person)
            //Erstelle aus der Klasse Person zwei Objekte und befühle die Felder.
            //Erstelle dann ein Menü wo man auf jedes Objekt zugreifen kann und die Metoden von diesen Objekten ausführen kann.

            Console.Write("Hallo User! bitte gib deinen Namen ein: ");
            string userName = Console.ReadLine();

            Person person1 = new Person("Maria", 31 , "Metzger");
            Person person2 = new Person("Reiner", 40, "Programmierer");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Wähle eine Person aus (1 - 2):\n\n1.{person1.Name}\n2.{person2.Name}");
                string input = Console.ReadLine();

                if (input == "1") Menu(person1, userName);
                else if (input == "2") Menu(person2, userName);
				else
                {
                    Console.WriteLine("Deine Eingabe war nicht korrekt!");
                    Console.ReadKey();
                    Console.Clear();
                }

                
            }
        }

        public static void Menu(Person person, string userName)
        {
			Console.Clear();
			Console.WriteLine("Soll die person dich begrüßen oder sollen ihre Infos ausgegeben werden (1 - 2):\n1.Begrüßung\n2.Infos");
			string input = Console.ReadLine();

			if (input == "1")
			{
				Console.Clear();
				person.Begruessung(userName);
				Console.ReadKey();
			}
			else if (input == "2")
			{
				Console.Clear();
				person.Infos();
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Deine Eingabe ist Fehlerhaft!");
				Console.ReadKey();
			}
		}
	}
}
