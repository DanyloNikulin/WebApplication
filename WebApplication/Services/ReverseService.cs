using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Interface;
using WebApplication.Models;

namespace WebApplication.Services {
	public class ReverseService : IReverseService{
		public ActionResult<ReverseGetResponce> Do(string data){
			string result = String.Empty;
			if (!string.IsNullOrEmpty(data)) {
				if (int.TryParse(data, out var value)) {
					result = Math.Sqrt(value).ToString();
				} else {
					result = ReverseString(data);
				}
			}
			return new ReverseGetResponce() { Data = result };
		}
		protected string ReverseString(string data) {
			char[] charArray = data.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
		
}
