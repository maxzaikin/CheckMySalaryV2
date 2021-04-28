using Windows.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using System.Collections.ObjectModel;
using System.IO;

namespace CheckMySalaryV2
{
    public class DataSrc
    {
        public ObservableCollection<MntsDataItem> _items;

        public async Task<IEnumerable<MntsDataItem>> GetMntsAsync()
        {
            var uri = new Uri("ms-appx:///mnts.csv");

            StorageFile _file;
            try
            {
                _file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            }
            catch (Exception e)
            {

                throw;
            }            

            IRandomAccessStreamWithContentType randomStream = await _file.OpenReadAsync();

            _items = new ObservableCollection<MntsDataItem>();

            using (StreamReader sr = new StreamReader(randomStream.AsStreamForRead()))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    //_items.Add(
                    //    new MntsDataItem()
                    //    {
                    //        Rank = uint.Parse(values[0]),
                    //        Mountain = values[1],
                    //        Height = uint.Parse(values[2]),
                    //        Range = values[3],
                    //        Coordinates = values[4],
                    //        Prominence = uint.Parse(values[5]),
                    //        ParentMountain = values[6],
                    //        First_Ascent = uint.Parse(values[7]),
                    //        Ascents = values[8]
                    //    });
                }

            }
            return _items;

        }
        public  IEnumerable<MntsDataItem> InitList()
        {           
            _items = new ObservableCollection<MntsDataItem>();          
           
            return _items;
        }


        public void OnAddENewLineExecute()
        {
            if (_items != null)
            {
               // _items.Add(new MntsDataItem(_items));
            } else
            {
                _items = new ObservableCollection<MntsDataItem>();
            }
            
        }


    }
}
