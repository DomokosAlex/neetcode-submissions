public class Solution {

    public string Encode(IList<string> strs) {
         
           
            string returnable = "";


            foreach(string s in strs)
            {

                returnable += $"{s.Length}#{s}";
            }

            return returnable;

    }

 public List<string> Decode(string s)
 {


     int counter = -1;
     int step = 0;
     string tempst = "";
     bool reader = false;
     List<string> returnable = new List<string>();


     while (step < s.Length)
     {
         if (counter == 0)
         {
             reader = false;
             returnable.Add(tempst);
             tempst = "";
             counter = -1;
             continue;
         }

         if (reader)
         {
             tempst += s[step];
             counter--;
             step++;
             continue;
             
             
         }

         if (s[step] == '#' && !reader)
         {
             counter = int.Parse(tempst);
             tempst = "";
             reader = true;
             step++;
             continue;
         }
         
         tempst += s[step];
         step++;

         
     }
if (reader && counter == 0)
{
    returnable.Add(tempst);
}
     return returnable;
 
 
 
 }
}