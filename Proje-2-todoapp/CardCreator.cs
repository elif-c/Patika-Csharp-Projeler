using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_101_proje2
{
    public abstract class CardCreator
    {
        private string title;
        private string content;
        private TeamMember teamMember;
        private Sizes size;

        public CardCreator(string title, string content, TeamMember teamMember, Sizes size)
        {
            
            this.title = title;
            this.content = content;
            this.teamMember = teamMember;
            this.size = size;
        }

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public TeamMember TeamMember { get => teamMember; set => teamMember = value; }
        public Sizes Size { get => size; }
    }

    public enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}

