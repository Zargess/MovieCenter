namespace MovieCenter.Core
module List =
    let lastElement list =
        List.rev list
        |> List.head

