using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HackyFox.Controls
{
    [ToolboxItem(true)]
    [DefaultEvent("Click")]
    public class RJProgressBar : ProgressBar
    {
        public enum TextPosition
        {
            Left,
            Right,
            Center,
            Sliding,
            None
        }

        // Apariencia
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximun = false;

        // Otros
        private bool paintedBack = false;
        private bool stopPainting = false;

        public RJProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.FromArgb(255, 241, 62);
        }

        [Category("RJ Code Advance")]
        public Color ChannelColor
        {
            get => channelColor;
            set { channelColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color SliderColor
        {
            get => sliderColor;
            set { sliderColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color ForeBackColor
        {
            get => foreBackColor;
            set { foreBackColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int ChannelHeight
        {
            get => channelHeight;
            set { channelHeight = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int SliderHeight
        {
            get => sliderHeight;
            set { sliderHeight = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public TextPosition ShowValue
        {
            get => showValue;
            set { showValue = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public string SymbolBefore
        {
            get => symbolBefore;
            set { symbolBefore = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public string SymbolAfter
        {
            get => symbolAfter;
            set { symbolAfter = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public bool ShowMaximun
        {
            get => showMaximun;
            set { showMaximun = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get => base.Font;
            set => base.Font = value;
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (!stopPainting && !paintedBack)
            {
                Graphics graph = pevent.Graphics;
                Rectangle rectChannel = new Rectangle(0, 0, Width, ChannelHeight);

                using (var brushChannel = new SolidBrush(channelColor))
                {
                    rectChannel.Y = ChannelHeight >= SliderHeight ?
                        Height - ChannelHeight :
                        Height - ((ChannelHeight + SliderHeight) / 2);

                    graph.Clear(Parent?.BackColor ?? SystemColors.Control);
                    graph.FillRectangle(brushChannel, rectChannel);

                    if (!DesignMode)
                        paintedBack = true;
                }

                if (Value == Maximum || Value == Minimum)
                    paintedBack = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!stopPainting)
            {
                Graphics graph = e.Graphics;
                double scaleFactor = ((double)Value - Minimum) / (Maximum - Minimum);
                int sliderWidth = (int)(Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, SliderHeight);

                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    rectSlider.Y = SliderHeight >= ChannelHeight ?
                        Height - SliderHeight :
                        Height - ((SliderHeight + ChannelHeight) / 2);

                    if (sliderWidth > 1)
                        graph.FillRectangle(brushSlider, rectSlider);

                    if (showValue != TextPosition.None)
                        DrawValueText(graph, sliderWidth, rectSlider);
                }
            }

            stopPainting = Value == Maximum;
        }

        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            string text = symbolBefore + Value.ToString() + symbolAfter;
            if (showMaximun)
                text += "/" + symbolBefore + Maximum.ToString() + symbolAfter;

            var textSize = TextRenderer.MeasureText(text, Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);

            using var brushText = new SolidBrush(ForeColor);
            using var brushTextBack = new SolidBrush(ForeBackColor);
            using var textFormat = new StringFormat();

            switch (showValue)
            {
                case TextPosition.Left:
                    rectText.X = 0;
                    textFormat.Alignment = StringAlignment.Near;
                    break;
                case TextPosition.Right:
                    rectText.X = Width - textSize.Width;
                    textFormat.Alignment = StringAlignment.Far;
                    break;
                case TextPosition.Center:
                    rectText.X = (Width - textSize.Width) / 2;
                    textFormat.Alignment = StringAlignment.Center;
                    break;
                case TextPosition.Sliding:
                    rectText.X = sliderWidth - textSize.Width;
                    textFormat.Alignment = StringAlignment.Center;

                    using (var brushClear = new SolidBrush(Parent?.BackColor ?? SystemColors.Control))
                    {
                        var rect = rectSlider;
                        rect.Y = rectText.Y;
                        rect.Height = rectText.Height;
                        graph.FillRectangle(brushClear, rect);
                    }
                    break;
            }

            graph.FillRectangle(brushTextBack, rectText);
            graph.DrawString(text, Font, brushText, rectText, textFormat);
        }
    }
}
