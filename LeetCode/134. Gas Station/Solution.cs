public class Solution {
    private bool startAt(int[] gas, int[] cost, int start){
        int tank = gas[start] - cost[start];
        
        int i = (start + 1) % gas.Length;
        while(i < start){
            tank += gas[i];
            if(cost[i] > tank) return false;
            
            tank -= cost[i];
            i = (i + 1) % gas.Length;
        }
        
        return true;
    }
    
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        for(int i = 0; i < gas.Length; i++){
            if(gas[i] > cost[i] && startAt(gas, cost, i)) return i;
        }
        
        return -1;
    }
}