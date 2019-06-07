namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Css =
    let [<Global>] CSSConditionRule: CSSConditionRuleType = jsNative
    let [<Global>] CSSFontFaceRule: CSSFontFaceRuleType = jsNative
    let [<Global>] CSSGroupingRule: CSSGroupingRuleType = jsNative
    let [<Global>] CSSImportRule: CSSImportRuleType = jsNative
    let [<Global>] CSSKeyframeRule: CSSKeyframeRuleType = jsNative
    let [<Global>] CSSKeyframesRule: CSSKeyframesRuleType = jsNative
    let [<Global>] CSSMediaRule: CSSMediaRuleType = jsNative
    let [<Global>] CSSNamespaceRule: CSSNamespaceRuleType = jsNative
    let [<Global>] CSSPageRule: CSSPageRuleType = jsNative
    let [<Global>] CSSRule: CSSRuleType = jsNative
    let [<Global>] CSSRuleList: CSSRuleListType = jsNative
    let [<Global>] CSSStyleDeclaration: CSSStyleDeclarationType = jsNative
    let [<Global>] CSSStyleRule: CSSStyleRuleType = jsNative
    let [<Global>] CSSStyleSheet: CSSStyleSheetType = jsNative
    let [<Global>] CSSSupportsRule: CSSSupportsRuleType = jsNative
    let [<Global>] StyleMedia: StyleMediaType = jsNative
    let [<Global>] StyleSheet: StyleSheetType = jsNative
    let [<Global>] StyleSheetList: StyleSheetListType = jsNative
    let [<Global>] StyleSheetPageList: StyleSheetPageListType = jsNative
