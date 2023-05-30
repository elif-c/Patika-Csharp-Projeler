using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_101_proje2
{
    public class TeamMember
    {
        private string name;
        private string surname;
        private int id;

        public TeamMember(string name, string surname, int id)
        {
            this.Name = name;
            this.Surname = surname;
            this.id = id; 
        }

        
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Id { get => id; set => id = value; }

        
    }

    public static class DefaultMembers
    {
        public static Dictionary<int, TeamMember> memberRecord = new Dictionary<int, TeamMember>();
        
        public static Dictionary<int, TeamMember> showMemberRecord()
        {
            memberRecord.Add(104, new TeamMember("claire", "boucher", 104));
            memberRecord.Add(238, new TeamMember("john", "silverback", 238));
            return memberRecord;
        } 

    }

}
