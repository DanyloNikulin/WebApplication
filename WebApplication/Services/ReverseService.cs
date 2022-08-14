using System;

namespace WebApplication.Services {
	public class ReverseService : IReverseService{
		public string Do(string data ){
			string result;
			if (int.TryParse(data, out var value)) {
				result = Math.Sqrt(value).ToString();
			} else {
				char[] charArray = data.ToCharArray();
				Array.Reverse(charArray);
				result = new string(charArray);
			}
			return result;
		}
	}
		
}
