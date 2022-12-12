open System

Console.WriteLine("input data:")
let first_param = Console.ReadLine() |> int
let second_param = Console.ReadLine() |> int

Console.Write($"answer:\n{first_param + second_param}")
