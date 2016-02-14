﻿//------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs"
//  company="Scott Dorman"
//  library="Cadru">
//    Copyright (C) 2001-2014 Scott Dorman.
// </copyright>
//
// <license>
//    Licensed under the Microsoft Public License (Ms-PL) (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </license>
//------------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Cadru.TransientFaultHandling")]
[assembly: AssemblyDescription("Provides retry mechanisms to make your application more resilient to transient faults in both synchronous and asynchronous scenarios.")]

[assembly: AssemblyFileVersion("1.0.0")]
[assembly: AssemblyInformationalVersion("4.0.0-beta-27")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: CLSCompliant(true)]
[assembly: InternalsVisibleTo("Cadru.Core.UnitTests")]
[assembly: InternalsVisibleTo("Cadru.Core.Explorables")]

//// Setting ComVisible to false makes the types in this assembly not visible
//// to COM components.  If you need to access a type in this assembly from
//// COM, set the ComVisible attribute to true on that type.
//[assembly: ComVisible(false)]

//// The following GUID is for the ID of the typelib if this project is exposed to COM
//[assembly: Guid("669d8638-4f8a-46e3-846f-871366612348")]
