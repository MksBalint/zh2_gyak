using System.Collections.ObjectModel;

namespace evip_zh2
{
    public partial class MainPage : ContentPage
    {
       public string name { get; set; }
       public int height { get; set; }
       public bool didClimb { get; set; }

        public ObservableCollection<Mountain> Mountains { get; set; } = new ObservableCollection<Mountain>
        {
            new Mountain { Name = "János-hegy", Height = 527, DidClimb = false},
            new Mountain { Name = "Kis-Hárs-hegy", Height = 362, DidClimb = false},
            new Mountain { Name = "Nagy-Hárs-hegy", Height = 454, DidClimb = false},
            new Mountain { Name = "Hármashatár-hegy", Height = 495, DidClimb = false}
        };

        public bool IsMountainSelected { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void SelectedMountain(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Mountain a)
            {
                name = a.Name;
                OnPropertyChanged(nameof(name));
                height = a.Height;
                OnPropertyChanged(nameof(height));
                didClimb = a.DidClimb;
                OnPropertyChanged(nameof(didClimb));
                ((ListView)sender).SelectedItem = null;
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            foreach (Mountain a in Mountains)
            {
                a.DidClimb = false;
            }
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            foreach(Mountain a in Mountains)
            {
                if (a.Name == name)
                {
                    a.DidClimb = didClimb;
                }
            }
        }
    }
}
