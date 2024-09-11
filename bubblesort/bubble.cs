using System;
using System.Collections.Generic;
using System.ComponentModel;
using extensions;

namespace Algorithms;

public class Bubble {

public static object? Sort<T>(T input, bool convert=false)
{
    if(input==null) throw new ArgumentNullException("input");
        return input switch
        {
            string[] => convert ? SortString(input) : SortStringArray(input),
            int[] or float[] => SortString(input),
            _ => throw new ArgumentException($"Invalid input type: {input.GetType}"),
        };
}


 public static string SortString<T>(T input) =>
	MakePlainString(SortStringArray(input));
 public static string[] SortStringArray<T>(T input) => Sort(input);

 private static string MakePlainString(string[] from){
	string ret=string.Empty;
	from.ToList().ForEach(x=> ret+=$"{x} ");
	return ret;
 }
private static string[] Sort<T>(T input) {

	bool swapped= true;
	if (input == null) throw new ArgumentNullException(nameof(input));
        string[] thisInput = input switch
        {
            string[] ss => ss,
            int[] ai => ai.Select(x => x.ToString()).ToArray(),
			float[] ff => ff.Select(x => x.ToString()).ToArray(),
            _ => throw new ArgumentException("Input must be of type string[]", nameof(input)),
        };

    for (int i=thisInput.Length-1; i>=0; i--) {
		for(int j=0; j< i; j++){
			swapped = true;
			if (input is string[]){
				var swapItems = new ExtensionString[2] { new (thisInput[j]),new (thisInput[j+1])};
				swapped = false;

				if (swapItems[0] > swapItems[1]) {
					(thisInput[j+1], thisInput[j]) = (thisInput[j], thisInput[j+1]);
					swapped = true;
				}
			}
			else if (input is int[] && int.Parse(thisInput[j]) > int.Parse(thisInput[j+1] ) )  
				(thisInput[j+1], thisInput[j]) = (thisInput[j], thisInput[j+1]);
			else if (input is float[] && float.Parse(thisInput[j]) > float.Parse(thisInput[j+1]) )
				(thisInput[j+1], thisInput[j]) = (thisInput[j], thisInput[j+1]);
			else 
				swapped = false;

		}
		if (!swapped) break;
	}
	return thisInput;
   }
}


