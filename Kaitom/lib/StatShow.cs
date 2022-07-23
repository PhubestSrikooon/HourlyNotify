using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Kaitom.lib
{
    internal class StatShow : Panel
    {
        public string NowTimeThai { get; set; } = "เวลาตอนนี้";
        public string NowTime { get; set; } = "00:00:10 AM";
        public string NextTimeThai { get; set; } = "การแจ้งเตือนครั่งถัดไป";
        public string NextTime { get; set; } = "00:00:10 AM";
        public Font f1 { get; set; } = new Font(DefaultFont.FontFamily,12f,FontStyle.Regular);
        public Font f2 { get; set; } = new Font(DefaultFont.FontFamily, 50f,FontStyle.Bold);
        public Font f3 { get; set; } = new Font(DefaultFont.FontFamily, 30f, FontStyle.Bold);
        public StatShow()
        {
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
        }



        // Fix lib flicker
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED 
                return result;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawString(NowTimeThai,
                f1,
                new SolidBrush(Color.Crimson),
                new PointF(this.Width/2 - TextRenderer.MeasureText(NowTimeThai, f1).Width/2, 0));
            e.Graphics.DrawString(NowTime,
                f2,
                new SolidBrush(Color.Crimson),
                new PointF(this.Width / 2 - TextRenderer.MeasureText(NowTime, f2).Width / 2, TextRenderer.MeasureText(NowTimeThai, f1).Height));


            e.Graphics.DrawString(NextTimeThai,
                f1,
                new SolidBrush(Color.DarkGreen),
                new PointF(this.Width / 2 - TextRenderer.MeasureText(NextTimeThai, f1).Width / 2, TextRenderer.MeasureText(NowTimeThai, f1).Height + TextRenderer.MeasureText(NowTime, f2).Height + 20));
            e.Graphics.DrawString(NextTime,
                f3,
                new SolidBrush(Color.DarkGreen),
                new PointF(this.Width / 2 - TextRenderer.MeasureText(NextTime, f3).Width / 2, TextRenderer.MeasureText(NowTimeThai, f1).Height + TextRenderer.MeasureText(NowTimeThai, f1).Height + TextRenderer.MeasureText(NowTime, f2).Height + 20));

        }
    }
}
