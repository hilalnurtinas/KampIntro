using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager(); 
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(housingCreditManager, databaseLoggerService);
   

           List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, vehicleCreditManager };

            //applicationManager.KrediOnBilgilendirmesiYap(credits);

        }
        
        
    }
    
}
