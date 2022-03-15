namespace Browser.Types

open System
open Fable.Core

type [<AllowNullLiteral; Global>] Performance =
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

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Performance =
    let [<Global>] performance: Performance = jsNative
