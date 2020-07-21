using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using App2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry),typeof(CustomEntry))]
namespace App2.Droid
{
    public class CustomEntry : EntryRenderer
    {
        public CustomEntry(Context context) : base(context)
            {
                
            }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || e.NewElement == null)
            {
                return;
            }
            Control.Background = null;
            if (!e.NewElement.IsPassword)
            {
                Control.InputType = InputTypes.TextFlagNoSuggestions;
            }
        }
    }
}