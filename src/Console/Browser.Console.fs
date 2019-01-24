namespace Browser

open System
open Fable.Core

type [<AllowNullLiteral>] Console =
    // TODO: Extension in the Browser.Dom package?
    // abstract select: element: Element -> unit
    abstract ``assert``: test: bool * message: string * [<ParamArray>] optionalParams: obj[] -> unit
    abstract clear: unit -> unit
    abstract count: ?countTitle: string -> unit
    abstract debug: message: string * [<ParamArray>] optionalParams: obj[] -> unit
    abstract dir: value: obj * [<ParamArray>] optionalParams: obj[] -> unit
    abstract dirxml: value: obj -> unit
    abstract error: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    abstract group: ?groupTitle: string -> unit
    abstract groupCollapsed: ?groupTitle: string -> unit
    abstract groupEnd: unit -> unit
    abstract info: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    abstract log: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    abstract profile: ?reportName: string -> unit
    abstract profileEnd: unit -> unit
    abstract time: ?timerName: string -> unit
    abstract timeEnd: ?timerName: string -> unit
    abstract trace: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
    abstract warn: message: obj * [<ParamArray>] optionalParams: obj[] -> unit

[<AutoOpen>]
module Console =
    let [<Global>] console: Console = jsNative
