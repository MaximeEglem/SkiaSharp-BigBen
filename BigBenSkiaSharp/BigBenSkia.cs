using SkiaSharp;

namespace BigBenSkiaSharp
{
    public class BigBenSkia
    {
        #region Computed Properties
        // Global style Black
        public static SKPaint BlackFillPaint { get; set; }
        public static SKPaint BlackFramePaint { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new instance of the BigBen class.
        /// </summary>
        public BigBenSkia()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes this new instance of the BigBen class.
        /// </summary>
        internal void Initialize()
        {
            // Fill color for Black
            var BlackFillColor = new SKColor(0, 0, 0, 255);

            // Initialize Black fill paint
            BlackFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = BlackFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Black
            var BlackFrameColor = new SKColor(0, 0, 0, 255);

            // Initialize Black frame paint
            BlackFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = BlackFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };


        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Convert the BigBenShape sketch to a png encoded SkiaSharp data object.
        /// </summary>
        /// <returns>The Sketch as a <c>SKData</c> object.</returns>
        private SKData BigBenShapeToData()
        {
            using (var surface = SKSurface.Create(480, 640, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
            {
                // Create Canvas
                SKCanvas canvas = surface.Canvas;
                canvas.Clear(new SKColor(255, 255, 255, 255));

                // Draw all shapes into the canvas
                DrawBigBenShape(canvas);

                // Return data from sketch
                return surface.Snapshot().Encode();
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Draw the BigBenShape sketch into the given SkiaSharp canvas.
        /// </summary>
        /// <param name="canvas">The <c>SKCanvas</c> to draw the sketch into.</param>
        public void DrawBigBenShape(SKCanvas canvas)
        {
            // Fill color for Base Style
            var BaseStyleFillColor = new SKColor(39, 39, 39, 255);

            // New Base Style fill paint
            var BaseStyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = BaseStyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Base Style
            var BaseStyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Base Style frame paint
            var BaseStyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = BaseStyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = false,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Base shape
            canvas.DrawRect(new SKRect(177.3416f, 569.0306f, 287.4795f, 640.0781f), BaseStyleFillPaint);
            canvas.DrawRect(new SKRect(177.3416f, 569.0306f, 287.4795f, 640.0781f), BaseStyleFramePaint);

            // Draw Round Column 1 shape
            canvas.DrawRoundRect(new SKRect(183.27f, 495.6139f, 284.3685f, 500.7571f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(183.27f, 495.6139f, 284.3685f, 500.7571f), 32f, 32f, BlackFramePaint);

            // Draw Round Column 2 shape
            canvas.DrawRoundRect(new SKRect(183.27f, 482.5447f, 284.3685f, 487.6889f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(183.27f, 482.5447f, 284.3685f, 487.6889f), 32f, 32f, BlackFramePaint);

            // Draw Round Column 3 shape
            canvas.DrawRoundRect(new SKRect(183.27f, 442.2851f, 284.3685f, 447.4277f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(183.27f, 442.2851f, 284.3685f, 447.4277f), 32f, 32f, BlackFramePaint);

            // Draw Round Column 4 shape
            canvas.DrawRoundRect(new SKRect(183.27f, 428.864f, 284.3685f, 434.008f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(183.27f, 428.864f, 284.3685f, 434.008f), 32f, 32f, BlackFramePaint);

            // Draw Columns left shape
            canvas.DrawRect(new SKRect(188.4156f, 346.9765f, 197.3267f, 568.6312f), BlackFillPaint);
            canvas.DrawRect(new SKRect(188.4156f, 346.9765f, 197.3267f, 568.6312f), BlackFramePaint);

            // Draw Columns right shape
            canvas.DrawRect(new SKRect(271.0826f, 346.7151f, 279.994f, 568.3709f), BlackFillPaint);
            canvas.DrawRect(new SKRect(271.0826f, 346.7151f, 279.994f, 568.3709f), BlackFramePaint);

            // Draw Midle Columns shape
            canvas.DrawRect(new SKRect(210.3829f, 346.9765f, 214.7886f, 568.6312f), BlackFillPaint);
            canvas.DrawRect(new SKRect(210.3829f, 346.9765f, 214.7886f, 568.6312f), BlackFramePaint);

            // Draw Midle Columns 1 shape
            canvas.DrawRect(new SKRect(221.5745f, 346.7648f, 225.9803f, 568.4189f), BlackFillPaint);
            canvas.DrawRect(new SKRect(221.5745f, 346.7648f, 225.9803f, 568.4189f), BlackFramePaint);

            // Draw Midle Columns 2 shape
            canvas.DrawRect(new SKRect(233.7241f, 347.3754f, 238.1298f, 569.0305f), BlackFillPaint);
            canvas.DrawRect(new SKRect(233.7241f, 347.3754f, 238.1298f, 569.0305f), BlackFramePaint);

            // Draw Midle Columns 3 shape
            canvas.DrawRect(new SKRect(243.4246f, 346.7648f, 247.8299f, 568.4189f), BlackFillPaint);
            canvas.DrawRect(new SKRect(243.4246f, 346.7648f, 247.8299f, 568.4189f), BlackFramePaint);

            // Draw Midle Columns 4 shape
            canvas.DrawRect(new SKRect(254.4382f, 346.7648f, 258.8439f, 568.4189f), BlackFillPaint);
            canvas.DrawRect(new SKRect(254.4382f, 346.7648f, 258.8439f, 568.4189f), BlackFramePaint);

            // Draw Round Column shape
            canvas.DrawRoundRect(new SKRect(183.27f, 541.7515f, 284.3685f, 546.8961f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(183.27f, 541.7515f, 284.3685f, 546.8961f), 32f, 32f, BlackFramePaint);

            // Fill color for Round Rectangle Style
            var RoundRectangleStyleFillColor = new SKColor(230, 230, 230, 0);

            // New Round Rectangle Style fill paint
            var RoundRectangleStyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangleStyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle Style
            var RoundRectangleStyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle Style frame paint
            var RoundRectangleStyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangleStyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 13.3378f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(184.8043f, 343.5824f, 283.9297f, 367.2644f), 6.485731f, 6.485731f, RoundRectangleStyleFillPaint);
            canvas.DrawRoundRect(new SKRect(184.8043f, 343.5824f, 283.9297f, 367.2644f), 6.485731f, 6.485731f, RoundRectangleStyleFramePaint);

            // Fill color for Border Clock Style
            var BorderClockStyleFillColor = new SKColor(230, 230, 230, 0);

            // New Border Clock Style fill paint
            var BorderClockStyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = BorderClockStyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Border Clock Style
            var BorderClockStyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Border Clock Style frame paint
            var BorderClockStyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = BorderClockStyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 15.06573f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Border Clock shape
            canvas.DrawRoundRect(new SKRect(173.7149f, 226.3907f, 294.1406f, 342.7446f), 18.45377f, 18.45377f, BorderClockStyleFillPaint);
            canvas.DrawRoundRect(new SKRect(173.7149f, 226.3907f, 294.1406f, 342.7446f), 18.45377f, 18.45377f, BorderClockStyleFramePaint);

            // Fill color for Border Clock 1 Style
            var BorderClock1StyleFillColor = new SKColor(230, 230, 230, 0);

            // New Border Clock 1 Style fill paint
            var BorderClock1StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = BorderClock1StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Border Clock 1 Style
            var BorderClock1StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Border Clock 1 Style frame paint
            var BorderClock1StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = BorderClock1StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 3.795585f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Border Clock 1 shape
            canvas.DrawRoundRect(new SKRect(184.7612f, 239.0375f, 281.6596f, 329.9629f), 6.973916f, 6.973916f, BorderClock1StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(184.7612f, 239.0375f, 281.6596f, 329.9629f), 6.973916f, 6.973916f, BorderClock1StyleFramePaint);

            // Draw Rectangle shape
            canvas.DrawRect(new SKRect(189.6367f, 186.9766f, 282.1563f, 222.582f), BlackFillPaint);
            canvas.DrawRect(new SKRect(189.6367f, 186.9766f, 282.1563f, 222.582f), BlackFramePaint);

            // Fill color for Round Rectangle top Style
            var RoundRectangletopStyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top Style fill paint
            var RoundRectangletopStyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletopStyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top Style
            var RoundRectangletopStyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top Style frame paint
            var RoundRectangletopStyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletopStyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top shape
            canvas.DrawRoundRect(new SKRect(200.0234f, 195.6602f, 208.3477f, 219.3438f), 32f, 32f, RoundRectangletopStyleFillPaint);
            canvas.DrawRoundRect(new SKRect(200.0234f, 195.6602f, 208.3477f, 219.3438f), 32f, 32f, RoundRectangletopStyleFramePaint);

            // Fill color for Round Rectangle top 1 Style
            var RoundRectangletop1StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 1 Style fill paint
            var RoundRectangletop1StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop1StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 1 Style
            var RoundRectangletop1StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 1 Style frame paint
            var RoundRectangletop1StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop1StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 1 shape
            canvas.DrawRoundRect(new SKRect(210f, 195.6602f, 218.3242f, 219.3438f), 32f, 32f, RoundRectangletop1StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(210f, 195.6602f, 218.3242f, 219.3438f), 32f, 32f, RoundRectangletop1StyleFramePaint);

            // Fill color for Round Rectangle top 2 Style
            var RoundRectangletop2StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 2 Style fill paint
            var RoundRectangletop2StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop2StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 2 Style
            var RoundRectangletop2StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 2 Style frame paint
            var RoundRectangletop2StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop2StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 2 shape
            canvas.DrawRoundRect(new SKRect(220f, 195.6602f, 228.3242f, 219.3438f), 32f, 32f, RoundRectangletop2StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(220f, 195.6602f, 228.3242f, 219.3438f), 32f, 32f, RoundRectangletop2StyleFramePaint);

            // Fill color for Round Rectangle top 3 Style
            var RoundRectangletop3StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 3 Style fill paint
            var RoundRectangletop3StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop3StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 3 Style
            var RoundRectangletop3StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 3 Style frame paint
            var RoundRectangletop3StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop3StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 3 shape
            canvas.DrawRoundRect(new SKRect(230f, 195.6602f, 238.3242f, 219.3438f), 32f, 32f, RoundRectangletop3StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(230f, 195.6602f, 238.3242f, 219.3438f), 32f, 32f, RoundRectangletop3StyleFramePaint);

            // Fill color for Round Rectangle top 4 Style
            var RoundRectangletop4StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 4 Style fill paint
            var RoundRectangletop4StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop4StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 4 Style
            var RoundRectangletop4StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 4 Style frame paint
            var RoundRectangletop4StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop4StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 4 shape
            canvas.DrawRoundRect(new SKRect(240f, 195.6602f, 248.3242f, 219.3438f), 32f, 32f, RoundRectangletop4StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(240f, 195.6602f, 248.3242f, 219.3438f), 32f, 32f, RoundRectangletop4StyleFramePaint);

            // Fill color for Round Rectangle top 5 Style
            var RoundRectangletop5StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 5 Style fill paint
            var RoundRectangletop5StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop5StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 5 Style
            var RoundRectangletop5StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 5 Style frame paint
            var RoundRectangletop5StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop5StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 5 shape
            canvas.DrawRoundRect(new SKRect(240f, 195.6602f, 248.3242f, 219.3438f), 32f, 32f, RoundRectangletop5StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(240f, 195.6602f, 248.3242f, 219.3438f), 32f, 32f, RoundRectangletop5StyleFramePaint);

            // Fill color for Round Rectangle top 6 Style
            var RoundRectangletop6StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 6 Style fill paint
            var RoundRectangletop6StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop6StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 6 Style
            var RoundRectangletop6StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 6 Style frame paint
            var RoundRectangletop6StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop6StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 6 shape
            canvas.DrawRoundRect(new SKRect(250f, 195.6602f, 258.3242f, 219.3438f), 32f, 32f, RoundRectangletop6StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(250f, 195.6602f, 258.3242f, 219.3438f), 32f, 32f, RoundRectangletop6StyleFramePaint);

            // Fill color for Round Rectangle top 7 Style
            var RoundRectangletop7StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 7 Style fill paint
            var RoundRectangletop7StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop7StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 7 Style
            var RoundRectangletop7StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 7 Style frame paint
            var RoundRectangletop7StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop7StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 7 shape
            canvas.DrawRoundRect(new SKRect(260f, 195.6602f, 268.3242f, 219.3438f), 32f, 32f, RoundRectangletop7StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(260f, 195.6602f, 268.3242f, 219.3438f), 32f, 32f, RoundRectangletop7StyleFramePaint);

            // Draw Rectangle shape
            canvas.DrawRect(new SKRect(189.957f, 216.3008f, 280.6641f, 224.0391f), BlackFillPaint);
            canvas.DrawRect(new SKRect(189.957f, 216.3008f, 280.6641f, 224.0391f), BlackFramePaint);

            // Define Triangle shape path
            var TrianglePath = new SKPath();
            TrianglePath.MoveTo(new SKPoint(237.1016f, 92.52344f));
            TrianglePath.LineTo(new SKPoint(197.9844f, 191.5625f));
            TrianglePath.LineTo(new SKPoint(276.2188f, 191.5625f));
            TrianglePath.LineTo(new SKPoint(237.1016f, 92.52344f));

            // Draw Triangle shape
            canvas.DrawPath(TrianglePath, BlackFillPaint);
            canvas.DrawPath(TrianglePath, BlackFramePaint);

            // Define Triangle 1 shape path
            var Triangle1Path = new SKPath();
            Triangle1Path.MoveTo(new SKPoint(236.5449f, 57.375f));
            Triangle1Path.LineTo(new SKPoint(220.7734f, 102.0195f));
            Triangle1Path.LineTo(new SKPoint(252.3164f, 102.0195f));
            Triangle1Path.LineTo(new SKPoint(236.5449f, 57.375f));

            // Draw Triangle 1 shape
            canvas.DrawPath(Triangle1Path, BlackFillPaint);
            canvas.DrawPath(Triangle1Path, BlackFramePaint);

            // Fill color for Round Rectangle top 1 Style
            var RoundRectangletop1Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 1 Style fill paint
            var RoundRectangletop1Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop1Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 1 Style
            var RoundRectangletop1Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 1 Style frame paint
            var RoundRectangletop1Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop1Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 1 shape
            canvas.DrawRoundRect(new SKRect(213.2734f, 164f, 219.2734f, 182f), 32f, 32f, RoundRectangletop1Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(213.2734f, 164f, 219.2734f, 182f), 32f, 32f, RoundRectangletop1Style1FramePaint);

            // Fill color for Round Rectangle top 2 Style
            var RoundRectangletop2Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 2 Style fill paint
            var RoundRectangletop2Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop2Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 2 Style
            var RoundRectangletop2Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 2 Style frame paint
            var RoundRectangletop2Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop2Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 2 shape
            canvas.DrawRoundRect(new SKRect(226.2109f, 164f, 232.2109f, 182f), 32f, 32f, RoundRectangletop2Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(226.2109f, 164f, 232.2109f, 182f), 32f, 32f, RoundRectangletop2Style1FramePaint);

            // Fill color for Round Rectangle top 3 Style
            var RoundRectangletop3Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 3 Style fill paint
            var RoundRectangletop3Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop3Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 3 Style
            var RoundRectangletop3Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 3 Style frame paint
            var RoundRectangletop3Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop3Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 3 shape
            canvas.DrawRoundRect(new SKRect(241.6562f, 164f, 247.6562f, 182f), 32f, 32f, RoundRectangletop3Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(241.6562f, 164f, 247.6562f, 182f), 32f, 32f, RoundRectangletop3Style1FramePaint);

            // Fill color for Round Rectangle top 4 Style
            var RoundRectangletop4Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 4 Style fill paint
            var RoundRectangletop4Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop4Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 4 Style
            var RoundRectangletop4Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 4 Style frame paint
            var RoundRectangletop4Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop4Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 4 shape
            canvas.DrawRoundRect(new SKRect(256.707f, 164f, 262.707f, 182f), 32f, 32f, RoundRectangletop4Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(256.707f, 164f, 262.707f, 182f), 32f, 32f, RoundRectangletop4Style1FramePaint);

            // Fill color for Round Rectangle top 5 Style
            var RoundRectangletop5Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 5 Style fill paint
            var RoundRectangletop5Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop5Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 5 Style
            var RoundRectangletop5Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 5 Style frame paint
            var RoundRectangletop5Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop5Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 5 shape
            canvas.DrawRoundRect(new SKRect(220.164f, 144.1211f, 226.164f, 162.1211f), 32f, 32f, RoundRectangletop5Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(220.164f, 144.1211f, 226.164f, 162.1211f), 32f, 32f, RoundRectangletop5Style1FramePaint);

            // Fill color for Round Rectangle top 6 Style
            var RoundRectangletop6Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 6 Style fill paint
            var RoundRectangletop6Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop6Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 6 Style
            var RoundRectangletop6Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 6 Style frame paint
            var RoundRectangletop6Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop6Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 6 shape
            canvas.DrawRoundRect(new SKRect(234.3867f, 144f, 240.3867f, 162f), 32f, 32f, RoundRectangletop6Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(234.3867f, 144f, 240.3867f, 162f), 32f, 32f, RoundRectangletop6Style1FramePaint);

            // Fill color for Round Rectangle top 7 Style
            var RoundRectangletop7Style1FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 7 Style fill paint
            var RoundRectangletop7Style1FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop7Style1FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 7 Style
            var RoundRectangletop7Style1FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 7 Style frame paint
            var RoundRectangletop7Style1FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop7Style1FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 7 shape
            canvas.DrawRoundRect(new SKRect(249.664f, 144f, 255.664f, 162f), 32f, 32f, RoundRectangletop7Style1FillPaint);
            canvas.DrawRoundRect(new SKRect(249.664f, 144f, 255.664f, 162f), 32f, 32f, RoundRectangletop7Style1FramePaint);

            // Draw Rectangle 1 shape
            canvas.DrawRect(new SKRect(208.3828f, 179.1914f, 268.7617f, 184.543f), BlackFillPaint);
            canvas.DrawRect(new SKRect(208.3828f, 179.1914f, 268.7617f, 184.543f), BlackFramePaint);

            // Draw Rectangle 2 shape
            canvas.DrawRect(new SKRect(213.6679f, 158.0664f, 259.7071f, 162.2383f), BlackFillPaint);
            canvas.DrawRect(new SKRect(213.6679f, 158.0664f, 259.7071f, 162.2383f), BlackFramePaint);

            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(185.1484f, 184.8281f, 285.7695f, 191.3672f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(185.1484f, 184.8281f, 285.7695f, 191.3672f), 32f, 32f, BlackFramePaint);

            // Draw Round Rectangle 1 shape
            canvas.DrawRoundRect(new SKRect(211.1406f, 136.1641f, 262.1406f, 142.1641f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(211.1406f, 136.1641f, 262.1406f, 142.1641f), 32f, 32f, BlackFramePaint);

            // Draw Rectangle shape
            canvas.DrawRect(new SKRect(213.8008f, 99.32422f, 258.8008f, 135.3555f), BlackFillPaint);
            canvas.DrawRect(new SKRect(213.8008f, 99.32422f, 258.8008f, 135.3555f), BlackFramePaint);

            // Fill color for Round Rectangle top 6 Style
            var RoundRectangletop6Style2FillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 6 Style fill paint
            var RoundRectangletop6Style2FillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop6Style2FillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 6 Style
            var RoundRectangletop6Style2FrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 6 Style frame paint
            var RoundRectangletop6Style2FramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop6Style2FrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 6 shape
            canvas.DrawRoundRect(new SKRect(215.8125f, 112f, 220.8125f, 128f), 32f, 32f, RoundRectangletop6Style2FillPaint);
            canvas.DrawRoundRect(new SKRect(215.8125f, 112f, 220.8125f, 128f), 32f, 32f, RoundRectangletop6Style2FramePaint);

            // Fill color for Round Rectangle top 8 Style
            var RoundRectangletop8StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 8 Style fill paint
            var RoundRectangletop8StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop8StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 8 Style
            var RoundRectangletop8StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 8 Style frame paint
            var RoundRectangletop8StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop8StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 8 shape
            canvas.DrawRoundRect(new SKRect(225f, 111.7266f, 230f, 127.7266f), 32f, 32f, RoundRectangletop8StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(225f, 111.7266f, 230f, 127.7266f), 32f, 32f, RoundRectangletop8StyleFramePaint);

            // Fill color for Round Rectangle top 10 Style
            var RoundRectangletop10StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 10 Style fill paint
            var RoundRectangletop10StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop10StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 10 Style
            var RoundRectangletop10StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 10 Style frame paint
            var RoundRectangletop10StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop10StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 10 shape
            canvas.DrawRoundRect(new SKRect(234f, 111.7266f, 239f, 127.7266f), 32f, 32f, RoundRectangletop10StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(234f, 111.7266f, 239f, 127.7266f), 32f, 32f, RoundRectangletop10StyleFramePaint);

            // Fill color for Round Rectangle top 12 Style
            var RoundRectangletop12StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 12 Style fill paint
            var RoundRectangletop12StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop12StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 12 Style
            var RoundRectangletop12StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 12 Style frame paint
            var RoundRectangletop12StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop12StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 12 shape
            canvas.DrawRoundRect(new SKRect(243f, 111.7266f, 248f, 127.7266f), 32f, 32f, RoundRectangletop12StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(243f, 111.7266f, 248f, 127.7266f), 32f, 32f, RoundRectangletop12StyleFramePaint);

            // Fill color for Round Rectangle top 13 Style
            var RoundRectangletop13StyleFillColor = new SKColor(253, 252, 255, 255);

            // New Round Rectangle top 13 Style fill paint
            var RoundRectangletop13StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = RoundRectangletop13StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Round Rectangle top 13 Style
            var RoundRectangletop13StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Round Rectangle top 13 Style frame paint
            var RoundRectangletop13StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = RoundRectangletop13StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            // Draw Round Rectangle top 13 shape
            canvas.DrawRoundRect(new SKRect(251f, 111.7266f, 256f, 127.7266f), 32f, 32f, RoundRectangletop13StyleFillPaint);
            canvas.DrawRoundRect(new SKRect(251f, 111.7266f, 256f, 127.7266f), 32f, 32f, RoundRectangletop13StyleFramePaint);

            // Draw Round Rectangle 1 shape
            canvas.DrawRoundRect(new SKRect(215.5156f, 126.3711f, 258.3242f, 129.582f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(215.5156f, 126.3711f, 258.3242f, 129.582f), 32f, 32f, BlackFramePaint);

            // Fill color for Stick Style
            var StickStyleFillColor = new SKColor(230, 230, 230, 255);

            // New Stick Style fill paint
            var StickStyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = StickStyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Stick Style
            var StickStyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Stick Style frame paint
            var StickStyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = StickStyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            //-----------------------------------------------------------------------------
            // Draw Stick shape group
            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(234.5117f, 19.54297f, 238.5117f, 80.83594f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(234.5117f, 19.54297f, 238.5117f, 80.83594f), 32f, 32f, BlackFramePaint);

            // Draw Oval shape
            canvas.DrawOval(new SKRect(228.8125f, 31.35156f, 243.9609f, 37.81641f), BlackFillPaint);
            canvas.DrawOval(new SKRect(228.8125f, 31.35156f, 243.9609f, 37.81641f), BlackFramePaint);

            //-----------------------------------------------------------------------------


            // Draw Oval shape
            canvas.DrawOval(new SKRect(231.2305f, 6.621094f, 240.5273f, 14.14453f), BlackFillPaint);
            canvas.DrawOval(new SKRect(231.2305f, 6.621094f, 240.5273f, 14.14453f), BlackFramePaint);

            // Fill color for Stick 1 Style
            var Stick1StyleFillColor = new SKColor(230, 230, 230, 255);

            // New Stick 1 Style fill paint
            var Stick1StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = Stick1StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Stick 1 Style
            var Stick1StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Stick 1 Style frame paint
            var Stick1StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = Stick1StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            //-----------------------------------------------------------------------------
            // Draw Stick 1 shape group
            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(275.8284f, 155.1797f, 278.9403f, 187.7891f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(275.8284f, 155.1797f, 278.9403f, 187.7891f), 32f, 32f, BlackFramePaint);

            // Draw Oval shape
            canvas.DrawOval(new SKRect(271.3945f, 161.4621f, 283.1797f, 164.9015f), BlackFillPaint);
            canvas.DrawOval(new SKRect(271.3945f, 161.4621f, 283.1797f, 164.9015f), BlackFramePaint);

            //-----------------------------------------------------------------------------


            // Fill color for Stick 2 Style
            var Stick2StyleFillColor = new SKColor(230, 230, 230, 255);

            // New Stick 2 Style fill paint
            var Stick2StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = Stick2StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Stick 2 Style
            var Stick2StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Stick 2 Style frame paint
            var Stick2StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = Stick2StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            //-----------------------------------------------------------------------------
            // Draw Stick 2 shape group
            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(194.1956f, 153.0469f, 197.3075f, 185.6563f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(194.1956f, 153.0469f, 197.3075f, 185.6563f), 32f, 32f, BlackFramePaint);

            // Draw Oval shape
            canvas.DrawOval(new SKRect(189.7617f, 159.3292f, 201.5469f, 162.7687f), BlackFillPaint);
            canvas.DrawOval(new SKRect(189.7617f, 159.3292f, 201.5469f, 162.7687f), BlackFramePaint);

            //-----------------------------------------------------------------------------


            // Fill color for Stick 3 Style
            var Stick3StyleFillColor = new SKColor(230, 230, 230, 255);

            // New Stick 3 Style fill paint
            var Stick3StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = Stick3StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Stick 3 Style
            var Stick3StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Stick 3 Style frame paint
            var Stick3StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = Stick3StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            //-----------------------------------------------------------------------------
            // Draw Stick 3 shape group
            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(216.0395f, 77.1875f, 218.8719f, 100.2656f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(216.0395f, 77.1875f, 218.8719f, 100.2656f), 32f, 32f, BlackFramePaint);

            // Draw Oval shape
            canvas.DrawOval(new SKRect(212.0039f, 81.63361f, 222.7305f, 84.06778f), BlackFillPaint);
            canvas.DrawOval(new SKRect(212.0039f, 81.63361f, 222.7305f, 84.06778f), BlackFramePaint);

            //-----------------------------------------------------------------------------


            // Fill color for Stick 4 Style
            var Stick4StyleFillColor = new SKColor(230, 230, 230, 255);

            // New Stick 4 Style fill paint
            var Stick4StyleFillPaint = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = Stick4StyleFillColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true
            };

            // Frame color for Stick 4 Style
            var Stick4StyleFrameColor = new SKColor(0, 0, 0, 255);

            // New Stick 4 Style frame paint
            var Stick4StyleFramePaint = new SKPaint()
            {
                Style = SKPaintStyle.Stroke,
                Color = Stick4StyleFrameColor,
                BlendMode = SKBlendMode.SrcOver,
                IsAntialias = true,
                StrokeWidth = 1f,
                StrokeMiter = 4f,
                StrokeJoin = SKStrokeJoin.Miter,
                StrokeCap = SKStrokeCap.Butt
            };

            //-----------------------------------------------------------------------------
            // Draw Stick 4 shape group
            // Draw Round Rectangle shape
            canvas.DrawRoundRect(new SKRect(254.7583f, 77f, 257.5907f, 100.0781f), 32f, 32f, BlackFillPaint);
            canvas.DrawRoundRect(new SKRect(254.7583f, 77f, 257.5907f, 100.0781f), 32f, 32f, BlackFramePaint);

            // Draw Oval shape
            canvas.DrawOval(new SKRect(250.7227f, 81.44611f, 261.4492f, 83.88028f), BlackFillPaint);
            canvas.DrawOval(new SKRect(250.7227f, 81.44611f, 261.4492f, 83.88028f), BlackFramePaint);

            //-----------------------------------------------------------------------------



        }
        #endregion

    }
}
