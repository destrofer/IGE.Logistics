/*
 * Author: Viacheslav Soroka
 * 
 * This file is part of IGE <https://github.com/destrofer/IGE>.
 * 
 * IGE is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * IGE is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License
 * along with IGE.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;

namespace IGE.Logistics {
	/// <summary>
	/// </summary>
	public class LogisticsSystem {
		/// <summary>
		/// List of all workers
		/// </summary>
		public HashSet<ILogisticsWorker> Workers;
		
		/// <summary>
		/// List of all workstations
		/// </summary>
		public HashSet<ILogisticsTool> Workstations;
		
		/// <summary>
		/// List of all storages
		/// </summary>
		public HashSet<ILogisticsStorage> Sotrages;

		/// <summary>
		/// List of all non-stored resources
		/// </summary>
		public HashSet<ILogisticsResourceStack> Resources;

		/*
		 * For now we won't use indexes until algorithms are perfected
		/// <summary>
		/// Index of workers that have a specific skill
		/// </summary>
		public Dictionary<ISkill, ILogisticsWorker> WorkersBySkill;
		
		/// <summary>
		/// Index of workstations on which a specific job can be done  
		/// </summary>
		public Dictionary<IJob, ILogisticsTool> WorkstationsByJob;
		
		/// <summary>
		/// Index of all storages that accept a specific resource
		/// </summary>
		public Dictionary<ILogisticsResource, ILogisticsStorage> AcceptingStoragesByResource;
		
		/// <summary>
		/// Index of all storages that contain a specific resource
		/// </summary>
		public Dictionary<ILogisticsResource, ILogisticsStorage> SupplyingStoragesByResource;
		*/
		
		
	}
}