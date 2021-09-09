using PubMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.ViewModel
{
    public class HistoryViewModel
    {
        public ObservableCollection<Pub> PubsHistory { get; set; }
    }
}
