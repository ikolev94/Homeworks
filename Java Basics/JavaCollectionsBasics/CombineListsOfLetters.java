import java.util.ArrayList;
import java.util.Scanner;

public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] firstWord = scanner.nextLine().split(" ");
        String[] secondWord = scanner.nextLine().split(" ");
        ArrayList<Character> first = new ArrayList<>();
        ArrayList<Character> second = new ArrayList<>();
        for (String s : firstWord) {
            first.add(s.charAt(0));
        }

        for (String s : secondWord) {
            second.add(s.charAt(0));
        }
        second.removeAll(first);
        first.addAll(second);
        for (Character letter : first) {
            System.out.print(letter + " ");
        }

    }
}
