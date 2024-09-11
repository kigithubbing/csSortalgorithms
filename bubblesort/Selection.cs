using System.Runtime.CompilerServices;

namespace Algorithms;

public class Selection {

    public static string Sort(int[] input) {
        ArgumentNullException.ThrowIfNull(input);
        if (input.Length == 1) return $"{input[0]}";
        
        for (int round =0 , min = round; round < input.Length -1 ; round ++)  {
            for (int i=round+1; i < input.Length ; i++)
                if(input[min]>input[i])
                    min = i;

            if (min != round) (input[round],input[min]) = (input[min],input[round]);
        }

        return input.Aggregate(string.Empty, (a,b) => a+=$"{b} ");
    }   

}