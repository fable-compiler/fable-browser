namespace Browser.Types

open System
open Fable.Core

type [<AllowNullLiteral>] Storage =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract clear: unit -> unit
    abstract getItem: key: string -> obj
    abstract key: index: float -> string
    abstract removeItem: key: string -> unit
    abstract setItem: key: string * data: string -> unit

type [<AllowNullLiteral>] StorageEvent =
    inherit Event
    abstract url: string
    abstract key: string
    abstract oldValue: string
    abstract newValue: string
    abstract storageArea: Storage

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module WebStorage =
    let [<Global>] localStorage: Storage = jsNative
    let [<Global>] sessionStorage: Storage = jsNative
