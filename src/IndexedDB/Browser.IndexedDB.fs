namespace rec Browser.Types

open System
open Fable.Core


[<Erase>]
type IDBRequestSource =
    | Index of IDBIndex
    | ObjectStore of IDBObjectStore
    | Cursor of IDBCursor

[<Erase>]
type IDBRequestReadyState =
    | Pending
    | ``Done``

type [<AllowNullLiteral>] DatabasesType =
    abstract name: string
    abstract version: string

type [<AllowNullLiteral; Global>] IDBIndex =
    abstract isAutoLocale: bool with get
    abstract locale: string with get
    abstract name: string with get
    abstract objectStore: IDBObjectStore with get
    abstract keyPath: obj with get
    abstract multiEntry: bool with get
    abstract unique: bool with get

    abstract count: ?key: obj -> IDBRequest
    abstract get: ?key: obj -> IDBRequest
    abstract getKey: ?key: obj -> IDBRequest
    abstract getAll: ?query: obj * ?count: int -> IDBRequest
    abstract getAllKeys: ?query: obj * ?count: int -> IDBRequest
    abstract openCursor: ?range: obj * ?direction: string -> IDBRequest
    abstract openKeyCursor: unit -> IDBRequest

type [<AllowNullLiteral; Global>] IDBVersionChangeEvent =
    inherit Event

    abstract oldVersion: int64 with get
    abstract newVersion: int64 with get

type [<AllowNullLiteral; Global>] IDBKeyRange =
    abstract lower: obj with get
    abstract upper: obj with get
    abstract lowerOpen: obj with get
    abstract upperOpen: obj with get

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

type [<AllowNullLiteral; Global>] IDBCursorWithValue =
    inherit IDBCursor

    abstract value: obj option with get

type [<AllowNullLiteral; Global>] IDBTransaction =
    abstract db: IDBDatabase with get
    abstract durability: obj with get
    abstract error: DOMException with get
    abstract mode: string with get
    abstract objectStoreNames: DOMStringList with get

    abstract abort: unit -> unit
    abstract objectStore: name: string -> IDBObjectStore
    abstract commit: unit -> unit

    abstract oncomplete: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBRequest =
    inherit EventTarget

    abstract error: DOMException with get
    abstract result: obj option with get
    abstract source: IDBRequestSource option with get
    abstract readyState: IDBRequestReadyState with get
    abstract transaction: IDBTransaction with get

    abstract onerror: (Event -> unit) with get, set
    abstract onsuccess: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBObjectStore =
    abstract indexNames: DOMStringList with get
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
    abstract get: obj -> IDBRequest
    abstract getKey: unit -> IDBRequest
    abstract getAll: unit -> IDBRequest
    abstract getAllKeys: unit -> IDBRequest
    abstract index: string -> IDBIndex
    abstract openCursor: ?query: IDBKeyRange -> IDBRequest
    abstract openKeyCursor: unit -> IDBRequest
    abstract put: unit -> IDBRequest

type [<AllowNullLiteral; Global>] IDBDatabase =
    inherit EventTarget

    abstract name: string with get
    abstract version: int64 with get
    abstract objectStoreNames: DOMStringList with get

    abstract close: unit -> unit
    abstract createObjectStore: name: string * ?options: obj -> IDBObjectStore
    abstract deleteObjectStore: name: string -> unit
    abstract transaction: storeNames: #seq<string> * ?mode: string * ?options: obj -> IDBTransaction
    abstract transaction: storeNames: string * ?mode: string * ?options: obj -> IDBTransaction

    abstract onerror: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBOpenDBRequest =
    inherit IDBRequest

    abstract blocked: (Event -> unit) with get, set
    abstract onupgradeneeded: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBFactory =
    abstract ``open``: name: string * ?version: int64 -> IDBOpenDBRequest
    abstract cmp: first: string -> second: string -> int
    abstract deleteDatabase: name: string -> IDBOpenDBRequest
    // NOTE(SimenLK): Not yet implemented
    // abstract databases: unit -> JS.Promise<DatabasesType array>
