﻿using Metalama.Framework.Fabrics;
using VtlSoftware.Aspects.Logging;

namespace VtlSoftware.Aspects.Logging.Tests.net6.AddControlledLoggingToAllClasses
{
    public class AddControlledLoggingToAllClassesTest
    {
    }

    public class Test1
    {
    }

    internal class Test2
    {
    }

    public class Configure : ProjectFabric
    {
        #region Public Methods
        public override void AmendProject(IProjectAmender amender) { amender.AddControlledLoggingToAllClasses(); }

        #endregion
    }
}
