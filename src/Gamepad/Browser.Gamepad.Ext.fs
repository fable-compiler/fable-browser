[<AutoOpen>]
module Browser.GamepadExtensions

open Fable.Core
open Browser.Types

type Navigator with
    /// The Navigator.getGamepads() method returns an array of Gamepad objects, one for each gamepad connected to the device. Elements in the array may be null if a gamepad disconnects during a session, so that the remaining gamepads retain the same index.
    [<Emit("$0.getGamepads()")>]
    member __.getGamepads(): unit -> ResizeArray<Gamepad option> = jsNative

type Window with
    member __.ongamepadconnected with get(): (GamepadEvent -> obj) = jsNative and set(v: GamepadEvent) = jsNative
    member __.ongamepaddisconnected with get(): (GamepadEvent -> obj) = jsNative and set(v: GamepadEvent) = jsNative
