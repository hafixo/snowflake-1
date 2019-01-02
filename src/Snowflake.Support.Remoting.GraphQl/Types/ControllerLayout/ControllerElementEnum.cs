﻿using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using Snowflake.Input.Controller;

namespace Snowflake.Support.Remoting.GraphQl.Types.ControllerLayout
{
    public class ControllerElementEnum : EnumerationGraphType
    {
        public ControllerElementEnum()
        {
            Name = "ControllerElement";
            Description = "A Stone Controller Element";
            AddValue(nameof(ControllerElement.NoElement), "No element.", ControllerElement.NoElement);
            AddValue(nameof(ControllerElement.ButtonA), "The conventional 'A' or confirm face button in a controller.",
                ControllerElement.ButtonA);
            AddValue(nameof(ControllerElement.ButtonB), "The conventional 'B' or back face button in a controller.",
                ControllerElement.ButtonB);
            AddValue(nameof(ControllerElement.ButtonC),
                "The 'C'-labeled, or 3rd button in a 6-face button layout or similar.", ControllerElement.ButtonC);
            AddValue(nameof(ControllerElement.ButtonX), "The conventional 'X' button in a controller.",
                ControllerElement.ButtonX);
            AddValue(nameof(ControllerElement.ButtonY), "The conventional 'Y' button in a controller.",
                ControllerElement.ButtonY);
            AddValue(nameof(ControllerElement.ButtonZ),
                "The 'Z'-labeled or 6th button in a 6-face button layout or similar.", ControllerElement.ButtonZ);
            AddValue(nameof(ControllerElement.ButtonL),
                "The shoulder button registering a digital signal on the left side of the controller.",
                ControllerElement.ButtonL);
            AddValue(nameof(ControllerElement.ButtonR),
                "The shoulder button registering a digital signal on the right side of the controller.",
                ControllerElement.ButtonR);
            AddValue(nameof(ControllerElement.ButtonStart),
                "The traditional 'Start' button on a conventional controller that usually pauses or starts the game.",
                ControllerElement.ButtonStart);
            AddValue(nameof(ControllerElement.ButtonSelect),
                "The traditional 'Select' button on a conventional controller that provides auxillary functions.",
                ControllerElement.ButtonSelect);
            AddValue(nameof(ControllerElement.ButtonGuide),
                "A guide button featured on modern controllers that bring up a pause or guide overlay outside of the game itself.",
                ControllerElement.ButtonGuide);
            AddValue(nameof(ControllerElement.ButtonClickL),
                "A depression on the left analog stick that registers a digital signal. Usually labeled as L3.",
                ControllerElement.ButtonClickL);
            AddValue(nameof(ControllerElement.ButtonClickR),
                "A depression on the Right analog stick that registers a digital signal. Usually labeled as R3.",
                ControllerElement.ButtonClickR);
            AddValue(nameof(ControllerElement.Button0),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button0);
            AddValue(nameof(ControllerElement.Button1),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button1);
            AddValue(nameof(ControllerElement.Button2),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button2);
            AddValue(nameof(ControllerElement.Button3),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button3);
            AddValue(nameof(ControllerElement.Button4),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button4);
            AddValue(nameof(ControllerElement.Button5),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button5);
            AddValue(nameof(ControllerElement.Button6),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button6);
            AddValue(nameof(ControllerElement.Button7),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button7);
            AddValue(nameof(ControllerElement.Button8),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button8);
            AddValue(nameof(ControllerElement.Button9),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons, or as a numeric pad key on certain controllers.",
                ControllerElement.Button9);
            AddValue(nameof(ControllerElement.Button10),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button10);
            AddValue(nameof(ControllerElement.Button11),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button11);
            AddValue(nameof(ControllerElement.Button12),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button12);
            AddValue(nameof(ControllerElement.Button13),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button13);
            AddValue(nameof(ControllerElement.Button14),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button14);
            AddValue(nameof(ControllerElement.Button15),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button15);
            AddValue(nameof(ControllerElement.Button16),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button16);
            AddValue(nameof(ControllerElement.Button17),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button17);
            AddValue(nameof(ControllerElement.Button18),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button18);
            AddValue(nameof(ControllerElement.Button19),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button19);
            AddValue(nameof(ControllerElement.Button20),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button20);
            AddValue(nameof(ControllerElement.Button21),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button21);
            AddValue(nameof(ControllerElement.Button22),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button22);
            AddValue(nameof(ControllerElement.Button23),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button23);
            AddValue(nameof(ControllerElement.Button24),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button24);
            AddValue(nameof(ControllerElement.Button25),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button25);
            AddValue(nameof(ControllerElement.Button26),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button26);
            AddValue(nameof(ControllerElement.Button27),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button27);
            AddValue(nameof(ControllerElement.Button28),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button28);
            AddValue(nameof(ControllerElement.Button29),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button29);
            AddValue(nameof(ControllerElement.Button30),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button30);
            AddValue(nameof(ControllerElement.Button31),
                "Numbered button without semantic value. Used as a placeholder for buttons that do not fit within the other semantic buttons..",
                ControllerElement.Button31);
            AddValue(nameof(ControllerElement.DirectionalN),
                "Directional button indicating the north or upwards direction.", ControllerElement.DirectionalN);
            AddValue(nameof(ControllerElement.DirectionalE),
                "Directional button indicating the east or rightwards direction.", ControllerElement.DirectionalE);
            AddValue(nameof(ControllerElement.DirectionalS),
                "Direction button indicating the south or downwards direction.", ControllerElement.DirectionalS);
            AddValue(nameof(ControllerElement.DirectionalW),
                "Direction button indicating the west or leftwards direction.", ControllerElement.DirectionalW);
            AddValue(nameof(ControllerElement.DirectionalNE),
                "Auxillary directional button indicating the northeast, or upwards and right direction.",
                ControllerElement.DirectionalNE);
            AddValue(nameof(ControllerElement.DirectionalNW),
                "Auxillary directional button indicating the northwest, or upwards and left direction.",
                ControllerElement.DirectionalNW);
            AddValue(nameof(ControllerElement.DirectionalSE),
                "Auxillary directional button indicating the southeast, or downwards and right direction.",
                ControllerElement.DirectionalSE);
            AddValue(nameof(ControllerElement.DirectionalSW),
                "Auxillary directional button indicating the southwest, or downwards and left direction.",
                ControllerElement.DirectionalSW);
            AddValue(nameof(ControllerElement.TriggerLeft),
                "An analog shoulder trigger, able to be depressed smoothly with varying degrees of pressure from undepressed (0%) to fully depressed (100%), on the left side of the controller, usually marked L2.",
                ControllerElement.TriggerLeft);
            AddValue(nameof(ControllerElement.TriggerRight),
                "An analog shoulder trigger, able to be depressed smoothly with varying degrees of pressure from undepressed (0%) to fully depressed (100%), on the right side of the controller, usually marked R2.",
                ControllerElement.TriggerRight);
            AddValue(nameof(ControllerElement.AxisLeftAnalogPositiveX),
                "Rightwards movement of the left analog stick along the X axis (horizontally).",
                ControllerElement.AxisLeftAnalogPositiveX);
            AddValue(nameof(ControllerElement.AxisLeftAnalogNegativeX),
                "Leftwards movement of the left analog stick along the X axis (horizontally).",
                ControllerElement.AxisLeftAnalogNegativeX);
            AddValue(nameof(ControllerElement.AxisLeftAnalogPositiveY),
                "Upwards movement of the left analog stick along the Y axis (vertically).",
                ControllerElement.AxisLeftAnalogPositiveY);
            AddValue(nameof(ControllerElement.AxisLeftAnalogNegativeY),
                "Downwards movement of the left analog stick along the Y axis (vertically).",
                ControllerElement.AxisLeftAnalogNegativeY);
            AddValue(nameof(ControllerElement.AxisRightAnalogPositiveX),
                "Rightwards movement of the right analog stick along the X axis (horizontally).",
                ControllerElement.AxisRightAnalogPositiveX);
            AddValue(nameof(ControllerElement.AxisRightAnalogNegativeX),
                "Leftwards movement of the right analog stick along the X axis (horizontally).",
                ControllerElement.AxisRightAnalogNegativeX);
            AddValue(nameof(ControllerElement.AxisRightAnalogPositiveY),
                "Upwards movement of the right analog stick along the Y axis (vertically).",
                ControllerElement.AxisRightAnalogPositiveY);
            AddValue(nameof(ControllerElement.AxisRightAnalogNegativeY),
                "Downwards movement of the right analog stick along the Y axis (vertically).",
                ControllerElement.AxisRightAnalogNegativeY);
            AddValue(nameof(ControllerElement.RumbleBig),
                "A large rumble action (usually through the larger of two rumble motors in a controller.",
                ControllerElement.RumbleBig);
            AddValue(nameof(ControllerElement.RumbleSmall),
                "A smaller rumble action (usually through the smaller of two rumble motors in a controller.",
                ControllerElement.RumbleSmall);
            AddValue(nameof(ControllerElement.Pointer2D),
                "A pointing device that can express position in the form of a contiguous set of coordinates on a 2 dimensional cartesian plane. Examples include a mouse, or the Wii Remote IR.",
                ControllerElement.Pointer2D);
            AddValue(nameof(ControllerElement.Pointer3D),
                "A pointing device that can express position in the form of a contiguous set of coordinates in 3 dimensional space. Examples include the Oculus Touch device, or the Playstation Move.",
                ControllerElement.Pointer3D);
            AddValue(nameof(ControllerElement.PointerAxisPositiveX),
                "Continous rightwards movement of a pointer device on the X axis (horizontal).",
                ControllerElement.PointerAxisPositiveX);
            AddValue(nameof(ControllerElement.PointerAxisNegativeX),
                "Continous leftwards movement of a pointer device on the X axis (horizontal).",
                ControllerElement.PointerAxisNegativeX);
            AddValue(nameof(ControllerElement.PointerAxisPositiveY),
                "Continous upwards movement of a pointer device on the Y axis (vertical).",
                ControllerElement.PointerAxisPositiveY);
            AddValue(nameof(ControllerElement.PointerAxisNegativeY),
                "Continous downwards movement of a pointer device on the Y axis (vertical).",
                ControllerElement.PointerAxisNegativeY);
            AddValue(nameof(ControllerElement.PointerAxisPositiveZ),
                "Continous forwards movement of a pointer device on the Z axis.",
                ControllerElement.PointerAxisPositiveZ);
            AddValue(nameof(ControllerElement.PointerAxisNegativeZ),
                "Continous backwards movement of a pointer device on the Z axis.",
                ControllerElement.PointerAxisNegativeZ);
            AddValue(nameof(ControllerElement.Keyboard),
                "A keyboad with an unspecified amount of keys. Intended for emulated computers such as the Commodore 64.",
                ControllerElement.Keyboard);
            AddValue(nameof(ControllerElement.Touchscreen),
                "A touch sensitive surface of unspecified size and precision, where input can be expressed as a non-contiguous matrix of coordinates on a 2 dimentional cartesian plane. However, most touchscreens in video game controllers are only concerned with a single matrix due to the lack of multi-touch.",
                ControllerElement.Touchscreen);
            AddValue(nameof(ControllerElement.KeyNone), "The None Key.", ControllerElement.KeyNone);
            AddValue(nameof(ControllerElement.KeyA), "The A Key.", ControllerElement.KeyA);
            AddValue(nameof(ControllerElement.KeyB), "The B Key.", ControllerElement.KeyB);
            AddValue(nameof(ControllerElement.KeyC), "The C Key.", ControllerElement.KeyC);
            AddValue(nameof(ControllerElement.KeyD), "The D Key.", ControllerElement.KeyD);
            AddValue(nameof(ControllerElement.KeyE), "The E Key.", ControllerElement.KeyE);
            AddValue(nameof(ControllerElement.KeyF), "The F Key.", ControllerElement.KeyF);
            AddValue(nameof(ControllerElement.KeyG), "The G Key.", ControllerElement.KeyG);
            AddValue(nameof(ControllerElement.KeyH), "The H Key.", ControllerElement.KeyH);
            AddValue(nameof(ControllerElement.KeyI), "The I Key.", ControllerElement.KeyI);
            AddValue(nameof(ControllerElement.KeyJ), "The J Key.", ControllerElement.KeyJ);
            AddValue(nameof(ControllerElement.KeyK), "The K Key.", ControllerElement.KeyK);
            AddValue(nameof(ControllerElement.KeyL), "The L Key.", ControllerElement.KeyL);
            AddValue(nameof(ControllerElement.KeyM), "The M Key.", ControllerElement.KeyM);
            AddValue(nameof(ControllerElement.KeyN), "The N Key.", ControllerElement.KeyN);
            AddValue(nameof(ControllerElement.KeyO), "The O Key.", ControllerElement.KeyO);
            AddValue(nameof(ControllerElement.KeyP), "The P Key.", ControllerElement.KeyP);
            AddValue(nameof(ControllerElement.KeyQ), "The Q Key.", ControllerElement.KeyQ);
            AddValue(nameof(ControllerElement.KeyR), "The R Key.", ControllerElement.KeyR);
            AddValue(nameof(ControllerElement.KeyS), "The S Key.", ControllerElement.KeyS);
            AddValue(nameof(ControllerElement.KeyT), "The T Key.", ControllerElement.KeyT);
            AddValue(nameof(ControllerElement.KeyU), "The U Key.", ControllerElement.KeyU);
            AddValue(nameof(ControllerElement.KeyV), "The V Key.", ControllerElement.KeyV);
            AddValue(nameof(ControllerElement.KeyW), "The W Key.", ControllerElement.KeyW);
            AddValue(nameof(ControllerElement.KeyX), "The X Key.", ControllerElement.KeyX);
            AddValue(nameof(ControllerElement.KeyY), "The Y Key.", ControllerElement.KeyY);
            AddValue(nameof(ControllerElement.KeyZ), "The Z Key.", ControllerElement.KeyZ);
            AddValue(nameof(ControllerElement.Key0), "The 0 Key.", ControllerElement.Key0);
            AddValue(nameof(ControllerElement.Key1), "The 1 Key.", ControllerElement.Key1);
            AddValue(nameof(ControllerElement.Key2), "The 2 Key.", ControllerElement.Key2);
            AddValue(nameof(ControllerElement.Key3), "The 3 Key.", ControllerElement.Key3);
            AddValue(nameof(ControllerElement.Key4), "The 4 Key.", ControllerElement.Key4);
            AddValue(nameof(ControllerElement.Key5), "The 5 Key.", ControllerElement.Key5);
            AddValue(nameof(ControllerElement.Key6), "The 6 Key.", ControllerElement.Key6);
            AddValue(nameof(ControllerElement.Key7), "The 7 Key.", ControllerElement.Key7);
            AddValue(nameof(ControllerElement.Key8), "The 8 Key.", ControllerElement.Key8);
            AddValue(nameof(ControllerElement.Key9), "The 9 Key.", ControllerElement.Key9);
            AddValue(nameof(ControllerElement.KeyEquals), "The Equals (=) Key.", ControllerElement.KeyEquals);
            AddValue(nameof(ControllerElement.KeyMinus), "The Minus (-) Key.", ControllerElement.KeyMinus);
            AddValue(nameof(ControllerElement.KeyBackspace), "The Backspace Key.", ControllerElement.KeyBackspace);
            AddValue(nameof(ControllerElement.KeySpacebar), "The Spacebar Key.", ControllerElement.KeySpacebar);
            AddValue(nameof(ControllerElement.KeyEnter), "The Enter Key.", ControllerElement.KeyEnter);
            AddValue(nameof(ControllerElement.KeyUp), "The Up Key.", ControllerElement.KeyUp);
            AddValue(nameof(ControllerElement.KeyDown), "The Down Key.", ControllerElement.KeyDown);
            AddValue(nameof(ControllerElement.KeyLeft), "The Left Key.", ControllerElement.KeyLeft);
            AddValue(nameof(ControllerElement.KeyRight), "The Right Key.", ControllerElement.KeyRight);
            AddValue(nameof(ControllerElement.KeyTab), "The Tab Key.", ControllerElement.KeyTab);
            AddValue(nameof(ControllerElement.KeyInsert), "The Insert Key.", ControllerElement.KeyInsert);
            AddValue(nameof(ControllerElement.KeyDelete), "The Delete Key.", ControllerElement.KeyDelete);
            AddValue(nameof(ControllerElement.KeyHome), "The Home Key.", ControllerElement.KeyHome);
            AddValue(nameof(ControllerElement.KeyEnd), "The End Key.", ControllerElement.KeyEnd);
            AddValue(nameof(ControllerElement.KeyPageUp), "The PageUp Key.", ControllerElement.KeyPageUp);
            AddValue(nameof(ControllerElement.KeyPageDown), "The PageDown Key.", ControllerElement.KeyPageDown);
            AddValue(nameof(ControllerElement.KeyShift), "The Shift Key.", ControllerElement.KeyShift);
            AddValue(nameof(ControllerElement.KeyCtrl), "The Ctrl Key.", ControllerElement.KeyCtrl);
            AddValue(nameof(ControllerElement.KeyAlt), "The Alt Key.", ControllerElement.KeyAlt);
            AddValue(nameof(ControllerElement.KeyEscape), "The Escape Key.", ControllerElement.KeyEscape);
            AddValue(nameof(ControllerElement.KeyTilde), "The Tilde (~) Key.", ControllerElement.KeyTilde);
            AddValue(nameof(ControllerElement.KeyQuote), "The Quote (') Key.", ControllerElement.KeyQuote);
            AddValue(nameof(ControllerElement.KeySemicolon), "The Semicolon (;) Key.", ControllerElement.KeySemicolon);
            AddValue(nameof(ControllerElement.KeyComma), "The Comma (:) Key.", ControllerElement.KeyComma);
            AddValue(nameof(ControllerElement.KeyPeriod), "The Period (.) Key.", ControllerElement.KeyPeriod);
            AddValue(nameof(ControllerElement.KeySlash), "The Slash (/) Key.", ControllerElement.KeySlash);
            AddValue(nameof(ControllerElement.KeyBracketLeft), "The Left Bracket ([)Key.",
                ControllerElement.KeyBracketLeft);
            AddValue(nameof(ControllerElement.KeyBracketRight), "The Right Brackey (]) Key.",
                ControllerElement.KeyBracketRight);
            AddValue(nameof(ControllerElement.KeyBackslash), "The Backslash (\\) Key.", ControllerElement.KeyBackslash);
            AddValue(nameof(ControllerElement.KeyRightAlt), "The Right Alt Key.", ControllerElement.KeyRightAlt);
            AddValue(nameof(ControllerElement.KeyRightCtrl), "The Right Ctrl Key.", ControllerElement.KeyRightCtrl);
            AddValue(nameof(ControllerElement.KeyRightShift), "The Right Shift Key.", ControllerElement.KeyRightShift);
            AddValue(nameof(ControllerElement.KeyNum0), "The Num0 Key.", ControllerElement.KeyNum0);
            AddValue(nameof(ControllerElement.KeyNum1), "The Num1 Key.", ControllerElement.KeyNum1);
            AddValue(nameof(ControllerElement.KeyNum2), "The Num2 Key.", ControllerElement.KeyNum2);
            AddValue(nameof(ControllerElement.KeyNum3), "The Num3 Key.", ControllerElement.KeyNum3);
            AddValue(nameof(ControllerElement.KeyNum4), "The Num4 Key.", ControllerElement.KeyNum4);
            AddValue(nameof(ControllerElement.KeyNum5), "The Num5 Key.", ControllerElement.KeyNum5);
            AddValue(nameof(ControllerElement.KeyNum6), "The Num6 Key.", ControllerElement.KeyNum6);
            AddValue(nameof(ControllerElement.KeyNum7), "The Num7 Key.", ControllerElement.KeyNum7);
            AddValue(nameof(ControllerElement.KeyNum8), "The Num8 Key.", ControllerElement.KeyNum8);
            AddValue(nameof(ControllerElement.KeyNum9), "The Num9 Key.", ControllerElement.KeyNum9);
            AddValue(nameof(ControllerElement.KeyNumPeriod), "The NumPeriod Key.", ControllerElement.KeyNumPeriod);
            AddValue(nameof(ControllerElement.KeyNumPlus), "The NumPlus Key.", ControllerElement.KeyNumPlus);
            AddValue(nameof(ControllerElement.KeyNumMinus), "The NumMinus Key.", ControllerElement.KeyNumMinus);
            AddValue(nameof(ControllerElement.KeyNumEnter), "The NumEnter Key.", ControllerElement.KeyNumEnter);
            AddValue(nameof(ControllerElement.KeyF1), "The F1 Key.", ControllerElement.KeyF1);
            AddValue(nameof(ControllerElement.KeyF2), "The F2 Key.", ControllerElement.KeyF2);
            AddValue(nameof(ControllerElement.KeyF3), "The F3 Key.", ControllerElement.KeyF3);
            AddValue(nameof(ControllerElement.KeyF4), "The F4 Key.", ControllerElement.KeyF4);
            AddValue(nameof(ControllerElement.KeyF5), "The F5 Key.", ControllerElement.KeyF5);
            AddValue(nameof(ControllerElement.KeyF6), "The F6 Key.", ControllerElement.KeyF6);
            AddValue(nameof(ControllerElement.KeyF7), "The F7 Key.", ControllerElement.KeyF7);
            AddValue(nameof(ControllerElement.KeyF8), "The F8 Key.", ControllerElement.KeyF8);
            AddValue(nameof(ControllerElement.KeyF9), "The F9 Key.", ControllerElement.KeyF9);
            AddValue(nameof(ControllerElement.KeyF10), "The F10 Key.", ControllerElement.KeyF10);
            AddValue(nameof(ControllerElement.KeyF11), "The F11 Key.", ControllerElement.KeyF11);
            AddValue(nameof(ControllerElement.KeyF12), "The F12 Key.", ControllerElement.KeyF12);
        }
    }
}
