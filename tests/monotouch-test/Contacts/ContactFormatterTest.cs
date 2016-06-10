﻿//
// Unit tests for CNContactFormatter
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

#if !__TVOS__
#if XAMCORE_2_0 // The Contacts framework is Unified only

using System;
#if XAMCORE_2_0
using Contacts;
using Foundation;
using ObjCRuntime;
using UIKit;
#else
using MonoTouch.Contacts;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.Contacts {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class ContactFormatterTest {

		[SetUp]
		public void MinimumSdkCheck ()
		{
			if (!TestRuntime.CheckiOSSystemVersion (9,0))
				Assert.Inconclusive ("Requires 9.0+");
		}

		[Test]
		public void GetDescriptorForRequiredKeys_FullName ()
		{
			var keys = CNContactFormatter.GetDescriptorForRequiredKeys (CNContactFormatterStyle.FullName);
			// while most input for ICNKeyDescriptor are done with NSString
			// the output is opaque and an internal type
			// note: this is not very robust - but I want to know if this changes during the next betas
			Assert.True (keys.Description.StartsWith ("<CNAggregateKeyDescriptor:", StringComparison.Ordinal), "type");
			Assert.True (keys.Description.Contains ("kind=Formatter style: 0"), "kind");
		}

		[Test]
		public void GetDescriptorForRequiredKeys_PhoneticFullName ()
		{
			var keys = CNContactFormatter.GetDescriptorForRequiredKeys (CNContactFormatterStyle.PhoneticFullName);
			// while most input for ICNKeyDescriptor are done with NSString
			// the output is opaque and an internal type
			// note: this is not very robust - but I want to know if this changes during the next betas
			Assert.True (keys.Description.StartsWith ("<CNAggregateKeyDescriptor:", StringComparison.Ordinal), "type");
			Assert.True (keys.Description.Contains ("kind=Formatter style: 1"), "kind");
		}
	}
}

#endif // XAMCORE_2_0
#endif // !__TVOS__
