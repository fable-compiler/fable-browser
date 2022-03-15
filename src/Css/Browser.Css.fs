namespace rec Browser.Types

open System
open Fable.Core

type [<AllowNullLiteral>] CSS =
    abstract supports: property: string * ?value: string -> bool

type [<AllowNullLiteral; Global>] CSSConditionRule =
    inherit CSSGroupingRule
    abstract conditionText: string with get, set

type CSSConditionRuleType =
    abstract prototype: CSSConditionRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSConditionRule

type [<AllowNullLiteral; Global>] CSSFontFaceRule =
    inherit CSSRule
    abstract style: CSSStyleDeclaration with get, set

type CSSFontFaceRuleType =
    abstract prototype: CSSFontFaceRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSFontFaceRule

type [<AllowNullLiteral; Global>] CSSGroupingRule =
    inherit CSSRule
    abstract cssRules: CSSRuleList with get, set
    abstract deleteRule: ?index: float -> unit
    abstract insertRule: rule: string * ?index: float -> float

type CSSGroupingRuleType =
    abstract prototype: CSSGroupingRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSGroupingRule

type [<AllowNullLiteral; Global>] CSSImportRule =
    inherit CSSRule
    abstract href: string with get, set
    // TODO
    // abstract media: MediaList with get, set
    abstract styleSheet: CSSStyleSheet with get, set

type CSSImportRuleType =
    abstract prototype: CSSImportRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSImportRule

type [<AllowNullLiteral; Global>] CSSKeyframeRule =
    inherit CSSRule
    abstract keyText: string with get, set
    abstract style: CSSStyleDeclaration with get, set

type CSSKeyframeRuleType =
    abstract prototype: CSSKeyframeRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSKeyframeRule

type [<AllowNullLiteral; Global>] CSSKeyframesRule =
    inherit CSSRule
    abstract cssRules: CSSRuleList with get, set
    abstract name: string with get, set
    abstract appendRule: rule: string -> unit
    abstract deleteRule: rule: string -> unit
    abstract findRule: rule: string -> CSSKeyframeRule

type CSSKeyframesRuleType =
    abstract prototype: CSSKeyframesRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSKeyframesRule

type [<AllowNullLiteral; Global>] CSSMediaRule =
    inherit CSSConditionRule
    /// TODO
    // abstract media: MediaList with get, set

type CSSMediaRuleType =
    abstract prototype: CSSMediaRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSMediaRule

type [<AllowNullLiteral; Global>] CSSNamespaceRule =
    inherit CSSRule
    abstract namespaceURI: string with get, set
    abstract prefix: string with get, set

type CSSNamespaceRuleType =
    abstract prototype: CSSNamespaceRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSNamespaceRule

type [<AllowNullLiteral; Global>] CSSPageRule =
    inherit CSSRule
    abstract pseudoClass: string with get, set
    abstract selector: string with get, set
    abstract selectorText: string with get, set
    abstract style: CSSStyleDeclaration with get, set

type CSSPageRuleType =
    abstract prototype: CSSPageRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSPageRule

type [<AllowNullLiteral; Global>] CSSRule =
    abstract cssText: string with get, set
    abstract parentRule: CSSRule with get, set
    abstract parentStyleSheet: CSSStyleSheet with get, set
    abstract ``type``: float with get, set
    abstract CHARSET_RULE: float with get, set
    abstract FONT_FACE_RULE: float with get, set
    abstract IMPORT_RULE: float with get, set
    abstract KEYFRAMES_RULE: float with get, set
    abstract KEYFRAME_RULE: float with get, set
    abstract MEDIA_RULE: float with get, set
    abstract NAMESPACE_RULE: float with get, set
    abstract PAGE_RULE: float with get, set
    abstract STYLE_RULE: float with get, set
    abstract SUPPORTS_RULE: float with get, set
    abstract UNKNOWN_RULE: float with get, set
    abstract VIEWPORT_RULE: float with get, set

