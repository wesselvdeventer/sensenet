﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("SenseNet.Tests")]
[assembly: InternalsVisibleTo("SenseNet.Packaging.Tests")]
[assembly: InternalsVisibleTo("SenseNet.Packaging.IntegrationTests")]

#if DEBUG
[assembly: AssemblyTitle("SenseNet.Common (Debug)")]
#else
[assembly: AssemblyTitle("SenseNet.Common (Release)")]
#endif

[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Sense/Net Inc.")]
[assembly: AssemblyCopyright("Copyright © Sense/Net Inc.")]
[assembly: AssemblyProduct("sensenet")]
[assembly: AssemblyTrademark("Sense/Net Inc.")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("7.1.1.0")]
[assembly: AssemblyFileVersion("7.1.1.0")]
[assembly: AssemblyInformationalVersion("7.1.1")]
