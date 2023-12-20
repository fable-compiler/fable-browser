### 2.2.0

* Add `IDBObjectStore.createIndex` overload that takes a `U2<string, ResizeArray<string>>` (by @MangelMaxime)

### 2.1.0

* Add `IDBObjectStore.createIndex` overload that takes a `ResizeArray<string>` (by @MangelMaxime)
* Change `IDBObjectStore.keyPath` from `obj` `U2<string, ResizeArray<string>>` (by @MangelMaxime)
* Change `IDBIndex.keyPath` from `obj` `U2<string, ResizeArray<string>>` (by @MangelMaxime)
* Improves properties types of `IDBCreateStoreOptions` (by @MangelMaxime)
* Change `IDBObjectStore.deleteIndex: unit -> IDBRequest` to `IDBObjectStore.deleteIndex: string -> IDBRequest` (by @kentcb)
* Change `DatabasesType.version` from `string` to `uint64` (by @kentcb)

### 2.0.0

* Align IndexedDB with current browser spec (by @robitar)

### 1.0.0

* Add `tags` to make binding displayed on Fable.Packages
* Stable release

### 1.0.0-beta-001

* First beta release
