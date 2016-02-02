namespace BULS.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// The repository interface
    /// </summary>
    /// <typeparam name="T">Type of the item</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Gets all elements
        /// </summary>
        /// <returns>All elements</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Gets a course by ID
        /// </summary>
        /// <param name="id">The ID of the course</param>
        /// <returns>The course</returns>
        T Get(int id);

        /// <summary>
        /// Adds a course to the repository
        /// </summary>
        /// <param name="item">The course to be added</param>
        void Add(T item);
    }
}