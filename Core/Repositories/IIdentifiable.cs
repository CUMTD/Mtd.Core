using Mtd.Core.Entities;

namespace Mtd.Core.Repositories
{
	/// <summary>
	/// A repository for an itentifiable entity.
	/// </summary>
	/// <typeparam name="TIdentity">
	/// The type of the entitie's identity.
	/// </typeparam>
	/// <typeparam name="TEntity">
	/// The type of the entity.
	/// </typeparam>
	public interface IIdentifiable<in TIdentity, TEntity>
		where TIdentity : notnull, IComparable<TIdentity>
		where TEntity : class, IIdentity<TIdentity>
	{
		/// <summary>
		/// Get an item that matches the provided identity.
		/// </summary>
		/// <param name="identity">
		/// The identity of the item to get.
		/// </param>
		/// <returns>
		/// An item with the matching identity.
		/// </returns>
		/// <remarks>
		/// Throws an error if no matching identity is found.
		/// </remarks>
		TEntity GetByIdentity(TIdentity identity);

		/// <summary>
		/// Get an item that matches the provided identity.
		/// </summary>
		/// <param name="identity">
		/// The identity of the item to get.
		/// </param>
		/// <returns>
		/// An item with the matching identity.
		/// </returns>
		/// <remarks>
		/// Returns null if no item with the matching identity is found.
		/// </remarks>
		TEntity? GetByIdentityOrDefault(TIdentity identity);

		Task<TEntity> GetByIdentityAsync(TIdentity identity);

		Task<TEntity?> GetByIdentityOrDefaultAsync(TIdentity identity);
	}
}
