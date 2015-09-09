import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CardsFrequencies {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        Pattern pattern = Pattern.compile("[JAKQ]|[0-9]+");
        Matcher matcher = pattern.matcher(text);
        Map<String, Double> cardsByAppearances = new LinkedHashMap<>();
        int count = 0;
        while (matcher.find()) {
            if (cardsByAppearances.containsKey(matcher.group())) {
                double value = cardsByAppearances.get(matcher.group());
                cardsByAppearances.put(matcher.group(), ++value);
            } else {
                cardsByAppearances.put(matcher.group(), 1.0);
            }
            count++;
        }

        for (String key : cardsByAppearances.keySet()) {

            System.out.printf("%s -> %.2f%%", key, (cardsByAppearances.get(key)/count)*100);
            System.out.println();

        }
    }
}
