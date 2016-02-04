namespace Theatre.Contracts
{
    using System;
    using System.Collections.Generic;

    using Theatre.Models;

    /// <summary>
    /// Performance database interface.
    /// </summary>
    public interface IPerformanceDatabase
    {
        /// <summary>
        /// Adds theatre name to the database.
        /// </summary>
        /// <param name="theatreName">The given theatre name.</param>
        void AddTheatre(string theatreName);

        /// <summary>
        /// Gets list of all theatre names from the database. 
        /// </summary>
        /// <returns>List of theatres</returns>
        IEnumerable<string> ListTheatres();

        /// <summary>
        /// Validates the theatre params and adds new performance to the database.
        /// </summary>
        /// <param name="theatreName">The theatre name.</param>
        /// <param name="performance">The performance title.</param>
        /// <param name="startDateTime">The start date.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="price">The ticket price.</param>
        void AddPerformance(
            string theatreName,
            string performance,
            DateTime startDateTime,
            TimeSpan duration,
            decimal price);

        /// <summary>
        /// Gets all performance from the all theatres in the database.
        /// </summary>
        /// <returns>List of all performance.</returns>
        IEnumerable<Performance> ListAllPerformances();

        /// <summary>
        /// Gets a list of performance by given theatre.
        /// </summary>
        /// <param name="theatreName">The theatre name.</param>
        /// <returns>List of performance.</returns>
        IEnumerable<Performance> ListPerformances(string theatreName);
    }
}