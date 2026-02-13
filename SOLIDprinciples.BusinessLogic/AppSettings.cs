using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class AppSettings
    {
        private static AppSettings _instance;

        public string Environment { get; set; } = "Staging";
        public bool EnablePaymentLogging { get; set; } = true;
        

        private AppSettings() { }
        
        public static AppSettings Instance()
        {
            if( _instance == null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }

    }
}
