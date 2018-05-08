package application;

import javafx.collections.ObservableList;
import java.io.FileWriter;
import javafx.scene.control.Dialog;
import  javafx.scene.control.Alert;
/**
 * Sample Skeleton for 'TableView.fxml' Controller Class
 */

import javafx.fxml.FXML;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import java.io.FileNotFoundException;
import java.net.URLEncoder;
import java.nio.file.Files;
import java.nio.file.Paths;
import javafx.collections.transformation.FilteredList;
import javafx.collections.transformation.SortedList;
import java.awt.Desktop;
import java.net.URI;


public class TableController {

    @FXML // fx:id="customerTable"
    private TableView<Address> addressTable;

    @FXML // fx:id="firstNameColumn"
    private TableColumn<Address, String> firstNameColumn;

    @FXML // fx:id="lastNameColumn"
    private TableColumn<Address, String> lastNameColumn;

    @FXML // fx:id="phoneNumberColumn"
    private TableColumn<Address, String> addressColumn;

    @FXML // fx:id="fNameInput"
    private TextField fNameInput;

    @FXML // fx:id="lNameInput"
    private TextField lNameInput;

    @FXML // fx:id="addressInput"
    private TextField addressInput;

    @FXML //
    private TextField filterTxt;

    @FXML //basically works like an onload() method
    protected void initialize() {

        //setting up the columns
        PropertyValueFactory<Address, String> firstNameProperty =
                new PropertyValueFactory<Address, String>("firstName");

        PropertyValueFactory<Address, String> lastNameProperty =
                new PropertyValueFactory<Address, String>("lastName");

        PropertyValueFactory<Address, String> addressProperty =
                new PropertyValueFactory<Address, String>("address");

        firstNameColumn.setCellValueFactory( firstNameProperty );
        lastNameColumn.setCellValueFactory( lastNameProperty );
        addressColumn.setCellValueFactory( addressProperty );

        //setting up the table data source
        DataSource data = new DataSource();
        ObservableList<Address> tableItems = data.getData();
        addressTable.setItems( tableItems );

        // Wrap observableList in filteredList
        FilteredList<Address> filterData = new FilteredList<>(tableItems, p -> true);
        // Set filter Predicate when filter changes
        filterTxt.textProperty().addListener(((observable, oldValue, newValue) -> {
            filterData.setPredicate(address -> {
                // If filter is empty display all addresses
                if (newValue == null || newValue.isEmpty()) {
                    return true;
                }

                // compare first and last name of filter text
                String lowerCaseFilter = newValue.toLowerCase();

                if (address.getFirstName().toLowerCase().contains(lowerCaseFilter)) {
                    return true; // Filter matches first name.
                } else if (address.getLastName().toLowerCase().contains(lowerCaseFilter)) {
                    return true; // Filter matches last name.
                }
                return false; // Does not match.
            });
        }));

        // Wrap the FilteredList in a SortedList.
        SortedList<Address> sortedData = new SortedList<>(filterData);

        // Bind the SortedList comparator to the TableView comparator.
        sortedData.comparatorProperty().bind(addressTable.comparatorProperty());

        // Add sorted (and filtered) data to the table.
        addressTable.setItems(sortedData);
    }


    @FXML// Add Button clicked
    public void addButtonClicked(){
        String firstName = fNameInput.getText();
        String lastName = lNameInput.getText();
        String address = addressInput.getText();
        DataSource.data.add(new Address(firstName, lastName, address));

        try{
            String object = new String(Files.readAllBytes(Paths.get("C:\\Users\\vjsmi\\IdeaProjects\\Address\\src\\application\\address.json")));
            String j = object;

            JSONParser parser = new JSONParser();
            JSONObject json = (JSONObject) parser.parse(j);

            //convert Object to JSONObject
            JSONObject jsonObject = new JSONObject(json);

            //Reading the array
            JSONArray people = (JSONArray) jsonObject.get("people");

            // create address objects
            JSONObject newAddress = new JSONObject();
            newAddress.put("firstName", firstName);
            newAddress.put("lastName", lastName);
            newAddress.put("address", address);
            people.add(newAddress);
            // add object to person object
            json.put("people", people);

            // JSON to string **** write to file
            FileWriter fileWriter = new FileWriter("C:\\Users\\vjsmi\\IdeaProjects\\Address\\src\\application\\address.json");
            fileWriter.write(json.toJSONString());
            fileWriter.flush();

        }catch(FileNotFoundException fe)
        {
            fe.printStackTrace();
        }
            catch(Exception e)
        {
            e.printStackTrace();
        }

        ObservableList<Address> tableItems = DataSource.getData();
        addressTable.setItems( tableItems );
    }

    @FXML //Get Map button clicked
    public void mapButtonClicked(){
        if (addressTable.getSelectionModel().getSelectedItem() != null) {
            Address address = addressTable.getSelectionModel().getSelectedItem();
            String maps = address.getAddress();
            if (Desktop.isDesktopSupported()) {try {
                maps = URLEncoder.encode(maps, "UTF-8");
                Desktop.getDesktop().browse(new URI("www.google.com/maps/place/" + maps));
            }
            catch(Exception e)
            {
                e.printStackTrace();
            }
            }
        }
        else {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText(null);
            alert.setContentText("Select an Address from the table.");

            alert.showAndWait();
        }
    }
}