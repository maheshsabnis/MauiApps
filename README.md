# MauiApps

Please find my receips on MAUI. 

Project Name: App_MVVM
  - This project uses the Model-View-ViewModel (MVVM) implementation in MAUI. This uses the Community Toolkit.  
  - The Project explains all steps of creating MVVM implementation in MAUI Apps.
  
  
Project Name: CollectionView 
  - This project demonstrate the use of CollectionView
  - You need to make sure that, all images those are shown in CollectionView are added in Resources\images folder.
  - Make sure that each image file is having extension '.png'.
  - Make sure that for eacg image the Build Action is 'MauiImage'.
  - The output of the collection view will be displayed as per the following image
  - ![alt text](https://github.com/maheshsabnis/MauiApps/blob/main/collectionview.png?raw=true) 


Project Name: MAUI_APpActions
  - The App Actions are the feature that provides a shortcut to perform operations proir to load the actual application.
  - To use AppActions for Android application, you have to make sure that the following line must be added in MainActivity.cs file of Platforms\Android\Resources folder on the MainActivity class attribute
```` csharp
 [IntentFilter(new[] { Platform.Intent.ActionAppAction }, Categories = new[] { Android.Content.Intent.CategoryDefault })]
````
  - To use the AppActions for iOS, you have to add the following line as attribute on AppDelegate class in AppDelegate.cs file in Platforms\Android\iOS folder
```` csharp
[Register("AppDelegate")]
````
  - To execute the AppActions the MauiProgram.cs file must be modified using the following code
```` csharp
 .ConfigureEssentials(e =>
                {
                    e.AddAppAction(new AppAction("actmessage", "My Messages", icon: "messages"));
                    e.AddAppAction(new AppAction("actappointments", "My Appointments", icon: "calender"));
                    e.AddAppAction(new AppAction("actinfo", "The App Info", icon: "appinfo"));
                })
````

  - The following image shows how App Actions will be accesses
  - ![alt text](https://github.com/maheshsabnis/MauiApps/blob/main/appactions.png?raw=true) 
  - When the applciation icon is kept pressed for some time the AppActions will be shown
  - You can select an action from AppActions and the view associated with it will be shown.
  
  
 Project Name:  MAUI_OpenBrowser
 - This project will demonstrate about opening the URL in browser.
 - To open the URL in browser the internet access must be configired for the application
 - Modify the AndroidManifest.xml file of the Platforms\Android folder by adding the permission to open the browser with URL in it
```` html
	<queries>
		<intent>
			<action android:name="android.intent.action.VIEW" />
			<data android:scheme="http"/>
		</intent>
		<intent>
			<action android:name="android.intent.action.VIEW" />
			<data android:scheme="https"/>
		</intent>
	</queries>
````
 - We need to add the following code to open the URL in browser (Note: In MainPage.xml, I have ListView that shows the URL)
```` csharp
 private async void btnOpenBrowser_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Uri uri = new Uri("https://www.microsoft.com");
                Uri uri = new Uri(((WebSites)lstUrls.SelectedItem).URL);
                BrowserLaunchOptions options = new BrowserLaunchOptions()
                {
                    LaunchMode = BrowserLaunchMode.SystemPreferred,
                    TitleMode = BrowserTitleMode.Show,
                    PreferredToolbarColor = Colors.Violet,
                    PreferredControlColor = Colors.SandyBrown
                };

                await Browser.Default.OpenAsync(uri, options);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            lstUrls.ItemsSource= new List<WebSites>() 
            { 
              new WebSites("Web Net Helper", "https://www.webnethelper.com"),
              new WebSites("DNC", "https://www.dotnetcurry.com"),
              new WebSites("DevC", "https://www.devcurry.com")
            };
        }
````
  - The class that contains properties for URL information is shown in the following snippet
```` csharp
internal class WebSites
    {
        public WebSites(string siteName, string uRL)
        {
            SiteName = siteName;
            URL = uRL;
        }

        public string SiteName { get; set; }
        public string URL { get; set; }
    }
````
  - Once the application id loaded in iOS / Android, the output will be shown as follows
  - ![alt text](https://github.com/maheshsabnis/MauiApps/blob/main/list-of-urls.png?raw=true) 
  - Select the URL from the list and click on Open In Browser button. The selected URL will be loaded in browser as shown in the following image
 - ![alt text](https://github.com/maheshsabnis/MauiApps/blob/main/url-in-browser.png?raw=true) 

So these are some of the receips, and there is much more to come e.g. REST Access, Accessing Secure Storage, Device Access, etc. 

   
