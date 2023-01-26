namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

type FileReaderState =
    | EMPTY = 0
    | LOADING = 1
    | DONE = 2

type [<AllowNullLiteral>] FilePropertyBag =
    abstract ``type``: string with get, set
    abstract lastModified: float with get, set

type [<AllowNullLiteral; Global>] File =
    inherit Blob
    abstract lastModified: float
    abstract name: string

type [<AllowNullLiteral>] FileType =
    [<Emit("new $0($1...)")>] abstract Create: parts: obj[] * filename: string * ?properties: FilePropertyBag -> File

type [<AllowNullLiteral; Global>] FileList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> File
    abstract item: index: int -> File

type [<AllowNullLiteral; Global>] FileReader =
    inherit EventTarget
    // abstract error: DOMException with get, set
    abstract readyState: FileReaderState
    abstract result: obj
    abstract onabort: (Event->unit) with get, set
    abstract onerror: (Event->unit) with get, set
    abstract onload: (Event->unit) with get, set
    abstract abort: unit -> unit
    abstract readAsArrayBuffer: blob: Blob -> unit
    abstract readAsBinaryString: blob: Blob -> unit
    abstract readAsDataURL: blob: Blob -> unit
    abstract readAsText: blob: Blob * ?encoding: string -> unit

type [<AllowNullLiteral>] FileReaderType =
    abstract prototype: FileReader with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> FileReader
