System.Console.WriteLine("input data:")

let create_collection() =
    let read_input n = Array.init n (fun _ -> System.Console.ReadLine())
    let my_array = System.Console.ReadLine() |> int |> read_input |> Array.map int
    my_array
    
let user_list = create_collection()

let output = Array.sum user_list
printf $"answer: {output}"
