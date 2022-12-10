using Nevosoft;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SupercowFontEditor
{
    public partial class Form
    {
        FontV2 nevofont = new FontV2();

        FontFamily fontFamily = new FontFamily("Arial");
        FontStyle fontStyle = FontStyle.Regular;

        readonly StringFormat stringFormat = new StringFormat
        {
            FormatFlags = StringFormatFlags.NoClip
                | StringFormatFlags.MeasureTrailingSpaces,
            Alignment = StringAlignment.Center
        };

        private void DrawPreview()
        {
            float glyphSize = (float)(imageSize.Value / glyphsPRow.Value);
            Bitmap bmp = new Bitmap((int)imageSize.Value, (int)imageSize.Value);
            int i = 0;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                g.SmoothingMode = SmoothingMode.HighQuality;
                foreach (ListViewItem item in charsList.Items)
                {
                    float Y = (int)(i / glyphsPRow.Value) * glyphSize;
                    float X = (int)(i % glyphsPRow.Value) * glyphSize;
                    var idx = Array.FindIndex(nevofont.Glyphs,
                        el => el.Glyph == item.Text.ToCharArray()[0]);
                    nevofont.Glyphs[idx].GlyphWidth = 
                        (ushort)GetCharSize(item.Text, g, stringFormat).Width;
                    DrawChar(item.Text, new RectangleF(X, Y, glyphSize, glyphSize),
                        g, stringFormat);
                    i++;
                }
            }
            preview.Image = bmp;
            preview.Refresh();
        }

        private Color GetColor()
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.Cancel)
                    return Color.Transparent;
                return cd.Color;
            }
        }

        private SizeF GetCharSize(string c, in Graphics g, StringFormat sf)
        {
            sf.SetMeasurableCharacterRanges(new CharacterRange[1] { new CharacterRange(0, 1) });
            Font stringFont = new Font(fontFamily, (float)(imageSize.Value / glyphsPRow.Value / 2), fontStyle);
            SizeF size = g.MeasureString(c, stringFont);
            RectangleF layoutRect = new RectangleF(0, 0, size.Width, size.Height);
            var stringRegions = g.MeasureCharacterRanges(c, stringFont, layoutRect, sf);
            Region region = stringRegions[0];
            RectangleF rect = region.GetBounds(g);
            return rect.Size;
        }

        private void DrawChar(string c, RectangleF r, in Graphics g, StringFormat sf)
        {
            using (GraphicsPath gp = new GraphicsPath() { FillMode = FillMode.Winding })
            using (Pen outline = new Pen(outlineSlider.Value != 0 ?
                outlineColor.BackColor : Color.Transparent, outlineSlider.Value)
            { LineJoin = LineJoin.Round })
            using (Brush foreBrush = new SolidBrush(Color.FromArgb(255, fontColor.BackColor)))
            {
                gp.AddString(c, fontFamily, (int)fontStyle,
                    g.DpiX * (float)(imageSize.Value / glyphsPRow.Value / 2) / 72, r, sf);
                g.DrawPath(outline, gp);
                g.FillPath(foreBrush, gp);
            }
        }
    }
}
