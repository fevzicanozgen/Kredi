using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager= new TasitKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.Basvuruyap(esnafKrediManager, new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService() });
            
         

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
