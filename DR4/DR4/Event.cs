using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR4
{
    internal class Event
    {
        public string Id { get; }
        public string Name;
        public string Location;
        public DateTime StartDate;
        public DateTime EndDate;
        public List<string> Email { get;  private set; }= new List<string>() { };   

        public Event()
        {
            Guid g = new Guid();
            g = Guid.NewGuid();
            Id = g.ToString();
        }

        public bool AddEmail(string a)
        {
            if (Email.Contains(a))
                return false;
            Email.Add(a);
            return true;
        }
        public bool RemoveEmail(string a)
        {
            if (!Email.Contains(a))
                return false;
            Email.Remove(a);
            return true;
        }
    }
}
