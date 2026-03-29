public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> merged = new List<int>();
        merged.AddRange(nums1);
        merged.AddRange(nums2);
        merged.Sort();
        
        int count = merged.Count;
        if (count % 2 == 0) {
            int mid1 = count / 2 - 1;
            int mid2 = count / 2;
            return (merged[mid1] + merged[mid2]) / 2.0;
        } else {
            return merged[count / 2];
        }
    }
}