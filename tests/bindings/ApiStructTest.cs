//
// ApiStructTest.cs: enforce structure definitions
//
// Authors:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2013 Xamarin, Inc.

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using NUnit.Framework;

#if XAMCORE_2_0
using ObjCRuntime;
using Foundation;
#elif MONOMAC
using MonoMac.ObjCRuntime;
using MonoMac.Foundation;
#else
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
#endif

namespace TouchUnit.Bindings
{
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class ApiStructTest : ApiBaseTest
	{
		public ApiStructTest ()
		{
			ContinueOnFailure = true;
			LogProgress = true;
		}

		protected virtual bool Skip (Type type)
		{
			return SkipDueToAttribute (type);
		}

		[Test]
		public void Structs ()
		{
			int totalStructs = 0;
			int totalErrors = 0;

			var structQuery = from type in Assembly.GetTypes ()
				where type.IsValueType && !type.IsPrimitive && !type.IsEnum && !Skip (type)
				select type;

			foreach (var type in structQuery) {
				totalStructs++;
				if (!CheckStruct (type)) {
					totalErrors++;

					if (!ContinueOnFailure)
						break;
				}
			}

			Assert.AreEqual (0, totalErrors,
				"{0} errors found in {1} structures validated",
				totalErrors, totalStructs);
		}

		protected virtual bool CheckStruct (Type type)
		{
			var success = true;

			foreach (var fi in type.GetFields ()) {
				if (!CheckField (type, fi))
					success = false;
			}

			return success;
		}

		protected virtual bool CheckField (Type type, FieldInfo fi)
		{
#if XAMCORE_2_0
			if (fi.FieldType.IsEnum && fi.FieldType.GetCustomAttribute<NativeAttribute> () != null) {
				if (LogProgress)
					Console.Error.WriteLine ("{0} has a [Native] enum field in its definition: {1} {2}",
						type.FullName, fi.FieldType, fi.Name);
				return false;
			}
#endif
			return true;
		}
	}
}

