import java.util.Scanner;

public class CountofEqualBitPairs {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();

        char[] nToBit = Integer.toBinaryString(n).toCharArray();
        int sequenceLenght = 0;
        for (int i = 0; i < nToBit.length - 1; i++) {
            char currentSymbol = nToBit[i];
            char nextSymbol = nToBit[i + 1];
            if (currentSymbol == nextSymbol) {
                sequenceLenght++;
            }
        }
        System.out.println(sequenceLenght);
    }
}
