[<AutoOpen>]
module Browser.SvgExtensions

open Fable.Core
open Browser.Types

type Document with
    /// Gets the root svg element in the document hierarchy.
    [<Emit("$0.rootElement{{=$1}}")>]
    member __.rootElement with get(): SVGSVGElement = jsNative and set(v: SVGSVGElement) = jsNative