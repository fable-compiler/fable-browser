namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

type MimeType =
    abstract description: string
    abstract enabledPlugin: Plugin
    abstract suffixes: string
    abstract ``type``: string

and Plugin =
    abstract description: string
    abstract filename: string
    abstract length: int
    abstract name: string
    abstract version: string
    abstract item: index: int -> MimeType
    abstract namedItem: ``type``: string -> MimeType

type ShareData =
    abstract url: string with get, set
    abstract text: string with get, set
    abstract title: string with get, set

type Clipboard =
    abstract writeText: string -> Promise<unit>
    abstract readText: unit -> Promise<string>
    
type NavigatorID =
    abstract appName: string
    abstract appVersion: string
    abstract platform: string
    abstract product: string
    abstract productSub: string
    abstract userAgent: string
    abstract vendor: string
    abstract vendorSub: string

type NavigatorOnLine =
    abstract onLine: bool

type NavigatorUserMediaSuccessCallback = MediaStream -> unit
type NavigatorUserMediaErrorCallback = MediaStreamError -> unit

type Navigator =
    inherit NavigatorID
    inherit NavigatorOnLine
    // TODO: abstract activeVRDisplays
    abstract appCodeName: string
    abstract appMinorVersion: string
    // abstract battery // Deprecated
    abstract clipboard: Clipboard option
    // TODO: abstract connection
    abstract cookieEnabled: bool
    abstract geolocation: Geolocation option
    abstract hardwareConcurrency: int
    // TODO: abstract keyboard
    abstract cpuClass: string
    abstract language: string option
    abstract languages: string[] option
    // TODO: abstract locks
    // TODO: abstract mediaCapabilities
    abstract maxTouchPoints: int
    abstract mimeTypes: MimeType[] option
    abstract oscpu: string
    // TODO: abstract permissions: Permissions
    // abstract platform: string // Not reliable
    abstract plugins: Plugin[] option
    abstract serviceWorker: ServiceWorkerContainer option
    // TODO: abstract storage: StorageManager
    abstract userAgent: string
    abstract webdriver: bool

// ## Methods

    abstract canShare: unit -> bool
    // TODO: abstract getVRDisplays()

    // NOT TODO: Navigator.getUserMedia is deprecated in favor of navigator.mediaDevices.getUserMedia()
    // See: https://developer.mozilla.org/en-US/docs/Web/API/Navigator/getUserMedia
    // abstract getUserMedia: constraints: MediaStreamConstraints * successCallback: NavigatorUserMediaSuccessCallback * errorCallback: NavigatorUserMediaErrorCallback -> unit

    // TODO: abstract registerProtocolHandler()
    // TODO: abstract requestMediaKeySystemAccess()
    // TODO: abstract sendBeacon()
    abstract share: ShareData -> JS.Promise<unit>
    /// Pulses the vibration hardware on the device, if such hardware exists. If the device doesn't support vibration, this method has no effect. If a vibration pattern is already in progress when this method is called, the previous pattern is halted and the new one begins instead.
    /// - pattern: Provides a pattern of vibration and pause intervals. Each value indicates a number of milliseconds to vibrate or pause, in alternation. You may provide either a single value (to vibrate once for that many milliseconds) or an array of values to alternately vibrate, pause, then vibrate again. See Vibration API for details.
    abstract vibrate: pattern: obj -> bool

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Navigator =
    let [<Global>] navigator: Navigator = jsNative
