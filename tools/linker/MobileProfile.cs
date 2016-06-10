using System;
using System.Collections.Generic;

namespace Xamarin.Linker {

	public abstract class MobileProfile : BaseProfile {

		static readonly HashSet<string> Sdk = new HashSet<string> {
			"mscorlib",
			"System",
			"System.ComponentModel.Composition",
			"System.ComponentModel.DataAnnotations",
			"System.Core",
			"System.Data",
			"System.Data.Services.Client",
			"System.IO.Compression.FileSystem",
			"System.IO.Compression",
			"System.Json",
			"System.Net",
			"System.Net.Http",
			"System.Numerics",
			"System.Runtime.Serialization",
			"System.ServiceModel",
			"System.ServiceModel.Internals",
			"System.ServiceModel.Web",
			"System.Transactions",
			"System.Web.Services",
			"System.Windows",
			"System.Xml",
			"System.Xml.Linq",
			"System.Xml.Serialization",
			"Microsoft.CSharp",
			"Microsoft.VisualBasic",
			"Mono.CSharp",
			"Mono.Data.Tds",
			"Mono.Data.Sqlite",
			"Mono.Dynamic.Interpreter",
			"Mono.Security",
			"OpenTK",
			"OpenTK-1.0",
			// New TLS Code
			"Mono.Security.Providers.NewSystemSource",
			"Mono.Security.Providers.OldTls",
			"Mono.Security.Providers.NewTls",
			"Mono.Security.Providers.DotNet",
			// Facades assemblies (PCL)
			"Microsoft.Win32.Primitives",
			"Microsoft.Win32.Registry.AccessControl",
			"Microsoft.Win32.Registry",
			"System.AppContext",
			"System.Collections.Concurrent",
			"System.Collections.NonGeneric",
			"System.Collections.Specialized",
			"System.Collections",
			"System.ComponentModel.Annotations",
			"System.ComponentModel.EventBasedAsync",
			"System.ComponentModel.Primitives",
			"System.ComponentModel.TypeConverter",
			"System.ComponentModel",
			"System.Console",
			"System.Data.Common",
			"System.Data.SqlClient",
			"System.Diagnostics.Contracts",
			"System.Diagnostics.Debug",
			"System.Diagnostics.FileVersionInfo",
			"System.Diagnostics.Process",
			"System.Diagnostics.StackTrace",
			"System.Diagnostics.TextWriterTraceListener",
			"System.Diagnostics.Tools",
			"System.Diagnostics.TraceEvent",
			"System.Diagnostics.TraceSource",
			"System.Diagnostics.Tracing",
			"System.Dynamic.Runtime",
			"System.Globalization.Calendars",
			"System.Globalization.Extensions",
			"System.Globalization",
			"System.IO",
			"System.IO.Compression.ZipFile",
			"System.IO.FileSystem.AccessControl",
			"System.IO.FileSystem.DriveInfo",
			"System.IO.FileSystem.Primitives",
			"System.IO.FileSystem",
			"System.IO.IsolatedStorage",
			"System.IO.MemoryMappedFiles",
			"System.IO.UnmanagedMemoryStream",
			"System.Linq.Expressions",
			"System.Linq.Parallel",
			"System.Linq.Queryable",
			"System.Linq",
			"System.Net.AuthenticationManager",
			"System.Net.Cache",
			"System.Net.HttpListener",
			"System.Net.Mail",
			"System.Net.NameResolution",
			"System.Net.NetworkInformation",
			"System.Net.Primitives",
			"System.Net.Requests",
			"System.Net.Security",
			"System.Net.ServicePoint",
			"System.Net.Sockets",
			"System.Net.Utilities",
			"System.Net.WebHeaderCollection",
			"System.Net.WebSockets.Client",
			"System.Net.WebSockets",
			"System.ObjectModel",
			"System.Private.CoreLib.InteropServices",
			"System.Private.CoreLib.Threading",
			"System.Reflection.Extensions",
			"System.Reflection.Primitives",
			"System.Reflection.TypeExtensions",
			"System.Reflection",
			"System.Resources.ReaderWriter",
			"System.Resources.ResourceManager",
			"System.Runtime.CompilerServices.VisualC",
			"System.Runtime.Extensions",
			"System.Runtime.Handles",
			"System.Runtime.InteropServices",
			"System.Runtime.InteropServices.WindowsRuntime",
			"System.Runtime.Numerics",
			"System.Runtime.Serialization.Json",
			"System.Runtime.Serialization.Primitives",
			"System.Runtime.Serialization.Xml",
			"System.Runtime",
			"System.Security.AccessControl",
			"System.Security.Claims",
			"System.Security.Cryptography.DeriveBytes",
			"System.Security.Cryptography.Encoding",
			"System.Security.Cryptography.Encryption.Aes",
			"System.Security.Cryptography.Encryption.ECDiffieHellman",
			"System.Security.Cryptography.Encryption.ECDsa",
			"System.Security.Cryptography.Encryption",
			"System.Security.Cryptography.Hashing.Algorithms",
			"System.Security.Cryptography.Hashing",
			"System.Security.Cryptography.RSA",
			"System.Security.Cryptography.RandomNumberGenerator",
			"System.Security.Cryptography.X509Certificates",
			"System.Security.Principal.Windows",
			"System.Security.Principal",
			"System.Security.SecureString",
			"System.ServiceModel.Duplex",
			"System.ServiceModel.NetTcp",
			"System.ServiceModel.Http",
			"System.ServiceModel.Primitives",
			"System.ServiceModel.Security",
			"System.Text.Encoding.Extensions",
			"System.Text.Encoding",
			"System.Text.RegularExpressions",
			"System.Threading.AccessControl",
			"System.Threading.Overlapped",
			"System.Threading.Tasks.Parallel",
			"System.Threading.Tasks",
			"System.Threading.Thread",
			"System.Threading.ThreadPool",
			"System.Threading.Timer",
			"System.Threading",
			"System.Xml.ReaderWriter",
			"System.Xml.XDocument",
			"System.Xml.XPath.XDocument",
			"System.Xml.XPath",
			"System.Xml.XmlDocument",
			"System.Xml.XmlSerializer",
			"System.Xml.Xsl.Primitives",
		};

		protected override bool IsSdk (string assemblyName)
		{
			return Sdk.Contains (assemblyName);
		}
	}
}
