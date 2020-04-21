namespace rec Browser.Types

open Fable.Core
open Browser.Types

type [<AllowNullLiteral>] MediaQueryList =
    inherit EventTarget
    abstract matches: bool with get, set
    abstract media: string with get, set
    abstract onchange: (Event -> 'Out) with get, set

type [<AllowNullLiteral>] MediaQueryListType =
    abstract prototype: MediaQueryList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> MediaQueryList
