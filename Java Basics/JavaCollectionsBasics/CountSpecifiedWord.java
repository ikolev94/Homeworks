import java.util.Scanner;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] words = scanner.nextLine().split("[^A-Za-z]+");
        String wordToSearch = scanner.nextLine().toLowerCase();
        int count = 0;
        for (String word : words) {
            count = wordToSearch.equals(word.toLowerCase()) ? count + 1 : count;
        }
        System.out.println(count);
    }
}
