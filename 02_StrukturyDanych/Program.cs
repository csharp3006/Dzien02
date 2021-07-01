using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayOper();
            //ListOper();
            //HashtableOper();
            //SortedListOper();
            //StackOper();
            QueueOper();
            Console.ReadKey();
        }

        /// <summary>
        /// operacje na kolejce
        /// </summary>
        private static void QueueOper()
        {
            Queue kolejka = new Queue();
            kolejka.Enqueue("A");
            kolejka.Enqueue("B");
            kolejka.Enqueue("C");
            kolejka.Enqueue("D");
            foreach (var el in kolejka)
            {
                Console.WriteLine(el);
            }
            string s = (string)kolejka.Dequeue();
            Console.WriteLine(s);

            s = (string)kolejka.Dequeue();
            Console.WriteLine(s);
        }

        /// <summary>
        /// Operacje na stosie
        /// </summary>
        private static void StackOper()
        {
            Stack stos = new Stack();
            String s = "ABCDEFG";
            foreach (var litera in s)
            {
                stos.Push(litera);
            }
            foreach (var element in stos)
            {
                Console.WriteLine(element);
            }
            // zdjecie ze stosu
            char z = (char)stos.Pop();
            Console.WriteLine("Zdjęto znak ="+z);
            
            z = (char)stos.Pop();
            Console.WriteLine("Zdjęto znak =" + z); 
            
            z = (char)stos.Pop();
            Console.WriteLine("Zdjęto znak =" + z);
        }

        private static void SortedListOper()
        {
            SortedList listaAut = new SortedList();
            listaAut.Add("001", "Audi");
            listaAut.Add("002", "Fiat");
            listaAut.Add("003", "Opel");
            listaAut.Add("004", "BMW");
            foreach (var k in listaAut.Keys)
            {
                Console.WriteLine(k + " = " + listaAut[k]);
            }
        }

        // tablica hashująca
        private static void HashtableOper()
        {
            Hashtable tabKrajow = new Hashtable();
            tabKrajow.Add("PL", "Polska");
            tabKrajow.Add("DE", "Niemcy");
            tabKrajow.Add("SE", "Szewcja");
            tabKrajow.Add("ES", "Hiszpania");
            tabKrajow.Add("CH", "Szwajcaria");

            String s = "", klucz = "PL";
            if (tabKrajow.ContainsKey(klucz)) { 
                s = tabKrajow[klucz].ToString();
            } else
            {
                s = String.Format("{0} nie istnieje", klucz);
            }
            Console.WriteLine(s);

            Console.WriteLine(tabKrajow.ContainsValue("Polska"));

            tabKrajow.Remove("ES"); //usuwa obiekt spod klucza ES
            tabKrajow.Clone(); //klonowanie obiektu

            foreach(var el in tabKrajow.Values)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();

            foreach (var k in tabKrajow.Keys)
            {
                Console.WriteLine(k+" = "+tabKrajow[k]);
            }

        }

        // operacje na listach
        private static void ListOper()
        {
            // deklaracja listy bez podania typu danych
            ArrayList listaImion = new ArrayList(10);
            listaImion.Add("Ala");
            listaImion.Add(10);
            listaImion.Add("Marek");
            String s = String.Format("ilosc elementow={0}, pojemnosc={1}", listaImion.Count,
                listaImion.Capacity);
            Console.WriteLine(s);

            // deklaracja listy z podaniem typu danych
            List<String> listaKrajow = new List<string>(5);
            listaKrajow.Add("Polska");
            listaKrajow.Add("Andora");
            listaKrajow.Add("Niemcy");
            listaKrajow.Add("Austria");
            s = String.Format("ilosc elementow={0}, pojemnosc={1}", listaKrajow.Count,
                listaKrajow.Capacity);
            Console.WriteLine(s);
            listaKrajow.Add("Belgia");
            listaKrajow.Add("Włochy");
            listaKrajow.Insert(1, "Hiszpania");
            listaKrajow.Add("Ąbcd");
            listaKrajow.Add("Łomianki");
            s = String.Format("ilosc elementow={0}, pojemnosc={1}", listaKrajow.Count,
                listaKrajow.Capacity);
            Console.WriteLine(s);

            listaKrajow[0] = "POLAND";

            listaKrajow.Sort();
            listaKrajow.Reverse();

            listaKrajow.Remove("Andora");
            listaKrajow.RemoveAt(1);
            listaKrajow.Remove("Niemcy");
            listaKrajow.TrimExcess(); //usuwanie nadmiaru alokacji na elementy listy
            s = String.Format("ilosc elementow={0}, pojemnosc={1}", listaKrajow.Count,
                listaKrajow.Capacity);
            Console.WriteLine(s);


        }

        // tablice, deklaracja i użycie
        private static void ArrayOper()
        {
            int[] stawkiVAT = new int[10];  // deklaracja 10-elementowej tablicy liczb calkowitych
            stawkiVAT[1] = 8; // zapis do drugiej komorki (index=1) wartosci 8
            stawkiVAT[9] = 23; // zapis do ostatniej komorki (index=9) wartosci 23
            //stawkiVAT[22] = -1; wygeneruje wyjatek

            int[] oceny1 = new int[6] {1,2,3,4,5,6}; // deklaracja tablicy z wart. poczatkowymi
            int[] oceny2 = new int[] {1,2,3,4,5,6}; // deklaracja tablicy z wart. poczatkowymi
            Console.WriteLine("Liczba elementow tablicy="+oceny2.Length);
            for(int i=0;i<oceny2.Length;i++)
            {
                Console.Write(oceny2[i] + ", ");
            }
            Console.WriteLine();

            int licznik = 0;
            foreach(int element in oceny2)
            {
                Console.Write(licznik + "," + element + " | ");
                licznik++;
            }

            int[] oceny3 = (int[])oceny1.Clone(); //klonowanie tabel
            oceny3[0] = 99;
            Console.WriteLine("\n===============================");
            for (int i = 0; i < oceny3.Length; i++)
            {
                Console.Write(oceny3[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < oceny1.Length; i++)
            {
                Console.Write(oceny1[i] + ", ");
            }
            Console.WriteLine();

            //kopiowanie tablic
            int[] oceny2a = new int[30];
            Array.Copy(oceny2, oceny2a, oceny2.Length);
            foreach(var el in oceny2a)
            {
                Console.Write(el + ", ");
            }
            Console.WriteLine();

            // deklaracja tablicy N-wymiarowych
            int[,] macierz1 = new int[3, 4]; //3 wiersze i 4 kolumny
            int[,] macierz2 = new int[3, 4] 
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            }; //3 wiersze i 4 kolumny

            // iterowanie po macierzy
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<4; j++)
                {
                    macierz2[i, j] *= 2;
                } 
            }

            // wyswietlanie macierzy
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(macierz2[i, j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
