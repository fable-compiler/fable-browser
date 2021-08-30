[<AutoOpen>]
module Browser.CssExtensions

open Fable.Core
open Browser.Types

type Window with
    [<Emit("$0.getComputedStyle($1...)")>]
    member __.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative

type ShadowRoot with
    /// Returns a StyleSheetList of CSSStyleSheet objects for stylesheets explicitly linked into, or embedded in a shadow tree.
    [<Emit("$0.styleSheets")>]
    member __.styleSheets: StyleSheetList = jsNative

    /// returns this shadowRoot adopted stylesheets or sets them.
    /// https://wicg.github.io/construct-stylesheets/#using-constructed-stylesheets
    [<Emit("$0.adoptedStyleSheets{{=$1}}")>]
    member __.adoptedStyleSheets with get(): CSSStyleSheet array = jsNative and set(v: CSSStyleSheet array) = jsNative

type Document with
    /// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
    [<Emit("$0.styleSheets{{=$1}}")>]
    member __.styleSheets with get(): StyleSheetList = jsNative and set(v: StyleSheetList) = jsNative
    [<Emit("$0.styleMedia{{=$1}}")>]
    member __.styleMedia with get(): StyleMedia = jsNative and set(v: StyleMedia) = jsNative
    [<Emit("$0.getMatchedCSSRules($1...)")>]
    member __.getMatchedCSSRules(elt: Element, ?pseudoElt: string): CSSRuleList = jsNative

type HTMLElement with
    [<Emit("$0.style{{=$1}}")>]
    member __.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type HTMLLinkElement with
    [<Emit("$0.sheet{{=$1}}")>]
    member __.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type HTMLStyleElement with
    [<Emit("$0.sheet{{=$1}}")>]
    member __.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type SVGStylable with
    [<Emit("$0.style{{=$1}}")>]
    member __.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type SVGSVGElement with
    [<Emit("$0.getComputedStyle($1...)")>]
    member __.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative
