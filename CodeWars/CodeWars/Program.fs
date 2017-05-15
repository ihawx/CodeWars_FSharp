open System


//[8 kyu] String repeat : Write a function called repeatStr which repeats the given string string exactly n times.
let repeatStr n s = 
    [1..n]
    |> List.map(fun x -> s)
    |> String.Concat

//[8 kyu] Calculate average  : Write function avg which calculates average of numbers in given list.
let avg list = 
    List.sum (list) / (float list.Length)



Console.ReadKey|>ignore