namespace Mtd.Core.Repositories
{
	/// <summary>
	/// A repository for a writeable entity.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity the repository holds.
	/// </typeparam>
	public interface IAsyncWriteable<T, T_Collection>
		where T : class
		where T_Collection : IEnumerable<T>
	{
		/// <summary>
		/// Add an entity to a repository.
		/// </summary>
		/// <param name="entity">
		/// The entity to add.
		/// </param>
		Task<T> AddAsync(T entity, CancellationToken cancellationToken);

		/// <summary>
		/// Add a collection of entities to a repository.
		/// </summary>
		/// <param name="entities">
		/// The entities to add.
		/// </param>
		Task<T_Collection> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

		/// <summary>
		/// Delete an entity from a repository.
		/// </summary>
		/// <param name="entity">
		/// The entity to delete.
		/// </param>
		Task DeleteAsync(T entity, CancellationToken cancellationToken);

		/// <summary>
		/// Write all changes to persistent storage.
		/// </summary>
		/// <returns>
		/// The number of changes committed.
		/// </returns>
		Task<int> CommitChangesAsync(CancellationToken cancellationToken);
	}
}
