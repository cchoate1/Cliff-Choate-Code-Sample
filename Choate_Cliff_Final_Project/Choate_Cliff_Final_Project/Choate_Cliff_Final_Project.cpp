// Choate_Cliff_Final_Project.cpp : This file contains the 'main' function. Program execution begins and ends there.
// Purpose: Basic functions of a customer resource management system for car dealer
// Author: Cliff Choate
// Date: 5/12/2020

#include <iostream>
#include <string>
#include <fstream>
#include <map>
#include <ctime>
#include "LogIn.h"
#include "Validator.h"
#include "dataTypes.h"
#include "Maps.h"
#include "LinkedList.h"
#include <queue>
#include "PriorityQueueList.h"

using namespace std;

void printMainMenu(string currentUser);
void inventoryControl();
void customerControl();
void leadControl();
void SOControl();
void saveAllLists();
void loadAllLists();
void printInventory();
void printCustomers();
void printLeads();
void printSalesOrders();
void availableInventory();
void loadHotList();
string getInventory();
string getCustomer();
string getLead();
string getSO();


static const int yearLimit = 2021;





int main()
{
	

	string userName = "";
	string password = "";
	string email = "";
	string currentUser = "";
	bool validUser = false;
	int menu = 0;

	loadAllLists();

	userList = loadUsers("userList.txt");
	cout << "Customer Resource Manager Light" << endl;

	while (!inRange(1, 2, menu)) // rudimentary login/new user function
	{
		cout << "Do you need to enter a new user? \n1) No \n2) Yes \n--> ";
		menu = inputInt();
		cin.ignore();
		switch (menu)
		{
			case 1:
			{
				break;
			}
			case 2:  // creates new user. Currently, no permissions or validation
			{
				cout << "Enter new username: ";
				getline(cin, userName);
				cout << "Enter " << userName << "'s password:";
				getline(cin, password);
				cout << "Enter " << userName << "'s e-mail address";
				getline(cin, email);

				if (userList.find(userName) == userList.end())
				{
					userList.emplace(userName, hashFunction(password));
					currentUser = userName;
					validUser = true;
					saveUsers(userList, "userList.txt");
				}
				else
				{
					cout << "User name already exists." << endl;
					menu = 0;
				}
			}
			default:
			{
				cout << "Invalid entry" << endl;
			}
		}
	}

	
	
	while (userList.find(userName) == userList.end() || validUser == false) // verify login
	{
		cout << "\nEnter username: ";
		getline(cin, userName);
		cout << "Enter Password: ";
		getline(cin, password);
		if (userList.count(userName) == 1)
		{
			validUser = hashCheck(userName, password, userList); // returns true if password hash matches
		}
		if (validUser == false)
		{
			cout << "The user information you entered is invalid. Please try again." << endl;
		}
		else
		{
			currentUser = userName;
		}
	}

	if (userList.find(currentUser) != userList.end()) // if a valid user is logged in
	{
		
		do
		{
			printMainMenu(currentUser); // top menu, functions except password change placed in own methods, future plans, make function methods a template
			menu = inputInt();
			switch (menu)
			{
			case 1:
			{
				inventoryControl();
				break;
			}
			case 2:
			{
				customerControl();
				break;
			}
			case 3:
			{
				leadControl();
				break;
			}
			case 4:
			{
				SOControl();
				break;
			}
			case 5:
			{
				cout << currentUser << ", enter new password: ";
				cin.ignore();
				getline(cin, password);
				changePassword(userList, currentUser, password);
				saveUsers(userList,"userList.txt");
				break;
			}
			case 6:
			{
				cout << "Saving and exiting";
				saveAllLists();
				
				break;
			}
			default:
			{
				cout << "Invalid menu selection. \n" << endl;
			}
			}

		} while (menu != 6);
	}
}

// menu printing functions-------

void printMainMenu(string currentUser)
{
	if (currentUser != "")
	{
		cout << "\n" << currentUser << " is currently logged in" << endl;
	}
	cout << "\nMake a selection \n1) Inventory \n2) Customers \n3) Leads \n4) Sales Orders \n5) Change Password \n6) Exit \n--> ";
}

