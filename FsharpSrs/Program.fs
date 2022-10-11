let Print3elm a =
    let b = a.ToString();
    let c = b.ToCharArray();
    printf "%c" (c[2]);
    
let PrintLastElm a =
    let b = a.ToString();
    let c = b.ToCharArray();
    printf "%c" (c[c.Length-1]);
   
       
let PrintKElm a k=
    let b = a.ToString();
    let c = b.ToCharArray();
    printf "%c" (c[k]);

let Eq2and4 a =
    let b = a.ToString();
    let c = b.ToCharArray();
    if c[1] = c[3] then
        printf "Equal";
    else
        printf "not Equal";

let EqFandL a =
    let b = a.ToString();
    let c = b.ToCharArray();
    if c[0] = c[c.Length-1] then
        printf "Equal";
    else
        printf "not Equal";

let Eq1Fand2L a1 a2 =
    let b1 = a1.ToString();
    let c1 = b1.ToCharArray();

    let b2 = a2.ToString();
    let c2 = b2.ToCharArray();

    if c1[0] = c2[c2.Length-1] then
        printf "Equal";
    else
        printf "not Equal";



let main =
    let str = "aadasds";
    let str2 = "aadasds";
    
    printfn "\n//task9.13//\n";
    Print3elm str;
    
    printfn "\n//task9.14//\n";
    PrintLastElm str;

    printfn "\n//task9.15//\n";
    PrintKElm str 2;

    printfn "\n//task9.16//\n";
    Eq2and4 str
    
    printfn "\n//task9.17//\n";
    EqFandL str
     
    printfn "\n//task9.18//\n";
    Eq1Fand2L str str2

main;