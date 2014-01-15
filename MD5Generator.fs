open System.Security.Cryptography
open System.IO
open System


// grab md5
let getMD5 = fun(file:string) ->
    try
        let md5csp = MD5CryptoServiceProvider.Create()
        let md5value = file |> File.ReadAllBytes |> md5csp.ComputeHash |> Convert.ToBase64String
        printfn "%s - %s " file md5value
    with
        | _ as ex -> printfn "%s exception occured" file