void printSubMenu(string dataType)
{
	
	if (dataType == "Lead")
	{
		cout << dataType << " Control \nMake a selection \n1) View Current Lead \n2) New \n3) Edit \n4) Delete \n5) Return \n--> ";
	}
	else if (dataType == "Sales Order")
	{
		cout << dataType << " Control \nMake a selection \n1) View \n2) New \n3) Delete \n4) Return \n--> ";
	}
	else
	{
		cout << dataType << " Control \nMake a selection \n1) View \n2) New \n3) Edit \n4) Delete \n5) Return \n--> ";
	}

}

//-----------------------------

// detail print functions -------

void inventoryDetail(string inventoryID)
{
	Inventory printee = inventoryList.at(inventoryID);
	cout << "\nPrice:  $" << printee.price << endl;
	cout << "Year:   " << printee.year << endl;
	cout << "Make:   " << printee.make << endl;
	cout << "Model:  " << printee.model << endl;
	cout << "Color:  " << printee.color << endl;
	cout << "VIN:    " << printee.VIN << endl;
	if (printee.available == true)
	{
		cout << "Available for sale" << endl;
	}
	else
	{
		cout << "Not available for sale" << endl;
	}

}

void customerDetail(string customerID)
{
	Customer printee = customerList.at(customerID);
	cout << endl;
	cout << "Name:    " << printee.firstName + " " + printee.lastName << endl;
	cout << "Phone:   " << printee.phone << endl;
	cout << "E-mail:  " << printee.email << endl;
	cout << "Address: " << printee.addr.toString();
}

//----------------------------------

// dataType specific control modules

void inventoryControl()
{
	string make = "";
	string model = "";
	string VIN = "";
	string color = "";
	int year = 0;
	double price = 0;

	int menu = 0;
	do
	{
		cout << endl;
		printSubMenu("Inventory");
		menu = inputInt();
		switch (menu)
		{
		case 1:
		{
			// printInventory();
			inventoryDetail(getInventory());
			break;
		}
		case 2:
		{
			// gets input for new vehicle

			cout << "Enter Make: ";
			cin.ignore();
			getline(cin, make);
			cout << "Enter Model: ";
			getline(cin, model);
			cout << "Enter color: ";
			getline(cin, color);
			cout << "Enter year: ";
			
			// gets a year in the range of 1850 to 2021. Future implementation would include a current model year lookup
			do
			{
				year = inputInt();
				if (year < 1850 || year > yearLimit)
				{
					cout << "Year out of range. Did you make a mistake? Please enter the correct year.";
				}
			} while (!inRange(1850, yearLimit, year));


			cin.ignore();
			cout << "Enter VIN: ";
			getline(cin, VIN);
			cout << "Enter sticker price: ";

			do // gets a price between $0 and $10,000,000
			{
				price = inputDouble();
				if (!inRange(0, 10000000, price))
				{
					cout << "Price is invalid. Please enter a price between $0 and $10,000,000" << endl;
				}
			} while (!inRange(0, 10000000, price));
			cin.ignore();

			// sets ID to current seconds, ensuring unique IDs
			string inventoryID = to_string(time(0));

			// adds new vehicle to inventoryList
			Inventory newItem(make, model, year, VIN, color, true, price);
			inventoryList.emplace(inventoryID, newItem);
			cout << "Vehicle " << inventoryID << " added.";
			break;
		}
		case 3:
		{
			cout << "\nInventory Edit" << endl;
			Inventory toEdit;
			string inventoryID = getInventory();

			toEdit = inventoryList.at(inventoryID);
			int choice = 0;

			

			while (!inRange(1, 7, choice)) // menu to choose field to edit, where each field is its own case. inventoryList is only updated upon menu exit
			{
				cout << "Select field to edit" << endl;
				cout << "1) Make \n2) Model \n3) Year \n4) Color \n5) sticker Price \n6) Availability \n7) Exit \n--> ";
				
				choice = inputInt();
				switch (choice)
				{
				case 1:
				{
					cout << "Enter corrected make: ";
					cin.ignore();
					getline(cin, make);
					toEdit.make = make;
					choice = 0;
					break;
				}
				case 2:
				{
					cout << "Enter corrected model: ";
					cin.ignore();
					getline(cin, model);
					toEdit.model = model;
					choice = 0;
					break;
				}
				case 3:
				{
					cout << "Enter corrected year: ";
					
					do
					{
						toEdit.year = inputInt();
						if (!inRange(0, yearLimit, toEdit.year))
						{
							cout << "Year entered is out of acceptable range. Please enter a number between 1900 and " << yearLimit << endl;
						}
					} while (!inRange(0, yearLimit, toEdit.year));

					choice = 0;
					break;
				}
				case 4:
				{
					cout << "Enter corrected color: ";
					cin.ignore();
					getline(cin, color);
					toEdit.color = color;
					choice = 0;
					break;
				}
				case 5:
				{
					cout << "Enter new sticker price: ";
					
					do
					{
						toEdit.price = inputDouble();
						if (!inRange(0, 10000000, toEdit.price))
						{
							cout << "New price is invalid. Please enter a price between $0 and $10,000,000" << endl;
						}
					} while (!inRange(0, 10000000, toEdit.price));
					choice = 0;
					break;
				}
				case 6:
				{
					cout << "Select availability \n1) Available \n2) Unavailable \n--> ";
					
					int availChoice = inputInt();
					switch (availChoice)
					{
					case 1:
					{
						toEdit.available = true;
						choice = 0;
						break;
					}
					case 2:
					{
						toEdit.available = false;
						choice = 0;
						break;
					}
					default:
					{
						cout << "Invalid selection. Returning to menu." << endl;
					}
					}
					break;
				}
				case 7:
				{
					if (toEdit == inventoryList.at(inventoryID))
					{
						cout << "No changes made. Returning..." << endl;
					}
					else
					{
						cout << "Saving changes to vehical..." << endl;
						inventoryList[inventoryID] = toEdit;
					}
					break;
				}
				default:
				{
					break;
				}
				}
			}

			
			break;
		}
		case 4:
		{
			cout << "Inventory Deletion" << endl;
			string inventoryID = getInventory(); // gets item to delete
			int choice = 0;
			cout << "Confirm delete of " << inventoryList.at(inventoryID).make << " " << inventoryList.at(inventoryID).model << "?" << endl; // confirms deletion
			cout << "1) Yes \n2) No \n--> ";
			cin.ignore();
			while (!inRange(1, 2, choice))
			{
				choice = inputInt();
				if (choice == 1)
				{
					cout << "Deleting inventory..." << endl;
					inventoryList.erase(inventoryList.find(inventoryID));

				}
				if (choice == 2)
				{
					cout << "Returning to inventory menu" << endl;
				}
			}

			
			break;
		}
		case 5:
		{
			cout << "Returning to main menu...\n" << endl;
			break;
		}
		default:
		{
			cout << "Invalid menu selection." << endl;
			break;
		}
		}

	} while (menu != 5);
}

