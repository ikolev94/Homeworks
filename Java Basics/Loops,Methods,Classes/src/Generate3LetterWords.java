import java.util.ArrayList;
import java.util.Scanner;

public class Generate3LetterWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] inputText = scanner.nextLine().trim().toCharArray();
        ArrayList<String> output = new ArrayList<>();
        for (int i = 0; i < inputText.length; i++) {
            for (int j = 0; j < inputText.length; j++) {
                for (int k = 0; k < inputText.length; k++) {
                    char first = inputText[i];
                    Character mid = inputText[j];
                    char last = inputText[k];
                    String a =  String.format("%s%s%s", first, mid, last);
                    output.add(a);
                }
            }
        }
        System.out.println(String.join(" ", output));
    }
}
