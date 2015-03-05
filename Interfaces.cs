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
using System.Collections;
using System.Collections.Generic;

namespace IGE.Logistics {
	/// <summary>
	/// An object that contains location information.
	/// </summary>
	public interface ILocation {
	}
	
	/// <summary>
	/// An object that contains object's size information.
	/// </summary>
	public interface ISize {
	}
	
	/// <summary>
	/// An object that contains information on how to go from point A to point B (ILocation).
	/// </summary>
	public interface IPath {
		ILocation GetNextLocation(ILocation currentLocation);
	}
	
	/// <summary>
	/// An object that contains information and methods for finding path between point A and point B.
	/// </summary>
	public interface IPathFinder {
		IPath FindPath(ILocation a, ILocation b, ISize objectSize);
	}
	
	/// <summary>
	/// Represents an object in the logistics system.
	/// </summary>
	public interface ILogisticsObject {
		LogisticsSystem Logistics { get; set; }
		ILocation Location { get; set; }
		ISize Size { get; set; }
	}
	
	public interface ILogisticsResource : ILogisticsObject {
		int MaxStack { get; }
	}
	
	public interface ILogisticsStorage : ILogisticsResource {
		IEnumerator<ILogisticsResourceStack> EnumerateInventory();
	}
	
	public interface ILogisticsResourceStack {
		ILogisticsResource Resource { get; set; }
		int Amount { get; set; }
	}
	
	public interface ILogisticsTool : ILogisticsResource {
	}
	
	public interface ILogisticsWorker : ILogisticsObject {
	}
	
	/// <summary>
	/// Defines what must be done to achieve some result.
	/// </summary>
	public interface IJob {
	}
	
	/// <summary>
	/// Contains information on who and what must do
	/// </summary>
	public interface ITask {
	}
}
