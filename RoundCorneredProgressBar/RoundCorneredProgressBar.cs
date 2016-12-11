﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundCorneredProgressBar
{
    public partial class RoundCorneredProgressBar : PictureBox
    {
        private Timer t = new Timer();

        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;

        Bitmap bmp;
        Graphics g;

        public RoundCorneredProgressBar()
        {
            DoubleBuffered = true;
            ProgressBarColor = Color.FromArgb(224, 224, 224);
            ProgressBackColor = Color.FromArgb(255, 128, 255);
            ProgressFont = new Font(Font.FontFamily, (int)(this.Height * 0.7), FontStyle.Bold);
            ProgressFontColor = Color.Black;
            Value = 0;
        }

        public int Value { get; set; }

        [Category("Appearance")]
        public Color ProgressBarColor { get; set; }

        [Category("Appearance")]
        public Color ProgressBackColor { get; set; }

        [Category("Appearance")]
        public Font ProgressFont { get; set; }

        [Category("Appearance")]
        public Color ProgressFontColor { get; set; }


        private GraphicsPath GetRoundRectagle(Rectangle bounds)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = bounds.Height;
            if (bounds.Height <= 0) radius = 20;
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
        private void RecreateRegion()
        {
            var bounds = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
            bounds.Inflate(-1, -1);
            this.Region = new Region(GetRoundRectagle(bounds));
            this.Invalidate();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        /// <summary>
        /// start the animation of filling the progress bar  
        /// </summary>
        public void Animate()
        {
            pbWIDTH = this.Width;
            pbHEIGHT = this.Height;

            pbUnit = pbWIDTH / 100.0;

            //% [min = 0 max = 100]
            pbComplete = 0;

            bmp = new Bitmap(pbWIDTH, pbHEIGHT);

            //timer
            this.t.Interval = 50;    
            this.t.Tick += new EventHandler(this.t_Tick);
            this.t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //graphics
            g = Graphics.FromImage(bmp);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.HighQuality;

            //clear graphics
            g.Clear(ProgressBackColor);

            GraphicsPath path = new GraphicsPath();
            Rectangle innerBounds = new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHEIGHT);

            //progressbar region filling
            Region r = new Region(GetRoundRectagle(innerBounds));

            g.FillRegion(new SolidBrush(ProgressBarColor), r);

            //draw string
            g.DrawString(pbComplete + "%", new Font(ProgressFont.FontFamily, (int)(pbHEIGHT * 0.6), ProgressFont.Style), new SolidBrush(ProgressFontColor), new PointF(pbWIDTH / 2 - pbHEIGHT, pbHEIGHT / 10));

            //load bitmap in picturebox picboxPB
            this.Image = bmp;

            //update pbComplete
            pbComplete++;
            if (pbComplete > Value)
            {
                //dispose
                g.Dispose();
                this.t.Stop();
            }

        }

    }
}
