namespace rec Browser

open System
open Fable.Core

type [<AllowNullLiteral>] FilePropertyBag =
    abstract ``type``: string with get, set
    abstract lastModified: float with get, set

type [<AllowNullLiteral>] File =
    inherit Blob
    abstract lastModified: float
    abstract name: string

type [<AllowNullLiteral>] FileType =
    [<Emit("new $0($1...)")>] abstract Create: parts: obj[] * filename: string * ?properties: FilePropertyBag -> File

type [<AllowNullLiteral>] FileList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> File
    abstract item: index: int -> File

type [<AllowNullLiteral>] FileReader =
    inherit EventTarget
    // TODO
    // abstract error: DOMException with get, set
    abstract readAsArrayBuffer: blob: Blob -> unit
    abstract readAsBinaryString: blob: Blob -> unit
    abstract readAsDataURL: blob: Blob -> unit
    abstract readAsText: blob: Blob * ?encoding: string -> unit

type [<AllowNullLiteral>] FileReaderType =
    abstract prototype: FileReader with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> FileReader

[<AutoOpen>]
module File =
    let [<Global>] File: FileType = jsNative
    let [<Global>] FileReader: FileReaderType = jsNative