type CSSRuleType =
    abstract prototype: CSSRule with get, set
    abstract CHARSET_RULE: float with get, set
    abstract FONT_FACE_RULE: float with get, set
    abstract IMPORT_RULE: float with get, set
    abstract KEYFRAMES_RULE: float with get, set
    abstract KEYFRAME_RULE: float with get, set
    abstract MEDIA_RULE: float with get, set
    abstract NAMESPACE_RULE: float with get, set
    abstract PAGE_RULE: float with get, set
    abstract STYLE_RULE: float with get, set
    abstract SUPPORTS_RULE: float with get, set
    abstract UNKNOWN_RULE: float with get, set
    abstract VIEWPORT_RULE: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSRule

type [<AllowNullLiteral; Global>] CSSRuleList =
    abstract length: float with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> CSSRule with get, set
    abstract item: index: float -> CSSRule

type CSSRuleListType =
    abstract prototype: CSSRuleList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSRuleList

type [<AllowNullLiteral; Global>] CSSStyleDeclaration =
    abstract alignContent: string with get, set
    abstract alignItems: string with get, set
    abstract alignSelf: string with get, set
    abstract alignmentBaseline: string with get, set
    abstract animation: string with get, set
    abstract animationDelay: string with get, set
    abstract animationDirection: string with get, set
    abstract animationDuration: string with get, set
    abstract animationFillMode: string with get, set
    abstract animationIterationCount: string with get, set
    abstract animationName: string with get, set
    abstract animationPlayState: string with get, set
    abstract animationTimingFunction: string with get, set
    abstract backfaceVisibility: string with get, set
    abstract background: string with get, set
    abstract backgroundAttachment: string with get, set
    abstract backgroundClip: string with get, set
    abstract backgroundColor: string with get, set
    abstract backgroundImage: string with get, set
    abstract backgroundOrigin: string with get, set
    abstract backgroundPosition: string with get, set
    abstract backgroundPositionX: string with get, set
    abstract backgroundPositionY: string with get, set
    abstract backgroundRepeat: string with get, set
    abstract backgroundSize: string with get, set
    abstract baselineShift: string with get, set
    abstract border: string with get, set
    abstract borderBottom: string with get, set
    abstract borderBottomColor: string with get, set
    abstract borderBottomLeftRadius: string with get, set
    abstract borderBottomRightRadius: string with get, set
    abstract borderBottomStyle: string with get, set
    abstract borderBottomWidth: string with get, set
    abstract borderCollapse: string with get, set
    abstract borderColor: string with get, set
    abstract borderImage: string with get, set
    abstract borderImageOutset: string with get, set
    abstract borderImageRepeat: string with get, set
    abstract borderImageSlice: string with get, set
    abstract borderImageSource: string with get, set
    abstract borderImageWidth: string with get, set
    abstract borderLeft: string with get, set
    abstract borderLeftColor: string with get, set
    abstract borderLeftStyle: string with get, set
    abstract borderLeftWidth: string with get, set
    abstract borderRadius: string with get, set
    abstract borderRight: string with get, set
    abstract borderRightColor: string with get, set
    abstract borderRightStyle: string with get, set
    abstract borderRightWidth: string with get, set
    abstract borderSpacing: string with get, set
    abstract borderStyle: string with get, set
    abstract borderTop: string with get, set
    abstract borderTopColor: string with get, set
    abstract borderTopLeftRadius: string with get, set
    abstract borderTopRightRadius: string with get, set
    abstract borderTopStyle: string with get, set
    abstract borderTopWidth: string with get, set
    abstract borderWidth: string with get, set
    abstract bottom: string with get, set
    abstract boxShadow: string with get, set
    abstract boxSizing: string with get, set
    abstract breakAfter: string with get, set
    abstract breakBefore: string with get, set
    abstract breakInside: string with get, set
    abstract captionSide: string with get, set
    abstract clear: string with get, set
    abstract clip: string with get, set
    abstract clipPath: string with get, set
    abstract clipRule: string with get, set
    abstract color: string with get, set
    abstract colorInterpolationFilters: string with get, set
    abstract columnCount: obj with get, set
    abstract columnFill: string with get, set
    abstract columnGap: obj with get, set
    abstract columnRule: string with get, set
    abstract columnRuleColor: obj with get, set
    abstract columnRuleStyle: string with get, set
    abstract columnRuleWidth: obj with get, set
    abstract columnSpan: string with get, set
    abstract columnWidth: obj with get, set
    abstract columns: string with get, set
    abstract content: string with get, set
    abstract counterIncrement: string with get, set
    abstract counterReset: string with get, set
    abstract cssFloat: string with get, set
    abstract cssText: string with get, set
    abstract cursor: string with get, set
    abstract direction: string with get, set
    abstract display: string with get, set
    abstract dominantBaseline: string with get, set
    abstract emptyCells: string with get, set
    abstract enableBackground: string with get, set
    abstract fill: string with get, set
    abstract fillOpacity: string with get, set
    abstract fillRule: string with get, set
    abstract filter: string with get, set
    abstract flex: string with get, set
    abstract flexBasis: string with get, set
    abstract flexDirection: string with get, set
    abstract flexFlow: string with get, set
    abstract flexGrow: string with get, set
    abstract flexShrink: string with get, set
    abstract flexWrap: string with get, set
    abstract floodColor: string with get, set
    abstract floodOpacity: string with get, set
    abstract font: string with get, set
    abstract fontFamily: string with get, set
    abstract fontFeatureSettings: string with get, set
    abstract fontSize: string with get, set
    abstract fontSizeAdjust: string with get, set
    abstract fontStretch: string with get, set
    abstract fontStyle: string with get, set
    abstract fontVariant: string with get, set
    abstract fontWeight: string with get, set
    abstract glyphOrientationHorizontal: string with get, set
    abstract glyphOrientationVertical: string with get, set
    abstract height: string with get, set
    abstract imeMode: string with get, set
    abstract justifyContent: string with get, set
    abstract kerning: string with get, set
    abstract left: string with get, set
    abstract length: float with get, set
    abstract letterSpacing: string with get, set
    abstract lightingColor: string with get, set
    abstract lineHeight: string with get, set
    abstract listStyle: string with get, set
    abstract listStyleImage: string with get, set
    abstract listStylePosition: string with get, set
    abstract listStyleType: string with get, set
    abstract margin: string with get, set
    abstract marginBottom: string with get, set
    abstract marginLeft: string with get, set
    abstract marginRight: string with get, set
    abstract marginTop: string with get, set
    abstract marker: string with get, set
    abstract markerEnd: string with get, set
    abstract markerMid: string with get, set
    abstract markerStart: string with get, set
    abstract mask: string with get, set
    abstract maxHeight: string with get, set
    abstract maxWidth: string with get, set
    abstract minHeight: string with get, set
    abstract minWidth: string with get, set
    abstract msContentZoomChaining: string with get, set
    abstract msContentZoomLimit: string with get, set
    abstract msContentZoomLimitMax: obj with get, set
    abstract msContentZoomLimitMin: obj with get, set
    abstract msContentZoomSnap: string with get, set
    abstract msContentZoomSnapPoints: string with get, set
    abstract msContentZoomSnapType: string with get, set
    abstract msContentZooming: string with get, set
    abstract msFlowFrom: string with get, set
    abstract msFlowInto: string with get, set
    abstract msFontFeatureSettings: string with get, set
    abstract msGridColumn: obj with get, set
    abstract msGridColumnAlign: string with get, set
    abstract msGridColumnSpan: obj with get, set
    abstract msGridColumns: string with get, set
    abstract msGridRow: obj with get, set
    abstract msGridRowAlign: string with get, set
    abstract msGridRowSpan: obj with get, set
    abstract msGridRows: string with get, set
    abstract msHighContrastAdjust: string with get, set
    abstract msHyphenateLimitChars: string with get, set
    abstract msHyphenateLimitLines: obj with get, set
    abstract msHyphenateLimitZone: obj with get, set
    abstract msHyphens: string with get, set
    abstract msImeAlign: string with get, set
    abstract msOverflowStyle: string with get, set
    abstract msScrollChaining: string with get, set
    abstract msScrollLimit: string with get, set
    abstract msScrollLimitXMax: obj with get, set
    abstract msScrollLimitXMin: obj with get, set
    abstract msScrollLimitYMax: obj with get, set
    abstract msScrollLimitYMin: obj with get, set
    abstract msScrollRails: string with get, set
    abstract msScrollSnapPointsX: string with get, set
    abstract msScrollSnapPointsY: string with get, set
    abstract msScrollSnapType: string with get, set
    abstract msScrollSnapX: string with get, set
    abstract msScrollSnapY: string with get, set
    abstract msScrollTranslation: string with get, set
    abstract msTextCombineHorizontal: string with get, set
    abstract msTextSizeAdjust: obj with get, set
    abstract msTouchAction: string with get, set
    abstract msTouchSelect: string with get, set
    abstract msUserSelect: string with get, set
    abstract msWrapFlow: string with get, set
    abstract msWrapMargin: obj with get, set
    abstract msWrapThrough: string with get, set
    abstract opacity: string with get, set
    abstract order: string with get, set
    abstract orphans: string with get, set
    abstract outline: string with get, set
    abstract outlineColor: string with get, set
    abstract outlineStyle: string with get, set
    abstract outlineWidth: string with get, set
    abstract overflow: string with get, set
    abstract overflowX: string with get, set
    abstract overflowY: string with get, set
    abstract padding: string with get, set
    abstract paddingBottom: string with get, set
    abstract paddingLeft: string with get, set
    abstract paddingRight: string with get, set
    abstract paddingTop: string with get, set
    abstract pageBreakAfter: string with get, set
    abstract pageBreakBefore: string with get, set
    abstract pageBreakInside: string with get, set
    abstract parentRule: CSSRule with get, set
    abstract perspective: string with get, set
    abstract perspectiveOrigin: string with get, set
    abstract pointerEvents: string with get, set
    abstract position: string with get, set
    abstract quotes: string with get, set
    abstract right: string with get, set
    abstract rubyAlign: string with get, set
    abstract rubyOverhang: string with get, set
    abstract rubyPosition: string with get, set
    abstract stopColor: string with get, set
    abstract stopOpacity: string with get, set
    abstract stroke: string with get, set
    abstract strokeDasharray: string with get, set
    abstract strokeDashoffset: string with get, set
    abstract strokeLinecap: string with get, set
    abstract strokeLinejoin: string with get, set
    abstract strokeMiterlimit: string with get, set
    abstract strokeOpacity: string with get, set
    abstract strokeWidth: string with get, set
    abstract tableLayout: string with get, set
    abstract textAlign: string with get, set
    abstract textAlignLast: string with get, set
    abstract textAnchor: string with get, set
    abstract textDecoration: string with get, set
    abstract textFillColor: string with get, set
    abstract textIndent: string with get, set
    abstract textJustify: string with get, set
    abstract textKashida: string with get, set
    abstract textKashidaSpace: string with get, set
    abstract textOverflow: string with get, set
    abstract textShadow: string with get, set
    abstract textTransform: string with get, set
    abstract textUnderlinePosition: string with get, set
    abstract top: string with get, set
    abstract touchAction: string with get, set
    abstract transform: string with get, set
    abstract transformOrigin: string with get, set
    abstract transformStyle: string with get, set
    abstract transition: string with get, set
    abstract transitionDelay: string with get, set
    abstract transitionDuration: string with get, set
    abstract transitionProperty: string with get, set
    abstract transitionTimingFunction: string with get, set
    abstract unicodeBidi: string with get, set
    abstract verticalAlign: string with get, set
    abstract visibility: string with get, set
    abstract webkitAlignContent: string with get, set
    abstract webkitAlignItems: string with get, set
    abstract webkitAlignSelf: string with get, set
    abstract webkitAnimation: string with get, set
    abstract webkitAnimationDelay: string with get, set
    abstract webkitAnimationDirection: string with get, set
    abstract webkitAnimationDuration: string with get, set
    abstract webkitAnimationFillMode: string with get, set
    abstract webkitAnimationIterationCount: string with get, set
    abstract webkitAnimationName: string with get, set
    abstract webkitAnimationPlayState: string with get, set
    abstract webkitAnimationTimingFunction: string with get, set
    abstract webkitAppearance: string with get, set
    abstract webkitBackfaceVisibility: string with get, set
    abstract webkitBackground: string with get, set
    abstract webkitBackgroundAttachment: string with get, set
    abstract webkitBackgroundClip: string with get, set
    abstract webkitBackgroundColor: string with get, set
    abstract webkitBackgroundImage: string with get, set
    abstract webkitBackgroundOrigin: string with get, set
    abstract webkitBackgroundPosition: string with get, set
    abstract webkitBackgroundPositionX: string with get, set
    abstract webkitBackgroundPositionY: string with get, set
    abstract webkitBackgroundRepeat: string with get, set
    abstract webkitBackgroundSize: string with get, set
    abstract webkitBorderBottomLeftRadius: string with get, set
    abstract webkitBorderBottomRightRadius: string with get, set
    abstract webkitBorderImage: string with get, set
    abstract webkitBorderImageOutset: string with get, set
    abstract webkitBorderImageRepeat: string with get, set
    abstract webkitBorderImageSlice: string with get, set
    abstract webkitBorderImageSource: string with get, set
    abstract webkitBorderImageWidth: string with get, set
    abstract webkitBorderRadius: string with get, set
    abstract webkitBorderTopLeftRadius: string with get, set
    abstract webkitBorderTopRightRadius: string with get, set
    abstract webkitBoxAlign: string with get, set
    abstract webkitBoxDirection: string with get, set
    abstract webkitBoxFlex: string with get, set
    abstract webkitBoxOrdinalGroup: string with get, set
    abstract webkitBoxOrient: string with get, set
    abstract webkitBoxPack: string with get, set
    abstract webkitBoxSizing: string with get, set
    abstract webkitColumnBreakAfter: string with get, set
    abstract webkitColumnBreakBefore: string with get, set
    abstract webkitColumnBreakInside: string with get, set
    abstract webkitColumnCount: obj with get, set
    abstract webkitColumnGap: obj with get, set
    abstract webkitColumnRule: string with get, set
    abstract webkitColumnRuleColor: obj with get, set
    abstract webkitColumnRuleStyle: string with get, set
    abstract webkitColumnRuleWidth: obj with get, set
    abstract webkitColumnSpan: string with get, set
    abstract webkitColumnWidth: obj with get, set
    abstract webkitColumns: string with get, set
    abstract webkitFilter: string with get, set
    abstract webkitFlex: string with get, set
    abstract webkitFlexBasis: string with get, set
    abstract webkitFlexDirection: string with get, set
    abstract webkitFlexFlow: string with get, set
    abstract webkitFlexGrow: string with get, set
    abstract webkitFlexShrink: string with get, set
    abstract webkitFlexWrap: string with get, set
    abstract webkitJustifyContent: string with get, set
    abstract webkitOrder: string with get, set
    abstract webkitPerspective: string with get, set
    abstract webkitPerspectiveOrigin: string with get, set
    abstract webkitTapHighlightColor: string with get, set
    abstract webkitTextFillColor: string with get, set
    abstract webkitTextSizeAdjust: obj with get, set
    abstract webkitTransform: string with get, set
    abstract webkitTransformOrigin: string with get, set
    abstract webkitTransformStyle: string with get, set
    abstract webkitTransition: string with get, set
    abstract webkitTransitionDelay: string with get, set
    abstract webkitTransitionDuration: string with get, set
    abstract webkitTransitionProperty: string with get, set
    abstract webkitTransitionTimingFunction: string with get, set
    abstract webkitUserSelect: string with get, set
    abstract webkitWritingMode: string with get, set
    abstract whiteSpace: string with get, set
    abstract widows: string with get, set
    abstract width: string with get, set
    abstract wordBreak: string with get, set
    abstract wordSpacing: string with get, set
    abstract wordWrap: string with get, set
    abstract writingMode: string with get, set
    abstract zIndex: string with get, set
    abstract zoom: string with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract getPropertyPriority: propertyName: string -> string
    abstract getPropertyValue: propertyName: string -> string
    abstract item: index: float -> string
    abstract removeProperty: propertyName: string -> string
    abstract setProperty: propertyName: string * value: string * ?priority: string -> unit

