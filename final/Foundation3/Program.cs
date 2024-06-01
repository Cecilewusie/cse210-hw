using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating address
        Address address1 = new Address("6 gbemi St", "Legon", "Ac", "00233");
        Address address2 = new Address("9 Underwood st", "Kwashieman", "Ga", "8980");
        Address address3 = new Address("1942 Gardens", "Oyarifa", "OY", "90911");

        // Creating events
        Lectures lectureEvent = new Lectures("Web Fundamentals", "Learn to code in 14 day.", new DateTime(2024, 6, 15), "10:00 AM", address1, "John Dalton", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "Meet professionals from various industries", new DateTime(2024, 6, 20), "5:00 PM", address2, "rsvp@example.com");
        OutDoorGathering outdoorEvent = new OutDoorGathering("Picnic in the Park", "Enjoy a day outdoors with games and food", new DateTime(2024, 7, 4), "12:00 PM", address3, "Sunny with a chance of clouds");

        // Generating marketing messages
        Console.WriteLine("--------Standard Details:--------");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("\n-------Full Details:-----------");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("\n------Short Description:-------");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine();
    }
}