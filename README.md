# Microsoft SqlClient Data Provider for SQL Server

## What is Microsoft.Data.SqlClient?

Microsoft.Data.SqlClient is a data provider for Microsoft Sql Server. Currently in preview, it is a union of the two System.Data.SqlClient components which live independently in .NET Framework and .NET Core. Going forward, support for new SQL Server features will be implemented in Microsoft.Data.SqlClient.

The Microsoft.Data.SqlClient package supports .NET Framework 4.6+, .NET Core 2.1+, and .NET Standard 2.0+.

The current preview of this library has been released under a proprietary, closed source license. When the code is migrated to this repository, future releases from that code will be released under the MIT license.

## Known issues

1. When targeting **.NET Framework** and platform **AnyCPU**, you may see a build warning about processor architecture mismatch:

   *Warning	There was a mismatch between the processor architecture of the project being built "MSIL" and the processor architecture of the reference "Microsoft.Data.SqlClient*...

   This is because Microsoft.Data.SqlClient targeting Framework contains a native code component and native components cannot target AnyCPU. To resolve the issue, change your application to target x86 or x64.

# Code of conduct

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
