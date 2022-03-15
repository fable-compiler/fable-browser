namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

[<StringEnum; RequireQualifiedAccess>]
type BlobEndings =
    /// Endings are stored in the blob without change
    | [<CompiledName("transparent")>] Transparent
    /// Line ending characters are changed to match host OS filesystem convention
    | [<CompiledName("native")>] Native

type [<AllowNullLiteral>] BlobPropertyBag =
    abstract ``type``: string with get, set
    abstract endings: BlobEndings with get, set

type [<AllowNullLiteral; Global>] Blob =
    abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    abstract size: int
    abstract ``type``: string
    abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob

type [<AllowNullLiteral>] BlobType =
    [<Emit("new $0($1...)")>] abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob

type [<AllowNullLiteral; Global>] FormData =
    abstract append: name: string * value: string -> unit
    abstract append: name: string * value: Blob * ?filename: string -> unit
    abstract delete: name: string -> unit
    abstract entries: unit -> (string * obj) seq
    abstract get: name: string -> obj
    abstract getAll: name: string -> obj[]
    abstract has: name: string -> bool
    abstract keys: unit -> string seq
    abstract set: name: string * value: string -> unit
    abstract set: name: string * value: Blob * ?filename: string -> unit
    abstract values: unit -> obj seq

type [<AllowNullLiteral>] FormDataType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> FormData

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Blob =
    let [<Global>] Blob: BlobType = jsNative
    let [<Global>] FormData: FormDataType = jsNative
