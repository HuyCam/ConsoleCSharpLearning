using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace ConsoleCSharpLearning.Experiment
{
    public class BindingFlagsEnum
    {
        public void OutPutMembers()
        {
            MemberInfo[] members = typeof(Cow).GetMembers();
            foreach (MemberInfo minfo in members)
                Console.WriteLine(minfo);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            IEnumerable<MemberInfo> members2 = typeof(Cow).GetMembers().OrderByDescending(mi => mi.DeclaringType.Name);
            foreach (MemberInfo minfo in members2)
                Console.WriteLine(minfo);
            Console.WriteLine("-------------------------------------------------------------------------------------");

        }

        // When using BindingFlag to get properties/members, make sure provide either public or private or both and Instance or Static or both
        // This is option to search for class members
        public void TestBindingFlags()
        {
            MemberInfo[] members = typeof(Cow).GetMembers(BindingFlags.DeclaredOnly|BindingFlags.Public|BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MemberInfo minfo in members)
                Console.WriteLine(minfo);
        }
    }
    
    class Cow
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int NumHeartBeats { get; set; }
        public void Beat() { NumHeartBeats++;  }
        private void Digest() { Console.WriteLine("grind grind ... ");  }
    }
}
