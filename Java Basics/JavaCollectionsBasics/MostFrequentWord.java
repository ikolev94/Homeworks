import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        Pattern pattern = Pattern.compile("[A-Za-z]+");
        Matcher matcher = pattern.matcher(text.toLowerCase());
        Map<String, Integer> uniqueWords = new TreeMap<>();
        while (matcher.find()) {
            if (uniqueWords.containsKey(matcher.group())) {
                int value = uniqueWords.get(matcher.group());
                uniqueWords.put(matcher.group(), ++value);
            } else {
                uniqueWords.put(matcher.group(), 1);
            }
        }
        int max = 0;
        for (String key : uniqueWords.keySet()) {
            if (uniqueWords.get(key)>max){
                max = uniqueWords.get(key);
            }
        }
        for (String key : uniqueWords.keySet()) {
            if (uniqueWords.get(key) == max){
                System.out.printf("%s -> %d",key,uniqueWords.get(key));
                System.out.println();
            }
        }
    }
}
