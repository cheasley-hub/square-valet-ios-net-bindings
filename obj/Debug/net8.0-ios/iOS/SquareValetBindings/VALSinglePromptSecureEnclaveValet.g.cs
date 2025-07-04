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
	[Register("VALSinglePromptSecureEnclaveValet", true)]
	public unsafe partial class VALSinglePromptSecureEnclaveValet : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VALSinglePromptSecureEnclaveValet");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, initWithFrame, frame);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected VALSinglePromptSecureEnclaveValet (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal VALSinglePromptSecureEnclaveValet (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("allKeysWithUserPrompt:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSSet<NSString>? AllKeysWithUserPrompt (string userPrompt, out NSError? error)
		{
			if (userPrompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userPrompt));
			NativeHandle errorValue = IntPtr.Zero;
			var nsuserPrompt = CFString.CreateNative (userPrompt);
			NSSet<NSString>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("allKeysWithUserPrompt:error:"), nsuserPrompt, &errorValue))!;
			} else {
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("allKeysWithUserPrompt:error:"), nsuserPrompt, &errorValue))!;
			}
			CFString.ReleaseNative (nsuserPrompt);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("migrateObjectsFrom:removeOnCompletion:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MigrateObjectsFrom (VALValet valet, bool removeOnCompletion, out NSError? error)
		{
			var valet__handle__ = valet!.GetNonNullHandle (nameof (valet));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, Selector.GetHandle ("migrateObjectsFrom:removeOnCompletion:error:"), valet__handle__, removeOnCompletion ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("migrateObjectsFrom:removeOnCompletion:error:"), valet__handle__, removeOnCompletion ? (byte) 1 : (byte) 0, &errorValue);
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("migrateObjectsMatching:removeOnCompletion:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MigrateObjectsMatching (NSDictionary<NSString, NSObject> query, bool removeOnCompletion, out NSError? error)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, Selector.GetHandle ("migrateObjectsMatching:removeOnCompletion:error:"), query__handle__, removeOnCompletion ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("migrateObjectsMatching:removeOnCompletion:error:"), query__handle__, removeOnCompletion ? (byte) 1 : (byte) 0, &errorValue);
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("objectForKey:withPrompt:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? ObjectForKey (string key, string userPrompt, out NSError? error)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (userPrompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userPrompt));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			var nsuserPrompt = CFString.CreateNative (userPrompt);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("objectForKey:withPrompt:error:"), nskey, nsuserPrompt, &errorValue))!;
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("objectForKey:withPrompt:error:"), nskey, nsuserPrompt, &errorValue))!;
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsuserPrompt);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("removeAllObjectsAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RemoveAllObjectsAndReturnError (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("removeAllObjectsAndReturnError:"), &errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("removeAllObjectsAndReturnError:"), &errorValue);
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("removeObjectForKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RemoveObjectForKey (string key, out NSError? error)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("removeObjectForKey:error:"), nskey, &errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("removeObjectForKey:error:"), nskey, &errorValue);
			}
			CFString.ReleaseNative (nskey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("requirePromptOnNextAccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequirePromptOnNextAccess ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requirePromptOnNextAccess"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requirePromptOnNextAccess"));
			}
		}
		[Export ("setObject:forKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetObject (NSData @object, string key, out NSError? error)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("setObject:forKey:error:"), @object__handle__, nskey, &errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("setObject:forKey:error:"), @object__handle__, nskey, &errorValue);
			}
			CFString.ReleaseNative (nskey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setString:forKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetString (string @string, string key, out NSError? error)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			var nsstring = CFString.CreateNative (@string);
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("setString:forKey:error:"), nsstring, nskey, &errorValue);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("setString:forKey:error:"), nsstring, nskey, &errorValue);
			}
			CFString.ReleaseNative (nsstring);
			CFString.ReleaseNative (nskey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("stringForKey:withPrompt:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string? StringForKey (string key, string userPrompt, out NSError? error)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (userPrompt is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userPrompt));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			var nsuserPrompt = CFString.CreateNative (userPrompt);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("stringForKey:withPrompt:error:"), nskey, nsuserPrompt, &errorValue))!;
			} else {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("stringForKey:withPrompt:error:"), nskey, nsuserPrompt, &errorValue))!;
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsuserPrompt);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VALSecureEnclaveAccessControl AccessControl {
			[Export ("accessControl")]
			get {
				VALSecureEnclaveAccessControl ret;
				if (IsDirectBinding) {
					ret = (SquareValetBindings.VALSecureEnclaveAccessControl) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessControl"));
				} else {
					ret = (SquareValetBindings.VALSecureEnclaveAccessControl) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessControl"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAccessKeychain {
			[Export ("canAccessKeychain")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canAccessKeychain"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canAccessKeychain"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Hash {
			[Export ("hash")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hash"));
				} else {
					return global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hash"));
				}
			}
		}
	} /* class VALSinglePromptSecureEnclaveValet */
}
