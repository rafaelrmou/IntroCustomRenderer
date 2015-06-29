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

//S鉶 os namespaces necess醨io para customizar o nosso controle
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using IntroCustomRenderer;
using IntroCustomRenderer.Droid;

//injeção de dependencia
[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace IntroCustomRenderer.Droid
{
    public class CustomTabbedPageRenderer : TabbedRenderer
    {

        protected override void DispatchDraw(Android.Graphics.Canvas canvas)
        {
            setIcons();
            base.DispatchDraw(canvas);
        }

        private void setIcons()
        {
            //Respons醰el pela Tela
            var Activity = this.Context as Activity;

            if (Activity != null && Activity.ActionBar != null)
            {
                int i = 0;
                //for (int i = 0; i < Activity.ActionBar.TabCount; i++)
                //{
                //    Android.App.ActionBar.Tab Aba = Activity.ActionBar.GetTabAt(i);

                //    Aba.SetIcon(ResourceIdFromString("icon"));
                //}

                foreach (var item in this.Element.Children)
                {

                    Android.App.ActionBar.Tab Aba = Activity.ActionBar.GetTabAt(i);

                    Aba.SetIcon(ResourceIdFromString(item.Icon.File));


                    i++;
                }
            }
        }

        private int ResourceIdFromString(string p)
        {
			p = p.ToLower ().Replace (".png", "").Replace (".jpg", "");

            Type tipo = typeof(Resource.Drawable);

            return (int)tipo.GetFields().FirstOrDefault(n => n.Name.ToLower() == p).GetValue(null);
        }

    }
}