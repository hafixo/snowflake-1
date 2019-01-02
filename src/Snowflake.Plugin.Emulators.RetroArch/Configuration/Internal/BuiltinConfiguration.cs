using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;

// autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.Emulators.RetroArch.Configuration.Internal
{
    [ConfigurationSection("builtin", "Builtin Options")]
    public interface BuiltinConfiguration : IConfigurationSection<BuiltinConfiguration>
    {
        [ConfigurationOption("builtin_imageviewer_enable", true, DisplayName = "Builtin Imageviewer Enable",
            Private = true)]
        bool BuiltinImageviewerEnable { get; set; }

        [ConfigurationOption("builtin_mediaplayer_enable", true, DisplayName = "Builtin Mediaplayer Enable",
            Private = true)]
        bool BuiltinMediaplayerEnable { get; set; }
    }
}
