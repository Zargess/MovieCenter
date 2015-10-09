// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open MovieCenter.Core.Test
open System

[<EntryPoint>]
let main argv = 
    printfn "%s" IMDBSearchEngineTest.scrubs
    Console.ReadLine() |> ignore
    0 // return an integer exit code
