﻿using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Devcade
{
  public static class Input
  {
    /// <summary>
    /// Enum of button names available on the cabinet. Maps directly to the 
    /// equivalent in the Buttons enum. Allows you to use existing controller 
    /// logic and essentially just rename the buttons but you must explicitly 
    /// cast it to a Button each time.
    /// </summary>
    public enum ArcadeButtons
    {
      A1=Buttons.X,
      A2=Buttons.Y,
      A3=Buttons.RightShoulder,
      A4=Buttons.LeftShoulder,
      B1=Buttons.A,
      B2=Buttons.B,
      B3=Buttons.RightTrigger,
      B4=Buttons.LeftTrigger,
      Menu=Buttons.Start,
      StickDown=Buttons.LeftThumbstickDown,
      StickUp=Buttons.LeftThumbstickUp,
      StickLeft=Buttons.LeftThumbstickLeft,
      StickRight=Buttons.LeftThumbstickRight
    }


    private static GamePadState p1State;
    private static GamePadState p1LastState;

    private static GamePadState p2State;
    private static GamePadState p2LastState;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerNum"></param>
    /// <param name="button"></param>
    /// <returns></returns>
    public static bool GetButton(int playerNum, ArcadeButtons button)
    {

      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerNum"></param>
    /// <param name="button"></param>
    /// <returns></returns>
    public static bool GetButtonDown(int playerNum, ArcadeButtons button)
    {

      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerNum"></param>
    /// <param name="button"></param>
    /// <returns></returns>
    public static bool GetButtonUp(int playerNum, ArcadeButtons button)
    {

      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerNum"></param>
    /// <param name="button"></param>
    /// <returns></returns>
    public static bool GetButtonHeld(int playerNum, ArcadeButtons button)
    {

      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerNum"></param>
    /// <returns></returns>
    public static Vector2 GetStick(int playerNum)
    {

      return Vector2.Zero;
    }

    /// <summary>
    /// 
    /// </summary>
    public static void Initialize()
    {
      p1State = GamePad.GetState(0);
      p2State = GamePad.GetState(1);
      p1LastState = GamePad.GetState(0);
      p2LastState = GamePad.GetState(1);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void Update()
    {
      p1LastState = p1State;
      p2LastState = p2State;
      p1State = GamePad.GetState(0);
      p2State = GamePad.GetState(1);
    }

  }
}