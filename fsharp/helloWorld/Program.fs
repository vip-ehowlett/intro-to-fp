
(*
    This is a mult-line comment in F#... it's weird, I know. This comes from the ML roots. 
    More specifically OCaml because F# started off as OCaml for .Net.
*)


// Top-level expressions were added in .Net 6 / F# 6
printfn "Hello, World!"


(*
    This is the old format. You had to add an attribute, the "[<...>]" syntax here,
    that declares this function to be the entry point of the program and you are only
    allowed to have one. The name also doesn't matter just as long as it takes a string array
    as the first argument and returns an int.
*)

// [<EntryPoint>]
// let main args = 
//     printfn "Hello, World!"
//     0

(*
    You might also be wondering why I indented the comment, but not the actual
    function. That's because F# is a whitespace sensative/delimited language.
    The above will compile if you uncomment it. The below won't.
*)
(*
    let main2 args = 
        printfn "Hello, World!"
        0
*)