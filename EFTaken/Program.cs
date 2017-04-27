using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EFTaken
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Taak2

            //using (var entities = new BankkEntities())
            //{
            //    var query = from Klant in entities.Klanten.Include("Rekeningen")
            //                orderby Klant.Voornaam
            //                select Klant;
            //    foreach (var klant in query)
            //    {
            //        Console.WriteLine(klant.Voornaam);
            //        var totSaldo = Decimal.Zero;
            //        foreach (var rekening in klant.Rekeningen)
            //        {
            //            Console.WriteLine("{0}: {1}", rekening.RekeningNr, rekening.Saldo);
            //            totSaldo += rekening.Saldo;
            //        }
            //        Console.WriteLine("Totaal: {0}", totSaldo);
            //        Console.WriteLine();
            //    }
            //}
            #endregion
            #region Taak3
            //using (var entities = new BankkEntities())
            //{
            //    var query = from Klant in entities.Klanten
            //                orderby Klant.KlantNr
            //                select Klant;
            //    foreach (var klant in query)
            //    {
            //        Console.WriteLine("{0}: {1}", klant.KlantNr,klant.Voornaam);
            //    }
            //    try
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Geef klantnr in : ");
            //        var klantNr = int.Parse(Console.ReadLine());
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant==null)
            //            Console.WriteLine("Klant niet gevonden");

            //        else
            //        {
            //            Console.WriteLine("RekeningNr : ");
            //            var rekeningBr = Console.ReadLine();
            //            var rekening = new Rekening { RekeningNr = rekeningBr, Soort = "Z" };
            //            klant.Rekeningen.Add(rekening);
            //            entities.SaveChanges();
            //        }
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Tik een getal in !!!!!");
            //    }
            //}
            #endregion
            #region Taak4
            //using (var entities = new BankkEntities())
            //{
            //    var query = from Rekening in entities.Rekeningen
            //                orderby Rekening.RekeningNr
            //                select Rekening;

            //    foreach (var rekening in query)
            //    {
            //        Console.WriteLine("{0} : {1}", rekening.RekeningNr, rekening.Saldo);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Geef rekeningnummer in : ");
            //    var rekNr = Console.ReadLine();
            //    var gevondenRek = entities.Rekeningen.Find(rekNr);
            //    if (gevondenRek == null)
            //        Console.WriteLine("Rekeningnr niet gevonden");
            //    else
            //    {
            //        try
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("Geef te storten bedrag :");
            //            var bedrag = decimal.Parse(Console.ReadLine());
            //            if (bedrag>0)
            //            {
            //                gevondenRek.Storten(bedrag);
            //                entities.SaveChanges();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Saldo moet een positief getal zijn!!!!");
            //            }
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Saldo moet een positief getal zijn!!!!");
            //        }
            //    }
            //}
            #endregion
            #region Taak5
            //try
            //{
            //    Console.WriteLine("Geef te verwijderen klantnr : ");
            //    var klantNr = int.Parse(Console.ReadLine());
            //    using (var entities = new BankkEntities())
            //    {
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant==null)
            //        {
            //            Console.WriteLine("Klant niet gevonden !!!");
            //        }
            //        else
            //        {
            //            if (klant.Rekeningen.Count!=0)
            //            {
            //                Console.WriteLine("klant heeft nog niet afgesloten rekeningen!!!!");
            //            }
            //            else
            //            {
            //                entities.Klanten.Remove(klant);
            //                entities.SaveChanges();
            //            }
            //        }
            //    }



            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Geef een getal !!!");
            //}



            //using (var entities = new BankkEntities())
            //{




            //}
            #endregion
            #region Taak6
            //var transactionOptions = new TransactionOptions
            //{
            //    IsolationLevel = IsolationLevel.RepeatableRead
            //};
            //using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            //{
            //    using (var entities = new BankkEntities())
            //    {
            //        var query = from Rekening in entities.Rekeningen
            //                    orderby Rekening.RekeningNr
            //                    select Rekening;

            //        foreach (var rekening in query)
            //        {
            //            Console.WriteLine("{0} : {1}", rekening.RekeningNr, rekening.Saldo);
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Geef rekeningnr  VAN rekening : ");
            //        var vanRekNr = Console.ReadLine();
            //        var vanRekening = entities.Rekeningen.Find(vanRekNr);
            //        if (vanRekening == null)
            //        {
            //            Console.WriteLine("Rekening Bestaat niet");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Geef rekeningnr NAAR rekening : ");
            //            var naarRekNr = Console.ReadLine();
            //            var naarRekening = entities.Rekeningen.Find(naarRekNr);
            //            if (naarRekening == null)
            //            {
            //                Console.WriteLine("Rekening Bestaat niet");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geef over te schrijven bedrag : ");
            //                var bedrag = decimal.Parse(Console.ReadLine());
            //                if (bedrag <= decimal.Zero)
            //                {
            //                    Console.WriteLine("Dit is geen positief getal!!!");
            //                }
            //                else
            //                {
            //                    if (vanRekening.Saldo<bedrag)
            //                    {
            //                        Console.WriteLine("Saldo ontoereikend");
            //                    }
            //                    else
            //                    {
            //                        vanRekening.Storten(bedrag * -1);
            //                        naarRekening.Storten(bedrag);
            //                        entities.SaveChanges();
            //                        transactionScope.Complete();
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion
            #region Taak7

            //try
            //{
            //    Console.WriteLine("Geef klantnr : ");
            //    var klantNr = int.Parse(Console.ReadLine());
            //    using (var entities = new BankkEntities())
            //    {
            //        var klant = entities.Klanten.Find(klantNr);
            //        if (klant==null)
            //        {
            //            Console.WriteLine("Klant niet gevonden");
            //        }
            //        else
            //        {
            //            Console.WriteLine(klant.Voornaam);
            //            Console.WriteLine();
            //            Console.WriteLine("Geef aangepaste naam : ");
            //            klant.Voornaam = Console.ReadLine();
            //            entities.SaveChanges();
            //        }
            //    } 
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Geef een getal in !!!!");
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    Console.WriteLine("Een ander gebruiker wijzigd deze klant");
            //}
            #endregion
            #region Taak8

            //    using (var entities = new BankkEntities())
            //    {
            //        var query = (from personeelslid in entities.Personeel
            //                     where personeelslid.Manager == null
            //                     select personeelslid).ToList();
            //        Afbeelden(query, 0);

            //    }
            //}
            //static void Afbeelden(List<Personeelslid> personeel, int insprong)
            //{
            //    foreach (var personeelslid in personeel)
            //    {
            //        Console.Write(new String('\t', insprong));
            //        Console.WriteLine(personeelslid.Voornaam);
            //        if (personeelslid.Ondergeschikten.Count != 0)
            //        {
            //            Afbeelden(personeelslid.Ondergeschikten.ToList(), insprong + 1);
            //        }
            //    }
            //}






            #endregion
            #region Taak10

            //using (var entities = new BankkEntities())
            //{
            //    var query = from totaleSaldoPerKlant
            //                in entities.TotaleSaldoPerKlant
            //                orderby totaleSaldoPerKlant.Voornaam
            //                select totaleSaldoPerKlant;
            //    foreach (var totaleSaldoPerklant  in query)
            //    {
            //        Console.WriteLine("{0} : {1}", totaleSaldoPerklant.Voornaam, totaleSaldoPerklant.TotaleSaldo);
            //    }


            //}


            #endregion
            #region Taak11
            Console.Write("Geef kostprijs in :");
            decimal kostprijs;
            if (decimal.TryParse(Console.ReadLine(), out kostprijs))
            {
                using (var entities = new BankkEntities())
                {
                    var administratieveKostMaken = entities.AdministratieveKost(kostprijs);
                    Console.WriteLine("{0} rekeningen aangepast", administratieveKostMaken);
                }
            }
            else
            {
                Console.WriteLine("Tik een getal");
            }




            #endregion
        }
    }
}

