### 3.1.0

* Fix #70: Wrong type for MediaStreamConstraints in Browser.MediaStream (by @Nhowka)

### 3.0.4

* Downgrade FSharp.Core to 4.7.2

### 3.0.3

* Downgrade FSharp.Core to 4.7.2

### 3.0.2

* Release a new version because one of the dependencies had the licence information missing

### 3.0.1

* Add licence to Nuget package @nojaf

### 3.0.0

* Add `ImageMediaTrackConstraintSet`
* Fix ContrainXXX should allow single value or constrain object
* Fix some bad type names
* Set `MediaTrackCapabilities` properties optional
* Add strongly typed methods on `AudioMediaStreamTrack` and `VideoMediaStreamTrack`
* Set `MediaDeviceInfo` kind as an enum

### 2.0.1

* Upgrade to Fable.Browser.Dom 1.2.1 to force usage of the new overloads of addListener|removeListener

### 2.0.0

* Add `MediaStream` suffix where necessary to follow the JavaScript API
* Add `MediaStreamError`

### 1.0.0

* First stable release
* Clone track returns track of the same type
* Fix `MediaStream.create` overloads
* Set framerate as optional parameter in `HTMLCanvasElement.captureStream`


### 1.0.0-beta-001

* First release
