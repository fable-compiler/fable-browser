namespace Fable.Import
open Fable.Import

[<System.Obsolete("Use Browser")>]
module Browser =
    /// Use Browser
    let obsolete<'T> : 'T = failwith "Use Browser"

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Dom =
    // Make console globally accessible
    let [<Global>] console: JS.Console = jsNative

    let [<Global>] DOMException: DOMExceptionType = jsNative

    let [<Global>] File: FileType = jsNative
    let [<Global>] FileReader: FileReaderType = jsNative

    let [<Global>] history: History = jsNative

    let [<Global>] window: Window = jsNative
    let [<Global>] document: Document = jsNative
    let [<Global>] self: Window = jsNative

    let [<Global>] Attr: AttrType = jsNative
    let [<Global>] CDATASection: CDATASectionType = jsNative
    let [<Global>] CanvasGradient: CanvasGradientType = jsNative
    let [<Global>] CanvasPattern: CanvasPatternType = jsNative
    let [<Global>] CanvasRenderingContext2D: CanvasRenderingContext2DType = jsNative
    let [<Global>] ClientRect: ClientRectType = jsNative
    let [<Global>] DOMImplementation: DOMImplementationType = jsNative
    let [<Global>] DOMStringList: DOMStringListType = jsNative
    let [<Global>] DOMStringMap: DOMStringMapType = jsNative
    let [<Global>] DOMTokenList: DOMTokenListType = jsNative
    let [<Global>] Document: DocumentType = jsNative
    let [<Global>] DocumentFragment: DocumentFragmentType = jsNative
    let [<Global>] DocumentType: DocumentTypeType = jsNative
    let [<Global>] Element: ElementType = jsNative
    let [<Global>] HTMLAllCollection: HTMLAllCollectionType = jsNative
    let [<Global>] HTMLAnchorElement: HTMLAnchorElementType = jsNative
    let [<Global>] HTMLAreaElement: HTMLAreaElementType = jsNative
    let [<Global>] HTMLAreasCollection: HTMLAreasCollectionType = jsNative
    let [<Global>] HTMLAudioElement: HTMLAudioElementType = jsNative
    let [<Global>] HTMLBRElement: HTMLBRElementType = jsNative
    let [<Global>] HTMLBaseElement: HTMLBaseElementType = jsNative
    let [<Global>] HTMLBlockElement: HTMLBlockElementType = jsNative
    let [<Global>] HTMLBodyElement: HTMLBodyElementType = jsNative
    let [<Global>] HTMLButtonElement: HTMLButtonElementType = jsNative
    let [<Global>] HTMLCanvasElement: HTMLCanvasElementType = jsNative
    let [<Global>] HTMLCollection: HTMLCollectionType = jsNative
    let [<Global>] HTMLDDElement: HTMLDDElementType = jsNative
    let [<Global>] HTMLDListElement: HTMLDListElementType = jsNative
    let [<Global>] HTMLDTElement: HTMLDTElementType = jsNative
    let [<Global>] HTMLDataListElement: HTMLDataListElementType = jsNative
    let [<Global>] HTMLDirectoryElement: HTMLDirectoryElementType = jsNative
    let [<Global>] HTMLDivElement: HTMLDivElementType = jsNative
    let [<Global>] HTMLDocument: HTMLDocumentType = jsNative
    let [<Global>] HTMLElement: HTMLElementType = jsNative
    let [<Global>] HTMLEmbedElement: HTMLEmbedElementType = jsNative
    let [<Global>] HTMLFieldSetElement: HTMLFieldSetElementType = jsNative
    let [<Global>] HTMLFontElement: HTMLFontElementType = jsNative
    let [<Global>] HTMLFormElement: HTMLFormElementType = jsNative
    let [<Global>] HTMLFrameElement: HTMLFrameElementType = jsNative
    let [<Global>] HTMLHRElement: HTMLHRElementType = jsNative
    let [<Global>] HTMLHeadElement: HTMLHeadElementType = jsNative
    let [<Global>] HTMLHeadingElement: HTMLHeadingElementType = jsNative
    let [<Global>] HTMLHtmlElement: HTMLHtmlElementType = jsNative
    let [<Global>] HTMLIFrameElement: HTMLIFrameElementType = jsNative
    let [<Global>] HTMLImageElement: ImageType = jsNative
    let [<Global>] HTMLInputElement: HTMLInputElementType = jsNative
    let [<Global>] HTMLLIElement: HTMLLIElementType = jsNative
    let [<Global>] HTMLLabelElement: HTMLLabelElementType = jsNative
    let [<Global>] HTMLLegendElement: HTMLLegendElementType = jsNative
    let [<Global>] HTMLLinkElement: HTMLLinkElementType = jsNative
    let [<Global>] HTMLMapElement: HTMLMapElementType = jsNative
    let [<Global>] HTMLMediaElement: HTMLMediaElementType = jsNative
    let [<Global>] HTMLMenuElement: HTMLMenuElementType = jsNative
    let [<Global>] HTMLMetaElement: HTMLMetaElementType = jsNative
    let [<Global>] HTMLModElement: HTMLModElementType = jsNative
    let [<Global>] HTMLNextIdElement: HTMLNextIdElementType = jsNative
    let [<Global>] HTMLOListElement: HTMLOListElementType = jsNative
    let [<Global>] HTMLObjectElement: HTMLObjectElementType = jsNative
    let [<Global>] HTMLOptGroupElement: HTMLOptGroupElementType = jsNative
    let [<Global>] HTMLOptionElement: HTMLOptionElementType = jsNative
    let [<Global>] HTMLParagraphElement: HTMLParagraphElementType = jsNative
    let [<Global>] HTMLParamElement: HTMLParamElementType = jsNative
    let [<Global>] HTMLPhraseElement: HTMLPhraseElementType = jsNative
    let [<Global>] HTMLPreElement: HTMLPreElementType = jsNative
    let [<Global>] HTMLProgressElement: HTMLProgressElementType = jsNative
    let [<Global>] HTMLQuoteElement: HTMLQuoteElementType = jsNative
    let [<Global>] HTMLScriptElement: HTMLScriptElementType = jsNative
    let [<Global>] HTMLSelectElement: HTMLSelectElementType = jsNative
    let [<Global>] HTMLSourceElement: HTMLSourceElementType = jsNative
    let [<Global>] HTMLSpanElement: HTMLSpanElementType = jsNative
    let [<Global>] HTMLStyleElement: HTMLStyleElementType = jsNative
    let [<Global>] HTMLTableCaptionElement: HTMLTableCaptionElementType = jsNative
    let [<Global>] HTMLTableCellElement: HTMLTableCellElementType = jsNative
    let [<Global>] HTMLTableColElement: HTMLTableColElementType = jsNative
    let [<Global>] HTMLTableDataCellElement: HTMLTableDataCellElementType = jsNative
    let [<Global>] HTMLTableElement: HTMLTableElementType = jsNative
    let [<Global>] HTMLTableHeaderCellElement: HTMLTableHeaderCellElementType = jsNative
    let [<Global>] HTMLTableRowElement: HTMLTableRowElementType = jsNative
    let [<Global>] HTMLTableSectionElement: HTMLTableSectionElementType = jsNative
    let [<Global>] HTMLTextAreaElement: HTMLTextAreaElementType = jsNative
    let [<Global>] HTMLTitleElement: HTMLTitleElementType = jsNative
    let [<Global>] HTMLTrackElement: HTMLTrackElementType = jsNative
    let [<Global>] HTMLUListElement: HTMLUListElementType = jsNative
    let [<Global>] HTMLUnknownElement: HTMLUnknownElementType = jsNative
    let [<Global>] HTMLVideoElement: HTMLVideoElementType = jsNative
    let [<Global>] ImageData: ImageDataType = jsNative
    let [<Global>] NamedNodeMap: NamedNodeMapType = jsNative
    let [<Global>] Node: NodeType = jsNative
    let [<Global>] NodeFilter: NodeFilterType = jsNative
    let [<Global>] NodeIterator: NodeIteratorType = jsNative
    let [<Global>] NodeList: NodeListType = jsNative
    let [<Global>] Range: RangeType = jsNative
    let [<Global>] Selection: SelectionType = jsNative
    let [<Global>] SourceBuffer: SourceBufferType = jsNative
    let [<Global>] SourceBufferList: SourceBufferListType = jsNative
    let [<Global>] Worker: WorkerType = jsNative
    let [<Global>] XMLDocument: XMLDocumentType = jsNative
