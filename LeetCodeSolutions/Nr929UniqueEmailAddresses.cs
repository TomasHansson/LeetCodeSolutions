using System.Collections.Generic;
using System.Linq;

/*
929. Unique Email Addresses
Every email consists of a local name and a domain name, separated by the @ sign.

For example, in alice@leetcode.com, alice is the local name, and leetcode.com is the domain name.

Besides lowercase letters, these emails may contain '.'s or '+'s.

If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name. 
For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)

If you add a plus ('+') in the local name, everything after the first plus sign will be ignored. This allows certain emails to be filtered, 
for example m.y+name@email.com will be forwarded to my@email.com.  (Again, this rule does not apply for domain names.)

It is possible to use both of these rules at the same time.

Given a list of emails, we send one email to each address in the list. 
How many different addresses actually receive mails? 
*/

namespace LeetCodeSolutions
{
    class Nr929UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> actualAdresses = new HashSet<string>();
            for (int i = 0; i < emails.Length; i++)
            {
                string localName = emails[i].Split('@')[0];
                if (localName.Contains('+'))
                {
                    localName = localName.Split('+')[0];
                }
                if (localName.Contains('.'))
                {
                    string[] localNameSplitByDots = localName.Split('.');
                    localName = "";
                    for (int j = 0; j < localNameSplitByDots.Length; j++)
                    {
                        localName = localName + localNameSplitByDots[j];
                    }
                }
                string domainName = emails[i].Split('@')[1];
                string fullEmail = localName + "@" + domainName;
                actualAdresses.Add(fullEmail);
            }
            return actualAdresses.Count;
        }
    }
}
