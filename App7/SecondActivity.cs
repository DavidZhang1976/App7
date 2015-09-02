using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App7
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "second" layout resource
            SetContentView(Resource.Layout.Sencond);

            Button btnToMain = FindViewById<Button>(Resource.Id.butToMain);
            btnToMain.Click += delegate {
                Finish();
            };

        }
    }
}