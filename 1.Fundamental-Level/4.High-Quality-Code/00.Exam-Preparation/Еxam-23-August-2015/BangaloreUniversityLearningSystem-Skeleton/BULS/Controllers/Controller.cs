namespace BULS.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    using BULS.Models;
    using BULS.Utilities;

    using Contracts;

    public abstract class Controller
    {
        public bool HasCurrentUser
        {
            get
            {
                return this.CurrentUser != null;
            }
        }

        public User CurrentUser { get; protected set; }

        protected IBangaloreUniversityData Data { get; set; }

        protected IView View(object model)
        {
            string fullNamespace = this.GetType().Namespace;
            int firstSeparatorIndex = fullNamespace.IndexOf(".");
            string baseNamespace = fullNamespace.Substring(0, firstSeparatorIndex);

            string controllerName = this.GetType().Name.Replace("Controller", string.Empty);
            string actionName = new StackTrace()
                .GetFrame(1)
                .GetMethod().Name;

            string fullPath = string.Format(
                "{0}.Views.{1}.{2}", 
                baseNamespace, 
                controllerName, 
                actionName);

            var viewType = Assembly
                .GetExecutingAssembly()
                .GetType(fullPath);

            return Activator.CreateInstance(viewType, model) as IView;
        }

        protected void EnsureAuthorization(params Role[] roles)
        {
            if (!this.HasCurrentUser)
            {
                throw new ArgumentException(
                    "There is no currently logged in user.");
            }

            // BOTTLENECK: Removed unused foreach
            if (!roles.Any(role => this.CurrentUser.IsInRole(role)))
            {
                throw new DivideByZeroException("The current user is not authorized to perform this operation.");
            }
        }
    }
}