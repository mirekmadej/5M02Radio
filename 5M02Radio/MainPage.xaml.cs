namespace _5M02Radio
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnUstaw(object sender, EventArgs e)
        {
            if (rbBlue.IsChecked)
                lblNapis.TextColor = Colors.Blue;
            else if (rbGreen.IsChecked)
                lblNapis.TextColor= Colors.Green;
            else if (rbRed.IsChecked)
                lblNapis.TextColor=( Colors.Red);   
        }
    }

}
