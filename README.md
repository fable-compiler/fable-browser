# fable-browser

Fable bindings for [Browser Web APIs](https://developer.mozilla.org/docs/Web/API)

|NuGet|Name|Description|
|-----|----|-----------|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Blob.svg)](https://www.nuget.org/packages/Fable.Browser.Blob)|[Fable.Browser.Blob](src/Blob)|Bindings for the browser Blob API.|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Dom.svg)](https://www.nuget.org/packages/Fable.Browser.Dom)|[Fable.Browser.Dom](src/Dom)|Bindings for DOM and HTML interfaces|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Event.svg)](https://www.nuget.org/packages/Fable.Browser.Event)|[Fable.Browser.Event](src/Event)|Bindings for the browser Event interface|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Performance.svg)](https://www.nuget.org/packages/Fable.Browser.Performance)|[Fable.Browser.Performance](src/Performance)|Bindings for the browser Performance API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Url.svg)](https://www.nuget.org/packages/Fable.Browser.Url)|[Fable.Browser.Url](src/Url)|Bindings for the browser Url API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.WebSocket.svg)](https://www.nuget.org/packages/Fable.Browser.WebSocket)|[Fable.Browser.WebSocket](src/WebSocket)|Bindings for the browser WebSocket API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.WebRTC.svg)](https://www.nuget.org/packages/Fable.Browser.WebRTC)|[Fable.Browser.WebRTC](src/WebRTC)|Bindings for the browser WebRTC API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.WebStorage.svg)](https://www.nuget.org/packages/Fable.Browser.WebStorage)|[Fable.Browser.WebStorage](src/WebStorage)|Bindings for the Web Storage API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.XMLHttpRequest.svg)](https://www.nuget.org/packages/Fable.Browser.XMLHttpRequest)|[Fable.Browser.XMLHttpRequest](src/XMLHttpRequest)|Bindings for the browser XMLHttpRequest API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Svg.svg)](https://www.nuget.org/packages/Fable.Browser.Svg)|[Fable.Browser.Svg](src/Svg)|Bindings for the browser Svg API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Css.svg)](https://www.nuget.org/packages/Fable.Browser.Css)|[Fable.Browser.Css](src/Css)|Bindings for the browser Css API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Worker.svg)](https://www.nuget.org/packages/Fable.Browser.Worker)|[Fable.Browser.Worker](src/Worker)|Bindings for the browser Worker API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Geolocation.svg)](https://www.nuget.org/packages/Fable.Browser.Geolocation)|[Fable.Browser.Geolocation](src/Geolocation)|Bindings for the browser Geolocation API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Navigator.svg)](https://www.nuget.org/packages/Fable.Browser.Navigator)|[Fable.Browser.Navigator](src/Navigator)|Bindings for the browser Navigator API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.MediaStream.svg)](https://www.nuget.org/packages/Fable.Browser.MediaStream)|[Fable.Browser.MediaStream](src/MediaStream)|Bindings for the browser MediaStream API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.MediaRecorder.svg)](https://www.nuget.org/packages/Fable.Browser.MediaRecorder)|[Fable.Browser.MediaRecorder](src/MediaRecorder)|Bindings for the browser MediaRecorder API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.MediaQueryList.svg)](https://www.nuget.org/packages/Fable.Browser.MediaQueryList)|[Fable.Browser.MediaQueryList](src/MediaQueryList)|Bindings for the browser MediaQueryList API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.WebGL.svg)](https://www.nuget.org/packages/Fable.Browser.WebGL)|[Fable.Browser.WebGL](src/WebGL)|Bindings for the browser WebGL API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.IntersectionObserver.svg)](https://www.nuget.org/packages/Fable.Browser.IntersectionObserver)|[Fable.Browser.IntersectionObserver](src/IntersectionObserver)|Bindings for the browser Intersection Observer API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.ResizeObserver.svg)](https://www.nuget.org/packages/Fable.Browser.ResizeObserver)|[Fable.Browser.ResizeObserver](src/ResizeObserver)|Bindings for the browser Resize Observer API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.IndexedDB.svg)](https://www.nuget.org/packages/Fable.Browser.IndexedDB)|[Fable.Browser.IndexedDB](src/IndexedDB)|Bindings for the browser IndexedDB API|
|[![Nuget Package](https://img.shields.io/nuget/v/Fable.Browser.Canvas.svg)](https://www.nuget.org/packages/Fable.Browser.Canvas)|[Fable.Browser.ResizeObserver](src/Canvas)|Bindings for the browser Canvas API|

## Usage

After installing one of the Nuget packages you can access the API. For that, you only need to open the `Browser` namespace.

```fsharp
open Browser

let fooEl = document.getElementById("foo")
```

Note the API values are actually contained in an `[<AutoOpen>]` module, so if you need to fully qualify the value to avoid name conflicts, use the full module name (same as the Nuget package without `Fable.` prefix):

```fsharp
let fooEl = Browser.Dom.document.getElementById("foo")
```

If you need to reference one of the types in the package, open the `Browser.Types` namespace:

```fsharp
open Browser.Types

let handleClick (ev: MouseEvent) = printfn "click!"
```

## Publishing

If you have rights to publish the packages, the only thing you need to do is to bump the version in the appropriate RELEASE_NOTES file and then run `npm run publish`. The build script will automatically detect what packages have new versions, update the .fsproj file and push a release. Just make sure:

- Your Nuget API key is in a FABLE_NUGET_KEY environmental variable
- The packages you want to publish are listed in the `packages` list of the Build.fsx script
