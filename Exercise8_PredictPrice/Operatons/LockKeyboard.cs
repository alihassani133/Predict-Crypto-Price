namespace Exercise8_PredictPrice.Operatons
{
    class LockKeyboard
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
