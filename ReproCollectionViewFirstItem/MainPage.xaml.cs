using System.Collections.ObjectModel;

namespace ReproCollectionViewFirstItem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public ObservableCollection<string> Items { get; set; }

        public MainPage()
        {
            

            Items = new ObservableCollection<string>();

            for (int i = 0; i < 25; i++)
            {
                Items.Add(string.Concat(Enumerable.Repeat("x", i)));
            }
            
            InitializeComponent();

            BindingContext = this;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
