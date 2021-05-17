using System;
using System.Collections.Generic;

namespace DictionaryAndSortedDictionary.Entities
{
    static class Example
    {
        public static void ShowExample()
        {
            Dictionary<string, string> cookie = new Dictionary<string, string>();

            cookie["user"] = "Maria";
            cookie["email"] = "maria@gmail.com";
            cookie["phone"] = "99999999";
            cookie["phone"] = "00000000"; //sobrepõe o valor anterior

            Console.WriteLine(cookie["email"]);
            cookie.Remove("email");

            if (cookie.ContainsKey("email"))
                Console.WriteLine(cookie["email"]);
            else
                Console.WriteLine("Error");

            Console.WriteLine($"Size: {cookie.Count}");

            foreach (KeyValuePair<string, string> item in cookie) //ou foreach (var item in cookie)
            {
                Console.WriteLine($"{item.Key}: {item.Value} ");
            }

        }
    }
}
