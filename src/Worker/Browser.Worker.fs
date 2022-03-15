namespace Browser.Types

open System
open Fable.Core

type AbstractWorker =
    abstract onerror: (ErrorEvent -> unit) with get, set

type [<Global>] Worker =
    inherit EventTarget
    inherit AbstractWorker
    abstract onmessage: (MessageEvent -> unit) with get, set
    abstract postMessage: message: obj * ?transfer: obj -> unit
    abstract terminate: unit -> unit

[<StringEnum>]
type WorkerType =
    | Classic
    | Module

[<StringEnum>]
type WorkerCredentials =
    | Omit
    | [<CompiledName("same-origin")>] SameOrigin
    | Include

type WorkerOptions =
    /// A DOMString specifying the type of worker to create. The value can be classic or module. If not specified, the default used is classic.
    abstract ``type``: WorkerType with get, set
    /// A DOMString specifying the type of credentials to use for the worker. The value can be omit, same-origin, or include. If not specified, or if type is classic, the default used is omit (no credentials required).
    abstract credentials: WorkerCredentials with get, set
    /// A DOMString specifying an identifying name for the DedicatedWorkerGlobalScope representing the scope of the worker, which is mainly useful for debugging purposes.
    abstract name: string with get, set

type WorkerConstructor =
    [<Emit("new $0($1...)")>] abstract Create: url: string * ?options: WorkerOptions -> Worker

[<StringEnum; RequireQualifiedAccess>]
type ServiceWorkerState =
    | Installing
    | Installed
    | Activating
    | Activated
    | Redundant

type [<Global>] ServiceWorker =
    inherit Worker
    abstract scriptURL: string
    abstract state: ServiceWorkerState
    abstract onstatechange: (Event -> unit) option with get, set

type [<Global>] ServiceWorkerRegistration =
    abstract scope: string
    abstract installing: ServiceWorker option
    abstract waiting: ServiceWorker option
    abstract active: ServiceWorker option
    // TODO abstract navigationPreload
    // TODO: abstract pushManager: PushManager
    abstract onupdatefound: (Event -> unit) option with get, set
    // TODO: abstract getNotifications: ?options: ServiceWorkerNotificationOptions -> JS.Promise<Notification[]>
    // TODO: abstract showNotifications()
    abstract update: unit -> JS.Promise<ServiceWorkerRegistration>
    abstract unregister: unit -> JS.Promise<bool>

type ServiceWorkerRegistrationOptions =
    /// A USVString representing a URL that defines a service worker's registration scope; that is, what range of URLs a service worker can control. This is usually a relative URL. It is relative to the base URL of the application. By default, the scope value for a service worker registration is set to the directory where the service worker script is located.
    abstract scope: string with get, set

type [<Global>] ServiceWorkerContainer =
    abstract controller: ServiceWorker option
    abstract ready: JS.Promise<ServiceWorkerRegistration>
    abstract oncontrollerchange: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set
    abstract onmessage: (Event -> unit) with get, set
    abstract register: url: string * ?options: ServiceWorkerRegistrationOptions -> JS.Promise<ServiceWorkerRegistration>
    abstract getRegistration: ?scope: string -> JS.Promise<ServiceWorkerRegistration>
    abstract getRegistrations: unit -> JS.Promise<ServiceWorkerRegistration[]>
    abstract startMessages: unit -> unit

namespace Browser

open Browser.Types
open Fable.Core

[<AutoOpen>]
module Worker =
    let [<Global>] Worker: WorkerConstructor = jsNative
