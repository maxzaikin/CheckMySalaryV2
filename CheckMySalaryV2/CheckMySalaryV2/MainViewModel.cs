using System.Collections.ObjectModel;

namespace CheckMySalaryV2
{
    public class MainViewModel : ViewModelBase
    {
        private MntsDataItem _selectedLine;
        public ObservableCollection<LineViewModel> Lines { get; } = new();       


        public MntsDataItem SelectedLine
        {
            get { return _selectedLine; }
            set
            {
                if (_selectedLine != value)
                {
                    _selectedLine = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void OnAddENewLineExecute()
        {
            Lines.Add(new LineViewModel(new MntsDataItem()));
            Lines[Lines.Count - 1].LineNo = Lines.Count;           
        }
        
    }
}
