using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadPlacer.Data.Abstract
{
	public interface ILoad
	{
        int Id { get; set; }	
        string Name { get; set; }
		short Width { get; set; }
		short Height { get; set; }
		short Length { get; set; }
		bool IsTough { get; set; }
		float? LDM { get; set; }
		short XPoint { get; set; }
		short YPoint { get; set; }
		short ZPoint { get; set; }
	}
}
