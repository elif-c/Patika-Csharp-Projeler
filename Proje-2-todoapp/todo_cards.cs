using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_101_proje2
{
    public class todo_cards : CardCreator
    {
        public static List<todo_cards> Cards = new List<todo_cards>();

        public todo_cards(string title, string content, TeamMember teamMember) : 
            base(title, content, teamMember, Sizes.S)
        {
            Cards.Add(this);
        }

        public static void CardsList()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards.Count > 0)
                {
                    Console.WriteLine("Başlık      :" + Cards[i].Title);
                    Console.WriteLine("İçerik      :" + Cards[i].Content);
                    Console.WriteLine("Atanan Kişi :" + Cards[i].TeamMember.Name +
                        " " + Cards[i].TeamMember.Surname);
                    Console.WriteLine("Büyüklük    :" + Cards[i].Size);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine(" ~ BOŞ ~ ");
                }
            }
        }
    }
}
