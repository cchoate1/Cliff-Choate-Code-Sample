#pragma once


#include <iostream>
#include <string>
#include <map>
#include <ctime>
#include <fstream>
#include "PriorityQueueList.h"
#include <queue>



class Lead;
class Inventory;
class Customer;
class SalesOrder;

static map<string, Lead> leadList;
static map<string, Inventory> inventoryList;
static map<string, Customer> customerList;
static map<string, SalesOrder> SOList;
priority_queue<Lead> hotList;




// utility and component data types

struct Address
{
	string street1;
	string street2;
	string city;
	string state;
	string zip;

	Address()
	{

	}

	Address(string street1, string street2, string city, string state, string zip)
	{
		this->street1 = street1;
		this->street2 = street2;
		this->city = city;
		this->state = state;
		this->zip = zip;
	}

	string toString()
	{
		string output = "";

		output = (street1 + "\n\t  " + street2 + "\n\t  " + city + ", " + state + "  " + zip + "\n");

		return output;
	}
	
	bool operator ==(Address other)
	{
		if (this->street1 == other.street1 && this->street2 == other.street2 &&
			this->city == other.city && this->state == other.state && this->zip == other.zip)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
};

enum priority{HOT=4,WARM=3,COLD=2,DEAD=1};
static map<priority, string> tempMap{ {HOT,"HOT"} , {WARM,"WARM"},{COLD,"COLD"},{DEAD,"DEAD"} };

// data type definitions

class Inventory
{
public:
	string make;
	string model;
	int year;
	string VIN;
	string color;
	double price;
	bool available;

	Inventory(string make, string model, int year, string VIN, string color, bool available, double price)
	{
		this->make = make;
		this->model = model;
		this->year = year;
		this->VIN = VIN;
		this->color = color;
		this->price = price;
		this->available = available;
	}

	Inventory()
	{
		 
	}

	/*Inventory(Inventory& toCopy)   copy constructor, not needed
	{
		this->make = toCopy.make;
		this->model = toCopy.model;
		this->year = toCopy.year;
		this->VIN = toCopy.VIN;
		this->color = toCopy.color;
		this->price = toCopy.price;
		this->available = toCopy.available;
	}*/
	
	bool operator==(Inventory other)
	{
		if (this->make == other.make && this->model == other.model &&
			this->year == other.year && this->VIN == other.VIN && this->color == other.color &&
			this->price == other.price && this->available == other.available)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	static void loadInventory(string filename)
	{
		
			map<string, Inventory> outputMap;
			ifstream inData;
			string input = "";

			string ID;
			string make = "";
			string model = "";
			int year;
			string VIN;
			string color;
			double price;
			bool available;

			inData.open(filename);

			while (!inData.eof())
			{
				getline(inData, input);
				if (input != "")
				{
					ID = input.substr(0, input.find_first_of('|'));
					input.erase(0, input.find_first_of('|') + 1);
					make = input.substr(0, input.find_first_of('|'));
					input.erase(0, input.find_first_of('|') + 1);
					model = input.substr(0, input.find_first_of('|'));
					input.erase(0, input.find_first_of('|') + 1);
					year = stoi(input.substr(0, input.find_first_of('|')));
					input.erase(0, input.find_first_of('|') + 1);
					VIN = input.substr(0, input.find_first_of('|'));
					input.erase(0, input.find_first_of('|') + 1);
					color = input.substr(0, input.find_first_of('|'));
					input.erase(0, input.find_first_of('|') + 1);
					available = stoi(input.substr(0, input.find_first_of('|')));
					input.erase(0, input.find_first_of('|') + 1);
					price = stod(input);
					Inventory loadItem(make, model, year, VIN, color, available,price);

					//outputMap.emplace(ID, loadItem);
					inventoryList.emplace(ID, loadItem);
				}
			}

			inData.close();
			//return outputMap;
		
	}

	string sGetYear()
	{
		string sYear = "";
		sYear = to_string(this->year);
		return sYear;
	}

	string sGetPrice()
	{
		string sPrice = "";
		sPrice = to_string(this->price);
		return sPrice;
	}

	string getAvail()
	{
		if (available == true)
		{
			return "1";
		}
		else
		{
			return "0";
		}
	}

	string saveString()
	{
		string output;
		output = (this->make + "|" + this->model + "|" + this->sGetYear() + "|" + this->VIN + "|" + this->color +"|"+ getAvail() + "|" + this->sGetPrice());
		return output;
	}

	static void saveInventory(map<string, Inventory> inventoryList, string filename)
	{
		ofstream outData;
		outData.open(filename);

		for (pair<string, Inventory> kvp : inventoryList)
		{
			outData << kvp.first + "|" + kvp.second.saveString() << endl;
		}
		outData.close();
	}

};

class Customer
{
	public:
		string firstName;
		string lastName;
		Address addr;
		string phone;
		string email;

	Customer(string firstName, string lastName, Address addr, string phone, string email)
	{
		this->firstName = firstName;
		this->lastName = lastName;
		this->addr = addr;
		this->phone = phone;
		this->email = email;
	}

	Customer()
	{

	}
	
