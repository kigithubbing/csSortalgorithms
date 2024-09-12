// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

// var bubble = new Algorithms.Bubble();


object[] inputs =  new object[] { new string[] {"arwe","add","anj","acio"}, new int[] {43,57,9,19}
                                ,new float[] {89.31f,90.09f,2.1f,9.11f,109f,-2f,-0.4f,198f,12f} };
foreach (var input in inputs)
    switch (input) {
        case string[] ss:
            foreach (var flag in new bool[] {true,false}) 
                {  
                    var res =  Algorithms.Bubble.Sort(ss,flag);
                    if(flag)
                     Console.WriteLine($"The Result is for string array, convert to {flag} is: {res}");
                    else {
                        
                        Console.WriteLine($"The Result is for string array, convert to {flag} is:");
                        var res2 = res as string[];
                        res2?.ToList()?.ForEach(x=> Console.WriteLine(x));
                    }
                }
            break;
        case int[] ii:
            {
                var res = Algorithms.Bubble.Sort(ii);
                Console.WriteLine($"The Result is for int array is: {res}");
                var resSelection=Algorithms.Selection.Sort(ii);
                Console.WriteLine($"The Result is for int array using Selection Sort is: {resSelection}");
                var resInsertion = Algorithms.Insertion.Sort(ii);
                var resString = string.Empty;
                foreach (var s in resInsertion) 
                    resString+= $"{s} ";
                Console.WriteLine($"The Result is for int array using Insertion is: {resString}");
                var resMergeSort = Algorithms.MergeSort.Sort(new int[] {43,57,9,19});
                resString = string.Empty;
                foreach (var s in resInsertion) 
                    resString+= $"{s} ";
                Console.WriteLine($"The Result is for int array using MergeSort is: {resString}");

                break;
            }
        case float[] f:
            {
                var res = Algorithms.Bubble.Sort(f);
                Console.WriteLine($"The Result is for float array is: {res}");
                break;
            }
    }