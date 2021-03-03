using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void Basvuruyap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
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
