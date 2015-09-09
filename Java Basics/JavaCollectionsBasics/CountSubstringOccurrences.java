import java.util.Scanner;

public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine().toLowerCase();
        String wordToSearchFor = scanner.nextLine().toLowerCase();
        int count = 0;
        for (int i = 0; i < text.length() - wordToSearchFor.length() + 1; i++) {
            String currentSubString = text.substring(i, i + wordToSearchFor.length());
            if (wordToSearchFor.equals(currentSubString)) {
                count++;
            }
        }

        System.out.println(count);
    }
}
