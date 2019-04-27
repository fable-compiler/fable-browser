namespace rec Browser.Types

open System
open Fable.Core

type [<AllowNullLiteral>] Attr =
    inherit Node
    abstract name: string with get, set
    abstract ownerElement: Element with get, set
    abstract specified: bool with get, set
    abstract value: string with get, set

type [<AllowNullLiteral>] AttrType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Attr

type [<AllowNullLiteral>] CDATASection =
    inherit Text

type [<AllowNullLiteral>] CDATASectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CDATASection

type [<AllowNullLiteral>] CharacterData =
    inherit Node
    inherit ChildNode
    abstract data: string with get, set
    abstract length: int
    abstract appendData: arg: string -> unit
    abstract deleteData: offset: float * count: float -> unit
    abstract insertData: offset: float * arg: string -> unit
    abstract replaceData: offset: float * count: float * arg: string -> unit
    abstract substringData: offset: float * count: float -> string

type [<AllowNullLiteral>] CharacterDataType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CharacterData

type [<AllowNullLiteral>] ChildNode =
    abstract remove: unit -> unit

type [<AllowNullLiteral>] Comment =
    inherit CharacterData
    abstract text: string with get, set

type [<AllowNullLiteral>] CommentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Comment

type [<AllowNullLiteral>] Document =
    inherit Node
    inherit GlobalEventHandlers
    inherit NodeSelector
    inherit DocumentEvent
    /// Gets the root svg element in the document hierarchy.
    abstract rootElement: SVGSVGElement with get, set
    /// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
    abstract styleSheets: StyleSheetList with get, set
    // TODO
    // abstract createExpression: expression: string * resolver: XPathNSResolver -> XPathExpression
    // abstract createNSResolver: nodeResolver: Node -> XPathNSResolver
    // abstract evaluate: expression: string * contextNode: Node * resolver: XPathNSResolver * ``type``: float * result: XPathResult -> XPathResult

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
    /// Retrieves a collection of all script objects in the document.
    abstract scripts: HTMLCollection with get, set
    abstract security: string with get, set
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

type [<AllowNullLiteral>] DocumentType =
    abstract entities: NamedNodeMap with get, set
    abstract internalSubset: string with get, set
    abstract name: string with get, set
    abstract notations: NamedNodeMap with get, set
    abstract publicId: string with get, set
    abstract systemId: string with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> Document
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

type [<AllowNullLiteral>] DocumentFragment =
    inherit Node
    inherit NodeSelector

type [<AllowNullLiteral>] DocumentFragmentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DocumentFragment

type [<AllowNullLiteral>] DocumentTypeType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DocumentType

type [<AllowNullLiteral>] DOMImplementation =
    abstract createDocument: namespaceURI: string * qualifiedName: string * doctype: DocumentType -> Document
    abstract createDocumentType: qualifiedName: string * publicId: string * systemId: string -> DocumentType
    abstract createHTMLDocument: title: string -> Document
    abstract hasFeature: feature: string * version: string -> bool

type [<AllowNullLiteral>] DOMImplementationType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMImplementation

type [<AllowNullLiteral>] DOMStringList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract contains: str: string -> bool
    abstract item: index: float -> string

type [<AllowNullLiteral>] DOMStringListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMStringList

type [<AllowNullLiteral>] DOMStringMap =
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> string with get, set

type [<AllowNullLiteral>] DOMStringMapType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMStringMap

type [<AllowNullLiteral>] DOMTokenList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    abstract add: [<ParamArray>] token: string[] -> unit
    abstract contains: token: string -> bool
    abstract item: index: float -> string
    abstract remove: [<ParamArray>] token: string[] -> unit
    abstract toString: unit -> string
    abstract toggle: token: string * ?force: bool -> bool

type [<AllowNullLiteral>] DOMTokenListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMTokenList

type [<AllowNullLiteral>] Element =
    inherit Node
    inherit GlobalEventHandlers
    inherit NodeSelector
    inherit ChildNode
    abstract classList: DOMTokenList with get, set
    abstract clientHeight: float with get, set
    abstract clientLeft: float with get, set
    abstract clientTop: float with get, set
    abstract clientWidth: float with get, set
    /// <summary>Returns the closest ancestor of the current element (or the current element itself) which matches the selectors given in a parameter</summary>
    /// <param name="selectors">DOMString containing a selector list such as "p:hover, .toto + q"</param>
    /// <exception cref="Fable.Core.JS.SyntaxError">Thrown if the selectors is not a valid selector list string.</exception>
    /// <returns>The `Element` which is the closest ancestor of the selected elements</returns>
    abstract closest: selectors : string -> Element option
    /// <summary>Returns the closest ancestor of the current element (or the current element itself) which matches the selectors given in a parameter</summary>
    /// <param name="element">The `Element` at the top of the tree of elements to be dealt with</param>
    /// <returns>The `Element` which is the closest ancestor of the selected elements</returns>
    abstract closest: element : Element -> Element option
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

type [<AllowNullLiteral>] ElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Element

type [<AllowNullLiteral>] HTMLCollection =
    /// Sets or retrieves the number of objects in a collection.
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Element with get, set
    /// Retrieves an object from various collections.
    abstract item: ?nameOrIndex: obj * ?optionalIndex: obj -> Element
    /// Retrieves a form object or an object from an elements collection.
    /// Sets or retrieves the frame name.
    abstract namedItem: name: string -> Element

type [<AllowNullLiteral>] HTMLCollectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLCollection

type [<AllowNullLiteral>] NamedNodeMap =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Attr with get, set
    abstract getNamedItem: name: string -> Attr
    abstract getNamedItemNS: namespaceURI: string * localName: string -> Attr
    abstract item: index: float -> Attr
    abstract removeNamedItem: name: string -> Attr
    abstract removeNamedItemNS: namespaceURI: string * localName: string -> Attr
    abstract setNamedItem: arg: Attr -> Attr
    abstract setNamedItemNS: arg: Attr -> Attr

type [<AllowNullLiteral>] NamedNodeMapType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> NamedNodeMap

type [<AllowNullLiteral>] Node =
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

type [<AllowNullLiteral>] NodeType =
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

type [<AllowNullLiteral>] NodeSelector =
    abstract querySelector: selectors: string -> Element
    abstract querySelectorAll: selectors: string -> NodeListOf<Element>

type [<AllowNullLiteral>] NodeFilter =
    abstract acceptNode: n: Node -> float

type [<AllowNullLiteral>] NodeFilterType =
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

type [<AllowNullLiteral>] NodeIterator =
    abstract filter: NodeFilter with get, set
    abstract root: Node with get, set
    abstract whatToShow: float with get, set
    abstract detach: unit -> unit
    abstract nextNode: unit -> Node
    abstract previousNode: unit -> Node

type [<AllowNullLiteral>] NodeIteratorType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> NodeIterator

type [<AllowNullLiteral>] NodeList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Node with get, set
    abstract item: index: float -> Node

type [<AllowNullLiteral>] NodeListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> NodeList

type [<AllowNullLiteral>] NodeListOf<'TNode> =
    inherit NodeList
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> 'TNode with get, set
    abstract item: index: float -> 'TNode

type [<AllowNullLiteral>] ProcessingInstruction =
    inherit CharacterData
    abstract target: string with get, set

type [<AllowNullLiteral>] ProcessingInstructionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> ProcessingInstruction

type [<AllowNullLiteral>] Selection =
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

type [<AllowNullLiteral>] SelectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Selection

type [<AllowNullLiteral>] ClientRect =
    abstract bottom: float with get, set
    abstract height: float with get, set
    abstract left: float with get, set
    abstract right: float with get, set
    abstract top: float with get, set
    abstract width: float with get, set

type [<AllowNullLiteral>] ClientRectType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> ClientRect

type [<AllowNullLiteral>] Range =
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

type [<AllowNullLiteral>] RangeType =
    abstract END_TO_END: float with get, set
    abstract END_TO_START: float with get, set
    abstract START_TO_END: float with get, set
    abstract START_TO_START: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> Range

type [<AllowNullLiteral>] Text =
    inherit CharacterData
    abstract wholeText: string with get, set
    abstract replaceWholeText: content: string -> Text
    abstract splitText: offset: float -> Text

type [<AllowNullLiteral>] TextType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Text

type [<AllowNullLiteral>] TimeRanges =
    abstract length: int
    abstract ``end``: index: float -> float
    abstract start: index: float -> float

type [<AllowNullLiteral>] TimeRangesType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TimeRanges

type [<AllowNullLiteral>] TreeWalker =
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

type [<AllowNullLiteral>] TreeWalkerType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TreeWalker

type [<AllowNullLiteral>] BarProp =
    abstract visible: bool with get, set

type [<AllowNullLiteral>] Screen =
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

type [<AllowNullLiteral>] Location =
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

type [<AllowNullLiteral>] WindowTimers =
    inherit WindowTimersExtension
    abstract clearInterval: handle: float -> unit
    abstract clearTimeout: handle: float -> unit
    abstract setInterval: handler: obj * timeout: int * [<ParamArray>] args: obj[] -> float
    abstract setTimeout: handler: obj * timeout: int * [<ParamArray>] args: obj[] -> float

type [<AllowNullLiteral>] WindowTimersExtension =
    abstract clearImmediate: handle: float -> unit
    abstract setImmediate: expression: obj * [<ParamArray>] args: obj[] -> float

type [<AllowNullLiteral>] WindowLocalStorage =
    abstract localStorage: Storage with get, set

type [<AllowNullLiteral>] WindowSessionStorage =
    abstract sessionStorage: Storage with get, set

type [<AllowNullLiteral>] WindowBase64 =
    abstract atob: encodedString: string -> string
    abstract btoa: rawString: string -> string

type [<AllowNullLiteral>] Window =
    inherit EventTarget
    inherit WindowTimers
    inherit WindowSessionStorage
    inherit WindowLocalStorage
    inherit GlobalEventHandlers
    inherit WindowBase64
    // TODO
    abstract performance: Performance with get, set
    // abstract clientInformation: Navigator with get, set
    // abstract crypto: Crypto with get, set
    // abstract navigator: Navigator with get, set
    abstract styleMedia: StyleMedia with get, set
    abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
    abstract getMatchedCSSRules: elt: Element * ?pseudoElt: string -> CSSRuleList
    // abstract matchMedia: mediaQuery: string -> MediaQueryList
    abstract animationStartTime: float with get, set
    abstract closed: bool with get, set
    abstract defaultStatus: string with get, set
    abstract devicePixelRatio: float with get, set
    abstract doNotTrack: string with get, set
    abstract document: Document with get, set
    abstract ``event``: Event with get, set
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
    abstract getSelection: unit -> Selection
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

