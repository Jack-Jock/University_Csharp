﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University3
{
    public class listHuman
    {
        private List<Human> listHumans;

        public listHuman()
        {
            listHumans = new List<Human>();
        }
        public void add(Human human)
        {
            listHumans.Add(human);
        }

        public void show()
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                listHumans[n].printInfo();
            }
        }


        public string show(int a)
        {
            string data = "";
            for (int n = 0; n < listHumans.Count(); n++)
                data += listHumans[n].toStr();
            return data;
        }
        public void findCountry_Nation(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
                if (listHumans[n].Address.Country == str &&
                    listHumans[n].Nation.ToString() == "Ukranian")
                    listHumans[n].printInfo();
        }
        public void findName(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if (listHumans[n].Name == str)
                    listHumans[n].printInfo();
                else
                    Console.WriteLine("Объекта с такими инициалами нету в списке!");
            }

        }
        
        public void remove(string name, string surname)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if ((listHumans[n].Name == name) && (listHumans[n].Surname == surname))
                    listHumans.RemoveAt(n);
            }
            Console.WriteLine("Удалено");
        }

        public void show(bool b)
        {
            foreach (Human obj in listHumans)
                obj.printInfo();
        }

        public void sort_surname()
        {
            Human reserv = new Human();
            for (int j = 1; j < listHumans.Count(); j++)
                for (int i = 0; i < listHumans.Count() - 1; i++)
                    if (listHumans[i].Surname[0] > listHumans[i + 1].Surname[0])
                    {
                        reserv = listHumans[i];
                        listHumans[i] = listHumans[i + 1];
                        listHumans[i + 1] = reserv;
                    }
            for (int n = 0; n < listHumans.Count(); n++)
                listHumans[n].printInfo();

        }
        public void sort_age()
        {
            Human reserv = new Human();
            for (int j = 1; j < listHumans.Count(); j++)
                for (int i = 0; i < listHumans.Count() - 1; i++)
                    if (listHumans[i].Age > listHumans[i + 1].Age)
                    {
                        reserv = listHumans[i];
                        listHumans[i] = listHumans[i + 1];
                        listHumans[i + 1] = reserv;
                    }
            for (int n = 0; n < listHumans.Count(); n++)
                listHumans[n].printInfo();

        }
        public void save_txt(listHuman list)
        {
            try
            {
                StreamWriter sw = new StreamWriter("D:\\Text.txt");
                int pop = 70;
                sw.WriteLine(list.show(pop));
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }

        }

    }
}
