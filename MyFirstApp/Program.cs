// This is a comment to my code

//Rakendus küsib kasutajal tema nime mida peab ta sisestama
// rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output
//string - sõne
string userName = Console.ReadLine(); //Input

// saad ka kasutada  Console.WriteLine("Hello" + ", " + userName);
Console.WriteLine("Hello, " + userName + "!");  //Output

//string interpolation parem varjant
Console.WriteLine($"Hello, {userName} !"); //Output

