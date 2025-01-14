namespace Mtd.Core.Entities
{
	/// <summary>
	/// Represents a transaction that can be committed or rolled back.
	/// </summary>
	public interface ITransaction : IDisposable
	{
		/// <summary>
		/// Gets the unique identifier for the transaction.
		/// </summary>
		Guid TransactionId { get; }

		/// <summary>
		/// Gets a value indicating whether the transaction supports save points.
		/// </summary>
		bool SupportsSavePoints { get; }

		/// <summary>
		/// Commit the transaction.
		/// </summary>
		/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
		/// <returns>A task that represents the asynchronous commit operation.</returns>
		Task CommitAsync(CancellationToken cancellationToken);

		/// <summary>
		/// Rollback the transaction.
		/// </summary>
		/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
		/// <returns>A task that represents the asynchronous rollback operation.</returns>
		Task RollbackAsync(CancellationToken cancellationToken);

		/// <summary>
		/// Creates a save point within the transaction.
		/// </summary>
		/// <param name="savePointName">The name of the save point.</param>
		/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
		/// <returns>A task that represents the asynchronous operation, containing the save point name.</returns>
		Task<string> CreateSavePointAsync(string savePointName, CancellationToken cancellationToken);

		/// <summary>
		/// Rolls back the transaction to a specified save point.
		/// </summary>
		/// <param name="savePointName">The name of the save point to roll back to.</param>
		/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
		/// <returns>A task that represents the asynchronous rollback operation, containing the save point name.</returns>
		Task<string> RollbackToSavePointAsync(string savePointName, CancellationToken cancellationToken);

		/// <summary>
		/// Releases a save point within the transaction.
		/// </summary>
		/// <param name="savePointName">The name of the save point to release.</param>
		/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
		/// <returns>A task that represents the asynchronous release operation.</returns>
		Task ReleaseSavePointAsync(string savePointName, CancellationToken cancellationToken);
	}
}
