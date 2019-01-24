namespace Browser

open System
open Fable.Core

type [<AllowNullLiteral>] History =
    abstract length: int
    abstract state: obj with get, set
    /// Equivalent to history.go(-1)
    abstract back: unit -> unit
    /// Equivalent to history.go(1)
    abstract forward: unit -> unit
    /// Loads a page from the session history, identified by its relative location to the current page, for example -1 for the previous page or 1  for the next page. If you specify an out-of-bounds value (for instance, specifying -1 when there are no previously-visited pages in the session history), this method silently has no effect. Calling go() without parameters or a value of 0 reloads the current page.
    abstract go: ?delta: int -> unit
    /// Pushes the given data onto the session history stack with the specified title and, if provided, URL. The data is treated as opaque by the DOM; you may specify any JavaScript object that can be serialized.
    abstract pushState: statedata: obj * ?title: string * ?url: string -> unit
    /// Updates the most recent entry on the history stack to have the specified data, title, and, if provided, URL. The data is treated as opaque by the DOM; you may specify any JavaScript object that can be serialized.
    abstract replaceState: statedata: obj * ?title: string * ?url: string -> unit

[<AutoOpen>]
module History =
    let [<Global>] history: History = jsNative
