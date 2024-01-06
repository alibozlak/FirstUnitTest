namespace Helpers
{
    public class StringHelper
    {
        //Gereksinimler : 
        //1. Girilen ifadenin başındaki ve sonundaki fazla boşluklar silinmelidir.
        //2. Girilen ifadenin içindeki fazla boşluklar silinmelidir.
        public static string FazlaBosluklariSil(string text)
        {
            text = text.Trim();
            string newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && text[i+1]== ' ')
                {
                    continue;
                }
                newText += text[i];
            }
            return newText;
        }
    }
}