void customerControl()
{
	int menu = 0;
	do
	{
		cout << endl;
		printSubMenu("Customer");
		menu = inputInt();
		switch (menu)
		{
			case 1:
			{
				customerDetail(getCustomer());
				break;
			}
			case 2:
			{
				string firstName = "";
				string lastName = "";
				string phone = "";
				string email = "";
				string street1;
				string street2;
				string city;
				string state;
				string zip;
				cout << "Enter Last Name: ";
				cin.ignore();
				getline(cin, lastName);
				cout << "Enter First Name: ";
				getline(cin, firstName);
				cout << "Enter phone: ";
				getline(cin, phone);
				cout << "Enter email: ";
				getline(cin, email);
				cout << "Enter street address, line 1: ";
				getline(cin, street1);
				cout << "Enter street address, line 2: ";
				getline(cin, street2);
				cout << "Enter city: ";
				getline(cin, city);
				cout << "Enter state: ";
				getline(cin, state);
				cout << "Enter ZIP code: ";
				getline(cin, zip);

			

				string customerID = to_string(time(0));
				Address newAddr(street1, street2, city, state, zip);
				Customer newItem(firstName, lastName, newAddr, phone, email);
				customerList.emplace(customerID, newItem);
				cout << "Customer " << customerID << " added.";

				break;
			}
			case 3:
			{
				cout << "\nCustomer Edit" << endl;
				Customer toEdit;
				string customerID = getCustomer();
					
				toEdit = customerList.at(customerID);
				int choice = 0;



				while (!inRange(1, 7, choice)) // menu to choose field to edit, where each field is its own case. customerList is only updated upon menu exit
				{
					cout << "Select field to edit" << endl;
					cout << "1) Name \n2) Street Address \n3) City \n4) State \n5) ZIP code \n6) Contact Information \n7) Exit \n--> ";

					choice = inputInt();
					switch (choice)
					{
					case 1:
					{
						cout << "Enter first name: ";
						cin.ignore();
						getline(cin, toEdit.firstName);

						cout << "Enter last name: ";
						cin.ignore();
						getline(cin, toEdit.lastName);

						choice = 0;
						break;
					}
					case 2:
					{
						cout << "Enter street address line 1: ";
						cin.ignore();
						getline(cin, toEdit.addr.street1);

						cout << "Enter street address line 2: ";
						cin.ignore();
						getline(cin, toEdit.addr.street2);

						choice = 0;
						break;
					}
					case 3:
					{
						cout << "Enter new city: ";
						cin.ignore();
						getline(cin, toEdit.addr.city);

						choice = 0;
						break;
					}
					case 4:
					{
						cout << "Enter new state: ";
						cin.ignore();
						getline(cin, toEdit.addr.state);

						choice = 0;
						break;
					}
					case 5:
					{
						cout << "Enter new ZIP code: ";
						cin.ignore();
						getline(cin, toEdit.addr.zip);

						choice = 0;
						break;
					}
					case 6:
					{
						cout << "Enter new phone: ";
						cin.ignore();
						getline(cin, toEdit.phone);

						cout << "Enter new e-mail: ";
						cin.ignore();
						getline(cin, toEdit.email);

						choice = 0;
						break;
					}
					case 7:
					{
						if (toEdit == customerList.at(customerID))
						{
							cout << "No changes made. Returning..." << endl;
						}
						else
						{
							cout << "Saving changes to vehciel..." << endl;
							customerList[customerID] = toEdit;
						}
					break;
					}
					default:
					{
						break;
					}
				}
			}
			break;
		}
		case 4:
		{
			int choice = -1;
			int count = 0;
			string customerID = "";

			cout << "Select customer to delete: " << endl;
			printCustomers();
			cout << (customerList.size() + 1) << ") Exit \n--> ";
			while (!inRange(1, (customerList.size() + 1), choice))
			{
				choice = inputInt();
				if (choice == customerList.size() + 1)
				{
					cout << "Returning to main menu..." << endl;
					break;
				}
				if (!inRange(1, customerList.size() + 1, choice))
				{
					cout << "Not a valid selection." << endl;
				}
			}

			for (pair<string, Customer> c : customerList)
			{
				count++;
				if (count == choice)
				{
					customerID = c.first;
					break;
				}
			}
			choice = 0;
			cout << "Confirm delete of " << customerList.at(customerID).firstName << " " << customerList.at(customerID).lastName << "?" << endl;
			cout << "1) Yes \n2) No \n--> ";
			cin.ignore();
			while (!inRange(1, 2, choice))
			{
				choice = inputInt();
				if (choice == 1)
				{
					cout << "Deleting customer..." << endl;
					customerList.erase(customerList.find(customerID));

				}
				if (choice == 2)
				{
					cout << "Returning to customer menu" << endl;
				}
			}

			
			break;
		}
		case 5:
		{
			cout << "Returning to main menu...\n" << endl;
			break;
		}
		default:
		{
			cout << "Invalid menu selection." << endl;
			break;
		}
		}

	} while (menu != 5);
}

