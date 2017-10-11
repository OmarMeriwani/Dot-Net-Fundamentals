using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s)
    {
        char[] arr = s.ToCharArray(); //n
        string ss = s;
        int i= 1;
        int lenn = arr.Length;
        while (i < ss.Length)
        {
            //Console.WriteLine(i + "- " + ss[i] + "," + ss[i - 1]);
            if (ss[i] == ss[i - 1])
            {
                string dup = String.Concat( ss[i] , ss[i]);
                //Console.WriteLine(dup);
                ss = ss.Replace(dup,"");
                i = 1;
                continue;
            }
                i ++;
        }
        if (ss == "" || ss == " ")
            ss = "Empty String";
        return ss;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
