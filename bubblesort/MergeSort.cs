using System.Runtime.InteropServices;

namespace Algorithms;
public class MergeSort {

    public static int[] Sort(int[] arr) {
        ArgumentNullException.ThrowIfNullOrEmpty(nameof(arr));
       
        var mid =arr.Length/2;
        // Range r = new Range(mid);
        var firstHalf=Divide(arr.Take(mid).ToArray());
        var rightHalf=Divide(arr.Skip(mid).ToArray());
        return Merge(firstHalf,rightHalf);
    }   

    private static int[] Divide(int[] arr) {
       if (arr.Length == 1) return arr;
       if (arr.Length == 2 ) return Swap(arr);  
        var mid =arr.Length/2;
        var left = Divide(arr.Take(mid).ToArray());
        var right = Divide(arr.Take(new Range(new Index(mid+1),new Index(1,true))).ToArray());
        return Merge(left, right);
        
    }

   private static int[] Merge(int[] left, int[] right)
    {
        var result = new int[left.Length + right.Length];
        bool inserted;
        {int pos=0;
        foreach(var i in left) result[pos++] = i;  
        }
        for(int r = 0 ; r < right.Length ; r++)
          {  
            inserted=false;
            for (int l = left.Length -1 ; l>=0; l--)
                if (right[r] > left[l] ) 
                {
                    
                    for(int pos=0; pos<result.Length ; pos++)
                        if (result[pos]== left[l])
                            {
                                
                                result[pos+1] = right[r];
                                inserted=true;
                                break;
                            }

                   if(inserted) break;
                }
            if(!inserted) 
                result =  new int[1] { right[0] }.Concat(result).ToArray() ;
          }     
        return result;
    }

    private static int[] Swap(int[] arr) {
        if (arr.Length!= 2) throw new ArgumentException("Invalid length. This needs an array of 2 elements");
          if (arr[0] > arr[1]) 
                 (arr[0],arr[1]) = (arr[1],arr[0]);
        return arr;
    }

}