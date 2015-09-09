import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Map<String,Integer> words = new LinkedHashMap<>();
        String[] inputLine = scanner.nextLine().split(" ");
        for (String word : inputLine) {
            if (!words.containsKey(word)){
                words.put(word,1);
            } else {
                int count = words.get(word);
                count++;
                words.put(word,count);
            }
        }

        for (String key : words.keySet()) {
            int count = words.get(key);
            for (int i = 0; i < count; i++) {
                System.out.print(key + " ");
            }
            System.out.println();
        }
    }
}
