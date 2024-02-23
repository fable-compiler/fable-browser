namespace rec Browser.Types

open System
open Fable.Core

type EventSourceState =
    | CONNECTING = 0
    | OPEN = 1
    | CLOSED = 2

[<AllowNullLiteral; Global>]
type EventSource =
    inherit EventTarget
    abstract readyState: EventSourceState
    abstract url: string
    abstract withCredentials: bool

    abstract close: unit -> unit

    abstract onerror: (Event -> unit) with get, set
    abstract onmessage: (MessageEvent -> unit) with get, set
    abstract onopen: (Event -> unit) with get, set

    [<Emit("$0.addEventListener('error',$1...)")>]
    abstract addEventListener_error: listener: (Event -> unit) * ?useCapture: bool -> unit

    [<Emit("$0.addEventListener('message',$1...)")>]
    abstract addEventListener_message: listener: (MessageEvent -> unit) * ?useCapture: bool -> unit

    [<Emit("$0.addEventListener('open',$1...)")>]
    abstract addEventListener_open: listener: (Event -> unit) * ?useCapture: bool -> unit

[<AllowNullLiteral>]
type EventSourceOptions =
    abstract withCredentials: bool with get, set

[<AllowNullLiteral>]
type EventSourceType =
    [<Emit("new $0($1...)")>]
    abstract Create: url: string * ?options: EventSourceOptions -> EventSource

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module EventSource =
    [<Global>]
    let EventSource: EventSourceType = jsNative
