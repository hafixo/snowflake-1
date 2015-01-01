﻿using System;
namespace Snowflake.Emulator.Input
{
    public interface IGamepadMapping
    {
        string GAMEPAD_A { get; }
        string GAMEPAD_B { get; }
        string GAMEPAD_DPAD_DOWN { get; }
        string GAMEPAD_DPAD_LEFT { get; }
        string GAMEPAD_DPAD_RIGHT { get; }
        string GAMEPAD_DPAD_UP { get; }
        string GAMEPAD_GUIDE { get; }
        string GAMEPAD_L_X_DOWN { get; }
        string GAMEPAD_L_X_UP { get; }
        string GAMEPAD_L_Y_LEFT { get; }
        string GAMEPAD_L_Y_RIGHT { get; }
        string GAMEPAD_L1 { get; }
        string GAMEPAD_L2 { get; }
        string GAMEPAD_L3 { get; }
        string GAMEPAD_R_X_DOWN { get; }
        string GAMEPAD_R_X_UP { get; }
        string GAMEPAD_R_Y_LEFT { get; }
        string GAMEPAD_R_Y_RIGHT { get; }
        string GAMEPAD_R1 { get; }
        string GAMEPAD_R2 { get; }
        string GAMEPAD_R3 { get; }
        string GAMEPAD_SELECT { get; }
        string GAMEPAD_START { get; }
        string GAMEPAD_X { get; }
        string GAMEPAD_Y { get; }
        string this[string key] { get; }
    }
}
