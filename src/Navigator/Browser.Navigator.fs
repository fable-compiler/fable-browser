namespace Browser.Types

open System
open Fable.Core

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

type Navigator =
    inherit NavigatorID
    inherit NavigatorOnLine
    // abstract activeVRDisplays
    abstract appCodeName: string
    abstract appMinorVersion: string
    // abstract battery
    // abstract connection
    abstract cookieEnabled: bool
    // abstract geolocation
    abstract hardwareConcurrency: int
    // abstract keyboard
    abstract cpuClass: string
    abstract language: string
    abstract languages: string[]
    // abstract locks
    // abstract mediaCapabilities
    abstract maxTouchPoints: int
    abstract mimeTypes: MimeType[]
    abstract oscpu: string
    // abstract permissions: Permissions
    // abstract platform: string // Not reliable
    abstract plugins: Plugin[]
    // abstract serviceWorker: ServiceWorkerContainer
    // abstract storage: StorageManager
    abstract userAgent: string
    abstract webdriver: bool

// ## Methods

    abstract canShare: unit -> bool
    // abstract getVRDisplays()
    // abstract getUserMedia()
    // abstract sendBeacon()
    // abstract registerProtocolHandler()
    // abstract requestMediaKeySystemAccess()
    // abstract sendBeacon()
    // abstract share()
    // abstract vibrate()

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module Navigator =
    let [<Global>] navigator: Navigator = jsNative
