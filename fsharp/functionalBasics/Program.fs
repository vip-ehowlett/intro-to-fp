let add l r =
    l + r

let explicitlyCurry = 
    fun l -> 
        fun r -> 
            l + r

let perform ( f : 'a -> 'a -> 'a ) l r =
    f l r

// printfn "perform add: %A" (perform add 1 2)
// printfn "perform explicitlyCurry: %A" (perform explicitlyCurry 1 2)


let partiallyAppliedAdd = add 1

// printfn "partiallyAppliedAdd: %A" (partiallyAppliedAdd 27)

let add2 = add 2 
let multiplyBy x y = y * x

// 2 |> add2 |> multiplyBy 2 |> printfn "piped: %A"

// 2 
// |> add2 
// |> multiplyBy 2
// |> printfn "piped: %A"

let composed = 
    add2 
    >> multiplyBy 2

// printfn "composed: %A" (composed 2)

let myPipe f g x = g ( f x )
let myCompose 
    ( f : 'a -> 'b )
    ( g : 'b -> 'c )
    = 
    fun x -> g (f x) 

myPipe (myPipe add2 (multiplyBy 2) ) (printfn "myPipe: %A") 2
myCompose (myCompose add2 (multiplyBy 2) ) (printfn "myCompose: %A")  2