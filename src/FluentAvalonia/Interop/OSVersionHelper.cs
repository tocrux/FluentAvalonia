namespace FluentAvalonia.Interop;

/// <summary>
/// Helper alowed to detect OS - keeping the IsWindows11 helper method here, all other
/// helpers pre2.5 are now replaced with direct calls to "OperatingSystem" class
/// </summary>
internal static class OSVersionHelper
{
    /// <summary>
    /// Return if current OS is Windows 11
    /// </summary>
    public static bool IsWindows11() =>
        OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22000);
    
    public static bool IsWindows10_1607() =>
        OperatingSystem.IsWindowsVersionAtLeast(10, 0, 14393);
    
    public static bool IsWindows10_1809() =>
        OperatingSystem.IsWindowsVersionAtLeast(10, 0, 17763);
    
    public static bool IsWindows10_1903() =>
        OperatingSystem.IsWindowsVersionAtLeast(10, 0, 18362);
}