void leadControl()
{

	int menu = 0;
	do
	{
		cout << endl;
		printSubMenu("Lead");
		cin.ignore();
		menu = inputInt();
		switch (menu)
		{
			case 1:
			{
				cout << tempMap.at(hotList.top().temp) << "--" << customerList.at(hotList.top().associatedCustomer).firstName << " " << customerList.at(hotList.top().associatedCustomer).lastName << " "
					<< customerList.at(hotList.top().associatedCustomer).phone << endl;
				break;
			}
			case 2:
			{
				string buyerID = "";
				priority temp = HOT;
				double maxPrice = 0;
				int choice = -1;
				int count = 0;
					
				cout << "Select customer: " << endl;
				buyerID = getCustomer();

				cout << "Select priority level: \n1) Hot \n2) Warm \n3) Cold \n4) Dead \n5) Exit \n-->";
				while (!inRange(1, 5, choice))
				{
					//cin.ignore();
					choice = inputInt();
					if (choice == 5)
					{
						cout << "Returning to main menu..." << endl;
						break;
					}
					switch (choice)
					{
					case 1:
					{
						temp = HOT;
						break;
					}
					case 2:
					{
						temp = WARM;
						break;
					}
					case 3:
					{
						temp = COLD;
						break;
					}
					case 4:
					{
						temp = DEAD;
						break;
					}
					default:
					{
						cout << "Invalid selection." << endl;
					}
					}
					if (!inRange(1, 5, choice))
					{
						cout << "Not a valid selection." << endl;
					}
				}


				do
				{
					cout << "Enter max price: $";
					maxPrice = inputDouble();
					if (!inRange(0, 10000000, maxPrice))
					{
						cout << "Max price is invalid. Please enter a price between $0 and $10,000,000" << endl;
					}
				} while (!inRange(0, 10000000, maxPrice));



				string leadID = to_string(time(0));

				Lead newItem(buyerID, maxPrice, temp);
				leadList.emplace(leadID, newItem);
				cout << "Lead " << leadID << " added.";
				break;
			}
			case 3:
			{
				cout << "\nLead Edit" << endl;
				Lead toEdit;
				string leadID = getLead();
					
				toEdit = leadList.at(leadID);
				int choice = 0;
				while (!inRange(1, 3, choice))
				{
					cout << "Select field to edit" << endl;
					cout << "1) Max Price \n2) Temperature \n3) Exit \n--> ";

					choice = inputInt();
					switch (choice)
					{
					case 1:
					{
						cout << "Enter new max price: ";

						do
						{
							toEdit.maxPrice = inputDouble();
							if (!inRange(0, 10000000, toEdit.maxPrice))
							{
								cout << "New price is invalid. Please enter a price between $0 and $10,000,000" << endl;
							}
						} while (!inRange(0, 10000000, toEdit.maxPrice));
						choice = 0;
						break;
					}
					case 2:
					{
						cout << "Select lead temperature \n1) Hot \n2) Warm \nCold \nDead \n--> ";

						int availChoice = inputInt();
						switch (availChoice)
						{
						case 1:
						{
							toEdit.temp = HOT;
							choice = 0;
							break;
						}
						case 2:
						{
							toEdit.temp = WARM;
							choice = 0;
							break;
						}
						case 3:
						{
							toEdit.temp = COLD;
							choice = 0;
							break;
						}
						case 4:
						{
							toEdit.temp = DEAD;
							choice = 0;
							break;
						}
						default:
						{
							cout << "Invalid selection. Returning to menu." << endl;
						}
						}
						break;
					}

					case 3:
					{
						if (toEdit == leadList.at(leadID))
						{
							cout << "No changes made. Returning..." << endl;
						}
						else
						{
							cout << "Saving changes to vehciel..." << endl;
							leadList[leadID] = toEdit;
						}
						break;
					}
					default:
					{
						cout << "Invalid selection" << endl;
					}
					}
				}
				loadHotList();
				break;
				}
				case 4:
				{
				int choice = -1;
				int count = 0;
				string leadID = "";

				cout << "Select lead to delete: " << endl;
				printLeads();
				cout << (leadList.size() + 1) << ") Exit \n--> ";
				while (!inRange(1, (leadList.size() + 1), choice))
				{
					choice = inputInt();
					if (choice == leadList.size() + 1)
					{
						cout << "Returning to main menu..." << endl;
						break;
					}
					if (!inRange(1, leadList.size() + 1, choice))
					{
						cout << "Not a valid selection." << endl;
					}
				}
					
				for	(pair<string, Lead> l : leadList)
				{
					count++;
					if (count == choice)
					{
						leadID = l.first;
						break;
					}
				}
				choice = 0;
				cout << "Confirm delete of " << leadID << "?" << endl;
				cout << "1) Yes \n2) No \n--> ";
				cin.ignore();
				while (!inRange(1, 2, choice))
				{
					choice = inputInt();
					if (choice == 1)
					{
						cout << "Deleting lead..." << endl;
						leadList.erase(leadList.find(leadID));
							
					}
					if (choice == 2)
					{
						cout << "Returning to lead menu" << endl;
					}
				}
				loadHotList();
				break;
				}

				case 5:
				{
				cout << "Returning to main menu...\n" << endl;
				break;
				}
				default:
				{
				cout << "Invalid menu selection." << endl;
				break;
				}
			
		}
	}while (menu != 5);
}

