namespace MovieCenter.Core
module Models =
    open FSharp.Data
    let testStructure : string = (IMDBSearchEngine.search "scrubs")
    type IMDBData = JsonProvider<"sample.json">
    let x = IMDBData.Load(testStructure).Writer

