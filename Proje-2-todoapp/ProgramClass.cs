using c_101_proje2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_101_proje2
{
    public class ProgramClass
    {
        static Dictionary<int, TeamMember> member = DefaultMembers.showMemberRecord();
        public void runProgram()
        {
            CardCreator todoCards = new todo_cards("todo1", "this is a todo item", member[104]);
            CardCreator inProgressCards = new inprogress_cards("in progress1", "this is an in progress item", member[238]);
            CardCreator doneCards = new done_cards("done1", "this is a completed item", member[238]);

            while (true)
            {
                Console.WriteLine("""
                Lütfen yapmak istediğiniz işlemi seçiniz ^^
                ******************************************* 
                (1) Board Listelemek 
                (2) Board'a Kart Eklemek 
                (3) Board'dan Kart Silmek 
                (4) Kart Taşımak
                (5) Uygulamadan Çıkmak
                """);

                int selection;
                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen bir sayi giriniz");
                    continue;
                }
                switch (selection)
                {
                    case 1:
                        showBoards();
                        break;
                    case 2:
                        try
                        {
                            addCard();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Lütfen bir sayi giriniz");
                            goto case 2;
                        }
                        break;
                    case 3:
                        try
                        {
                            deleteCard();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Lütfen bir sayi giriniz");
                            goto case 3;
                        }
                        break;
                    case 4:
                        try
                        {
                            moveCard();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Lütfen bir sayi giriniz");
                            goto case 4;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Çıkış yapıldı ^^");
                        Environment.Exit(1);
                        break;

                }
            }
        }

        public void showMembersList()
        {
            // calling the TeamMember function to create a member as dictionary item
            // Dictionary<int, TeamMember> member = DefaultMembers.showMemberRecord();

            foreach (TeamMember teammember in member.Values)
            {
                Console.Write(teammember.Name + " " + teammember.Surname + ":" + teammember.Id + "\n");

            }
        }

        public void showOneBoard(string board, int boardIndex)
        {
            Console.WriteLine("""
                Bulunan Kart Bilgileri:
                ************************************** 
                """);
            if (board == "todo")
            {
                Console.WriteLine("Başlık      :" + todo_cards.Cards[boardIndex].Title);
                Console.WriteLine("İçerik      :" + todo_cards.Cards[boardIndex].Content);
                Console.WriteLine("Atanan Kişi :" + todo_cards.Cards[boardIndex].TeamMember.Name +
                    " " + todo_cards.Cards[boardIndex].TeamMember.Surname);
                Console.WriteLine("Büyüklük    :" + todo_cards.Cards[boardIndex].Size);

            }
            else if (board == "inprogress")
            {
                Console.WriteLine("Başlık      :" + inprogress_cards.Cards[boardIndex].Title);
                Console.WriteLine("İçerik      :" + inprogress_cards.Cards[boardIndex].Content);
                Console.WriteLine("Atanan Kişi :" + inprogress_cards.Cards[boardIndex].TeamMember.Name +
                    " " + inprogress_cards.Cards[boardIndex].TeamMember.Surname);
                Console.WriteLine("Büyüklük    :" + inprogress_cards.Cards[boardIndex].Size);
            }
            else if (board == "done")
            {
                Console.WriteLine("Başlık      :" + done_cards.Cards[boardIndex].Title);
                Console.WriteLine("İçerik      :" + done_cards.Cards[boardIndex].Content);
                Console.WriteLine("Atanan Kişi :" + done_cards.Cards[boardIndex].TeamMember.Name +
                    " " + done_cards.Cards[boardIndex].TeamMember.Surname);
                Console.WriteLine("Büyüklük    :" + done_cards.Cards[boardIndex].Size);
            }
        }

        public void showBoards()
        {
            Console.WriteLine("TODO Line\n ************************");
            todo_cards.CardsList();
            Console.WriteLine("IN PROGRESS Line\n ************************");
            inprogress_cards.CardsList();
            Console.WriteLine("DONE Line\n ************************");
            done_cards.CardsList();
        }

        public void addCard()
        {
            // Dictionary<int, TeamMember> member = DefaultMembers.showMemberRecord();

            Console.WriteLine("Lütfen kart için bir başlık yazınız:");
            string title = Console.ReadLine();
            Console.WriteLine("Lütfen kart içeriğini yazınız:");
            string content = Console.ReadLine();
            showMembersList();
            Console.WriteLine("Lütfen id numarasi ile bir kisi atayiniz:");
            int id = 0; // empty int for user entry on id search
            while (true)
            {
                id = Convert.ToInt32(Console.ReadLine()); // getting id number from user
                bool switch_ = member.Keys.Contains(id);
                switch (switch_)
                {
                    case true:
                        foreach (var teammemberId in member.Keys)
                        {   
                            // checking each member item in members dictionary searching by the key
                            // which is the id number
                            // if the iterated member id matches the one searched for
                            if (teammemberId == id)
                            { goto default; }
                            else
                            { continue; }
                        }
                        break;
                    case false:
                        Console.WriteLine("Lütfen tekrar deneyiniz");
                        continue; // getting another id from user
                    default:
                        break;
                }
                break; // exiting loop
            }
            TeamMember selectedMember = member[id];
            Console.WriteLine("""
            Lütfen ekleyeceğiniz kartın hangi kolona ekleneceğini giriniz
            (1)-ToDo-(L)
            (2)-InProgress-(M)
            (3)-Done-(S)
            """);
            int selectedBoard = Convert.ToInt32(Console.ReadLine());
            switch (selectedBoard)
            {
                case 1:
                    Console.WriteLine("Todo Listesine Kart Eklendi.");
                    CardCreator newTodoCard = new todo_cards(title, content, selectedMember);
                    break;
                case 2:
                    Console.WriteLine("InProgress Listesine Kart Eklendi.");
                    CardCreator newInProgressCard = new inprogress_cards(title, content, selectedMember);
                    break;
                case 3:
                    Console.WriteLine("Done Listesine Kart Eklendi.");
                    CardCreator newDoneCard = new done_cards(title, content, selectedMember);
                    break;
            }
        }

        public void deleteCard()
        {
            Console.WriteLine("""
            Hangi bölümdeki kartı sileceksiniz?
            (1)-ToDo
            (2)-InProgress
            (3)-Done
            """);
            int selectedBoard = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("""
                Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.
                Lütfen kart başlığını yazınız:
                """);
                string searchTitle = Console.ReadLine().Trim().ToLower();
                switch (selectedBoard)
                {
                    case 1:
                        for (int i = 0; i < todo_cards.Cards.Count; i++)
                        {
                            if (todo_cards.Cards[i].Title.ToLower().Contains(searchTitle))
                            {
                                todo_cards.Cards.Remove(todo_cards.Cards[i]);
                                Console.WriteLine("Kart silindi.");
                                break;
                            }
                            else if (i == todo_cards.Cards.Count - 1)
                            {
                                Console.WriteLine("""
                                Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.
                                * Silmeyi sonlandırmak için : (1)
                                * Yeniden denemek için : (2)
                                """);   
                                int selection = Convert.ToInt32(Console.ReadLine().Trim());
                                if (selection == 1)
                                {
                                    goto default;
                                }
                                else
                                {
                                    goto case 8;
                                }
                                
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < inprogress_cards.Cards.Count; i++)
                        {
                            if (inprogress_cards.Cards[i].Title.ToLower().Contains(searchTitle))
                            {
                                inprogress_cards.Cards.Remove(inprogress_cards.Cards[i]);
                                Console.WriteLine("Kart silindi.");
                                break;
                            }
                            else if (i == inprogress_cards.Cards.Count - 1)
                            {
                                Console.WriteLine("""
                                Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.
                                * Silmeyi sonlandırmak için : (1)
                                * Yeniden denemek için : (2)
                                """);
                                int selection = Convert.ToInt32(Console.ReadLine().Trim());
                                if (selection == 1)
                                {
                                    goto default;
                                }
                                else
                                {
                                    goto case 8;
                                }

                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < done_cards.Cards.Count; i++)
                        {
                            if (done_cards.Cards[i].Title.ToLower().Contains(searchTitle))
                            {
                                done_cards.Cards.Remove(done_cards.Cards[i]);
                                Console.WriteLine("Kart silindi.");
                                break;
                            }
                            else if (i == done_cards.Cards.Count - 1)
                            {
                                Console.WriteLine("""
                                Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.
                                * Silmeyi sonlandırmak için : (1)
                                * Yeniden denemek için : (2)
                                """);
                                int selection = Convert.ToInt32(Console.ReadLine().Trim());
                                if (selection == 1)
                                {
                                    goto default;
                                }
                                else
                                {
                                    goto case 8;
                                }

                            }
                        }
                        break;
                    case 8:
                        // going back to the while loop
                        continue;
                    default:
                        break;
                }
                break;
            }
            

        }

        public void moveCard()
        {
            string board = ""; // need to declare as empty
            int boardIndex = 0; // otherwise get "unassigned" error
            while (true)
            {
                Console.WriteLine("""
                Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.
                Lütfen kart başlığını yazınız:
                """);
                string searchTitle = Console.ReadLine().Trim().ToLower();
                // searching all card boards for the matching one
                for (int i = 0; i < todo_cards.Cards.Count; i++)
                {
                    if (todo_cards.Cards[i].Title.ToLower().Contains(searchTitle))
                    {
                        board = "todo";
                        boardIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < inprogress_cards.Cards.Count; i++)
                {
                    if (inprogress_cards.Cards[i].Title.ToLower().Contains(searchTitle))
                    {
                        board = "inprogress";
                        boardIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < done_cards.Cards.Count; i++)
                {
                    if (done_cards.Cards[i].Title.ToLower().Contains(searchTitle))
                    {
                        board = "done";
                        boardIndex = i;
                        break;
                    }
                }
                if (board != "")
                {   
                    // if a card is found, exit the loop
                    break;
                }
                Console.WriteLine("""
                    Aradığınız krtiterlere uygun kart bulunamadı. Lütfen bir seçim yapınız.
                    * İşlemi sonlandırmak için : (1)
                    * Yeniden denemek için : (2)
                    """);
                int selection = Convert.ToInt32(Console.ReadLine().Trim());
                if (selection == 1)
                { break; }
                else
                { continue; }
            }
            if (board != "")
            {   
                // show the found matching card
                showOneBoard(board, boardIndex);

                Console.WriteLine("""
                Lütfen taşımak istediğiniz board'u seçiniz: 
                (1) TODO 
                (2) IN PROGRESS 
                (3) DONE
                """);
                int boardMoveSelection = Convert.ToInt32(Console.ReadLine().Trim());
                switch (boardMoveSelection)
                {
                    case 1:
                        if (board == "todo")
                        {
                            Console.WriteLine("Bu kart zaten bu board'da bulunuyor.");
                            break;
                        }
                        else if (board == "inprogress")
                        {   
                            // taking the info on inprogress card and creating new todo card with it
                            todo_cards addedCard = new todo_cards(inprogress_cards.Cards[boardIndex].Title,
                                inprogress_cards.Cards[boardIndex].Content, 
                                inprogress_cards.Cards[boardIndex].TeamMember); 
                            // removing the old card
                            inprogress_cards.Cards.Remove(inprogress_cards.Cards[boardIndex]);
                        }
                        else if (board == "done")
                        {
                            todo_cards addedCard = new todo_cards(done_cards.Cards[boardIndex].Title,
                                done_cards.Cards[boardIndex].Content,
                                done_cards.Cards[boardIndex].TeamMember);
                            done_cards.Cards.Remove(done_cards.Cards[boardIndex]);
                        }
                        break;
                    case 2:
                        if (board == "inprogress")
                        {
                            Console.WriteLine("Bu kart zaten bu board'da bulunuyor.");
                            break;
                        }
                        else if (board == "todo")
                        {
                            inprogress_cards addedCard = new inprogress_cards(todo_cards.Cards[boardIndex].Title,
                                todo_cards.Cards[boardIndex].Content,
                                todo_cards.Cards[boardIndex].TeamMember);
                            todo_cards.Cards.Remove(todo_cards.Cards[boardIndex]);
                        }
                        else if (board == "done")
                        {
                            inprogress_cards addedCard = new inprogress_cards(done_cards.Cards[boardIndex].Title,
                                done_cards.Cards[boardIndex].Content,
                                done_cards.Cards[boardIndex].TeamMember);
                            done_cards.Cards.Remove(done_cards.Cards[boardIndex]);
                        }
                        break;
                    case 3:
                        if (board == "done")
                        {
                            Console.WriteLine("Bu kart zaten bu board'da bulunuyor.");
                            break;
                        }
                        else if (board == "todo")
                        {
                            done_cards addedCard = new done_cards(todo_cards.Cards[boardIndex].Title,
                                todo_cards.Cards[boardIndex].Content,
                                todo_cards.Cards[boardIndex].TeamMember);
                            todo_cards.Cards.Remove(todo_cards.Cards[boardIndex]);
                        }
                        else if (board == "inprogress")
                        {
                            done_cards addedCard = new done_cards(inprogress_cards.Cards[boardIndex].Title,
                                inprogress_cards.Cards[boardIndex].Content,
                                inprogress_cards.Cards[boardIndex].TeamMember);
                            inprogress_cards.Cards.Remove(inprogress_cards.Cards[boardIndex]);
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yaptınız.");
                        break;

                }
                Console.WriteLine("Kart tasima islemi tamamlandi.");
            }
            

        }

    }
}
