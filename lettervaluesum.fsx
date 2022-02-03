// https://www.reddit.com/r/dailyprogrammer/comments/onfehl/20210719_challenge_399_easy_letter_value_sum/

open System

let totalTime = Diagnostics.Stopwatch.StartNew()

let print x =
    printf "%A\n" x
    |> ignore

// let alphabet = [ 'a' .. 'z' ]
// let lettersum (input : String) =
//     let letterArray = Seq.toList (input.ToLower())
//     let mutable num = 0
//     for i in letterArray do
//         let mutable count = 1
//         for letter in alphabet do
//             if i = letter then num <- num + count // (then break)
//             count <- count + 1
//     num

let lettersum (input : String) = 
    let letterArray = Seq.toList (input.ToLower())
    let mutable num = 0
    for i in letterArray do
        match i with
        | 'a' -> num <- num + 1
        | 'b' -> num <- num + 2
        | 'c' -> num <- num + 3
        | 'd' -> num <- num + 4
        | 'e' -> num <- num + 5
        | 'f' -> num <- num + 6
        | 'g' -> num <- num + 7
        | 'h' -> num <- num + 8
        | 'i' -> num <- num + 9
        | 'j' -> num <- num + 10
        | 'k' -> num <- num + 11
        | 'l' -> num <- num + 12
        | 'm' -> num <- num + 13
        | 'n' -> num <- num + 14
        | 'o' -> num <- num + 15
        | 'p' -> num <- num + 16
        | 'q' -> num <- num + 17
        | 'r' -> num <- num + 18
        | 's' -> num <- num + 19
        | 't' -> num <- num + 20
        | 'u' -> num <- num + 21
        | 'v' -> num <- num + 22
        | 'w' -> num <- num + 23
        | 'x' -> num <- num + 24
        | 'y' -> num <- num + 25
        | 'z' -> num <- num + 26
        | _ -> invalidArg input "bledkopf"
    num

print (lettersum("")) // 0
print (lettersum("a")) // 1
print (lettersum("z")) // 26
print (lettersum("cab")) // 6
print (lettersum("excellent")) // 100
print (lettersum("microspectrophotometries")) // 317


let wordList = (System.IO.File.ReadAllText "G:/Philip/Media/Programme/F#/enable1.txt").Split [|'\n'|]
let bonus1 =
    let mutable output = []
    for i in wordList do
        if (lettersum i) = 319 then output <- [i] |> List.append output
    print output
bonus1

let bonus2 =
    let mutable output = 0
    for i in wordList do
        if (lettersum i) % 2 = 1 then output <- output + 1
    print output
bonus2

// the highest lettersum is 319
let bonus3 =
    let lettersums : int array = Array.zeroCreate(320) 
    for i in wordList do
        lettersums[lettersum i] <- lettersums[lettersum i] + 1
    print lettersums

    let mutable max = 0
    let mutable max_index = 0
    let mutable n = 0
    for i in lettersums do
        if i > max 
        then 
            max <- i
            max_index <- n
        n <- n + 1
    printf "Most common lettersum: %A\nFrequency: %A\n" max_index max
bonus3

// get all words with 11 letter length difference
let bonus4 =
    let wordPairs = Array.init 2 (fun _ -> Array.create 2 "")
    let mutable n = 0
    for i in wordList do
        for x in wordList do
            if (String.length x) - (String.length i) = 11 && lettersum i = lettersum x
            then
                wordPairs.[n].[0] <- i
                wordPairs.[n].[1] <- x
                n <- n + 1
                printf "n incr to: %A\n" n
    print wordPairs
    |>ignore 
// bonus4
// voluptuously, electroencephalographic; zyzzyva, biodegradabilities

let bonus5 = 
    let wordPairs = Array.init 3 (fun _ -> Array.create 2 "")
    let mutable n = 0
    for i in wordList do
        for x in wordList do
            if (lettersum i > 188 && lettersum i = lettersum x)
            then
                wordPairs.[n].[0] <- i
            wordPairs.[n].[1] <- x
        n <- n + 1
    print wordPairs
    |>ignore
bonus5

totalTime.Stop()
printf "Total execution time: %fms" totalTime.Elapsed.TotalMilliseconds