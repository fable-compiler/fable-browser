#load "node_modules/fable-publish-utils/PublishUtils.fs"
open PublishUtils

match args with
| IgnoreCase "publish"::_ ->
    let srcDir = fullPath "src"
    for file in dirFiles srcDir do
        let projDir = srcDir </> file
        if isDirectory projDir then
            for file in dirFiles projDir do
                if file.EndsWith(".fsproj") then
                    pushNuget (projDir </> file)
| _ -> ()
