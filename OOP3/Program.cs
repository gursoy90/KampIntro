using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackredimanager = new IhtiyacKrediManager();
            IKrediManager tasitkredimanager = new TasitKrediManager();
            IKrediManager konutkredimanager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackredimanager,tasitkredimanager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
