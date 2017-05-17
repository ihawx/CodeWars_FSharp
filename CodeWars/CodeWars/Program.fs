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

///[8 kyu] Is it a palindrome? : Write function isPalindrom that checks if a given string (case insensitive) is a palindrom.
let reverse (s:string) = 
    s
    |> Seq.rev
    |> String.Concat

let isPalindrome s = 
    String.Compare(s,reverse s,true) = 0

///[8 kyu] MakeLowerCase : Write function makeLowerCase.
let makeLowerCase s = 
    s
    |> Seq.map(fun x -> Char.ToLower(x))
    |> String.Concat

///[8 kyu] MakeUpperCase : Write function makeUpperCase.
let makeUpperCase (s:string) = s.ToUpper()

///[8 kyu] Calculate BMI : Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
let calculateBMI weight height = weight / float height ** 2.0
let bmi weight height =
    match calculateBMI weight height with
    | x when x <= 18.5 -> "Underweight"
    | x when x > 18.5 && x <= 25.0 -> "Normal"
    | x when x > 25.0 && x <= 30.0 -> "Overweight"
    | x when x > 30.0 -> "Obese"
    | _ -> "Exception"
    

Console.ReadKey|>ignore