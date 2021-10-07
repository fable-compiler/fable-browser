module EventTest

open Fable.Core
open Fable.Core.JsInterop
open Expect
open Expect.Dom
open WebTestRunner
open Browser
open Browser.Types

describe "Event" <| fun () ->
    it "can create events" <| fun () -> promise {
        use container = Container.New()

        let mutable sideEffect = 0
        container.El.addEventListener("my-event", fun _ ->
            sideEffect <- sideEffect + 1)

        let ev = Event.Create("my-event", jsOptions(fun o ->
            o.bubbles <- true))
        container.El.appendChild().dispatchEvent(ev) |> ignore
        sideEffect |> Expect.equal 1

        // Non-bubbling events won't be detected by parent
        let ev = Event.Create("my-event")
        container.El.appendChild().dispatchEvent(ev) |> ignore
        sideEffect |> Expect.equal 1

        // But can be detected on the same element
        container.El.dispatchEvent(ev) |> ignore
        sideEffect |> Expect.equal 2
    }

    it "can create custom events" <| fun () -> promise {
        use container = Container.New()

        let mutable sideEffect = 0
        container.El.addEventListener("my-custom-event", fun ev ->
            let ev = ev :?> CustomEvent<int>
            ev.detail |> Expect.some "event detail" |> fun v ->
                sideEffect <- sideEffect + v)

        let ev = CustomEvent.Create("my-custom-event", jsOptions<CustomEventInit<int>>(fun o ->
            o.bubbles <- true
            o.detail <- Some 5))
        container.El.appendChild().dispatchEvent(ev) |> ignore

        sideEffect |> Expect.equal 5
    }
