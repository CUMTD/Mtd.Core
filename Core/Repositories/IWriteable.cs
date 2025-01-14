using Mtd.Core.Entities;

namespace Mtd.Core.Repositories
{
	/// <summary>
	/// The type of entity the repository holds.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity the repository holds.
	/// </typeparam>
	/// <typeparam name="T_Collection">
	/// The type of collection that holds the entities.
	/// </typeparam>
	public interface IWriteable<T, T_Collection>
		where T : class
		where T_Collection : IEnumerable<T>
	{
		/// <summary>
		/// Add an entity to a repository.
		/// </summary>
		/// <param name="entity">
		/// The entity to add.
		/// </param>
		T Add(T entity);

		/// <summary>
		/// Add a collection of entities to a repository.
		/// </summary>
		/// <param name="entities">
		/// The entities to add.
		/// </param>
		T_Collection AddRange(IEnumerable<T> entities);

		/// <summary>
		/// Delete an entity from a repository.
		/// </summary>
		/// <param name="entity">
		/// The entity to delete.
		/// </param>
		void Delete(T entity);

		/// <summary>
		/// Write all changes to persistent storage.
		/// </summary>
		/// <returns>
		/// The number of changes committed.
		/// </returns>
		int CommitChanges();

		/// <summary>
		/// Create a new transaction.
		/// </summary>
		/// <returns>
		/// A new transaction instance.
		/// </returns>
		ITransaction CreateTransaction();
	}
}
