public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int m = nums.Length - 1; m >= 0; m--) {    // Перебераем список nums с конца через nums.Length - 1
            for (int n = m - 1; n >= 0; n--) {          // Берем меньшую цифру n от m на 1
                if (nums[n] == target - nums[m]) {      // Проверяем что цифры сходяться через разность
                    return new int[] {m,n}; 
                }
            }
        }
        return new int[] {};                            // Выводим если нет ответа
    }
}