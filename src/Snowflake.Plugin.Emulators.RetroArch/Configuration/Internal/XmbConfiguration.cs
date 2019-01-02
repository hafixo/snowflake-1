using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;

// autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.Emulators.RetroArch.Configuration.Internal
{
    /// <summary>
    ///     Menu is completely disabled.
    /// </summary>
    [ConfigurationSection("xmb", "Xmb Options")]
    public interface XmbConfiguration : IConfigurationSection<XmbConfiguration>
    {
        [ConfigurationOption("xmb_alpha_factor", 75, DisplayName = "Xmb Alpha Factor", Private = true)]
        int XmbAlphaFactor { get; set; }

        [ConfigurationOption("xmb_font", "", DisplayName = "Xmb Font", Private = true)]
        string XmbFont { get; set; }

        [ConfigurationOption("xmb_scale_factor", 100, DisplayName = "Xmb Scale Factor", Private = true)]
        int XmbScaleFactor { get; set; }

        [ConfigurationOption("xmb_shadows", false, DisplayName = "Xmb Shadows", Private = true)]
        bool XmbShadows { get; set; }

        // unknown how xmb theme works.
        [ConfigurationOption("xmb_theme", 0, DisplayName = "Xmb Theme", Private = true)]
        int XmbTheme { get; set; }
    }
}
