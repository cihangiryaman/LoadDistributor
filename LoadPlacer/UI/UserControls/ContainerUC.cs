using CromulentBisgetti.ContainerPacking.Entities;
using LoadPlacer.Data.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadPlacer.UI.Forms
{
    public partial class ContainerUC : UserControl
	{
		public ContainerUC()
		{
			InitializeComponent();
		}

		public List<Item> Items { get; set; }

		private void ContainerUC_Paint(object sender, PaintEventArgs e)
		{
			short index = 0;
			Brush[] brushes = [Brushes.Red, Brushes.LimeGreen, Brushes.Orange, Brushes.AliceBlue, Brushes.DarkGreen];
			foreach (Item item in Items)
			{
				GraphicsPath path = new GraphicsPath();
				Rectangle rectangle = new Rectangle(Convert.ToInt32(item.PackDimX), Convert.ToInt32(item.PackDimY), Convert.ToInt32(item.Dim1), Convert.ToInt32(item.Dim2));
				path.AddRectangle(rectangle);
				Region region = new Region(path);
				Graphics graphics = e.Graphics;
				try
				{
					graphics.FillRegion(brushes[index], region);
					index++;
				}
				catch(IndexOutOfRangeException ex)
				{
					index = 0;
				}
			}
		}
	}
}