type [<AllowNullLiteral>] AbstractWorker =
    abstract onerror: (Event -> 'Out) with get, set


type [<AllowNullLiteral>] Worker =
    inherit EventTarget
    inherit AbstractWorker
    abstract onmessage: (MessageEvent -> 'Out) with get, set
    abstract postMessage: message: obj * ?ports: obj -> unit
    abstract terminate: unit -> unit

type [<AllowNullLiteral>] WorkerType =
    [<Emit("new $0($1...)")>] abstract Create: stringUrl: string -> Worker

type [<AllowNullLiteral>] XMLDocument =
    inherit Document

type [<AllowNullLiteral>] XMLDocumentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> XMLDocument

// ## HTML

type [<AllowNullLiteral>] GetSVGDocument =
    abstract getSVGDocument: unit -> Document

type [<AllowNullLiteral>] GlobalEventHandlers =
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

type [<AllowNullLiteral>] HTMLAllCollection =
    inherit HTMLCollection
    /// Sets or retrieves the shape of the object.
    /// Retrieves a select object or an object from an options collection.
    abstract namedItem: name: string -> Element

type [<AllowNullLiteral>] HTMLAllCollectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAllCollection

type [<AllowNullLiteral>] HTMLAnchorElement =
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

type [<AllowNullLiteral>] HTMLAnchorElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAnchorElement

type [<AllowNullLiteral>] HTMLAreaElement =
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

type [<AllowNullLiteral>] HTMLAreaElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAreaElement

type [<AllowNullLiteral>] HTMLAreasCollection =
    inherit HTMLCollection
    /// <summary>Adds an element to the areas, controlRange, or options collection.</summary>
    /// <param name="element">Variant of type Number that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
    /// <param name="before">Variant of type Object that specifies an element to insert before, or null to append the object to the collection.</param>
    abstract add: element: HTMLElement * ?before: U2<HTMLElement, float> -> unit
    /// <summary>Removes an element from the collection.</summary>
    /// <param name="index">Number that specifies the zero-based index of the element to remove from the collection.</param>
    abstract remove: ?index: float -> unit

type [<AllowNullLiteral>] HTMLAreasCollectionType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAreasCollection

type [<AllowNullLiteral>] HTMLAudioElement =
    inherit HTMLMediaElement

type [<AllowNullLiteral>] HTMLAudioElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAudioElement

type [<AllowNullLiteral>] HTMLBRElement =
    inherit HTMLElement
    /// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
    abstract clear: string with get, set

type [<AllowNullLiteral>] HTMLBRElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBRElement

type [<AllowNullLiteral>] HTMLBaseElement =
    inherit HTMLElement
    /// Sets or retrieves a destination URL or an anchor point.
    abstract href: string with get, set
    /// Sets or retrieves the window or frame at which to target content.
    abstract target: string with get, set

type [<AllowNullLiteral>] HTMLBaseElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBaseElement

type [<AllowNullLiteral>] HTMLBlockElement =
    inherit HTMLElement
    /// Sets or retrieves reference information about the object.
    abstract cite: string with get, set
    abstract clear: string with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set

type [<AllowNullLiteral>] HTMLBlockElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBlockElement

type [<AllowNullLiteral>] HTMLBodyElement =
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
    abstract onunload: (Event -> 'Out) with get, set
    /// Sets or retrieves the text string specified by the option tag.
    abstract text: obj with get, set
    abstract vLink: obj with get, set

type [<AllowNullLiteral>] HTMLBodyElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBodyElement

type [<AllowNullLiteral>] HTMLButtonElement =
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

type [<AllowNullLiteral>] HTMLButtonElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLButtonElement

type [<AllowNullLiteral>] HTMLCanvasElement =
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

type [<AllowNullLiteral>] HTMLCanvasElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLCanvasElement

type [<AllowNullLiteral>] HTMLDDElement =
    inherit HTMLElement
    /// Sets or retrieves whether the browser automatically performs wordwrap.
    abstract noWrap: bool with get, set

type [<AllowNullLiteral>] HTMLDDElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDDElement

type [<AllowNullLiteral>] HTMLDListElement =
    inherit HTMLElement
    abstract compact: bool with get, set

type [<AllowNullLiteral>] HTMLDListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDListElement

type [<AllowNullLiteral>] HTMLDTElement =
    inherit HTMLElement
    abstract noWrap: bool with get, set

type [<AllowNullLiteral>] HTMLDTElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDTElement

type [<AllowNullLiteral>] HTMLDataListElement =
    inherit HTMLElement
    abstract options: HTMLCollection with get, set

type [<AllowNullLiteral>] HTMLDataListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDataListElement

type [<AllowNullLiteral>] HTMLDirectoryElement =
    inherit HTMLElement
    abstract compact: bool with get, set

type [<AllowNullLiteral>] HTMLDirectoryElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDirectoryElement

type [<AllowNullLiteral>] HTMLDivElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract noWrap: bool with get, set

type [<AllowNullLiteral>] HTMLDivElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDivElement

type [<AllowNullLiteral>] HTMLDocument =
    inherit Document

type [<AllowNullLiteral>] HTMLDocumentType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDocument

type [<AllowNullLiteral>] HTMLElement =
    inherit Element
    // TODO
    abstract style: CSSStyleDeclaration with get, set
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

type [<AllowNullLiteral>] HTMLElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLElement

type [<AllowNullLiteral>] HTMLEmbedElement =
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

type [<AllowNullLiteral>] HTMLEmbedElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLEmbedElement

type [<AllowNullLiteral>] HTMLFieldSetElement =
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

type [<AllowNullLiteral>] HTMLFieldSetElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFieldSetElement

type [<AllowNullLiteral>] HTMLFontElement =
    inherit HTMLElement
    /// Sets or retrieves the current typeface family.
    abstract face: string with get, set

type [<AllowNullLiteral>] HTMLFontElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFontElement

type [<AllowNullLiteral>] HTMLFormElement =
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

type [<AllowNullLiteral>] HTMLFormElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFormElement

type [<AllowNullLiteral>] HTMLFrameElement =
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

type [<AllowNullLiteral>] HTMLFrameElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFrameElement

type [<AllowNullLiteral>] HTMLHRElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    /// Sets or retrieves whether the horizontal rule is drawn with 3-D shading.
    abstract noShade: bool with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set

type [<AllowNullLiteral>] HTMLHRElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHRElement

type [<AllowNullLiteral>] HTMLHeadElement =
    inherit HTMLElement
    abstract profile: string with get, set

type [<AllowNullLiteral>] HTMLHeadElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHeadElement

type [<AllowNullLiteral>] HTMLHeadingElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract clear: string with get, set

type [<AllowNullLiteral>] HTMLHeadingElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHeadingElement

type [<AllowNullLiteral>] HTMLHtmlElement =
    inherit HTMLElement
    /// Sets or retrieves the DTD version that governs the current document.
    abstract version: string with get, set

type [<AllowNullLiteral>] HTMLHtmlElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHtmlElement

type [<AllowNullLiteral>] HTMLIFrameElement =
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
    /// Sets or retrieves whether the frame can be scrolled.
    abstract scrolling: string with get, set
    abstract security: obj with get, set
    /// Sets or retrieves a URL to be loaded by the object.
    abstract src: string with get, set
    /// Sets or retrieves the vertical margin for the object.
    abstract vspace: float with get, set
    /// Sets or retrieves the width of the object.
    abstract width: string with get, set

type [<AllowNullLiteral>] HTMLIFrameElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLIFrameElement

type [<AllowNullLiteral>] HTMLImageElement =
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

type [<AllowNullLiteral>] HTMLImageElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLImageElement
    abstract create: unit -> HTMLImageElement

type [<AllowNullLiteral>] HTMLInputElement =
    inherit HTMLElement
    /// Returns a FileList object on a file type input object.
    abstract files: FileList with get, set
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
    abstract indeterminate: bool with get, set
    /// Specifies the ID of a pre-defined datalist of options for an input element.
    abstract list: HTMLElement with get, set
    /// Defines the maximum acceptable value for an input element with type="number".When used with the min and step attributes, lets you control the range and increment (such as only even numbers) that the user can enter into an input field.
    abstract max: string with get, set
    /// Sets or retrieves the maximum number of characters that the user can enter in a text control.
    /// Defines the maximum, or "done" value for a progress element.
    abstract maxLength: int with get, set
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
    abstract selectionEnd: int with get, set
    /// Gets or sets the starting position or offset of a text selection.
    /// Highlights the input area of a form element.
    abstract selectionStart: int with get, set
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
    abstract setSelectionRange: start: int * ``end``: int -> unit
    /// <summary>Decrements a range input control's value by the value given by the Step attribute. If the optional parameter is used, it will decrement the input control's step value multiplied by the parameter's value.</summary>
    /// <param name="n">Value to decrement the value by.</param>
    abstract stepDown: ?n: float -> unit
    /// <summary>Increments a range input control's value by the value given by the Step attribute. If the optional parameter is used, will increment the input control's value by that value.</summary>
    /// <param name="n">Value to increment the value by.</param>
    abstract stepUp: ?n: float -> unit

type [<AllowNullLiteral>] HTMLInputElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLInputElement

type [<AllowNullLiteral>] HTMLLIElement =
    inherit HTMLElement
    /// Sets or retrieves the MIME type of the object.
    abstract ``type``: string with get, set
    /// Sets or retrieves the value which is returned to the server when the form control is submitted.
    abstract value: float with get, set

type [<AllowNullLiteral>] HTMLLIElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLIElement

type [<AllowNullLiteral>] HTMLLabelElement =
    inherit HTMLElement
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the object to which the given label object is assigned.
    abstract htmlFor: string with get, set

type [<AllowNullLiteral>] HTMLLabelElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLabelElement

type [<AllowNullLiteral>] HTMLLegendElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract form: HTMLFormElement with get, set

type [<AllowNullLiteral>] HTMLLegendElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLegendElement

type [<AllowNullLiteral>] HTMLLinkElement =
    inherit HTMLElement
    // TODO
    inherit LinkStyle
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

type [<AllowNullLiteral>] HTMLLinkElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLinkElement

type [<AllowNullLiteral>] HTMLMapElement =
    inherit HTMLElement
    /// Retrieves a collection of the area objects defined for the given map object.
    abstract areas: HTMLAreasCollection with get, set
    /// Sets or retrieves the name of the object.
    abstract name: string with get, set

type [<AllowNullLiteral>] HTMLMapElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMapElement

type [<AllowNullLiteral>] HTMLMediaElement =
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

type [<AllowNullLiteral>] HTMLMediaElementType =
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

type [<AllowNullLiteral>] HTMLMenuElement =
    inherit HTMLElement
    abstract compact: bool with get, set
    /// Sets or retrieves the MIME type for the associated scripting engine.
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] HTMLMenuElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMenuElement

type [<AllowNullLiteral>] HTMLMetaElement =
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

type [<AllowNullLiteral>] HTMLMetaElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMetaElement

type [<AllowNullLiteral>] HTMLModElement =
    inherit HTMLElement
    /// Sets or retrieves reference information about the object.
    abstract cite: string with get, set
    /// Sets or retrieves the date and time of a modification to the object.
    abstract dateTime: string with get, set

type [<AllowNullLiteral>] HTMLModElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLModElement

type [<AllowNullLiteral>] HTMLNextIdElement =
    inherit HTMLElement
    abstract n: string with get, set

type [<AllowNullLiteral>] HTMLNextIdElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLNextIdElement

type [<AllowNullLiteral>] HTMLOListElement =
    inherit HTMLElement
    abstract compact: bool with get, set
    abstract start: float with get, set
    /// Retrieves the type of select control based on the value of the MULTIPLE attribute.
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] HTMLOListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOListElement

type [<AllowNullLiteral>] HTMLObjectElement =
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

type [<AllowNullLiteral>] HTMLObjectElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLObjectElement

type [<AllowNullLiteral>] HTMLOptGroupElement =
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

type [<AllowNullLiteral>] HTMLOptGroupElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOptGroupElement

type [<AllowNullLiteral>] HTMLOptionElement =
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

type [<AllowNullLiteral>] HTMLOptionElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOptionElement
    abstract create: unit -> HTMLOptionElement

type [<AllowNullLiteral>] HTMLParagraphElement =
    inherit HTMLElement
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    abstract clear: string with get, set

type [<AllowNullLiteral>] HTMLParagraphElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLParagraphElement

type [<AllowNullLiteral>] HTMLParamElement =
    inherit HTMLElement
    abstract name: string with get, set
    /// Retrieves the CSS language in which the style sheet is written.
    abstract ``type``: string with get, set
    /// Sets or retrieves the value which is returned to the server when the form control is submitted.
    abstract value: string with get, set
    /// Sets or retrieves the data type of the value attribute.
    /// Retrieves or sets the text in the entry field of the textArea element.
    abstract valueType: string with get, set

type [<AllowNullLiteral>] HTMLParamElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLParamElement

type [<AllowNullLiteral>] HTMLPhraseElement =
    inherit HTMLElement
    abstract cite: string with get, set
    abstract dateTime: string with get, set

type [<AllowNullLiteral>] HTMLPhraseElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPhraseElement

type [<AllowNullLiteral>] HTMLPreElement =
    inherit HTMLElement
    abstract cite: string with get, set
    abstract clear: string with get, set
    /// Sets or retrieves the width of the object.
    abstract width: float with get, set

type [<AllowNullLiteral>] HTMLPreElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPreElement

type [<AllowNullLiteral>] HTMLProgressElement =
    inherit HTMLElement
    abstract form: HTMLFormElement with get, set
    abstract max: float with get, set
    /// Returns the quotient of value/max when the value attribute is set (determinate progress bar), or -1 when the value attribute is missing (indeterminate progress bar).
    abstract position: float with get, set
    abstract value: float with get, set

type [<AllowNullLiteral>] HTMLProgressElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLProgressElement

type [<AllowNullLiteral>] HTMLQuoteElement =
    inherit HTMLElement
    abstract cite: string with get, set
    abstract dateTime: string with get, set

type [<AllowNullLiteral>] HTMLQuoteElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLQuoteElement

type [<AllowNullLiteral>] HTMLScriptElement =
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

type [<AllowNullLiteral>] HTMLScriptElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLScriptElement

type [<AllowNullLiteral>] HTMLSelectElement =
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

type [<AllowNullLiteral>] HTMLSelectElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSelectElement

type [<AllowNullLiteral>] HTMLSourceElement =
    inherit HTMLElement
    /// Gets or sets the intended media type of the media source.
    abstract media: string with get, set
    abstract src: string with get, set
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] HTMLSourceElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSourceElement

