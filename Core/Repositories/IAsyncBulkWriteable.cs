namespace Mtd.Core.Repositories
{
	/// <summary>
	/// Interface for asynchronous bulk write operations.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	/// <typeparam name="T_Collection">The type of the collection of entities.</typeparam>
	public interface IAsyncBulkWriteable<T, T_Collection>
	{
		/// <summary>
		/// Asynchronously inserts a collection of entities.
		/// </summary>
		/// <param name="entities">The entities to insert.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task BulkInsertAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

		/// <summary>
		/// Asynchronously inserts or updates a collection of entities.
		/// </summary>
		/// <param name="entities">The entities to insert or update.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task BulkInsertOrUpdateAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

		/// <summary>
		/// Asynchronously inserts, updates, or deletes a collection of entities.
		/// </summary>
		/// <param name="entities">The entities to insert, update, or delete.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task BulkInsertOrUpdateOrDeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

		/// <summary>
		/// Asynchronously updates a collection of entities.
		/// </summary>
		/// <param name="entities">The entities to update.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task BulkUpdateAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

		/// <summary>
		/// Asynchronously deletes a collection of entities.
		/// </summary>
		/// <param name="entities">The entities to delete.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task BulkDeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

		/// <summary>
		/// Asynchronously saves changes made in bulk operations.
		/// </summary>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task BulkSaveChangesAsync(CancellationToken cancellationToken);

		/// <summary>
		/// Asynchronously truncates the collection of entities.
		/// </summary>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task TruncateAsync(CancellationToken cancellationToken);
	}
}
