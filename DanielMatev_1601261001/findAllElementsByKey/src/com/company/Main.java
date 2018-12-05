package com.company;

import java.util.HashMap;
import java.util.Map;

public class Main {

    public static void main(String[] args) {

        Map<String, String> map = new HashMap<>();

        map.put("1", "one");
        map.put("2", "two");
        map.put("3", "three");
        map.put("4", "four");
        map.put("5", "five");
        map.put("6", "six");

        findElementByKey(map, "1");
        findElementByKey(map, "9");



    }

    private static <K,V> void findElementByKey(Map<K,V> map, K searchKey) {

        if(map.containsKey(searchKey)) {
            System.out.println(map.get(searchKey));
        } else {
            System.out.println(String.format("There is no value for key: %s", searchKey));
        }
    }
}
