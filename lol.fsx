open System

let wordPairs = Array.init 5 (fun _ -> Array.create 2 "")

wordPairs.[0].[0] <- "Servus"
wordPairs.[0].[1] <- "Versus"

printf "%A" wordPairs