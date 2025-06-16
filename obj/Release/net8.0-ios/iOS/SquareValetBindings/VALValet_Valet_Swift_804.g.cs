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
	public unsafe static partial class VALValet_Valet_Swift_804  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VALValet");
		[Export ("containsObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ContainsObjectForKey (this VALValet This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("containsObjectForKey:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("iCloudValetWithAppIDPrefix:sharedGroupIdentifier:accessibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALValet? ICloudValetWithAppIDPrefix (this VALValet This, string appIDPrefix, string identifier, VALCloudAccessibility accessibility)
		{
			if (appIDPrefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appIDPrefix));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsappIDPrefix = CFString.CreateNative (appIDPrefix);
			var nsidentifier = CFString.CreateNative (identifier);
			VALValet? ret;
			ret =  Runtime.GetNSObject<VALValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("iCloudValetWithAppIDPrefix:sharedGroupIdentifier:accessibility:"), nsappIDPrefix, nsidentifier, (IntPtr) (long) accessibility))!;
			CFString.ReleaseNative (nsappIDPrefix);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("iCloudValetWithGroupPrefix:sharedGroupIdentifier:accessibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALValet? ICloudValetWithGroupPrefix (this VALValet This, string groupPrefix, string identifier, VALCloudAccessibility accessibility)
		{
			if (groupPrefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groupPrefix));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsgroupPrefix = CFString.CreateNative (groupPrefix);
			var nsidentifier = CFString.CreateNative (identifier);
			VALValet? ret;
			ret =  Runtime.GetNSObject<VALValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("iCloudValetWithGroupPrefix:sharedGroupIdentifier:accessibility:"), nsgroupPrefix, nsidentifier, (IntPtr) (long) accessibility))!;
			CFString.ReleaseNative (nsgroupPrefix);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("iCloudValetWithIdentifier:accessibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALValet? ICloudValetWithIdentifier (this VALValet This, string identifier, VALCloudAccessibility accessibility)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			VALValet? ret;
			ret =  Runtime.GetNSObject<VALValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("iCloudValetWithIdentifier:accessibility:"), nsidentifier, (IntPtr) (long) accessibility))!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("migrateObjectsFrom:compactMap:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool MigrateObjectsFrom (this VALValet This, VALValet valet, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<VALMigratableKeyValuePairInput, VALMigratableKeyValuePairOutput> compactMap, out NSError? error)
		{
			var valet__handle__ = valet!.GetNonNullHandle (nameof (valet));
			if (compactMap is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (compactMap));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_compactMap = Trampolines.SDFuncArity2V0.CreateBlock (compactMap);
			BlockLiteral *block_ptr_compactMap = &block_compactMap;
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("migrateObjectsFrom:compactMap:error:"), valet__handle__, (IntPtr) block_ptr_compactMap, &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("migrateObjectsMatching:compactMap:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool MigrateObjectsMatching (this VALValet This, NSDictionary<NSString, NSObject> query, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<VALMigratableKeyValuePairInput, VALMigratableKeyValuePairOutput> compactMap, out NSError? error)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (compactMap is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (compactMap));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_compactMap = Trampolines.SDFuncArity2V0.CreateBlock (compactMap);
			BlockLiteral *block_ptr_compactMap = &block_compactMap;
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("migrateObjectsMatching:compactMap:error:"), query__handle__, (IntPtr) block_ptr_compactMap, &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALValet? SharedGroupValetWithAppIDPrefix (this VALValet This, string appIDPrefix, string identifier, VALAccessibility accessibility)
		{
			if (appIDPrefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appIDPrefix));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsappIDPrefix = CFString.CreateNative (appIDPrefix);
			var nsidentifier = CFString.CreateNative (identifier);
			VALValet? ret;
			ret =  Runtime.GetNSObject<VALValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessibility:"), nsappIDPrefix, nsidentifier, (IntPtr) (long) accessibility))!;
			CFString.ReleaseNative (nsappIDPrefix);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALValet? SharedGroupValetWithGroupPrefix (this VALValet This, string groupPrefix, string identifier, VALAccessibility accessibility)
		{
			if (groupPrefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groupPrefix));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsgroupPrefix = CFString.CreateNative (groupPrefix);
			var nsidentifier = CFString.CreateNative (identifier);
			VALValet? ret;
			ret =  Runtime.GetNSObject<VALValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessibility:"), nsgroupPrefix, nsidentifier, (IntPtr) (long) accessibility))!;
			CFString.ReleaseNative (nsgroupPrefix);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("valetWithIdentifier:accessibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VALValet? ValetWithIdentifier (this VALValet This, string identifier, VALAccessibility accessibility)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			VALValet? ret;
			ret =  Runtime.GetNSObject<VALValet> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("valetWithIdentifier:accessibility:"), nsidentifier, (IntPtr) (long) accessibility))!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
	} /* class VALValet_Valet_Swift_804 */
}
