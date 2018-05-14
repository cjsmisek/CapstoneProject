package application;

import java.io.IOException;
import java.net.URL;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;


public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws IOException {
        URL url = getClass().getResource("TableView.fxml");

        AnchorPane pane = FXMLLoader.load( url );
        Scene scene = new Scene( pane );

        URL url1 = this.getClass().getResource("style.css");
        if (url1 == null) {
            System.out.println("Resource not found. Aborting.");
            System.exit(-1);
        }
        String css = url1.toExternalForm();
        scene.getStylesheets().add(css);

        primaryStage.setScene( scene );
        primaryStage.setTitle( "JavaFX TableView" );
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }


}