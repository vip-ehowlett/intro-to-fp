# Hello, World! -- From F#

[F#](https://fsharp.org/) is an [ML-style](https://en.wikipedia.org/wiki/ML_(programming_language)), functional-first, expression-based language that runs on the [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet) platform and interoperates very well with other .Net languages. This means it can take advantage of a lot of existing libraries written in [C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/). 

F#'s 1.0 release was in 2005 and has been heavily developed since then by both Microsoft and an open-source community (fun fact: the chair of the F# Foundation actually lives in Yarmouth). Although not the first first language with async support (that's usually attributed to ML and Haskell), it was the reason virtually every other language received it. F# brought the Async/Await pattern to the .Net platform in 2007 with it's 2.0 release. Over time this pattern was adopted by C# where it exploded in popularity and became absorbed by virtually every other mainstream language. There's a very common pattern of features being implemented in F# that eventually get adopted into C# and I'll go into some of those below.

## Why F#?

Why not F#? It's immutable by default, has a sound type system, and is basically a super-set of C#.

### Immutable by Default

On the surface, this sounds like a terrible idea. "How do I perform any type of computation if I can't mutate things???" You actually can! It works the same way that functions work in mathematics. You take some inputs and return an output. Computer-wise, the output is then bound to a separate address in memory so not to overwrite the original one.

Secondly, it's only immutable by default. It's very easy to allow mutation by marking a variable as mutable explicitly. 

#### But Why?

This is useful because you don't have to worry about how every single variable can change in your code. Nowhere in the code can you have mutation hidden from you! It's explicitly stated in either variable assignment or through special syntax. This is especially useful in multi-threaded applications because you can never encouter a data-race if memory isn't mutated! 

### A Sound Type System

Type systems, to me, are the biggest factor in deciding to choose a programming language. Descisions in how the type system is implemented ripple throughout every single line of code in the language. F# is a strongly, inferred, statically, nominally typed language. All that means is that: 
- once a variable is assigned a type it cannot be assigned a value with a different type
- types are inferred by usage so it's not as verbose as other statically-typed languages and looks a lot like [Python](https://www.python.org/)
- the types are assigned (and checked) at compile-time 
- you can have two stuctures that have the same interface but if they are named differently there is a type error. 

There's even a mathematical proof that a well-typed progam using the Hindley-Milner type system (the one F# uses) is sound.

#### What Does That Even Mean?

Well, a couple of things. The last point in a vast oversimplification means there are no (read few) runtime errors (most of these involve interop with existing C# code). It has that "if it compiles, it probably works" feel to it that [Rust](https://www.rust-lang.org/) has. That isn't to say, however, that it prevents logical errors IE you assigning value A when you really want to assign value B or having poor conditional statemetns.

Type inference is extremely good. There are some edge-cases where you may have to be explicit with types but it's no where near what you have to do in C# or Java. 

During compilation, if the type checker detects a collision in types, it fails to compile. This is basically a free test suite for your programs.

If you have two classes both that have a field/property name'd "B". Even though the structure is the same, the type is affected by the class name and therefore doesn't pass type checking.

### A C# Superset 

Similar to how TypeScript is a superset of JavaScript or C++ being a superset of C, F# is a superset of C#. It's a functional-first language, not a purely functional one so all the OOP features of C# exist in F# too.

- Classes? ✅
- Interfaces? ✅
- Inheritance? ✅
- AbstractBoxFactoryFactory? ❌... erm ✅... but don't do that... **seriously**. F# provides much better ways to address the problem this pattern is trying to solve.

## The Best Enterprise Language 

Scott Wlachin, author of *Domain Modeling Made Functional* and the blog *F# For Fun and Profit* lays out a very compelling argument for why F# is one of the best options for an enterprise language in [this post](https://fsharpforfunandprofit.com/posts/fsharp-is-the-best-enterprise-language/0).


## Let's get started 

Why don't you open [Program.fs](./Program.fs) to see what the most basic F# program looks like?