namespace Browser.Types

open Fable.Core

type IntersectionObserverEntry =
    /// A rectangle describing the smallest rectangle that contains the entire target element
    abstract boundingClientRect: ClientRect
    /// How much of the target element is currently visible within the root's intersection ratio, as a value between 0.0 and 1.0
    abstract intersectionRatio: float
    /// The smallest rectangle that contains the entire portion of the target element which is currently visible within the intersection root
    abstract intersectionRect: ClientRect
    /// True if the target element intersects with the intersection observer's root
    abstract isIntersecting: bool
    /// A rectangle corresponding to the target's root intersection rectangle, offset by the IntersectionObserver.rootMargin if one is specified
    abstract rootBounds: ClientRect
    /// Which targeted Element has changed its amount of intersection with the intersection root
    abstract target: Node
    /// The time at which the intersection change occurred relative to the time at which the document was created
    abstract time: System.Double // DOMHighResTimeStamp - defined in MediaRecorder

type IntersectionObserverOptions =
    /// An Element or Document object which is an ancestor of the intended target, whose bounding rectangle will be considered the viewport
    abstract root: Node with get, set
    ///  string which specifies a set of offsets to add to the root's bounding_box when calculating intersections, effectively shrinking or growing the root for calculation purposes
    abstract rootMargin: string with get, set
    /// Either a single number or an array of numbers between 0.0 and 1.0, specifying a ratio of intersection area to total bounding box area for the observed target
    abstract threshold: U2<float,float[]> with get, set


type [<AllowNullLiteral; Global>] IntersectionObserverType =
    /// identifies the Element or Document whose bounds are treated as the bounding box of the viewport for the element which is the observer's target. Use null for  document viewport
    abstract root: Node
    /// A string (in CSS margin format), which contains offsets for one or more sides of the root's bounding box. These offsets are added to the corresponding values in the root's bounding box before the intersection between the resulting rectangle and the target element's bounds
    abstract rootMargin: string
    /// Array of intersection thresholds that was specified when the observer was instantiated
    abstract thresholds: float[]
    // Stop watching all target elements
    abstract disconnect: unit -> unit
    // Start watching given target
    abstract observe: Node -> unit
    /// Return array of IntersectionObserverEntry records captured since last callback was invoked
    abstract takeRecords: Node -> unit
    // Stop watching given target
    abstract unobserve: Node -> unit

type IntersectionObserverCallback = IntersectionObserverEntry[] -> IntersectionObserverType -> unit

type [<Global>] IntersectionObserverCtor =
    [<Emit("new $0($1...)")>] abstract Create: url: IntersectionObserverCallback  * ?options: IntersectionObserverOptions -> IntersectionObserverType

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module IntersectionObserver =
    let [<Global>] IntersectionObserver: IntersectionObserverCtor = jsNative
