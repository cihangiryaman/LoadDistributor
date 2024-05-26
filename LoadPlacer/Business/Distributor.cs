using CromulentBisgetti.ContainerPacking;
using CromulentBisgetti.ContainerPacking.Algorithms;
using CromulentBisgetti.ContainerPacking.Entities;
using LoadPlacer.Data.Abstract;
using LoadPlacer.Data.Concrete;
using System.Collections.Generic;

namespace LoadPlacer.Business
{
	public class Distributor
	{		
		public List<ContainerPackingResult> PlaceToMultiple(List<Item> items, Container container, short containerCount)
		{
			List<Container> containers = new List<Container>();
			for (int i = 0; i < containerCount; i++)
			{
				container.ID = i;
				containers.Add(container);
			}
			List<int> algorithms = [(int)AlgorithmType.EB_AFIT];

			List<ContainerPackingResult> result = PackingService.Pack(containers, items, algorithms);
			return result;
		}

		public List<Item> PlaceToSingle(List<Item> items, Container container)
		{
			List<Container> containers = [container];
			List<int> algorithms = [(int)AlgorithmType.EB_AFIT];
			PackingService.Pack(containers, items, algorithms);
			return items;
		}
	}
}
