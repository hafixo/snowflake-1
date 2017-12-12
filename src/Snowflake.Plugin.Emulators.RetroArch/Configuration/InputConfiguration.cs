using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;
using Snowflake.Plugin.Emulators.RetroArch.Selections.InputConfiguration;

// autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.Emulators.RetroArch.Configuration
{
    [ConfigurationSection("input", "Input Options")]
    public interface InputConfiguration : IConfigurationSection<InputConfiguration>
    {
        [ConfigurationOption("auto_remaps_enable", false, DisplayName = "Auto Remaps Enable", Private = true)]
        bool AutoRemapsEnable { get; set; }

        // This is private because of Snowflake input API.
        [ConfigurationOption("input_autodetect_enable", false,
            DisplayName = "Enable RetroArch Input Profile Auto Detection", Private = true)]
        bool InputAutodetectEnable { get; set; }

        [ConfigurationOption("input_axis_threshold", 0.500000, DisplayName = "Input Axis Threshold")]
        double InputAxisThreshold { get; set; }

        [ConfigurationOption("input_descriptor_hide_unbound", false, DisplayName = "Input Descriptor Hide Unbound",
            Private = true)]
        bool InputDescriptorHideUnbound { get; set; }

        [ConfigurationOption("input_descriptor_label_show", true, DisplayName = "Input Descriptor Label Show",
            Private = true)]
        bool InputDescriptorLabelShow { get; set; }

        [ConfigurationOption("input_driver", InputDriver.DirectInput, DisplayName = "Input Driver", Private = true)]
        InputDriver InputDriver { get; set; }

        // todo check max
        [ConfigurationOption("input_duty_cycle", 3, DisplayName = "Input Duty Cycle")]
        int InputDutyCycle { get; set; }

        [ConfigurationOption("input_joypad_driver", InputJoypadDriver.XInput, DisplayName = "Input Joypad Driver",
            Private = true)]
        InputJoypadDriver InputJoypadDriver { get; set; }

        [ConfigurationOption("input_max_users", 4, DisplayName = "Input Max Users", Private = true)]
        int InputMaxUsers { get; set; }

        [ConfigurationOption("input_menu_toggle_gamepad_combo", 0, DisplayName = "Input Menu Toggle Gamepad Combo",
            Private = true)]
        int InputMenuToggleGamepadCombo { get; set; }

        [ConfigurationOption("input_poll_type_behavior", InputPollType.Normal, DisplayName = "Input Poll Type Behavior")
        ]
        InputPollType InputPollTypeBehavior { get; set; }

        // disabled and private as core wrapper handles input
        [ConfigurationOption("input_remap_binds_enable", false, DisplayName = "Input Remap Binds Enable", Private = true)]
        bool InputRemapBindsEnable { get; set; }

        [ConfigurationOption("input_turbo_period", 6, DisplayName = "Input Turbo Period")]
        int InputTurboPeriod { get; set; }

        // It is unknown what these keyboard settings do.
        [ConfigurationOption("keyboard_gamepad_enable", true, DisplayName = "Keyboard Gamepad Enable", Private = true)]
        bool KeyboardGamepadEnable { get; set; }

        [ConfigurationOption("input_keyboard_layout", "", DisplayName = "Input Keyboard Layout", Private = true)]
        string InputKeyboardLayout { get; set; }

        // this is probably an enum but it's not exposed inside the retroarch gui.
        [ConfigurationOption("keyboard_gamepad_mapping_type", 1, DisplayName = "Keyboard Gamepad Mapping Type",
            Private = true)]
        int KeyboardGamepadMappingType { get; set; }

        [ConfigurationOption("input_menu_toggle", "nul", DisplayName = "Menu Toggle Stub", Private = true)] // stub the menu toggle hotkey
        string InputMenuToggle { get; set; }

        [ConfigurationOption("input_toggle_fast_forward", "nul", DisplayName = "Fast Forward Stub", Private = true)] // stub fast-forwad
        string InputFastForward { get; set; }
        #region InputOverlay

        // The input overlay is useless on desktops.
        [ConfigurationOption("input_osk_overlay", "", DisplayName = "Input Osk Overlay", Private = true)]
        string InputOskOverlay { get; set; }

        [ConfigurationOption("input_osk_overlay_enable", false, DisplayName = "Input Osk Overlay Enable", Private = true)]
        bool InputOskOverlayEnable { get; set; }

        [ConfigurationOption("input_overlay", "", DisplayName = "Input Overlay", Private = true)]
        string InputOverlay { get; set; }

        [ConfigurationOption("input_overlay_enable", false, DisplayName = "Input Overlay Enable", Private = true)]
        bool InputOverlayEnable { get; set; }

        [ConfigurationOption("input_overlay_enable_autopreferred", false,
            DisplayName = "Input Overlay Enable Autopreferred", Private = true)]
        bool InputOverlayEnableAutopreferred { get; set; }

        [ConfigurationOption("input_overlay_hide_in_menu", true, DisplayName = "Input Overlay Hide In Menu",
            Private = true)]
        bool InputOverlayHideInMenu { get; set; }

        [ConfigurationOption("input_overlay_opacity", 0.700000, DisplayName = "Input Overlay Opacity", Private = true)]
        double InputOverlayOpacity { get; set; }

        [ConfigurationOption("input_overlay_scale", 1.000000, DisplayName = "Input Overlay Scale", Private = true)]
        double InputOverlayScale { get; set; }

        #endregion
    }
}