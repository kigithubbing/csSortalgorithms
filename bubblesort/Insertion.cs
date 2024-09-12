namespace Algorithms;
public class Insertion {

    public static int[] Sort(int[] input){
        ArgumentNullException.ThrowIfNullOrEmpty(nameof(input));
        if (input.Length == 1) return input;
        
        for(int i = 1; i < input.Length; i++)
            for(int j=i-1; j>=0; j--) 
                if (input[i] < input[j])
                    (input[i] ,input[j]) = (input[j],input[i]);

        return input;
    }          
    
}