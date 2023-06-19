//using Android.Content;
//using Android.Graphics;
using InfoMovies.UWP.CustomRenderers;
using InfoMovies.Helpers;
using InfoMovies.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Controls;

[assembly: ExportRenderer(typeof(GradientMask), typeof(GradientMaskRenderer))]
namespace InfoMovies.UWP.CustomRenderers
{
    public class GradientMaskRenderer : VisualElementRenderer<GradientMask>
    {
        #region Constructors

        //public GradientMaskRenderer(Context context) : base(context)
        //{}

        #endregion

        #region Overrides

        protected /*override*/ void DispatchDraw(Canvas canvas)
        {
            try
            {
                /*
                var gradient = new LinearGradient(
                    0, 0, 0, Height, Element.TopColor.ToAndroid(),
                    Element.BottomColor.ToAndroid(), Shader.TileMode.Mirror);

                var paint = new Paint
                {
                    Dither = true
                };

                paint.SetShader(gradient);
                canvas.DrawPaint(paint);
                */
            }
            catch (Exception ex)
            {
                LogHelper.LogException(ex);
            }
            
            //base.DispatchDraw(canvas);
        }

        #endregion
    }

    public class VisualElementRenderer<T>
    {
        //
    }
}