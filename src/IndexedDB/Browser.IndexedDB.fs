namespace rec Browser.Types

open Fable.Core

[<Erase>]
type IDBRequestSource =
    | Index of IDBIndex
    | ObjectStore of IDBObjectStore
    | Cursor of IDBCursor

[<StringEnum>]
type IDBRequestReadyState =
    | Pending
    | Done

[<StringEnum>]
type IDBTransactionMode =
    | Readonly
    | Readwrite
    | Versionchange

[<StringEnum>]
type IDBTransactionDuarability =
    | Strict
    | Relaxed
    | Default

[<StringEnum>]
type IDBCursorDirection =
    | Next
    | Nextunique
    | Prev
    | Prevunique

type [<AllowNullLiteral>] DatabasesType =
    abstract name: string
    abstract version: string

type [<AllowNullLiteral; Global>] IDBIndex =
    abstract isAutoLocale: bool with get
    abstract locale: string with get
    abstract name: string with get
    abstract objectStore: IDBObjectStore with get
    abstract keyPath: U2<string, ResizeArray<string>> with get
    abstract multiEntry: bool with get
    abstract unique: bool with get

    abstract count: ?key: obj -> IDBRequest
    abstract get: ?key: obj -> IDBRequest
    abstract getKey: ?key: obj -> IDBRequest
    abstract getAll: ?query: obj * ?count: int -> IDBRequest
    abstract getAllKeys: ?query: obj * ?count: int -> IDBRequest
    abstract openCursor: ?range: obj * ?direction: IDBCursorDirection -> IDBRequest
    abstract openKeyCursor: ?range: obj * ?direction: IDBCursorDirection -> IDBRequest

type [<AllowNullLiteral; Global>] IDBVersionChangeEvent =
    inherit Event

    abstract oldVersion: int64 with get
    abstract newVersion: int64 with get

type [<AbstractClass; AllowNullLiteral; Global>] IDBKeyRange =
    abstract lower: obj with get
    abstract upper: obj with get
    abstract lowerOpen: bool with get
    abstract upperOpen: bool with get
    abstract includes: obj -> bool

    [<Emit("IDBKeyRange.bound($0, $1, $2, $3)")>]
    static member bound(lower: obj, upper: obj, ?lowerOpen: bool, ?upperOpen: bool) = jsNative<IDBKeyRange>

    [<Emit("IDBKeyRange.only($0)")>]
    static member only(only: obj) = jsNative<IDBKeyRange>

    [<Emit("IDBKeyRange.lowerBound($0, $1)")>]
    static member lowerBound(lower: obj, ?``open``: bool) = jsNative<IDBKeyRange>

    [<Emit("IDBKeyRange.upperBound($0, $1)")>]
    static member upperBound(upper: obj, ?``open``: bool) = jsNative<IDBKeyRange>

type [<AllowNullLiteral; Global>] IDBCursor =
    abstract source: IDBObjectStore with get
    abstract direction: IDBCursorDirection with get
    abstract key: obj option with get
    abstract primaryKey: obj option with get
    abstract request: IDBRequest with get

    abstract advance: count: int -> unit
    abstract ``continue``: ?key: obj -> unit
    abstract continuePrimaryKey: key: obj * primaryKey: obj -> unit
    abstract delete: unit -> IDBRequest
    abstract update: value: obj -> IDBRequest

type [<AllowNullLiteral; Global>] IDBCursorWithValue =
    inherit IDBCursor

    abstract value: obj option with get

type [<AllowNullLiteral; Global>] IDBTransaction =
    inherit EventTarget

    abstract db: IDBDatabase with get
    abstract durability: IDBTransactionDuarability with get
    abstract error: DOMException with get
    abstract mode: IDBTransactionMode with get
    abstract objectStoreNames: DOMStringList with get

    abstract abort: unit -> unit
    abstract objectStore: name: string -> IDBObjectStore
    abstract commit: unit -> unit

    abstract oncomplete: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set
    abstract onabort: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBRequest =
    inherit EventTarget

    abstract error: DOMException with get
    abstract result: obj option with get
    abstract source: IDBRequestSource option with get
    abstract readyState: IDBRequestReadyState with get
    abstract transaction: IDBTransaction with get

    abstract onerror: (Event -> unit) with get, set
    abstract onsuccess: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBCreateIndexOptions =
    abstract unique: bool with get, set
    abstract multiEntry: bool with get, set

type [<AllowNullLiteral; Global>] IDBObjectStore =
    abstract indexNames: DOMStringList with get
    abstract keyPath: U2<string, ResizeArray<string>> with get
    abstract name: string with get
    abstract transaction: IDBTransaction with get
    abstract autoIncrement: bool with get

    abstract add: value: obj * ?key: obj -> IDBRequest
    abstract clear: unit -> IDBRequest
    abstract count: ?query: IDBKeyRange -> IDBRequest
    abstract createIndex: indexName: string * keyPath: ResizeArray<string> * ?options: IDBCreateIndexOptions -> IDBRequest
    abstract createIndex: indexName: string * keyPath: string * ?options: IDBCreateIndexOptions -> IDBRequest
    abstract delete: key: obj -> IDBRequest
    abstract deleteIndex: unit -> IDBRequest
    abstract get: key: obj -> IDBRequest
    abstract getKey: key: obj -> IDBRequest
    abstract getAll: ?query: IDBKeyRange * ?count: int -> IDBRequest
    abstract getAllKeys: ?query: IDBKeyRange * ?count: int -> IDBRequest
    abstract index: string -> IDBIndex
    abstract openCursor: ?range: IDBKeyRange * ?direction: IDBCursorDirection -> IDBRequest
    abstract openKeyCursor: ?range: IDBKeyRange * ?direction: IDBCursorDirection -> IDBRequest
    abstract put: item: obj * ?key: obj -> IDBRequest

type [<AllowNullLiteral; Global>] IDBCreateStoreOptions =
    abstract autoIncrement: bool option with get, set
    abstract keyPath: U2<string, ResizeArray<string>> option with get, set

type [<AllowNullLiteral; Global>] IDBTransactionOptions =
    abstract durability: IDBTransactionDuarability with get, set

type [<AllowNullLiteral; Global>] IDBDatabase =
    inherit EventTarget

    abstract name: string with get
    abstract version: int64 with get
    abstract objectStoreNames: DOMStringList with get

    abstract close: unit -> unit
    abstract createObjectStore: name: string * ?options: IDBCreateStoreOptions -> IDBObjectStore
    abstract deleteObjectStore: name: string -> unit
    abstract transaction: storeNames: #seq<string> * ?mode: IDBTransactionMode * ?options: IDBTransactionOptions -> IDBTransaction
    abstract transaction: storeNames: string * ?mode: IDBTransactionMode * ?options: IDBTransactionOptions -> IDBTransaction

    abstract onclose: (Event -> unit) with get, set
    abstract onversionchange: (Event -> unit) with get, set
    abstract onabort: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBOpenDBRequest =
    inherit IDBRequest

    abstract blocked: (Event -> unit) with get, set
    abstract onupgradeneeded: (IDBVersionChangeEvent -> unit) with get, set

type [<AllowNullLiteral; Global>] IDBFactory =
    abstract ``open``: name: string * ?version: int -> IDBOpenDBRequest
    abstract cmp: first: 'T * second: 'T -> int
    abstract deleteDatabase: name: string -> IDBOpenDBRequest
    abstract databases: unit -> JS.Promise<DatabasesType array>
