namespace MovieCenter.Core

type Folder = { 
    path : string; 
    name : string;
    filepaths : string list
}

module FolderManager =
    open System.IO

    let directoryToFolder (dir : string) =
        let name = 
             dir.Split([|'\\'|])
             |> List.ofArray
             |> List.lastElement

        let files = Directory.EnumerateFiles(dir, "*", SearchOption.TopDirectoryOnly) |> List.ofSeq
        {path = dir; name = name; filepaths = files}

    let findFolders path =
        Directory.EnumerateDirectories(path) 
        |> List.ofSeq
        |> List.map directoryToFolder
        


