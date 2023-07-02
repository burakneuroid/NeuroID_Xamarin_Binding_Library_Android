using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Com.Neuroid.Tracker;
using Com.Neuroid.Tracker.Utils;
using Com.Neuroid.Tracker.Storage;

namespace NeuroIDXamarinAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            NeuroID n = new NeuroID.Builder(this.Application, "key_live_9cKE1AM8ZHxeKIhCJ4eC9GTd").Build();
            n.Environment = "LIVE";
            
            NeuroID.SetNeuroIdInstance(n);
            n.SiteId = "form_yours920";

            NIDSharedPrefsDefaults c = new NIDSharedPrefsDefaults(this);
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();

            c.SetUserId(myuuidAsString);

      
            n.Start();




        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            var result = "Please create your native control";
            //var control = new Com.Microsoft.CoolcontrolsLibrary.CoolKotlinControl();
            //var result = control.DoIt("Alexey");

           
             
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

     

    
}