void SOControl()
{
	int menu = 0;
	do
	{
		printSubMenu("Sales Order");
		menu = inputInt();
		switch (menu)
		{
		case 1:
		{
			printSalesOrders();
			break;
		}
		case 2:
		{
			string buyerID = "";
			string vehicleID = "";
			double salePrice = -10;
			int choice = -1;
			int count = 0;

			cout << "Select customer: " << endl;
			buyerID = getCustomer();

			cout << "Select vehicle from available inventory: " << endl;
			availableInventory();
			cin.ignore();
			cout << (inventoryList.size() + 1) << ") Exit \n--> ";
			while (!inRange(1, inventoryList.size() + 1, choice))
			{
				choice = inputInt();
				if (choice == inventoryList.size() + 1)
				{
					cout << "Returning to main menu..." << endl;
					break;
				}
				if (!inRange(1, inventoryList.size() + 1, choice))
				{
					cout << "Not a valid selection." << endl;
				}
			}

			for (pair<string, Inventory> v : inventoryList)
			{
				count++;
				if (count == choice)
				{
					vehicleID = v.first;
				}
			}

			cin.ignore();
			cout << "Enter final price: ";
			while (!inRange(0, 10000000, salePrice))
			{
				salePrice = inputDouble();
				
				if (!inRange(0,10000000,salePrice))
				{
					cout << "Not a valid entry." << endl;
				}
			}
			


			string SOID = to_string(time(0));

			SalesOrder newItem(buyerID,salePrice,vehicleID);
			inventoryList[vehicleID].available = false;
			SOList.emplace(SOID, newItem);
			cout << "Sales order " << SOID << " added.";
			break;
		}
		case 3:
		{
			int choice = -1;
			int count = 0;
			string SOID = "";

			cout << "Select sales order to delete: " << endl;
			printSalesOrders();
			cout << (SOList.size() + 1) << ") Exit \n--> ";
			while (!inRange(1, (SOList.size() + 1), choice))
			{
				choice = inputInt();
				if (choice == SOList.size() + 1)
				{
					cout << "Returning to main menu..." << endl;
					break;
				}
				if (!inRange(1, SOList.size() + 1, choice))
				{
					cout << "Not a valid selection." << endl;
				}
			}

			for (pair<string, SalesOrder> s : SOList)
			{
				count++;
				if (count == choice)
				{
					SOID = s.first;
					break;
				}
			}
			choice = 0;
			cout << "Confirm delete of Sales Order for " << customerList.at(SOList.at(SOID).buyerID).firstName << " " << customerList.at(SOList.at(SOID).buyerID).lastName << "?" << endl;
			cout << "1) Yes \n2) No \n--> ";
			cin.ignore();
			while (!inRange(1, 2, choice))
			{
				choice = inputInt();
				if (choice == 1)
				{
					cout << "Deleting sales order..." << endl;
					SOList.erase(SOList.find(SOID));

				}
				if (choice == 2)
				{
					cout << "Returning to sales order menu" << endl;
				}
			}
			break;
		}
		
		case 4:
		{
			cout << "Returning to main menu...\n" << endl;
			break;
		}
		default:
		{
			cout << "Invalid menu selection." << endl;
			break;
		}
		}

	} while (menu != 4);
}

