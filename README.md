# NeuroID_Xamarin_Binding_Library_Android
Xamarin Binding Library for NeuroID SDK - Android

Folder Structure

- Kotlin
  - VendorFrameworks

- Xamarin
  - Android.Binding
    - Binding Library for Android SDK. Just use the compiled "Android.Binding.dll" in your Xamarin app with the configuration below:
            NeuroID n = new NeuroID.Builder(this.Application, "{key}").Build();
            NeuroID.SetNeuroIdInstance(n);
            n.SiteId = "form_yours920";
            n.UserId = {setUseriD}
            n.Start();
  - Android.Sample
    - Xamarin Android Sample app for testing
   
Demo : 
