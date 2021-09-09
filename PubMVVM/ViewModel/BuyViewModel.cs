using PubMVVM.Model;
using PubMVVM.Repostory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.ViewModel
{
    public class BuyViewModel:BaseViewModel
    {
        private Pub pub;

        public Pub Pub
        {
            get { return pub; }
            set { pub = value;OnPropertyChanged();}
        }

       
    }
}
