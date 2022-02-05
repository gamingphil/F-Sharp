// https://projecteuler.net/problem=1

open System

let numbers = [1 .. 1000]

let mutable sum = 0
for i in numbers do
    if(i % 3 = 0 || i % 5 = 0)
    then sum <- sum + i

printf "Sum : %A" sum