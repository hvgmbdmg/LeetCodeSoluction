public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double result;
        int len1 = nums1.Length;
        int len2 = nums2.Length;

        int findSmall = (len1+len2+1)/2;    //--- Length, not index.
        int head1 = 0;  //--- is index
        int head2 = 0;  //--- is index
        int ignoreCount = head1 + head2;

        bool isEven;
        if( (len1+len2)%2==0 )
            isEven = true;
        else
            isEven = false;
        
        //--- If len1 || len2 is empty
        if ( len1==0 ){
            if(len2 == 0)   //--- both nums1 and nums2 are empty.
                result = 0;
            else    //--- Only nums1 is empty.
                result = haveEmptyArray( nums2 );
            return result;
        }
        else if ( len2==0 ){   //--- Only nums2 is empty.
            result = haveEmptyArray( nums1 );
            return result;
        }
        
        //--- Suppose Odd
        while ( ignoreCount+1<findSmall ){       //--- if break, means findSmall = ignoreCount.
            int chooseNum = (findSmall-head1-head2)/2;  //--- how much numbers I want to ignore this time.
            closerMedium( nums1, nums2, ref head1, ref head2, chooseNum );
            
            //Console.WriteLine("head1: "+head1+", head2: "+head2+", ignoreCount: "+ignoreCount+", chooseNum: "+chooseNum);
            ignoreCount += chooseNum;
        }   //--- while end;

        if ( chooseValidNumber(nums1,head1)<chooseValidNumber(nums2,head2) )
            result = nums1[head1];
        else
            result = nums2[head2];
        
        //Console.WriteLine("head1: "+head1+", head2: "+head2+", result: "+result);

        if ( isEven ){
            closerMedium( nums1, nums2, ref head1, ref head2, 1 );
            //Console.WriteLine("head1: "+head1+", head2: "+head2);
            
            if ( chooseValidNumber(nums1,head1)<chooseValidNumber(nums2,head2) )
                result = (result+nums1[head1])/2;
            else
                result = (result+nums2[head2])/2;
        }

        return result;
    }
    
    //Note: Special Case => [1,2,3,4,5,6] & [1];
    void closerMedium(int[] nums1, int[] nums2, ref int head1, ref int head2, int chooseNum ){
        int len1 = nums1.Length;
        int len2 = nums2.Length;

        if( head1+chooseNum>len1 ){
            head2+=chooseNum;
            return;
        }

        if( head2+chooseNum>len2 ){
            head1+=chooseNum;
            return;
        }

        if( nums1[head1+chooseNum-1]>nums2[head2+chooseNum-1] )
            head2+=chooseNum;
        else
            head1+=chooseNum;
    }
    
    int chooseValidNumber( int[] nums, int head ){
        if( head >= nums.Length )
            return Int32.MaxValue;
        return nums[head];
    }
    
    double haveEmptyArray( int[] nums ){
        int len = nums.Length;//len = 9
        double result = nums[len/2];
        if( len%2==0 ){
            result += nums[(len/2)-1] ;
            result /= 2;
        }
        return result;
    }

}