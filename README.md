# square-valet-ios-net-bindings

**.NET 8 / iOS bindings for [Square Valet](https://github.com/square/Valet)** – Square’s battle-tested Keychain / Secure Enclave wrapper.

> **Status:** Early preview – APIs compile & run on real devices, but docs / samples are still catching up.  
> Please file issues (or PRs!) for anything that looks off.

---

## Why?

* **Modern .NET 8** projects now target *net8.0-ios* instead of the old Xamarin targets.
* The original **Square.Valet** NuGet package stopped at Xamarin.iOS ➜ it won’t load in a modern MAUI / .NET for iOS app.
* These bindings expose the full Valet 5.x+ surface so you can keep using the clean Valet API instead of rolling raw Keychain code.

---

## Quick start

```csharp
using SquareValetBindings;              // namespace from the binding project

// 1. Create a valet (app-keychain, no keychain sharing)
var valet = VALValet_Valet_Swift_804.ValetWithIdentifier(
    "com.example.app",                  // keychain identifier / service
    VALAccessibility.WhenUnlocked);     // Keychain accessibility level

// 2. Store & retrieve a string
valet.SetString("super-secret", "MyKey");

var secret = valet.StringForKey("MyKey", out var error);
Console.WriteLine($"Secret = {secret}");
