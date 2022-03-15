namespace Browser.Types

open System
open Fable.Core

type Coordinates =
    /// Returns a double representing the position's latitude in decimal degrees.
    abstract latitude: float
    /// Returns a double representing the position's longitude in decimal degrees.
    abstract longitude: float
    /// Returns a double representing the position's altitude in meters, relative to sea level. This value can be null if the implementation cannot provide the data.
    abstract altitude: float option
    /// Returns a double representing the accuracy of the latitude and longitude properties, expressed in meters.
    abstract accuracy: float
    /// Returns a double representing the accuracy of the altitude expressed in meters. This value can be null.
    abstract altitudeAccuracy: float option
    /// Returns a double representing the direction in which the device is traveling. This value, specified in degrees, indicates how far off from heading true north the device is. 0 degrees represents true north, and the direction is determined clockwise (which means that east is 90 degrees and west is 270 degrees). If speed is 0, heading is NaN. If the device is unable to provide heading information, this value is null.
    abstract heading: float option
    /// Returns a double representing the velocity of the device in meters per second. This value can be null.
    abstract speed: float option

type Position =
    abstract coords: Coordinates
    abstract timestamp: float

type PositionErrorCode =
    | PERMISSION_DENIED = 1
    | POSITION_UNAVAILABLE = 2
    | TIMEOUT = 3

type PositionError =
    abstract code: PositionErrorCode
    abstract message: string

type PositionOptions =
    abstract enableHighAccuracy: bool option with get, set
    abstract timeout: int option with get, set
    abstract maximumAge: int option with get, set

type [<Global>] Geolocation =
    abstract clearWatch: watchId: float -> unit
    abstract getCurrentPosition: successCallback: (Position->unit) * ?errorCallback: (PositionError->unit) * ?options: PositionOptions -> unit
    abstract watchPosition: successCallback: (Position->unit) * ?errorCallback: (PositionError->unit) * ?options: PositionOptions -> float
