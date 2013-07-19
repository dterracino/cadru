//------------------------------------------------------------------------------
// <copyright file="InternetInformationServicesFeature.cs" 
//  company="Scott Dorman" 
//  library="Cadru">
//    Copyright (C) 2001-2013 Scott Dorman.
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

namespace Cadru
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Specifies the Internet Information Services (IIS) features.
    /// </summary>
    /// <remarks>Features only apply to IIS versions 7 and later.</remarks>
    public enum InternetInformationServicesFeature
    {
        /// <summary>
        /// World Wide Web (WWW) service
        /// </summary>
        Webserver,

        /// <summary>
        /// File Transfer Protocol (FTP) Service
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FTP")]
        FTP,

        /// <summary>
        /// Application Initialization
        /// </summary>
        ApplicationInitialization,

        /// <summary>
        /// ASP
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ASP")]
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed.")]
        ASP,

        /// <summary>
        /// ASP.NET 3.5
        /// </summary>
        AspNet,

        /// <summary>
        /// ASP.NET 4.5
        /// </summary>
        AspNet45,

        /// <summary>
        /// CGI
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "CGI")]
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed.")]
        CGI,

        /// <summary>
        /// ISAPI Extensions
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ISAPI")]
        ISAPIExtensions,

        /// <summary>
        /// ISAPI Filters
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ISAPI")]
        ISAPIFilters,

        /// <summary>
        /// .NET Framework Extensibility 3.5
        /// </summary>
        NetFxExtensibility,

        /// <summary>
        /// .NET Framework Extensibility 4.5
        /// </summary>
        NetFxExtensibility45,

        /// <summary>
        /// Server-Side Includes
        /// </summary>
        ServerSideIncludes,

        /// <summary>
        /// WebSocket Protocol
        /// </summary>
        WebSockets,

        /// <summary>
        /// Default Document
        /// </summary>
        DefaultDocument,

        /// <summary>
        /// Directory Browsing
        /// </summary>
        DirectoryBrowsing,

        /// <summary>
        /// HTTP Errors
        /// </summary>
        HttpErrors,

        /// <summary>
        /// HTTP Redirection
        /// </summary>
        HttpRedirection,

        /// <summary>
        /// Static Content
        /// </summary>
        StaticContent,

        /// <summary>
        /// Web Distributed Authoring and Versioning (WebDAV) publishing
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DAV")]
        WebDAV,

        /// <summary>
        /// Custom Logging
        /// </summary>
        CustomLogging,

        /// <summary>
        /// HTTP Logging
        /// </summary>
        HttpLogging,

        /// <summary>
        /// Logging Tools
        /// </summary>
        LoggingTools,

        /// <summary>
        /// ODBC Logging
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ODBC")]
        ODBCLogging,

        /// <summary>
        /// Request Monitor
        /// </summary>
        RequestMonitor,

        /// <summary>
        /// Tracing
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1630:DocumentationTextMustContainWhitespace", Justification = "Reviewed.")]
        Tracing,

        /// <summary>
        /// Dynamic Content Compression
        /// </summary>
        DynamicContentCompression,

        /// <summary>
        /// Static Content Compression
        /// </summary>
        StaticContentCompression,

        /// <summary>
        /// URL Authorization
        /// </summary>
        Authorization,

        /// <summary>
        /// Basic Authentication
        /// </summary>
        BasicAuthentication,

        /// <summary>
        /// Centralized SSL Certificate Support
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL")]
        CentralizedSSLCertificateSupport,

        /// <summary>
        /// Client Certificate Mapping Authentication
        /// </summary>
        ClientCertificateMappingAuthentication,

        /// <summary>
        /// Digest Authentication
        /// </summary>
        DigestAuthentication,

        /// <summary>
        /// IIS Client Certificate Mapping Authentication
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "IIS")]
        IISCertificateMappingAuthentication,

        /// <summary>
        /// IP Security
        /// </summary>
        IPSecurity,

        /// <summary>
        /// Request filtering
        /// </summary>
        RequestFiltering,

        /// <summary>
        /// Windows Authentication
        /// </summary>
        WindowsAuthentication,

        /// <summary>
        /// IIS Management Console
        /// </summary>
        ManagementConsole,

        /// <summary>
        /// IIS Management Scripts and Tools
        /// </summary>
        ManagementScriptingTools,

        /// <summary>
        /// IIS Management Service
        /// </summary>
        ManagementService,

        /// <summary>
        /// IIS 6 Scripting Tools
        /// </summary>
        LegacyScripts,

        /// <summary>
        /// IIS 6 Management Console
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Snapin")]
        LegacySnapin,

        /// <summary>
        /// IIS <c>Metabase</c> and IIS 6 configuration compatibility
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Metabase")]
        MetabaseCompatibility,

        /// <summary>
        /// IIS 6 WMI Compatibility
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "WMI")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Compatability",
            Justification = "Reviewed.")]
        WMICompatability,

        /// <summary>
        /// FTP Extensibility
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FTP")]
        FTPExtensibility,
    }
}
