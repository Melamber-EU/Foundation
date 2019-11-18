using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azshara.Models
{
    class RaidersM
    {
        public string name { get; set; }
    }
    class Timers
    {
        public double timers { get; set; }
        public double soak { get; set; }
    }
    class SetCounter
    {
        public string SetC1T { get; set; }
        public string SetC1R { get; set; }
    }
    class SQLRoster
    { 
        public int _ID { get; set; }
        public string name { get; set; }
        public class SQLClasses
        {
            public int _ID { get; set; }
            public string clsName { get; set; }
        }
        public class SQLRoles
        {
            public int _ID { get; set; }
            public string spec { get; set; }
        }
    }
    
    
}
