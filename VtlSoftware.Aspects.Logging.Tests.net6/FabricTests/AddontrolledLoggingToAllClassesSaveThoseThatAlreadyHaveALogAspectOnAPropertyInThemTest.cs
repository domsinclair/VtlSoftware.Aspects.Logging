﻿using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging.Net6;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThem
{
    public class AddontrolledLoggingToAllClassesSaveThoseThatAlreadyHaveALogAspectOnAPropertyInThemTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    public class LogClass
    {
        #region Private Methods

        private string GetMyString() { return "Hi"; }

        #endregion

        #region Public Properties
        [Log]
        public string MyString { get; set; }

        #endregion
    }

    public class LogAnTimeClassClass
    {
        #region Private Methods
        private string GetMyString() { return "Hi"; }

        #endregion

        #region Public Properties
        [LogAndTime]
        public string MyString { get; set; }

        #endregion
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods

        public override void AmendProject(IProjectAmender amender) { amender.AddBasicLoggingToAllClasses(); }

        #endregion
    }
}
