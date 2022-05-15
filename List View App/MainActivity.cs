using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;

namespace List_View_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ListView listnames;
private List<string> itemlist;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            listnames = (ListView)FindViewById<ListView>(Resource.Id.listView1);
            itemlist = new List<string>();
            itemlist.Add("SRM University");
            itemlist.Add("VIT University");
            itemlist.Add("ANNA University");
            itemlist.Add("IIT Chennai");
            itemlist.Add("IIT Mumbai");
            itemlist.Add("IIT Delhi");
            itemlist.Add("Alagapa University");
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,
            Android.Resource.Layout.SimpleListItem1, itemlist);
            listnames.Adapter = adapter;
            listnames.ItemClick += Listnames_ItemClick;
        }

        private object FindViewById<T>(object listView1)
        {
            throw new NotImplementedException();
        }

        private void Listnames_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, e.Position.ToString(), ToastLength.Long).Show();
        }
       
            
            
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}