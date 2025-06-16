using System;
using Foundation;
using ObjCRuntime;

namespace SquareValetBindings
{
	// @interface VALMigratableKeyValuePairInput : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface VALMigratableKeyValuePairInput
	{
		// @property (readonly, nonatomic) id _Nonnull key;
		[Export ("key")]
		NSObject Key { get; }

		// @property (readonly, copy, nonatomic) NSData * _Nonnull value;
		[Export ("value", ArgumentSemantic.Copy)]
		NSData Value { get; }
	}

	// @interface VALMigratableKeyValuePairOutput : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface VALMigratableKeyValuePairOutput
	{
		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key value:(NSData * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithKey:value:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string key, NSData value);

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key stringValue:(NSString * _Nonnull)stringValue __attribute__((objc_designated_initializer));
		[Export ("initWithKey:stringValue:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string key, string stringValue);

		// +(VALMigratableKeyValuePairOutput * _Nonnull)preventMigration __attribute__((warn_unused_result("")));
		[Static]
		[Export ("preventMigration")]
		VALMigratableKeyValuePairOutput PreventMigration { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull key;
		[Export ("key")]
		string Key { get; }

		// @property (readonly, copy, nonatomic) NSData * _Nonnull value;
		[Export ("value", ArgumentSemantic.Copy)]
		NSData Value { get; }
	}

	// @interface VALSecureEnclaveValet : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface VALSecureEnclaveValet
	{
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, nonatomic) enum VALSecureEnclaveAccessControl accessControl;
		[Export ("accessControl")]
		VALSecureEnclaveAccessControl AccessControl { get; }

		// -(BOOL)canAccessKeychain __attribute__((warn_unused_result("")));
		[Export ("canAccessKeychain")]
		bool CanAccessKeychain { get; }

		// -(BOOL)setObject:(NSData * _Nonnull)object forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setObject:forKey:error:")]
		bool SetObject (NSData @object, string key, [NullAllowed] out NSError error);

		// -(NSData * _Nullable)objectForKey:(NSString * _Nonnull)key withPrompt:(NSString * _Nonnull)userPrompt error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("objectForKey:withPrompt:error:")]
		[return: NullAllowed]
		NSData ObjectForKey (string key, string userPrompt, [NullAllowed] out NSError error);

		// -(BOOL)setString:(NSString * _Nonnull)string forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setString:forKey:error:")]
		bool SetString (string @string, string key, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key withPrompt:(NSString * _Nonnull)userPrompt error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("stringForKey:withPrompt:error:")]
		[return: NullAllowed]
		string StringForKey (string key, string userPrompt, [NullAllowed] out NSError error);

		// -(BOOL)removeObjectForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("removeObjectForKey:error:")]
		bool RemoveObjectForKey (string key, [NullAllowed] out NSError error);

		// -(BOOL)removeAllObjectsAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("removeAllObjectsAndReturnError:")]
		bool RemoveAllObjectsAndReturnError ([NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsMatching:(NSDictionary<NSString *,NSObject *> * _Nonnull)query removeOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsMatching:removeOnCompletion:error:")]
		bool MigrateObjectsMatching (NSDictionary<NSString, NSObject> query, bool removeOnCompletion, [NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsFrom:(VALValet * _Nonnull)valet removeOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsFrom:removeOnCompletion:error:")]
		bool MigrateObjectsFrom (VALValet valet, bool removeOnCompletion, [NullAllowed] out NSError error);
	}

	// @interface Valet_Swift_501 (VALSecureEnclaveValet)
	[Category]
	[BaseType (typeof(VALSecureEnclaveValet))]
	interface VALSecureEnclaveValet_Valet_Swift_501
	{
		// +(VALSecureEnclaveValet * _Nullable)valetWithIdentifier:(NSString * _Nonnull)identifier accessControl:(enum VALSecureEnclaveAccessControl)accessControl __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valetWithIdentifier:accessControl:")]
		[return: NullAllowed]
		VALSecureEnclaveValet ValetWithIdentifier (string identifier, VALSecureEnclaveAccessControl accessControl);

		// +(VALSecureEnclaveValet * _Nullable)sharedGroupValetWithAppIDPrefix:(NSString * _Nonnull)appIDPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessControl:(enum VALSecureEnclaveAccessControl)accessControl __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessControl:")]
		[return: NullAllowed]
		VALSecureEnclaveValet SharedGroupValetWithAppIDPrefix (string appIDPrefix, string identifier, VALSecureEnclaveAccessControl accessControl);

		// +(VALSecureEnclaveValet * _Nullable)sharedGroupValetWithGroupPrefix:(NSString * _Nonnull)groupPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessControl:(enum VALSecureEnclaveAccessControl)accessControl __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessControl:")]
		[return: NullAllowed]
		VALSecureEnclaveValet SharedGroupValetWithGroupPrefix (string groupPrefix, string identifier, VALSecureEnclaveAccessControl accessControl);

		// -(BOOL)containsObjectForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("containsObjectForKey:")]
		bool ContainsObjectForKey (string key);
	}

	// @interface VALSinglePromptSecureEnclaveValet : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface VALSinglePromptSecureEnclaveValet
	{
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, nonatomic) enum VALSecureEnclaveAccessControl accessControl;
		[Export ("accessControl")]
		VALSecureEnclaveAccessControl AccessControl { get; }

		// -(BOOL)canAccessKeychain __attribute__((warn_unused_result("")));
		[Export ("canAccessKeychain")]
		bool CanAccessKeychain { get; }

		// -(BOOL)setObject:(NSData * _Nonnull)object forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setObject:forKey:error:")]
		bool SetObject (NSData @object, string key, [NullAllowed] out NSError error);

		// -(NSData * _Nullable)objectForKey:(NSString * _Nonnull)key withPrompt:(NSString * _Nonnull)userPrompt error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("objectForKey:withPrompt:error:")]
		[return: NullAllowed]
		NSData ObjectForKey (string key, string userPrompt, [NullAllowed] out NSError error);

		// -(BOOL)setString:(NSString * _Nonnull)string forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setString:forKey:error:")]
		bool SetString (string @string, string key, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key withPrompt:(NSString * _Nonnull)userPrompt error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("stringForKey:withPrompt:error:")]
		[return: NullAllowed]
		string StringForKey (string key, string userPrompt, [NullAllowed] out NSError error);

		// -(void)requirePromptOnNextAccess;
		[Export ("requirePromptOnNextAccess")]
		void RequirePromptOnNextAccess ();

		// -(NSSet<NSString *> * _Nullable)allKeysWithUserPrompt:(NSString * _Nonnull)userPrompt error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("allKeysWithUserPrompt:error:")]
		[return: NullAllowed]
		NSSet<NSString> AllKeysWithUserPrompt (string userPrompt, [NullAllowed] out NSError error);

		// -(BOOL)removeObjectForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("removeObjectForKey:error:")]
		bool RemoveObjectForKey (string key, [NullAllowed] out NSError error);

		// -(BOOL)removeAllObjectsAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("removeAllObjectsAndReturnError:")]
		bool RemoveAllObjectsAndReturnError ([NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsMatching:(NSDictionary<NSString *,NSObject *> * _Nonnull)query removeOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsMatching:removeOnCompletion:error:")]
		bool MigrateObjectsMatching (NSDictionary<NSString, NSObject> query, bool removeOnCompletion, [NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsFrom:(VALValet * _Nonnull)valet removeOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsFrom:removeOnCompletion:error:")]
		bool MigrateObjectsFrom (VALValet valet, bool removeOnCompletion, [NullAllowed] out NSError error);
	}

	// @interface Valet_Swift_645 (VALSinglePromptSecureEnclaveValet)
	[Category]
	[BaseType (typeof(VALSinglePromptSecureEnclaveValet))]
	interface VALSinglePromptSecureEnclaveValet_Valet_Swift_645
	{
		// +(VALSinglePromptSecureEnclaveValet * _Nullable)valetWithIdentifier:(NSString * _Nonnull)identifier accessControl:(enum VALSecureEnclaveAccessControl)accessControl __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valetWithIdentifier:accessControl:")]
		[return: NullAllowed]
		VALSinglePromptSecureEnclaveValet ValetWithIdentifier (string identifier, VALSecureEnclaveAccessControl accessControl);

		// +(VALSinglePromptSecureEnclaveValet * _Nullable)sharedGroupValetWithAppIDPrefix:(NSString * _Nonnull)appIDPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessControl:(enum VALSecureEnclaveAccessControl)accessControl __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessControl:")]
		[return: NullAllowed]
		VALSinglePromptSecureEnclaveValet SharedGroupValetWithAppIDPrefix (string appIDPrefix, string identifier, VALSecureEnclaveAccessControl accessControl);

		// +(VALSinglePromptSecureEnclaveValet * _Nullable)sharedGroupValetWithGroupPrefix:(NSString * _Nonnull)groupPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessControl:(enum VALSecureEnclaveAccessControl)accessControl __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessControl:")]
		[return: NullAllowed]
		VALSinglePromptSecureEnclaveValet SharedGroupValetWithGroupPrefix (string groupPrefix, string identifier, VALSecureEnclaveAccessControl accessControl);

		// -(BOOL)containsObjectForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("containsObjectForKey:")]
		bool ContainsObjectForKey (string key);
	}

	// @interface VALValet : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface VALValet
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, nonatomic) enum VALAccessibility accessibility;
		[Export ("accessibility")]
		VALAccessibility Accessibility { get; }

		// -(BOOL)canAccessKeychain __attribute__((warn_unused_result("")));
		[Export ("canAccessKeychain")]
		bool CanAccessKeychain { get; }

		// -(BOOL)setObject:(NSData * _Nonnull)object forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setObject:forKey:error:")]
		bool SetObject (NSData @object, string key, [NullAllowed] out NSError error);

		// -(NSData * _Nullable)objectForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("objectForKey:error:")]
		[return: NullAllowed]
		NSData ObjectForKey (string key, [NullAllowed] out NSError error);

		// -(BOOL)setString:(NSString * _Nonnull)string forKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("setString:forKey:error:")]
		bool SetString (string @string, string key, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)stringForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("stringForKey:error:")]
		[return: NullAllowed]
		string StringForKey (string key, [NullAllowed] out NSError error);

		// -(NSSet<NSString *> * _Nullable)allKeysAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("allKeysAndReturnError:")]
		[return: NullAllowed]
		NSSet<NSString> AllKeysAndReturnError ([NullAllowed] out NSError error);

		// -(BOOL)removeObjectForKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("removeObjectForKey:error:")]
		bool RemoveObjectForKey (string key, [NullAllowed] out NSError error);

		// -(BOOL)removeAllObjectsAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("removeAllObjectsAndReturnError:")]
		bool RemoveAllObjectsAndReturnError ([NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsMatching:(NSDictionary<NSString *,NSObject *> * _Nonnull)query removeOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsMatching:removeOnCompletion:error:")]
		bool MigrateObjectsMatching (NSDictionary<NSString, NSObject> query, bool removeOnCompletion, [NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsFrom:(VALValet * _Nonnull)valet removeOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsFrom:removeOnCompletion:error:")]
		bool MigrateObjectsFrom (VALValet valet, bool removeOnCompletion, [NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsFromAlwaysAccessibleValetWithRemoveOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsFromAlwaysAccessibleValetWithRemoveOnCompletion:error:")]
		bool MigrateObjectsFromAlwaysAccessibleValetWithRemoveOnCompletion (bool removeOnCompletion, [NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsFromAlwaysAccessibleThisDeviceOnlyValetWithRemoveOnCompletion:(BOOL)removeOnCompletion error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsFromAlwaysAccessibleThisDeviceOnlyValetWithRemoveOnCompletion:error:")]
		bool MigrateObjectsFromAlwaysAccessibleThisDeviceOnlyValetWithRemoveOnCompletion (bool removeOnCompletion, [NullAllowed] out NSError error);
	}

	// @interface Valet_Swift_804 (VALValet)
	[Category]
	[BaseType (typeof(VALValet))]
	interface VALValet_Valet_Swift_804
	{
		// +(VALValet * _Nullable)valetWithIdentifier:(NSString * _Nonnull)identifier accessibility:(enum VALAccessibility)accessibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valetWithIdentifier:accessibility:")]
		[return: NullAllowed]
		VALValet ValetWithIdentifier (string identifier, VALAccessibility accessibility);

		// +(VALValet * _Nullable)iCloudValetWithIdentifier:(NSString * _Nonnull)identifier accessibility:(enum VALCloudAccessibility)accessibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iCloudValetWithIdentifier:accessibility:")]
		[return: NullAllowed]
		VALValet ICloudValetWithIdentifier (string identifier, VALCloudAccessibility accessibility);

		// +(VALValet * _Nullable)sharedGroupValetWithAppIDPrefix:(NSString * _Nonnull)appIDPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessibility:(enum VALAccessibility)accessibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedGroupValetWithAppIDPrefix:sharedGroupIdentifier:accessibility:")]
		[return: NullAllowed]
		VALValet SharedGroupValetWithAppIDPrefix (string appIDPrefix, string identifier, VALAccessibility accessibility);

		// +(VALValet * _Nullable)sharedGroupValetWithGroupPrefix:(NSString * _Nonnull)groupPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessibility:(enum VALAccessibility)accessibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedGroupValetWithGroupPrefix:sharedGroupIdentifier:accessibility:")]
		[return: NullAllowed]
		VALValet SharedGroupValetWithGroupPrefix (string groupPrefix, string identifier, VALAccessibility accessibility);

		// +(VALValet * _Nullable)iCloudValetWithAppIDPrefix:(NSString * _Nonnull)appIDPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessibility:(enum VALCloudAccessibility)accessibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iCloudValetWithAppIDPrefix:sharedGroupIdentifier:accessibility:")]
		[return: NullAllowed]
		VALValet ICloudValetWithAppIDPrefix (string appIDPrefix, string identifier, VALCloudAccessibility accessibility);

		// +(VALValet * _Nullable)iCloudValetWithGroupPrefix:(NSString * _Nonnull)groupPrefix sharedGroupIdentifier:(NSString * _Nonnull)identifier accessibility:(enum VALCloudAccessibility)accessibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iCloudValetWithGroupPrefix:sharedGroupIdentifier:accessibility:")]
		[return: NullAllowed]
		VALValet ICloudValetWithGroupPrefix (string groupPrefix, string identifier, VALCloudAccessibility accessibility);

		// -(BOOL)containsObjectForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("containsObjectForKey:")]
		bool ContainsObjectForKey (string key);

		// -(BOOL)migrateObjectsMatching:(NSDictionary<NSString *,NSObject *> * _Nonnull)query compactMap:(VALMigratableKeyValuePairOutput * _Nullable (^ _Nonnull)(VALMigratableKeyValuePairInput * _Nonnull))compactMap error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsMatching:compactMap:error:")]
		bool MigrateObjectsMatching (NSDictionary<NSString, NSObject> query, Func<VALMigratableKeyValuePairInput, VALMigratableKeyValuePairOutput> compactMap, [NullAllowed] out NSError error);

		// -(BOOL)migrateObjectsFrom:(VALValet * _Nonnull)valet compactMap:(VALMigratableKeyValuePairOutput * _Nullable (^ _Nonnull)(VALMigratableKeyValuePairInput * _Nonnull))compactMap error:(NSError * _Nullable * _Nullable)error;
		[Export ("migrateObjectsFrom:compactMap:error:")]
		bool MigrateObjectsFrom (VALValet valet, Func<VALMigratableKeyValuePairInput, VALMigratableKeyValuePairOutput> compactMap, [NullAllowed] out NSError error);
	}
}
