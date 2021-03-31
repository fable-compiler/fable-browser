namespace Browser.Types

type GamepadButton =
    abstract value: float
    abstract pressed: bool

type Gamepad =
    abstract axes: ResizeArray<float>
    abstract buttons: ResizeArray<GamepadButton>
    abstract connected: bool
    abstract id: string
    abstract index: int
    abstract mapping: string
    abstract timestamp: float

type [<AllowNullLiteral>] GamepadEvent =
    inherit Event
    abstract gamepad: Gamepad

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Gamepad =
    let [<Global>] gamepad: Gamepad = jsNative
