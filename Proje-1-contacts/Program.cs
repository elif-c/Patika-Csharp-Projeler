using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;
using System.Security.AccessControl;

class Program
{
    public static void Main(string[] args)
    {
        string[] nameArray = new string[2];
        Dictionary<string, long> numbersDict = new Dictionary<string, long>();

        SamplePersons samplePersons = new SamplePersons();
        samplePersons.SamplePairs(numbersDict);

        DictionaryProcesses dictionary = new DictionaryProcesses();

        int numberInput;
        string name;

        while (true)
        {

            Console.WriteLine("""
        Lütfen yapmak istediğiniz işlemi seçiniz ^^
        (1) Yeni Numara Kaydetmek 
        (2) Varolan Numarayı Silmek 
        (3) Varolan Numarayı Güncelleme 
        (4) Rehberi Listelemek 
        (5) Rehberde Arama Yapmak﻿
        """);
            try
            {
                numberInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLütfen bir sayı giriniz.\n");
                continue;
            }

            switch (numberInput)
            {
                case 1:
                    Console.WriteLine("Lütfen isim giriniz: ");
                    nameArray[0] = Console.ReadLine().ToLower().Trim();
                    Console.Write("Lütfen soyisim giriniz: ");
                    nameArray[1] = Console.ReadLine().ToLower().Trim();
                    Console.Write("Lütfen telefon numarasi giriniz: ");
                    name = nameArray[0].ToString() + " " + nameArray[1].ToString();
                    numbersDict[name] = Convert.ToInt64(Console.ReadLine().Trim());

                    // confirmation message
                    Console.WriteLine("\n{0} rehbere eklendi.\n", name);
                    break;

                case 2:
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string searchPerson = Console.ReadLine().Trim();
                    bool containsName2 = false;
                    string personName2 = "";

                    containsName2 = dictionary.IsInDictionary(numbersDict.Keys, searchPerson, containsName2);

                    if (containsName2)
                    {
                        personName2 = dictionary.IsInDictionary(numbersDict.Keys, searchPerson, personName2);
                        Console.WriteLine($"{personName2} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                        string deleteinput = Console.ReadLine().Trim().ToLower();
                        if (deleteinput == "y")
                        {
                            numbersDict.Remove(personName2);
                            Console.WriteLine("\n{0} rehberden silindi.\n", personName2);
                        }
                        else if (deleteinput == "n")
                        { break; }
                        else
                        {
                            Console.WriteLine("Lütfen tekrar deneyiniz.");
                            goto case 2;
                        }
                    }
                    else
                    {
                        int deleteinput;
                        Console.WriteLine("""
                    Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
                    * Silmeyi sonlandırmak için : (1)
                    * Yeniden denemek için      : (2)
                    """);
                        try
                        {
                            deleteinput = Convert.ToInt32(Console.ReadLine().Trim());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nLütfen bir sayı giriniz.\n");
                            continue;
                        }

                        if (deleteinput == 1)
                        {
                            break;
                        }
                        else if (deleteinput == 2)
                        { goto case 2; }
                    }
                    break;
                case 3:
                    Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string updatenumber = Console.ReadLine().Trim().ToLower();
                    bool containsName3 = false;
                    string personName3 = "";

                    containsName3 = dictionary.IsInDictionary(numbersDict.Keys, updatenumber, containsName3);

                    if (containsName3)
                    {
                        personName3 = dictionary.IsInDictionary(numbersDict.Keys, updatenumber, personName3);
                        long newnumber;
                        Console.WriteLine($"{personName3} isimli kişi için yeni numara giriniz: ");
                        try
                        {
                            newnumber = Convert.ToInt64(Console.ReadLine().Trim());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nLütfen bir sayı giriniz.\n");
                            goto case 3;
                        }
                        numbersDict[personName3] = newnumber;
                        Console.WriteLine("\n{0} numarası değiştirildi.\n", personName3);
                    }
                    else
                    {
                        int updateinput;
                        Console.WriteLine("""
                    Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
                    * Güncellemeyi sonlandırmak için    : (1)
                    * Yeniden denemek için              : (2)
                    """);
                        try
                        {
                            updateinput = Convert.ToInt32(Console.ReadLine().Trim());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nLütfen bir sayı giriniz.\n");
                            goto case 3;
                        }

                        if (updateinput == 1)
                        { break; }
                        else if (updateinput == 2)
                        { goto case 3; }
                    }
                    break;

                case 4:
                    List<string> contacts = new List<string>();
                    Console.WriteLine("Siralama yontemi seciniz: (a/z)");
                    string sortInput = Console.ReadLine().Trim().ToLower();
                    foreach (var person in numbersDict)
                    {
                        contacts.Add(person.Key);
                    }
                    contacts.Sort();
                    if (sortInput == "a")
                    {
                        Console.WriteLine("""
                              Telefon Rehberi
                ********************************************** 
                """);
                        dictionary.PrintContacts(numbersDict, contacts);
                        Console.WriteLine("\n");
                    }
                    else if (sortInput == "z")
                    {
                        Console.WriteLine("""
                              Telefon Rehberi
                ********************************************** 
                """);
                        contacts.Reverse();
                        dictionary.PrintContacts(numbersDict, contacts);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen tekrar deneyiniz.");
                        goto case 4;
                    }
                    break;

                case 5:
                    Console.WriteLine("""
                        Arama yapmak istediğiniz tipi seçiniz.
                        ********************************************** 
                        İsim veya soyisime göre arama yapmak için: (1) 
                        Telefon numarasına göre arama yapmak için: (2)
                        """);
                    int searchinput;
                    try
                    {
                        searchinput = Convert.ToInt32(Console.ReadLine().Trim());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nLütfen bir sayı giriniz.\n");
                        goto case 5;
                    }

                    if (searchinput == 1)
                    {
                        Console.WriteLine("Lütfen isim veya soyisim giriniz: ");
                        string searchPersonName = Console.ReadLine().Trim().ToLower();
                        dictionary.PrintSearchResult(searchPersonName, numbersDict);
                    }
                    else if (searchinput == 2)
                    {
                        long searchNumber;
                        Console.WriteLine("Lütfen telefon numarasi giriniz: ");
                        try
                        {
                            searchNumber = Convert.ToInt64(Console.ReadLine().Trim());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nLütfen bir telefon numarasi giriniz.\n");
                            goto case 5;
                        }
                        dictionary.PrintNumberSearchResult(numbersDict, searchNumber);


                    }

                    break;

                default:
                    Console.WriteLine("\nLütfen tekrar deneyiniz.\n");
                    break;
            }

        }
    }
}

class SamplePersons
{
    public void SamplePairs(Dictionary<string, long> numbersDict)
    {
        // sample persons
        numbersDict["emma roberts"] = 5554440000;
        numbersDict["emma watson"] = 5554440001;
        numbersDict["quentin tarantino"] = 5554321102;
        numbersDict["wes anderson"] = 5554321002;
        numbersDict["christopher nolan"] = 5554321203;
    }
}

class DictionaryProcesses
{
    public bool IsInDictionary(Dictionary<string, long>.KeyCollection keys, string searchname, bool containsname)
    {
        foreach (string key_ in keys) // we could use var for pairs
        {
            if (key_.Contains(searchname))
            { return true; }
        }
        return false;
    }

