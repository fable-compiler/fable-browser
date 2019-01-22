namespace Fable.Browser

open System
open Fable.Core

type [<AllowNullLiteral>] UIEvent =
    inherit Event
    abstract detail: float
    abstract view: Window

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
