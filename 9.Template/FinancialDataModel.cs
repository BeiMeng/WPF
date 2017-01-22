using System;
using System.Collections.ObjectModel;

namespace _9.Template
{
    public class FinancialDataCollection : ObservableCollection<FinancialDataPoint>
    {
        public FinancialDataCollection()
        {
            this.Add(new FinancialDataPoint { Spending = 20, Budget = 60, Label = "AAA", });
            this.Add(new FinancialDataPoint { Spending = 80, Budget = 40, Label = "BBBB", });
            this.Add(new FinancialDataPoint { Spending = 20, Budget = 60, Label = "CCCCC", });
            this.Add(new FinancialDataPoint { Spending = 80, Budget = 40, Label = "DDDDD", });
            this.Add(new FinancialDataPoint { Spending = 20, Budget = 60, Label = "EEEEEEE", });
            this.Add(new FinancialDataPoint { Spending = 60, Budget = 20, Label = "FFFFFFFF", });
        }

    }
    public class FinancialDataPoint
    {
        public string Label { get; set; }
        public double Spending { get; set; }
        public double Budget { get; set; }


        public string ToolTip { get { return String.Format("{0}, Spending {1}, Budget {2}", Label, Spending, Budget); } }

    }
}