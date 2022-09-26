namespace Browser.Types

open System
open Fable.Core


// type IDBCursorWithValue = ()
// type IDBDatabase = ()
type IDBFactory =
    abstract ``open``: string with get
// type IDBIndex = ()
// type IDBKeyRange = ()
// type IDBObjectStore = ()
// type IDBOpenDBRequest = ()
// type IDBRequest = ()
// type IDBTransaction = ()
// type IDBVersionChangeEvent = ()

type IndexedDBType =
    abstract ``open``: string -> unit

[<AutoOpen>]
module IndexedDB =
    let [<Global>] indexedDB: IndexedDBType = jsNative
