namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module IndexedDB =
    let [<Global>] indexedDB: IDBFactory = jsNative

