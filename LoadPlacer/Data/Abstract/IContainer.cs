using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadPlacer.Data.Abstract
{
	public interface IContainer
	{
        short Length { get; set; }
        short Width { get; set; }
        short Height { get; set; }
    }
}
