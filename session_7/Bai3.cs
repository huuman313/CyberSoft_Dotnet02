class Bai3 {
    public static List<string> findAllStartM (List<string> lstString) {
        List<string> results = new List<string>();
        foreach (string str in lstString) {
            // if (str.Contains("m") == true) {
            if (str.StartsWith("m") == true) {
                results.Add(str);
            }
        }
        return results;
    }
}