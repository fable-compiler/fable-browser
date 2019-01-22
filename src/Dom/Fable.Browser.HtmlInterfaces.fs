namespace Fable.Browser

open System
open Fable.Core

type [<AllowNullLiteral>] GetSVGDocument =
    abstract getSVGDocument: unit -> Document

and [<AllowNullLiteral>] GlobalEventHandlers =
    abstract onpointercancel: (PointerEvent -> 'Out) with get, set
    abstract onpointerdown: (PointerEvent -> 'Out) with get, set
    abstract onpointerenter: (PointerEvent -> 'Out) with get, set
    abstract onpointerleave: (PointerEvent -> 'Out) with get, set
    abstract onpointermove: (PointerEvent -> 'Out) with get, set
    abstract onpointerout: (PointerEvent -> 'Out) with get, set
    abstract onpointerover: (PointerEvent -> 'Out) with get, set
    abstract onpointerup: (PointerEvent -> 'Out) with get, set
    abstract onwheel: (WheelEvent -> 'Out) with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLAllCollection =
    inherit HTMLCollection
    /// Sets or retrieves the shape of the object.
    /// Retrieves a select object or an object from an options collection.
    abstract namedItem: name: string -> Element

and [<AllowNullLiteral>] HTMLAllCollectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAllCollection

and [<AllowNullLiteral>] HTMLAnchorElement =
    inherit HTMLElement
    abstract Methods: string with get, set
    /// Sets or retrieves the character set used to encode the object.
    abstract charset: string with get, set
    /// Sets or retrieves the coordinates of the object.
    abstract coords: string with get, set
    /// Contains the anchor portion of the URL including the hash sign (#).
    abstract hash: string with get, set
    /// Contains the hostname and port values of the URL.
    abstract host: string with get, set
    /// Contains the hostname of a URL.
    /// Sets or retrieves the hostname and port number of the location or URL.
    abstract hostname: string with get, set
    /// Sets or retrieves a destination URL or an anchor point.
    abstract href: string with get, set
    /// Sets or retrieves the language code of the object.
    /// Sets or retrieves a destination URL or an anchor point.
    abstract hreflang: string with get, set
    abstract mimeType: string with get, set
    /// Sets or retrieves the shape of the object.
    abstract name: string with get, set
    /// Sets or retrieves the name of the object.
    abstract nameProp: string with get, set
    /// Contains the pathname of the URL.
    abstract pathname: string with get, set
    /// Sets or retrieves the port number associated with a URL.
    abstract port: string with get, set
    /// Contains the protocol of the URL.
    abstract protocol: string with get, set
    /// Sets or retrieves the protocol portion of a URL.
    abstract protocolLong: string with get, set
    /// Sets or retrieves the relationship between the object and the destination of the link.
    abstract rel: string with get, set
    /// Sets or retrieves the relationship between the object and the destination of the link.
    abstract rev: string with get, set
    /// Sets or retrieves the substring of the href property that follows the question mark.
    abstract search: string with get, set
    /// Sets or retrieves the shape of the object.
    abstract shape: string with get, set
    /// Sets or retrieves the window or frame at which to target content.
    abstract target: string with get, set
    /// Retrieves or sets the text of the object as a string.
    abstract text: string with get, set
    /// Returns the content type of the object.
    abstract ``type``: string with get, set
    abstract urn: string with get, set
    /// Returns a string representation of an object.
    abstract toString: unit -> string

and [<AllowNullLiteral>] HTMLAnchorElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAnchorElement

and [<AllowNullLiteral>] HTMLAreaElement =
    inherit HTMLElement
    /// Sets or retrieves a text alternative to the graphic.
    abstract alt: string with get, set
    /// Sets or retrieves the coordinates of the object.
    abstract coords: string with get, set
    /// Sets or retrieves the subsection of the href property that follows the number sign (#).
    abstract hash: string with get, set
    abstract host: string with get, set
    /// Sets or retrieves the host name part of the location or URL.
    abstract hostname: string with get, set
    /// Gets or sets the baseline URL on which relative links are based.
    abstract href: string with get, set
    /// Sets or gets whether clicks in this region cause action.
    abstract noHref: bool with get, set
    /// Sets or retrieves the file name or path specified by the object.
    abstract pathname: string with get, set
    /// Sets or retrieves the port number associated with a URL.
    abstract port: string with get, set
    abstract protocol: string with get, set
    /// Sets or retrieves the relationship between the object and the destination of the link.
    abstract rel: string with get, set
    /// Sets or retrieves the substring of the href property that follows the question mark.
    abstract search: string with get, set
    /// Sets or retrieves the shape of the object.
    abstract shape: string with get, set
    /// Sets or retrieves the window or frame at which to target content.
    abstract target: string with get, set
    /// Returns a string representation of an object.
    abstract toString: unit -> string

and [<AllowNullLiteral>] HTMLAreaElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAreaElement

and [<AllowNullLiteral>] HTMLAreasCollection =
    inherit HTMLCollection
    /// <summary>Adds an element to the areas, controlRange, or options collection.</summary>
    /// <param name="element">Variant of type Number that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
    /// <param name="before">Variant of type Object that specifies an element to insert before, or null to append the object to the collection.</param>
    abstract add: element: HTMLElement * ?before: U2<HTMLElement, float> -> unit
    /// <summary>Removes an element from the collection.</summary>
    /// <param name="index">Number that specifies the zero-based index of the element to remove from the collection.</param>
    abstract remove: ?index: float -> unit

and [<AllowNullLiteral>] HTMLAreasCollectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAreasCollection

and [<AllowNullLiteral>] HTMLAudioElement =
    inherit HTMLMediaElement

and [<AllowNullLiteral>] HTMLAudioElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAudioElement

and [<AllowNullLiteral>] HTMLBRElement =
    inherit HTMLElement
    /// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
    abstract clear: string with get, set

and [<AllowNullLiteral>] HTMLBRElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBRElement

and [<AllowNullLiteral>] HTMLBaseElement =
    inherit HTMLElement
    /// Sets or retrieves a destination URL or an anchor point.
    abstract href: string with get, set
    /// Sets or retrieves the window or frame at which to target content.
    abstract target: string with get, set

and [<AllowNullLiteral>] HTMLBaseElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBaseElement

and [<AllowNullLiteral>] HTMLBlockElement =
    inherit HTMLElement
    /// Sets or retrieves reference information about the object.
    abstract cite: string with get, set
    abstract clear: string with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set

and [<AllowNullLiteral>] HTMLBlockElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBlockElement

and [<AllowNullLiteral>] HTMLBodyElement =
    inherit HTMLElement
    abstract aLink: obj with get, set
    abstract background: string with get, set
    abstract bgColor: obj with get, set
    abstract bgProperties: string with get, set
    abstract link: obj with get, set
    /// Sets or retrieves whether the browser automatically performs wordwrap.
    abstract noWrap: bool with get, set
    abstract onafterprint: (Event -> 'Out) with get, set
    abstract onbeforeprint: (Event -> 'Out) with get, set
    abstract onbeforeunload: (BeforeUnloadEvent -> 'Out) with get, set
    abstract onblur: (FocusEvent -> 'Out) with get, set
    abstract onerror: (Event -> 'Out) with get, set
    abstract onfocus: (FocusEvent -> 'Out) with get, set
    abstract onhashchange: (HashChangeEvent -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract onmessage: (MessageEvent -> 'Out) with get, set
    abstract onoffline: (Event -> 'Out) with get, set
    abstract ononline: (Event -> 'Out) with get, set
    abstract onorientationchange: (Event -> 'Out) with get, set
    abstract onpagehide: (PageTransitionEvent -> 'Out) with get, set
    abstract onpageshow: (PageTransitionEvent -> 'Out) with get, set
    abstract onpopstate: (PopStateEvent -> 'Out) with get, set
    abstract onresize: (UIEvent -> 'Out) with get, set
    abstract onstorage: (StorageEvent -> 'Out) with get, set
    abstract onunload: (Event -> 'Out) with get, set
    /// Sets or retrieves the text string specified by the option tag.
    abstract text: obj with get, set
    abstract vLink: obj with get, set
    /// <param name="before">Variant of type Object that specifies an element to insert before, or null to append the object to the collection.</param>
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLBodyElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBodyElement

and [<AllowNullLiteral>] HTMLButtonElement =
    inherit HTMLElement
    /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
    abstract autofocus: bool with get, set
    abstract disabled: bool with get, set
    /// Retrieves a reference to the form that the object is embedded in.
    abstract form: HTMLFormElement with get, set
    /// Overrides the action attribute (where the data on a form is sent) on the parent form element.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formAction: string with get, set
    /// Used to override the encoding (formEnctype attribute) specified on the form element.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formEnctype: string with get, set
    /// Overrides the submit method attribute previously specified on a form element.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formMethod: string with get, set
    /// Overrides any validation or required attributes on a form or form elements to allow it to be submitted without validation. This can be used to create a "save draft"-type submit option.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formNoValidate: string with get, set
    /// Overrides the target attribute on a form element.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formTarget: string with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set
    /// Sets or retrieves the value indicating whether the control is selected.
    abstract status: obj with get, set
    /// Returns the content type of the object.
    abstract ``type``: string with get, set
    /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
    abstract validationMessage: string with get, set
    /// Returns a  ValidityState object that represents the validity states of an element.
    abstract validity: ValidityState with get, set
    /// Sets or retrieves the default or selected value of the control.
    abstract value: string with get, set
    /// Returns whether an element will successfully validate based on forms validation rules and constraints.
    abstract willValidate: bool with get, set
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    /// <summary>Sets a custom error message that is displayed when a form is submitted.</summary>
    /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
    abstract setCustomValidity: error: string -> unit

and [<AllowNullLiteral>] HTMLButtonElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLButtonElement

and [<AllowNullLiteral>] HTMLCanvasElement =
    inherit HTMLElement
    /// Gets or sets the height of a canvas element on a document.
    abstract height: float with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set
    [<Emit("$0.getContext('2d'{{, $1}})")>]  abstract getContext_2d: ?contextAttributes: obj -> CanvasRenderingContext2D
    /// Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document. A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
    abstract getContext: contextId: string * ?contextAttributes: obj -> obj
    /// <summary>Returns the content of the current canvas as an image that you can use as a source for another canvas or an HTML element.</summary>
    /// <param name="type">The standard MIME type for the image format to return. If you do not specify this parameter, the default value is a PNG format image.</param>
    abstract toDataURL: ?``type``: string * [<ParamArray>] args: obj[] -> string
    /// Returns a blob object encoded as a Portable Network Graphics (PNG) format from a canvas image or drawing.
    abstract toBlob : (Blob -> unit) * ?mimeType:string * ?quality: float -> unit

and [<AllowNullLiteral>] Blob =
    abstract size: float with get, set
    abstract ``type``: string with get, set
    abstract slice: ?start: float * ?``end``: float * ?contentType: string -> Blob

// and [<AllowNullLiteral>] BlobType =
//     [<Emit("new $0($1...)")>] abstract Create: ?blobParts: ResizeArray<obj> * ?options: BlobPropertyBag -> Blob

and [<AllowNullLiteral>] HTMLCanvasElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLCanvasElement

and [<AllowNullLiteral>] HTMLDDElement =
    inherit HTMLElement
    /// Sets or retrieves whether the browser automatically performs wordwrap.
    abstract noWrap: bool with get, set

and [<AllowNullLiteral>] HTMLDDElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDDElement

and [<AllowNullLiteral>] HTMLDListElement =
    inherit HTMLElement
    abstract compact: bool with get, set

and [<AllowNullLiteral>] HTMLDListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDListElement

and [<AllowNullLiteral>] HTMLDTElement =
    inherit HTMLElement
    abstract noWrap: bool with get, set

and [<AllowNullLiteral>] HTMLDTElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDTElement

and [<AllowNullLiteral>] HTMLDataListElement =
    inherit HTMLElement
    abstract options: HTMLCollection with get, set

and [<AllowNullLiteral>] HTMLDataListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDataListElement

and [<AllowNullLiteral>] HTMLDirectoryElement =
    inherit HTMLElement
    abstract compact: bool with get, set

and [<AllowNullLiteral>] HTMLDirectoryElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDirectoryElement

and [<AllowNullLiteral>] HTMLDivElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract noWrap: bool with get, set

and [<AllowNullLiteral>] HTMLDivElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDivElement

and [<AllowNullLiteral>] HTMLDocument =
    inherit Document

and [<AllowNullLiteral>] HTMLDocumentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDocument

and [<AllowNullLiteral>] HTMLElement =
    inherit Element
    abstract accessKey: string with get, set
    abstract children: HTMLCollection with get, set
    abstract contentEditable: string with get, set
    /// Sets or retrieves the URL that references the data of the object.
    abstract dataset: DOMStringMap with get, set
    abstract dir: string with get, set
    abstract draggable: bool with get, set
    abstract hidden: bool with get, set
    abstract hideFocus: bool with get, set
    abstract innerHTML: string with get, set
    abstract innerText: string with get, set
    abstract isContentEditable: bool with get, set
    abstract lang: string with get, set
    abstract offsetHeight: float with get, set
    abstract offsetLeft: float with get, set
    abstract offsetParent: Element with get, set
    abstract offsetTop: float with get, set
    abstract offsetWidth: float with get, set
    abstract onabort: (Event -> 'Out) with get, set
    abstract onactivate: (UIEvent -> 'Out) with get, set
    abstract onbeforeactivate: (UIEvent -> 'Out) with get, set
    abstract onbeforecopy: (DragEvent -> 'Out) with get, set
    abstract onbeforecut: (DragEvent -> 'Out) with get, set
    abstract onbeforedeactivate: (UIEvent -> 'Out) with get, set
    abstract onbeforepaste: (DragEvent -> 'Out) with get, set
    abstract onblur: (FocusEvent -> 'Out) with get, set
    abstract oncanplay: (Event -> 'Out) with get, set
    abstract oncanplaythrough: (Event -> 'Out) with get, set
    abstract onchange: (Event -> 'Out) with get, set
    abstract onclick: (MouseEvent -> 'Out) with get, set
    abstract oncontextmenu: (PointerEvent -> 'Out) with get, set
    abstract oncopy: (DragEvent -> 'Out) with get, set
    abstract oncuechange: (Event -> 'Out) with get, set
    abstract oncut: (DragEvent -> 'Out) with get, set
    abstract ondblclick: (MouseEvent -> 'Out) with get, set
    abstract ondeactivate: (UIEvent -> 'Out) with get, set
    abstract ondrag: (DragEvent -> 'Out) with get, set
    abstract ondragend: (DragEvent -> 'Out) with get, set
    abstract ondragenter: (DragEvent -> 'Out) with get, set
    abstract ondragleave: (DragEvent -> 'Out) with get, set
    abstract ondragover: (DragEvent -> 'Out) with get, set
    abstract ondragstart: (DragEvent -> 'Out) with get, set
    abstract ondrop: (DragEvent -> 'Out) with get, set
    abstract ondurationchange: (Event -> 'Out) with get, set
    abstract onemptied: (Event -> 'Out) with get, set
    abstract onended: (Event -> 'Out) with get, set
    abstract onerror: (Event -> 'Out) with get, set
    abstract onfocus: (FocusEvent -> 'Out) with get, set
    abstract oninput: (Event -> 'Out) with get, set
    abstract onkeydown: (KeyboardEvent -> 'Out) with get, set
    abstract onkeypress: (KeyboardEvent -> 'Out) with get, set
    abstract onkeyup: (KeyboardEvent -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract onloadeddata: (Event -> 'Out) with get, set
    abstract onloadedmetadata: (Event -> 'Out) with get, set
    abstract onloadstart: (Event -> 'Out) with get, set
    abstract onmousedown: (MouseEvent -> 'Out) with get, set
    abstract onmouseenter: (MouseEvent -> 'Out) with get, set
    abstract onmouseleave: (MouseEvent -> 'Out) with get, set
    abstract onmousemove: (MouseEvent -> 'Out) with get, set
    abstract onmouseout: (MouseEvent -> 'Out) with get, set
    abstract onmouseover: (MouseEvent -> 'Out) with get, set
    abstract onmouseup: (MouseEvent -> 'Out) with get, set
    abstract onmousewheel: (MouseWheelEvent -> 'Out) with get, set
    abstract onpaste: (DragEvent -> 'Out) with get, set
    abstract onpause: (Event -> 'Out) with get, set
    abstract onplay: (Event -> 'Out) with get, set
    abstract onplaying: (Event -> 'Out) with get, set
    abstract onprogress: (ProgressEvent -> 'Out) with get, set
    abstract onratechange: (Event -> 'Out) with get, set
    abstract onreset: (Event -> 'Out) with get, set
    abstract onscroll: (UIEvent -> 'Out) with get, set
    abstract onseeked: (Event -> 'Out) with get, set
    abstract onseeking: (Event -> 'Out) with get, set
    abstract onselect: (UIEvent -> 'Out) with get, set
    abstract onselectstart: (Event -> 'Out) with get, set
    abstract onstalled: (Event -> 'Out) with get, set
    abstract onsubmit: (Event -> 'Out) with get, set
    abstract onsuspend: (Event -> 'Out) with get, set
    abstract ontimeupdate: (Event -> 'Out) with get, set
    abstract onvolumechange: (Event -> 'Out) with get, set
    abstract onwaiting: (Event -> 'Out) with get, set
    abstract outerHTML: string with get, set
    abstract outerText: string with get, set
    abstract spellcheck: bool with get, set
    // abstract style: CSSStyleDeclaration with get, set
    abstract tabIndex: float with get, set
    abstract title: string with get, set
    abstract blur: unit -> unit
    abstract click: unit -> unit
    abstract dragDrop: unit -> bool
    abstract focus: unit -> unit
    abstract insertAdjacentElement: position: string * insertedElement: Element -> Element
    abstract insertAdjacentHTML: where: string * html: string -> unit
    abstract insertAdjacentText: where: string * text: string -> unit
    abstract scrollIntoView: ?top: bool -> unit
    abstract setActive: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLElement

and [<AllowNullLiteral>] HTMLEmbedElement =
    inherit HTMLElement
    inherit GetSVGDocument
    /// Sets or retrieves the height of the object.
    abstract height: string with get, set
    abstract hidden: obj with get, set
    /// Sets or retrieves the frame name.
    abstract name: string with get, set
    /// Retrieves the palette used for the embedded document.
    abstract palette: string with get, set
    /// Retrieves the URL of the plug-in used to view an embedded document.
    abstract pluginspage: string with get, set
    abstract readyState: string with get, set
    /// Sets or retrieves a URL to be loaded by the object.
    abstract src: string with get, set
    /// Sets or retrieves the height and width units of the embed object.
    abstract units: string with get, set
    /// Sets or retrieves the width of the object.
    abstract width: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLEmbedElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLEmbedElement

and [<AllowNullLiteral>] HTMLFieldSetElement =
    inherit HTMLElement
    /// Sets or retrieves a value that indicates the table alignment.
    abstract align: string with get, set
    abstract disabled: bool with get, set
    /// Retrieves a reference to the form that the object is embedded in.
    abstract form: HTMLFormElement with get, set
    /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
    abstract validationMessage: string with get, set
    /// Returns a  ValidityState object that represents the validity states of an element.
    abstract validity: ValidityState with get, set
    /// Returns whether an element will successfully validate based on forms validation rules and constraints.
    abstract willValidate: bool with get, set
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
    abstract setCustomValidity: error: string -> unit

and [<AllowNullLiteral>] HTMLFieldSetElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFieldSetElement

and [<AllowNullLiteral>] HTMLFontElement =
    inherit HTMLElement
    /// Sets or retrieves the current typeface family.
    abstract face: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLFontElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFontElement

and [<AllowNullLiteral>] HTMLFormElement =
    inherit HTMLElement
    /// Sets or retrieves a list of character encodings for input data that must be accepted by the server processing the form.
    /// Sets or retrieves a comma-separated list of content types.
    abstract acceptCharset: string with get, set
    /// Sets or retrieves the URL to which the form content is sent for processing.
    abstract action: string with get, set
    /// Specifies whether autocomplete is applied to an editable text field.
    abstract autocomplete: string with get, set
    /// Retrieves a collection, in source order, of all controls in a given form.
    abstract elements: HTMLCollection with get, set
    /// Sets or retrieves the MIME encoding for the form.
    abstract encoding: string with get, set
    /// Sets or retrieves the encoding type for the form.
    abstract enctype: string with get, set
    /// Sets or retrieves the number of objects in a collection.
    abstract length: int
    /// Sets or retrieves how to send the form data to the server.
    abstract ``method``: string with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set
    /// Designates a form that is not validated when submitted.
    abstract noValidate: bool with get, set
    /// Sets or retrieves the window or frame at which to target content.
    abstract target: string with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> obj with get, set
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    /// <summary>Retrieves a form object or an object from an elements collection.</summary>
    /// <param name="name">Variant of type Number or String that specifies the object or collection to retrieve. If this parameter is a Number, it is the zero-based index of the object. If this parameter is a string, all objects with matching name or id properties are retrieved, and a collection is returned if more than one match is made.</param>
    /// <param name="index">Variant of type Number that specifies the zero-based index of the object to retrieve when a collection is returned.</param>
    abstract item: ?name: obj * ?index: obj -> obj
    /// Sets or retrieves the name of the object.
    /// Retrieves a select object or an object from an options collection.
    abstract namedItem: name: string -> obj
    /// Fires when the user resets a form.
    abstract reset: unit -> unit
    /// Fires when a FORM is about to be submitted.
    abstract submit: unit -> unit

and [<AllowNullLiteral>] HTMLFormElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFormElement

and [<AllowNullLiteral>] HTMLFrameElement =
    inherit HTMLElement
    inherit GetSVGDocument
    /// Specifies the properties of a border drawn around an object.
    abstract border: string with get, set
    /// Sets or retrieves the border color of the object.
    /// Specifies the properties of a border drawn around an object.
    abstract borderColor: obj with get, set
    /// Retrieves the document object of the page or frame.
    abstract contentDocument: Document with get, set
    /// Retrieves the object of the specified.
    abstract contentWindow: Window with get, set
    /// Sets or retrieves whether to display a border for the frame.
    /// Sets or retrieves the way the border frame around the table is displayed.
    abstract frameBorder: string with get, set
    /// Sets or retrieves the amount of additional space between the frames.
    abstract frameSpacing: obj with get, set
    /// Sets or retrieves the height of the object.
    abstract height: float with get, set
    /// Sets or retrieves a URI to a long description of the object.
    abstract longDesc: string with get, set
    /// Sets or retrieves the top and bottom margin heights before displaying the text in a frame.
    abstract marginHeight: string with get, set
    /// Sets or retrieves the left and right margin widths before displaying the text in a frame.
    abstract marginWidth: string with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set
    /// Sets or retrieves whether the user can resize the frame.
    abstract noResize: bool with get, set
    abstract onload: (Event -> 'Out) with get, set
    /// Sets or retrieves whether the frame can be scrolled.
    abstract scrolling: string with get, set
    abstract security: obj with get, set
    /// Sets or retrieves a URL to be loaded by the object.
    abstract src: string with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLFrameElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFrameElement

and [<AllowNullLiteral>] HTMLFrameSetElement =
    inherit HTMLElement
    /// Sets or retrieves the width of the border to draw around the object.
    abstract border: string with get, set
    /// Sets or retrieves the border color of the object.
    /// Sets or retrieves the width of the border to draw around the object.
    abstract borderColor: obj with get, set
    /// Sets or retrieves the frame widths of the object.
    abstract cols: string with get, set
    /// Sets or retrieves whether to display a border for the frame.
    abstract frameBorder: string with get, set
    /// Sets or retrieves the amount of additional space between the frames.
    abstract frameSpacing: obj with get, set
    /// Sets or retrieves the value specified in the content attribute of the meta object.
    abstract name: string with get, set
    abstract onafterprint: (Event -> 'Out) with get, set
    abstract onbeforeprint: (Event -> 'Out) with get, set
    abstract onbeforeunload: (BeforeUnloadEvent -> 'Out) with get, set
    abstract onblur: (FocusEvent -> 'Out) with get, set
    abstract onerror: (Event -> 'Out) with get, set
    abstract onfocus: (FocusEvent -> 'Out) with get, set
    abstract onhashchange: (HashChangeEvent -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract onmessage: (MessageEvent -> 'Out) with get, set
    abstract onoffline: (Event -> 'Out) with get, set
    abstract ononline: (Event -> 'Out) with get, set
    abstract onorientationchange: (Event -> 'Out) with get, set
    abstract onpagehide: (PageTransitionEvent -> 'Out) with get, set
    abstract onpageshow: (PageTransitionEvent -> 'Out) with get, set
    abstract onresize: (UIEvent -> 'Out) with get, set
    abstract onstorage: (StorageEvent -> 'Out) with get, set
    abstract onunload: (Event -> 'Out) with get, set
    /// Sets or retrieves the frame heights of the object.
    abstract rows: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLFrameSetElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFrameSetElement

and [<AllowNullLiteral>] HTMLHRElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    /// Sets or retrieves whether the horizontal rule is drawn with 3-D shading.
    abstract noShade: bool with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLHRElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHRElement

and [<AllowNullLiteral>] HTMLHeadElement =
    inherit HTMLElement
    abstract profile: string with get, set

and [<AllowNullLiteral>] HTMLHeadElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHeadElement

and [<AllowNullLiteral>] HTMLHeadingElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract clear: string with get, set

and [<AllowNullLiteral>] HTMLHeadingElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHeadingElement

and [<AllowNullLiteral>] HTMLHtmlElement =
    inherit HTMLElement
    /// Sets or retrieves the DTD version that governs the current document.
    abstract version: string with get, set

and [<AllowNullLiteral>] HTMLHtmlElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHtmlElement

and [<AllowNullLiteral>] HTMLIFrameElement =
    inherit HTMLElement
    inherit GetSVGDocument
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract allowFullscreen: bool with get, set
    abstract border: string with get, set
    /// Retrieves the document object of the page or frame.
    abstract contentDocument: Document with get, set
    /// Retrieves the object of the specified.
    abstract contentWindow: Window with get, set
    /// Sets or retrieves whether to display a border for the frame.
    abstract frameBorder: string with get, set
    /// Sets or retrieves the amount of additional space between the frames.
    abstract frameSpacing: obj with get, set
    /// Sets or retrieves the height of the object.
    abstract height: string with get, set
    /// Sets or retrieves the width of the border to draw around the object.
    abstract hspace: float with get, set
    /// Sets or retrieves a URI to a long description of the object.
    abstract longDesc: string with get, set
    /// Sets or retrieves the top and bottom margin heights before displaying the text in a frame.
    abstract marginHeight: string with get, set
    /// Sets or retrieves the left and right margin widths before displaying the text in a frame.
    abstract marginWidth: string with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set
    /// Sets or retrieves whether the user can resize the frame.
    abstract noResize: bool with get, set
    abstract onload: (Event -> 'Out) with get, set
    // abstract sandbox: DOMSettableTokenList with get, set
    /// Sets or retrieves whether the frame can be scrolled.
    abstract scrolling: string with get, set
    abstract security: obj with get, set
    /// Sets or retrieves a URL to be loaded by the object.
    abstract src: string with get, set
    /// Sets or retrieves the vertical margin for the object.
    abstract vspace: float with get, set
    /// Sets or retrieves the width of the object.
    abstract width: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLIFrameElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLIFrameElement

and [<AllowNullLiteral>] HTMLImageElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    /// Sets or retrieves a text alternative to the graphic.
    abstract alt: string with get, set
    abstract border: string with get, set
    /// Retrieves whether the object is fully loaded.
    abstract complete: bool with get, set
    abstract crossOrigin: string with get, set
    /// Gets the address or URL of the current media resource that is selected by IHTMLMediaElement.
    abstract currentSrc: string with get, set
    /// Sets or retrieves the height of the object.
    abstract height: float with get, set
    /// Sets or retrieves the width of the border to draw around the object.
    abstract hspace: float with get, set
    /// Sets or retrieves whether the image is a server-side image map.
    abstract isMap: bool with get, set
    /// Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
    abstract longDesc: string with get, set
    /// Sets or retrieves the name of an input parameter for an element.
    abstract name: string with get, set
    /// The original height of the image resource before sizing.
    abstract naturalHeight: float with get, set
    /// The original width of the image resource before sizing.
    abstract naturalWidth: float with get, set
    /// The address or URL of the a media resource that is to be considered.
    abstract src: string with get, set
    /// The address or URL of the a media resource that is to be considered.
    abstract srcset: string with get, set
    /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
    abstract useMap: string with get, set
    /// Sets or retrieves the vertical margin for the object.
    abstract vspace: float with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] HTMLImageElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLImageElement
    abstract create: unit -> HTMLImageElement

and [<AllowNullLiteral>] HTMLInputElement =
    inherit HTMLElement
    abstract accept: string with get, set
    /// Retrieves a reference to the form that the object is embedded in.
    abstract align: string with get, set
    /// Sets or retrieves a text alternative to the graphic.
    abstract alt: string with get, set
    /// Specifies whether autocomplete is applied to an editable text field.
    abstract autocomplete: string with get, set
    /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
    abstract autofocus: bool with get, set
    abstract border: string with get, set
    /// Sets or retrieves the state of the check box or radio button.
    abstract ``checked``: bool with get, set
    /// Retrieves whether the object is fully loaded.
    abstract complete: bool with get, set
    /// Sets or retrieves the state of the check box or radio button.
    abstract defaultChecked: bool with get, set
    /// Sets or retrieves the initial contents of the object.
    abstract defaultValue: string with get, set
    abstract disabled: bool with get, set
    // TODO
    // /// Returns a FileList object on a file type input object.
    // abstract files: FileList with get, set
    /// Retrieves a reference to the form that the object is embedded in.
    abstract form: HTMLFormElement with get, set
    /// Overrides the action attribute (where the data on a form is sent) on the parent form element.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formAction: string with get, set
    /// Used to override the encoding (formEnctype attribute) specified on the form element.
    /// Retrieves a reference to the form that the object is embedded in.
    abstract formEnctype: string with get, set
    /// Overrides the submit method attribute previously specified on a form element.
    abstract formMethod: string with get, set
    /// Overrides any validation or required attributes on a form or form elements to allow it to be submitted without validation. This can be used to create a "save draft"-type submit option.
    abstract formNoValidate: string with get, set
    /// Overrides the target attribute on a form element.
    abstract formTarget: string with get, set
    /// Sets or retrieves the height of the object.
    abstract height: string with get, set
    abstract hspace: float with get, set
    abstract indeterminate: bool with get, set
    /// Specifies the ID of a pre-defined datalist of options for an input element.
    abstract list: HTMLElement with get, set
    /// Defines the maximum acceptable value for an input element with type="number".When used with the min and step attributes, lets you control the range and increment (such as only even numbers) that the user can enter into an input field.
    abstract max: string with get, set
    /// Sets or retrieves the maximum number of characters that the user can enter in a text control.
    /// Defines the maximum, or "done" value for a progress element.
    abstract maxLength: float with get, set
    /// Defines the minimum acceptable value for an input element with type="number". When used with the max and step attributes, lets you control the range and increment (such as even numbers only) that the user can enter into an input field.
    abstract min: string with get, set
    /// Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
    abstract multiple: bool with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set
    /// Gets or sets a string containing a regular expression that the user's input must match.
    abstract pattern: string with get, set
    /// Gets or sets a text string that is displayed in an input field as a hint or prompt to users as the format or type of information they need to enter.The text appears in an input field until the user puts focus on the field.
    abstract placeholder: string with get, set
    /// Sets or retrieves the value indicated whether the content of the object is read-only.
    abstract readOnly: bool with get, set
    /// When present, marks an element that can't be submitted without a value.
    abstract required: bool with get, set
    /// Gets or sets the end position or offset of a text selection.
    /// Makes the selection equal to the current object.
    abstract selectionEnd: float with get, set
    /// Gets or sets the starting position or offset of a text selection.
    /// Highlights the input area of a form element.
    abstract selectionStart: float with get, set
    /// Sets or retrieves the number of rows in the list box.
    abstract size: int with get, set
    /// The address or URL of the a media resource that is to be considered.
    abstract src: string with get, set
    abstract status: bool with get, set
    /// Defines an increment or jump between values that you want to allow the user to enter. When used with the max and min attributes, lets you control the range and increment (for example, allow only even numbers) that the user can enter into an input field.
    abstract step: string with get, set
    /// Sets or retrieves the MIME type of the object.
    abstract ``type``: string with get, set
    /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
    abstract useMap: string with get, set
    /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
    abstract validationMessage: string with get, set
    /// Returns a  ValidityState object that represents the validity states of an element.
    abstract validity: ValidityState with get, set
    /// Returns the value of the data at the cursor's current position.
    abstract value: string with get, set
    /// Sets or retrieves the value of a list item.
    abstract valueAsDate: DateTime with get, set
    /// Returns the input field value as a number.
    /// Sets or retrieves the value which is returned to the server when the form control is submitted.
    abstract valueAsNumber: float with get, set
    abstract vspace: float with get, set
    /// Sets or gets a value that you can use to implement your own width functionality for the object.
    abstract width: string with get, set
    /// Returns whether an element will successfully validate based on forms validation rules and constraints.
    abstract willValidate: bool with get, set
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    abstract select: unit -> unit
    /// <summary>Sets a custom error message that is displayed when a form is submitted.</summary>
    /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
    abstract setCustomValidity: error: string -> unit
    /// <summary>Sets the start and end positions of a selection in a text field.</summary>
    /// <param name="start">The offset into the text field for the start of the selection.</param>
    /// <param name="end">The offset into the text field for the end of the selection.</param>
    abstract setSelectionRange: start: float * ``end``: float -> unit
    /// <summary>Decrements a range input control's value by the value given by the Step attribute. If the optional parameter is used, it will decrement the input control's step value multiplied by the parameter's value.</summary>
    /// <param name="n">Value to decrement the value by.</param>
    abstract stepDown: ?n: float -> unit
    /// <summary>Increments a range input control's value by the value given by the Step attribute. If the optional parameter is used, will increment the input control's value by that value.</summary>
    /// <param name="n">Value to increment the value by.</param>
    abstract stepUp: ?n: float -> unit

and [<AllowNullLiteral>] HTMLInputElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLInputElement

and [<AllowNullLiteral>] HTMLLIElement =
    inherit HTMLElement
    /// Sets or retrieves the MIME type of the object.
    abstract ``type``: string with get, set
    /// Sets or retrieves the value which is returned to the server when the form control is submitted.
    abstract value: float with get, set

and [<AllowNullLiteral>] HTMLLIElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLIElement

and [<AllowNullLiteral>] HTMLLabelElement =
    inherit HTMLElement
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the object to which the given label object is assigned.
    abstract htmlFor: string with get, set

and [<AllowNullLiteral>] HTMLLabelElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLabelElement

and [<AllowNullLiteral>] HTMLLegendElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract form: HTMLFormElement with get, set

and [<AllowNullLiteral>] HTMLLegendElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLegendElement

and [<AllowNullLiteral>] HTMLLinkElement =
    inherit HTMLElement
    // inherit LinkStyle
    /// Sets or retrieves the character set used to encode the object.
    abstract charset: string with get, set
    abstract disabled: bool with get, set
    abstract href: string with get, set
    /// Sets or retrieves the language code of the object.
    abstract hreflang: string with get, set
    /// Sets or retrieves the media type.
    abstract media: string with get, set
    abstract rel: string with get, set
    /// Sets or retrieves the relationship between the object and the destination of the link.
    abstract rev: string with get, set
    /// Sets or retrieves the window or frame at which to target content.
    abstract target: string with get, set
    /// Sets or retrieves the content type of the resource designated by the value attribute.
    abstract ``type``: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLLinkElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLinkElement

and [<AllowNullLiteral>] HTMLMapElement =
    inherit HTMLElement
    /// Retrieves a collection of the area objects defined for the given map object.
    abstract areas: HTMLAreasCollection with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set

and [<AllowNullLiteral>] HTMLMapElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMapElement

and [<AllowNullLiteral>] HTMLMediaElement =
    inherit HTMLElement
    /// Returns an AudioTrackList object with the audio tracks for a given video element.
    abstract audioTracks: AudioTrackList with get, set
    /// Gets or sets a value that indicates whether to start playing the media automatically.
    abstract autoplay: bool with get, set
    /// Gets a collection of buffered time ranges.
    abstract buffered: TimeRanges with get, set
    /// Gets or sets a flag that indicates whether the client provides a set of controls for the media (in case the developer does not include controls for the player).
    abstract controls: bool with get, set
    abstract currentSrc: string with get, set
    /// Gets or sets the current playback position, in seconds.
    abstract currentTime: float with get, set
    abstract defaultMuted: bool with get, set
    /// Gets or sets the default playback rate when the user is not using fast forward or reverse for a video or audio resource.
    abstract defaultPlaybackRate: float with get, set
    /// Returns the duration in seconds of the current media resource. A NaN value is returned if duration is not available, or Infinity if the media resource is streaming.
    abstract duration: float with get, set
    /// Gets information about whether the playback has ended or not.
    abstract ended: bool with get, set
    /// Returns an object representing the current error state of the audio or video element.
    abstract error: MediaError with get, set
    abstract loop: bool with get, set
    /// Gets or sets a flag that indicates whether the audio (either audio or the audio track on video media) is muted.
    abstract muted: bool with get, set
    /// Gets the current network activity for the element.
    abstract networkState: float with get, set
    /// Gets a flag that specifies whether playback is paused.
    /// Pauses the current playback and sets paused to TRUE. This can be used to test whether the media is playing or paused. You can also use the pause or play events to tell whether the media is playing or not.
    abstract paused: bool with get, set
    /// Gets or sets the current rate of speed for the media resource to play. This speed is expressed as a multiple of the normal speed of the media resource.
    /// Loads and starts playback of a media resource.
    abstract playbackRate: float with get, set
    /// Gets TimeRanges for the current media resource that has been played.
    abstract played: TimeRanges with get, set
    /// Gets or sets the current playback position, in seconds.
    abstract preload: string with get, set
    abstract readyState: float with get, set
    /// Returns a TimeRanges object that represents the ranges of the current media resource that can be seeked.
    abstract seekable: TimeRanges with get, set
    /// Gets a flag that indicates whether the the client is currently moving to a new playback position in the media resource.
    abstract seeking: bool with get, set
    /// Retrieves the URL to an external file that contains the source code or data.
    abstract src: string with get, set
    /// Sets or retrieves the text string specified by the option tag.
    abstract textTracks: TextTrackList with get, set
    abstract videoTracks: VideoTrackList with get, set
    /// Gets or sets the volume level for audio portions of the media element.
    abstract volume: float with get, set
    abstract HAVE_CURRENT_DATA: float with get, set
    abstract HAVE_ENOUGH_DATA: float with get, set
    abstract HAVE_FUTURE_DATA: float with get, set
    abstract HAVE_METADATA: float with get, set
    abstract HAVE_NOTHING: float with get, set
    abstract NETWORK_EMPTY: float with get, set
    abstract NETWORK_IDLE: float with get, set
    abstract NETWORK_LOADING: float with get, set
    abstract NETWORK_NO_SOURCE: float with get, set
    abstract addTextTrack: kind: string * ?label: string * ?language: string -> TextTrack
    /// Returns a string that specifies whether the client can play a given media resource type.
    abstract canPlayType: ``type``: string -> string
    /// Resets the audio or video object and loads a new media resource.
    abstract load: unit -> unit
    abstract pause: unit -> unit
    abstract play: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLMediaElementType =
    abstract HAVE_CURRENT_DATA: float with get, set
    abstract HAVE_ENOUGH_DATA: float with get, set
    abstract HAVE_FUTURE_DATA: float with get, set
    abstract HAVE_METADATA: float with get, set
    abstract HAVE_NOTHING: float with get, set
    abstract NETWORK_EMPTY: float with get, set
    abstract NETWORK_IDLE: float with get, set
    abstract NETWORK_LOADING: float with get, set
    abstract NETWORK_NO_SOURCE: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMediaElement

and [<AllowNullLiteral>] HTMLMenuElement =
    inherit HTMLElement
    abstract compact: bool with get, set
    /// Sets or retrieves the MIME type for the associated scripting engine.
    abstract ``type``: string with get, set

and [<AllowNullLiteral>] HTMLMenuElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMenuElement

and [<AllowNullLiteral>] HTMLMetaElement =
    inherit HTMLElement
    /// Sets or retrieves the character set used to encode the object.
    abstract charset: string with get, set
    abstract content: string with get, set
    /// Gets or sets information used to bind the value of a content attribute of a meta element to an HTTP response header.
    abstract httpEquiv: string with get, set
    abstract name: string with get, set
    /// Sets or retrieves a scheme to be used in interpreting the value of a property specified for the object.
    abstract scheme: string with get, set
    /// Sets or retrieves the URL property that will be loaded after the specified time has elapsed.
    abstract url: string with get, set

and [<AllowNullLiteral>] HTMLMetaElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMetaElement

and [<AllowNullLiteral>] HTMLModElement =
    inherit HTMLElement
    /// Sets or retrieves reference information about the object.
    abstract cite: string with get, set
    /// Sets or retrieves the date and time of a modification to the object.
    abstract dateTime: string with get, set

and [<AllowNullLiteral>] HTMLModElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLModElement

and [<AllowNullLiteral>] HTMLNextIdElement =
    inherit HTMLElement
    abstract n: string with get, set

and [<AllowNullLiteral>] HTMLNextIdElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLNextIdElement

and [<AllowNullLiteral>] HTMLOListElement =
    inherit HTMLElement
    abstract compact: bool with get, set
    abstract start: float with get, set
    /// Retrieves the type of select control based on the value of the MULTIPLE attribute.
    abstract ``type``: string with get, set

and [<AllowNullLiteral>] HTMLOListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOListElement

and [<AllowNullLiteral>] HTMLObjectElement =
    inherit HTMLElement
    inherit GetSVGDocument
    /// Retrieves a string of the URL where the object tag can be found. This is often the href of the document that the object is in, or the value set by a base element.
    abstract BaseHref: string with get, set
    /// Sets or retrieves the alignment of the caption or legend.
    abstract align: string with get, set
    abstract alt: string with get, set
    /// Gets or sets the optional alternative HTML script to execute if the object fails to load.
    abstract altHtml: string with get, set
    /// Sets or retrieves a character string that can be used to implement your own archive functionality for the object.
    abstract archive: string with get, set
    abstract border: string with get, set
    abstract code: string with get, set
    /// Sets or retrieves the URL of the component.
    abstract codeBase: string with get, set
    /// Sets or retrieves the Internet media type for the code associated with the object.
    abstract codeType: string with get, set
    /// Retrieves the document object of the page or frame.
    abstract contentDocument: Document with get, set
    abstract data: string with get, set
    abstract declare: bool with get, set
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the height of the object.
    abstract height: string with get, set
    abstract hspace: float with get, set
    abstract name: string with get, set
    abstract ``object``: obj with get, set
    abstract readyState: float with get, set
    /// Sets or retrieves a message to be displayed while an object is loading.
    abstract standby: string with get, set
    /// Gets or sets the MIME type of a media resource.
    abstract ``type``: string with get, set
    /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
    abstract useMap: string with get, set
    /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
    abstract validationMessage: string with get, set
    /// Returns a  ValidityState object that represents the validity states of an element.
    abstract validity: ValidityState with get, set
    abstract vspace: float with get, set
    /// Sets or retrieves the width of the object.
    abstract width: string with get, set
    /// Returns whether an element will successfully validate based on forms validation rules and constraints.
    abstract willValidate: bool with get, set
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
    abstract setCustomValidity: error: string -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLObjectElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLObjectElement

and [<AllowNullLiteral>] HTMLOptGroupElement =
    inherit HTMLElement
    /// Sets or retrieves the status of an option.
    abstract defaultSelected: bool with get, set
    abstract disabled: bool with get, set
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the ordinal position of an option in a list box.
    abstract index: int with get, set
    /// Sets or retrieves a value that you can use to implement your own label functionality for the object.
    abstract label: string with get, set
    /// Sets or retrieves whether the option in the list box is the default item.
    abstract selected: bool with get, set
    /// Retrieves or sets the text of the object as a string.
    abstract text: string with get, set
    /// Sets or retrieves the value of an input parameter for an element.
    abstract value: string with get, set

and [<AllowNullLiteral>] HTMLOptGroupElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOptGroupElement

and [<AllowNullLiteral>] HTMLOptionElement =
    inherit HTMLElement
    /// Sets or retrieves the status of an option.
    abstract defaultSelected: bool with get, set
    abstract disabled: bool with get, set
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the ordinal position of an option in a list box.
    abstract index: int with get, set
    /// Sets or retrieves a value that you can use to implement your own label functionality for the object.
    abstract label: string with get, set
    /// Sets or retrieves whether the option in the list box is the default item.
    abstract selected: bool with get, set
    /// Retrieves or sets the text of the object as a string.
    abstract text: string with get, set
    /// Sets or gets the current value of a progress element. The value must be a non-negative number between 0 and the max value.
    abstract value: string with get, set

and [<AllowNullLiteral>] HTMLOptionElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOptionElement
    abstract create: unit -> HTMLOptionElement

and [<AllowNullLiteral>] HTMLParagraphElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract clear: string with get, set

and [<AllowNullLiteral>] HTMLParagraphElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLParagraphElement

and [<AllowNullLiteral>] HTMLParamElement =
    inherit HTMLElement
    abstract name: string with get, set
    /// Retrieves the CSS language in which the style sheet is written.
    abstract ``type``: string with get, set
    /// Sets or retrieves the value which is returned to the server when the form control is submitted.
    abstract value: string with get, set
    /// Sets or retrieves the data type of the value attribute.
    /// Retrieves or sets the text in the entry field of the textArea element.
    abstract valueType: string with get, set

and [<AllowNullLiteral>] HTMLParamElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLParamElement

and [<AllowNullLiteral>] HTMLPhraseElement =
    inherit HTMLElement
    abstract cite: string with get, set
    abstract dateTime: string with get, set

and [<AllowNullLiteral>] HTMLPhraseElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPhraseElement

and [<AllowNullLiteral>] HTMLPreElement =
    inherit HTMLElement
    abstract cite: string with get, set
    abstract clear: string with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set

and [<AllowNullLiteral>] HTMLPreElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPreElement

and [<AllowNullLiteral>] HTMLProgressElement =
    inherit HTMLElement
    abstract form: HTMLFormElement with get, set
    abstract max: float with get, set
    /// Returns the quotient of value/max when the value attribute is set (determinate progress bar), or -1 when the value attribute is missing (indeterminate progress bar).
    abstract position: float with get, set
    abstract value: float with get, set

and [<AllowNullLiteral>] HTMLProgressElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLProgressElement

and [<AllowNullLiteral>] HTMLQuoteElement =
    inherit HTMLElement
    abstract cite: string with get, set
    abstract dateTime: string with get, set

and [<AllowNullLiteral>] HTMLQuoteElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLQuoteElement

and [<AllowNullLiteral>] HTMLScriptElement =
    inherit HTMLElement
    abstract async: bool with get, set
    /// Sets or retrieves the character set used to encode the object.
    abstract charset: string with get, set
    /// Sets or retrieves the status of the script.
    abstract defer: bool with get, set
    /// Sets or retrieves the event for which the script is written.
    abstract ``event``: string with get, set
    /// Sets or retrieves the object that is bound to the event script.
    abstract htmlFor: string with get, set
    /// The address or URL of the a media resource that is to be considered.
    abstract src: string with get, set
    abstract text: string with get, set
    /// Retrieves the type of control.
    abstract ``type``: string with get, set

and [<AllowNullLiteral>] HTMLScriptElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLScriptElement

and [<AllowNullLiteral>] HTMLSelectElement =
    inherit HTMLElement
    /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
    abstract autofocus: bool with get, set
    abstract disabled: bool with get, set
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the number of objects in a collection.
    abstract length: int
    /// Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
    abstract multiple: bool with get, set
    abstract name: string with get, set
    abstract options: HTMLCollection with get, set
    /// When present, marks an element that can't be submitted without a value.
    abstract required: bool with get, set
    /// Sets or retrieves the index of the selected option in a select object.
    abstract selectedIndex: int with get, set
    abstract size: int with get, set
    abstract ``type``: string with get, set
    /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
    abstract validationMessage: string with get, set
    /// Returns a  ValidityState object that represents the validity states of an element.
    abstract validity: ValidityState with get, set
    abstract value: string with get, set
    /// Returns whether an element will successfully validate based on forms validation rules and constraints.
    abstract willValidate: bool with get, set
    abstract selectedOptions: HTMLCollection with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> obj with get, set
    abstract add: element: HTMLElement * ?before: U2<HTMLElement, float> -> unit
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    /// <param name="name">Variant of type Number or String that specifies the object or collection to retrieve. If this parameter is a Number, it is the zero-based index of the object. If this parameter is a string, all objects with matching name or id properties are retrieved, and a collection is returned if more than one match is made.</param>
    /// <param name="index">Variant of type Number that specifies the zero-based index of the object to retrieve when a collection is returned.</param>
    abstract item: ?name: obj * ?index: obj -> obj
    abstract namedItem: name: string -> obj
    /// <param name="index">Number that specifies the zero-based index of the element to remove from the collection.</param>
    abstract remove: ?index: float -> unit
    /// <summary>Sets a custom error message that is displayed when a form is submitted.</summary>
    /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
    abstract setCustomValidity: error: string -> unit

and [<AllowNullLiteral>] HTMLSelectElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSelectElement

and [<AllowNullLiteral>] HTMLSourceElement =
    inherit HTMLElement
    /// Gets or sets the intended media type of the media source.
    abstract media: string with get, set
    abstract src: string with get, set
    abstract ``type``: string with get, set

and [<AllowNullLiteral>] HTMLSourceElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSourceElement

and [<AllowNullLiteral>] HTMLSpanElement =
    inherit HTMLElement


and [<AllowNullLiteral>] HTMLSpanElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSpanElement

and [<AllowNullLiteral>] HTMLStyleElement =
    inherit HTMLElement
    // inherit LinkStyle
    /// Sets or retrieves the media type.
    abstract media: string with get, set
    abstract ``type``: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLStyleElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLStyleElement

and [<AllowNullLiteral>] HTMLTableCaptionElement =
    inherit HTMLElement
    /// Sets or retrieves the alignment of the object relative to the display or table.
    abstract align: string with get, set
    /// Sets or retrieves whether the caption appears at the top or bottom of the table.
    abstract vAlign: string with get, set

and [<AllowNullLiteral>] HTMLTableCaptionElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableCaptionElement

and [<AllowNullLiteral>] HTMLTableCellElement =
    inherit HTMLElement
    inherit HTMLTableAlignment
    /// Sets or retrieves abbreviated text for the object.
    abstract abbr: string with get, set
    /// Sets or retrieves a value that indicates the table alignment.
    abstract align: string with get, set
    /// Sets or retrieves a comma-delimited list of conceptual categories associated with the object.
    abstract axis: string with get, set
    abstract bgColor: obj with get, set
    /// Retrieves the position of the object in the cells collection of a row.
    abstract cellIndex: float with get, set
    /// Sets or retrieves the number columns in the table that the object should span.
    abstract colSpan: float with get, set
    /// Sets or retrieves a list of header cells that provide information for the object.
    abstract headers: string with get, set
    /// Sets or retrieves the height of the object.
    abstract height: obj with get, set
    abstract noWrap: bool with get, set
    /// Sets or retrieves how many rows in a table the cell should span.
    abstract rowSpan: float with get, set
    /// Sets or retrieves the group of cells in a table to which the object's information applies.
    abstract scope: string with get, set
    /// Gets or sets the width of the video element.
    abstract width: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLTableCellElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableCellElement

and [<AllowNullLiteral>] HTMLTableColElement =
    inherit HTMLElement
    inherit HTMLTableAlignment
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    /// Sets or retrieves the number of columns in the group.
    abstract span: float with get, set
    abstract width: obj with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLTableColElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableColElement

and [<AllowNullLiteral>] HTMLTableDataCellElement =
    inherit HTMLTableCellElement


and [<AllowNullLiteral>] HTMLTableDataCellElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableDataCellElement

and [<AllowNullLiteral>] HTMLTableElement =
    inherit HTMLElement
    /// Sets or retrieves a value that indicates the table alignment.
    abstract align: string with get, set
    abstract bgColor: obj with get, set
    abstract border: string with get, set
    /// Sets or retrieves the border color of the object.
    abstract borderColor: obj with get, set
    /// Retrieves the caption object of a table.
    abstract caption: HTMLTableCaptionElement with get, set
    /// Sets or retrieves the amount of space between the border of the cell and the content of the cell.
    abstract cellPadding: string with get, set
    /// Sets or retrieves the amount of space between cells in a table.
    abstract cellSpacing: string with get, set
    /// Sets or retrieves the number of columns in the table.
    abstract cols: float with get, set
    abstract frame: string with get, set
    /// Sets or retrieves the height of the object.
    abstract height: obj with get, set
    /// Sets or retrieves the number of horizontal rows contained in the object.
    abstract rows: HTMLCollection with get, set
    /// Sets or retrieves which dividing lines (inner borders) are displayed.
    abstract rules: string with get, set
    /// Sets or retrieves a description and/or structure of the object.
    abstract summary: string with get, set
    /// Retrieves a collection of all tBody objects in the table. Objects in this collection are in source order.
    abstract tBodies: HTMLCollection with get, set
    /// Retrieves the tFoot object of the table.
    abstract tFoot: HTMLTableSectionElement with get, set
    /// Retrieves the tHead object of the table.
    abstract tHead: HTMLTableSectionElement with get, set
    abstract width: string with get, set
    /// Creates an empty caption element in the table.
    abstract createCaption: unit -> HTMLTableCaptionElement
    /// Creates an empty tBody element in the table.
    abstract createTBody: unit -> HTMLTableSectionElement
    /// Creates an empty tFoot element in the table.
    abstract createTFoot: unit -> HTMLTableSectionElement
    /// Returns the tHead element object if successful, or null otherwise.
    abstract createTHead: unit -> HTMLTableSectionElement
    /// Deletes the caption element and its contents from the table.
    abstract deleteCaption: unit -> unit
    /// <summary>Removes the specified row (tr) from the element and from the rows collection.</summary>
    /// <param name="index">Number that specifies the zero-based position in the rows collection of the row to remove.</param>
    abstract deleteRow: ?index: float -> unit
    /// Deletes the tFoot element and its contents from the table.
    abstract deleteTFoot: unit -> unit
    /// Deletes the tHead element and its contents from the table.
    abstract deleteTHead: unit -> unit
    /// <summary>Creates a new row (tr) in the table, and adds the row to the rows collection.</summary>
    /// <param name="index">Number that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
    abstract insertRow: ?index: float -> HTMLTableRowElement

and [<AllowNullLiteral>] HTMLTableElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableElement

and [<AllowNullLiteral>] HTMLTableHeaderCellElement =
    inherit HTMLTableCellElement
    /// Sets or retrieves the group of cells in a table to which the object's information applies.
    abstract scope: string with get, set

and [<AllowNullLiteral>] HTMLTableHeaderCellElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableHeaderCellElement

and [<AllowNullLiteral>] HTMLTableRowElement =
    inherit HTMLElement
    inherit HTMLTableAlignment
    abstract align: string with get, set
    abstract bgColor: obj with get, set
    /// Retrieves a collection of all cells in the table row.
    abstract cells: HTMLCollection with get, set
    /// Gets or sets the height of the video element.
    abstract height: obj with get, set
    /// Retrieves the position of the object in the rows collection for the table.
    abstract rowIndex: float with get, set
    /// Retrieves the position of the object in the collection.
    abstract sectionRowIndex: float with get, set
    /// <summary>Removes the specified cell from the table row, as well as from the cells collection.</summary>
    /// <param name="index">Number that specifies the zero-based position of the cell to remove from the table row. If no value is provided, the last cell in the cells collection is deleted.</param>
    abstract deleteCell: ?index: float -> unit
    /// <summary>Creates a new cell in the table row, and adds the cell to the cells collection.</summary>
    /// <param name="index">Number that specifies where to insert the cell in the tr. The default value is -1, which appends the new cell to the end of the cells collection.</param>
    abstract insertCell: ?index: float -> HTMLTableCellElement
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLTableRowElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableRowElement

and [<AllowNullLiteral>] HTMLTableSectionElement =
    inherit HTMLElement
    inherit HTMLTableAlignment
    abstract align: string with get, set
    /// Sets or retrieves the number of horizontal rows contained in the object.
    abstract rows: HTMLCollection with get, set
    /// <param name="index">Number that specifies the zero-based position in the rows collection of the row to remove.</param>
    abstract deleteRow: ?index: float -> unit
    /// <param name="index">Number that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
    abstract insertRow: ?index: float -> HTMLTableRowElement
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLTableSectionElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableSectionElement

and [<AllowNullLiteral>] HTMLTextAreaElement =
    inherit HTMLElement
    /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
    abstract autofocus: bool with get, set
    /// Sets or retrieves the width of the object.
    abstract cols: float with get, set
    /// Sets or retrieves the initial contents of the object.
    abstract defaultValue: string with get, set
    abstract disabled: bool with get, set
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the maximum number of characters that the user can enter in a text control.
    abstract maxLength: float with get, set
    abstract name: string with get, set
    /// Gets or sets a text string that is displayed in an input field as a hint or prompt to users as the format or type of information they need to enter.The text appears in an input field until the user puts focus on the field.
    abstract placeholder: string with get, set
    abstract readOnly: bool with get, set
    /// When present, marks an element that can't be submitted without a value.
    abstract required: bool with get, set
    /// Sets or retrieves the number of horizontal rows contained in the object.
    abstract rows: float with get, set
    /// Gets or sets the end position or offset of a text selection.
    abstract selectionEnd: float with get, set
    /// Gets or sets the starting position or offset of a text selection.
    abstract selectionStart: float with get, set
    abstract status: obj with get, set
    abstract ``type``: string with get, set
    /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
    abstract validationMessage: string with get, set
    /// Returns a  ValidityState object that represents the validity states of an element.
    abstract validity: ValidityState with get, set
    abstract value: string with get, set
    /// Returns whether an element will successfully validate based on forms validation rules and constraints.
    abstract willValidate: bool with get, set
    /// Sets or retrieves how to handle wordwrapping in the object.
    abstract wrap: string with get, set
    /// Returns whether a form will validate when it is submitted, without having to submit it.
    abstract checkValidity: unit -> bool
    abstract select: unit -> unit
    /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
    abstract setCustomValidity: error: string -> unit
    /// <param name="start">The offset into the text field for the start of the selection.</param>
    /// <param name="end">The offset into the text field for the end of the selection.</param>
    abstract setSelectionRange: start: float * ``end``: float -> unit

and [<AllowNullLiteral>] HTMLTextAreaElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTextAreaElement

and [<AllowNullLiteral>] HTMLTitleElement =
    inherit HTMLElement
    abstract text: string with get, set

and [<AllowNullLiteral>] HTMLTitleElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTitleElement

and [<AllowNullLiteral>] HTMLTrackElement =
    inherit HTMLElement
    abstract ``default``: bool with get, set
    abstract kind: string with get, set
    abstract label: string with get, set
    abstract readyState: float with get, set
    abstract src: string with get, set
    abstract srclang: string with get, set
    abstract track: TextTrack with get, set
    abstract ERROR: float with get, set
    abstract LOADED: float with get, set
    abstract LOADING: float with get, set
    abstract NONE: float with get, set

and [<AllowNullLiteral>] HTMLTrackElementType =
    abstract ERROR: float with get, set
    abstract LOADED: float with get, set
    abstract LOADING: float with get, set
    abstract NONE: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTrackElement

and [<AllowNullLiteral>] HTMLUListElement =
    inherit HTMLElement
    abstract compact: bool with get, set
    abstract ``type``: string with get, set

and [<AllowNullLiteral>] HTMLUListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLUListElement

and [<AllowNullLiteral>] HTMLUnknownElement =
    inherit HTMLElement

and [<AllowNullLiteral>] HTMLUnknownElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLUnknownElement

and [<AllowNullLiteral>] HTMLVideoElement =
    inherit HTMLMediaElement
    abstract height: float with get, set
    /// Gets or sets a URL of an image to display, for example, like a movie poster. This can be a still frame from the video, or another image if no video data is available.
    abstract poster: string with get, set
    /// Gets the intrinsic height of a video in CSS pixels, or zero if the dimensions are not known.
    abstract videoHeight: float with get, set
    /// Gets the intrinsic width of a video in CSS pixels, or zero if the dimensions are not known.
    abstract videoWidth: float with get, set
    abstract width: float with get, set
    abstract getVideoPlaybackQuality: unit -> VideoPlaybackQuality
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] HTMLVideoElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLVideoElement

and [<AllowNullLiteral>] VideoPlaybackQuality =
    abstract corruptedVideoFrames: float with get, set
    abstract creationTime: float with get, set
    abstract droppedVideoFrames: float with get, set
    abstract totalFrameDelay: float with get, set
    abstract totalVideoFrames: float with get, set

and [<AllowNullLiteral>] VideoPlaybackQualityType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> VideoPlaybackQuality

and [<AllowNullLiteral>] VideoTrack =
    abstract id: string with get, set
    abstract kind: string with get, set
    abstract label: string with get, set
    abstract language: string with get, set
    abstract selected: bool with get, set
    abstract sourceBuffer: SourceBuffer with get, set

and [<AllowNullLiteral>] VideoTrackType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> VideoTrack

and [<AllowNullLiteral>] VideoTrackList =
    inherit EventTarget
    abstract length: int
    abstract onaddtrack: (TrackEvent -> 'Out) with get, set
    abstract onchange: (Event -> 'Out) with get, set
    abstract onremovetrack: (TrackEvent -> 'Out) with get, set
    abstract selectedIndex: int with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> VideoTrack with get, set
    abstract getTrackById: id: string -> VideoTrack
    abstract item: index: float -> VideoTrack
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] VideoTrackListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> VideoTrackList

and [<AllowNullLiteral>] SourceBuffer =
    inherit EventTarget
    abstract appendWindowEnd: float with get, set
    abstract appendWindowStart: float with get, set
    abstract audioTracks: AudioTrackList with get, set
    abstract buffered: TimeRanges with get, set
    abstract mode: string with get, set
    abstract timestampOffset: float with get, set
    abstract updating: bool with get, set
    abstract videoTracks: VideoTrackList with get, set
    abstract abort: unit -> unit
    abstract appendBuffer: data: obj -> unit
    abstract remove: start: float * ``end``: float -> unit

and [<AllowNullLiteral>] SourceBufferType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> SourceBuffer

and [<AllowNullLiteral>] SourceBufferList =
    inherit EventTarget
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> SourceBuffer with get, set
    abstract item: index: float -> SourceBuffer

and [<AllowNullLiteral>] SourceBufferListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> SourceBufferList

and [<AllowNullLiteral>] AudioTrack =
    abstract enabled: bool with get, set
    abstract id: string with get, set
    abstract kind: string with get, set
    abstract label: string with get, set
    abstract language: string with get, set
    abstract sourceBuffer: SourceBuffer with get, set

and [<AllowNullLiteral>] AudioTrackType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> AudioTrack

and [<AllowNullLiteral>] AudioTrackList =
    inherit EventTarget
    abstract length: int
    abstract onaddtrack: (TrackEvent -> 'Out) with get, set
    abstract onchange: (Event -> 'Out) with get, set
    abstract onremovetrack: (TrackEvent -> 'Out) with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> AudioTrack with get, set
    abstract getTrackById: id: string -> AudioTrack
    abstract item: index: float -> AudioTrack
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] AudioTrackListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> AudioTrackList

and [<AllowNullLiteral>] TextTrack =
    inherit EventTarget
    abstract activeCues: TextTrackCueList with get, set
    abstract cues: TextTrackCueList with get, set
    abstract inBandMetadataTrackDispatchType: string with get, set
    abstract kind: string with get, set
    abstract label: string with get, set
    abstract language: string with get, set
    abstract mode: obj with get, set
    abstract oncuechange: (Event -> 'Out) with get, set
    abstract onerror: (Event -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract readyState: float with get, set
    abstract DISABLED: float with get, set
    abstract ERROR: float with get, set
    abstract HIDDEN: float with get, set
    abstract LOADED: float with get, set
    abstract LOADING: float with get, set
    abstract NONE: float with get, set
    abstract SHOWING: float with get, set
    abstract addCue: cue: TextTrackCue -> unit
    abstract removeCue: cue: TextTrackCue -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] TextTrackType =
    abstract DISABLED: float with get, set
    abstract ERROR: float with get, set
    abstract HIDDEN: float with get, set
    abstract LOADED: float with get, set
    abstract LOADING: float with get, set
    abstract NONE: float with get, set
    abstract SHOWING: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrack

and [<AllowNullLiteral>] TextTrackCue =
    inherit EventTarget
    abstract endTime: float with get, set
    abstract id: string with get, set
    abstract onenter: (Event -> 'Out) with get, set
    abstract onexit: (Event -> 'Out) with get, set
    abstract pauseOnExit: bool with get, set
    abstract startTime: float with get, set
    abstract text: string with get, set
    abstract track: TextTrack with get, set
    abstract getCueAsHTML: unit -> DocumentFragment
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] TextTrackCueType =
    [<Emit("new $0($1...)")>] abstract Create: startTime: float * endTime: float * text: string -> TextTrackCue

and [<AllowNullLiteral>] TextTrackCueList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextTrackCue with get, set
    abstract getCueById: id: string -> TextTrackCue
    abstract item: index: float -> TextTrackCue

and [<AllowNullLiteral>] TextTrackCueListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrackCueList

and [<AllowNullLiteral>] TextTrackList =
    inherit EventTarget
    abstract length: int
    abstract onaddtrack: (TrackEvent -> 'Out) with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextTrack with get, set
    abstract item: index: float -> TextTrack
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] TextTrackListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrackList

and [<AllowNullLiteral>] HTMLTableAlignment =
    /// Sets or retrieves a value that you can use to implement your own ch functionality for the object.
    abstract ch: string with get, set
    /// Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
    abstract chOff: string with get, set
    /// Sets or retrieves how text and other content are vertically aligned within the object that contains them.
    abstract vAlign: string with get, set

and [<AllowNullLiteral>] TextMetrics =
    abstract width: float with get, set

and [<AllowNullLiteral>] TextMetricsType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextMetrics

and [<AllowNullLiteral>] MediaError =
    abstract code: float with get, set
    abstract MEDIA_ERR_ABORTED: float with get, set
    abstract MEDIA_ERR_DECODE: float with get, set
    abstract MEDIA_ERR_NETWORK: float with get, set
    abstract MEDIA_ERR_SRC_NOT_SUPPORTED: float with get, set

and [<AllowNullLiteral>] MediaErrorType =
    abstract MEDIA_ERR_ABORTED: float with get, set
    abstract MEDIA_ERR_DECODE: float with get, set
    abstract MEDIA_ERR_NETWORK: float with get, set
    abstract MEDIA_ERR_SRC_NOT_SUPPORTED: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> MediaError

and [<AllowNullLiteral>] ValidityState =
    abstract badInput: bool with get, set
    abstract customError: bool with get, set
    abstract patternMismatch: bool with get, set
    abstract rangeOverflow: bool with get, set
    abstract rangeUnderflow: bool with get, set
    abstract stepMismatch: bool with get, set
    abstract tooLong: bool with get, set
    abstract tooShort: bool with get, set
    abstract typeMismatch: bool with get, set
    abstract valid: bool with get, set
    abstract valueMissing: bool with get, set

and [<AllowNullLiteral>] ValidityStateType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> ValidityState
