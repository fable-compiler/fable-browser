namespace rec Browser.Types

open System
open Fable.Core

type DatabasesType = {
    name: string
    version: string
}

// type IDBCursorWithValue = ()
type [<AllowNullLiteral; Global>] IDBCursor =
    abstract source: IDBObjectStore with get
    abstract direction: string with get
    abstract key: obj option with get
    abstract primaryKey: obj option with get
    abstract request: IDBRequest with get

    abstract advance: count: int -> unit
    abstract continue: ?key: obj -> unit
    abstract continuePrimaryKey: key: obj * primaryKey: obj -> unit
    abstract delete: unit -> IDBRequest
    abstract update: value: obj -> IDBRequest

type [<AllowNullLiteral; Global>] IDBTransaction =
    abstract db: IDBDatabase with get
    abstract durability: obj with get
    abstract error: exn with get
    abstract mode: string with get
    abstract objectStoreNames: string array with get

    abstract abort: unit -> unit
    abstract objectStore: name: string -> IDBObjectStore
    abstract commit: unit -> unit

    abstract oncomplete: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBDatabase =
    inherit EventTarget

    abstract name: string with get
    abstract version: int64 with get
    abstract objectStoreNames: string array with get

    abstract close: unit -> unit
    abstract createObjectStore: name: string * ?options: obj -> IDBObjectStore
    abstract deleteObjectStore: name: string -> unit
    abstract transaction: storeNames: #seq<string> * ?mode: string * ?options: obj -> IDBTransaction

    abstract onerror: (Event -> unit) with get, set

type IDBRequest =
    inherit EventTarget

    abstract error: exn with get
    abstract result: IDBDatabase with get
    abstract source: string option with get
    abstract readyState: obj with get
    abstract transaction: IDBTransaction with get

    abstract onsuccess: (Event -> unit) with get, set
    abstract onupgradeneeded: (Event -> unit) with get, set

type IDBObjectStore =
    abstract indexNames: string array with get
    abstract keyPath: obj with get
    abstract name: string with get
    abstract transaction: IDBTransaction with get
    abstract autoIncrement: bool with get

    abstract add: value: obj * ?key: obj -> IDBRequest
    abstract clear: unit -> IDBRequest
    abstract count: unit -> IDBRequest
    abstract createIndex: indexName: string * keyPath: string * ?objectParameters: obj -> IDBRequest
    abstract delete: unit -> IDBRequest
    abstract deleteIndex: unit -> IDBRequest
    abstract get: unit -> IDBRequest
    abstract getKey: unit -> IDBRequest
    abstract getAll: unit -> IDBRequest
    abstract getAllKeys: unit -> IDBRequest
    abstract index: unit -> IDBRequest
    abstract openCursor: unit -> IDBRequest
    abstract openKeyCursor: unit -> IDBRequest
    abstract put: unit -> IDBRequest

type IDBOpenDBRequest =
    inherit IDBRequest

type IDBFactory =
    abstract ``open``: string -> IDBOpenDBRequest
    // NOTE(SimenLK): Not yet implemented
    abstract databases: unit -> JS.Promise<DatabasesType array>
// type IDBIndex = ()
// type IDBKeyRange = ()
// type IDBVersionChangeEvent = ()

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module IndexedDB =
    let [<Global>] indexedDB: IDBFactory = jsNative
