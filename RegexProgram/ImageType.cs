using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
	public class ImageType
	{
		public static void CheckImageType()
		{
			string pattren = "^*.(jpg|jpeg|png|gif|img)$";
			string[] input = { "photo.jpg", "car.jpeg", "doucument.txt", "bus.img", "file.exc","pic.gif" };
			Regex regex = new Regex(pattren);
			for(int i=0; i< input.Length; i++)
			{
                bool result = regex.IsMatch(input[i]);
				if(result == true)
				{
					Console.WriteLine("Valid");
				}
				else
				{
                    Console.WriteLine("Not Valid");
                }
            }
        }
	}
}

