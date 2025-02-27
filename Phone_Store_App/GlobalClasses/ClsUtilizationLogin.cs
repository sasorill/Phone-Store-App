﻿using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public class ClsUtilizationLogin
	{
		public static ClsPeople Person;

		public static ClsUsers Users;

		public static string HashingPasswordToSHA1(string Value)
		{
			using (SHA256 sha1 = SHA256.Create())
			{
				byte[] HashByte = sha1.ComputeHash(Encoding.UTF8.GetBytes(Value));
				return BitConverter.ToString(HashByte).Replace("-", "").ToLower();
			}
		}

		public static bool RememberUsernameAndPassword(string Username, string Password)
		{

			try
			{
				//this will get the current project directory folder.
				string currentDirectory = System.IO.Directory.GetCurrentDirectory();


				// Define the path to the text file where you want to save the data
				string filePath = currentDirectory + "\\data.txt";

				//incase the username is empty, delete the file
				if (Username == "" && File.Exists(filePath))
				{
					File.Delete(filePath);
					return true;

				}

				// concatonate username and passwrod withe seperator.
				string dataToSave = Username + "#//#" + Password;

				// Create a StreamWriter to write to the file
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					// Write the data to the file
					writer.WriteLine(dataToSave);

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool GetStoredCredential(ref string Username, ref string Password)
		{
			//this will get the stored username and password and will return true if found and false if not found.
			try
			{
				//gets the current project's directory
				string currentDirectory = System.IO.Directory.GetCurrentDirectory();

				// Path for the file that contains the credential.
				string filePath = currentDirectory + "\\data.txt";

				// Check if the file exists before attempting to read it
				if (File.Exists(filePath))
				{
					// Create a StreamReader to read from the file
					using (StreamReader reader = new StreamReader(filePath))
					{
						// Read data line by line until the end of the file
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							Console.WriteLine(line); // Output each line of data to the console
							string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

							Username = result[0];
							Password = result[1];
						}
						return true;
					}
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool RememberEmailAndPassword(string Username, string Password)
		{

			try
			{
				//this will get the current project directory folder.
				string currentDirectory = System.IO.Directory.GetCurrentDirectory();


				// Define the path to the text file where you want to save the data
				string filePath = currentDirectory + "\\PersonLoginData.txt";

				//incase the username is empty, delete the file
				if (Username == "" && File.Exists(filePath))
				{
					File.Delete(filePath);
					return true;

				}

				// concatonate username and passwrod withe seperator.
				string dataToSave = Username + "#//#" + Password;

				// Create a StreamWriter to write to the file
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					// Write the data to the file
					writer.WriteLine(dataToSave);

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool GetStoredCredentialEmail(ref string Username, ref string Password)
		{
			//this will get the stored username and password and will return true if found and false if not found.
			try
			{
				//gets the current project's directory
				string currentDirectory = System.IO.Directory.GetCurrentDirectory();

				// Path for the file that contains the credential.
				string filePath = currentDirectory + "\\PersonLoginData.txt";

				// Check if the file exists before attempting to read it
				if (File.Exists(filePath))
				{
					// Create a StreamReader to read from the file
					using (StreamReader reader = new StreamReader(filePath))
					{
						// Read data line by line until the end of the file
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							Console.WriteLine(line); // Output each line of data to the console
							string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

							Username = result[0];
							Password = result[1];
						}
						return true;
					}
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool ValidateCardNumber(string CardNumber)
		{
			int Sum = 0;
			bool AlterNate = false;
			for (int i = CardNumber.Length - 1; i >= 0; i--)  
			{
				int n = int.Parse(CardNumber[i].ToString());
				if(AlterNate)
				{
					n *= 2;
					if (n > 9) 
					{
						n -= 9;
					}
				}
				Sum += n;
				AlterNate = !AlterNate;
			}
			return (Sum % 10 == 0);
		}
	}
}
