﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PredictPrice.Operatons
{
    class UserInterface
    {
        public static string ControlUserInput()
        {
            bool isValid = false;
            ConsoleKeyInfo firstInput;
            string[] validInputs = { "1", "2", "3", "4", "5" };
            do
            {
                firstInput = Console.ReadKey(true);
                foreach (var item in validInputs)
                {
                    if (item.ToLower() == firstInput.KeyChar.ToString().ToLower())
                    {
                        isValid = true;
                    }
                }
            } while (isValid == false);
            string finalInput = firstInput.KeyChar.ToString();
            Console.WriteLine(finalInput);
            return finalInput;
        }

    }
}