
namespace Fable.Browser

open System
open Fable.Core

type [<AllowNullLiteral>] Attr =
    inherit Node
    abstract name: string with get, set
    abstract ownerElement: Element with get, set
    abstract specified: bool with get, set
    abstract value: string with get, set

and [<AllowNullLiteral>] AttrType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Attr

and [<AllowNullLiteral>] CDATASection =
    inherit Text

and [<AllowNullLiteral>] CDATASectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CDATASection

and [<AllowNullLiteral>] CharacterData =
    inherit Node
    inherit ChildNode
    abstract data: string with get, set
    abstract length: int
    abstract appendData: arg: string -> unit
    abstract deleteData: offset: float * count: float -> unit
    abstract insertData: offset: float * arg: string -> unit
    abstract replaceData: offset: float * count: float * arg: string -> unit
    abstract substringData: offset: float * count: float -> string
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] CharacterDataType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CharacterData

and [<AllowNullLiteral>] ChildNode =
    abstract remove: unit -> unit

and [<AllowNullLiteral>] Comment =
    inherit CharacterData
    abstract text: string with get, set

and [<AllowNullLiteral>] CommentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Comment

and [<AllowNullLiteral>] Document =
    inherit Node
    inherit GlobalEventHandlers
    inherit NodeSelector
    inherit DocumentEvent
    /// Sets or gets the URL for the current document.
    abstract URL: string with get, set
    /// Gets the URL for the document, stripped of any character encoding.
    abstract URLUnencoded: string with get, set
    /// Gets the object that has the focus when the parent document has focus.
    abstract activeElement: Element with get, set
    /// Sets or gets the color of all active links in the document.
    abstract alinkColor: string with get, set
    /// Returns a reference to the collection of elements contained by the object.
    abstract all: HTMLCollection with get, set
    /// Retrieves a collection of all a objects that have a name and/or id property. Objects in this collection are in HTML source order.
    abstract anchors: HTMLCollection with get, set
    /// Retrieves a collection of all applet objects in the document.
    abstract applets: HTMLCollection with get, set
    /// Deprecated. Sets or retrieves a value that indicates the background color behind the object.
    abstract bgColor: string with get, set
    /// Specifies the beginning and end of the document body.
    abstract body: HTMLElement with get, set
    abstract characterSet: string with get, set
    /// Gets or sets the character set used to encode the object.
    abstract charset: string with get, set
    /// Gets a value that indicates whether standards-compliant mode is switched on for the object.
    abstract compatMode: string with get, set
    abstract cookie: string with get, set
    abstract defaultCharset: string with get, set
    abstract defaultView: Window with get, set
    /// Sets or gets a value that indicates whether the document can be edited.
    abstract designMode: string with get, set
    /// Sets or retrieves a value that indicates the reading order of the object.
    abstract dir: string with get, set
    /// Gets an object representing the document type declaration associated with the current document.
    abstract doctype: DocumentType with get, set
    /// Gets a reference to the root node of the document.
    abstract documentElement: HTMLElement with get, set
    /// Sets or gets the security domain of the document.
    abstract domain: string with get, set
    /// Retrieves a collection of all embed objects in the document.
    abstract embeds: HTMLCollection with get, set
    /// Sets or gets the foreground (text) color of the document.
    abstract fgColor: string with get, set
    /// Retrieves a collection, in source order, of all form objects in the document.
    abstract forms: HTMLCollection with get, set
    abstract fullscreenElement: Element with get, set
    abstract fullscreenEnabled: bool with get, set
    abstract head: HTMLHeadElement with get, set
    abstract hidden: bool with get, set
    /// Retrieves a collection, in source order, of img objects in the document.
    abstract images: HTMLCollection with get, set
    /// Gets the implementation object of the current document.
    abstract implementation: DOMImplementation with get, set
    /// Returns the character encoding used to create the webpage that is loaded into the document object.
    abstract inputEncoding: string with get, set
    /// Gets the date that the page was last modified, if the page supplies one.
    abstract lastModified: string with get, set
    /// Sets or gets the color of the document links.
    abstract linkColor: string with get, set
    /// Retrieves a collection of all a objects that specify the href property and all area objects in the document.
    abstract links: HTMLCollection with get, set
    /// Contains information about the current URL.
    abstract location: Location with get, set
    abstract media: string with get, set
    /// Fires when the user aborts the download.
    abstract onabort: (Event -> 'Out) with get, set
    /// Fires when the object is set as the active element.
    abstract onactivate: (UIEvent -> 'Out) with get, set
    /// Fires immediately before the object is set as the active element.
    abstract onbeforeactivate: (UIEvent -> 'Out) with get, set
    /// Fires immediately before the activeElement is changed from the current object to another object in the parent document.
    abstract onbeforedeactivate: (UIEvent -> 'Out) with get, set
    /// Fires when the object loses the input focus.
    abstract onblur: (FocusEvent -> 'Out) with get, set
    /// Occurs when playback is possible, but would require further buffering.
    abstract oncanplay: (Event -> 'Out) with get, set
    abstract oncanplaythrough: (Event -> 'Out) with get, set
    /// Fires when the contents of the object or selection have changed.
    abstract onchange: (Event -> 'Out) with get, set
    /// Fires when the user clicks the left mouse button on the object
    abstract onclick: (MouseEvent -> 'Out) with get, set
    /// Fires when the user clicks the right mouse button in the client area, opening the context menu.
    abstract oncontextmenu: (PointerEvent -> 'Out) with get, set
    /// Fires when the user double-clicks the object.
    abstract ondblclick: (MouseEvent -> 'Out) with get, set
    /// Fires when the activeElement is changed from the current object to another object in the parent document.
    abstract ondeactivate: (UIEvent -> 'Out) with get, set
    /// Fires on the source object continuously during a drag operation.
    abstract ondrag: (DragEvent -> 'Out) with get, set
    /// Fires on the source object when the user releases the mouse at the close of a drag operation.
    abstract ondragend: (DragEvent -> 'Out) with get, set
    /// Fires on the target element when the user drags the object to a valid drop target.
    abstract ondragenter: (DragEvent -> 'Out) with get, set
    /// Fires on the target object when the user moves the mouse out of a valid drop target during a drag operation.
    abstract ondragleave: (DragEvent -> 'Out) with get, set
    /// Fires on the target element continuously while the user drags the object over a valid drop target.
    abstract ondragover: (DragEvent -> 'Out) with get, set
    /// Fires on the source object when the user starts to drag a text selection or selected object.
    abstract ondragstart: (DragEvent -> 'Out) with get, set
    abstract ondrop: (DragEvent -> 'Out) with get, set
    /// Occurs when the duration attribute is updated.
    abstract ondurationchange: (Event -> 'Out) with get, set
    /// Occurs when the media element is reset to its initial state.
    abstract onemptied: (Event -> 'Out) with get, set
    /// Occurs when the end of playback is reached.
    abstract onended: (Event -> 'Out) with get, set
    /// Fires when an error occurs during object loading.
    abstract onerror: (Event -> 'Out) with get, set
    /// Fires when the object receives focus.
    abstract onfocus: (FocusEvent -> 'Out) with get, set
    abstract onfullscreenchange: (Event -> 'Out) with get, set
    abstract onfullscreenerror: (Event -> 'Out) with get, set
    abstract oninput: (Event -> 'Out) with get, set
    /// Fires when the user presses a key.
    abstract onkeydown: (KeyboardEvent -> 'Out) with get, set
    /// Fires when the user presses an alphanumeric key.
    abstract onkeypress: (KeyboardEvent -> 'Out) with get, set
    /// Fires when the user releases a key.
    abstract onkeyup: (KeyboardEvent -> 'Out) with get, set
    /// Fires immediately after the browser loads the object.
    abstract onload: (Event -> 'Out) with get, set
    /// Occurs when media data is loaded at the current playback position.
    abstract onloadeddata: (Event -> 'Out) with get, set
    /// Occurs when the duration and dimensions of the media have been determined.
    abstract onloadedmetadata: (Event -> 'Out) with get, set
    /// Occurs when Internet Explorer begins looking for media data.
    abstract onloadstart: (Event -> 'Out) with get, set
    /// Fires when the user clicks the object with either mouse button.
    abstract onmousedown: (MouseEvent -> 'Out) with get, set
    /// Fires when the user moves the mouse over the object.
    abstract onmousemove: (MouseEvent -> 'Out) with get, set
    /// Fires when the user moves the mouse pointer outside the boundaries of the object.
    abstract onmouseout: (MouseEvent -> 'Out) with get, set
    /// Fires when the user moves the mouse pointer into the object.
    abstract onmouseover: (MouseEvent -> 'Out) with get, set
    /// Fires when the user releases a mouse button while the mouse is over the object.
    abstract onmouseup: (MouseEvent -> 'Out) with get, set
    /// Fires when the wheel button is rotated.
    abstract onmousewheel: (MouseWheelEvent -> 'Out) with get, set
    /// Occurs when playback is paused.
    abstract onpause: (Event -> 'Out) with get, set
    /// Occurs when the play method is requested.
    abstract onplay: (Event -> 'Out) with get, set
    /// Occurs when the audio or video has started playing.
    abstract onplaying: (Event -> 'Out) with get, set
    abstract onpointerlockchange: (Event -> 'Out) with get, set
    abstract onpointerlockerror: (Event -> 'Out) with get, set
    /// Occurs to indicate progress while downloading media data.
    abstract onprogress: (ProgressEvent -> 'Out) with get, set
    /// Occurs when the playback rate is increased or decreased.
    abstract onratechange: (Event -> 'Out) with get, set
    /// Fires when the state of the object has changed.
    abstract onreadystatechange: (ProgressEvent -> 'Out) with get, set
    /// Fires when the user resets a form.
    abstract onreset: (Event -> 'Out) with get, set
    /// Fires when the user repositions the scroll box in the scroll bar on the object.
    abstract onscroll: (UIEvent -> 'Out) with get, set
    /// Occurs when the seek operation ends.
    abstract onseeked: (Event -> 'Out) with get, set
    /// Occurs when the current playback position is moved.
    abstract onseeking: (Event -> 'Out) with get, set
    /// Fires when the current selection changes.
    abstract onselect: (UIEvent -> 'Out) with get, set
    abstract onselectstart: (Event -> 'Out) with get, set
    /// Occurs when the download has stopped.
    abstract onstalled: (Event -> 'Out) with get, set
    /// Fires when the user clicks the Stop button or leaves the Web page.
    abstract onstop: (Event -> 'Out) with get, set
    abstract onsubmit: (Event -> 'Out) with get, set
    /// Occurs if the load operation has been intentionally halted.
    abstract onsuspend: (Event -> 'Out) with get, set
    /// Occurs to indicate the current playback position.
    abstract ontimeupdate: (Event -> 'Out) with get, set
    abstract ontouchcancel: (TouchEvent -> 'Out) with get, set
    abstract ontouchend: (TouchEvent -> 'Out) with get, set
    abstract ontouchmove: (TouchEvent -> 'Out) with get, set
    abstract ontouchstart: (TouchEvent -> 'Out) with get, set
    /// Occurs when the volume is changed, or playback is muted or unmuted.
    abstract onvolumechange: (Event -> 'Out) with get, set
    /// Occurs when playback stops because the next frame of a video resource is not available.
    abstract onwaiting: (Event -> 'Out) with get, set
    abstract plugins: HTMLCollection with get, set
    abstract pointerLockElement: Element with get, set
    /// Retrieves a value that indicates the current state of the object.
    abstract readyState: string with get, set
    /// Gets the URL of the location that referred the user to the current page.
    abstract referrer: string with get, set
    // /// Gets the root svg element in the document hierarchy.
    // abstract rootElement: SVGSVGElement with get, set
    /// Retrieves a collection of all script objects in the document.
    abstract scripts: HTMLCollection with get, set
    abstract security: string with get, set
    // /// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
    // abstract styleSheets: StyleSheetList with get, set
    /// Contains the title of the document.
    abstract title: string with get, set
    abstract visibilityState: string with get, set
    /// Sets or gets the color of the links that the user has visited.
    abstract vlinkColor: string with get, set
    abstract xmlEncoding: string with get, set
    abstract xmlStandalone: bool with get, set
    /// Gets or sets the version attribute specified in the declaration of an XML document.
    abstract xmlVersion: string with get, set
    abstract currentScript: HTMLScriptElement with get, set
    abstract adoptNode: source: Node -> Node
    abstract captureEvents: unit -> unit
    abstract clear: unit -> unit
    /// Closes an output stream and forces the sent data to display.
    abstract close: unit -> unit
    /// <summary>Creates an attribute object with a specified name.</summary>
    /// <param name="name">String that sets the attribute object's name.</param>
    abstract createAttribute: name: string -> Attr
    abstract createAttributeNS: namespaceURI: string * qualifiedName: string -> Attr
    abstract createCDATASection: data: string -> CDATASection
    /// <summary>Creates a comment object with the specified data.</summary>
    /// <param name="data">Sets the comment object's data.</param>
    abstract createComment: data: string -> Comment
    /// Creates a new document.
    abstract createDocumentFragment: unit -> DocumentFragment
    /// <summary>Creates an instance of the element for the specified tag.</summary>
    /// <param name="tagName">The name of an element.</param>
    abstract createElement: tagName: string -> HTMLElement
    abstract createElementNS: namespaceURI: string * qualifiedName: string -> Element
    // abstract createExpression: expression: string * resolver: XPathNSResolver -> XPathExpression
    // abstract createNSResolver: nodeResolver: Node -> XPathNSResolver
    /// <summary>Creates a NodeIterator object that you can use to traverse filtered lists of nodes or elements in a document.</summary>
    /// <param name="root">The root element or node to start traversing on.</param>
    /// <param name="whatToShow">The type of nodes or elements to appear in the node list</param>
    /// <param name="filter">A custom NodeFilter function to use. For more information, see filter. Use null for no filter.</param>
    /// <param name="entityReferenceExpansion">A flag that specifies whether entity reference nodes are expanded.</param>
    abstract createNodeIterator: root: Node * ?whatToShow: float * ?filter: NodeFilter * ?entityReferenceExpansion: bool -> NodeIterator
    abstract createProcessingInstruction: target: string * data: string -> ProcessingInstruction
    /// Returns an empty range object that has both of its boundary points positioned at the beginning of the document.
    abstract createRange: unit -> Range
    /// <summary>Creates a text string from the specified value.</summary>
    /// <param name="data">String that specifies the nodeValue property of the text node.</param>
    abstract createTextNode: data: string -> Text
    abstract createTouch: view: obj * target: EventTarget * identifier: float * pageX: float * pageY: float * screenX: float * screenY: float -> Touch
    abstract createTouchList: [<ParamArray>] touches: Touch[] -> Touch[]
    /// <summary>Creates a TreeWalker object that you can use to traverse filtered lists of nodes or elements in a document.</summary>
    /// <param name="root">The root element or node to start traversing on.</param>
    /// <param name="whatToShow">The type of nodes or elements to appear in the node list. For more information, see whatToShow.</param>
    /// <param name="filter">A custom NodeFilter function to use.</param>
    /// <param name="entityReferenceExpansion">A flag that specifies whether entity reference nodes are expanded.</param>
    abstract createTreeWalker: root: Node * ?whatToShow: float * ?filter: NodeFilter * ?entityReferenceExpansion: bool -> TreeWalker
    /// <summary>Returns the element for the specified x coordinate and the specified y coordinate.</summary>
    /// <param name="x">The x-offset</param>
    /// <param name="y">The y-offset</param>
    abstract elementFromPoint: x: float * y: float -> Element
    // abstract evaluate: expression: string * contextNode: Node * resolver: XPathNSResolver * ``type``: float * result: XPathResult -> XPathResult
    /// <summary>Executes a command on the current document, current selection, or the given range.</summary>
    /// <param name="commandId">String that specifies the command to execute. This command can be any of the command identifiers that can be executed in script.</param>
    /// <param name="showUI">Display the user interface, defaults to false.</param>
    /// <param name="value">Value to assign.</param>
    abstract execCommand: commandId: string * ?showUI: bool * ?value: obj -> bool
    /// <summary>Displays help information for the given command identifier.</summary>
    /// <param name="commandId">Displays help information for the given command identifier.</param>
    abstract execCommandShowHelp: commandId: string -> bool
    abstract exitFullscreen: unit -> unit
    abstract exitPointerLock: unit -> unit
    /// Causes the element to receive the focus and executes the code specified by the onfocus event.
    abstract focus: unit -> unit
    /// <summary>Returns a reference to the first object with the specified value of the ID or NAME attribute.</summary>
    /// <param name="elementId">String that specifies the ID value. Case-insensitive.</param>
    /// <param name="elementId">String that specifies the ID value. Case-insensitive.</param>
    abstract getElementById: elementId: string -> HTMLElement
    abstract getElementsByClassName: classNames: string -> NodeListOf<Element>
    /// <summary>Gets a collection of objects based on the value of the NAME or ID attribute.</summary>
    /// <param name="elementName">Gets a collection of objects based on the value of the NAME or ID attribute.</param>
    abstract getElementsByName: elementName: string -> NodeListOf<Element>
    /// Retrieves a collection of objects based on the specified element name.
    abstract getElementsByTagName: tagname: string -> NodeListOf<Element>
    abstract getElementsByTagNameNS: namespaceURI: string * localName: string -> NodeListOf<Element>
    /// Returns an object representing the current selection of the document that is loaded into the object displaying a webpage.
    abstract getSelection: unit -> Selection
    /// Gets a value indicating whether the object currently has focus.
    abstract hasFocus: unit -> bool
    abstract importNode: importedNode: Node * deep: bool -> Node
    /// <summary>Opens a new window and loads a document specified by a given URL. Also, opens a new window that uses the url parameter and the name parameter to collect the output of the write method and the writeln method.</summary>
    /// <param name="url">Specifies a MIME type for the document.</param>
    /// <param name="name">Specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.</param>
    /// <param name="features">Contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes"). The following values are supported.</param>
    /// <param name="replace">Specifies whether the existing entry for the document is replaced in the history list.</param>
    abstract ``open``: ?url: string * ?name: string * ?features: string * ?replace: bool -> Document
    /// <summary>Returns a Boolean value that indicates whether a specified command can be successfully executed using execCommand, given the current state of the document.</summary>
    /// <param name="commandId">Specifies a command identifier.</param>
    abstract queryCommandEnabled: commandId: string -> bool
    /// <summary>Returns a Boolean value that indicates whether the specified command is in the indeterminate state.</summary>
    /// <param name="commandId">String that specifies a command identifier.</param>
    abstract queryCommandIndeterm: commandId: string -> bool
    /// <summary>Returns a Boolean value that indicates the current state of the command.</summary>
    /// <param name="commandId">String that specifies a command identifier.</param>
    abstract queryCommandState: commandId: string -> bool
    /// <summary>Returns a Boolean value that indicates whether the current command is supported on the current range.</summary>
    /// <param name="commandId">Specifies a command identifier.</param>
    abstract queryCommandSupported: commandId: string -> bool
    /// <summary>Retrieves the string associated with a command.</summary>
    /// <param name="commandId">String that contains the identifier of a command. This can be any command identifier given in the list of Command Identifiers.</param>
    abstract queryCommandText: commandId: string -> string
    /// <summary>Returns the current value of the document, range, or current selection for the given command.</summary>
    /// <param name="commandId">String that specifies a command identifier.</param>
    abstract queryCommandValue: commandId: string -> string
    abstract releaseEvents: unit -> unit
    /// Allows updating the print settings for the page.
    abstract updateSettings: unit -> unit
    /// <summary>Writes one or more HTML expressions to a document in the specified window.</summary>
    /// <param name="content">Specifies the text and HTML tags to write.</param>
    abstract write: [<ParamArray>] content: string[] -> unit
    /// <summary>Writes one or more HTML expressions, followed by a carriage return, to a document in the specified window.</summary>
    /// <param name="content">The text and HTML tags to write.</param>
    abstract writeln: [<ParamArray>] content: string[] -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] DocumentType =
    abstract entities: NamedNodeMap with get, set
    abstract internalSubset: string with get, set
    abstract name: string with get, set
    abstract notations: NamedNodeMap with get, set
    abstract publicId: string with get, set
    abstract systemId: string with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> Document
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] DocumentFragment =
    inherit Node
    inherit NodeSelector
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] DocumentFragmentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DocumentFragment

and [<AllowNullLiteral>] DocumentTypeType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DocumentType

and [<AllowNullLiteral>] DOMException =
    abstract code: float with get, set
    abstract message: string with get, set
    abstract name: string with get, set
    abstract ABORT_ERR: float with get, set
    abstract DATA_CLONE_ERR: float with get, set
    abstract DOMSTRING_SIZE_ERR: float with get, set
    abstract HIERARCHY_REQUEST_ERR: float with get, set
    abstract INDEX_SIZE_ERR: float with get, set
    abstract INUSE_ATTRIBUTE_ERR: float with get, set
    abstract INVALID_ACCESS_ERR: float with get, set
    abstract INVALID_CHARACTER_ERR: float with get, set
    abstract INVALID_MODIFICATION_ERR: float with get, set
    abstract INVALID_NODE_TYPE_ERR: float with get, set
    abstract INVALID_STATE_ERR: float with get, set
    abstract NAMESPACE_ERR: float with get, set
    abstract NETWORK_ERR: float with get, set
    abstract NOT_FOUND_ERR: float with get, set
    abstract NOT_SUPPORTED_ERR: float with get, set
    abstract NO_DATA_ALLOWED_ERR: float with get, set
    abstract NO_MODIFICATION_ALLOWED_ERR: float with get, set
    abstract PARSE_ERR: float with get, set
    abstract QUOTA_EXCEEDED_ERR: float with get, set
    abstract SECURITY_ERR: float with get, set
    abstract SERIALIZE_ERR: float with get, set
    abstract SYNTAX_ERR: float with get, set
    abstract TIMEOUT_ERR: float with get, set
    abstract TYPE_MISMATCH_ERR: float with get, set
    abstract URL_MISMATCH_ERR: float with get, set
    abstract VALIDATION_ERR: float with get, set
    abstract WRONG_DOCUMENT_ERR: float with get, set
    abstract toString: unit -> string

and [<AllowNullLiteral>] DOMExceptionType =
    abstract ABORT_ERR: float with get, set
    abstract DATA_CLONE_ERR: float with get, set
    abstract DOMSTRING_SIZE_ERR: float with get, set
    abstract HIERARCHY_REQUEST_ERR: float with get, set
    abstract INDEX_SIZE_ERR: float with get, set
    abstract INUSE_ATTRIBUTE_ERR: float with get, set
    abstract INVALID_ACCESS_ERR: float with get, set
    abstract INVALID_CHARACTER_ERR: float with get, set
    abstract INVALID_MODIFICATION_ERR: float with get, set
    abstract INVALID_NODE_TYPE_ERR: float with get, set
    abstract INVALID_STATE_ERR: float with get, set
    abstract NAMESPACE_ERR: float with get, set
    abstract NETWORK_ERR: float with get, set
    abstract NOT_FOUND_ERR: float with get, set
    abstract NOT_SUPPORTED_ERR: float with get, set
    abstract NO_DATA_ALLOWED_ERR: float with get, set
    abstract NO_MODIFICATION_ALLOWED_ERR: float with get, set
    abstract PARSE_ERR: float with get, set
    abstract QUOTA_EXCEEDED_ERR: float with get, set
    abstract SECURITY_ERR: float with get, set
    abstract SERIALIZE_ERR: float with get, set
    abstract SYNTAX_ERR: float with get, set
    abstract TIMEOUT_ERR: float with get, set
    abstract TYPE_MISMATCH_ERR: float with get, set
    abstract URL_MISMATCH_ERR: float with get, set
    abstract VALIDATION_ERR: float with get, set
    abstract WRONG_DOCUMENT_ERR: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMException

and [<AllowNullLiteral>] DOMImplementation =
    abstract createDocument: namespaceURI: string * qualifiedName: string * doctype: DocumentType -> Document
    abstract createDocumentType: qualifiedName: string * publicId: string * systemId: string -> DocumentType
    abstract createHTMLDocument: title: string -> Document
    abstract hasFeature: feature: string * version: string -> bool

and [<AllowNullLiteral>] DOMImplementationType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMImplementation

and [<AllowNullLiteral>] DOMStringList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract contains: str: string -> bool
    abstract item: index: float -> string

and [<AllowNullLiteral>] DOMStringListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMStringList

and [<AllowNullLiteral>] DOMStringMap =
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> string with get, set

and [<AllowNullLiteral>] DOMStringMapType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMStringMap

and [<AllowNullLiteral>] DOMTokenList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract add: [<ParamArray>] token: string[] -> unit
    abstract contains: token: string -> bool
    abstract item: index: float -> string
    abstract remove: [<ParamArray>] token: string[] -> unit
    abstract toString: unit -> string
    abstract toggle: token: string * ?force: bool -> bool

and [<AllowNullLiteral>] DOMTokenListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMTokenList

and [<AllowNullLiteral>] Element =
    inherit Node
    inherit GlobalEventHandlers
    inherit NodeSelector
    inherit ChildNode
    abstract classList: DOMTokenList with get, set
    abstract clientHeight: float with get, set
    abstract clientLeft: float with get, set
    abstract clientTop: float with get, set
    abstract clientWidth: float with get, set
    abstract onariarequest: (AriaRequestEvent -> 'Out) with get, set
    abstract oncommand: (CommandEvent -> 'Out) with get, set
    abstract ongotpointercapture: (PointerEvent -> 'Out) with get, set
    abstract onlostpointercapture: (PointerEvent -> 'Out) with get, set
    abstract ontouchcancel: (TouchEvent -> 'Out) with get, set
    abstract ontouchend: (TouchEvent -> 'Out) with get, set
    abstract ontouchmove: (TouchEvent -> 'Out) with get, set
    abstract ontouchstart: (TouchEvent -> 'Out) with get, set
    abstract scrollHeight: float with get, set
    abstract scrollLeft: float with get, set
    abstract scrollTop: float with get, set
    abstract scrollWidth: float with get, set
    abstract tagName: string with get, set
    abstract id: string with get, set
    abstract className: string with get, set
    abstract innerHTML: string with get, set
    abstract getAttribute: ?name: string -> string
    abstract getAttributeNS: namespaceURI: string * localName: string -> string
    abstract getAttributeNode: name: string -> Attr
    abstract getAttributeNodeNS: namespaceURI: string * localName: string -> Attr
    abstract getBoundingClientRect: unit -> ClientRect
    abstract getClientRects: unit -> ClientRect[]
    abstract getElementsByTagName: name: string -> NodeListOf<Element>
    abstract getElementsByTagNameNS: namespaceURI: string * localName: string -> NodeListOf<Element>
    abstract hasAttribute: name: string -> bool
    abstract hasAttributeNS: namespaceURI: string * localName: string -> bool
    abstract releasePointerCapture: pointerId: float -> unit
    abstract removeAttribute: ?name: string -> unit
    abstract removeAttributeNS: namespaceURI: string * localName: string -> unit
    abstract removeAttributeNode: oldAttr: Attr -> Attr
    abstract requestFullscreen: unit -> unit
    abstract requestPointerLock: unit -> unit
    abstract setAttribute: name: string * value: string -> unit
    abstract setAttributeNS: namespaceURI: string * qualifiedName: string * value: string -> unit
    abstract setAttributeNode: newAttr: Attr -> Attr
    abstract setAttributeNodeNS: newAttr: Attr -> Attr
    abstract setPointerCapture: pointerId: float -> unit
    abstract getElementsByClassName: classNames: string -> NodeListOf<Element>
    abstract matches: selector: string -> bool
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] ElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Element

and [<AllowNullLiteral>] Event =
    abstract bubbles: bool with get, set
    abstract cancelBubble: bool with get, set
    abstract cancelable: bool with get, set
    abstract currentTarget: EventTarget with get, set
    abstract defaultPrevented: bool with get, set
    abstract eventPhase: float with get, set
    abstract isTrusted: bool with get, set
    abstract returnValue: bool with get, set
    abstract srcElement: Element with get, set
    abstract target: EventTarget with get, set
    abstract timeStamp: float with get, set
    abstract ``type``: string with get, set
    abstract AT_TARGET: float with get, set
    abstract BUBBLING_PHASE: float with get, set
    abstract CAPTURING_PHASE: float with get, set
    abstract initEvent: eventTypeArg: string * canBubbleArg: bool * cancelableArg: bool -> unit
    abstract preventDefault: unit -> unit
    abstract stopImmediatePropagation: unit -> unit
    abstract stopPropagation: unit -> unit

and [<AllowNullLiteral>] EventType =
    abstract AT_TARGET: float with get, set
    abstract BUBBLING_PHASE: float with get, set
    abstract CAPTURING_PHASE: float with get, set

and [<AllowNullLiteral>] EventTarget =
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit
    abstract dispatchEvent: evt: Event -> bool
    abstract removeEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] EventTargetType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> EventTarget

and [<AllowNullLiteral>] HTMLCollection =
    /// Sets or retrieves the number of objects in a collection.
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Element with get, set
    /// Retrieves an object from various collections.
    abstract item: ?nameOrIndex: obj * ?optionalIndex: obj -> Element
    /// Retrieves a form object or an object from an elements collection.
    /// Sets or retrieves the frame name.
    abstract namedItem: name: string -> Element

and [<AllowNullLiteral>] HTMLCollectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLCollection

and [<AllowNullLiteral>] NamedNodeMap =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Attr with get, set
    abstract getNamedItem: name: string -> Attr
    abstract getNamedItemNS: namespaceURI: string * localName: string -> Attr
    abstract item: index: float -> Attr
    abstract removeNamedItem: name: string -> Attr
    abstract removeNamedItemNS: namespaceURI: string * localName: string -> Attr
    abstract setNamedItem: arg: Attr -> Attr
    abstract setNamedItemNS: arg: Attr -> Attr

and [<AllowNullLiteral>] NamedNodeMapType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> NamedNodeMap

and [<AllowNullLiteral>] Node =
    inherit EventTarget
    abstract attributes: NamedNodeMap with get, set
    abstract baseURI: string with get, set
    abstract childNodes: NodeList with get, set
    abstract firstChild: Node with get, set
    abstract lastChild: Node with get, set
    abstract localName: string with get, set
    abstract namespaceURI: string with get, set
    abstract nextSibling: Node with get, set
    abstract nodeName: string with get, set
    abstract nodeType: float with get, set
    abstract nodeValue: string with get, set
    abstract ownerDocument: Document with get, set
    abstract parentElement: HTMLElement with get, set
    abstract parentNode: Node with get, set
    abstract prefix: string with get, set
    abstract previousSibling: Node with get, set
    abstract textContent: string with get, set
    abstract ATTRIBUTE_NODE: float with get, set
    abstract CDATA_SECTION_NODE: float with get, set
    abstract COMMENT_NODE: float with get, set
    abstract DOCUMENT_FRAGMENT_NODE: float with get, set
    abstract DOCUMENT_NODE: float with get, set
    abstract DOCUMENT_POSITION_CONTAINED_BY: float with get, set
    abstract DOCUMENT_POSITION_CONTAINS: float with get, set
    abstract DOCUMENT_POSITION_DISCONNECTED: float with get, set
    abstract DOCUMENT_POSITION_FOLLOWING: float with get, set
    abstract DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC: float with get, set
    abstract DOCUMENT_POSITION_PRECEDING: float with get, set
    abstract DOCUMENT_TYPE_NODE: float with get, set
    abstract ELEMENT_NODE: float with get, set
    abstract ENTITY_NODE: float with get, set
    abstract ENTITY_REFERENCE_NODE: float with get, set
    abstract NOTATION_NODE: float with get, set
    abstract PROCESSING_INSTRUCTION_NODE: float with get, set
    abstract TEXT_NODE: float with get, set
    abstract appendChild: newChild: Node -> Node
    abstract cloneNode: ?deep: bool -> Node
    abstract compareDocumentPosition: other: Node -> float
    abstract hasAttributes: unit -> bool
    abstract hasChildNodes: unit -> bool
    abstract insertBefore: newChild: Node * ?refChild: Node -> Node
    abstract isDefaultNamespace: namespaceURI: string -> bool
    abstract isEqualNode: arg: Node -> bool
    abstract isSameNode: other: Node -> bool
    abstract lookupNamespaceURI: prefix: string -> string
    abstract lookupPrefix: namespaceURI: string -> string
    abstract normalize: unit -> unit
    abstract removeChild: oldChild: Node -> Node
    abstract replaceChild: newChild: Node * oldChild: Node -> Node
    abstract contains: node: Node -> bool

and [<AllowNullLiteral>] NodeType =
    abstract ATTRIBUTE_NODE: float with get, set
    abstract CDATA_SECTION_NODE: float with get, set
    abstract COMMENT_NODE: float with get, set
    abstract DOCUMENT_FRAGMENT_NODE: float with get, set
    abstract DOCUMENT_NODE: float with get, set
    abstract DOCUMENT_POSITION_CONTAINED_BY: float with get, set
    abstract DOCUMENT_POSITION_CONTAINS: float with get, set
    abstract DOCUMENT_POSITION_DISCONNECTED: float with get, set
    abstract DOCUMENT_POSITION_FOLLOWING: float with get, set
    abstract DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC: float with get, set
    abstract DOCUMENT_POSITION_PRECEDING: float with get, set
    abstract DOCUMENT_TYPE_NODE: float with get, set
    abstract ELEMENT_NODE: float with get, set
    abstract ENTITY_NODE: float with get, set
    abstract ENTITY_REFERENCE_NODE: float with get, set
    abstract NOTATION_NODE: float with get, set
    abstract PROCESSING_INSTRUCTION_NODE: float with get, set
    abstract TEXT_NODE: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> Node

and [<AllowNullLiteral>] NodeSelector =
    abstract querySelector: selectors: string -> Element
    abstract querySelectorAll: selectors: string -> NodeListOf<Element>

and [<AllowNullLiteral>] NodeFilter =
    abstract acceptNode: n: Node -> float

and [<AllowNullLiteral>] NodeFilterType =
    abstract FILTER_ACCEPT: float with get, set
    abstract FILTER_REJECT: float with get, set
    abstract FILTER_SKIP: float with get, set
    abstract SHOW_ALL: float with get, set
    abstract SHOW_ATTRIBUTE: float with get, set
    abstract SHOW_CDATA_SECTION: float with get, set
    abstract SHOW_COMMENT: float with get, set
    abstract SHOW_DOCUMENT: float with get, set
    abstract SHOW_DOCUMENT_FRAGMENT: float with get, set
    abstract SHOW_DOCUMENT_TYPE: float with get, set
    abstract SHOW_ELEMENT: float with get, set
    abstract SHOW_ENTITY: float with get, set
    abstract SHOW_ENTITY_REFERENCE: float with get, set
    abstract SHOW_NOTATION: float with get, set
    abstract SHOW_PROCESSING_INSTRUCTION: float with get, set
    abstract SHOW_TEXT: float with get, set

and [<AllowNullLiteral>] NodeIterator =
    abstract filter: NodeFilter with get, set
    abstract root: Node with get, set
    abstract whatToShow: float with get, set
    abstract detach: unit -> unit
    abstract nextNode: unit -> Node
    abstract previousNode: unit -> Node

and [<AllowNullLiteral>] NodeIteratorType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> NodeIterator

and [<AllowNullLiteral>] NodeList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Node with get, set
    abstract item: index: float -> Node

and [<AllowNullLiteral>] NodeListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> NodeList

and [<AllowNullLiteral>] NodeListOf<'TNode> =
    inherit NodeList
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> 'TNode with get, set
    abstract item: index: float -> 'TNode

and [<AllowNullLiteral>] ProcessingInstruction =
    inherit CharacterData
    abstract target: string with get, set

and [<AllowNullLiteral>] ProcessingInstructionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> ProcessingInstruction

and [<AllowNullLiteral>] Selection =
    abstract anchorNode: Node with get, set
    abstract anchorOffset: float with get, set
    abstract focusNode: Node with get, set
    abstract focusOffset: float with get, set
    abstract isCollapsed: bool with get, set
    abstract rangeCount: float with get, set
    abstract ``type``: string with get, set
    abstract addRange: range: Range -> unit
    abstract collapse: parentNode: Node * offset: float -> unit
    abstract collapseToEnd: unit -> unit
    abstract collapseToStart: unit -> unit
    abstract containsNode: node: Node * partlyContained: bool -> bool
    abstract deleteFromDocument: unit -> unit
    abstract empty: unit -> unit
    abstract extend: newNode: Node * offset: float -> unit
    abstract getRangeAt: index: float -> Range
    abstract removeAllRanges: unit -> unit
    abstract removeRange: range: Range -> unit
    abstract selectAllChildren: parentNode: Node -> unit
    abstract setBaseAndExtent: baseNode: Node * baseOffset: float * extentNode: Node * extentOffset: float -> unit
    abstract toString: unit -> string

and [<AllowNullLiteral>] SelectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Selection

and [<AllowNullLiteral>] ClientRect =
    abstract bottom: float with get, set
    abstract height: float with get, set
    abstract left: float with get, set
    abstract right: float with get, set
    abstract top: float with get, set
    abstract width: float with get, set

and [<AllowNullLiteral>] ClientRectType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> ClientRect

and [<AllowNullLiteral>] Range =
    abstract collapsed: bool with get, set
    abstract commonAncestorContainer: Node with get, set
    abstract endContainer: Node with get, set
    abstract endOffset: float with get, set
    abstract startContainer: Node with get, set
    abstract startOffset: float with get, set
    abstract END_TO_END: float with get, set
    abstract END_TO_START: float with get, set
    abstract START_TO_END: float with get, set
    abstract START_TO_START: float with get, set
    abstract cloneContents: unit -> DocumentFragment
    abstract cloneRange: unit -> Range
    abstract collapse: toStart: bool -> unit
    abstract compareBoundaryPoints: how: float * sourceRange: Range -> float
    abstract createContextualFragment: fragment: string -> DocumentFragment
    abstract deleteContents: unit -> unit
    abstract detach: unit -> unit
    abstract expand: Unit: string -> bool
    abstract extractContents: unit -> DocumentFragment
    abstract getBoundingClientRect: unit -> ClientRect
    abstract getClientRects: unit -> ClientRect[]
    abstract insertNode: newNode: Node -> unit
    abstract selectNode: refNode: Node -> unit
    abstract selectNodeContents: refNode: Node -> unit
    abstract setEnd: refNode: Node * offset: float -> unit
    abstract setEndAfter: refNode: Node -> unit
    abstract setEndBefore: refNode: Node -> unit
    abstract setStart: refNode: Node * offset: float -> unit
    abstract setStartAfter: refNode: Node -> unit
    abstract setStartBefore: refNode: Node -> unit
    abstract surroundContents: newParent: Node -> unit
    abstract toString: unit -> string

and [<AllowNullLiteral>] RangeType =
    abstract END_TO_END: float with get, set
    abstract END_TO_START: float with get, set
    abstract START_TO_END: float with get, set
    abstract START_TO_START: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> Range

and [<AllowNullLiteral>] Text =
    inherit CharacterData
    abstract wholeText: string with get, set
    abstract replaceWholeText: content: string -> Text
    abstract splitText: offset: float -> Text

and [<AllowNullLiteral>] TextType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Text

and [<AllowNullLiteral>] TimeRanges =
    abstract length: int
    abstract ``end``: index: float -> float
    abstract start: index: float -> float

and [<AllowNullLiteral>] TimeRangesType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TimeRanges

and [<AllowNullLiteral>] TreeWalker =
    abstract currentNode: Node with get, set
    abstract filter: NodeFilter with get, set
    abstract root: Node with get, set
    abstract whatToShow: float with get, set
    abstract firstChild: unit -> Node
    abstract lastChild: unit -> Node
    abstract nextNode: unit -> Node
    abstract nextSibling: unit -> Node
    abstract parentNode: unit -> Node
    abstract previousNode: unit -> Node
    abstract previousSibling: unit -> Node

and [<AllowNullLiteral>] TreeWalkerType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TreeWalker

and [<AllowNullLiteral>] URL =
    abstract hash: string with get, set
    abstract host: string with get, set
    abstract hostname: string with get, set
    abstract href: string with get, set
    abstract origin: string
    abstract password: string with get, set
    abstract pathname: string with get, set
    abstract port: string with get, set
    abstract protocol: string with get, set
    abstract search: string with get, set
    abstract username: string with get, set
    abstract searchParams: URLSearchParams
    abstract toString: unit -> string

and [<AllowNullLiteral>] URLType =
    [<Emit("new $0($1...)")>] abstract Create: url: string -> URL

and [<AllowNullLiteral>] URLSearchParams =
    /// Appends a specified key/value pair as a new search parameter.
    abstract append: name: string * value: string -> unit
    /// Deletes the given search parameter, and its associated value, from the list of all search parameters.
    abstract delete: name: string -> unit
    /// Returns the first value associated to the given search parameter.
    abstract get: name: string -> string option
    /// Returns all the values association with a given search parameter.
    abstract getAll: name: string -> array<string>
    /// Returns a Boolean indicating if such a search parameter exists.
    abstract has: name: string -> bool
    /// Sets the value associated to a given search parameter to the given value. If there were several values, delete the others.
    abstract set: name: string * value: string -> unit

and [<AllowNullLiteral>] URLSearchParamsType =
    [<Emit("new $0($1...)")>] abstract Create: arg: obj -> URLSearchParams

and [<AllowNullLiteral>] BarProp =
    abstract visible: bool with get, set

and [<AllowNullLiteral>] Screen =
    inherit EventTarget
    abstract availHeight: float with get, set
    abstract availWidth: float with get, set
    abstract bufferDepth: float with get, set
    abstract colorDepth: float with get, set
    abstract deviceXDPI: float with get, set
    abstract deviceYDPI: float with get, set
    abstract fontSmoothingEnabled: bool with get, set
    abstract height: float with get, set
    abstract logicalXDPI: float with get, set
    abstract logicalYDPI: float with get, set
    abstract pixelDepth: float with get, set
    abstract systemXDPI: float with get, set
    abstract systemYDPI: float with get, set
    abstract width: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] Location =
    abstract hash: string with get, set
    abstract host: string with get, set
    abstract hostname: string with get, set
    abstract href: string with get, set
    abstract origin: string with get, set
    abstract password: string with get, set
    abstract pathname: string with get, set
    abstract port: string with get, set
    abstract protocol: string with get, set
    abstract search: string with get, set
    abstract username: string with get, set
    abstract assign: url: string -> unit
    abstract reload: ?forcedReload: bool -> unit
    abstract replace: url: string -> unit
    abstract toString: unit -> string

and [<AllowNullLiteral>] Storage =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract clear: unit -> unit
    abstract getItem: key: string -> obj
    abstract key: index: float -> string
    abstract removeItem: key: string -> unit
    abstract setItem: key: string * data: string -> unit

and [<AllowNullLiteral>] History =
    abstract length: int
    abstract state: obj with get, set
    abstract back: ?distance: obj -> unit
    abstract forward: ?distance: obj -> unit
    abstract go: ?delta: obj -> unit
    abstract pushState: statedata: obj * ?title: string * ?url: string -> unit
    abstract replaceState: statedata: obj * ?title: string * ?url: string -> unit

and [<AllowNullLiteral>] Performance =
    abstract clearMarks: ?markName: string -> unit
    abstract clearMeasures: ?measureName: string -> unit
    abstract clearResourceTimings: unit -> unit
    // TODO: Typed overloads to get the corresponding PerformanceEntry subtype
    // See https://developer.mozilla.org/en-US/docs/Web/API/PerformanceEntry
    abstract getEntries: unit -> obj
    abstract getEntriesByName: name: string * ?entryType: string -> obj
    abstract getEntriesByType: entryType: string -> obj
    abstract mark: markName: string -> unit
    abstract ``measure``: measureName: string * ?startMarkName: string * ?endMarkName: string -> unit
    abstract now: unit -> float
    abstract setResourceTimingBufferSize: maxSize: float -> unit
    abstract toJSON: unit -> obj

and [<AllowNullLiteral>] WindowTimers =
    inherit WindowTimersExtension
    abstract clearInterval: handle: float -> unit
    abstract clearTimeout: handle: float -> unit
    abstract setInterval: handler: obj * timeout: int * [<ParamArray>] args: obj[] -> float
    abstract setTimeout: handler: obj * timeout: int * [<ParamArray>] args: obj[] -> float

and [<AllowNullLiteral>] WindowTimersExtension =
    abstract clearImmediate: handle: float -> unit
    abstract setImmediate: expression: obj * [<ParamArray>] args: obj[] -> float

and [<AllowNullLiteral>] WindowLocalStorage =
    abstract localStorage: Storage with get, set

and [<AllowNullLiteral>] WindowSessionStorage =
    abstract sessionStorage: Storage with get, set

and [<AllowNullLiteral>] WindowBase64 =
    abstract atob: encodedString: string -> string
    abstract btoa: rawString: string -> string

and [<AllowNullLiteral>] Window =
    inherit EventTarget
    inherit WindowTimers
    inherit WindowSessionStorage
    inherit WindowLocalStorage
    // inherit WindowConsole
    inherit GlobalEventHandlers
    // inherit IDBEnvironment
    inherit WindowBase64
    abstract animationStartTime: float with get, set
    // abstract applicationCache: ApplicationCache with get, set
    // abstract clientInformation: Navigator with get, set
    abstract closed: bool with get, set
    // abstract crypto: Crypto with get, set
    abstract defaultStatus: string with get, set
    abstract devicePixelRatio: float with get, set
    abstract doNotTrack: string with get, set
    abstract document: Document with get, set
    abstract ``event``: Event with get, set
    // abstract ``external``: External with get, set
    abstract frameElement: Element with get, set
    abstract frames: Window with get, set
    abstract history: History with get, set
    abstract innerHeight: float with get, set
    abstract innerWidth: float with get, set
    abstract length: int
    abstract location: Location with get, set
    abstract locationbar: BarProp with get, set
    abstract menubar: BarProp with get, set
    abstract name: string with get, set
    // abstract navigator: Navigator with get, set
    abstract offscreenBuffering: bool with get, set
    abstract onabort: (Event -> 'Out) with get, set
    abstract onafterprint: (Event -> 'Out) with get, set
    abstract onbeforeprint: (Event -> 'Out) with get, set
    abstract onbeforeunload: (BeforeUnloadEvent -> 'Out) with get, set
    abstract onblur: (FocusEvent -> 'Out) with get, set
    abstract oncanplay: (Event -> 'Out) with get, set
    abstract oncanplaythrough: (Event -> 'Out) with get, set
    abstract onchange: (Event -> 'Out) with get, set
    abstract onclick: (MouseEvent -> 'Out) with get, set
    abstract oncompassneedscalibration: (Event -> 'Out) with get, set
    abstract oncontextmenu: (PointerEvent -> 'Out) with get, set
    abstract ondblclick: (MouseEvent -> 'Out) with get, set
    abstract ondevicemotion: (DeviceMotionEvent -> 'Out) with get, set
    abstract ondeviceorientation: (DeviceOrientationEvent -> 'Out) with get, set
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
    abstract onhashchange: (HashChangeEvent -> 'Out) with get, set
    abstract oninput: (Event -> 'Out) with get, set
    abstract onkeydown: (KeyboardEvent -> 'Out) with get, set
    abstract onkeypress: (KeyboardEvent -> 'Out) with get, set
    abstract onkeyup: (KeyboardEvent -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract onloadeddata: (Event -> 'Out) with get, set
    abstract onloadedmetadata: (Event -> 'Out) with get, set
    abstract onloadstart: (Event -> 'Out) with get, set
    abstract onmessage: (MessageEvent -> 'Out) with get, set
    abstract onmousedown: (MouseEvent -> 'Out) with get, set
    abstract onmouseenter: (MouseEvent -> 'Out) with get, set
    abstract onmouseleave: (MouseEvent -> 'Out) with get, set
    abstract onmousemove: (MouseEvent -> 'Out) with get, set
    abstract onmouseout: (MouseEvent -> 'Out) with get, set
    abstract onmouseover: (MouseEvent -> 'Out) with get, set
    abstract onmouseup: (MouseEvent -> 'Out) with get, set
    abstract onmousewheel: (MouseWheelEvent -> 'Out) with get, set
    abstract onoffline: (Event -> 'Out) with get, set
    abstract ononline: (Event -> 'Out) with get, set
    abstract onorientationchange: (Event -> 'Out) with get, set
    abstract onpagehide: (PageTransitionEvent -> 'Out) with get, set
    abstract onpageshow: (PageTransitionEvent -> 'Out) with get, set
    abstract onpause: (Event -> 'Out) with get, set
    abstract onplay: (Event -> 'Out) with get, set
    abstract onplaying: (Event -> 'Out) with get, set
    abstract onpopstate: (PopStateEvent -> 'Out) with get, set
    abstract onprogress: (ProgressEvent -> 'Out) with get, set
    abstract onratechange: (Event -> 'Out) with get, set
    abstract onreadystatechange: (ProgressEvent -> 'Out) with get, set
    abstract onreset: (Event -> 'Out) with get, set
    abstract onresize: (UIEvent -> 'Out) with get, set
    abstract onscroll: (UIEvent -> 'Out) with get, set
    abstract onseeked: (Event -> 'Out) with get, set
    abstract onseeking: (Event -> 'Out) with get, set
    abstract onselect: (UIEvent -> 'Out) with get, set
    abstract onstalled: (Event -> 'Out) with get, set
    abstract onstorage: (StorageEvent -> 'Out) with get, set
    abstract onsubmit: (Event -> 'Out) with get, set
    abstract onsuspend: (Event -> 'Out) with get, set
    abstract ontimeupdate: (Event -> 'Out) with get, set
    abstract ontouchcancel: obj with get, set
    abstract ontouchend: obj with get, set
    abstract ontouchmove: obj with get, set
    abstract ontouchstart: obj with get, set
    abstract onunload: (Event -> 'Out) with get, set
    abstract onvolumechange: (Event -> 'Out) with get, set
    abstract onwaiting: (Event -> 'Out) with get, set
    abstract opener: Window with get, set
    abstract orientation: string with get, set
    abstract outerHeight: float with get, set
    abstract outerWidth: float with get, set
    abstract pageXOffset: float with get, set
    abstract pageYOffset: float with get, set
    abstract parent: Window with get, set
    abstract performance: Performance with get, set
    abstract personalbar: BarProp with get, set
    abstract screen: Screen with get, set
    abstract screenLeft: float with get, set
    abstract screenTop: float with get, set
    abstract screenX: float with get, set
    abstract screenY: float with get, set
    abstract scrollX: float with get, set
    abstract scrollY: float with get, set
    abstract scrollbars: BarProp with get, set
    abstract self: Window with get, set
    abstract status: string with get, set
    abstract statusbar: BarProp with get, set
    // abstract styleMedia: StyleMedia with get, set
    abstract toolbar: BarProp with get, set
    abstract top: Window with get, set
    abstract window: Window with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Window with get, set
    abstract alert: ?message: obj -> unit
    abstract blur: unit -> unit
    abstract cancelAnimationFrame: handle: float -> unit
    abstract captureEvents: unit -> unit
    abstract close: unit -> unit
    abstract confirm: ?message: string -> bool
    abstract focus: unit -> unit
    // abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
    // abstract getMatchedCSSRules: elt: Element * ?pseudoElt: string -> CSSRuleList
    abstract getSelection: unit -> Selection
    // abstract matchMedia: mediaQuery: string -> MediaQueryList
    abstract moveBy: ?x: float * ?y: float -> unit
    abstract moveTo: ?x: float * ?y: float -> unit
    abstract ``open``: ?url: string * ?target: string * ?features: string * ?replace: bool -> Window
    abstract postMessage: message: obj * targetOrigin: string * ?ports: obj -> unit
    abstract print: unit -> unit
    abstract prompt: ?message: string * ?_default: string -> string
    abstract releaseEvents: unit -> unit
    abstract requestAnimationFrame: callback: (float -> unit) -> float
    abstract resizeBy: ?x: float * ?y: float -> unit
    abstract resizeTo: ?x: float * ?y: float -> unit
    abstract scroll: ?x: float * ?y: float -> unit
    abstract scrollBy: ?x: float * ?y: float -> unit
    abstract scrollTo: ?x: float * ?y: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] AbstractWorker =
    abstract onerror: (Event -> 'Out) with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] Worker =
    inherit EventTarget
    inherit AbstractWorker
    abstract onmessage: (MessageEvent -> 'Out) with get, set
    abstract postMessage: message: obj * ?ports: obj -> unit
    abstract terminate: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] WorkerType =
    [<Emit("new $0($1...)")>] abstract Create: stringUrl: string -> Worker

and [<AllowNullLiteral>] XMLDocument =
    inherit Document

and [<AllowNullLiteral>] XMLDocumentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> XMLDocument
