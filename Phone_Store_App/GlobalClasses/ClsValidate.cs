using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phone_Store_App
{
	public class ClsValidate
	{
		public static bool EmailValidate(string Email)
		{
			var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
			var regex = new Regex(pattern);
			return regex.IsMatch(Email);
		}

		public static string HashingPassword(string Password)
		{
			using (SHA256 sha1 = SHA256.Create())
			{
				byte[] HashByte = sha1.ComputeHash(Encoding.UTF8.GetBytes(Password));
				return BitConverter.ToString(HashByte).Replace("-", "").ToLower();
			}
		}
	}
}
