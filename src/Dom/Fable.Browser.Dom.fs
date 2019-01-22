namespace Fable.Browser

module Dom =

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

    // ## HTML

    and [<AllowNullLiteral>] GetSVGDocument =
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

    // ## CANVAS

    and [<AllowNullLiteral>] CanvasGradient =
        abstract addColorStop: offset: float * color: string -> unit

    and [<AllowNullLiteral>] CanvasGradientType =
        [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasGradient

    and [<AllowNullLiteral>] CanvasPattern =
        interface end

    and [<AllowNullLiteral>] CanvasPatternType =
        [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasPattern

    and [<AllowNullLiteral>] CanvasRenderingContext2D =
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

    and [<AllowNullLiteral>] CanvasRenderingContext2DType =
        [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasRenderingContext2D

    and [<AllowNullLiteral>] ImageData =
        abstract data: uint8[] with get, set
        abstract height: float with get, set
        abstract width: float with get, set

    and [<AllowNullLiteral>] ImageDataType =
        [<Emit("new $0($1...)")>] abstract Create: width: float * height: float -> ImageData
        [<Emit("new $0($1...)")>] abstract Create: array: uint8[] * width: float * height: float -> ImageData

    // ## OTHER HTML INTERFACES

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

    // ## EVENTS

    and [<AllowNullLiteral>] UIEvent =
        inherit Event
        abstract detail: float
        abstract view: Window

    and [<AllowNullLiteral>] AnimationEvent =
        inherit Event
        abstract animationName: string with get, set
        abstract elapsedTime: float with get, set

    and [<AllowNullLiteral>] MouseEvent =
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

    and [<AllowNullLiteral>] MouseWheelEvent =
        inherit MouseEvent
        abstract wheelDelta: float
        abstract wheelDeltaX: float
        abstract wheelDeltaY: float

    and [<AllowNullLiteral>] DocumentEvent =
        abstract createEvent: eventInterface: string -> Event

    and [<AllowNullLiteral>] DragEvent =
        inherit MouseEvent
        abstract dataTransfer: DataTransfer

    and [<AllowNullLiteral>] ClipboardEvent =
        inherit Event
        abstract clipboardData: DataTransfer

    and [<AllowNullLiteral>] CompositionEvent =
        inherit UIEvent
        abstract data: string
        abstract locale: string

    and [<AllowNullLiteral>] DataTransfer =
        abstract dropEffect: string
        abstract effectAllowed: string
        // TODO
        // abstract files: FileList
        abstract items: DataTransferItemList
        abstract types: DOMStringList
        abstract clearData: ?format: string -> bool
        abstract getData: format: string -> string
        abstract setData: format: string * data: string -> bool

    and [<AllowNullLiteral>] DataTransferItem =
        abstract kind: string
        abstract ``type``: string
        // TODO
        // abstract getAsFile: unit -> File
        abstract getAsString: _callback: (string -> unit) -> unit

    and [<AllowNullLiteral>] DataTransferItemList =
        abstract length: int
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> DataTransferItem
        // TODO
        // abstract add: data: File -> DataTransferItem
        abstract clear: unit -> unit
        abstract item: index: float -> DataTransferItem
        abstract remove: index: float -> unit

    and [<AllowNullLiteral>] FocusEvent =
        inherit UIEvent
        abstract relatedTarget: EventTarget

    and [<AllowNullLiteral>] PointerEvent =
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

    and [<AllowNullLiteral>] PopStateEvent =
        inherit Event
        abstract state: obj

    and [<AllowNullLiteral>] KeyboardEvent =
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

    and [<AllowNullLiteral>] ProgressEvent =
        inherit Event
        abstract lengthComputable: bool
        abstract loaded: float
        abstract total: float

    and [<AllowNullLiteral>] Touch =
        abstract clientX: float
        abstract clientY: float
        abstract identifier: float
        abstract pageX: float
        abstract pageY: float
        abstract screenX: float
        abstract screenY: float
        abstract target: EventTarget

    and [<AllowNullLiteral>] TouchEvent =
        inherit UIEvent
        abstract altKey: bool
        abstract changedTouches: Touch[]
        abstract ctrlKey: bool
        abstract metaKey: bool
        abstract shiftKey: bool
        abstract targetTouches: Touch[]
        abstract touches: Touch[]

    and [<AllowNullLiteral>] AriaRequestEvent =
        inherit Event
        abstract attributeName: string
        abstract attributeValue: string

    and [<AllowNullLiteral>] CommandEvent =
        inherit Event
        abstract commandName: string
        abstract detail: string

    and [<AllowNullLiteral>] BeforeUnloadEvent =
        inherit Event
        abstract returnValue: obj

    and [<AllowNullLiteral>] DeviceMotionEvent =
        inherit Event
        abstract acceleration: DeviceAcceleration
        abstract accelerationIncludingGravity: DeviceAcceleration
        abstract interval: float
        abstract rotationRate: DeviceRotationRate

    and [<AllowNullLiteral>] DeviceOrientationEvent =
        inherit Event
        abstract absolute: bool
        abstract alpha: float
        abstract beta: float
        abstract gamma: float

    and [<AllowNullLiteral>] DeviceAcceleration =
        abstract x: float
        abstract y: float
        abstract z: float

    and [<AllowNullLiteral>] DeviceRotationRate =
        abstract alpha: float
        abstract beta: float
        abstract gamma: float

    and [<AllowNullLiteral>] MessageEvent =
        inherit Event
        abstract data: obj
        abstract origin: string
        abstract ports: obj
        abstract source: Window

    and [<AllowNullLiteral>] TransitionEvent =
        inherit Event
        abstract elapsedTime: float with get, set
        abstract propertyName: string with get, set

     and [<AllowNullLiteral>] PageTransitionEvent =
        inherit Event
        abstract persisted: bool

    and [<AllowNullLiteral>] StorageEvent =
        inherit Event
        abstract url: string
        abstract key: string
        abstract oldValue: string
        abstract newValue: string
        abstract storageArea: Storage

    and [<AllowNullLiteral>] HashChangeEvent =
        inherit Event
        abstract newURL: string
        abstract oldURL: string

    and [<AllowNullLiteral>] TrackEvent =
        inherit Event
        abstract track: obj

    and [<AllowNullLiteral>] WheelEvent =
        inherit MouseEvent
        abstract deltaMode: float
        abstract deltaX: float
        abstract deltaY: float
        abstract deltaZ: float
        abstract DOM_DELTA_LINE: float
        abstract DOM_DELTA_PAGE: float
        abstract DOM_DELTA_PIXEL: float
        abstract getCurrentPoint: element: Element -> unit

    // and [<AllowNullLiteral>] WheelEventType =
    //     abstract DOM_DELTA_LINE: float
    //     abstract DOM_DELTA_PAGE: float
    //     abstract DOM_DELTA_PIXEL: float
    //     [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: WheelEventInit -> WheelEvent

    // let [<Global>] ANGLE_instanced_arrays: ANGLE_instanced_arraysType = jsNative
    // let [<Global>] AnalyserNode: AnalyserNodeType = jsNative
    // let [<Global>] AnimationEvent: AnimationEventType = jsNative
    // let [<Global>] ApplicationCache: ApplicationCacheType = jsNative
    // let [<Global>] AriaRequestEvent: AriaRequestEventType = jsNative
    let [<Global>] Attr: AttrType = jsNative
    // let [<Global>] AudioBuffer: AudioBufferType = jsNative
    // let [<Global>] AudioBufferSourceNode: AudioBufferSourceNodeType = jsNative
    // let [<Global>] AudioContext: AudioContextType = jsNative
    // let [<Global>] AudioDestinationNode: AudioDestinationNodeType = jsNative
    // let [<Global>] AudioListener: AudioListenerType = jsNative
    // let [<Global>] AudioNode: AudioNodeType = jsNative
    // let [<Global>] AudioParam: AudioParamType = jsNative
    // let [<Global>] AudioProcessingEvent: AudioProcessingEventType = jsNative
    // let [<Global>] AudioTrack: AudioTrackType = jsNative
    // let [<Global>] AudioTrackList: AudioTrackListType = jsNative
    // let [<Global>] AudioWorker: AudioWorkerType = jsNative
    // let [<Global>] AudioWorkerGlobalScope: AudioWorkerGlobalScopeType = jsNative
    // let [<Global>] AudioWorkerNode: AudioWorkerNodeType = jsNative
    // let [<Global>] AudioWorkerNodeProcessor: AudioWorkerNodeProcessorType = jsNative
    // let [<Global>] BarProp: BarPropType = jsNative
    // let [<Global>] BeforeUnloadEvent: BeforeUnloadEventType = jsNative
    // let [<Global>] BiquadFilterNode: BiquadFilterNodeType = jsNative
    // let [<Global>] Blob: BlobType = jsNative
    let [<Global>] CDATASection: CDATASectionType = jsNative
    // let [<Global>] CSS: CSS = jsNative
    // let [<Global>] CSSConditionRule: CSSConditionRuleType = jsNative
    // let [<Global>] CSSFontFaceRule: CSSFontFaceRuleType = jsNative
    // let [<Global>] CSSGroupingRule: CSSGroupingRuleType = jsNative
    // let [<Global>] CSSImportRule: CSSImportRuleType = jsNative
    // let [<Global>] CSSKeyframeRule: CSSKeyframeRuleType = jsNative
    // let [<Global>] CSSKeyframesRule: CSSKeyframesRuleType = jsNative
    // let [<Global>] CSSMediaRule: CSSMediaRuleType = jsNative
    // let [<Global>] CSSNamespaceRule: CSSNamespaceRuleType = jsNative
    // let [<Global>] CSSPageRule: CSSPageRuleType = jsNative
    // let [<Global>] CSSRule: CSSRuleType = jsNative
    // let [<Global>] CSSRuleList: CSSRuleListType = jsNative
    // let [<Global>] CSSStyleDeclaration: CSSStyleDeclarationType = jsNative
    // let [<Global>] CSSStyleRule: CSSStyleRuleType = jsNative
    // let [<Global>] CSSStyleSheet: CSSStyleSheetType = jsNative
    // let [<Global>] CSSSupportsRule: CSSSupportsRuleType = jsNative
    let [<Global>] CanvasGradient: CanvasGradientType = jsNative
    let [<Global>] CanvasPattern: CanvasPatternType = jsNative
    let [<Global>] CanvasRenderingContext2D: CanvasRenderingContext2DType = jsNative
    // let [<Global>] ChannelMergerNode: ChannelMergerNodeType = jsNative
    // let [<Global>] ChannelSplitterNode: ChannelSplitterNodeType = jsNative
    // let [<Global>] CharacterData: CharacterDataType = jsNative
    let [<Global>] ClientRect: ClientRectType = jsNative
    // let [<Global>] ClientRectList: ClientRectListType = jsNative
    // let [<Global>] ClipboardEvent: ClipboardEventType = jsNative
    // let [<Global>] CloseEvent: CloseEventType = jsNative
    // let [<Global>] CommandEvent: CommandEventType = jsNative
    // let [<Global>] Comment: CommentType = jsNative
    // let [<Global>] CompositionEvent: CompositionEventType = jsNative
    // let [<Global>] Console: ConsoleType = jsNative
    // let [<Global>] ConvolverNode: ConvolverNodeType = jsNative
    // let [<Global>] Coordinates: CoordinatesType = jsNative
    // let [<Global>] Crypto: CryptoType = jsNative
    // let [<Global>] CryptoKey: CryptoKeyType = jsNative
    // let [<Global>] CryptoKeyPair: CryptoKeyPairType = jsNative
    // let [<Global>] CustomEvent: CustomEventType = jsNative
    let [<Global>] DOMException: DOMExceptionType = jsNative
    let [<Global>] DOMImplementation: DOMImplementationType = jsNative
    // let [<Global>] DOMParser: DOMParserType = jsNative
    let [<Global>] DOMStringList: DOMStringListType = jsNative
    let [<Global>] DOMStringMap: DOMStringMapType = jsNative
    let [<Global>] DOMTokenList: DOMTokenListType = jsNative
    // let [<Global>] DataCue: DataCueType = jsNative
    // let [<Global>] DataTransfer: DataTransferType = jsNative
    // let [<Global>] DataTransferItem: DataTransferItemType = jsNative
    // let [<Global>] DataTransferItemList: DataTransferItemListType = jsNative
    // let [<Global>] DeferredPermissionRequest: DeferredPermissionRequestType = jsNative
    // let [<Global>] DelayNode: DelayNodeType = jsNative
    // let [<Global>] DeviceAcceleration: DeviceAccelerationType = jsNative
    // let [<Global>] DeviceMotionEvent: DeviceMotionEventType = jsNative
    // let [<Global>] DeviceOrientationEvent: DeviceOrientationEventType = jsNative
    // let [<Global>] DeviceRotationRate: DeviceRotationRateType = jsNative
    let [<Global>] Document: DocumentType = jsNative
    let [<Global>] DocumentFragment: DocumentFragmentType = jsNative
    let [<Global>] DocumentType: DocumentTypeType = jsNative
    // let [<Global>] DragEvent: DragEventType = jsNative
    // let [<Global>] DynamicsCompressorNode: DynamicsCompressorNodeType = jsNative
    let [<Global>] Element: ElementType = jsNative
    // let [<Global>] ErrorEvent: ErrorEventType = jsNative
    // let [<Global>] Event: EventType = jsNative
    // let [<Global>] EventTarget: EventTargetType = jsNative
    // let [<Global>] External: ExternalType = jsNative
    // let [<Global>] File: FileType = jsNative
    // let [<Global>] FileList: FileListType = jsNative
    // let [<Global>] FileReader: FileReaderType = jsNative
    // let [<Global>] FocusEvent: FocusEventType = jsNative
    // let [<Global>] FormData: FormDataType = jsNative
    // let [<Global>] GainNode: GainNodeType = jsNative
    // let [<Global>] Gamepad: GamepadType = jsNative
    // let [<Global>] GamepadButton: GamepadButtonType = jsNative
    // let [<Global>] GamepadEvent: GamepadEventType = jsNative
    // let [<Global>] Geolocation: GeolocationType = jsNative
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
    let [<Global>] HTMLFrameSetElement: HTMLFrameSetElementType = jsNative
    let [<Global>] HTMLHRElement: HTMLHRElementType = jsNative
    let [<Global>] HTMLHeadElement: HTMLHeadElementType = jsNative
    let [<Global>] HTMLHeadingElement: HTMLHeadingElementType = jsNative
    let [<Global>] HTMLHtmlElement: HTMLHtmlElementType = jsNative
    let [<Global>] HTMLIFrameElement: HTMLIFrameElementType = jsNative
    let [<Global>] HTMLImageElement: HTMLImageElementType = jsNative
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
    // let [<Global>] HashChangeEvent: HashChangeEventType = jsNative
    // let [<Global>] History: HistoryType = jsNative
    // let [<Global>] IIRFilterNode: IIRFilterNodeType = jsNative
    let [<Global>] ImageData: ImageDataType = jsNative
    // let [<Global>] KeyboardEvent: KeyboardEventType = jsNative
    // let [<Global>] Location: LocationType = jsNative
    // let [<Global>] LongRunningScriptDetectedEvent: LongRunningScriptDetectedEventType = jsNative
    // let [<Global>] MediaElementAudioSourceNode: MediaElementAudioSourceNodeType = jsNative
    // let [<Global>] MediaError: MediaErrorType = jsNative
    // let [<Global>] MediaList: MediaListType = jsNative
    // let [<Global>] MediaQueryList: MediaQueryListType = jsNative
    // let [<Global>] MediaSource: MediaSourceType = jsNative
    // let [<Global>] MediaStream: MediaStreamType = jsNative
    // let [<Global>] MediaStreamAudioDestinationNode: MediaStreamAudioDestinationNodeType = jsNative
    // let [<Global>] MediaStreamAudioSourceNode: MediaStreamAudioSourceNodeType = jsNative
    // let [<Global>] MessageChannel: MessageChannelType = jsNative
    // let [<Global>] MessageEvent: MessageEventType = jsNative
    // let [<Global>] MessagePort: MessagePortType = jsNative
    // let [<Global>] MimeType: MimeTypeType = jsNative
    // let [<Global>] MimeTypeArray: MimeTypeArrayType = jsNative
    // let [<Global>] MouseEvent: MouseEventType = jsNative
    // let [<Global>] MouseWheelEvent: MouseWheelEventType = jsNative
    let [<Global>] NamedNodeMap: NamedNodeMapType = jsNative
    // let [<Global>] NavigationCompletedEvent: NavigationCompletedEventType = jsNative
    // let [<Global>] NavigationEvent: NavigationEventType = jsNative
    // let [<Global>] NavigationEventWithReferrer: NavigationEventWithReferrerType = jsNative
    // let [<Global>] Navigator: NavigatorType = jsNative
    let [<Global>] Node: NodeType = jsNative
    let [<Global>] NodeFilter: NodeFilterType = jsNative
    let [<Global>] NodeIterator: NodeIteratorType = jsNative
    let [<Global>] NodeList: NodeListType = jsNative
    // let [<Global>] OES_element_index_uint: OES_element_index_uintType = jsNative
    // let [<Global>] OES_standard_derivatives: OES_standard_derivativesType = jsNative
    // let [<Global>] OES_texture_float: OES_texture_floatType = jsNative
    // let [<Global>] OES_texture_float_linear: OES_texture_float_linearType = jsNative
    // let [<Global>] OfflineAudioCompletionEvent: OfflineAudioCompletionEventType = jsNative
    // let [<Global>] OfflineAudioContext: OfflineAudioContextType = jsNative
    // let [<Global>] OscillatorNode: OscillatorNodeType = jsNative
    // let [<Global>] PageTransitionEvent: PageTransitionEventType = jsNative
    // let [<Global>] PannerNode: PannerNodeType = jsNative
    // let [<Global>] PerfWidgetExternal: PerfWidgetExternalType = jsNative
    // let [<Global>] Performance: PerformanceType = jsNative
    // let [<Global>] PerformanceEntry: PerformanceEntryType = jsNative
    // let [<Global>] PerformanceMark: PerformanceMarkType = jsNative
    // let [<Global>] PerformanceMeasure: PerformanceMeasureType = jsNative
    // let [<Global>] PerformanceNavigation: PerformanceNavigationType = jsNative
    // let [<Global>] PerformanceNavigationTiming: PerformanceNavigationTimingType = jsNative
    // let [<Global>] PerformanceResourceTiming: PerformanceResourceTimingType = jsNative
    // let [<Global>] PerformanceTiming: PerformanceTimingType = jsNative
    // let [<Global>] PeriodicWave: PeriodicWaveType = jsNative
    // let [<Global>] PermissionRequest: PermissionRequestType = jsNative
    // let [<Global>] PermissionRequestedEvent: PermissionRequestedEventType = jsNative
    // let [<Global>] Plugin: PluginType = jsNative
    // let [<Global>] PluginArray: PluginArrayType = jsNative
    // let [<Global>] PointerEvent: PointerEventType = jsNative
    // let [<Global>] PopStateEvent: PopStateEventType = jsNative
    // let [<Global>] Position: PositionType = jsNative
    // let [<Global>] PositionError: PositionErrorType = jsNative
    // let [<Global>] ProcessingInstruction: ProcessingInstructionType = jsNative
    // let [<Global>] ProgressEvent: ProgressEventType = jsNative
    let [<Global>] Range: RangeType = jsNative
    // let [<Global>] Screen: ScreenType = jsNative
    // let [<Global>] ScriptNotifyEvent: ScriptNotifyEventType = jsNative
    // let [<Global>] ScriptProcessorNode: ScriptProcessorNodeType = jsNative
    let [<Global>] Selection: SelectionType = jsNative
    let [<Global>] SourceBuffer: SourceBufferType = jsNative
    let [<Global>] SourceBufferList: SourceBufferListType = jsNative
    // let [<Global>] SpatialListener: SpatialListenerType = jsNative
    // let [<Global>] SpatialPannerNode: SpatialPannerNodeType = jsNative
    // let [<Global>] StereoPannerNode: StereoPannerNodeType = jsNative
    // let [<Global>] Storage: StorageType = jsNative
    // let [<Global>] StorageEvent: StorageEventType = jsNative
    // let [<Global>] StyleMedia: StyleMediaType = jsNative
    // let [<Global>] StyleSheet: StyleSheetType = jsNative
    // let [<Global>] StyleSheetList: StyleSheetListType = jsNative
    // let [<Global>] StyleSheetPageList: StyleSheetPageListType = jsNative
    // let [<Global>] SubtleCrypto: SubtleCryptoType = jsNative
    // let [<Global>] Text: TextType = jsNative
    // let [<Global>] TextEvent: TextEventType = jsNative
    // let [<Global>] TextMetrics: TextMetricsType = jsNative
    // let [<Global>] TextRange: TextRangeType = jsNative
    // let [<Global>] TextRangeCollection: TextRangeCollectionType = jsNative
    // let [<Global>] TextTrack: TextTrackType = jsNative
    // let [<Global>] TextTrackCue: TextTrackCueType = jsNative
    // let [<Global>] TextTrackCueList: TextTrackCueListType = jsNative
    // let [<Global>] TextTrackList: TextTrackListType = jsNative
    // let [<Global>] TimeRanges: TimeRangesType = jsNative
    // let [<Global>] Touch: TouchType = jsNative
    // let [<Global>] TouchEvent: TouchEventType = jsNative
    // let [<Global>] TouchList: TouchListType = jsNative
    // let [<Global>] TrackEvent: TrackEventType = jsNative
    // let [<Global>] TransitionEvent: TransitionEventType = jsNative
    // let [<Global>] TreeWalker: TreeWalkerType = jsNative
    // let [<Global>] UIEvent: UIEventType = jsNative
    // let [<Global>] UnviewableContentIdentifiedEvent: UnviewableContentIdentifiedEventType = jsNative
    // let [<Global>] ValidityState: ValidityStateType = jsNative
    // let [<Global>] VideoPlaybackQuality: VideoPlaybackQualityType = jsNative
    // let [<Global>] VideoTrack: VideoTrackType = jsNative
    // let [<Global>] VideoTrackList: VideoTrackListType = jsNative
    // let [<Global>] WebSocket: WebSocketType = jsNative
    // let [<Global>] WheelEvent: WheelEventType = jsNative
    // let [<Global>] Window: WindowType = jsNative
    let [<Global>] Worker: WorkerType = jsNative
    let [<Global>] XMLDocument: XMLDocumentType = jsNative
    // let [<Global>] HTMLTemplateElement: HTMLTemplateElementType = jsNative
    // let [<Global>] HTMLPictureElement: HTMLPictureElementType = jsNative
    // let [<Global>] Audio: AudioType = jsNative
    // let [<Global>] Image: ImageType = jsNative
    let [<Global>] animationStartTime: float = jsNative
    // let [<Global>] clientInformation: Navigator = jsNative
    let [<Global>] closed: bool = jsNative
    // let [<Global>] crypto: Crypto = jsNative
    let [<Global>] defaultStatus: string = jsNative
    let [<Global>] devicePixelRatio: float = jsNative
    let [<Global>] doNotTrack: string = jsNative
    let [<Global>] document: Document = jsNative
    // let [<Global>] ``event``: Event = jsNative
    // let [<Global>] ``external``: External = jsNative
    let [<Global>] frameElement: Element = jsNative
    let [<Global>] frames: Window = jsNative
    let [<Global>] history: History = jsNative
    let [<Global>] innerHeight: float = jsNative
    let [<Global>] innerWidth: float = jsNative
    let [<Global>] length: int = jsNative
    let [<Global>] location: Location = jsNative
    let [<Global>] locationbar: BarProp = jsNative
    let [<Global>] menubar: BarProp = jsNative
    let [<Global>] name: string = jsNative
    // let [<Global>] navigator: Navigator = jsNative
    let [<Global>] offscreenBuffering: bool = jsNative
    let [<Global>] opener: Window = jsNative
    let [<Global>] orientation: string = jsNative
    let [<Global>] outerHeight: float = jsNative
    let [<Global>] outerWidth: float = jsNative
    let [<Global>] pageXOffset: float = jsNative
    let [<Global>] pageYOffset: float = jsNative
    let [<Global>] parent: Window = jsNative
    let [<Global>] performance: Performance = jsNative
    let [<Global>] personalbar: BarProp = jsNative
    let [<Global>] screen: Screen = jsNative
    let [<Global>] screenLeft: float = jsNative
    let [<Global>] screenTop: float = jsNative
    let [<Global>] screenX: float = jsNative
    let [<Global>] screenY: float = jsNative
    let [<Global>] scrollX: float = jsNative
    let [<Global>] scrollY: float = jsNative
    let [<Global>] scrollbars: BarProp = jsNative
    let [<Global>] self: Window = jsNative
    let [<Global>] status: string = jsNative
    let [<Global>] statusbar: BarProp = jsNative
    // let [<Global>] styleMedia: StyleMedia = jsNative
    let [<Global>] toolbar: BarProp = jsNative
    let [<Global>] top: Window = jsNative
    let [<Global>] window: Window = jsNative
    let [<Global>] URL: URLType = jsNative
    let [<Global>] URLSearchParams: URLSearchParamsType = jsNative
    let [<Global>] sessionStorage: Storage = jsNative
    let [<Global>] localStorage: Storage = jsNative
    let [<Global>] console: Console = jsNative

namespace Fable.Import

[<System.Obsolete("Use Fable.Browser.Dom")>]
module Browser =
    /// Use Fable.Browser.Dom
    let obsolete<'T> : 'T = failwith "Use Fable.Browser.Dom"