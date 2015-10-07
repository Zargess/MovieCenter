// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open MovieCenter.Core
open FSharp.Data
[<EntryPoint>]
let main argv = 
    System.Console.WriteLine(IMDBSearchEngine.search "The Hunger Games")
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code
