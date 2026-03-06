namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saad valida mis LINQ-i tahad kasutada");
            Console.WriteLine("Vali Number");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Tooted, mille hind on üle 50 euro (Filtreerimine)");
            Console.WriteLine("2. Sorteerimine Linna ja Nime järgi");
            Console.WriteLine("3. Kõikide toodete nimed");
            Console.WriteLine("4. Jätab vahele esimesed kolm toodet");
            Console.WriteLine("5. Näitab tooteid seni, kuni millegi hind on üle 100 euro");
            Console.WriteLine("6. Näitab esimest liha toodet listis");
            Console.WriteLine("7. Toodete statistikad");
            Console.WriteLine("8. Kontroll, et kas midagi maksab üle 500 euro");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Filtreerimine();
                    break;

                case 2:
                    Sorteerimine();
                    break;

                case 3:
                    Projitseerimine();
                    break;

                case 4:
                    Vahelejätmine();
                    break;

                case 5:
                    TakeWhile();
                    break;

                case 6:
                    FirstOrDefault();
                    break;

                case 7:
                    Statistika();
                    break;

                case 8:
                    Kontroll();
                    break;

                default:
                    Console.WriteLine("Valik ei sobi");
                    break;
            }
        }

        public static void Filtreerimine()
        {
            Console.Clear();

            //kui on midagi, mis maksab üle 50 euro, siis konsool näitab seda 
            var ProductPrice = ProductList.products.Where(x => x.Price > 50);

            Console.WriteLine("-----Tooted üle 50 euro-----");
            foreach (var Price in ProductPrice)
            {
                Console.WriteLine("Toote nimi on " + Price.Name + " ja hind on " + Price.Price + " Eurot");
            }
        }

        public static void Sorteerimine()
        {
            Console.Clear();

            var Sorteerimine = ClientList.Clients
            //järjestab linnad tähestikulises järjekorras
            .OrderBy(x => x.City)
            //kui on sama linn, siis ta järjestab nimelises järjekorras
            .ThenBy(x => x.Name);

            Console.WriteLine("-----Sorteerimine Linna ja seejärel nime järgi-----");
            foreach (var Client in Sorteerimine)
            {
                Console.WriteLine("Linn: " + Client.City + " Nimi: " + Client.Name);
            }
        }

        public static void Projitseerimine()
        {
            Console.Clear();

            //Select valib tooteid nimede järgi, mis pärast siis konsool kirjutab välja
            var Projitseerimine = ProductList.products.Select(x => new {Name = x.Name});

            Console.WriteLine("-----Toodete Nimed-----");
            foreach ( var Product in Projitseerimine)
            {
                Console.WriteLine(Product.Name);
            }
        }

        public static void Vahelejätmine()
        {
            Console.Clear();

            //Skip jätab vahele esimesed 3 toodet
            var Skip = ProductList.products.Skip(3);

            Console.WriteLine("-----Jätab vahele esimesed kolm toodet-----");
            foreach ( var Product in Skip)
            {
                Console.WriteLine(Product.Name);
            }
        }

        public static void TakeWhile()
        {
            Console.Clear();

            //võtab tooteid ja kirjutab neid konsooli niikaua, kui tuleb midagi
            //mis maksab rohkem kui 100 eurot ja järgmiseid tooteid ültse enam ei näita
            var TakeWhile = ProductList.products.TakeWhile(x => x.Price < 100);

            Console.WriteLine("-----Tooted niikaua, kuni midagi maksab üle 100 euro-----");
            foreach (var Product in TakeWhile)
            {
                Console.WriteLine(Product.Name);
            }
        }

        public static void FirstOrDefault()
        {
            Console.Clear();

            //otsib esimest toodet, mis vastab ta tingimusele ja kui leiab selle siis läheb konsooli
            var Toode = ProductList.products.FirstOrDefault(x => x.Category == "Liha").Name;

            Console.WriteLine("-----Esimene liha toode listis-----");
            Console.WriteLine("Esimene Liha toode listis on " + Toode);

        }

        public static void Statistika()
        {
            Console.Clear();

            //võtab kõik tooted ja arvutab keskmise hinna nende vahel
            var Average = ProductList.products.Average(x => x.Price);

            Console.WriteLine("-----Kõikide toodete keskmine hind-----");
            Console.WriteLine("Kõikide toodete keskmine hind on " + Average + " eurot");
            Console.WriteLine("---------------------------------------");

            //võtab kõik tooted ja otsib kõige kallimat ja kirjutab konsooli selle
            var max = ProductList.products.Max( x => x.Price);

            Console.WriteLine("-----Kõige kallim toode-----");
            Console.WriteLine("Kõige kallim toode maksab " + max + " eurot");
            Console.WriteLine("---------------------------------------");

            //otsib tooted, mis vastab ta tingimusele ja kui leiab selle siis
            //kirjutab toote konsooli ja lõpp
            var Count = ProductList.products.Count(x => x.Category == "Liha");

            Console.WriteLine("-----Liha toodete arv-----");
            Console.WriteLine("Liha tooteid on kokku " + Count);
            Console.WriteLine("---------------------------------------");
        }

        public static void Kontroll()
        {
            Console.Clear();

            //otsib läbi kõik tooted, et vaadata kas midagi on üle 500 euro
            //ja kui on siis kirjutab konsooli True ja kui ei ole siis kirjutab
            //konsooli False
            var Kontroll = ProductList.products.All(x => x.Price < 500);

            Console.WriteLine("-----Kontroll, et kas midagi maksab üle 500 euro-----");
            Console.WriteLine(Kontroll);
        }
    }
}
