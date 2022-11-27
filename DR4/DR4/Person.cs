using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR4
{
    internal class Person
    {
        public string Name;
        public string Surname { get; }
        public string Email { get; }
        public Dictionary<string, bool> Attendance { get; private set; } = new Dictionary<string, bool>();

        public Person(string a, string b)
        {
            Surname = a;
            Email = b;
        }

        public bool Attended(string a, bool b)
        {
            if (Attendance.ContainsKey(a))
                return false;
            Attendance.Add(a, b);
            return true;
        }
        public bool RemoveAttendance(string a)
        {
            if (!Attendance.ContainsKey(a))
                return false;
            Attendance[a] = false;
            return true;
        }

        public bool RemoveEvent(string a)
        {
            Attendance.Remove(a);
            return true;
        }
    }
}

