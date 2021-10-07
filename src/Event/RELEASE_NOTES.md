### 1.4.6

* Fix Event and CustomEvent constructors

### 1.4.5

* Fix Fable #2463 @forki
* Add back non-generic CustomEvent

### 1.4.4

* Downgrade FSharp.Core to 4.7.2

### 1.4.3

* Downgrade FSharp.Core to 4.7.2

### 1.4.2

* Upgrade to Fable.Browser.Gamepad 1.0.1 to use the version with the licence information in it

### 1.4.1

* Add licence to Nuget package @nojaf

### 1.4.0

* Make CustomEvent generic @AngelMunoz

### 1.3.0

* Add GamepadEvent (by @rastreus)

### 1.2.1

* Make explicit overloads for (add | remove)EventListener (by @Zaid-Ajaj)

### 1.2.0

* Add an overload for `addEventListener` and `removeEventListener` without the third argument in order to avoid forcing the user to pass the third optional argument and helps F# compiler determine which overload to use

### 1.1.0

* Add missing overload for `addEventListener` and `removeEventListener` on type `EventTarget` (by @baronfel)

### 1.0.0

* First stable release

### 1.0.0-alpha-001

* First release
