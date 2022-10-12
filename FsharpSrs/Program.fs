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

let Slovsoch2i4 a = 
    let b = a.ToString();
    let c = b.ToCharArray(); 
    printf"%c%c"(c[1])(c[3]);

    
let Slovsoch3iL a = 
    let b = a.ToString();
    let c = b.ToCharArray(); 
    printf"%c%c"(c[2])(c[c.Length-1]);



////////////10/////////////

let Findx b = 
    let mutable tmp = 0.0;
    if b = "a" then
        tmp <- ((sqrt(6.0) + 6.0) / 2.0 + (sqrt(13.0) + 13.0) / 2.0 + (sqrt(21.0) + 21.0) / 2.0);
    else if b = "b" then 
        tmp <- ((sqrt(5.0) + 5.0) / (sqrt(7.0) + 7.0) + (sqrt(12.0) + 12.0) / (sqrt(8.0) + 8.0) + (sqrt(31.0) + 31.0) / (sqrt(2.0) + 2.0));
    else if b = "c" then 
        tmp <- ((sqrt(8.0) + 15.0) / (8.0 + sqrt(15.0)) + (sqrt(12.0) + 6.0) / (sqrt(6.0) + 12.0) + (sqrt(21.0) + 7.0) / (sqrt(7.0) + 21.0));
    else if b = "d" then 
        tmp <- ((sqrt(7.0) + 13.0) / (7.0 + sqrt(13.0)) + (sqrt(12.0) + 15.0) / (sqrt(15.0) + 12.0) + (sqrt(21.0) + 32.0) / (sqrt(32.0) + 21.0));
    (tmp)

let Findy b = 
    let mutable tmp = 0.0;
    if b = "a" then
        tmp <- ((1.0 + sin(1.0) / 3.0) + (5.0 + sin(5.0) / 3.0) + (3.0 + sin(3.0) / 3.0))
    else if b = "b" then 
        tmp <- (2.0 + sin(2.0) / sin(5.0) + 5.0) + (6.0 + sin(6.0) / sin(3.0) + 3.0) + (1.0 + sin(1.0) / sin(4.0) + 4.0);
    else if b = "c" then 
        tmp <- (1.0 + sin(4.0) / sin(1.0) + 4.0) + (7.0 + sin(5.0) / sin(7.0) + 5.0) + (3.0 + sin(2.0) / sin(3.0) + 2.0);
    else if b = "d" then 
        tmp <- (2.0 + sin(3.0) / sin(2.0) + 3.0) + (1.0 + sin(5.0) / sin(1.0) + 5.0) + (4.0 + sin(7.0) / sin(3.0) + 7.0);
    (tmp)

let Maxnum a b = 
    if (a > b) then
        (a);
    else 
        (b);

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
    Eq2and4 str;
    
    printfn "\n//task9.17//\n";
    EqFandL str;
     
    printfn "\n//task9.18//\n";
    Eq1Fand2L str str2;

    printfn "\n//task9.19//\n";
    Slovsoch2i4 str;

    printfn "\n//task9.20//\n";
    Slovsoch3iL str;

    
    printfn "\n//task10.1//\n";

    let mutable tmp = Findx "a"
    printfn "%f" tmp;

    tmp <- Findx "b"
    printfn "%f" tmp;
    
    tmp <- Findx "c"
    printfn "%f" tmp;
        
    tmp <- Findx "d"
    printfn "%f" tmp;

    printfn "\n//task10.2//\n";

    tmp <- Findy "a"
    printfn "%f" tmp;

    tmp <- Findy "b"
    printfn "%f" tmp;
    
    tmp <- Findy "c"
    printfn "%f" tmp;
        
    tmp <- Findy "d"
    printfn "%f" tmp;

    printfn "\n//task10.3//\n";

    let a = 5;
    let b = 5;

    let mutable z = Maxnum a (b * 2) * Maxnum (2 * a - b) b;
    printfn "%i" z;
    
    z <- max a (b * 2) * max (2 * a - b) b;
    printfn "%i" z;

    printfn "\n//task10.4//\n";

    z <- Maxnum a (b * 3) * Maxnum (2 * a - b) (2*b);
    printfn "%i" z;
    
    z <- max a (b * 3) * max (2 * a - b) (2*b);
    printfn "%i" z;
    

main;