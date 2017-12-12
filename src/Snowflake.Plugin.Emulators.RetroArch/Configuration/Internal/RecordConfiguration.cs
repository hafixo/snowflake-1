using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;

// autogenerated using generate_retroarch.py
// going to disable recording for the time being
namespace Snowflake.Plugin.Emulators.RetroArch.Configuration.Internal
{
    [ConfigurationSection("record", "Record Options")]
    public interface RecordConfiguration : IConfigurationSection<RecordConfiguration>
    {
        // this can be enum but the only other possible value is null.
        [ConfigurationOption("record_driver", "ffmpeg", DisplayName = "Record Driver", Private = true)]
        string RecordDriver { get; set; }

        [ConfigurationOption("auto_screenshot_filename", true, DisplayName = "Automatic screenshot filename",
            Private = true)]
        bool AutoScreenshotFilename { get; set; }

        [ConfigurationOption("video_gpu_record", false, DisplayName = "Enable Video Recording", Private = true)]
        bool VideoGpuRecord { get; set; }
    }
}