    // overload
    public string IsInDictionary(Dictionary<string, long>.KeyCollection keys, string searchname, string personname)
    {
        foreach (string key_ in keys)
        {
            if (key_.Contains(searchname))
            {
                personname = key_;
                return personname;
            }
        }
        return "";
    }

    public void PrintNumberSearchResult(Dictionary<string, long> dictionary, long searchnumber)
    {
        foreach (string key_ in dictionary.Keys)
        {
            if (dictionary[key_].ToString().Contains(searchnumber.ToString()))
            {
                PrintFoundContact(dictionary, key_);
            }
        }
    }

    public void PrintSearchResult(string searchname, Dictionary<string, long> dictionary)
    {
        foreach (string key_ in dictionary.Keys)
        {
            if (key_.Contains(searchname))
            {
                PrintFoundContact(dictionary, key_);
            }
        }
    }

    public void PrintFoundContact(Dictionary<string, long> dictionary, string key)
    {
        string[] name_surname = new string[2];
        name_surname = key.ToString().Split(' ');
        Console.WriteLine($"Isim: {name_surname[0]} " +
            $"Soyisim: {name_surname[1]} " +
            $"Telefon numarasi: {dictionary[key].ToString()}");
    }

    public void PrintContacts(Dictionary<string, long> dictionary, List<string> contacts)
    {
        string[] name_surname = new string[2];
        foreach (string contact in contacts)
        {
            name_surname = contact.ToString().Split(' ');
            Console.WriteLine($"Isim: {name_surname[0]} " +
                $"Soyisim: {name_surname[1]} " +
                $"Telefon numarasi: {dictionary[contact].ToString()}");
        }
    }
}

