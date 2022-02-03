// https://exercism.org/tracks/fsharp/exercises/pig-latin

open System

let sentence = Console.ReadLine()

let voc = ['a'; 'e'; 'i'; 'o'; 'u'; 'y'; 'x'; 'ä'; 'ü'; 'ö']
let pl (input : String) : String =
    let words = (input.ToLower()).Split [|' '|]
    let mutable output = ""
    for i in words do
        let letters = Seq.toList i
        if List.contains (letters).Head voc then output <- output + i + "ey "
        elif not (List.contains (letters).[1] voc) && not ((letters).[1] = 'y') then  output <- output + i.[2..] + i.[0..1]+ "ey "
        else output <- output + i.[1..] + string i.[0]+ "ey "
    output

printf "%A" (pl sentence)