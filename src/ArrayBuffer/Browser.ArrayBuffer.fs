namespace Browser.Types

open System
open Fable.Core


type [<AllowNullLiteral>] ArrayBuffer =
    abstract byteLength: uint32 with get

type ArrayBufferType =
    [<Emit "new $0($1...)">] abstract Create: size: int -> ArrayBuffer

type [<AllowNullLiteral>] ArrayBufferView =
    interface end

type ArrayBufferViewType =
    [<Emit "new $0($1...)">] abstract Create: size: int -> ArrayBufferView

type TypedArray =
  abstract buffer: ArrayBuffer with get
  abstract byteLength: uint32 with get
  abstract byteOffset: uint32 with get
  abstract length: uint32 with get
  abstract copyWithin: targetStartIndex:uint32 * start:uint32 * ? ``end``:uint32 -> unit
  abstract entries: unit -> obj

type TypedArray<'T> =
  inherit TypedArray
  abstract fill: value:obj * ?``begin``:uint32 * ?``end``:uint32 -> TypedArray<'T>
  abstract filter: ('T -> uint32 -> TypedArray<'T> -> bool) -> TypedArray<'T>
  abstract filter: ('T -> uint32 -> bool) -> TypedArray<'T>
  abstract filter: ('T -> bool) -> TypedArray<'T>
  abstract find: ('T -> uint32 -> TypedArray<'T> -> bool) -> 'T option
  abstract find: ('T -> uint32 -> bool) -> 'T option
  abstract find: ('T -> bool) -> 'T option
  abstract findIndex: ('T -> uint32 -> TypedArray<'T> -> bool) -> int
  abstract findIndex: ('T -> uint32 -> bool) -> int
  abstract findIndex: ('T -> bool) -> int
  abstract forEach: ('T -> uint32 -> TypedArray<'T> -> bool) -> unit
  abstract forEach: ('T -> uint32 -> bool) -> unit
  abstract forEach: ('T -> bool) -> unit
  abstract includes: searchElement:'T * ?fromIndex:uint32 -> bool
  abstract indexOf: searchElement:'T * ?fromIndex:uint32 -> int
  abstract join: separator:string -> string
  abstract keys: unit -> obj
  abstract lastIndexOf: searchElement:'T * ?fromIndex:uint32 -> int
  abstract map: ('T -> uint32 -> TypedArray<'T> -> 'U) -> TypedArray<'U>
  abstract map: ('T -> uint32 -> 'U) -> TypedArray<'U>
  abstract map: ('T -> 'U) -> TypedArray<'U>
  abstract reduce: ('State -> 'T -> uint32 -> TypedArray<'T> -> 'State) * state:'State -> 'State
  abstract reduce: ('State -> 'T -> uint32 -> 'State) * state:'State -> 'State
  abstract reduce: ('State -> 'T -> 'State) * state:'State -> 'State
  abstract reduceRight: ('State -> 'T -> uint32 -> TypedArray<'T> -> 'State) * state:'State -> 'State
  abstract reduceRight: ('State -> 'T -> uint32 -> 'State) * state:'State -> 'State
  abstract reduceRight: ('State -> 'T -> 'State) * state:'State -> 'State
  abstract reverse: unit -> TypedArray<'T>
  abstract set: source:Array * ?offset:uint32 -> TypedArray<'T>
  abstract set: source:#TypedArray * ?offset:uint32 -> TypedArray<'T>
  abstract slice: ?``begin``:uint32 * ?``end``:uint32 -> TypedArray<'T>
  abstract some: ('T -> uint32 -> TypedArray<'T> -> bool) -> bool
  abstract some: ('T -> uint32 -> bool) -> bool
  abstract some: ('T -> bool) -> bool
  abstract sort: ?sortFunction:('T -> 'T -> int) -> bool
  abstract subarray: ?``begin``:uint32 * ?``end``:uint32 -> TypedArray<'T>
  abstract values: unit -> obj


type Int8Array =
  inherit TypedArray<Int8Array>

type Int8ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Int8Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Int8Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Int8Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Int8Array


type Uint8Array =
  inherit TypedArray<Uint8Array>

type Uint8ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Uint8Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Uint8Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Uint8Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Uint8Array


type Uint8ClampedArray =
  inherit TypedArray<Uint8ClampedArray>

type Uint8ClampedArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Uint8ClampedArray
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Uint8ClampedArray
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Uint8ClampedArray
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Uint8ClampedArray
  abstract slice: ?``begin``:uint32 * ?``end``:uint32 -> Uint8ClampedArrayType


type Int16Array =
  inherit TypedArray<Int16Array>

type Int16ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Int16Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Int16Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Int16Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Int16Array


type Uint16Array =
  inherit TypedArray<Uint16Array>

type Uint16ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Uint16Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Uint16Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Uint16Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Uint16Array


type Int32Array =
  inherit TypedArray<Int32Array>

type Int32ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Int32Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Int32Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Int32Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Int32Array


type Uint32Array =
  inherit TypedArray<Uint32Array>

type Uint32ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Uint32Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Uint32Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Uint32Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Uint32Array


type Float32Array =
  inherit TypedArray<Float32Array>

type Float32ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Float32Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Float32Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Float32Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Float32Array


type Float64Array =
  inherit TypedArray<Float64Array>

type Float64ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> Float64Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> Float64Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> Float64Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> Float64Array


type BigInt64Array =
  inherit TypedArray<BigInt64Array>

type BigInt64ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> BigInt64Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> BigInt64Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> BigInt64Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> BigInt64Array


type BigUint64Array =
  inherit TypedArray<BigUint64Array>

type BigUint64ArrayType =
  [<Emit "new $0($1...)">] abstract Create: size: int -> BigUint64Array
  [<Emit "new $0($1...)">] abstract Create: typedArray: TypedArray -> BigUint64Array
  [<Emit "new $0($1...)">] abstract Create: buffer: ArrayBuffer * ?offset:uint32 * ?length:uint32 -> BigUint64Array
  [<Emit "new $0($1...)">] abstract Create: data:obj -> BigUint64Array



namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Blob =
    let [<Global>] ArrayBuffer: ArrayBufferType = jsNative
    let [<Global>] ArrayBufferView: ArrayBufferViewType = jsNative
    let [<Global>] Int8Array: Int8ArrayType = jsNative
    let [<Global>] Uint8Array: Uint8ArrayType = jsNative
    let [<Global>] Uint8ClampedArray: Uint8ClampedArrayType = jsNative
    let [<Global>] Int16Array: Int16ArrayType = jsNative
    let [<Global>] Uint16Array: Uint16ArrayType = jsNative
    let [<Global>] Int32Array: Int32ArrayType = jsNative
    let [<Global>] Uint32Array: Uint32ArrayType = jsNative
    let [<Global>] Float32Array: Float32ArrayType = jsNative
    let [<Global>] Float64Array: Float64ArrayType = jsNative
    let [<Global>] BigInt64Array: BigInt64ArrayType = jsNative
    let [<Global>] BigUint64Array: BigUint64ArrayType = jsNative
