using Foundation;
using ObjCRuntime;

namespace SquareValetBindings.Helpers
{
    public static class ValetFactory
    {
        public static VALValet Create(string identifier, VALAccessibility access) =>
            // supply the unused ‘this’ parameter as null
            VALValet_Valet_Swift_804.ValetWithIdentifier(
                (VALValet?)null,   // <- the dummy receiver
                identifier,
                access);
    }
}