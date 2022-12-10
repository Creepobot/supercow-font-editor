using EblanModule;
using System.Windows.Forms;

namespace SupercowFontEditor
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.bold = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.underline = new System.Windows.Forms.CheckBox();
            this.strikeout = new System.Windows.Forms.CheckBox();
            this.fontGroup = new System.Windows.Forms.GroupBox();
            this.outlineSizeLabel = new System.Windows.Forms.Label();
            this.outlineColorLabel = new System.Windows.Forms.Label();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.outlineColor = new System.Windows.Forms.Button();
            this.fontColor = new System.Windows.Forms.Button();
            this.previewGroup = new System.Windows.Forms.GroupBox();
            this.previewScroll = new System.Windows.Forms.Panel();
            this.preview = new System.Windows.Forms.PictureBox();
            this.exportImage = new System.Windows.Forms.Button();
            this.tilemapGroup = new System.Windows.Forms.GroupBox();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.removeAll = new System.Windows.Forms.Button();
            this.removeChar = new System.Windows.Forms.Button();
            this.addChar = new System.Windows.Forms.Button();
            this.charsList = new System.Windows.Forms.ListView();
            this.glyphsPRowLabel = new System.Windows.Forms.Label();
            this.glyphsPRow = new System.Windows.Forms.NumericUpDown();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.imageSize = new System.Windows.Forms.NumericUpDown();
            this.addCharText = new System.Windows.Forms.TextBox();
            this.glyph = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exportFont = new System.Windows.Forms.Button();
            this.importFont = new System.Windows.Forms.Button();
            this.outlineSlider = new SupercowFontEditor.SliderNumericUpDown(this.components);
            this.fontPicker = new FontComboBox();
            this.fontGroup.SuspendLayout();
            this.previewGroup.SuspendLayout();
            this.previewScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.tilemapGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glyphsPRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // bold
            // 
            this.bold.Appearance = System.Windows.Forms.Appearance.Button;
            this.bold.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.Location = new System.Drawing.Point(136, 14);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(22, 22);
            this.bold.TabIndex = 13;
            this.bold.Tag = System.Drawing.FontStyle.Bold;
            this.bold.UseVisualStyleBackColor = false;
            this.bold.CheckedChanged += new System.EventHandler(this.FontStyle_Checked);
            // 
            // italic
            // 
            this.italic.Appearance = System.Windows.Forms.Appearance.Button;
            this.italic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.italic.Image = ((System.Drawing.Image)(resources.GetObject("italic.Image")));
            this.italic.Location = new System.Drawing.Point(164, 14);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(22, 22);
            this.italic.TabIndex = 14;
            this.italic.Tag = System.Drawing.FontStyle.Italic;
            this.italic.UseVisualStyleBackColor = false;
            this.italic.CheckedChanged += new System.EventHandler(this.FontStyle_Checked);
            // 
            // underline
            // 
            this.underline.Appearance = System.Windows.Forms.Appearance.Button;
            this.underline.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.Location = new System.Drawing.Point(192, 14);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(22, 22);
            this.underline.TabIndex = 12;
            this.underline.Tag = System.Drawing.FontStyle.Underline;
            this.underline.UseVisualStyleBackColor = false;
            this.underline.CheckedChanged += new System.EventHandler(this.FontStyle_Checked);
            // 
            // strikeout
            // 
            this.strikeout.Appearance = System.Windows.Forms.Appearance.Button;
            this.strikeout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.strikeout.Image = ((System.Drawing.Image)(resources.GetObject("strikeout.Image")));
            this.strikeout.Location = new System.Drawing.Point(220, 14);
            this.strikeout.Name = "strikeout";
            this.strikeout.Size = new System.Drawing.Size(22, 22);
            this.strikeout.TabIndex = 10;
            this.strikeout.Tag = System.Drawing.FontStyle.Strikeout;
            this.strikeout.UseVisualStyleBackColor = false;
            this.strikeout.CheckedChanged += new System.EventHandler(this.FontStyle_Checked);
            // 
            // fontGroup
            // 
            this.fontGroup.Controls.Add(this.outlineSlider);
            this.fontGroup.Controls.Add(this.fontPicker);
            this.fontGroup.Controls.Add(this.outlineSizeLabel);
            this.fontGroup.Controls.Add(this.outlineColorLabel);
            this.fontGroup.Controls.Add(this.fontColorLabel);
            this.fontGroup.Controls.Add(this.outlineColor);
            this.fontGroup.Controls.Add(this.fontColor);
            this.fontGroup.Controls.Add(this.strikeout);
            this.fontGroup.Controls.Add(this.underline);
            this.fontGroup.Controls.Add(this.bold);
            this.fontGroup.Controls.Add(this.italic);
            this.fontGroup.Location = new System.Drawing.Point(8, 8);
            this.fontGroup.Name = "fontGroup";
            this.fontGroup.Size = new System.Drawing.Size(348, 74);
            this.fontGroup.TabIndex = 2;
            this.fontGroup.TabStop = false;
            this.fontGroup.Text = "Font Settings";
            // 
            // outlineSizeLabel
            // 
            this.outlineSizeLabel.Location = new System.Drawing.Point(117, 49);
            this.outlineSizeLabel.Name = "outlineSizeLabel";
            this.outlineSizeLabel.Size = new System.Drawing.Size(66, 13);
            this.outlineSizeLabel.TabIndex = 4;
            this.outlineSizeLabel.Text = "Outline Size:";
            // 
            // outlineColorLabel
            // 
            this.outlineColorLabel.Location = new System.Drawing.Point(8, 49);
            this.outlineColorLabel.Name = "outlineColorLabel";
            this.outlineColorLabel.Size = new System.Drawing.Size(70, 13);
            this.outlineColorLabel.TabIndex = 6;
            this.outlineColorLabel.Text = "Outline Color:";
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.Location = new System.Drawing.Point(248, 18);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(58, 13);
            this.fontColorLabel.TabIndex = 7;
            this.fontColorLabel.Text = "Font Color:";
            // 
            // outlineColor
            // 
            this.outlineColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outlineColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outlineColor.Location = new System.Drawing.Point(78, 46);
            this.outlineColor.Name = "outlineColor";
            this.outlineColor.Size = new System.Drawing.Size(35, 20);
            this.outlineColor.TabIndex = 8;
            this.outlineColor.UseVisualStyleBackColor = false;
            this.outlineColor.Click += new System.EventHandler(this.OutlineColor_Click);
            // 
            // fontColor
            // 
            this.fontColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fontColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fontColor.Location = new System.Drawing.Point(305, 14);
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(35, 20);
            this.fontColor.TabIndex = 9;
            this.fontColor.UseVisualStyleBackColor = false;
            this.fontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // previewGroup
            // 
            this.previewGroup.Controls.Add(this.previewScroll);
            this.previewGroup.Location = new System.Drawing.Point(367, 8);
            this.previewGroup.Name = "previewGroup";
            this.previewGroup.Size = new System.Drawing.Size(385, 395);
            this.previewGroup.TabIndex = 1;
            this.previewGroup.TabStop = false;
            this.previewGroup.Tag = "";
            this.previewGroup.Text = "Preview";
            // 
            // previewScroll
            // 
            this.previewScroll.AutoScroll = true;
            this.previewScroll.Controls.Add(this.preview);
            this.previewScroll.Location = new System.Drawing.Point(3, 13);
            this.previewScroll.Name = "previewScroll";
            this.previewScroll.Size = new System.Drawing.Size(380, 380);
            this.previewScroll.TabIndex = 1;
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(380, 380);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // exportImage
            // 
            this.exportImage.Location = new System.Drawing.Point(246, 376);
            this.exportImage.Name = "exportImage";
            this.exportImage.Size = new System.Drawing.Size(113, 27);
            this.exportImage.TabIndex = 1;
            this.exportImage.Text = "Export Image";
            this.exportImage.UseVisualStyleBackColor = true;
            this.exportImage.Click += new System.EventHandler(this.ExportImage_Click);
            // 
            // tilemapGroup
            // 
            this.tilemapGroup.Controls.Add(this.zoomLabel);
            this.tilemapGroup.Controls.Add(this.zoomSlider);
            this.tilemapGroup.Controls.Add(this.removeAll);
            this.tilemapGroup.Controls.Add(this.removeChar);
            this.tilemapGroup.Controls.Add(this.addChar);
            this.tilemapGroup.Controls.Add(this.charsList);
            this.tilemapGroup.Controls.Add(this.glyphsPRowLabel);
            this.tilemapGroup.Controls.Add(this.glyphsPRow);
            this.tilemapGroup.Controls.Add(this.imageSizeLabel);
            this.tilemapGroup.Controls.Add(this.imageSize);
            this.tilemapGroup.Controls.Add(this.addCharText);
            this.tilemapGroup.Location = new System.Drawing.Point(8, 88);
            this.tilemapGroup.Name = "tilemapGroup";
            this.tilemapGroup.Size = new System.Drawing.Size(351, 282);
            this.tilemapGroup.TabIndex = 0;
            this.tilemapGroup.TabStop = false;
            this.tilemapGroup.Text = "Tilemap Settings";
            // 
            // zoomLabel
            // 
            this.zoomLabel.Location = new System.Drawing.Point(250, 228);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(80, 13);
            this.zoomLabel.TabIndex = 24;
            this.zoomLabel.Text = "Preview Zoom:";
            // 
            // zoomSlider
            // 
            this.zoomSlider.AutoSize = false;
            this.zoomSlider.Location = new System.Drawing.Point(245, 240);
            this.zoomSlider.Minimum = 1;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Size = new System.Drawing.Size(105, 36);
            this.zoomSlider.TabIndex = 23;
            this.zoomSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.zoomSlider.Value = 1;
            this.zoomSlider.Scroll += new System.EventHandler(this.ZoomSlider_Scroll);
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(250, 100);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(93, 23);
            this.removeAll.TabIndex = 22;
            this.removeAll.Text = "Remove All";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // removeChar
            // 
            this.removeChar.Location = new System.Drawing.Point(250, 71);
            this.removeChar.Name = "removeChar";
            this.removeChar.Size = new System.Drawing.Size(93, 23);
            this.removeChar.TabIndex = 21;
            this.removeChar.Text = "Remove";
            this.removeChar.UseVisualStyleBackColor = true;
            this.removeChar.Click += new System.EventHandler(this.RemoveChar_Click);
            // 
            // addChar
            // 
            this.addChar.Location = new System.Drawing.Point(277, 43);
            this.addChar.Name = "addChar";
            this.addChar.Size = new System.Drawing.Size(66, 22);
            this.addChar.TabIndex = 20;
            this.addChar.Text = "Add";
            this.addChar.UseVisualStyleBackColor = true;
            this.addChar.Click += new System.EventHandler(this.AddChar_Click);
            // 
            // charsList
            // 
            this.charsList.HideSelection = false;
            this.charsList.Location = new System.Drawing.Point(8, 44);
            this.charsList.Name = "charsList";
            this.charsList.Size = new System.Drawing.Size(235, 230);
            this.charsList.TabIndex = 19;
            this.charsList.UseCompatibleStateImageBehavior = false;
            // 
            // glyphsPRowLabel
            // 
            this.glyphsPRowLabel.Location = new System.Drawing.Point(120, 21);
            this.glyphsPRowLabel.Name = "glyphsPRowLabel";
            this.glyphsPRowLabel.Size = new System.Drawing.Size(86, 13);
            this.glyphsPRowLabel.TabIndex = 17;
            this.glyphsPRowLabel.Text = "Glyphs Per Row:";
            // 
            // glyphsPRow
            // 
            this.glyphsPRow.Location = new System.Drawing.Point(206, 17);
            this.glyphsPRow.Maximum = 32;
            this.glyphsPRow.Minimum = 1;
            this.glyphsPRow.Name = "glyphsPRow";
            this.glyphsPRow.Size = new System.Drawing.Size(36, 20);
            this.glyphsPRow.TabIndex = 16;
            this.glyphsPRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.glyphsPRow.Value = 22;
            this.glyphsPRow.ValueChanged += new System.EventHandler(this.GlyphsPRow_Changed);
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.Location = new System.Drawing.Point(6, 21);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(62, 13);
            this.imageSizeLabel.TabIndex = 15;
            this.imageSizeLabel.Text = "Image Size:";
            // 
            // imageSize
            // 
            this.imageSize.Location = new System.Drawing.Point(67, 17);
            this.imageSize.Maximum = 4096;
            this.imageSize.Minimum = 128;
            this.imageSize.Name = "imageSize";
            this.imageSize.Size = new System.Drawing.Size(46, 20);
            this.imageSize.TabIndex = 2;
            this.imageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageSize.Value = 1034;
            this.imageSize.ValueChanged += new System.EventHandler(this.ImageSize_Changed);
            // 
            // addCharText
            // 
            this.addCharText.Location = new System.Drawing.Point(250, 44);
            this.addCharText.MaxLength = 1;
            this.addCharText.Name = "addCharText";
            this.addCharText.Size = new System.Drawing.Size(20, 20);
            this.addCharText.TabIndex = 0;
            // 
            // exportFont
            // 
            this.exportFont.Location = new System.Drawing.Point(127, 376);
            this.exportFont.Name = "exportFont";
            this.exportFont.Size = new System.Drawing.Size(113, 27);
            this.exportFont.TabIndex = 3;
            this.exportFont.Text = "Export Settings";
            this.exportFont.UseVisualStyleBackColor = true;
            this.exportFont.Click += new System.EventHandler(this.ExportFont_Click);
            // 
            // importFont
            // 
            this.importFont.Location = new System.Drawing.Point(8, 376);
            this.importFont.Name = "importFont";
            this.importFont.Size = new System.Drawing.Size(113, 27);
            this.importFont.TabIndex = 4;
            this.importFont.Text = "Import Settings";
            this.importFont.UseVisualStyleBackColor = true;
            this.importFont.Click += new System.EventHandler(this.ImportFont_Click);
            // 
            // outlineSlider
            // 
            this.outlineSlider.DecimalPlaces = 2;
            this.outlineSlider.Location = new System.Drawing.Point(178, 42);
            this.outlineSlider.Name = "outlineSlider";
            this.outlineSlider.NumericUpDownMaximum = 100F;
            this.outlineSlider.NumericUpDownMinimum = 0F;
            this.outlineSlider.Size = new System.Drawing.Size(166, 28);
            this.outlineSlider.TabIndex = 0;
            this.outlineSlider.TickFrequency = 5;
            this.outlineSlider.TrackBarMaximum = 50;
            this.outlineSlider.Value = 0F;
            this.outlineSlider.ValueChanged += new SupercowFontEditor.SliderNumericUpDown.ValueChangedHandler(this.OutlineSlider_Changed);
            // 
            // fontPicker
            // 
            this.fontPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.fontPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontPicker.FormattingEnabled = true;
            this.fontPicker.IntegralHeight = false;
            this.fontPicker.Items.AddRange(new object[] { "Arial" });
            this.fontPicker.Location = new System.Drawing.Point(8, 14);
            this.fontPicker.MaxDropDownItems = 20;
            this.fontPicker.Name = "fontPicker";
            this.fontPicker.Size = new System.Drawing.Size(121, 21);
            this.fontPicker.TabIndex = 0;
            this.fontPicker.SelectedIndexChanged += new System.EventHandler(this.FontPicker_IndexSelected);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 411);
            this.Controls.Add(this.importFont);
            this.Controls.Add(this.exportFont);
            this.Controls.Add(this.tilemapGroup);
            this.Controls.Add(this.exportImage);
            this.Controls.Add(this.previewGroup);
            this.Controls.Add(this.fontGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = $"Supercow {"Font".EblanRnd()} Editor";
            this.fontGroup.ResumeLayout(false);
            this.previewGroup.ResumeLayout(false);
            this.previewScroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.tilemapGroup.ResumeLayout(false);
            this.tilemapGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glyphsPRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.CheckBox underline;
        private System.Windows.Forms.CheckBox strikeout;
        private System.Windows.Forms.GroupBox fontGroup;
        private System.Windows.Forms.GroupBox previewGroup;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.GroupBox tilemapGroup;
        private System.Windows.Forms.Button fontColor;
        private System.Windows.Forms.Button outlineColor;
        private System.Windows.Forms.Label outlineColorLabel;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Label outlineSizeLabel;
        private SliderNumericUpDown outlineSlider;
        private FontComboBox fontPicker;
        private TextBox addCharText;
        private Button exportImage;
        private NumericUpDown imageSize;
        private Label glyphsPRowLabel;
        private NumericUpDown glyphsPRow;
        private Label imageSizeLabel;
        private ListView charsList;
        private ColumnHeader glyph;
        private Button removeAll;
        private Button removeChar;
        private Button addChar;
        private Button exportFont;
        private Button importFont;
        private Panel previewScroll;
        private TrackBar zoomSlider;
        private Label zoomLabel;
    }
}