public class Solution {

    public string Encode(IList<string> strs) {
            string ret = "";
            foreach(string s in strs)
            {
                ret += $"{s.Length}#{s}";
            }
            return ret;
    }

 public List<string> Decode(string s)
 {

            List<string> returnable = new List<string>();
            if(s.Count() == 0)
            {
                return returnable;
            }
            bool reader = false;
            bool countreader = true;
            int amount = -1; 
            string actst = "";
            for (int i = 0; i < s.Length; i++)
            {
            
                if(!reader && s[i] == '#')
                {
                    amount = Convert.ToInt32(actst);
                    actst = "";
                    reader = true;
                    countreader = false;
                    continue;
                }

                if(reader && amount > 0)
                {
                    actst += s[i];
                    amount--;
                    continue;
                }

                if(amount == 0 && reader)
                {
                    reader = false;
                    countreader = true;
                    returnable.Add(actst);
                    actst = "";
                    
                }

                if (countreader)
                {
                    actst += s[i];
                    continue;
                }
            
            
            
            }

           
                returnable.Add(actst);
            
            return returnable;

 }
}