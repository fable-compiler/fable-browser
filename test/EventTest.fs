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
        use! container = render_html $"""<div></div>"""
        let mutable x = 0
        container.El.addEventListener("my-event", fun _ -> x <- x + 1)
        let ev = Event.Create("my-event")
        container.El.dispatchEvent(ev) |> ignore
        x |> Expect.equal 1
    }

    it "can create custom events" <| fun () -> promise {
        use! container = render_html $"""<div></div>"""
        let mutable x = 0
        container.El.addEventListener("my-custom-event", fun ev ->
            let ev = ev :?> CustomEvent<int>
            ev.detail |> Expect.some "event detail" |> fun v -> x <- x + v)
        let ev = CustomEvent.Create("my-custom-event", jsOptions<CustomEventInit<int>>(fun o ->
            o.detail <- Some 5))
        container.El.dispatchEvent(ev) |> ignore
        x |> Expect.equal 5
    }
