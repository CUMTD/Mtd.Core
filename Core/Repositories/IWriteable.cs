namespace Mtd.Core.Repositories
{
	/// <summary>
	/// A repository for a writeable entity.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity the repository holds.
	/// </typeparam>
	public interface IWriteable<T> where T : class
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
		IEnumerable<T> AddRange(IEnumerable<T> entities);

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
		int CommitChanges();

		/// <summary>
		/// Write all changes to persistent storage.
		/// </summary>
		Task<int> CommitChangesAsync();
		Task<int> CommitChangesAsync(CancellationToken token);
	}
}
