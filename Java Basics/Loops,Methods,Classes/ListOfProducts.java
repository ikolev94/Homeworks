import java.io.*;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;

public class ListOfProducts {
    public static void main(String[] args) throws IOException {
        ArrayList<Product> products = new ArrayList<>();
        try (BufferedReader reader = new BufferedReader(new FileReader("input.txt"))) {
            String inputLine = reader.readLine();
            while (inputLine != null && !inputLine.isEmpty()) {
                String[] inputArgs = inputLine.split(" ");
                String productName = inputArgs[0];
                BigDecimal price = new BigDecimal(inputArgs[1]);
                products.add(new Product(productName, price));
                inputLine = reader.readLine();
            }
        } catch (FileNotFoundException e) {
            System.out.println("Cannot find file");
        }
        Collections.sort(products);
        try (BufferedWriter writer = new BufferedWriter(new FileWriter("output.txt"))) {
            for (Product product : products) {
                String output = String.format("%s %s%n", product.getPrice(), product.getName());
                writer.write(output);
            }
        }
    }
}
