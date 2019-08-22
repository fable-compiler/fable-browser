[<AutoOpen>]
module Browser.DomExtensions

open Fable.Core
open Browser.Types

type FormDataType with
    [<Emit("new $0($1...)")>]
    member __.Create(form: HTMLFormElement): FormData = jsNative
