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
                    e.AddAppAction(new AppAction("actappointments", "My Appointments", icon: "calende   r"));
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
 - Modify the  
