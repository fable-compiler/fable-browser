namespace Browser.Types

open System
open Fable.Core

type [<AllowNullLiteral>] URLSearchParams =
    /// Appends a specified key/value pair as a new search parameter.
    abstract append: name: string * value: string -> unit
    /// Deletes the given search parameter, and its associated value, from the list of all search parameters.
    abstract delete: name: string -> unit
    /// Returns the first value associated to the given search parameter.
    abstract get: name: string -> string option
    /// Returns all the values association with a given search parameter.
    abstract getAll: name: string -> array<string>
    /// Returns a Boolean indicating if such a search parameter exists.
    abstract has: name: string -> bool
    /// Sets the value associated to a given search parameter to the given value. If there were several values, delete the others.
    abstract set: name: string * value: string -> unit

type [<AllowNullLiteral>] URLSearchParamsType =
    [<Emit("new $0($1...)")>] abstract Create: arg: obj -> URLSearchParams

type [<AllowNullLiteral>] URL =
    abstract hash: string with get, set
    abstract host: string with get, set
    abstract hostname: string with get, set
    abstract href: string with get, set
    abstract origin: string
    abstract password: string with get, set
    abstract pathname: string with get, set
    abstract port: string with get, set
    abstract protocol: string with get, set
    abstract search: string with get, set
    abstract username: string with get, set
    abstract searchParams: URLSearchParams
    abstract toString: unit -> string
    abstract toJSON: unit -> string

type [<AllowNullLiteral>] URLType =
    [<Emit("new $0($1...)")>] abstract Create: url: string -> URL
    /// Returns a DOMString containing a unique blob URL, that is a URL with blob: as its scheme, followed by an opaque string uniquely identifying the object in the browser.
    abstract createObjectURL: obj -> string
    /// Revokes an object URL previously created using URL.createObjectURL().
    abstract revokeObjectURL: string -> unit

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Url =
    let [<Global>] URL: URLType = jsNative
    let [<Global>] URLSearchParams: URLSearchParamsType = jsNative
