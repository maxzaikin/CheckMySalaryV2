using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMySalaryV2
{
    public class MntsDataItem : ViewModelBase
    {
        private int _lineNo;
        private int _regularHrs;
        private int _ot15Hrs;
        private int _ot20Hrs;
        private int _hollidayHrs;

             
        public MntsDataItem()
        {
           // _lineNo = _items.Count() +1;
        }
        
        public int HollidayHrs
        {
            get { return _hollidayHrs; }
            set
            {
                if (_hollidayHrs != value)
                {
                    _hollidayHrs = value;
                    RaisePropertyChanged();
                }

            }
        }

        public int OT20Hrs
        {
            get { return _ot20Hrs; }
            set
            {
                if (_ot20Hrs != value)
                {
                    _ot20Hrs = value;
                }
            }
        }

        public int OT15Hrs
        {
            get { return _ot15Hrs; }
            set
            {
                if (_ot15Hrs != value)
                {
                    _ot15Hrs = value;
                }
            }
        }

        public int RegularHrs
        {
            get { return _regularHrs; }
            set
            {
                if (_regularHrs != value)
                {
                    _regularHrs = value;
                }
            }
        }

        public int LineNo
        {
            get { return _lineNo; }
            set
            {
                if (_lineNo != value)
                {
                    _lineNo = value;
                }
            }
        }

       
    }
}
