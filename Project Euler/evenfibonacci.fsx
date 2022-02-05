// https://projecteuler.net/problem=2

open System

let mutable fib1 = 1
let mutable fib2 = 2
let mutable fib3 = fib1 + fib2

let mutable sum = 2

while fib3 < 4000000 do
    fib1 <- fib2
    fib2 <- fib3
    fib3 <- fib1 + fib2
    if fib3 % 2 = 0 then sum <- sum + fib3