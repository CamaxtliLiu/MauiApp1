namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }

        private void OnReadMoreTapped(object sender, EventArgs e)
        {
            // Check if the full text is currently visible
            bool isFullTextVisible = fullTextLabel.IsVisible;

            // Toggle the visibility of the full text
            fullTextLabel.IsVisible = !isFullTextVisible;

            // Update the "Read More/Read Less" label text
            readMoreLabel.Text = isFullTextVisible ? "Read More" : "Read Less";

            // Optionally, adjust the summary label visibility if needed
            summaryLabel.IsVisible = isFullTextVisible;
        }
    }
}