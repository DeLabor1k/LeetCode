public class Solution 
{
    // Task 2452 | Medium
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) 
    {
        List<string> result = new List<string>();       // Создание списка для получения результата.

        foreach (string query in queries)               // Перебираем все слова из массива queries.
        {
            bool found = false;                         // Флаг, указывающий, что для текущего query найдено подходящее слово в словаре.
            foreach (string dict in dictionary)         // Проверяем текущее query против всех слов в словаре dictionary;
            {
                if (CountDiff(query, dict) <= 2)        // Берем  значения из второго метода CountDiff. Если количество различий не больше двух, слово подходит.
                {
                    found = true;
                    break;                              // Дальше словарь можно не проверять.
                }
            }
            if (found == true)                          // Если нашли подходящее слово то добавляем query в результат.
                {
                    result.Add(query);
                }
        } 
        return result;                                  // Возвращаем результат.
    }
    public int CountDiff(string s1, string s2)          //  Метод подсчёта количества различающихся символов в двух строках.
    {
        int diff = 0;                                   // Объявляем переменную diff для хранения кол-ва отличающихся букв в словах.

        for (int i = 0; i < s1.Length; i++)             // Цикл for проходит по всем символам строк.
        {
            if (s1[i] != s2[i])                         // Проходим по буквам с одинаковым индексом и если они не совпадают то увеличиваем значение diff (не совпадающие буквы).
            {
                diff++;
            }
        }
        return diff;                                    // Возвращаем diff.
    }
}