using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
         //Methot injection
        public void BasvuruYap(IKrediManager kredimanager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //

            kredimanager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            } 


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
