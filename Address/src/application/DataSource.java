package application;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import java.io.FileNotFoundException;
import java.io.FileReader;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import java.lang.String;
import java.util.Scanner;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Iterator;


public class DataSource {

    public static final ObservableList<Address> data =
            FXCollections.observableArrayList();

    public static ObservableList<Address> getData() {
        return data;
    }

    public DataSource()  {
        try {
            String object = new String(Files.readAllBytes(Paths.get("C:\\Users\\vjsmi\\IdeaProjects\\Address\\src\\application\\address.json")));
            String j = object;

            JSONParser parser = new JSONParser();
            JSONObject json = (JSONObject) parser.parse(j);

            //convert Object to JSONObject
            JSONObject jsonObject = new JSONObject(json);

            //Reading the array

            JSONArray slideContent = (JSONArray) jsonObject.get("people");
            Iterator i = slideContent.iterator();

            while (i.hasNext()) {
                JSONObject slide = (JSONObject) i.next();
                String firstName = (String)slide.get("firstName");
                String lastName = (String)slide.get("lastName");
                String address = (String)slide.get("address");
                data.add(new Address(firstName, lastName, address));
            }

        }catch(FileNotFoundException fe)
            {
                fe.printStackTrace();
            }
        catch(Exception e)
        {
            e.printStackTrace();
        }
    }


}