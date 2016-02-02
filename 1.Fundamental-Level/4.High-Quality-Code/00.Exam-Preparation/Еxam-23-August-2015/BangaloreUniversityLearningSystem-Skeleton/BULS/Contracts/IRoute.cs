namespace BULS.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// The route interface.
    /// </summary>
    public interface IRoute
    {
        /// <summary>
        /// Gets the controller name.
        /// </summary>
        string ControllerName { get; }

        /// <summary>
        /// Gets the action name.
        /// </summary>
        string ActionName { get; }

        /// <summary>
        /// Gets the parameters name.
        /// </summary>
        IDictionary<string, string> Parameters { get; }
    }
}