import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class SumNumbersFromATextFile {
    public static void main(String[] args) throws IOException {
        try {
            BufferedReader reader = new BufferedReader(new FileReader("input.txt"));
            String inputLine = reader.readLine();
            int sum = 0;
            while (inputLine !=null && !inputLine.isEmpty()) {
                sum += Integer.parseInt(inputLine);
                inputLine = reader.readLine();
            }
            System.out.println(sum);
            reader.close();
        } catch (FileNotFoundException e) {
            System.out.println("Error - file is missing");
        }
    }
}