type CSSStyleDeclarationType =
    abstract prototype: CSSStyleDeclaration with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleDeclaration

type [<AllowNullLiteral; Global>] CSSStyleRule =
    inherit CSSRule
    abstract readOnly: bool with get, set
    abstract selectorText: string with get, set
    abstract style: CSSStyleDeclaration with get, set

type CSSStyleRuleType =
    abstract prototype: CSSStyleRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleRule

type [<AllowNullLiteral; Global>] CSSStyleSheet =
    inherit StyleSheet
    abstract cssRules: CSSRuleList with get, set
    abstract cssText: string with get, set
    abstract href: string with get, set
    abstract id: string with get, set
    abstract imports: StyleSheetList with get, set
    abstract isAlternate: bool with get, set
    abstract isPrefAlternate: bool with get, set
    abstract ownerRule: CSSRule with get, set
    abstract owningElement: Element with get, set
    abstract pages: StyleSheetPageList with get, set
    abstract readOnly: bool with get, set
    abstract rules: CSSRuleList with get, set
    abstract addImport: bstrURL: string * ?lIndex: float -> float
    abstract addPageRule: bstrSelector: string * bstrStyle: string * ?lIndex: float -> float
    abstract addRule: bstrSelector: string * ?bstrStyle: string * ?lIndex: float -> float
    abstract deleteRule: ?index: float -> unit
    abstract insertRule: rule: string * ?index: float -> float
    abstract removeImport: lIndex: float -> unit
    abstract removeRule: lIndex: float -> unit
    /// <summary>
    /// replaces the content of the stylesheet with the content passed into it.
    /// The method returns a promise that resolves with a CSSStyleSheet object.
    /// </summary>
    /// <remarks>
    /// The replaceSync() and CSSStyleSheet.replace() methods can only be used on a stylesheet created with the CSSStyleSheet() constructor.
    /// </remarks>
    abstract replace: string -> JS.Promise<CSSStyleSheet>
    /// <summary>
    /// synchronously replaces the content of the stylesheet with the content passed into it.
    /// </summary>
    /// <remarks>
    /// The replaceSync() and CSSStyleSheet.replace() methods can only be used on a stylesheet created with the CSSStyleSheet() constructor.
    /// </remarks>
    abstract replaceSync: string -> unit

