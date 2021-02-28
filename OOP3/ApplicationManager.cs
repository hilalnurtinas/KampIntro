using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //başvurumanager
    class ApplicationManager
    {
        //Method injection
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //basvuru bilgilerini değerlendirme

            creditManager.Calculate();
            loggerService.Log();
        }
            public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
            {
                foreach (var credit in credits)
                {
                credit.Calculate(); 
                }
            
            }


        
    }
}
