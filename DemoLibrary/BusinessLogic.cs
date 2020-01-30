using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic 
    { 
        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();


            logger.Log("Starting the processing of data");
            Console.WriteLine("Processing of data");
            dataAccess.LoadData();
            dataAccess.SaveData("processingInfo");
            logger.Log("Finished processing of data");
        }
    }
}