type CSSStyleSheetType =
    abstract prototype: CSSStyleSheet with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleSheet

type [<AllowNullLiteral; Global>] CSSSupportsRule =
    inherit CSSConditionRule

type CSSSupportsRuleType =
    abstract prototype: CSSSupportsRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSSupportsRule

type [<AllowNullLiteral; Global>] StyleMedia =
    abstract ``type``: string with get, set
    abstract matchMedium: mediaquery: string -> bool

type StyleMediaType =
    abstract prototype: StyleMedia with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleMedia

type [<AllowNullLiteral; Global>] StyleSheet =
    abstract disabled: bool with get, set
    abstract href: string with get, set
    // TODO
    // abstract media: MediaList with get, set
    abstract ownerNode: Node with get, set
    abstract parentStyleSheet: StyleSheet with get, set
    abstract title: string with get, set
    abstract ``type``: string with get, set

type StyleSheetType =
    abstract prototype: StyleSheet with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheet

type [<AllowNullLiteral; Global>] StyleSheetList =
    abstract length: float with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> StyleSheet with get, set
    abstract item: ?index: float -> StyleSheet

type StyleSheetListType =
    abstract prototype: StyleSheetList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheetList

type [<AllowNullLiteral; Global>] StyleSheetPageList =
    abstract length: float with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> CSSPageRule with get, set
    abstract item: index: float -> CSSPageRule

type StyleSheetPageListType =
    abstract prototype: StyleSheetPageList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheetPageList