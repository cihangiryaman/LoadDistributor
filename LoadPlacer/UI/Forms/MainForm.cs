using CromulentBisgetti.ContainerPacking.Entities;
using LoadPlacer.Business;
using LoadPlacer.Data.Concrete;

namespace LoadPlacer.UI.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		List<Item> fakeItems = new List<Item>()
		{
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(4,60,25,20,1),
			new Item(6,50,20,20,1),
			new Item(4,60,25,20,1),
			new Item(6,50,20,20,1),
			new Item(4,60,25,20,1),
			new Item(6,50,20,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(0,40,30,15,1),
			new Item(0,40,30,15,1),
			new Item(0,40,30,15,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(4,60,25,20,1),
			new Item(6,50,20,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(0,40,30,15,1),
			new Item(4,60,25,20,1),
			new Item(6,50,20,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(3,60,25,20,1),
			new Item(0,40,30,15,1),
			new Item(0,40,30,15,1),
		};

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Container container = new Container(0, 280, 100, 100);
			Distributor distributor = new Distributor();
			List<Item> groupedItems = fakeItems.GroupBy(x => new { x.Dim1, x.Dim2, x.Dim3 })
								.Select(g => new Item(-1, g.Key.Dim1, g.Key.Dim2, g.Key.Dim3, g.Count()))
								.ToList();
			List<Item> placedItems = distributor.PlaceToSingle(groupedItems, container);
			for (int i = 0; i < groupedItems.Count; i++)
			{
				groupedItems[i].ID = i;
				textBox1.Text += placedItems[i].CoordX;
			}			
		}
	}
}
