using System.Linq.Expressions;

namespace Mtd.Core.Repositories
{
	/// <summary>
	/// A repository for a readable entity.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity the repository holds.
	/// </typeparam>
	/// <typeparam name="T_Collection">
	/// The type of collection that should be returned by methods that return multiple results.
	/// </typeparam>
	public interface IReadable<T, T_Collection>
		where T : class
		where T_Collection : IEnumerable<T>
	{
		/// <summary>
		/// Determines whether all elements in the repository satisfy a condition.
		/// </summary>
		/// <param name="predicate">
		/// A function to test each element for a condition.
		/// </param>
		/// <returns>
		/// true if every element of the repository passes the test in the specified predicate, or if
		/// the repository is empty; otherwise, false.
		/// </returns>
		bool All(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Determines whether any element of a sequence satisfies a condition.
		/// </summary>
		/// <param name="predicate">
		/// A function to test each element for a condition.
		/// </param>
		/// <returns>
		/// true if any elements in the repository pass the test in the specified predicate;
		/// otherwise, false.
		/// </returns>
		bool Any(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Returns the first element in a sequence that satisfies a specified condition.
		/// </summary>
		/// <param name="predicate">
		/// A function to test each element for a condition.
		/// </param>
		/// <returns>
		/// default(T) if repository is empty or if no element passes the test specified by
		/// predicate; otherwise, the first element in the repository that passes the test specified
		/// by predicate.
		/// </returns>
		T First(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Returns the first element of the repository that satisfies a condition or a default value
		/// if no such element is found.
		/// </summary>
		/// <param name="predicate">
		/// A function to test each element for a condition.
		/// </param>
		/// <returns>
		/// The first element in the sequence that passes the test in the specified predicate function.
		/// </returns>
		T? FirstOrDefault(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

		/// <summary>
		/// Returns all items in the repository.
		/// </summary>
		/// <returns>
		/// All elements in the repository.
		/// </returns>
		T_Collection GetAll();

		/// <summary>
		/// Returns the only element of a sequence that satisfies a specified condition, and throws
		/// an exception if more than one such element exists.
		/// </summary>
		/// <param name="predicate">
		/// A function to test an element for a condition.
		/// </param>
		/// <returns>
		/// The single element of the input sequence that satisfies a condition.
		/// </returns>
		T Single(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Returns the only element of the repository that satisfies a specified condition or a
		/// default value if no such element exists; this method throws an exception if more than one
		/// element satisfies the condition.
		/// </summary>
		/// <param name="predicate">
		/// A function to test an element for a condition.
		/// </param>
		/// <returns>
		/// The single element of the repository that satisfies the condition, or default(T) if no
		/// such element is found.
		/// </returns>
		T? SingleOrDefault(Expression<Func<T, bool>> predicate);


		/// <summary>
		/// Filters the repository based on a predicate.
		/// </summary>
		/// <param name="predicate">
		/// A function to test each element for a condition.
		/// </param>
		/// <returns>
		/// An IEnumerable&lt;T&gt; that contains all elements from the repository that satisfy the condition.
		/// </returns>
		T_Collection Where(Expression<Func<T, bool>> predicate);
	}
}