// -----------------------------------

// file Input/Output

void saveAllLists()
{
	Inventory::saveInventory(inventoryList, "inventoryList.txt");
	Customer::saveCustomers(customerList, "customerList.txt");
	Lead::saveLeads(leadList, "leadList.txt");
	SalesOrder::saveSalesOrders(SOList, "salesOrderList.txt");
}

void loadAllLists()
{
	Inventory::loadInventory("inventoryList.txt");
	Customer::loadCustomers("customerList.txt");
	Lead::loadLeads("leadList.txt");
	SalesOrder::loadSalesOrders("salesOrderList.txt");
	loadHotList();
	
}

void loadHotList()
{
	hotList = priority_queue<Lead>();
	for (pair<string, Lead> l : leadList)
	{
		
		hotList.push(l.second);
	}
}

//--------------------------------------

// list print functions-----------------------

void printCustomers()
{
	int lineNum = 0;
	cout << "\n" << endl;
	for (pair<string, Customer> c : customerList)
	{
		lineNum++;
		cout << lineNum << ") " << c.second.firstName << " " << c.second.lastName << endl;
	}
}

void printInventory()
{
	int lineNum = 0;
	cout << "\n" << endl;
	for (pair<string, Inventory> v : inventoryList)
	{
		lineNum++;
		cout << lineNum << ") " << v.second.make << " " << v.second.model << " $" << v.second.price << endl;
	}
}

