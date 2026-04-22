/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    // Task 94 | Easy
    public IList<int> InorderTraversal(TreeNode root) 
    {
        List<int> result = new List<int>();                 // Список для хранения результата.
        Stack<TreeNode> stack = new Stack<TreeNode>();      // Стек для хранения узлов, ожидающих обработки.
        TreeNode current = root;                            // Указатель на текущий узел, начиная с корня.

        while (current != null || stack.Count > 0)          // Пока есть непройденные узлы. Условие: Если текущий узел не null или в стеке еще есть узлы.
        {
            while (current != null)                         // Спускаемся вниз влево по дереву
            {
                stack.Push(current);                        // Кладем текущий узел в стек.
                current = current.left;                     // Переходим к левому потомку.
            }
            current = stack.Pop();                          // Если пришли слева в тупик, достаем узел из стека.
            result.Add(current.val);                        // Добавляем значение узла в результат
            current = current.right;                        // Переходим к правому поддереву. Начинаем спуск влево по нему.
        }
        return result;                                      // Возвращаем результат.
    }
}