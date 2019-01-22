namespace Fable.Browser

open System
open Fable.Core

type [<AllowNullLiteral>] CanvasGradient =
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
