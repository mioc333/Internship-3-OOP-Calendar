using DR4;
using System.Globalization;
using System;

namespace DR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Radic", "mate.radic@gmail.com");
            person1.Name = "Mate";
            var person2 = new Person("Grubic", "antea.grubic@gmail.com");
            person2.Name = "Antea";
            var person3 = new Person("Lalic", "mario.lalic@gmail.com");
            person3.Name = "Mario";
            var person4 = new Person("Radanovic", "Mirko.radanovic@gmail.com");
            person4.Name = "Mirko";
            var person5 = new Person("Pekic", "klara.pekic@gmail.com");
            person5.Name = "Klara";

            var event1 = new Event();
            event1.Name = "Tango Argentino";
            event1.StartDate = new DateTime(2023, 7, 14, 20, 0, 0);
            event1.EndDate = new DateTime(2023, 7, 14, 22, 0, 0);
            event1.Location = "Tusculum";


            event1.AddEmail(person1.Email);
            event1.AddEmail(person2.Email);

            var event2 = new Event();
            event2.Name = "Mala skola restauracije";
            event2.StartDate = new DateTime(2022, 7, 22, 8, 0, 0);
            event2.EndDate = new DateTime(2022, 7, 25, 12, 0, 0);
            event2.Location = "Gradina";


            event2.AddEmail(person3.Email);
            event2.AddEmail(person4.Email);

            var event3 = new Event();
            event3.Name = "Dalmatia Film Festival";
            event3.StartDate = new DateTime(2023, 7, 27, 19, 30, 0);
            event3.EndDate = new DateTime(2023, 7, 30, 23, 0, 0);
            event3.Location = "Tusculum";

            event3.AddEmail(person1.Email);
            event3.AddEmail(person2.Email);
            event3.AddEmail(person3.Email);
            event3.AddEmail(person4.Email);

            var event4 = new Event();
            event4.Name = "Balet";
            event4.StartDate = new DateTime(2023, 8, 1, 21, 0, 0);
            event4.EndDate = new DateTime(2023, 8, 1, 23, 0, 0);
            event4.Location = "HNK";

            event4.AddEmail(person4.Email);
            event4.AddEmail(person5.Email);

            var event5 = new Event();
            event5.Name = "Koncert";
            event5.StartDate = new DateTime(2023, 8, 2, 17, 0, 0);
            event5.EndDate = new DateTime(2023, 8, 2, 23, 0, 0);
            event5.Location = "Prokurative";

            event5.AddEmail(person1.Email);
            event5.AddEmail(person4.Email);
            event5.AddEmail(person5.Email);

            var event6 = new Event();
            event6.Name = "Priredba";
            event6.StartDate = new DateTime(2023, 8, 5, 16, 45, 0);
            event6.EndDate = new DateTime(2023, 8, 5, 18, 0, 0);
            event6.Location = "Tusculum";

            event6.AddEmail(person2.Email);
            event6.AddEmail(person3.Email);
            event6.AddEmail(person5.Email);

            var event7 = new Event();
            event7.Name = "Trip to Boston";
            event7.StartDate = new DateTime(2023, 8, 14, 5, 0, 0);
            event7.EndDate = new DateTime(2023, 8, 20, 23, 0, 0);
            event7.Location = "Boston";

            event7.AddEmail(person1.Email);
            event7.AddEmail(person2.Email);
            event7.AddEmail(person5.Email);

            var event8 = new Event();
            event8.Name = "Museum of Art";
            event8.StartDate = new DateTime(2023, 8, 21, 12, 0, 0);
            event8.EndDate = new DateTime(2023, 8, 22, 23, 0, 0);
            event8.Location = "Paris";

            event8.AddEmail(person5.Email);

            var event9 = new Event();
            event9.Name = "Birthday";
            event9.StartDate = new DateTime(2023, 9, 1, 18, 0, 0);
            event9.EndDate = new DateTime(2023, 9, 1, 21, 0, 0);
            event9.Location = "Tusculum";

            event9.AddEmail(person3.Email);
            event9.AddEmail(person4.Email);
            event9.AddEmail(person5.Email);

            var event10 = new Event();
            event10.Name = "Koncert";
            event10.StartDate = new DateTime(2023, 9, 3, 16, 0, 0);
            event10.EndDate = new DateTime(2023, 9, 5, 23, 0, 0);
            event10.Location = "Zagreb";

            event10.AddEmail(person1.Email);
            event10.AddEmail(person2.Email);
            event10.AddEmail(person3.Email);
            event10.AddEmail(person4.Email);
            event10.AddEmail(person5.Email);

            person1.Attended(event1.Id, true);
            person1.Attended(event2.Id, false);
            person1.Attended(event3.Id, true);
            person1.Attended(event4.Id, false);
            person1.Attended(event5.Id, true);
            person1.Attended(event6.Id, false);
            person1.Attended(event7.Id, true);
            person1.Attended(event8.Id, false);
            person1.Attended(event9.Id, false);
            person1.Attended(event10.Id, true);

            person2.Attended(event1.Id, true);
            person2.Attended(event2.Id, false);
            person2.Attended(event3.Id, true);
            person2.Attended(event4.Id, false);
            person2.Attended(event5.Id, false);
            person2.Attended(event6.Id, true);
            person2.Attended(event7.Id, true);
            person2.Attended(event8.Id, false);
            person2.Attended(event9.Id, false);
            person2.Attended(event10.Id, true);

            person3.Attended(event1.Id, false);
            person3.Attended(event2.Id, true);
            person3.Attended(event3.Id, true);
            person3.Attended(event4.Id, false);
            person3.Attended(event5.Id, false);
            person3.Attended(event6.Id, true);
            person3.Attended(event7.Id, false);
            person3.Attended(event8.Id, false);
            person3.Attended(event9.Id, true);
            person3.Attended(event10.Id, true);

            person4.Attended(event1.Id, false);
            person4.Attended(event2.Id, true);
            person4.Attended(event3.Id, true);
            person4.Attended(event4.Id, true);
            person4.Attended(event5.Id, true);
            person4.Attended(event6.Id, false);
            person4.Attended(event7.Id, false);
            person4.Attended(event8.Id, false);
            person4.Attended(event9.Id, true);
            person4.Attended(event10.Id, true);

            person5.Attended(event1.Id, false);
            person5.Attended(event2.Id, false);
            person5.Attended(event3.Id, false);
            person5.Attended(event4.Id, true);
            person5.Attended(event5.Id, true);
            person5.Attended(event6.Id, true);
            person5.Attended(event7.Id, true);
            person5.Attended(event8.Id, true);
            person5.Attended(event9.Id, true);
            person5.Attended(event10.Id, true);



            List<Person> listPersons = new List<Person>() { person1, person2, person3, person4, person5 };
            List<Event> listEvents = new List<Event>() { event1, event2, event3, event4, event5, event6, event7, event8, event9, event10 };

            DateTime UnesiDatum()
            {
                string dateString;
                string format = "g";
                CultureInfo provider = new CultureInfo("fr-FR");
                DateTime result = DateTime.Now;
                bool a = false;
                do
                {
                    Console.WriteLine("Unesi datum u formatu: 15/06/2008 16:30");
                    dateString = Console.ReadLine();
                    a = false;
                    try
                    {
                        result = DateTime.ParseExact(dateString, format, provider);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"{dateString} nije dobar format.");
                        a = true;
                    }
                }
                while (a);
                return result;
            }
            void ZabiljeziNeprisutnost()
            {
                Event odabraniEvent = new Event();
                string unos;
                bool a=true;
                do
                {
                    Console.WriteLine("Unesite id eventa u kojem zelite zabiljeziti neprisutnost: ");
                    unos = Console.ReadLine();
                    a = true;
                    foreach (var p in listEvents)
                    {
                        if (unos == p.Id)
                        {
                            odabraniEvent = p;
                            a = false;
                        }
                    }
                }
                while(a);
                

                Console.WriteLine("Unesite mailove osoba koji nisu bili prisutni(mailove odvojite razmakon)");
                string popisNeprisutnih = Console.ReadLine();
                string[] nizNeprisutnih = popisNeprisutnih.Split(" ");
                for (var i = 0; i < nizNeprisutnih.Length; i++)
                {
                    if (odabraniEvent.RemoveEmail(nizNeprisutnih[i]))
                        Console.WriteLine("Maknut je mail " + nizNeprisutnih[i]+ " iz sudionika");
                    else
                        Console.WriteLine("Mail "+ nizNeprisutnih[i]+ " nije ni bio medu sudionicima");
                }
                foreach(Person p in listPersons)
                {
                    if (nizNeprisutnih.Contains(p.Email))
                       if( p.RemoveAttendance(odabraniEvent.Id))
                            Console.WriteLine("Iz podataka osobe s mailom "+p+" izbrisana je pristunost na ovome eventu.");
                }
                Izbornik();

            }
            void IzbrisiEvent()
            {
                Event odabraniEvent = new Event();
                string unos;
                bool a=true;
                do
                {
                    Console.WriteLine("Unesite id eventa kojeg zelite izbrisati: ");
                    unos = Console.ReadLine();
                    a = true;
                    foreach (var p in listEvents)
                    {
                        if (unos == p.Id)
                        {
                            odabraniEvent = p;
                            a = false;
                        }
                    }
                }
                while (a);
                foreach (Person p in listPersons)
                {
                    if (p.RemoveEvent(odabraniEvent.Id))
                        Console.WriteLine("Iz podataka osobe s mailom " + p.Email + " izbrisan je event.");
                }

                listEvents.Remove(odabraniEvent);
            }
            void UkoloniOsobeSEventa()
            {
                Event odabraniEvent = new Event();
                string unos;
                int k = 0;
                do
                {
                    Console.WriteLine("Unesite id eventa u kojem zelite zabiljeziti neprisutnost: ");
                    unos = Console.ReadLine();
                    foreach (var p in listEvents)
                    {
                        if (unos == p.Id)
                        { 
                            odabraniEvent= p;
                            k = 1;
                        }
                    }
                }
                while (k == 0);

                Console.WriteLine("Unesite mailove osoba koji nisu bili prisutni(mailove odvojite razmakon)");
                string popisNeprisutnih = Console.ReadLine();
                string[] nizNeprisutnih = popisNeprisutnih.Split(" ");
                for (var i = 0; i < nizNeprisutnih.Length; i++)
                {
                    if (odabraniEvent.RemoveEmail(nizNeprisutnih[i]))
                        Console.WriteLine("Maknut je mail " + nizNeprisutnih[i] + " iz sudionika");
                    else
                        Console.WriteLine("Mail " + nizNeprisutnih[i] + " nije ni bio medu sudionicima");
                }
                foreach (Person p in listPersons)
                {
                    if (nizNeprisutnih.Contains(p.Email))
                        if (p.RemoveAttendance(odabraniEvent.Id))
                            Console.WriteLine("Iz podataka osobe s mailom " + p.Email + " izbrisana je pristunost na ovome eventu.");
                }

                Izbornik();

                
            }

            

            void AktivniEventi()
            {
                foreach (var item in listEvents)
                {
                    if (item.StartDate.Date <= DateTime.Now.Date && item.EndDate.Date >= DateTime.Now.Date)
                    {
                        Console.WriteLine($"{item.Id}\n"
                                        + $"{item.Name} - {item.Location} - {item.EndDate}\n"
                                        + $"Popis sudionika:");
                        string s = "";
                        for (var i = 0; i < item.Email.Count; i++)
                        {
                            if (i == item.Email.Count - 1)
                                s += item.Email[i];
                            else
                                s += item.Email[i] += ", ";
                        }
                        Console.WriteLine(s+"\n");
                    }

                }

                string unos;
                do
                {
                    Console.WriteLine("Odaberi:\n1-Zabiljezi neprisutnost\n2-Povratak na glavni izbornik");
                    unos = Console.ReadLine();
                }
                while (unos != "1" && unos != "2");
                int odabir = int.Parse(unos);
                switch (odabir)
                {
                    case 1:
                        ZabiljeziNeprisutnost();
                        break;
                    case 2:
                        Console.Clear();
                        Izbornik();
                        break;
                }

            }
            void NadolazeciEventi()
            {
                foreach (var item in listEvents)
                {
                    if (item.StartDate.Date > DateTime.Now.Date)
                    {
                        var diffOfDates = item.StartDate - DateTime.Now;
                        var diffOfDates1 = item.EndDate - item.StartDate;
                        Console.WriteLine($"{item.Id}\n"
                                        + $"{item.Name} - {item.Location} - pocinje za {diffOfDates.Days} dana i traje {diffOfDates1.Days} dana i {diffOfDates1.Hours} sati.\n"
                                        + $"Popis sudionika:");
                        string s = "";
                        for (var i = 0; i < item.Email.Count; i++)
                        {
                            if (i == item.Email.Count - 1)
                                s += item.Email[i];
                            else
                                s += item.Email[i] += ", ";
                        }
                        Console.WriteLine(s+"\n");
                    }

                }

                string unos;
                do
                {
                    Console.WriteLine("Odaberi:\n1-Izbrisi event\n2-Ukloni osobu s eventa\n3-Povratak na glavni izbornik");
                    unos = Console.ReadLine();
                }
                while (unos != "1" && unos != "2" && unos != "3");
                int odabir = int.Parse(unos);
                switch (odabir)
                {
                    case 1:
                        IzbrisiEvent();
                        break;
                    case 2:
                        UkoloniOsobeSEventa();
                        break;
                    case 3:
                        Console.Clear();
                        Izbornik();
                        break;
                }

            }
            void EventiKojiSuZavrsili()
            {
                foreach (var item in listEvents)
                {
                    if (item.EndDate < DateTime.Now)
                    {
                        var diffOfDates = DateTime.Now-item.EndDate;
                        var diffOfDates1 = item.EndDate - item.StartDate;
                        Console.WriteLine($"{item.Id}\n"
                                        + $"{item.Name} - {item.Location} - zavrsilo je prije {diffOfDates.Days} dana i trajalo je {diffOfDates1.Days} dana i {diffOfDates1.Hours} sata\n");


                        string s1 = "";
                        string s2 = "";
                        for (var i = 0; i < listPersons.Count; i++)
                        {
                            if (item.Email.Contains(listPersons[i].Email))
                                s1 += listPersons[i].Email + ", ";
                            else
                                s2 += listPersons[i].Email + ", ";
                        }

                        Console.WriteLine("Popis prisutnih sudionika:");
                        Console.WriteLine(s1);
                        Console.WriteLine("Popis neprisutnih sudionika:");
                        Console.WriteLine(s2);
                    }

                }
                Izbornik();
            }
            void KreirajEvent()  
            {
                Console.WriteLine("Unesi naziv eventa: ");
                string name = Console.ReadLine();
                Console.WriteLine("Unesi lokaciju eventa: ");
                string location = Console.ReadLine();
                Console.WriteLine("Datum pocetka: ");
                DateTime startDate = UnesiDatum();
                Console.WriteLine("Datum kraja: ");
                DateTime endDate = UnesiDatum();

                Event noviEvent = new Event();
                noviEvent.Name = name;
                noviEvent.StartDate = startDate;
                noviEvent.EndDate = endDate;
                noviEvent.Location = location;
                listEvents.Add(noviEvent);

                Console.WriteLine("Unesite mailove osoba koji ce bit prisutni(mailove odvojite razmakon)");
                string popisPrisutnih = Console.ReadLine();
                string[] nizPrisutnih = popisPrisutnih.Split(" ");
                List<Person> listaPrisutnih=new List<Person>();
                for (var i = 0; i < nizPrisutnih.Length; i++)
                {
                    foreach(Person p in listPersons) 
                    {
                        if (nizPrisutnih[i]==p.Email)
                            listaPrisutnih.Add(p);
                    }    
                }
                foreach (Person p in listaPrisutnih)
                {
                    foreach(var k in p.Attendance.Keys) 
                    {
                        Event odabraniEvent = new Event();
                        //ovdje mi javlja neku gresku ali nisan znala u cemu je problem
                        if (p.Attendance.ContainsKey(k) && p.Attendance[k]==true)
                        {
                            foreach (var t in listEvents)
                            {
                                if (k == t.Id)
                                {
                                    odabraniEvent = t;
                                }
                            }
                        }
                        if((odabraniEvent.StartDate>=noviEvent.StartDate && odabraniEvent.StartDate <= noviEvent.EndDate) || (odabraniEvent.EndDate >= noviEvent.StartDate && odabraniEvent.EndDate <= noviEvent.EndDate))
                        {
                            Console.WriteLine("Osoba " + p.Name+ " ne moze prisustvovati ovom eventu.");
                        }
                        else
                        {
                            p.Attended(noviEvent.Id, true);
                            noviEvent.AddEmail(p.Email);
                            Console.WriteLine("Osoba " + p.Name + " moze prisustvovati ovom eventu.");
                        }

                    }
                }


                Izbornik();


            }    
            void IzadiIzPrograma()
            {
                Console.Clear();
                Console.WriteLine("Izasli ste iz aplikacije.");
            }

            void Izbornik()
            {
                string unos;
                do
                {
                    Console.WriteLine("Odaberi:\n1-Aktivni Eventi\n2-Nadolazeci Eventi\n3-Eventi koji su zavrsili\n4-Kreiraj Event\n5-Izadi iz programa");
                    unos = Console.ReadLine();
                }
                while (unos != "1" && unos != "2" && unos != "3" && unos != "4" && unos != "5");
                int odabir = int.Parse(unos);
                switch (odabir)
                {
                    case 1:
                        AktivniEventi();
                        break;
                    case 2:
                        NadolazeciEventi();
                        break;
                    case 3:
                        EventiKojiSuZavrsili();
                        break;
                    case 4:
                        KreirajEvent();
                        break;
                    case 5:
                        IzadiIzPrograma();
                        break;

                }
            }

            Izbornik();
        }
    }
}







