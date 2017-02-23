using C_Back_60CA.Model;
using C_Back_60CA.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Linq;

namespace C_Back_60CA
{
    class MainWindowViewModel
    {
        private AnalogCSVRepo mCBankUB;
        public List<AnalogPoint> ListCbankPoint;
        private IEnumerable<string> ShortName;
        private DispatcherTimer m_dispatcherTimer = new DispatcherTimer();
        public MainWindowViewModel()
        {
            Console.WriteLine("Hello");
            this.mCBankUB = new AnalogCSVRepo();
            this.mCBankUB.ReadAnalogCSV();
            ListCbankPoint = this.mCBankUB.ListAnalogPoint;
            ShortName = ListCbankPoint.Select(s=>s.ShortName) ;
         }
    }
}
