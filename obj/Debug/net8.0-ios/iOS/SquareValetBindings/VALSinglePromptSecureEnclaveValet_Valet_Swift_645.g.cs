//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace SquareValetBindings {
	public unsafe static partial class VALSinglePromptSecureEnclaveValet_Valet_Swift_645  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VALSinglePromptSecureEnclaveValet");
		[Export ("containsObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ContainsObjectForKey (this VALSinglePromptSecureEnclaveValet This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("containsObjectForKey:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALSinglePromptSecureEnclaveValet? SharedGroupValetWithAppIDPrefix (this VALSinglePromptSecureEnclaveValet This, string appIDPrefix, string identifier, VALSecureEnclaveAccessControl accessControl)
		{
			if (appIDPrefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appIDPrefix));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsappIDPrefix = CFString.CreateNative (appIDPrefix);
			var nsidentifier = CFString.CreateNative (identifier);
			VALSinglePromptSecureEnclaveValet? ret;
			ret =  Runtime.GetNSObject<VALSinglePromptSecureEnclaveValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessControl:"), nsappIDPrefix, nsidentifier, (IntPtr) (long) accessControl))!;
			CFString.ReleaseNative (nsappIDPrefix);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALSinglePromptSecureEnclaveValet? SharedGroupValetWithGroupPrefix (this VALSinglePromptSecureEnclaveValet This, string groupPrefix, string identifier, VALSecureEnclaveAccessControl accessControl)
		{
			if (groupPrefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groupPrefix));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsgroupPrefix = CFString.CreateNative (groupPrefix);
			var nsidentifier = CFString.CreateNative (identifier);
			VALSinglePromptSecureEnclaveValet? ret;
			ret =  Runtime.GetNSObject<VALSinglePromptSecureEnclaveValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessControl:"), nsgroupPrefix, nsidentifier, (IntPtr) (long) accessControl))!;
			CFString.ReleaseNative (nsgroupPrefix);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("valetWithIdentifier:accessControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALSinglePromptSecureEnclaveValet? ValetWithIdentifier (this VALSinglePromptSecureEnclaveValet This, string identifier, VALSecureEnclaveAccessControl accessControl)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			VALSinglePromptSecureEnclaveValet? ret;
			ret =  Runtime.GetNSObject<VALSinglePromptSecureEnclaveValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("valetWithIdentifier:accessControl:"), nsidentifier, (IntPtr) (long) accessControl))!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
	} /* class VALSinglePromptSecureEnclaveValet_Valet_Swift_645 */
}
