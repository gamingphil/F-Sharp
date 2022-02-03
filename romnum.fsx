// https://www.reddit.com/r/dailyprogrammer/comments/oe9qnb/20210705_challenge_397_easy_roman_numeral/
let num1 = "M"
let num2 = "XX"

open System

let inline isNull value = obj.ReferenceEquals(value, null)

let numconvert (roman : String) =
    let list = Seq.toList roman
    let mutable num = 0
    if isNull roman = false
    then 
        for item in list do
            if item = 'I' then num <- num + 1
            elif item = 'V' then num <- num + 5
            elif item = 'X' then num <- num + 10
            elif item = 'L' then num <- num + 50
            elif item = 'C' then num <- num + 100
            elif item = 'D' then num <- num + 500
            elif item = 'M' then num <- num + 1000
            else raise (ArgumentException("String can't contain Roman numerals higher than M!"))  
    num

let numcompare n1 n2 : Boolean =
    let bool =
        if numconvert n1 < numconvert n2 then true
        else false
    bool

printf "%A" (numcompare num1 num2)