	bool operator==(Customer other)
	{
		if (this->firstName == other.firstName && this->lastName == other.lastName &&
			this->addr == other.addr && this->phone == other.phone && this->email == other.email)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	string saveString()
	{
		string output;
		output = (this->firstName + "|" + this->lastName + "|" + this->addr.street1 + "|" + this->addr.street2 + "|" + 
				this->addr.city + "|" + this->addr.state + "|" + this->addr.zip + "|" + this->phone + "|" + this->email);
		return output;
	}
	
	static void loadCustomers(string filename)
	{

		map<string, Customer> outputMap;
		ifstream inData;
		string input = "";
		string ID = "";
		string firstName = "";
		string lastName = "";
		string phone = "";
		string email = "";
		Address addr;

		inData.open(filename);

		while (!inData.eof())
		{
			getline(inData, input);
			if (input != "")
			{
				ID = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				firstName = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				lastName = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				addr.street1 = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				addr.street2 = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				addr.city = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				addr.state = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				addr.zip = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				phone = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				email = input;

				Customer loadItem(firstName, lastName, addr, phone, email);
				//outputMap.emplace(ID, loadItem);
				customerList.emplace(ID, loadItem);
			}
		}

		inData.close();
		//return outputMap;

	}

	static void saveCustomers(map<string, Customer> customerList, string filename)
	{
		ofstream outData;
		outData.open(filename);

		for (pair<string, Customer> kvp : customerList)
		{
			outData << kvp.first + "|" + kvp.second.saveString() << endl;
		}
		outData.close();
	}
};

class Lead
{
	public:
		string associatedCustomer;
		double maxPrice;
		priority temp;

	Lead()
	{

	}

	Lead(string customerID,double maxPrice, priority temp)
	{
		this->associatedCustomer = customerID;
		this->maxPrice = maxPrice;
		this->temp = temp;
	}

	bool operator==(Lead other)
	{
		if (this->associatedCustomer == other.associatedCustomer && this->maxPrice == other.maxPrice &&
			this->temp == other.temp)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	string saveString()
	{
		string output;
		output = (this->associatedCustomer + "|" + to_string(this->maxPrice) + "|" + tempMap.at(temp));
		return output;
	}

	static void saveLeads(map<string, Lead> leadList, string filename)
	{
		ofstream outData;
		outData.open(filename);

		for (pair<string, Lead> kvp : leadList)
		{
			outData << kvp.first + "|" + kvp.second.saveString() << endl;
		}
		outData.close();
	}

	

	static void loadLeads(string filename)
	{

		//map<string, Lead> outputMap;
		ifstream inData;
		string input = "";
		string ID;
		string associatedCustomer = "";
		double maxPrice = 0;
		priority temp;

		inData.open(filename);

		while (!inData.eof())
		{
			getline(inData, input);
			if (input != "")
			{
				ID = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				associatedCustomer = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				maxPrice = stod(input.substr(0, input.find_first_of('|')));
				input.erase(0, input.find_first_of('|') + 1);
				if (input == "HOT")
				{
					temp = HOT;
				}
				else if (input == "WARM")
				{
					temp = WARM;
				}
				else if (input == "COLD")
				{
					temp = COLD;
				}
				else
				{
					temp = DEAD;
				}

				Lead loadItem(associatedCustomer, maxPrice, temp);

				//outputMap.emplace(ID, new Lead(associatedCustomer, maxPrice, temp));
				leadList.emplace(ID, loadItem);
			}
		}

		inData.close();
		//return outputMap;

	}
};

class SalesOrder
{
	public:
		string vehicleID;
		string buyerID;
		double salePrice;
	
	SalesOrder(string customerID, double salePrice, string inventoryID)
	{
		this->vehicleID = inventoryID;
		this->buyerID = customerID;
		this->salePrice = salePrice;
	}

	SalesOrder()
	{

	}
	

	string saveString()
	{
		string output;
		output = (this->buyerID +  "|" + to_string(this->salePrice) + "|" + this->vehicleID);
		return output;
	}

	static void saveSalesOrders(map<string, SalesOrder> SOList, string filename)
	{
		ofstream outData;
		outData.open(filename);

		for (pair<string, SalesOrder> kvp : SOList)
		{
			outData << kvp.first + "|" + kvp.second.saveString() << endl;
		}
		outData.close();
	}

	static void loadSalesOrders(string filename)
	{

		//map<string, Lead> outputMap;
		ifstream inData;
		string input = "";
		string ID = "";
		string buyerID = "";
		double salePrice = 0;
		string vehicleID = "";

		inData.open(filename);

		while (!inData.eof())
		{
			getline(inData, input);
			if (input != "")
			{
				ID = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				buyerID = input.substr(0, input.find_first_of('|'));
				input.erase(0, input.find_first_of('|') + 1);
				salePrice = stod(input.substr(0, input.find_first_of('|')));
				input.erase(0, input.find_first_of('|') + 1);
				vehicleID = input;
				

				SalesOrder loadItem(buyerID, salePrice, vehicleID);

				//outputMap.emplace(ID, new Lead(associatedCustomer, maxPrice, temp));
				SOList.emplace(ID, loadItem);
			}
		}

		inData.close();
		//return outputMap;

	}
};

// lead priority comparison
bool operator<(const Lead& lhs, const Lead& rhs)
{
	return (lhs.temp < rhs.temp);
}




