namespace MAUI_Activity_Button
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
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

        private async void btn1_Tapped(object sender, EventArgs e)
        {
            btn1.IsInProgress= true; // Activity Indicator
            await Task.Delay(5000); // Some Long Running Process
            btn1.IsInProgress = false; // Complete the Process and hide the Indicator
        }
    }
}