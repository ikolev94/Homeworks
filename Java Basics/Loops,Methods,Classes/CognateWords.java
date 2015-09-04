import java.util.ArrayList;
import java.util.HashSet;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CognateWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        Pattern pattern = Pattern.compile("[A-za-z]+");
        Matcher matcher = pattern.matcher(text);
        ArrayList<String> words = new ArrayList<>();
        while (matcher.find()) {
            words.add(matcher.group());
        }

        HashSet<String> uniqueWords = new HashSet<>();
        for (int i = 0; i < words.size(); i++) {
            for (int j = 0; j < words.size(); j++) {
                for (int k = 0; k < words.size(); k++) {
                    if (i == j || i == k || j == k) {
                        continue;
                    }
                    String firstWord = words.get(i);
                    String secondWord = words.get(j);
                    String thirdWord = words.get(k);
                    String result = firstWord + secondWord;
                    if (result.equals(thirdWord) && !uniqueWords.contains(result)) {
                        System.out.printf("%s|%s=%s", firstWord, secondWord, thirdWord);
                        System.out.println();
                        uniqueWords.add(result);
                    }
                }
            }
        }
        if (uniqueWords.size() == 0) {
            System.out.println("No");
        }
    }
}
