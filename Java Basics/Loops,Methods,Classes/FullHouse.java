public class FullHouse {
    public static void main(String[] args) {
        String[] faces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String[] suits = new String[]{"♣", "♦", "♥", "♠"};
        int count = 0;
        for (int leftFace = 0; leftFace < faces.length; leftFace++) {
            for (int rightFace = 0; rightFace < faces.length; rightFace++) {
                for (int i1 = 0; i1 < suits.length; i1++) {
                    for (int i2 = i1 + 1; i2 < suits.length; i2++) {
                        for (int i3 = i2 + 1; i3 < suits.length; i3++) {
                            for (int i4 = 0; i4 < suits.length; i4++) {
                                if (leftFace != rightFace) {
                                    for (int i5 = i4 + 1; i5 < suits.length; i5++) {
                                        count++;
                                        System.out.printf("(%1$s%2$s %1$s%3$s %1$s%4$s %7$s%5$s %7$s%6$s)\n"
                                                , faces[leftFace]
                                                , suits[i1]
                                                , suits[i2]
                                                , suits[i3]
                                                , suits[i4]
                                                , suits[i5]
                                                , faces[rightFace]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        System.out.println(count);
    }
}

