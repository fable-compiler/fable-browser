namespace rec Browser

open System
open Fable.Core

// TODO: Add CustomEvent

type [<AllowNullLiteral>] Event =
    abstract bubbles: bool with get, set
    abstract cancelBubble: bool with get, set
    abstract cancelable: bool with get, set
    abstract currentTarget: EventTarget with get, set
    abstract defaultPrevented: bool with get, set
    abstract eventPhase: float with get, set
    abstract isTrusted: bool with get, set
    abstract returnValue: bool with get, set
    abstract target: EventTarget with get, set
    abstract timeStamp: float with get, set
    abstract ``type``: string with get, set
    abstract AT_TARGET: float with get, set
    abstract BUBBLING_PHASE: float with get, set
    abstract CAPTURING_PHASE: float with get, set
    abstract initEvent: eventTypeArg: string * canBubbleArg: bool * cancelableArg: bool -> unit
    abstract preventDefault: unit -> unit
    abstract stopImmediatePropagation: unit -> unit
    abstract stopPropagation: unit -> unit

type [<AllowNullLiteral>] EventType =
    abstract AT_TARGET: float with get, set
    abstract BUBBLING_PHASE: float with get, set
    abstract CAPTURING_PHASE: float with get, set

type [<AllowNullLiteral>] EventTarget =
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit
    abstract dispatchEvent: evt: Event -> bool
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

type [<AllowNullLiteral>] EventTargetType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> EventTarget

[<AutoOpen>]
module Event =
    let [<Global>] Event: EventType = jsNative
    let [<Global>] EventTarget: EventTargetType = jsNative
