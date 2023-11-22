
string hello = " we are the champions?";

int stringLength = hello.Length;
 
//string trimmedString = hello.Trim();


hello = hello.Trim(); //väärtuse "hello" ümberkirjutamine vahemälus

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);



//int wordCounter = 1;  

//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i])) //tagastab: true / false
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.);
