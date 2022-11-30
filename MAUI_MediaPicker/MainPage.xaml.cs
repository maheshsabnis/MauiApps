namespace MAUI_MediaPicker
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

      
        private async void btnTakePhoto_Clicked(object sender, EventArgs e)
        {

            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    var stream = await photo.OpenReadAsync(); 
                    using FileStream localFileStream = File.OpenWrite(localFilePath);

                     await sourceStream.CopyToAsync(localFileStream);
                    capturedImage.Source = ImageSource.FromStream(()=> stream);
                }
            }
        }
    }
}