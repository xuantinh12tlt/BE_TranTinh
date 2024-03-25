namespace SharedLibrary
{
    public class SharedLibrary
    {
        /// <summary>
        /// Checks if the input string is an integer
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckIsInt(string s)
        {
            int Number;

            if(int.TryParse(s, out Number))
            {
                if (Number > int.MaxValue)
                    return false;
                return true;
            }
            return false;

        }
    }
}