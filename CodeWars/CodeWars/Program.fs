open System


//[8 kyu] String repeat : Write a function called repeatStr which repeats the given string string exactly n times.
let repeatStr n s = 
    [1..n]
    |> List.map(fun x -> s)
    |> String.Concat

//[8 kyu] Calculate average  : Write function avg which calculates average of numbers in given list.
let avg list = 
    List.sum (list) / (float list.Length)


//[8 kyu] Remove exclamation marks  : Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
let removeExclamationMarks s = 
    s
    |> Seq.filter(fun c -> not (c='!'))
    |> String.Concat

Console.ReadKey|>ignore