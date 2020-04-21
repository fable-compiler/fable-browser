[<AutoOpen>]
module Browser.CssExtensions

open Fable.Core
open Browser.Types

type Document with
    [<Emit("$0.matchMedia($1...)")>]
    member __.matchMedia(mediaQuery : string) : MediaQueryList = jsNative

type Window with
    [<Emit("$0.matchMedia($1...)")>]
    member __.matchMedia(mediaQuery : string) : MediaQueryList = jsNative