### 2.18.0

* Better type event by replacing `Event` with things like `InputEvent` (by @Lanayx)
* Add missing event properties (by @Lanayx)
* Remove incorrect APIs (by @Lanayx)

### 2.17.0

* Fix #137: Remove `Worker` related types, use `Fable.Browser.Worker` if needed (by @MangelMaxime)

### 2.16.0

* Move `children` from `HTMLElement` to `Element` (by @chkn)

### 2.15.0

* Oupsy seems like I lost that release in a black hole...

### 2.14.0

* PR #114: Remove `File.text` which was defined as a getter instead of a function. Moreover the method is already available via `Blob` inheritance. (by @IanManske)

### 2.13.0

* Remove `HTMLButtonElement.reportValidity` (by @aronerben)
* Add `HTMLFormElement.reportValidity` (by @aronerben)
* Add `HTMLInputElement.reportValidity` (by @aronerben)

### 2.12.0

* Add `HTMLDialogElement` by @IanManske
* Remove `HTMLDivElementType` because `HTMLDivElement` doesn't have a constructor in JS

### 2.11.0

* Add `tags` to make binding displayed on Fable.Packages
* Fix #106: Add missing `file.text()`

### 2.10.1

* Add `CanvasRenderingContext2D.imageSmoothingEnabled`

### 2.10.0

* Add Global attribute to global interfaces @chkn

### 2.9.0

* PR #91: Add support for `Element.toggleAttribute`

### 2.8.0

* Fix #89: Add `orientation` to `window.screen` @sumeetdas

### 2.7.0

* Fix #86: Add `nextElementSibling` and `previousElementSibling` methods

### 2.6.0

* Fix #78: Invalid IL @jwosty

### 2.5.0

* Add shadow root types @AngelMunoz

### 2.4.4

* Downgrade FSharp.Core to 4.7.2

### 2.4.3

* Downgrade FSharp.Core to 4.7.2

### 2.4.2

* Release a new version because one of the dependencies had the licence information missing

### 2.4.1

* Add licence to Nuget package @nojaf

### 2.4.0

* Add ScrollToOptions support @saboco

### 2.3.0

* Add event handler properties for gamepad events to Window (by @rastreus)

### 2.2.1

* Fix #56: Clipboard API event handler argument types @kodfodrasz
* Add event handler properties for clipboard events to Document @kodfodrasz

### 2.2.0

* Fix #52: Add decodeURI, encodeURI, decodeURIComponent, encodeURIComponent to a `window` @MNie

### 2.1.2

* Fix #48: FSharp.Core dependency @forki

### 2.1.1

* Fix #25: Image constructor for HTMLImageElement

### 2.1.0

* Add missing APIs on CanvasRenderingContext2D

### 2.0.1

* Upgrade to Fable.Browser.Dom 1.2.1 to force usage of the new overloads of addListener|removeListener

### 2.0.0

* Remove `addEventListener` from `DocumentType` and `GlobalEventHandlers` (by @baronfel)
* Make `DocumentType` inherit from `Node` (by @baronfel)

### 1.3.0

* Fix #39: Add `event.code` and deprecate `event.keyCode`

### 1.2.0

* Add getter/setter to DataTransfer related types

### 1.1.0

* Add `FormData` extension constructor

### 1.0.0

* First stable release

### 1.0.0-alpha-004

* Add missing members to FileReader

### 1.0.0-alpha-003

* Move some APIs to standalone packages

### 1.0.0-alpha-002

* Add missing events

### 1.0.0-alpha-001

* First release
