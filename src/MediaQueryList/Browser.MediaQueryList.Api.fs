namespace Browser

open Fable.Core
open Browser.Types

module MediaQueryList =
    let [<Global>] MediaQueryList : MediaQueryListType = jsNative
