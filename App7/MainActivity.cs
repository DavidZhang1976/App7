using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App7
{
    [Activity(Label = "App7", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.Main);

                // Get our button from the layout resource,
                // and attach an event to it
                Button button = FindViewById<Button>(Resource.Id.MyButton);

                button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

                Button button1 = FindViewById<Button>(Resource.Id.button1);
                TextView textview = FindViewById<TextView>(Resource.Id.textView1);
                button1.Click += delegate { textview.Text = string.Format("{0} hello zzb!!", count); };

                Button btnPhone = FindViewById<Button>(Resource.Id.btnPhone);


                btnPhone.Click += delegate { };
                btnPhone.Click += BtnPhone_Click;

                Button btnToSec = FindViewById<Button>(Resource.Id.btnToSec);
                btnToSec.Click += delegate {
                    Intent intent = new Intent(this, typeof(SecondActivity));
                    StartActivity(intent);
                };
            
        }
        private void BtnPhone_Click(object sender, EventArgs e)
        {
            //创建 是否类型提示框
            var callDialog = new AlertDialog.Builder(this);
            //提示框信息
            callDialog.SetMessage("是否开始通话？");
            //确定按钮的文字和事件
            callDialog.SetNeutralButton("通话", delegate
            {
                //创建打电话的事件
                Intent call = new Intent(Intent.ActionCall);
                EditText txtPhone = FindViewById<EditText>(Resource.Id.txtPhone);
                //要打给的电话号是多少
                call.SetData(Android.Net.Uri.Parse("tel:" + txtPhone.Text));
                //执行这个事件
                StartActivity(call);
            });
            //取消按钮的文字和事件
            callDialog.SetNegativeButton("取消", delegate { });
            //显示出来。
            callDialog.Show();
        }
    }
}

