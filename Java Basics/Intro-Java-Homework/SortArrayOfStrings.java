import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        String[] words = new String[n];
        for (int i= 0;i < n;i++){
        words[i]=scanner.nextLine();
            if (words[i].isEmpty()) {
                i--;
            }
        }

        sort(words);

        for (String word :words){
            System.out.println(word);
        }
    }

    public static String[] sort(String[] collection){

        for (int i = 0; i < collection.length - 1; i++) {
            for (int j = i + 1; j < collection.length ; j++) {
                if (collection[i].compareTo(collection[j]) > 0){
                    String oldValue = collection[j];
                    collection[j] = collection[i];
                    collection[i] = oldValue;
                }

            }
        }

        return collection;
    }
}
