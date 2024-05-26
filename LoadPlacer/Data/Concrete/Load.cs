using LoadPlacer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadPlacer.Data.Concrete
{
	public class Load : ILoad
	{
        public int Id { get; set; }
        public string Name { get; set; } = "Paletli Yük";
		public short Width { get; set; }
		public short Height { get; set; }
		public short Length { get; set; }
		public bool IsTough { get; set; }
        public float? LDM { get; set; }
		public short XPoint { get; set; }
		public short YPoint { get; set; }
		public short ZPoint { get; set; }
	}
}
