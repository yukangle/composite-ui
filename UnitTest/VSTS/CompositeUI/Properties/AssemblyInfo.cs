//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
#if DEBUG
[assembly : AssemblyConfiguration("Debug")]
#else
[
assembly
:
AssemblyConfiguration
(
"Release"
)
]
#endif

[assembly : AssemblyTitle("Microsoft.Practices.CompositeUI.Tests")]
[assembly : AssemblyDescription("Microsoft Composite UI Application Blocks: Unit Tests")]
[assembly : AssemblyCompany("Microsoft")]
[assembly : AssemblyCopyright("Copyright� Microsoft Corporation.  All rights reserved.")]
[assembly : AssemblyTrademark("")]
[assembly : AssemblyCulture("")]
[assembly : CLSCompliant(true)]
[assembly : ComVisible(false)]
