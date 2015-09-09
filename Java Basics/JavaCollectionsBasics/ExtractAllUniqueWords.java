import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        Pattern pattern = Pattern.compile("[A-Za-z]+");
        Matcher matcher = pattern.matcher(text);
        Set<String> uniqueWords = new HashSet<>();
        while (matcher.find()){
            uniqueWords.add(matcher.group());
        }
        uniqueWords.iterator().forEachRemaining(w-> System.out.print(w + " "));
    }
}
