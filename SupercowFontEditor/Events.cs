using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EblanModule;
using Nevosoft;

namespace SupercowFontEditor
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            preview.Image = new Bitmap((int)imageSize.Value, (int)imageSize.Value);
            nevofont.TextureWidth = (ushort)imageSize.Value;
            nevofont.TextureHeight = (ushort)imageSize.Value;
            nevofont.GlyphsPerRow = (uint)glyphsPRow.Value;
        }

        private void FontStyle_Checked(object s, EventArgs e)
        {
            fontStyle ^= (FontStyle)(s as CheckBox).Tag;
            DrawPreview();
        }

        private void FontPicker_IndexSelected(object s, EventArgs e)
        {
            fontFamily = new FontFamily(fontPicker.Text);
            DrawPreview();
        }

        private void OutlineSlider_Changed(object s, EventArgs e)
        {
            DrawPreview();
        }

        private void FontColor_Click(object s, EventArgs e)
        {
            fontColor.BackColor = GetColor();
            DrawPreview();
        }

        private void OutlineColor_Click(object s, EventArgs e)
        {
            outlineColor.BackColor = GetColor();
            DrawPreview();
        }

        private void ExportImage_Click(object s, EventArgs e)
        {
            using (var dialog = new SaveFileDialog()
            { FileName = "font.png", OverwritePrompt = true,
                Title = "Save " + "Image".EblanRnd(),
                Filter = "PNG Image (*.png)|*.png" })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                preview.Image.Save(dialog.FileName);
            }
        }

        private void RemoveChar_Click(object s, EventArgs e)
        {
            foreach (ListViewItem item in charsList.SelectedItems)
            {
                charsList.Items.Remove(item);
                nevofont.Glyphs = nevofont.Glyphs
                    .Where((val, idx) => idx != item.Index).ToArray();
            }
            DrawPreview();
        }

        private void RemoveAll_Click(object s, EventArgs e)
        {
            charsList.Items.Clear();
            Array.Clear(nevofont.Glyphs,
                0, nevofont.Glyphs.Length);
            DrawPreview();
        }

        private void AddChar_Click(object s, EventArgs e)
        {
            if (addCharText.Text == "" || addCharText.Text == null) return;
            if (charsList.Items.Count >= 1024) return;
            if (charsList.Items.Cast<ListViewItem>()
                .FirstOrDefault(x => x.Text == addCharText.Text) != null) return;
            ListViewItem item = new ListViewItem()
            { Text = addCharText.Text };
            charsList.Items.Add(item);
            SizeF size = GetCharSize(addCharText.Text, Graphics.FromImage(preview.Image), stringFormat);
            var trueCount = nevofont.Glyphs.Count(i => i.GlyphWidth != 0);
            nevofont.Glyphs[trueCount].Glyph = addCharText.Text.ToCharArray()[0];
            nevofont.Glyphs[trueCount].GlyphWidth = (ushort)size.Width;
            DrawPreview();
        }

        private void ImportFont_Click(object s, EventArgs e)
        {
            using (var dialog = new OpenFileDialog()
            { Filter = "Nevosoft Font Data (*.dat)|*.dat",
                Title = "Select " + "Font".EblanRnd(),
                RestoreDirectory = true })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                nevofont = new FontV2(dialog.FileName);
                charsList.Items.Clear();
                imageSize.Value = nevofont.TextureWidth;
                glyphsPRow.Value = nevofont.GlyphsPerRow;
                for (int i = 0; i < nevofont.Glyphs.Length; i++)
                {
                    if (nevofont.Glyphs[i].GlyphWidth == 0) continue;
                    ListViewItem item = new ListViewItem()
                    { Text = nevofont.Glyphs[i].Glyph.ToString() };
                    charsList.Items.Add(item);
                }
                DrawPreview();
            }
        }

        private void ExportFont_Click(object s, EventArgs e)
        {
            using (var dialog = new SaveFileDialog()
            { FileName = "font.dat", OverwritePrompt = true,
                Filter = "Nevosoft Font Data (*.dat)|*.dat",
                Title = "Save " + "Font".EblanRnd() })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                nevofont.Save(dialog.FileName);
            }
        }

        private void ImageSize_Changed(object s, EventArgs e)
        {
            nevofont.TextureWidth = (ushort)imageSize.Value;
            nevofont.TextureHeight = (ushort)imageSize.Value;
            DrawPreview();
        }

        private void GlyphsPRow_Changed(object s, EventArgs e)
        {
            nevofont.GlyphsPerRow = (uint)glyphsPRow.Value;
            DrawPreview();
        }

        private void ZoomSlider_Scroll(object s, EventArgs e)
        {
            int size = 380 * zoomSlider.Value;
            preview.Size = new Size(size, size);
        }
    }
}