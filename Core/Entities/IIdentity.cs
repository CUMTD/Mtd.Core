﻿namespace Mtd.Core.Entities
{
	/// <summary>
	/// The identity of an entity.
	/// </summary>
	/// <typeparam name="T">
	/// The type of the identity.
	/// </typeparam>
	public interface IIdentity<T> : IEntity
		where T : notnull, IComparable<T>
	{
		/// <summary>
		/// The identity.
		/// </summary>
		T Id { get; set; }
	}
}
