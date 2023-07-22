# Bank-project
This project consist of two steps: 1- create Accounts 2- performing bank operations base on customer ask
Consider a simple banking system with two classes: "Account" and "Bank". Each Account has a unique account number (شماره حساب), an account holder's name, and a balance.
The Bank class keeps track of multiple Account objects. The "Bank" class is responsible for managing multiple "Account" objects within the banking system.
It provides functionalities to create new accounts, retrieve account information, and perform operations on individual accounts. Here's a more detailed explanation of the Bank class:

1.	Class Name: Bank
2.	Properties:
o	accounts: A collection (such as an array, list, or dictionary) that stores the Account objects.
3.	Public Methods and Functionalities:
o	createAccount(accountNumber, accountHolderName, initialBalance): Creates a new Account object with the specified account number, account holder's name, and initial balance, then adds it to the accounts collection.
o	getAccount(): Retrieves the Account object with the specified account number from the accounts collection.
o	deposit(): Deposits the specified amount into the account with the given account number. The account's balance will be updated accordingly.
o	withdraw(): Withdraws the specified amount from the account with the given account number, if the account has sufficient balance. Otherwise, it displays an error message.
o	getBalance(): Retrieves the current balance of the account with the specified account number.
o	printAccountDetails(): Prints the account details (account number, account holder's name, and balance) for all accounts in the bank. It traverses the accounts collection and displays the information for each Account object.
The Bank class acts as a container for managing multiple Account objects and providing methods to interact with them. It allows users to create new accounts, perform transactions (deposit and withdraw), get balance information, and display account details.


Algorithm:
Database:
1- Create a number of accounts and save them like database
2-display accounts information
Bank operation
3- select of bank operations by customer between this choicec: C (Creat Account) , D (Deposit) , W (Withdraw) , B (Get balance) )
4- Do the bank operation base on custumer's choice

Example:
if custumer select D:
5- Asked customer to tell his/her account number
6- find the custumer from  build database and if the custumer there isn't in database the program throw an error message with getAccount() method
7-Asked customer to tell the money that he/she want to deposit
8-call deposit() method 
