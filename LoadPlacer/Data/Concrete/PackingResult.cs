using CromulentBisgetti.ContainerPacking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadPlacer.Data.Concrete
{
	public class PackingResult : ContainerPackingResult
	{
        public List<Item> PlacedItems { get; set; }
		public AlgorithmPackingResult AlgorithmPackingResult { get; set; }

		public PackingResult()
		{

		}

		public PackingResult(List<Item> items, AlgorithmPackingResult algorithmPackingResult)
        {
            PlacedItems = items;
			AlgorithmPackingResult = algorithmPackingResult;
        }
    }
}
