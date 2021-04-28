using System.Collections;

namespace CheckMySalaryV2
{
    public class LineViewModel : ViewModelBase, IEnumerable

    {
        private readonly MntsDataItem _lineData;

        public LineViewModel(MntsDataItem _data)
        {
            _lineData = _data; ;
        }

        private double _hourlyRate;

        public double HourlyRate
        {
            get { return _hourlyRate; }
            set
            {
                _hourlyRate = value;
                RaisePropertyChanged();
            }
        }


        private int hrsSummary;

        public int HrsSummary
        {
            get { return _lineData.HollidayHrs + _lineData.OT20Hrs + _lineData.OT15Hrs + _lineData.RegularHrs; }
            set { hrsSummary = value; }
        }


        public int HollidayHrs
        {
            get { return _lineData.HollidayHrs; }
            set
            {
                if (_lineData.HollidayHrs != value)
                {
                    _lineData.HollidayHrs = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(HrsSummary));
                }
            }
        }

        public int OT20Hrs
        {
            get { return _lineData.OT20Hrs; }
            set
            {
                if (_lineData.OT20Hrs != value)
                {
                    _lineData.OT20Hrs = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(HrsSummary));
                }
            }
        }

        public int OT15Hrs
        {
            get { return _lineData.OT15Hrs; }
            set
            {
                if (_lineData.OT15Hrs != value)
                {
                    _lineData.OT15Hrs = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(HrsSummary));
                }
            }
        }

        public int RegularHrs
        {
            get { return _lineData.RegularHrs; }
            set
            {
                if (_lineData.RegularHrs != value)
                {
                    _lineData.RegularHrs = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(HrsSummary));
                }
            }
        }

        public int LineNo
        {
            get { return _lineData.LineNo; }
            set
            {
                if (_lineData.LineNo != value)
                {
                    _lineData.LineNo = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(HrsSummary));
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }




    }
}
