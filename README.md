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
      - NIDSharedPrefsDefaults c = new NIDSharedPrefsDefaults(this);
         - Guid myuuid = Guid.NewGuid();
         - string myuuidAsString = myuuid.ToString();
         - c.SetUserId(myuuidAsString);
      - n.Start();
      - You have to store the uuid that you used and pass it to your backend and use when you make a NeuroID - Analytics API Call
  - Android.Sample
    - Xamarin Android Sample app for testing
   
Demo : <img src="https://github.com/burakneuroid/NeuroID_Xamarin_Binding_Library_Android/blob/673cd2dbde92561a3d8d6c85f0c67a28c85bd7ee/Demo.png" width="700px"/>

DISCLAIMER: We've prepared a general guide to assist you in creating a Xamarin binding library for our SDKs (see attached) Please note that this guide is shared as a courtesy and is not part of our official documentation or support.
The guide and any associated sample code are shared under the MIT License. 

This means they are provided "as is", without warranty of any kind, express or implied, including but not limited to the warranties of merchantability, fitness for a particular purpose, and non-infringement. In no event shall the authors or copyright holders be liable for any claim, damages, or other liability, whether in an action of contract, tort, or otherwise, arising from, out of, or in connection with the guide or the use of or other dealings in the guide.

By using this guide and associated sample code, you accept these terms and agree that Neuro-ID is not responsible for any issues or liabilities arising from your use of the guide or associated sample code.

Please contact Neuro-ID Implementation Engineering Team if you have any questions :
ie@neuro-id.com