void printLeads()
{
	int lineNum = 0;
	cout << "\n" << endl;
	for (pair<string, Lead> l : leadList)
	{
		lineNum++;
		cout << lineNum << ") " << customerList.at(l.second.associatedCustomer).firstName << " " << 
								customerList.at(l.second.associatedCustomer).lastName << ", under $" << l.second.maxPrice << endl << " " << tempMap.at(l.second.temp);
	}
}

void printSalesOrders()
{
	int lineNum = 0;
	cout << "\n" << endl;
	for (pair<string, SalesOrder> so : SOList)
	{
		lineNum++;
		cout << lineNum << ") " << customerList.at(so.second.buyerID).firstName << " " << customerList.at(so.second.buyerID).lastName <<
								inventoryList.at(so.second.vehicleID).make << " " << inventoryList.at(so.second.vehicleID).model << " $" << 
								inventoryList.at(so.second.vehicleID).price << endl;
	}
}

void availableInventory()
{
	int lineNum = 0;
	cout << "\n" << endl;
	for (pair<string, Inventory> v : inventoryList)
	{
		if (v.second.available == true)
		{
			lineNum++;
			cout << lineNum << ") " << v.second.make << " " << v.second.model << " $" << v.second.price << endl;
		}
	}
}


//---------------------------------------

// methods to have user select an item and return the ID

string getInventory()
{
	int choice = -1;
	int count = 0;
	string inventoryID = "";
	

	cout << "Select vehicle: " << endl;
	printInventory();
	cout << (inventoryList.size() + 1) << ") Exit \n--> ";
	while (!inRange(1, (inventoryList.size() + 1), choice))
	{
		choice = inputInt();
		if (choice == inventoryList.size() + 1)
		{
			cout << "Returning to main menu..." << endl;
			break;
		}
		if (!inRange(1, inventoryList.size() + 1, choice))
		{
			cout << "Not a valid selection." << endl;
		}
	}

	for (pair<string, Inventory> v : inventoryList)
	{
		count++;
		if (count == choice)
		{
			inventoryID = v.first;
			break;
		}
	}

	return inventoryID;
}

string getCustomer()
{
	int choice = -1;
	int count = 0;
	string customerID = "";


	cout << "Select customer: " << endl;
	printCustomers();
	cout << (customerList.size() + 1) << ") Exit \n--> ";
	while (!inRange(1, (customerList.size() + 1), choice))
	{
		choice = inputInt();
		if (choice == customerList.size() + 1)
		{
			cout << "Returning to main menu..." << endl;
			break;
		}
		if (!inRange(1, customerList.size() + 1, choice))
		{
			cout << "Not a valid selection." << endl;
		}
	}

	for (pair<string, Customer> v : customerList)
	{
		count++;
		if (count == choice)
		{
			customerID = v.first;
			break;
		}
	}

	return customerID;
}

string getLead()
{
	int choice = -1;
	int count = 0;
	string leadID = "";


	cout << "Select lead: " << endl;
	printLeads();
	cout << (leadList.size() + 1) << ") Exit \n--> ";
	while (!inRange(1, (leadList.size() + 1), choice))
	{
		choice = inputInt();
		if (choice == leadList.size() + 1)
		{
			cout << "Returning to main menu..." << endl;
			break;
		}
		if (!inRange(1, leadList.size() + 1, choice))
		{
			cout << "Not a valid selection." << endl;
		}
	}

	for (pair<string, Lead> l : leadList)
	{
		count++;
		if (count == choice)
		{
			leadID = l.first;
			break;
		}
	}

	return leadID;
	
}

string getSO()
{
	int choice = -1;
	int count = 0;
	string SOID = "";


	cout << "Select SO: " << endl;
	printSalesOrders();
	cout << (SOList.size() + 1) << ") Exit \n--> ";
	while (!inRange(1, (SOList.size() + 1), choice))
	{
		choice = inputInt();
		if (choice == SOList.size() + 1)
		{
			cout << "Returning to main menu..." << endl;
			break;
		}
		if (!inRange(1, SOList.size() + 1, choice))
		{
			cout << "Not a valid selection." << endl;
		}
	}

	for (pair<string, SalesOrder> so : SOList)
	{
		count++;
		if (count == choice)
		{
			SOID = so.first;
			break;
		}
	}

	return SOID;
}

//--------------------------------------------------------