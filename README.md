Instructions to Run the Project on multiple platforms:
In the project there is one class called > Browser Selector > Go to this class > at the top and inside de class there is one variable called browsername with the value = firefox, it means the script will run in firefox, in order to run the scripts on chrome the value of browsername should be Chrome, the same For IE, if browsername = ie then script will get executed on IE platform.
My project structure is based on POM design so inside the project there is two folder, one folder is called Main.
Inside Main folder is all about setting up the framework, reusability class, Page class and methods.
Test folder constains the Test suite and Base test class.
Test Suite class contains all the Test scripts.
BaseTest class executed any particular pre-condition before a test run.
