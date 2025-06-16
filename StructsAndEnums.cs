using ObjCRuntime;

namespace SquareValetBindings
{
    [Native]
    public enum VALAccessibility : long
    {
        WhenUnlocked = 1,
        AfterFirstUnlock = 2,
        WhenPasscodeSetThisDeviceOnly = 4,
        WhenUnlockedThisDeviceOnly = 5,
        AfterFirstUnlockThisDeviceOnly = 6
    }

    [Native]
    public enum VALCloudAccessibility : long
    {
        WhenUnlocked = 1,
        AfterFirstUnlock = 2
    }

    [Native]
    public enum VALKeychainError : long
    {
        CouldNotAccessKeychain = 0,
        UserCancelled = 1,
        ItemNotFound = 2,
        MissingEntitlement = 3,
        EmptyKey = 4,
        EmptyValue = 5
    }

    [Native]
    public enum VALMigrationResult : long
    {
        InvalidQuery = 0,
        KeyToMigrateInvalid = 1,
        DataToMigrateInvalid = 2,
        DuplicateKeyToMigrate = 3,
        KeyToMigrateAlreadyExistsInValet = 4,
        RemovalFailed = 5
    }

    [Native]
    public enum VALSecureEnclaveAccessControl : long
    {
        UserPresence = 1,
        BiometricAny = 2,
        BiometricCurrentSet = 3,
        DevicePasscode = 4
    }
}