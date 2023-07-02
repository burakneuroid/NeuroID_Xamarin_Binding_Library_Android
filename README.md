# NeuroID_Xamarin_Binding_Library_Android
Xamarin Binding Library for NeuroID SDK - Android

Folder Structure

- Kotlin
  - VendorFrameworks

- Xamarin
  - Android.Binding
    - Binding Library for Android SDK. Just use the compiled "Android.Binding.dll" in your Xamarin app with the configuration below:
      - NeuroID n = new NeuroID.Builder(this.Application, "{key}").Build();
      - NeuroID.SetNeuroIdInstance(n);
      - n.SiteId = "{siteId}";
      - n.UserId = {setUseriD}
      - n.Start(); 
  - Android.Sample
    - Xamarin Android Sample app for testing
   
Demo : <img src="https://github.com/burakneuroid/NeuroID_Xamarin_Binding_Library_Android/blob/673cd2dbde92561a3d8d6c85f0c67a28c85bd7ee/Demo.png" width="700px"/>
