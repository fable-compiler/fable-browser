namespace Browser.Types

open Fable.Core

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

[<StringEnum>]
type GamepadEventType =
    | [<CompiledName("gamepadconnected")>] GamepadConnected
    | [<CompiledName("gamepaddisconnected")>] GamepadDisconnected

type [<AllowNullLiteral>] GamepadEvent =
    inherit Event
    [<Emit("new $0($1...)")>] abstract Create: typeArg: GamepadEventType * ?options: Gamepad
    abstract gamepad: Gamepad

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Gamepad =
    let [<Global>] gamepad: Gamepad = jsNative