type [<AllowNullLiteral>] HTMLSpanElement =
    inherit HTMLElement


type [<AllowNullLiteral>] HTMLSpanElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSpanElement

type [<AllowNullLiteral>] HTMLStyleElement =
    inherit HTMLElement
    // TODO
    inherit LinkStyle
    /// Sets or retrieves the media type.
    abstract media: string with get, set
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] HTMLStyleElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLStyleElement

type [<AllowNullLiteral>] HTMLTableCaptionElement =
    inherit HTMLElement
    /// Sets or retrieves the alignment of the object relative to the display or table.
    abstract align: string with get, set
    /// Sets or retrieves whether the caption appears at the top or bottom of the table.
    abstract vAlign: string with get, set

type [<AllowNullLiteral>] HTMLTableCaptionElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableCaptionElement

type [<AllowNullLiteral>] HTMLTableCellElement =
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

type [<AllowNullLiteral>] HTMLTableCellElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableCellElement

type [<AllowNullLiteral>] HTMLTableColElement =
    inherit HTMLElement
    inherit HTMLTableAlignment
    /// Sets or retrieves how the object is aligned with adjacent text.
    abstract align: string with get, set
    /// Sets or retrieves the number of columns in the group.
    abstract span: float with get, set
    abstract width: obj with get, set

type [<AllowNullLiteral>] HTMLTableColElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableColElement

type [<AllowNullLiteral>] HTMLTableDataCellElement =
    inherit HTMLTableCellElement


type [<AllowNullLiteral>] HTMLTableDataCellElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableDataCellElement

type [<AllowNullLiteral>] HTMLTableElement =
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

type [<AllowNullLiteral>] HTMLTableElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableElement

type [<AllowNullLiteral>] HTMLTableHeaderCellElement =
    inherit HTMLTableCellElement
    /// Sets or retrieves the group of cells in a table to which the object's information applies.
    abstract scope: string with get, set

type [<AllowNullLiteral>] HTMLTableHeaderCellElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableHeaderCellElement

type [<AllowNullLiteral>] HTMLTableRowElement =
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

type [<AllowNullLiteral>] HTMLTableRowElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableRowElement

type [<AllowNullLiteral>] HTMLTableSectionElement =
    inherit HTMLElement
    inherit HTMLTableAlignment
    abstract align: string with get, set
    /// Sets or retrieves the number of horizontal rows contained in the object.
    abstract rows: HTMLCollection with get, set
    /// <param name="index">Number that specifies the zero-based position in the rows collection of the row to remove.</param>
    abstract deleteRow: ?index: float -> unit
    /// <param name="index">Number that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
    abstract insertRow: ?index: float -> HTMLTableRowElement

type [<AllowNullLiteral>] HTMLTableSectionElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableSectionElement

type [<AllowNullLiteral>] HTMLTextAreaElement =
    inherit HTMLElement
    /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
    abstract autofocus: bool with get, set
    /// Sets or retrieves the width of the object.
    abstract cols: int with get, set
    /// Sets or retrieves the initial contents of the object.
    abstract defaultValue: string with get, set
    abstract disabled: bool with get, set
    abstract form: HTMLFormElement with get, set
    /// Sets or retrieves the maximum number of characters that the user can enter in a text control.
    abstract maxLength: int with get, set
    abstract name: string with get, set
    /// Gets or sets a text string that is displayed in an input field as a hint or prompt to users as the format or type of information they need to enter.The text appears in an input field until the user puts focus on the field.
    abstract placeholder: string with get, set
    abstract readOnly: bool with get, set
    /// When present, marks an element that can't be submitted without a value.
    abstract required: bool with get, set
    /// Sets or retrieves the number of horizontal rows contained in the object.
    abstract rows: int with get, set
    /// Gets or sets the end position or offset of a text selection.
    abstract selectionEnd: int with get, set
    /// Gets or sets the starting position or offset of a text selection.
    abstract selectionStart: int with get, set
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
    abstract setSelectionRange: start: int * ``end``: int -> unit

type [<AllowNullLiteral>] HTMLTextAreaElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTextAreaElement

type [<AllowNullLiteral>] HTMLTitleElement =
    inherit HTMLElement
    abstract text: string with get, set

type [<AllowNullLiteral>] HTMLTitleElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTitleElement

type [<AllowNullLiteral>] HTMLTrackElement =
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

type [<AllowNullLiteral>] HTMLTrackElementType =
    abstract ERROR: float with get, set
    abstract LOADED: float with get, set
    abstract LOADING: float with get, set
    abstract NONE: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTrackElement

type [<AllowNullLiteral>] HTMLUListElement =
    inherit HTMLElement
    abstract compact: bool with get, set
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] HTMLUListElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLUListElement

type [<AllowNullLiteral>] HTMLUnknownElement =
    inherit HTMLElement

type [<AllowNullLiteral>] HTMLUnknownElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLUnknownElement

type [<AllowNullLiteral>] HTMLVideoElement =
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

type [<AllowNullLiteral>] HTMLVideoElementType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLVideoElement

type [<AllowNullLiteral>] VideoPlaybackQuality =
    abstract corruptedVideoFrames: float with get, set
    abstract creationTime: float with get, set
    abstract droppedVideoFrames: float with get, set
    abstract totalFrameDelay: float with get, set
    abstract totalVideoFrames: float with get, set

type [<AllowNullLiteral>] VideoPlaybackQualityType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> VideoPlaybackQuality

type [<AllowNullLiteral>] VideoTrack =
    abstract id: string with get, set
    abstract kind: string with get, set
    abstract label: string with get, set
    abstract language: string with get, set
    abstract selected: bool with get, set
    abstract sourceBuffer: SourceBuffer with get, set

type [<AllowNullLiteral>] VideoTrackType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> VideoTrack

