namespace MovieCenter.Core
module IMDBSearchEngine =
    open FSharp.Data
    let search (name : string) =
        let searchableName = name.Replace(' ','+')
        Http.RequestString("http://www.omdbapi.com/?t=" + searchableName + "&r=json");

    //TODO : Create function that finds the poster image for the movie

