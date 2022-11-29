namespace MAUI_FilePicker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        #region Commented
        //private async Task<FileResult> PickAndShow(PickOptions options)
        //{
        //    try
        //    {
        //        //await DisplayAlert("Error", "In PickUp and Show Enter", "Close");
        //        var result = await FilePicker.Default.PickAsync(options);
        //        if (result != null)
        //        {
        //            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
        //                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
        //            {
        //                using var stream = await result.OpenReadAsync();
        //                var image = ImageSource.FromStream(() => stream);
        //            }
        //        }
        //       // await DisplayAlert("Error", "In PickUp and Show Exit", "Close");

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("Error", ex.Message, "Close");
        //    }
        //    return null;
        //}
        #endregion
        private async void btnPickImage_Clicked(object sender, EventArgs e)
        {
            try
            {
                #region Commented

                //var customFileType = new FilePickerFileType(
                //new Dictionary<DevicePlatform, IEnumerable<string>>
                //{
                //    { DevicePlatform.iOS, new[] { "public.my.comic.extension" } }, // UTType values
                //    { DevicePlatform.Android, new[] { "application/comics" } }, // MIME type
                //    { DevicePlatform.WinUI, new[] { ".jpeg", ".png" } }, // file extension
                //    { DevicePlatform.Tizen, new[] { "*/*" } },
                //    { DevicePlatform.macOS, new[] { "cbr", "cbz" } }, // UTType values
                //});

                //PickOptions options = new()
                //{
                //    PickerTitle = "Please select a comic file",

                //    FileTypes = customFileType,
                //};



                // var fileResult = await FilePicker.Default.PickAsync(options);

                // var fileResult =  FilePicker.PickAsync(PickOptions.Images).Result;

                //if (fileResult != null)
                //{
                //    if (fileResult.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                //        fileResult.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                //    {
                //        using var stream = await fileResult.OpenReadAsync();
                //        var image = ImageSource.FromStream(() => stream);
                //        imgSrc.Source = image;
                //    }
                //}


                ////var fileResult =   await PickAndShow(PickOptions.Default);
                //if (fileResult != null)
                //{
                //    imgSrc.Source = ImageSource.FromFile(fileResult.FileName);
                //    // imgSrc.Source = ImageSource.FromResource(fileResult.FileName);
                //}
                //else
                //{
                //    throw new Exception("There is Problem in File Reading");
                //}
                #endregion

                var result = await FilePicker.PickAsync(new PickOptions 
                {
                   PickerTitle = "Pick Image",     
                   FileTypes = FilePickerFileType.Images,
                });

                if (result == null) return;


                var stream = await result.OpenReadAsync();
                imgSrc.Source = ImageSource.FromStream(()=>stream);
            }
            catch (Exception ex)
            {
              //  await DisplayAlert("Error", ex.Message, "Close");
            }

           
        }

        private async void btnPickMultiplrImage_Clicked(object sender, EventArgs e)
        {
            var customFileType = new FilePickerFileType(
            new Dictionary<DevicePlatform, IEnumerable<string>>
            {
                { DevicePlatform.iOS, new[] { "com.adobe.pdf" } }, // UTType values
                { DevicePlatform.Android, new[] { "application/pdf" } }, // MIME type
                { DevicePlatform.WinUI, new[] { ".pdf" } }, // file extension
                { DevicePlatform.Tizen, new[] { "*/*" } },
                { DevicePlatform.macOS, new[] { "pdf"} }, // UTType values
            });

            var results = await FilePicker.PickMultipleAsync(new PickOptions 
            { 
               FileTypes= customFileType
            });
            foreach (var file in results)
            {
                await DisplayAlert("Info", file.FileName, "Close");
            }
        }
    }
}