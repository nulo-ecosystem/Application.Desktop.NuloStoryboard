namespace Nulo.Core.Utilities {

    internal static partial class NativeMethods {

        public static string GetCopyright() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.LegalCopyright;
            } catch {
                return string.Empty;
            }
        }

        public static string GetSmallVersion() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return $"{info.ProductMajorPart}.{info.ProductMinorPart}";
            } catch {
                return string.Empty;
            }
        }

        public static string GetProductName() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.ProductName.Replace(" ®", "®");
            } catch {
                return string.Empty;
            }
        }

        public static string GetIdProduct() {
            return "{6c5b1a1a-641d-4c32-9256-4e6681e88dd1}";
        }
    }
}