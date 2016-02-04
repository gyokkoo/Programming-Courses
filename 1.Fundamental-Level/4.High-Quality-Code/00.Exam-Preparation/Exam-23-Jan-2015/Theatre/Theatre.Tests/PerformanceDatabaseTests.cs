namespace Theatre.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Theatre.Data;
    using Theatre.Exceptions;

    [TestClass]
    public class PerformanceDatabaseTests
    {
        [TestMethod]
        public void ListTheatres_EmptyDatabase_ShouldReturnEmptyCollection()
        {
            var database = new PerformanceDatabase();
            var exptected = new List<string>();

            var result = database.ListTheatres();

            Assert.AreEqual(exptected.Count, result.Count());
        }

        [TestMethod]
        public void ListTheatres_NonEmptyDatabase_ShouldReturnCorrectTheatrers()
        {
            var database = new PerformanceDatabase();
            database.AddTheatre("Theatre 1");
            database.AddTheatre("Theatre 2");
            database.AddTheatre("Theatre 3");

            var exptected = new[] { "Theatre 1", "Theatre 2", "Theatre 3" };

            var result = (ICollection)database.ListTheatres();

            CollectionAssert.AreEqual(exptected, result);
        }

        [TestMethod]
        public void ListTheatres_NonEmptyDatabase_ShouldReturntCorrectTheatresCount()
        {
            const int Count = 100;

            var database = new PerformanceDatabase();
            for (int i = 0; i < Count; i++)
            {
                database.AddTheatre($"Theatre {i}");
            }

            var result = database.ListTheatres();

            Assert.AreEqual(Count, result.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(TheatreNotFoundException))]
        public void AddPerformance_NonExistingTheatre_ShouldThrow()
        {
            var database = new PerformanceDatabase();

            database.AddPerformance("Sofiq", "Vecher", DateTime.Now, TimeSpan.Parse("3600"), 10m);
        }

        [TestMethod]
        [ExpectedException(typeof(TimeDurationOverlapException))]
        public void AddPerformance_ExistingOverlapTheatre_ShouldThrow()
        {
            var database = new PerformanceDatabase();

            database.AddTheatre("Sofiq");
            database.AddPerformance("Sofiq", "Vecher", DateTime.Now, TimeSpan.Parse("3600"), 10m);

            database.AddPerformance("Sofiq", "Vecher", DateTime.Now, TimeSpan.Parse("36000"), 10m);
        }

        [TestMethod]
        public void AddPerformance_ExistingTheatres_ShouldAddCorrectPerformance()
        {
            const string TheatreName = "Sofiq";
            const string Performance = "Vecher";
            const decimal TicketPrice = 15.50m;

            DateTime startDate = new DateTime(2015, 2, 4, 8, 30, 0);
            TimeSpan duration = new TimeSpan(0, 2, 30, 00);

            var database = new PerformanceDatabase();

            database.AddTheatre(TheatreName);
            database.AddPerformance(TheatreName, Performance, startDate, duration, TicketPrice);

            var result = database.ListAllPerformances().First();

            Assert.AreEqual(TheatreName, result.TheatreName);
            Assert.AreEqual(Performance, result.Performances);
            Assert.AreEqual(startDate, result.StartDate);
            Assert.AreEqual(duration, result.Duration);
            Assert.AreEqual(TicketPrice, result.TicketPrice);
        }

        [TestMethod]
        [ExpectedException(typeof(TheatreNotFoundException))]
        public void ListPerformances_NonExistingTheatres_ShouldThrow()
        {
            var database = new PerformanceDatabase();

            database.ListPerformances("Sofiq");
        }

        [TestMethod]
        public void ListPerformances_ExistingTheatres_ShouldReturnCollection()
        {
            const string TheatreName = "Sofiq";
            const string Performance = "Vecher";
            const decimal TicketPrice = 15.50m;

            DateTime startDate = new DateTime(2015, 2, 4, 8, 30, 0);
            TimeSpan duration = new TimeSpan(0, 2, 30, 00);

            var database = new PerformanceDatabase();

            database.AddTheatre(TheatreName);
            database.AddPerformance(TheatreName, Performance, startDate, duration, TicketPrice);

            var result = database.ListPerformances(TheatreName).First();

            Assert.AreEqual(TheatreName, result.TheatreName);
            Assert.AreEqual(Performance, result.Performances);
            Assert.AreEqual(startDate, result.StartDate);
            Assert.AreEqual(duration, result.Duration);
            Assert.AreEqual(TicketPrice, result.TicketPrice);
        }
    }
}