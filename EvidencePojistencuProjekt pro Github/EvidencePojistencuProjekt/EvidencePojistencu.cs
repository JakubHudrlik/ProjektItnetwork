using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistencuProjekt
{/// <summary>
/// Třída evidující pojištěnce, obsahuje hlavní metody
/// </summary>
    public class EvidencePojistencu
    {
        /// <summary>
        /// Seznam pojištěnců
        /// </summary>
        private HashSet<Pojistenec> Seznam { get; set; }
        
        /// <summary>
        /// Instance třídy,obsahuje nový HashSet
        /// </summary>
        public EvidencePojistencu()
        {
            Seznam = new HashSet<Pojistenec>();
        }
        /// <summary>
        /// Metoda nabízející možnosti hlavního menu (switchem)
        /// </summary>
        public void Nabidni()
        {
            
            bool pokracovat = true;

            do // do while - pro opakované nabízení, podmíněné boolem pokracovat o řádek výš
            {
                Console.Clear();
                Console.WriteLine("Evidence pojištěných");
                                                                                                     //
                Console.WriteLine();                                                                 //
                Console.WriteLine("Zadejte číslo operace a podvrťte jej klávesou \"enter\":");       //
                Console.WriteLine("1 - Přidat nového pojištěnce");                                   // Možnosti menu
                Console.WriteLine("2 - Vypsat pojištěné");                                           //
                Console.WriteLine("3 - Vyhledat pojištěného");                                       //
                Console.WriteLine("4 - Ukončit aplikaci");                                           //

                string volba = Console.ReadLine(); // uživatelská volba pro switch
                bool platnavolba = true;            //předpokládáme platnou volbu
                switch (volba)                      //switchem vybereme metodu / možnost
                {
                    case "1":
                        
                        Pridej();



                        break;
                    case "2":
                        Vypis();



                        break;
                    case "3":
                        Vyhledej();
                        
                        break;
                    case "4":


                        Console.WriteLine("Děkujeme za použití aplikace, nashledanou.");                            // změna podmínky pro znovunabídnutí
                        pokracovat = false;                                                                         //              
                        break;                                                                                      //
                    default:                                                                                        //cokoliv mimo 1-4 je neplatná volba
                        platnavolba = false;                                                                        //
                        break;
                }
                if (!platnavolba)                                                                                   //při neplatné volbě vypíšeme text
                {                                                                                                   //
                    Console.Clear();                                                                                //
                    Console.WriteLine("Neplatná volba.Pro zobrazení validních voleb stiskněte libovolnou klávesu.");//necháme přečíst (čekáme na klávesu)
                                                                                                                    //
                    Console.ReadKey();                                                                              //
                    Console.Clear();                                                                                //
                }




            } while (pokracovat);                                                                                    // vracíme se na začátek(nebyl pokyn pro zmenu boolu)
        }

        /// <summary>
        /// Metoda k přidávání pojištěnců
        /// </summary>
        public void Pridej()
        {

            Console.Clear();
            int pocetPojistencu;
            string jmeno;
            string prijmeni;
            int vek;
            int telCislo;


            Console.WriteLine("Zadejte počet pojištěnců k evidenci do systému:");
            
            while (!int.TryParse(Console.ReadLine(), out pocetPojistencu))                                                  //zjištění počtu přidaných a ošetření vstupu
            {                                                                                                               //
                Console.WriteLine("POZOR!");                                                                                //
                Console.WriteLine("Zadejte prosím počet pojištěnců k evidenci do systému vyjádřený arabskými číslicemi.");  //
            }                                                                                                               //
            Console.Clear();                                                                                                //
                                                                                                                            //
                                                                                                                            //
            for (int i = 0; i < pocetPojistencu; i++)                                                                       // přidání nových pojištěnců
                                                                                                                            // cyklem for
            {                                                                                                               //
                                                                                                                            //
                Console.Clear();                                                                                            // čistím konzoli, uživatelsky mi to více vyhovovalo
                                                                                                                            //
                                                                                                                            //
                do                                                                                                          //
                {                                                                                                           //
                                                                                                                            //
                    Console.WriteLine("Zadejte jméno pojištěné osoby:");                                                    // získání dat, osekání mezer, zacyklení
                    jmeno = Console.ReadLine().Trim();                                                                      // dokud nezískáme validní jméno, přijmení
                    Console.Clear();                                                                                        // (validní jméno je pro mě v dnešní době cokoliv, krom mezery
                                                                                                                            //
                } while (jmeno == "");                                                                                      //
                                                                                                                            //
                do                                                                                                          //
                {                                                                                                           //
                                                                                                                            //
                                                                                                                            //
                    Console.WriteLine("Zadejte příjmení pojištěné osoby:");                                                 //
                    prijmeni = Console.ReadLine().Trim();                                                                   //
                    Console.Clear();                                                                                        //
                                                                                                                            //
                } while (prijmeni == "");                                                                                   //
                                                                                                                            //
                Console.WriteLine("Zadejte věk pojištěné osoby:");                                                          // získání věku, omezeno pouze na int, mez (např.1-100 let jsem neřešil)
                while (!int.TryParse(Console.ReadLine(), out vek))                                                          //
                {                                                                                                           //
                    Console.WriteLine("POZOR!");                                                                            //
                    Console.WriteLine("Zadejte prosím věk pojištěnce vyjádřený arabskými číslicemi.");                      //
                }                                                                                                           //zisk tel. čísla, omezeno na int, další omezení jsem neřešil
                Console.Clear();                                                                                            //
                Console.WriteLine("Zadejte telefon pojištěné osoby ve formátu 123456789.");                                 //
                                                                                                                            //
                while (!int.TryParse(Console.ReadLine(), out telCislo))                                                     //
                {                                                                                                           //
                    Console.WriteLine("POZOR!");                                                                            //
                    Console.WriteLine("Zadejte prosím tel. číslo vyjádřené arabskými číslicemi ve formátu 123456789.");     //
                }                                                                                                           //
                Console.Clear();                                                                                            //
                Console.WriteLine("Osoba byla uložena, pro pokračování stiskněte libovolnou klávesu.");                     // výpis pro ujištění uživatele, že je vše ok
                Seznam.Add(new Pojistenec(jmeno, prijmeni, vek, telCislo));                                                 // přidání do seznamu
                Console.ReadKey();                                                                                          //
                                                                                                                            //
            }                                                                                                               //
                                                                                                                            //
        }                                                                                                                   //
                                                                                                                            //
                                                                                                                            //
                                                                                                                            //
                                                                                                                            // 
          /// <summary>
          /// Výpis všech pojištěnců                                                                                         //
          /// </summary>
        public void Vypis()                                                                                                  //
        {                                                                                                                    //
            Console.Clear();                                                                                                 //
            Console.WriteLine("Seznam všech pojištěnců:");                                                                   //
            foreach (var p in Seznam)                                                                                        //
            {                                                                                                                //
                Console.WriteLine(p);                                                                                        // Výpis foreachem, p je overrided do vhodné podoby
            }                                                                                                                //
            Console.WriteLine("Pro návrat do hlavního menu stiskněte libovolnou klávesu.");                                  //
            Console.ReadKey();                                                                                               //
                                                                                                                             //
        }                                                                                                                    //
        /// <summary>
        /// Metoda pro vyhledávání dle jména a příjmení                                                                                                                    //
        /// </summary>
        public void Vyhledej()                                                                                               //
        {                                                                                                                    // stringy do kterých za sebe píši pojištěnce a následně je vypisuji jako výsledek
            string vypisPodobnychPojistencu = "";                                                                            //
            string vypisOdpovidajicichPojistencu = "";                                                                       //
            string vyslednaZprava = "";                                                                                      //
            string jmeno;                                                                                                    //
            string prijmeni;                                                                                                 //
            Pojistenec A = null;                                                                                             //
            Console.Clear();                                                                                                 //
            Console.WriteLine("Zadejte jméno pojištěné osoby:");                                                             // získáme koho chceme hledat, osekáme od mezer
            jmeno = Console.ReadLine().Trim();                                                                               // přišlo mi zbytečné ošetřovat >>> klidně můžeme vyhledávat čísla, mezery, cokoliv
            Console.WriteLine("Zadejte příjmení pojištěné osoby:");                                                          //
            prijmeni = Console.ReadLine().Trim();                                                                            //
                                                                                                                             //
                                                                                                                             //
                                                                                                                             //
            foreach (Pojistenec p in Seznam)                                                                                 //
            {
                bool podminkaNalezeni = (p.Jmeno.ToLower() == jmeno.ToLower()) && (p.Prijmeni.ToLower() == prijmeni.ToLower());                       // podmínka pro nalezení v případě, že najdeme jméno i příjmení, uživatel neřeší malá velká písmena
                bool podminkaCastecnehoNalezeni = (p.Jmeno.ToLower() == jmeno.ToLower()) ^ (p.Prijmeni.ToLower() == prijmeni.ToLower());              // podmínka pro nalezení v případě, že máme alespoň jméno, nebo příjmení v seznamu
                                                                                                                                                      //
                                                                                                                                                      //
                                                                                                                                                      //
                                                                                                                                                      //
                                                                                                                                                      //
                if (podminkaNalezeni)                                                                                                                 //
                {                                                                                                                                     //
                                                                                                                                                      //
                                                                                                                                                      //
                                                                                                                                                      //
                    A = p;                                                                                                                            //
                    vypisOdpovidajicichPojistencu += A + "\n";                                                                                        // uložení případů kdy jsme našli jméno i příjmení
                }                                                                                                                                     //
                else if (podminkaCastecnehoNalezeni && !podminkaNalezeni)                                                                             //
                {                                                                                                                                     //
                                                                                                                                                       //
                    A = p;                                                                                                                            //
                    vypisPodobnychPojistencu += A + "\n";                                                                                             // uložení případů, kde je stejné jméno, nebo příjmení
                }                                                                                                                                     //
                                                                                                                                                      //
                                                                                                                                                      //
                                                                                                                                                      //
            }                                                                                                                                         //
                                                                                                                                                      //
            if (A == null)                                                                                                                            //
            {                                                                                                                                         //
                vyslednaZprava = "Pojištěnec " + jmeno + " " + prijmeni + " nebyl nalezen.";                                                          //
                                                                                                                                                      // hláška v případě, že ani jméno ani příjmení neodpovídá seznamu (čili je pojištěnec A null)
                Console.WriteLine(vyslednaZprava);                                                                                                    //
                                                                                                                                                      //
            }                                                                                                                                         //
            else                                                                                                                                      //
            {                                                                                                                                         //
                                                                                                                                                      // Pokud není A null a nenašli jsme shodu jména i příjmení
                if (vypisOdpovidajicichPojistencu == "")                                                                                              // vypíšeme hlášku a nabídneme podobné pojištěnce (shoda jména,nebo příjmení)
                {                                                                                                                                     //
                    vyslednaZprava = "Pojištěnec " + jmeno + " " + prijmeni + " nebyl nalezen. \nPodobné výsledky : \n";                              //
                    Console.WriteLine(vyslednaZprava + vypisPodobnychPojistencu);                                                                     //
                }                                                                                                                                     //
                else                                                                                                                                  //
                {                                                                                                                                     //
                    vyslednaZprava = "Pojištěnec " + jmeno + " " + prijmeni + " nalezen :\n";                                                         //    Pokud A není null ale našli jsme pojištěnce s odpovídajícím
                    Console.WriteLine(vyslednaZprava + vypisOdpovidajicichPojistencu);                                                                //    jménem i příjmením >>> vypíšeme je i se zprávou
                }                                                                                                                                     //
            }                                                                                                                                         //
                                                                                                                                                      //
                                                                                                                                                      // Informace pro návrat do menu a čekání na žádost o návrat (key)
            Console.WriteLine("\nPro návrat do hlavního menu stiskněte libovolnou klávesu.");                                                         //
            Console.ReadKey();                                                                                                                        //
        }















    }
}
