using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using MyTabPageRender.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(MyTabRenderer))]
namespace MyTabPageRender.Droid
{
    public class MyTabRenderer : TabbedPageRenderer, TabLayout.IOnTabSelectedListener
    {
        Context mContext;

        public MyTabRenderer(Context context) : base(context)
        {
            mContext = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);


        }
        void TabLayout.IOnTabSelectedListener.OnTabReselected(TabLayout.Tab tab)
        {

            Log.Error("lv", "OnTabReselected");
            var tabs = Element as TabbedPage;
            var playTab = tabs.Children[2];
            var selectedPosition = tab.Position;

            if (selectedPosition == 2)
            {
                if (playTab.Title == "Play")
                {
                    Log.Error("lv", "Play");
                    if (tabs != null)
                    {
                        playTab.Icon = "pause";
                        playTab.Title = "Pause";
                    }
                }else if (playTab.Title == "Pause")
                {
                    Log.Error("lv", "Pause");
                    if (tabs != null)
                    {
                        playTab.Title = "Play";
                        playTab.Icon = "play";
                    }
                }
            }
        }
            void TabLayout.IOnTabSelectedListener.OnTabSelected(TabLayout.Tab tab){

            Log.Error("lv", "OnTabSelected");
            var tabs = Element as TabbedPage;
            var playTab = tabs.Children[2];
            var selectedPosition = tab.Position;
            if (selectedPosition == 2)
            {
                if (playTab.Title == "Play")
                {
                    Log.Error("lv", playTab.Title);
                   
                    if (tabs != null)
                    {
                        playTab.Title = "Pause";
                        playTab.Icon = "pause.png";
                    }
                }else if  (playTab.Title == "Pause")
                {
                    Log.Error("lv", playTab.Title);
                    
                    if (tabs != null)
                    {
                        playTab.Title = "Play";
                        playTab.Icon = "play.png";
                    }
                }
            }
        }


        }
}