namespace rec Browser.Types

open System
open Fable.Core

type WebSocketState =
    | CONNECTING = 0
    | OPEN = 1
    | CLOSING = 2
    | CLOSED = 3

type [<AllowNullLiteral; Global>] CloseEvent =
    inherit Event
    abstract code: int
    abstract reason: string
    abstract wasClean: bool

type [<AllowNullLiteral; Global>] WebSocket =
    inherit EventTarget
    abstract binaryType: string with get, set
    abstract bufferedAmount: float
    abstract extensions: string
    abstract onclose: (CloseEvent -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set
    abstract onmessage: (MessageEvent -> unit) with get, set
    abstract onopen: (Event -> unit) with get, set
    abstract protocol: string
    abstract readyState: WebSocketState
    abstract url: string
    abstract close: ?code: int * ?reason: string -> unit
    abstract send: data: obj -> unit
    [<Emit("$0.addEventListener('close',$1...)")>] abstract addEventListener_close: listener: (CloseEvent -> unit) * ?useCapture: bool -> unit
    [<Emit("$0.addEventListener('error',$1...)")>] abstract addEventListener_error: listener: (ErrorEvent -> unit) * ?useCapture: bool -> unit
    [<Emit("$0.addEventListener('message',$1...)")>] abstract addEventListener_message: listener: (MessageEvent -> unit) * ?useCapture: bool -> unit
    [<Emit("$0.addEventListener('open',$1...)")>] abstract addEventListener_open: listener: (Event -> unit) * ?useCapture: bool -> unit

type [<AllowNullLiteral>] WebSocketType =
    [<Emit("new $0($1...)")>] abstract Create: url: string * ?protocols: U2<string, string[]> -> WebSocket

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module WebSocket =
    let [<Global>] WebSocket: WebSocketType = jsNative
