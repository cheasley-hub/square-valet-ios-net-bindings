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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput>))]
		unsafe internal delegate NativeHandle DFuncArity2V0 (IntPtr block, NativeHandle arg);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput>))]
			internal static unsafe NativeHandle Invoke (IntPtr block, NativeHandle arg) {
				var del = BlockLiteral.GetTarget<global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput>> (block);
				var retval = del ( Runtime.GetNSObject<SquareValetBindings.VALMigratableKeyValuePairInput> (arg)!);
				return retval.GetHandle ();
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDFuncArity2V0), nameof (Invoke));
			}
		} /* class SDFuncArity2V0 */
		internal sealed class NIDFuncArity2V0 : TrampolineBlockBase {
			DFuncArity2V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity2V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity2V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<global::SquareValetBindings.VALMigratableKeyValuePairInput, global::SquareValetBindings.VALMigratableKeyValuePairOutput>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity2V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe global::SquareValetBindings.VALMigratableKeyValuePairOutput Invoke (global::SquareValetBindings.VALMigratableKeyValuePairInput arg)
			{
				var arg__handle__ = arg.GetHandle ();
				var ret =  Runtime.GetNSObject<global::SquareValetBindings.VALMigratableKeyValuePairOutput> (invoker (BlockPointer, arg__handle__))!;
				return ret!;
			}
		} /* class NIDFuncArity2V0 */
	}
}
