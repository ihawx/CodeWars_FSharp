open System
///[8 kyu] String repeat : Write a function called repeatStr which repeats the given string string exactly n times.
let repeatStr n s = 
    [1..n]
    |> List.map(fun x -> s)
    |> String.Concat

///[8 kyu] Calculate average  : Write function avg which calculates average of numbers in given list.
let avg list = 
    List.sum (list) / (float list.Length)


///[8 kyu] Remove exclamation marks  : Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
let removeExclamationMarks s = 
    s
    |> Seq.filter(fun c -> not (c='!'))
    |> String.Concat

///[8 kyu] Powers of 2  : Write a function powersOfTwo which will return list of all powers of 2 from 0 to n (where n is an exponent).
let powersOfTwo n = 
    [0..n]
    |>List.map(fun x -> int(2.0**(float x)))

///[8 kyu] Remove duplicates from list : Write function distinct that removes duplicate from list of numbers. The order of the sequence needs to stay the same.
let distinct = List.distinct

Console.ReadKey|>ignore