/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Merge(IList<Interval> intervals) {
        IList<Interval> result = new List<Interval>();
        List<int> head = new List<int>();
        List<int> tail = new List<int>();
        int len = intervals.Count;
        
        for( int i=0; i<len; i++ ){
            head.Add( intervals[i].start );
            tail.Add( intervals[i].end );
        }
        
        head.Sort();
        tail.Sort();
        
        int j=0;
        for( int i=0; i<len; i++ ){
            if( i==len-1 || head[i+1] > tail[i] ){
                result.Add( new Interval( head[j], tail[i] ) );
                j = i+1;
            }
        }
        
        return result;
    }
}