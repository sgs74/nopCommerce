namespace Nop.Data
{
    /// <summary>
    /// Represents default values related to data settings
    /// </summary>
    public static partial class NopDataSettingsDefaults
    {
        /// <summary>
        /// Gets a path to the file that contains data settings (old version)
        /// </summary>
        public static string FilePath => "~/App_Data/dataSettings.json";

        /// <summary>
        /// Gets a path to the file that contains app settings
        /// </summary>
        public static string AppSettingsFilePath => "~/App_Data/appsettings.json";
    }
}