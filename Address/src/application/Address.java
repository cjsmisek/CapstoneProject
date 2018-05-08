package application;

import javafx.beans.property.SimpleStringProperty;

public class Address {
    private final SimpleStringProperty firstName;
    private final SimpleStringProperty lastName;
    private final SimpleStringProperty address;


    public Address(
            String firstName,
            String lastName,
            String address
    ) {
        this.firstName = new SimpleStringProperty( firstName );
        this.lastName = new SimpleStringProperty( lastName );
        this.address = new SimpleStringProperty( address );
    }


    public String getFirstName() {
        return firstName.get();
    }

    public void setFirstName(String firstName) {
        this.firstName.set( firstName );
    }



    public String getLastName() {
        return lastName.get();
    }

    public void setLastName(String lastName) {
        this.lastName.set( lastName );
    }



    public String getAddress() {
        return address.get();
    }
    public void setAddress(String address) {
        this.address.set( address );
    }
}