# ATM Console Application
This console application simulates an ATM (Automated Teller Machine) that allows users to perform various banking operations such as depositing money, withdrawing money, checking their account balance, and exiting the application. Users need to input their debit card number and PIN to access their account.

## Classes ATM
### #Main method:
 This is the entry point of the application. It contains the main logic for handling user interactions and banking operations.

#### printOptions method:
 This function displays the available banking options to the user.
#### deposit method:
 This function allows the user to deposit money into their account.

#### withdraw method:
 This function allows the user to withdraw money from their account, provided they have sufficient balance.

#### balance method:
 This function displays the current balance of the user's account.

#### cardHolder Class
This class represents a cardholder and stores information such as card number, PIN, first name, last name, and account balance. It also contains getter and setter methods for accessing and modifying the cardholder's information.

## Usage
When the application starts, the user is prompted to insert their debit card by entering the card number.
The user is then asked to enter their PIN for verification.
If the card number and PIN combination match any existing cardholder's data, the user is greeted with their name and presented with a list of options to choose from.
The user can select one of the following options:

* Option 1 * : Deposit money into their account.

* Option 2 * : Withdraw money from their account (if sufficient 
balance is available).

* Option 3 * : Check their current account balance.

* Option 4 * : Exit the application.

After performing the selected operation, the user is again presented with the list of options to choose from.
The user can continue to perform banking operations until they choose to exit the application (Option 4).

## Functionality

* Deposit * : The user can deposit a specific amount of money into their account. After the deposit is made, the new account balance is displayed.

* Withdraw * : The user can withdraw a specific amount of money from their account. If the requested amount exceeds the account balance, an error message is displayed. Otherwise, the withdrawal is successful, and the new account balance is shown.

* Show Balance * : The current balance of the user's account is displayed.

* Exit * : The user can choose to exit the application.