type [<AllowNullLiteral>] VideoTrackList =
    inherit EventTarget
    abstract length: int
    abstract onaddtrack: (TrackEvent -> 'Out) with get, set
    abstract onchange: (Event -> 'Out) with get, set
    abstract onremovetrack: (TrackEvent -> 'Out) with get, set
    abstract selectedIndex: int with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> VideoTrack with get, set
    abstract getTrackById: id: string -> VideoTrack
    abstract item: index: float -> VideoTrack

type [<AllowNullLiteral>] VideoTrackListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> VideoTrackList

type [<AllowNullLiteral>] SourceBuffer =
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

type [<AllowNullLiteral>] SourceBufferType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> SourceBuffer

type [<AllowNullLiteral>] SourceBufferList =
    inherit EventTarget
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> SourceBuffer with get, set
    abstract item: index: float -> SourceBuffer

type [<AllowNullLiteral>] SourceBufferListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> SourceBufferList

type [<AllowNullLiteral>] AudioTrack =
    abstract enabled: bool with get, set
    abstract id: string with get, set
    abstract kind: string with get, set
    abstract label: string with get, set
    abstract language: string with get, set
    abstract sourceBuffer: SourceBuffer with get, set

type [<AllowNullLiteral>] AudioTrackType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> AudioTrack

type [<AllowNullLiteral>] AudioTrackList =
    inherit EventTarget
    abstract length: int
    abstract onaddtrack: (TrackEvent -> 'Out) with get, set
    abstract onchange: (Event -> 'Out) with get, set
    abstract onremovetrack: (TrackEvent -> 'Out) with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> AudioTrack with get, set
    abstract getTrackById: id: string -> AudioTrack
    abstract item: index: float -> AudioTrack

type [<AllowNullLiteral>] AudioTrackListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> AudioTrackList

type [<AllowNullLiteral>] TextTrack =
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

type [<AllowNullLiteral>] TextTrackType =
    abstract DISABLED: float with get, set
    abstract ERROR: float with get, set
    abstract HIDDEN: float with get, set
    abstract LOADED: float with get, set
    abstract LOADING: float with get, set
    abstract NONE: float with get, set
    abstract SHOWING: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrack

type [<AllowNullLiteral>] TextTrackCue =
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

type [<AllowNullLiteral>] TextTrackCueType =
    [<Emit("new $0($1...)")>] abstract Create: startTime: float * endTime: float * text: string -> TextTrackCue

type [<AllowNullLiteral>] TextTrackCueList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextTrackCue with get, set
    abstract getCueById: id: string -> TextTrackCue
    abstract item: index: float -> TextTrackCue

type [<AllowNullLiteral>] TextTrackCueListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrackCueList

type [<AllowNullLiteral>] TextTrackList =
    inherit EventTarget
    abstract length: int
    abstract onaddtrack: (TrackEvent -> 'Out) with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextTrack with get, set
    abstract item: index: float -> TextTrack

type [<AllowNullLiteral>] TextTrackListType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrackList

type [<AllowNullLiteral>] HTMLTableAlignment =
    /// Sets or retrieves a value that you can use to implement your own ch functionality for the object.
    abstract ch: string with get, set
    /// Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
    abstract chOff: string with get, set
    /// Sets or retrieves how text and other content are vertically aligned within the object that contains them.
    abstract vAlign: string with get, set

// ## CANVAS

type [<AllowNullLiteral>] CanvasGradient =
    abstract addColorStop: offset: float * color: string -> unit

type [<AllowNullLiteral>] CanvasGradientType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasGradient

type [<AllowNullLiteral>] CanvasPattern =
    interface end

type [<AllowNullLiteral>] CanvasPatternType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasPattern

type [<AllowNullLiteral>] CanvasRenderingContext2D =
    abstract canvas: HTMLCanvasElement with get, set
    abstract fillStyle: U3<string, CanvasGradient, CanvasPattern> with get, set
    abstract font: string with get, set
    abstract globalAlpha: float with get, set
    abstract globalCompositeOperation: string with get, set
    abstract lineCap: string with get, set
    abstract lineDashOffset: float with get, set
    abstract lineJoin: string with get, set
    abstract lineWidth: float with get, set
    abstract miterLimit: float with get, set
    abstract shadowBlur: float with get, set
    abstract shadowColor: string with get, set
    abstract shadowOffsetX: float with get, set
    abstract shadowOffsetY: float with get, set
    abstract strokeStyle: U3<string, CanvasGradient, CanvasPattern> with get, set
    abstract textAlign: string with get, set
    abstract textBaseline: string with get, set
    abstract arc: x: float * y: float * radius: float * startAngle: float * endAngle: float * ?anticlockwise: bool -> unit
    abstract arcTo: x1: float * y1: float * x2: float * y2: float * radius: float -> unit
    abstract beginPath: unit -> unit
    abstract bezierCurveTo: cp1x: float * cp1y: float * cp2x: float * cp2y: float * x: float * y: float -> unit
    abstract clearRect: x: float * y: float * w: float * h: float -> unit
    abstract clip: ?fillRule: string -> unit
    abstract closePath: unit -> unit
    abstract createImageData: imageData: ImageData -> ImageData
    abstract createImageData: width: float * height: float -> ImageData
    abstract createLinearGradient: x0: float * y0: float * x1: float * y1: float -> CanvasGradient
    abstract createPattern: image: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * repetition: string -> CanvasPattern
    abstract createRadialGradient: x0: float * y0: float * r0: float * x1: float * y1: float * r1: float -> CanvasGradient
    abstract drawImage: image: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * offsetX: float * offsetY: float * ?width: float * ?height: float * ?canvasOffsetX: float * ?canvasOffsetY: float * ?canvasImageWidth: float * ?canvasImageHeight: float -> unit
    abstract fill: ?fillRule: string -> unit
    abstract fillRect: x: float * y: float * w: float * h: float -> unit
    abstract fillText: text: string * x: float * y: float * ?maxWidth: float -> unit
    abstract getImageData: sx: float * sy: float * sw: float * sh: float -> ImageData
    abstract getLineDash: unit -> array<float>
    abstract isPointInPath: x: float * y: float * ?fillRule: string -> bool
    abstract lineTo: x: float * y: float -> unit
    abstract measureText: text: string -> TextMetrics
    abstract moveTo: x: float * y: float -> unit
    abstract putImageData: imagedata: ImageData * dx: float * dy: float * ?dirtyX: float * ?dirtyY: float * ?dirtyWidth: float * ?dirtyHeight: float -> unit
    abstract quadraticCurveTo: cpx: float * cpy: float * x: float * y: float -> unit
    abstract rect: x: float * y: float * w: float * h: float -> unit
    abstract restore: unit -> unit
    abstract rotate: angle: float -> unit
    abstract save: unit -> unit
    abstract scale: x: float * y: float -> unit
    abstract setLineDash: segments: array<float> -> unit
    abstract setTransform: m11: float * m12: float * m21: float * m22: float * dx: float * dy: float -> unit
    abstract stroke: unit -> unit
    abstract strokeRect: x: float * y: float * w: float * h: float -> unit
    abstract strokeText: text: string * x: float * y: float * ?maxWidth: float -> unit
    abstract transform: m11: float * m12: float * m21: float * m22: float * dx: float * dy: float -> unit
    abstract translate: x: float * y: float -> unit

type [<AllowNullLiteral>] CanvasRenderingContext2DType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasRenderingContext2D

type [<AllowNullLiteral>] ImageData =
    abstract data: uint8[] with get, set
    abstract height: float with get, set
    abstract width: float with get, set

type [<AllowNullLiteral>] ImageDataType =
    [<Emit("new $0($1...)")>] abstract Create: width: float * height: float -> ImageData
    [<Emit("new $0($1...)")>] abstract Create: array: uint8[] * width: float * height: float -> ImageData

// ## OTHER HTML INTERFACES

type [<AllowNullLiteral>] TextMetrics =
    abstract width: float with get, set

type [<AllowNullLiteral>] TextMetricsType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> TextMetrics

type [<AllowNullLiteral>] MediaError =
    abstract code: float with get, set
    abstract MEDIA_ERR_ABORTED: float with get, set
    abstract MEDIA_ERR_DECODE: float with get, set
    abstract MEDIA_ERR_NETWORK: float with get, set
    abstract MEDIA_ERR_SRC_NOT_SUPPORTED: float with get, set

type [<AllowNullLiteral>] MediaErrorType =
    abstract MEDIA_ERR_ABORTED: float with get, set
    abstract MEDIA_ERR_DECODE: float with get, set
    abstract MEDIA_ERR_NETWORK: float with get, set
    abstract MEDIA_ERR_SRC_NOT_SUPPORTED: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> MediaError

type [<AllowNullLiteral>] ValidityState =
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

type [<AllowNullLiteral>] ValidityStateType =
    [<Emit("new $0($1...)")>] abstract Create: unit -> ValidityState

// ## EVENTS

type [<AllowNullLiteral>] UIEvent =
    inherit Event
    abstract detail: float
    abstract view: Window

type [<AllowNullLiteral>] AnimationEvent =
    inherit Event
    abstract animationName: string with get, set
    abstract elapsedTime: float with get, set

type [<AllowNullLiteral>] MouseEvent =
    inherit UIEvent
    abstract altKey: bool
    abstract button: float
    abstract buttons: float
    abstract clientX: float
    abstract clientY: float
    abstract ctrlKey: bool
    abstract fromElement: Element
    abstract layerX: float
    abstract layerY: float
    abstract metaKey: bool
    abstract movementX: float
    abstract movementY: float
    abstract offsetX: float
    abstract offsetY: float
    abstract pageX: float
    abstract pageY: float
    abstract relatedTarget: EventTarget
    abstract screenX: float
    abstract screenY: float
    abstract shiftKey: bool
    abstract toElement: Element
    abstract which: float
    abstract x: float
    abstract y: float
    abstract getModifierState: keyArg: string -> bool

type [<AllowNullLiteral>] MouseWheelEvent =
    inherit MouseEvent
    abstract wheelDelta: float
    abstract wheelDeltaX: float
    abstract wheelDeltaY: float

type [<AllowNullLiteral>] DocumentEvent =
    abstract createEvent: eventInterface: string -> Event

type [<AllowNullLiteral>] DragEvent =
    inherit MouseEvent
    abstract dataTransfer: DataTransfer

type [<AllowNullLiteral>] ClipboardEvent =
    inherit Event
    abstract clipboardData: DataTransfer

type [<AllowNullLiteral>] CompositionEvent =
    inherit UIEvent
    abstract data: string
    abstract locale: string

type [<AllowNullLiteral>] DataTransfer =
    abstract dropEffect: string
    abstract effectAllowed: string
    abstract files: FileList
    abstract items: DataTransferItemList
    abstract types: DOMStringList
    abstract clearData: ?format: string -> bool
    abstract getData: format: string -> string
    abstract setData: format: string * data: string -> bool

type [<AllowNullLiteral>] DataTransferItem =
    abstract kind: string
    abstract ``type``: string
    abstract getAsFile: unit -> File
    abstract getAsString: _callback: (string -> unit) -> unit

type [<AllowNullLiteral>] DataTransferItemList =
    abstract length: int
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> DataTransferItem
    abstract add: data: File -> DataTransferItem
    abstract clear: unit -> unit
    abstract item: index: float -> DataTransferItem
    abstract remove: index: float -> unit

type [<AllowNullLiteral>] FocusEvent =
    inherit UIEvent
    abstract relatedTarget: EventTarget

type [<AllowNullLiteral>] PointerEvent =
    inherit MouseEvent
    abstract currentPoint: obj
    abstract height: float
    abstract hwTimestamp: float
    abstract intermediatePoints: obj
    abstract isPrimary: bool
    abstract pointerId: float
    abstract pointerType: obj
    abstract pressure: float
    abstract rotation: float
    abstract tiltX: float
    abstract tiltY: float
    abstract width: float
    abstract getCurrentPoint: element: Element -> unit
    abstract getIntermediatePoints: element: Element -> unit

type [<AllowNullLiteral>] PopStateEvent =
    inherit Event
    abstract state: obj

type [<AllowNullLiteral>] KeyboardEvent =
    inherit UIEvent
    abstract altKey: bool
    abstract char: string
    abstract charCode: float
    abstract ctrlKey: bool
    abstract key: string
    abstract keyCode: float
    abstract locale: string
    abstract location: float
    abstract metaKey: bool
    abstract repeat: bool
    abstract shiftKey: bool
    abstract which: float
    abstract DOM_KEY_LOCATION_JOYSTICK: float
    abstract DOM_KEY_LOCATION_LEFT: float
    abstract DOM_KEY_LOCATION_MOBILE: float
    abstract DOM_KEY_LOCATION_NUMPAD: float
    abstract DOM_KEY_LOCATION_RIGHT: float
    abstract DOM_KEY_LOCATION_STANDARD: float
    abstract getModifierState: keyArg: string -> bool

type [<AllowNullLiteral>] ProgressEvent =
    inherit Event
    abstract lengthComputable: bool
    abstract loaded: float
    abstract total: float

type [<AllowNullLiteral>] Touch =
    abstract clientX: float
    abstract clientY: float
    abstract identifier: float
    abstract pageX: float
    abstract pageY: float
    abstract screenX: float
    abstract screenY: float
    abstract target: EventTarget

type [<AllowNullLiteral>] TouchEvent =
    inherit UIEvent
    abstract altKey: bool
    abstract changedTouches: Touch[]
    abstract ctrlKey: bool
    abstract metaKey: bool
    abstract shiftKey: bool
    abstract targetTouches: Touch[]
    abstract touches: Touch[]

type [<AllowNullLiteral>] AriaRequestEvent =
    inherit Event
    abstract attributeName: string
    abstract attributeValue: string

type [<AllowNullLiteral>] CommandEvent =
    inherit Event
    abstract commandName: string
    abstract detail: string

type [<AllowNullLiteral>] BeforeUnloadEvent =
    inherit Event
    abstract returnValue: obj

type [<AllowNullLiteral>] DeviceMotionEvent =
    inherit Event
    abstract acceleration: DeviceAcceleration
    abstract accelerationIncludingGravity: DeviceAcceleration
    abstract interval: float
    abstract rotationRate: DeviceRotationRate

type [<AllowNullLiteral>] DeviceOrientationEvent =
    inherit Event
    abstract absolute: bool
    abstract alpha: float
    abstract beta: float
    abstract gamma: float

type [<AllowNullLiteral>] DeviceAcceleration =
    abstract x: float
    abstract y: float
    abstract z: float

type [<AllowNullLiteral>] DeviceRotationRate =
    abstract alpha: float
    abstract beta: float
    abstract gamma: float

type [<AllowNullLiteral>] TransitionEvent =
    inherit Event
    abstract elapsedTime: float with get, set
    abstract propertyName: string with get, set

type [<AllowNullLiteral>] PageTransitionEvent =
    inherit Event
    abstract persisted: bool

type [<AllowNullLiteral>] HashChangeEvent =
    inherit Event
    abstract newURL: string
    abstract oldURL: string

type [<AllowNullLiteral>] TrackEvent =
    inherit Event
    abstract track: obj

type [<AllowNullLiteral>] WheelEvent =
    inherit MouseEvent
    abstract deltaMode: float
    abstract deltaX: float
    abstract deltaY: float
    abstract deltaZ: float
    abstract DOM_DELTA_LINE: float
    abstract DOM_DELTA_PAGE: float
    abstract DOM_DELTA_PIXEL: float
    abstract getCurrentPoint: element: Element -> unit

// type [<AllowNullLiteral>] WheelEventType =
//     abstract DOM_DELTA_LINE: float
//     abstract DOM_DELTA_PAGE: float
//     abstract DOM_DELTA_PIXEL: float
//     [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: WheelEventInit -> WheelEvent

// ## SVG Elements

type [<AllowNullLiteral>] SVGAElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract target: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGAElementType =
    abstract prototype: SVGAElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAElement

and [<AllowNullLiteral>] SVGAngle =
    abstract unitType: float with get, set
    abstract value: float with get, set
    abstract valueAsString: string with get, set
    abstract valueInSpecifiedUnits: float with get, set
    abstract SVG_ANGLETYPE_DEG: float with get, set
    abstract SVG_ANGLETYPE_GRAD: float with get, set
    abstract SVG_ANGLETYPE_RAD: float with get, set
    abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    abstract convertToSpecifiedUnits: unitType: float -> unit
    abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

and [<AllowNullLiteral>] SVGAngleType =
    abstract prototype: SVGAngle with get, set
    abstract SVG_ANGLETYPE_DEG: float with get, set
    abstract SVG_ANGLETYPE_GRAD: float with get, set
    abstract SVG_ANGLETYPE_RAD: float with get, set
    abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAngle

and [<AllowNullLiteral>] SVGAnimatedAngle =
    abstract animVal: SVGAngle with get, set
    abstract baseVal: SVGAngle with get, set

and [<AllowNullLiteral>] SVGAnimatedAngleType =
    abstract prototype: SVGAnimatedAngle with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedAngle

and [<AllowNullLiteral>] SVGAnimatedBoolean =
    abstract animVal: bool with get, set
    abstract baseVal: bool with get, set

and [<AllowNullLiteral>] SVGAnimatedBooleanType =
    abstract prototype: SVGAnimatedBoolean with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedBoolean

and [<AllowNullLiteral>] SVGAnimatedEnumeration =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

and [<AllowNullLiteral>] SVGAnimatedEnumerationType =
    abstract prototype: SVGAnimatedEnumeration with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedEnumeration

and [<AllowNullLiteral>] SVGAnimatedInteger =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

and [<AllowNullLiteral>] SVGAnimatedIntegerType =
    abstract prototype: SVGAnimatedInteger with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedInteger

and [<AllowNullLiteral>] SVGAnimatedLength =
    abstract animVal: SVGLength with get, set
    abstract baseVal: SVGLength with get, set

and [<AllowNullLiteral>] SVGAnimatedLengthType =
    abstract prototype: SVGAnimatedLength with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedLength

and [<AllowNullLiteral>] SVGAnimatedLengthList =
    abstract animVal: SVGLengthList with get, set
    abstract baseVal: SVGLengthList with get, set

and [<AllowNullLiteral>] SVGAnimatedLengthListType =
    abstract prototype: SVGAnimatedLengthList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedLengthList

and [<AllowNullLiteral>] SVGAnimatedNumber =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

and [<AllowNullLiteral>] SVGAnimatedNumberType =
    abstract prototype: SVGAnimatedNumber with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedNumber

and [<AllowNullLiteral>] SVGAnimatedNumberList =
    abstract animVal: SVGNumberList with get, set
    abstract baseVal: SVGNumberList with get, set

and [<AllowNullLiteral>] SVGAnimatedNumberListType =
    abstract prototype: SVGAnimatedNumberList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedNumberList

and [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatio =
    abstract animVal: SVGPreserveAspectRatio with get, set
    abstract baseVal: SVGPreserveAspectRatio with get, set

and [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatioType =
    abstract prototype: SVGAnimatedPreserveAspectRatio with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedPreserveAspectRatio

and [<AllowNullLiteral>] SVGAnimatedRect =
    abstract animVal: SVGRect with get, set
    abstract baseVal: SVGRect with get, set

and [<AllowNullLiteral>] SVGAnimatedRectType =
    abstract prototype: SVGAnimatedRect with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedRect

and [<AllowNullLiteral>] SVGAnimatedString =
    abstract animVal: string with get, set
    abstract baseVal: string with get, set

and [<AllowNullLiteral>] SVGAnimatedStringType =
    abstract prototype: SVGAnimatedString with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedString

and [<AllowNullLiteral>] SVGAnimatedTransformList =
    abstract animVal: SVGTransformList with get, set
    abstract baseVal: SVGTransformList with get, set

and [<AllowNullLiteral>] SVGAnimatedTransformListType =
    abstract prototype: SVGAnimatedTransformList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedTransformList

and [<AllowNullLiteral>] SVGCircleElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract r: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGCircleElementType =
    abstract prototype: SVGCircleElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGCircleElement

and [<AllowNullLiteral>] SVGClipPathElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGUnitTypes
    abstract clipPathUnits: SVGAnimatedEnumeration with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGClipPathElementType =
    abstract prototype: SVGClipPathElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGClipPathElement

and [<AllowNullLiteral>] SVGComponentTransferFunctionElement =
    inherit SVGElement
    abstract amplitude: SVGAnimatedNumber with get, set
    abstract exponent: SVGAnimatedNumber with get, set
    abstract intercept: SVGAnimatedNumber with get, set
    abstract offset: SVGAnimatedNumber with get, set
    abstract slope: SVGAnimatedNumber with get, set
    abstract tableValues: SVGAnimatedNumberList with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set

and [<AllowNullLiteral>] SVGComponentTransferFunctionElementType =
    abstract prototype: SVGComponentTransferFunctionElement with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGComponentTransferFunctionElement

and [<AllowNullLiteral>] SVGDefsElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGDefsElementType =
    abstract prototype: SVGDefsElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGDefsElement

and [<AllowNullLiteral>] SVGDescElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGDescElementType =
    abstract prototype: SVGDescElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGDescElement

and [<AllowNullLiteral>] SVGElement =
    inherit Element
    abstract id: string with get, set
    abstract onclick: (MouseEvent -> 'Out) with get, set
    abstract ondblclick: (MouseEvent -> 'Out) with get, set
    abstract onfocusin: (FocusEvent -> 'Out) with get, set
    abstract onfocusout: (FocusEvent -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract onmousedown: (MouseEvent -> 'Out) with get, set
    abstract onmousemove: (MouseEvent -> 'Out) with get, set
    abstract onmouseout: (MouseEvent -> 'Out) with get, set
    abstract onmouseover: (MouseEvent -> 'Out) with get, set
    abstract onmouseup: (MouseEvent -> 'Out) with get, set
    abstract ownerSVGElement: SVGSVGElement with get, set
    abstract viewportElement: SVGElement with get, set
    abstract xmlbase: string with get, set
    abstract className: obj with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGElementType =
    abstract prototype: SVGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElement

and [<AllowNullLiteral>] SVGElementInstance =
    inherit EventTarget
    abstract childNodes: SVGElementInstanceList with get, set
    abstract correspondingElement: SVGElement with get, set
    abstract correspondingUseElement: SVGUseElement with get, set
    abstract firstChild: SVGElementInstance with get, set
    abstract lastChild: SVGElementInstance with get, set
    abstract nextSibling: SVGElementInstance with get, set
    abstract parentNode: SVGElementInstance with get, set
    abstract previousSibling: SVGElementInstance with get, set

and [<AllowNullLiteral>] SVGElementInstanceType =
    abstract prototype: SVGElementInstance with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElementInstance

and [<AllowNullLiteral>] SVGElementInstanceList =
    abstract length: float with get, set
    abstract item: index: float -> SVGElementInstance

and [<AllowNullLiteral>] SVGElementInstanceListType =
    abstract prototype: SVGElementInstanceList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElementInstanceList

and [<AllowNullLiteral>] SVGEllipseElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract rx: SVGAnimatedLength with get, set
    abstract ry: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGEllipseElementType =
    abstract prototype: SVGEllipseElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGEllipseElement

and [<AllowNullLiteral>] SVGFEBlendElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract mode: SVGAnimatedEnumeration with get, set
    abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_HUE: float with get, set
    abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEBlendElementType =
    abstract prototype: SVGFEBlendElement with get, set
    abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_HUE: float with get, set
    abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEBlendElement

and [<AllowNullLiteral>] SVGFEColorMatrixElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract values: SVGAnimatedNumberList with get, set
    abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEColorMatrixElementType =
    abstract prototype: SVGFEColorMatrixElement with get, set
    abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEColorMatrixElement

and [<AllowNullLiteral>] SVGFEComponentTransferElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEComponentTransferElementType =
    abstract prototype: SVGFEComponentTransferElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEComponentTransferElement

and [<AllowNullLiteral>] SVGFECompositeElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract k1: SVGAnimatedNumber with get, set
    abstract k2: SVGAnimatedNumber with get, set
    abstract k3: SVGAnimatedNumber with get, set
    abstract k4: SVGAnimatedNumber with get, set
    abstract operator: SVGAnimatedEnumeration with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFECompositeElementType =
    abstract prototype: SVGFECompositeElement with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFECompositeElement

and [<AllowNullLiteral>] SVGFEConvolveMatrixElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract bias: SVGAnimatedNumber with get, set
    abstract divisor: SVGAnimatedNumber with get, set
    abstract edgeMode: SVGAnimatedEnumeration with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract kernelMatrix: SVGAnimatedNumberList with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract orderX: SVGAnimatedInteger with get, set
    abstract orderY: SVGAnimatedInteger with get, set
    abstract preserveAlpha: SVGAnimatedBoolean with get, set
    abstract targetX: SVGAnimatedInteger with get, set
    abstract targetY: SVGAnimatedInteger with get, set
    abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    abstract SVG_EDGEMODE_NONE: float with get, set
    abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    abstract SVG_EDGEMODE_WRAP: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEConvolveMatrixElementType =
    abstract prototype: SVGFEConvolveMatrixElement with get, set
    abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    abstract SVG_EDGEMODE_NONE: float with get, set
    abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    abstract SVG_EDGEMODE_WRAP: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEConvolveMatrixElement

and [<AllowNullLiteral>] SVGFEDiffuseLightingElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract diffuseConstant: SVGAnimatedNumber with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract surfaceScale: SVGAnimatedNumber with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEDiffuseLightingElementType =
    abstract prototype: SVGFEDiffuseLightingElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDiffuseLightingElement

and [<AllowNullLiteral>] SVGFEDisplacementMapElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract scale: SVGAnimatedNumber with get, set
    abstract xChannelSelector: SVGAnimatedEnumeration with get, set
    abstract yChannelSelector: SVGAnimatedEnumeration with get, set
    abstract SVG_CHANNEL_A: float with get, set
    abstract SVG_CHANNEL_B: float with get, set
    abstract SVG_CHANNEL_G: float with get, set
    abstract SVG_CHANNEL_R: float with get, set
    abstract SVG_CHANNEL_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEDisplacementMapElementType =
    abstract prototype: SVGFEDisplacementMapElement with get, set
    abstract SVG_CHANNEL_A: float with get, set
    abstract SVG_CHANNEL_B: float with get, set
    abstract SVG_CHANNEL_G: float with get, set
    abstract SVG_CHANNEL_R: float with get, set
    abstract SVG_CHANNEL_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDisplacementMapElement

and [<AllowNullLiteral>] SVGFEDistantLightElement =
    inherit SVGElement
    abstract azimuth: SVGAnimatedNumber with get, set
    abstract elevation: SVGAnimatedNumber with get, set

and [<AllowNullLiteral>] SVGFEDistantLightElementType =
    abstract prototype: SVGFEDistantLightElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDistantLightElement

and [<AllowNullLiteral>] SVGFEFloodElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEFloodElementType =
    abstract prototype: SVGFEFloodElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFloodElement

and [<AllowNullLiteral>] SVGFEFuncAElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncAElementType =
    abstract prototype: SVGFEFuncAElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncAElement

and [<AllowNullLiteral>] SVGFEFuncBElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncBElementType =
    abstract prototype: SVGFEFuncBElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncBElement

and [<AllowNullLiteral>] SVGFEFuncGElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncGElementType =
    abstract prototype: SVGFEFuncGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncGElement

and [<AllowNullLiteral>] SVGFEFuncRElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncRElementType =
    abstract prototype: SVGFEFuncRElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncRElement

and [<AllowNullLiteral>] SVGFEGaussianBlurElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract stdDeviationX: SVGAnimatedNumber with get, set
    abstract stdDeviationY: SVGAnimatedNumber with get, set
    abstract setStdDeviation: stdDeviationX: float * stdDeviationY: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEGaussianBlurElementType =
    abstract prototype: SVGFEGaussianBlurElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEGaussianBlurElement

and [<AllowNullLiteral>] SVGFEImageElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    inherit SVGLangSpace
    inherit SVGURIReference
    inherit SVGExternalResourcesRequired
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEImageElementType =
    abstract prototype: SVGFEImageElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEImageElement

and [<AllowNullLiteral>] SVGFEMergeElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEMergeElementType =
    abstract prototype: SVGFEMergeElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMergeElement

and [<AllowNullLiteral>] SVGFEMergeNodeElement =
    inherit SVGElement
    abstract in1: SVGAnimatedString with get, set

and [<AllowNullLiteral>] SVGFEMergeNodeElementType =
    abstract prototype: SVGFEMergeNodeElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMergeNodeElement

and [<AllowNullLiteral>] SVGFEMorphologyElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract operator: SVGAnimatedEnumeration with get, set
    abstract radiusX: SVGAnimatedNumber with get, set
    abstract radiusY: SVGAnimatedNumber with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEMorphologyElementType =
    abstract prototype: SVGFEMorphologyElement with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMorphologyElement

and [<AllowNullLiteral>] SVGFEOffsetElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract dx: SVGAnimatedNumber with get, set
    abstract dy: SVGAnimatedNumber with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEOffsetElementType =
    abstract prototype: SVGFEOffsetElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEOffsetElement

and [<AllowNullLiteral>] SVGFEPointLightElement =
    inherit SVGElement
    abstract x: SVGAnimatedNumber with get, set
    abstract y: SVGAnimatedNumber with get, set
    abstract z: SVGAnimatedNumber with get, set

and [<AllowNullLiteral>] SVGFEPointLightElementType =
    abstract prototype: SVGFEPointLightElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEPointLightElement

and [<AllowNullLiteral>] SVGFESpecularLightingElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract specularConstant: SVGAnimatedNumber with get, set
    abstract specularExponent: SVGAnimatedNumber with get, set
    abstract surfaceScale: SVGAnimatedNumber with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFESpecularLightingElementType =
    abstract prototype: SVGFESpecularLightingElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFESpecularLightingElement

and [<AllowNullLiteral>] SVGFESpotLightElement =
    inherit SVGElement
    abstract limitingConeAngle: SVGAnimatedNumber with get, set
    abstract pointsAtX: SVGAnimatedNumber with get, set
    abstract pointsAtY: SVGAnimatedNumber with get, set
    abstract pointsAtZ: SVGAnimatedNumber with get, set
    abstract specularExponent: SVGAnimatedNumber with get, set
    abstract x: SVGAnimatedNumber with get, set
    abstract y: SVGAnimatedNumber with get, set
    abstract z: SVGAnimatedNumber with get, set

and [<AllowNullLiteral>] SVGFESpotLightElementType =
    abstract prototype: SVGFESpotLightElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFESpotLightElement

and [<AllowNullLiteral>] SVGFETileElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFETileElementType =
    abstract prototype: SVGFETileElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFETileElement

and [<AllowNullLiteral>] SVGFETurbulenceElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract baseFrequencyX: SVGAnimatedNumber with get, set
    abstract baseFrequencyY: SVGAnimatedNumber with get, set
    abstract numOctaves: SVGAnimatedInteger with get, set
    abstract seed: SVGAnimatedNumber with get, set
    abstract stitchTiles: SVGAnimatedEnumeration with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    abstract SVG_STITCHTYPE_STITCH: float with get, set
    abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFETurbulenceElementType =
    abstract prototype: SVGFETurbulenceElement with get, set
    abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    abstract SVG_STITCHTYPE_STITCH: float with get, set
    abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFETurbulenceElement

and [<AllowNullLiteral>] SVGFilterElement =
    inherit SVGElement
    inherit SVGUnitTypes
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGURIReference
    inherit SVGExternalResourcesRequired
    abstract filterResX: SVGAnimatedInteger with get, set
    abstract filterResY: SVGAnimatedInteger with get, set
    abstract filterUnits: SVGAnimatedEnumeration with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract primitiveUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract setFilterRes: filterResX: float * filterResY: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFilterElementType =
    abstract prototype: SVGFilterElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFilterElement

and [<AllowNullLiteral>] SVGForeignObjectElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract height: SVGAnimatedLength with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGForeignObjectElementType =
    abstract prototype: SVGForeignObjectElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGForeignObjectElement

and [<AllowNullLiteral>] SVGGElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGGElementType =
    abstract prototype: SVGGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGGElement

and [<AllowNullLiteral>] SVGGradientElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    inherit SVGUnitTypes
    abstract gradientTransform: SVGAnimatedTransformList with get, set
    abstract gradientUnits: SVGAnimatedEnumeration with get, set
    abstract spreadMethod: SVGAnimatedEnumeration with get, set
    abstract SVG_SPREADMETHOD_PAD: float with get, set
    abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGGradientElementType =
    abstract prototype: SVGGradientElement with get, set
    abstract SVG_SPREADMETHOD_PAD: float with get, set
    abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGGradientElement

and [<AllowNullLiteral>] SVGImageElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract height: SVGAnimatedLength with get, set
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGImageElementType =
    abstract prototype: SVGImageElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGImageElement

and [<AllowNullLiteral>] SVGLength =
    abstract unitType: float with get, set
    abstract value: float with get, set
    abstract valueAsString: string with get, set
    abstract valueInSpecifiedUnits: float with get, set
    abstract SVG_LENGTHTYPE_CM: float with get, set
    abstract SVG_LENGTHTYPE_EMS: float with get, set
    abstract SVG_LENGTHTYPE_EXS: float with get, set
    abstract SVG_LENGTHTYPE_IN: float with get, set
    abstract SVG_LENGTHTYPE_MM: float with get, set
    abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    abstract SVG_LENGTHTYPE_PC: float with get, set
    abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    abstract SVG_LENGTHTYPE_PT: float with get, set
    abstract SVG_LENGTHTYPE_PX: float with get, set
    abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    abstract convertToSpecifiedUnits: unitType: float -> unit
    abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

and [<AllowNullLiteral>] SVGLengthType =
    abstract prototype: SVGLength with get, set
    abstract SVG_LENGTHTYPE_CM: float with get, set
    abstract SVG_LENGTHTYPE_EMS: float with get, set
    abstract SVG_LENGTHTYPE_EXS: float with get, set
    abstract SVG_LENGTHTYPE_IN: float with get, set
    abstract SVG_LENGTHTYPE_MM: float with get, set
    abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    abstract SVG_LENGTHTYPE_PC: float with get, set
    abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    abstract SVG_LENGTHTYPE_PT: float with get, set
    abstract SVG_LENGTHTYPE_PX: float with get, set
    abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLength

and [<AllowNullLiteral>] SVGLengthList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGLength -> SVGLength
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGLength
    abstract initialize: newItem: SVGLength -> SVGLength
    abstract insertItemBefore: newItem: SVGLength * index: float -> SVGLength
    abstract removeItem: index: float -> SVGLength
    abstract replaceItem: newItem: SVGLength * index: float -> SVGLength

and [<AllowNullLiteral>] SVGLengthListType =
    abstract prototype: SVGLengthList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLengthList

and [<AllowNullLiteral>] SVGLineElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract x1: SVGAnimatedLength with get, set
    abstract x2: SVGAnimatedLength with get, set
    abstract y1: SVGAnimatedLength with get, set
    abstract y2: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGLineElementType =
    abstract prototype: SVGLineElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLineElement

and [<AllowNullLiteral>] SVGLinearGradientElement =
    inherit SVGGradientElement
    abstract x1: SVGAnimatedLength with get, set
    abstract x2: SVGAnimatedLength with get, set
    abstract y1: SVGAnimatedLength with get, set
    abstract y2: SVGAnimatedLength with get, set

and [<AllowNullLiteral>] SVGLinearGradientElementType =
    abstract prototype: SVGLinearGradientElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLinearGradientElement

and [<AllowNullLiteral>] SVGMarkerElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    abstract markerHeight: SVGAnimatedLength with get, set
    abstract markerUnits: SVGAnimatedEnumeration with get, set
    abstract markerWidth: SVGAnimatedLength with get, set
    abstract orientAngle: SVGAnimatedAngle with get, set
    abstract orientType: SVGAnimatedEnumeration with get, set
    abstract refX: SVGAnimatedLength with get, set
    abstract refY: SVGAnimatedLength with get, set
    abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    abstract setOrientToAngle: angle: SVGAngle -> unit
    abstract setOrientToAuto: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGMarkerElementType =
    abstract prototype: SVGMarkerElement with get, set
    abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMarkerElement

and [<AllowNullLiteral>] SVGMaskElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGUnitTypes
    abstract height: SVGAnimatedLength with get, set
    abstract maskContentUnits: SVGAnimatedEnumeration with get, set
    abstract maskUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGMaskElementType =
    abstract prototype: SVGMaskElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMaskElement

and [<AllowNullLiteral>] SVGMatrix =
    abstract a: float with get, set
    abstract b: float with get, set
    abstract c: float with get, set
    abstract d: float with get, set
    abstract e: float with get, set
    abstract f: float with get, set
    abstract flipX: unit -> SVGMatrix
    abstract flipY: unit -> SVGMatrix
    abstract inverse: unit -> SVGMatrix
    abstract multiply: secondMatrix: SVGMatrix -> SVGMatrix
    abstract rotate: angle: float -> SVGMatrix
    abstract rotateFromVector: x: float * y: float -> SVGMatrix
    abstract scale: scaleFactor: float -> SVGMatrix
    abstract scaleNonUniform: scaleFactorX: float * scaleFactorY: float -> SVGMatrix
    abstract skewX: angle: float -> SVGMatrix
    abstract skewY: angle: float -> SVGMatrix
    abstract translate: x: float * y: float -> SVGMatrix

and [<AllowNullLiteral>] SVGMatrixType =
    abstract prototype: SVGMatrix with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMatrix

and [<AllowNullLiteral>] SVGMetadataElement =
    inherit SVGElement


and [<AllowNullLiteral>] SVGMetadataElementType =
    abstract prototype: SVGMetadataElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMetadataElement

and [<AllowNullLiteral>] SVGNumber =
    abstract value: float with get, set

and [<AllowNullLiteral>] SVGNumberType =
    abstract prototype: SVGNumber with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGNumber

and [<AllowNullLiteral>] SVGNumberList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGNumber -> SVGNumber
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGNumber
    abstract initialize: newItem: SVGNumber -> SVGNumber
    abstract insertItemBefore: newItem: SVGNumber * index: float -> SVGNumber
    abstract removeItem: index: float -> SVGNumber
    abstract replaceItem: newItem: SVGNumber * index: float -> SVGNumber

and [<AllowNullLiteral>] SVGNumberListType =
    abstract prototype: SVGNumberList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGNumberList

and [<AllowNullLiteral>] SVGPathElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPathData
    abstract createSVGPathSegArcAbs: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcAbs
    abstract createSVGPathSegArcRel: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcRel
    abstract createSVGPathSegClosePath: unit -> SVGPathSegClosePath
    abstract createSVGPathSegCurvetoCubicAbs: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicAbs
    abstract createSVGPathSegCurvetoCubicRel: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicRel
    abstract createSVGPathSegCurvetoCubicSmoothAbs: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothAbs
    abstract createSVGPathSegCurvetoCubicSmoothRel: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothRel
    abstract createSVGPathSegCurvetoQuadraticAbs: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticAbs
    abstract createSVGPathSegCurvetoQuadraticRel: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticRel
    abstract createSVGPathSegCurvetoQuadraticSmoothAbs: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothAbs
    abstract createSVGPathSegCurvetoQuadraticSmoothRel: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothRel
    abstract createSVGPathSegLinetoAbs: x: float * y: float -> SVGPathSegLinetoAbs
    abstract createSVGPathSegLinetoHorizontalAbs: x: float -> SVGPathSegLinetoHorizontalAbs
    abstract createSVGPathSegLinetoHorizontalRel: x: float -> SVGPathSegLinetoHorizontalRel
    abstract createSVGPathSegLinetoRel: x: float * y: float -> SVGPathSegLinetoRel
    abstract createSVGPathSegLinetoVerticalAbs: y: float -> SVGPathSegLinetoVerticalAbs
    abstract createSVGPathSegLinetoVerticalRel: y: float -> SVGPathSegLinetoVerticalRel
    abstract createSVGPathSegMovetoAbs: x: float * y: float -> SVGPathSegMovetoAbs
    abstract createSVGPathSegMovetoRel: x: float * y: float -> SVGPathSegMovetoRel
    abstract getPathSegAtLength: distance: float -> float
    abstract getPointAtLength: distance: float -> SVGPoint
    abstract getTotalLength: unit -> float
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPathElementType =
    abstract prototype: SVGPathElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathElement

and [<AllowNullLiteral>] SVGPathSeg =
    abstract pathSegType: float with get, set
    abstract pathSegTypeAsLetter: string with get, set
    abstract PATHSEG_ARC_ABS: float with get, set
    abstract PATHSEG_ARC_REL: float with get, set
    abstract PATHSEG_CLOSEPATH: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_LINETO_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    abstract PATHSEG_LINETO_REL: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    abstract PATHSEG_MOVETO_ABS: float with get, set
    abstract PATHSEG_MOVETO_REL: float with get, set
    abstract PATHSEG_UNKNOWN: float with get, set

and [<AllowNullLiteral>] SVGPathSegType =
    abstract prototype: SVGPathSeg with get, set
    abstract PATHSEG_ARC_ABS: float with get, set
    abstract PATHSEG_ARC_REL: float with get, set
    abstract PATHSEG_CLOSEPATH: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_LINETO_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    abstract PATHSEG_LINETO_REL: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    abstract PATHSEG_MOVETO_ABS: float with get, set
    abstract PATHSEG_MOVETO_REL: float with get, set
    abstract PATHSEG_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSeg

and [<AllowNullLiteral>] SVGPathSegArcAbs =
    inherit SVGPathSeg
    abstract angle: float with get, set
    abstract largeArcFlag: bool with get, set
    abstract r1: float with get, set
    abstract r2: float with get, set
    abstract sweepFlag: bool with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegArcAbsType =
    abstract prototype: SVGPathSegArcAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegArcAbs

and [<AllowNullLiteral>] SVGPathSegArcRel =
    inherit SVGPathSeg
    abstract angle: float with get, set
    abstract largeArcFlag: bool with get, set
    abstract r1: float with get, set
    abstract r2: float with get, set
    abstract sweepFlag: bool with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegArcRelType =
    abstract prototype: SVGPathSegArcRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegArcRel

and [<AllowNullLiteral>] SVGPathSegClosePath =
    inherit SVGPathSeg


and [<AllowNullLiteral>] SVGPathSegClosePathType =
    abstract prototype: SVGPathSegClosePath with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegClosePath

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbsType =
    abstract prototype: SVGPathSegCurvetoCubicAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicRelType =
    abstract prototype: SVGPathSegCurvetoCubicRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicRel

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbsType =
    abstract prototype: SVGPathSegCurvetoCubicSmoothAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicSmoothAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRelType =
    abstract prototype: SVGPathSegCurvetoCubicSmoothRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicSmoothRel

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbsType =
    abstract prototype: SVGPathSegCurvetoQuadraticAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRelType =
    abstract prototype: SVGPathSegCurvetoQuadraticRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticRel

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbsType =
    abstract prototype: SVGPathSegCurvetoQuadraticSmoothAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRelType =
    abstract prototype: SVGPathSegCurvetoQuadraticSmoothRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothRel

and [<AllowNullLiteral>] SVGPathSegLinetoAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoAbsType =
    abstract prototype: SVGPathSegLinetoAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoAbs

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbs =
    inherit SVGPathSeg
    abstract x: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbsType =
    abstract prototype: SVGPathSegLinetoHorizontalAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoHorizontalAbs

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRel =
    inherit SVGPathSeg
    abstract x: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRelType =
    abstract prototype: SVGPathSegLinetoHorizontalRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoHorizontalRel

and [<AllowNullLiteral>] SVGPathSegLinetoRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoRelType =
    abstract prototype: SVGPathSegLinetoRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoRel

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbs =
    inherit SVGPathSeg
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbsType =
    abstract prototype: SVGPathSegLinetoVerticalAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoVerticalAbs

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalRel =
    inherit SVGPathSeg
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalRelType =
    abstract prototype: SVGPathSegLinetoVerticalRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoVerticalRel

and [<AllowNullLiteral>] SVGPathSegList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGPathSeg -> SVGPathSeg
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGPathSeg
    abstract initialize: newItem: SVGPathSeg -> SVGPathSeg
    abstract insertItemBefore: newItem: SVGPathSeg * index: float -> SVGPathSeg
    abstract removeItem: index: float -> SVGPathSeg
    abstract replaceItem: newItem: SVGPathSeg * index: float -> SVGPathSeg

and [<AllowNullLiteral>] SVGPathSegListType =
    abstract prototype: SVGPathSegList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegList

and [<AllowNullLiteral>] SVGPathSegMovetoAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegMovetoAbsType =
    abstract prototype: SVGPathSegMovetoAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegMovetoAbs

and [<AllowNullLiteral>] SVGPathSegMovetoRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegMovetoRelType =
    abstract prototype: SVGPathSegMovetoRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegMovetoRel

and [<AllowNullLiteral>] SVGPatternElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGURIReference
    inherit SVGUnitTypes
    abstract height: SVGAnimatedLength with get, set
    abstract patternContentUnits: SVGAnimatedEnumeration with get, set
    abstract patternTransform: SVGAnimatedTransformList with get, set
    abstract patternUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPatternElementType =
    abstract prototype: SVGPatternElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPatternElement

and [<AllowNullLiteral>] SVGPoint =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract matrixTransform: matrix: SVGMatrix -> SVGPoint

and [<AllowNullLiteral>] SVGPointType =
    abstract prototype: SVGPoint with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPoint

and [<AllowNullLiteral>] SVGPointList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGPoint -> SVGPoint
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGPoint
    abstract initialize: newItem: SVGPoint -> SVGPoint
    abstract insertItemBefore: newItem: SVGPoint * index: float -> SVGPoint
    abstract removeItem: index: float -> SVGPoint
    abstract replaceItem: newItem: SVGPoint * index: float -> SVGPoint

and [<AllowNullLiteral>] SVGPointListType =
    abstract prototype: SVGPointList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPointList

and [<AllowNullLiteral>] SVGPolygonElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPoints
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPolygonElementType =
    abstract prototype: SVGPolygonElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPolygonElement

and [<AllowNullLiteral>] SVGPolylineElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPoints
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPolylineElementType =
    abstract prototype: SVGPolylineElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPolylineElement

and [<AllowNullLiteral>] SVGPreserveAspectRatio =
    abstract align: float with get, set
    abstract meetOrSlice: float with get, set
    abstract SVG_MEETORSLICE_MEET: float with get, set
    abstract SVG_MEETORSLICE_SLICE: float with get, set
    abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set

and [<AllowNullLiteral>] SVGPreserveAspectRatioType =
    abstract prototype: SVGPreserveAspectRatio with get, set
    abstract SVG_MEETORSLICE_MEET: float with get, set
    abstract SVG_MEETORSLICE_SLICE: float with get, set
    abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPreserveAspectRatio

and [<AllowNullLiteral>] SVGRadialGradientElement =
    inherit SVGGradientElement
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract fx: SVGAnimatedLength with get, set
    abstract fy: SVGAnimatedLength with get, set
    abstract r: SVGAnimatedLength with get, set

and [<AllowNullLiteral>] SVGRadialGradientElementType =
    abstract prototype: SVGRadialGradientElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRadialGradientElement

and [<AllowNullLiteral>] SVGRect =
    abstract height: float with get, set
    abstract width: float with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGRectType =
    abstract prototype: SVGRect with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRect

and [<AllowNullLiteral>] SVGRectElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract height: SVGAnimatedLength with get, set
    abstract rx: SVGAnimatedLength with get, set
    abstract ry: SVGAnimatedLength with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGRectElementType =
    abstract prototype: SVGRectElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRectElement

and [<AllowNullLiteral>] SVGSVGElement =
    inherit SVGElement
    inherit DocumentEvent
    inherit SVGLocatable
    inherit SVGTests
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGZoomAndPan
    abstract contentScriptType: string with get, set
    abstract contentStyleType: string with get, set
    abstract currentScale: float with get, set
    abstract currentTranslate: SVGPoint with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract onabort: (Event -> 'Out) with get, set
    abstract onerror: (Event -> 'Out) with get, set
    abstract onresize: (UIEvent -> 'Out) with get, set
    abstract onscroll: (UIEvent -> 'Out) with get, set
    abstract onunload: (Event -> 'Out) with get, set
    abstract onzoom: (SVGZoomEvent -> 'Out) with get, set
    abstract pixelUnitToMillimeterX: float with get, set
    abstract pixelUnitToMillimeterY: float with get, set
    abstract screenPixelToMillimeterX: float with get, set
    abstract screenPixelToMillimeterY: float with get, set
    abstract viewport: SVGRect with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract checkEnclosure: element: SVGElement * rect: SVGRect -> bool
    abstract checkIntersection: element: SVGElement * rect: SVGRect -> bool
    abstract createSVGAngle: unit -> SVGAngle
    abstract createSVGLength: unit -> SVGLength
    abstract createSVGMatrix: unit -> SVGMatrix
    abstract createSVGNumber: unit -> SVGNumber
    abstract createSVGPoint: unit -> SVGPoint
    abstract createSVGRect: unit -> SVGRect
    abstract createSVGTransform: unit -> SVGTransform
    abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    abstract deselectAll: unit -> unit
    abstract forceRedraw: unit -> unit
    abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
    abstract getCurrentTime: unit -> float
    abstract getElementById: elementId: string -> Element
    abstract getEnclosureList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    abstract getIntersectionList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    abstract pauseAnimations: unit -> unit
    abstract setCurrentTime: seconds: float -> unit
    abstract suspendRedraw: maxWaitMilliseconds: float -> float
    abstract unpauseAnimations: unit -> unit
    abstract unsuspendRedraw: suspendHandleID: float -> unit
    abstract unsuspendRedrawAll: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGSVGElementType =
    abstract prototype: SVGSVGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSVGElement

and [<AllowNullLiteral>] SVGScriptElement =
    inherit SVGElement
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract ``type``: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGScriptElementType =
    abstract prototype: SVGScriptElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGScriptElement

and [<AllowNullLiteral>] SVGStopElement =
    inherit SVGElement
    inherit SVGStylable
    abstract offset: SVGAnimatedNumber with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGStopElementType =
    abstract prototype: SVGStopElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStopElement

and [<AllowNullLiteral>] SVGStringList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: string -> string
    abstract clear: unit -> unit
    abstract getItem: index: float -> string
    abstract initialize: newItem: string -> string
    abstract insertItemBefore: newItem: string * index: float -> string
    abstract removeItem: index: float -> string
    abstract replaceItem: newItem: string * index: float -> string

and [<AllowNullLiteral>] SVGStringListType =
    abstract prototype: SVGStringList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStringList

and [<AllowNullLiteral>] SVGStyleElement =
    inherit SVGElement
    inherit SVGLangSpace
    abstract media: string with get, set
    abstract title: string with get, set
    abstract ``type``: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGStyleElementType =
    abstract prototype: SVGStyleElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStyleElement

and [<AllowNullLiteral>] SVGSwitchElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGSwitchElementType =
    abstract prototype: SVGSwitchElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSwitchElement

and [<AllowNullLiteral>] SVGSymbolElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGSymbolElementType =
    abstract prototype: SVGSymbolElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSymbolElement

and [<AllowNullLiteral>] SVGTSpanElement =
    inherit SVGTextPositioningElement


and [<AllowNullLiteral>] SVGTSpanElementType =
    abstract prototype: SVGTSpanElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTSpanElement

and [<AllowNullLiteral>] SVGTextContentElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract lengthAdjust: SVGAnimatedEnumeration with get, set
    abstract textLength: SVGAnimatedLength with get, set
    abstract LENGTHADJUST_SPACING: float with get, set
    abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    abstract LENGTHADJUST_UNKNOWN: float with get, set
    abstract getCharNumAtPosition: point: SVGPoint -> float
    abstract getComputedTextLength: unit -> float
    abstract getEndPositionOfChar: charnum: float -> SVGPoint
    abstract getExtentOfChar: charnum: float -> SVGRect
    abstract getNumberOfChars: unit -> float
    abstract getRotationOfChar: charnum: float -> float
    abstract getStartPositionOfChar: charnum: float -> SVGPoint
    abstract getSubStringLength: charnum: float * nchars: float -> float
    abstract selectSubString: charnum: float * nchars: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTextContentElementType =
    abstract prototype: SVGTextContentElement with get, set
    abstract LENGTHADJUST_SPACING: float with get, set
    abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    abstract LENGTHADJUST_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextContentElement

and [<AllowNullLiteral>] SVGTextElement =
    inherit SVGTextPositioningElement
    inherit SVGTransformable
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTextElementType =
    abstract prototype: SVGTextElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextElement

and [<AllowNullLiteral>] SVGTextPathElement =
    inherit SVGTextContentElement
    inherit SVGURIReference
    abstract ``method``: SVGAnimatedEnumeration with get, set
    abstract spacing: SVGAnimatedEnumeration with get, set
    abstract startOffset: SVGAnimatedLength with get, set
    abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTextPathElementType =
    abstract prototype: SVGTextPathElement with get, set
    abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextPathElement

and [<AllowNullLiteral>] SVGTextPositioningElement =
    inherit SVGTextContentElement
    abstract dx: SVGAnimatedLengthList with get, set
    abstract dy: SVGAnimatedLengthList with get, set
    abstract rotate: SVGAnimatedNumberList with get, set
    abstract x: SVGAnimatedLengthList with get, set
    abstract y: SVGAnimatedLengthList with get, set

and [<AllowNullLiteral>] SVGTextPositioningElementType =
    abstract prototype: SVGTextPositioningElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextPositioningElement

and [<AllowNullLiteral>] SVGTitleElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTitleElementType =
    abstract prototype: SVGTitleElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTitleElement

and [<AllowNullLiteral>] SVGTransform =
    abstract angle: float with get, set
    abstract matrix: SVGMatrix with get, set
    abstract ``type``: float with get, set
    abstract SVG_TRANSFORM_MATRIX: float with get, set
    abstract SVG_TRANSFORM_ROTATE: float with get, set
    abstract SVG_TRANSFORM_SCALE: float with get, set
    abstract SVG_TRANSFORM_SKEWX: float with get, set
    abstract SVG_TRANSFORM_SKEWY: float with get, set
    abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    abstract setMatrix: matrix: SVGMatrix -> unit
    abstract setRotate: angle: float * cx: float * cy: float -> unit
    abstract setScale: sx: float * sy: float -> unit
    abstract setSkewX: angle: float -> unit
    abstract setSkewY: angle: float -> unit
    abstract setTranslate: tx: float * ty: float -> unit

and [<AllowNullLiteral>] SVGTransformType =
    abstract prototype: SVGTransform with get, set
    abstract SVG_TRANSFORM_MATRIX: float with get, set
    abstract SVG_TRANSFORM_ROTATE: float with get, set
    abstract SVG_TRANSFORM_SCALE: float with get, set
    abstract SVG_TRANSFORM_SKEWX: float with get, set
    abstract SVG_TRANSFORM_SKEWY: float with get, set
    abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTransform

and [<AllowNullLiteral>] SVGTransformList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGTransform -> SVGTransform
    abstract clear: unit -> unit
    abstract consolidate: unit -> SVGTransform
    abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    abstract getItem: index: float -> SVGTransform
    abstract initialize: newItem: SVGTransform -> SVGTransform
    abstract insertItemBefore: newItem: SVGTransform * index: float -> SVGTransform
    abstract removeItem: index: float -> SVGTransform
    abstract replaceItem: newItem: SVGTransform * index: float -> SVGTransform

and [<AllowNullLiteral>] SVGTransformListType =
    abstract prototype: SVGTransformList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTransformList

and [<AllowNullLiteral>] SVGUnitTypes =
    abstract SVG_UNIT_TYPE_OBJECTBOUNDINGBOX: float with get, set
    abstract SVG_UNIT_TYPE_UNKNOWN: float with get, set
    abstract SVG_UNIT_TYPE_USERSPACEONUSE: float with get, set

and [<AllowNullLiteral>] SVGUseElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract animatedInstanceRoot: SVGElementInstance with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract instanceRoot: SVGElementInstance with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGUseElementType =
    abstract prototype: SVGUseElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGUseElement

and [<AllowNullLiteral>] SVGViewElement =
    inherit SVGElement
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGZoomAndPan
    abstract viewTarget: SVGStringList with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGViewElementType =
    abstract prototype: SVGViewElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGViewElement

and [<AllowNullLiteral>] SVGZoomAndPan =
    abstract zoomAndPan: float with get, set

and [<AllowNullLiteral>] SVGZoomAndPanType =
    abstract SVG_ZOOMANDPAN_DISABLE: float with get, set
    abstract SVG_ZOOMANDPAN_MAGNIFY: float with get, set
    abstract SVG_ZOOMANDPAN_UNKNOWN: float with get, set

and [<AllowNullLiteral>] SVGZoomEvent =
    inherit UIEvent
    abstract newScale: float with get, set
    abstract newTranslate: SVGPoint with get, set
    abstract previousScale: float with get, set
    abstract previousTranslate: SVGPoint with get, set
    abstract zoomRectScreen: SVGRect with get, set

and [<AllowNullLiteral>] SVGZoomEventType =
    abstract prototype: SVGZoomEvent with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGZoomEvent

and [<AllowNullLiteral>] SVGAnimatedPathData =
        abstract pathSegList: SVGPathSegList with get, set

    and [<AllowNullLiteral>] SVGAnimatedPoints =
        abstract animatedPoints: SVGPointList with get, set
        abstract points: SVGPointList with get, set

    and [<AllowNullLiteral>] SVGExternalResourcesRequired =
        abstract externalResourcesRequired: SVGAnimatedBoolean with get, set

    and [<AllowNullLiteral>] SVGFilterPrimitiveStandardAttributes =
        inherit SVGStylable
        abstract height: SVGAnimatedLength with get, set
        abstract result: SVGAnimatedString with get, set
        abstract width: SVGAnimatedLength with get, set
        abstract x: SVGAnimatedLength with get, set
        abstract y: SVGAnimatedLength with get, set

    and [<AllowNullLiteral>] SVGFitToViewBox =
        abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
        abstract viewBox: SVGAnimatedRect with get, set

    and [<AllowNullLiteral>] SVGLangSpace =
        abstract xmllang: string with get, set
        abstract xmlspace: string with get, set

    and [<AllowNullLiteral>] SVGLocatable =
        abstract farthestViewportElement: SVGElement with get, set
        abstract nearestViewportElement: SVGElement with get, set
        abstract getBBox: unit -> SVGRect
        abstract getCTM: unit -> SVGMatrix
        abstract getScreenCTM: unit -> SVGMatrix
        abstract getTransformToElement: element: SVGElement -> SVGMatrix

    and [<AllowNullLiteral>] SVGStylable =
        abstract className: obj with get, set
        abstract style: CSSStyleDeclaration with get, set

    and [<AllowNullLiteral>] SVGTests =
        abstract requiredExtensions: SVGStringList with get, set
        abstract requiredFeatures: SVGStringList with get, set
        abstract systemLanguage: SVGStringList with get, set
        abstract hasExtension: extension: string -> bool

    and [<AllowNullLiteral>] SVGTransformable =
        inherit SVGLocatable
        abstract transform: SVGAnimatedTransformList with get, set

    and [<AllowNullLiteral>] SVGURIReference =
        abstract href: SVGAnimatedString with get, set

// ## CSS

type [<AllowNullLiteral>] LinkStyle =
    abstract sheet: StyleSheet with get, set

type [<AllowNullLiteral>] CSS =
    abstract supports: property: string * ?value: string -> bool

type [<AllowNullLiteral>] CSSConditionRule =
    inherit CSSGroupingRule
    abstract conditionText: string with get, set

type [<AllowNullLiteral>] CSSConditionRuleType =
    abstract prototype: CSSConditionRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSConditionRule

type [<AllowNullLiteral>] CSSFontFaceRule =
    inherit CSSRule
    abstract style: CSSStyleDeclaration with get, set

type [<AllowNullLiteral>] CSSFontFaceRuleType =
    abstract prototype: CSSFontFaceRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSFontFaceRule

type [<AllowNullLiteral>] CSSGroupingRule =
    inherit CSSRule
    abstract cssRules: CSSRuleList with get, set
    abstract deleteRule: ?index: float -> unit
    abstract insertRule: rule: string * ?index: float -> float

type [<AllowNullLiteral>] CSSGroupingRuleType =
    abstract prototype: CSSGroupingRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSGroupingRule

type [<AllowNullLiteral>] CSSImportRule =
    inherit CSSRule
    abstract href: string with get, set
    // TODO
    // abstract media: MediaList with get, set
    abstract styleSheet: CSSStyleSheet with get, set

type [<AllowNullLiteral>] CSSImportRuleType =
    abstract prototype: CSSImportRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSImportRule

type [<AllowNullLiteral>] CSSKeyframeRule =
    inherit CSSRule
    abstract keyText: string with get, set
    abstract style: CSSStyleDeclaration with get, set

type [<AllowNullLiteral>] CSSKeyframeRuleType =
    abstract prototype: CSSKeyframeRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSKeyframeRule

type [<AllowNullLiteral>] CSSKeyframesRule =
    inherit CSSRule
    abstract cssRules: CSSRuleList with get, set
    abstract name: string with get, set
    abstract appendRule: rule: string -> unit
    abstract deleteRule: rule: string -> unit
    abstract findRule: rule: string -> CSSKeyframeRule

type [<AllowNullLiteral>] CSSKeyframesRuleType =
    abstract prototype: CSSKeyframesRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSKeyframesRule

type [<AllowNullLiteral>] CSSMediaRule =
    inherit CSSConditionRule
    /// TODO
    // abstract media: MediaList with get, set

type [<AllowNullLiteral>] CSSMediaRuleType =
    abstract prototype: CSSMediaRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSMediaRule

type [<AllowNullLiteral>] CSSNamespaceRule =
    inherit CSSRule
    abstract namespaceURI: string with get, set
    abstract prefix: string with get, set

type [<AllowNullLiteral>] CSSNamespaceRuleType =
    abstract prototype: CSSNamespaceRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSNamespaceRule

type [<AllowNullLiteral>] CSSPageRule =
    inherit CSSRule
    abstract pseudoClass: string with get, set
    abstract selector: string with get, set
    abstract selectorText: string with get, set
    abstract style: CSSStyleDeclaration with get, set

type [<AllowNullLiteral>] CSSPageRuleType =
    abstract prototype: CSSPageRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSPageRule

type [<AllowNullLiteral>] CSSRule =
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

type [<AllowNullLiteral>] CSSRuleType =
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

type [<AllowNullLiteral>] CSSRuleList =
    abstract length: float with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> CSSRule with get, set
    abstract item: index: float -> CSSRule

type [<AllowNullLiteral>] CSSRuleListType =
    abstract prototype: CSSRuleList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSRuleList

type [<AllowNullLiteral>] CSSStyleDeclaration =
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

type [<AllowNullLiteral>] CSSStyleDeclarationType =
    abstract prototype: CSSStyleDeclaration with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleDeclaration

type [<AllowNullLiteral>] CSSStyleRule =
    inherit CSSRule
    abstract readOnly: bool with get, set
    abstract selectorText: string with get, set
    abstract style: CSSStyleDeclaration with get, set

type [<AllowNullLiteral>] CSSStyleRuleType =
    abstract prototype: CSSStyleRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleRule

type [<AllowNullLiteral>] CSSStyleSheet =
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

type [<AllowNullLiteral>] CSSStyleSheetType =
    abstract prototype: CSSStyleSheet with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleSheet

type [<AllowNullLiteral>] CSSSupportsRule =
    inherit CSSConditionRule

type [<AllowNullLiteral>] CSSSupportsRuleType =
    abstract prototype: CSSSupportsRule with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> CSSSupportsRule

type [<AllowNullLiteral>] StyleMedia =
    abstract ``type``: string with get, set
    abstract matchMedium: mediaquery: string -> bool

type [<AllowNullLiteral>] StyleMediaType =
    abstract prototype: StyleMedia with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleMedia

type [<AllowNullLiteral>] StyleSheet =
    abstract disabled: bool with get, set
    abstract href: string with get, set
    // TODO
    // abstract media: MediaList with get, set
    abstract ownerNode: Node with get, set
    abstract parentStyleSheet: StyleSheet with get, set
    abstract title: string with get, set
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] StyleSheetType =
    abstract prototype: StyleSheet with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheet

type [<AllowNullLiteral>] StyleSheetList =
    abstract length: float with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> StyleSheet with get, set
    abstract item: ?index: float -> StyleSheet

type [<AllowNullLiteral>] StyleSheetListType =
    abstract prototype: StyleSheetList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheetList

type [<AllowNullLiteral>] StyleSheetPageList =
    abstract length: float with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> CSSPageRule with get, set
    abstract item: index: float -> CSSPageRule

type [<AllowNullLiteral>] StyleSheetPageListType =
    abstract prototype: StyleSheetPageList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheetPageList
