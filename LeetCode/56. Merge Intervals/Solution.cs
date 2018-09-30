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
        IList<Interval> sorted = intervals.OrderBy(o=>o.start).ToList();
        IList<Interval> merged = new List<Interval>();
        
        for(int i = 0; i < sorted.Count; i++){
            if(merged.Count == 0 || merged[merged.Count - 1].end < sorted[i].start){
                merged.Add(sorted[i]);
            }
            else{
                merged[merged.Count - 1].end = Math.Max(merged[merged.Count - 1].end, sorted[i].end);
            }
        }
        
        return merged;
        
    }
}