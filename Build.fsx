#load "node_modules/fable-publish-utils/PublishUtils.fs"

open System
open PublishUtils

// TODO: Maybe we should create a list to make sure packages
// are published in dependency order

let ignoreCaseEquals (str1: string) (str2: string) =
    String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase)

match args with
| IgnoreCase "publish"::rest ->
    let target = List.tryHead rest
    let srcDir = fullPath "src"
    for file in dirFiles srcDir do
        let projDir = srcDir </> file
        if isDirectory projDir then
            for file in dirFiles projDir do
                if file.EndsWith(".fsproj") then
                    match target with
                    | Some target ->
                        if ignoreCaseEquals file.[..(file.Length - 8)] target then
                            pushNuget (projDir </> file)
                    | None -> pushNuget (projDir </> file)
| _ -> ()
