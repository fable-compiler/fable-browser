namespace Browser

open System
open Fable.Core

[<StringEnum; RequireQualifiedAccess>]
type BlobEndings =
    /// Endings are stored in the blob without change
    | [<CompiledName("transparent")>] Transparent
    /// Line ending characters are changed to match host OS filesystem convention
    | [<CompiledName("native")>] Native

type [<AllowNullLiteral>] BlobPropertyBag =
    abstract ``type``: string with get, set
    abstract endings: BlobEndings with get, set

type [<AllowNullLiteral>] Blob =
    abstract size: int
    abstract ``type``: string
    abstract slice: ?start: int * ?``end``: int * ?contentType: string -> Blob

type [<AllowNullLiteral>] BlobType =
    [<Emit("new $0($1...)")>] abstract Create: ?blobParts: obj[] * ?options: BlobPropertyBag -> Blob

[<AutoOpen>]
module Blob =
    let [<Global>] Blob: BlobType = jsNative
