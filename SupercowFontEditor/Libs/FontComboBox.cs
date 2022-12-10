using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

public class FontComboBox : ComboBox
{
    Font nfont;
    int maxwid = 0;
	string item = "Arial";

    public FontComboBox()
	{
        MaxDropDownItems = 20;
		IntegralHeight = false;
		DropDownStyle = ComboBoxStyle.DropDownList;
		DrawMode = DrawMode.OwnerDrawVariable;
        Items.Add(item);
        SelectedItem = item;
    }

	public void Populate()
	{
		Items.Clear();
        using (InstalledFontCollection col = new InstalledFontCollection())
            foreach (FontFamily fa in col.Families)
				Items.Add(fa.Name);
		if(Items.Count > 0)
			SelectedItem = item;
	}

	protected override void OnMeasureItem(MeasureItemEventArgs e)
	{	
		if(e.Index > -1)
		{
			string fontstring = Items[e.Index].ToString();						
			Graphics g = CreateGraphics();
			e.ItemHeight = (int)g.MeasureString(fontstring, new Font(fontstring, 8.25f)).Height;
			int w = (int)g.MeasureString(fontstring, new Font(fontstring, 8.25f)).Width;
			if(w > maxwid)
				maxwid = w;
			if(e.ItemHeight > 20)
				e.ItemHeight = 20;
		}				
		base.OnMeasureItem(e);
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{	
		if(e.Index > -1)
		{
			string fontstring = Items[e.Index].ToString();
			nfont = new Font(fontstring, 8.25f);
			e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
			e.Graphics.DrawString(fontstring, nfont, new SolidBrush(SystemColors.WindowText), e.Bounds.X, e.Bounds.Y);
		}
		base.OnDrawItem(e);
	}
	protected override void OnSelectedIndexChanged(EventArgs e)
	{
        item = SelectedItem as string;
		base.OnSelectedIndexChanged(e);
	}

	protected override void OnDropDown(EventArgs e)
	{
		Populate();
		DropDownWidth = maxwid;
	}
}