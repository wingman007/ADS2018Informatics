package app;

import app.compression.Compressor;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String userInput = input.nextLine();

        System.out.println(Compressor.runLengthCompression(userInput));

        input.close();
    }
}
