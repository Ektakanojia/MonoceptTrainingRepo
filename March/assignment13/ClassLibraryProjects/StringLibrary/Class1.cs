namespace StringLibrary

{
    public static class Class1
    {
        public static bool StartWithUpper(this string ? str)
        {
            if(string.IsNullOrEmpty(str)) 
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
            
        }

    }
}