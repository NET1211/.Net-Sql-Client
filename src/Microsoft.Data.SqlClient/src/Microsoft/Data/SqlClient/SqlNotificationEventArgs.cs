// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.Data.SqlClient
{
    /// <include file='../../../../../../doc/snippets/Microsoft.Data.SqlClient/SqlNotificationEventArgs.xml' path='docs/members[@name="SqlNotificationEventArgs"]/SqlNotificationEventArgs/*' />
    public class SqlNotificationEventArgs : EventArgs
    {
        private readonly SqlNotificationType _type;
        private readonly SqlNotificationInfo _info;
        private readonly SqlNotificationSource _source;

        /// <include file='../../../../../../doc/snippets/Microsoft.Data.SqlClient/SqlNotificationEventArgs.xml' path='docs/members[@name="SqlNotificationEventArgs"]/ctor/*' />
        public SqlNotificationEventArgs(SqlNotificationType type, SqlNotificationInfo info, SqlNotificationSource source)
        {
            _info = info;
            _source = source;
            _type = type;
        }

        /// <include file='../../../../../../doc/snippets/Microsoft.Data.SqlClient/SqlNotificationEventArgs.xml' path='docs/members[@name="SqlNotificationEventArgs"]/Type/*' />
        public SqlNotificationType Type => _type;

        /// <include file='../../../../../../doc/snippets/Microsoft.Data.SqlClient/SqlNotificationEventArgs.xml' path='docs/members[@name="SqlNotificationEventArgs"]/Info/*' />
        public SqlNotificationInfo Info => _info;

        /// <include file='../../../../../../doc/snippets/Microsoft.Data.SqlClient/SqlNotificationEventArgs.xml' path='docs/members[@name="SqlNotificationEventArgs"]/Source/*' />
        public SqlNotificationSource Source => _source;

        internal static SqlNotificationEventArgs s_notifyError = new(SqlNotificationType.Subscribe, SqlNotificationInfo.Error, SqlNotificationSource.Object);
    }
}
