using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace BigBenSkiaSharp
{
    public partial class BigBenSkiaSharpPage : ContentPage
    {
        public BigBenSkiaSharpPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1f / 60), () =>
            {
                canvasView.InvalidateSurface();
                return true;
            });
        }

        private void canvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var width = e.Info.Width;
            var height = e.Info.Height;

            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColors.Transparent);

            //transform
            canvas.Translate(width / 2f, height * 64 / 121);
            canvas.Scale(width / 360f);

            //DateTime
            DateTime currentTime = DateTime.Now;

            using (var clockPaint = new SKPaint())
            {
                clockPaint.Style = SKPaintStyle.Fill;
                clockPaint.Color = SKColors.Black;
                canvas.DrawCircle(0, 0, 40, clockPaint);
            }

            using (var arrowPaint = new SKPaint())
            {
                arrowPaint.Style = SKPaintStyle.Stroke;
                arrowPaint.Color = SKColors.White;
                arrowPaint.StrokeWidth = 2;
                arrowPaint.StrokeCap = SKStrokeCap.Round;
                arrowPaint.IsAntialias = true;

                //Hour hand
                canvas.Save();
                canvas.RotateDegrees(30 * currentTime.Hour + currentTime.Minute / 2f);
                arrowPaint.StrokeWidth = 6;
                canvas.DrawLine(0, 0, 0, -20, arrowPaint);
                canvas.Restore();

                //Minute hand
                canvas.Save();
                canvas.RotateDegrees(6 * currentTime.Minute + currentTime.Second / 10f);
                arrowPaint.StrokeWidth = 3;
                canvas.DrawLine(0, 0, 0, -30, arrowPaint);
                canvas.Restore();

                //Second hand
                canvas.Save();
                var seconds = currentTime.Second + currentTime.Millisecond / 1000f;
                canvas.RotateDegrees(6 * seconds);
                arrowPaint.StrokeWidth = 1;
                canvas.DrawLine(0, 10, 0, -35, arrowPaint);
                canvas.Restore();
            }
        }

        private void canvasBigBenView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var width = e.Info.Width;
            var height = e.Info.Height;

            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColors.Transparent);

            //transform
            canvas.Translate(-width / 16, height / 7f);
            canvas.Scale(width / 415f);

            var bigBenSkia = new BigBenSkia();
            bigBenSkia.DrawBigBenShape(canvas);
        }
    }
}
