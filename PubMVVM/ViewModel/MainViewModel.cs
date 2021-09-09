using PubMVVM.Model;
using PubMVVM.Repostory;
using PubMVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PubMVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainWindow MainWindow { get; set; }
        public FakeRepo PubRepostory { get; set; }
        public BuyViewModel BuyViewModel { get; set; }
        public ObservableCollection<Pub> Pubs { get; set; }
        public ObservableCollection<Pub> PubsCopy { get; set; }
        public HistoryViewModel HistoryViewModel { get; set; }
        private Pub pub;
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(); }
        }

        public Pub Pub
        {
            get { return pub; }
            set { pub = value; OnPropertyChanged(); }
        }
        public RelayCommand ShowHistoryCommand { get; set; }
        public RelayCommand BuyCommand { get; set; }
        public RelayCommand ResetCommand { get; set; }
        public RelayCommand SelectedItemChangedCommand { get; set; }
        public RelayCommand ButtonClickPlus { get; set; }
        public RelayCommand ButtonClickMinus { get; set; }
        public MainViewModel()
        {
            PubRepostory = new FakeRepo();
            Pubs = new ObservableCollection<Pub>(PubRepostory.GetAll());
            PubsCopy = new ObservableCollection<Pub>();

            SelectedItemChangedCommand = new RelayCommand((SelectedItem) =>
            {
                var item = SelectedItem as Pub;
                Pub = item;
                Count = 1;
            });


            BuyCommand = new RelayCommand((bc) =>
              {
                  if (Count != 0)
                  {
                      var view = new BuyWindow();
                      BuyViewModel = new BuyViewModel();
                      Pub.Count = Count;
                      BuyViewModel.Pub = Pub;
                      view.buyListbox.Items.Add(Pub);
                      PubsCopy.Add(Pub);
                      view.DataContext = BuyViewModel;
                      view.ShowDialog();
                  }
              });

            ButtonClickPlus = new RelayCommand((bClick) =>
            {
                if (Count != 0)
                {
                    ++Count;
                }
            });

            ButtonClickMinus = new RelayCommand((bClick) =>
            {
                if (Count != 0)
                {
                    Count--;
                }
            });

            ResetCommand = new RelayCommand((r) =>
             {
                 Count = 0;
             });

            ShowHistoryCommand = new RelayCommand((sH) =>
              {
                  var view = new HistoryWindow();
                  HistoryViewModel = new HistoryViewModel();
                  HistoryViewModel.PubsHistory = PubsCopy;
                  view.DataContext = HistoryViewModel;
                  view.ShowDialog();
              });
        }
    }
}
