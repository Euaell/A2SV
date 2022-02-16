public class Solution {
    public string DecodeString(string s) {
        string x = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    string inp = "";
                    while (s[i] != '[')
                    {
                        inp = inp.Insert(inp.Length, s[i].ToString());
                        i++;
                    }
                    i++;
                    int cou = 0;
                    int pass = 0;
                    for (int j = i; j < s.Length; j++)
                    {
                        if (s[j] == '[')
                            cou--;
                        else if (s[j] == ']')
                            cou++;
                        if (cou > 0 || j == s.Length - 1)
                            break;

                        pass++;
                    }
                    string temp = String.Concat(Enumerable.Repeat(DecodeString(s.Substring(i, pass)), Int32.Parse(inp)));
                    i += pass;
                    x = x.Insert(x.Length, temp);
                } 
                else if (Char.IsLetter(s[i]))
                    x = x.Insert(x.Length, s[i].ToString());
            }
            
            return x;
    }
}
