import java.util.Random;
import java.util.Scanner;

public class RandomHandsOf5Cards {
    public static void main(String[] args) {
        String[] faces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String[] suits = new String[]{"♣", "♦", "♥", "♠"};
        Random random = new Random();
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        for (int i = 0; i < n; i++) {
            System.out.printf("%s%s %s%s %s%s %s%s %s%s\n"
                    , faces[random.nextInt(12)]
                    , suits[random.nextInt(4)]
                    , faces[random.nextInt(12)]
                    , suits[random.nextInt(4)]
                    , faces[random.nextInt(12)]
                    , suits[random.nextInt(4)]
                    , faces[random.nextInt(12)]
                    , suits[random.nextInt(4)]
                    , faces[random.nextInt(12)]
                    , suits[random.nextInt(4)]);
        }
    }
}
