using System;
using System.Collections.Generic;

namespace tryandCatch
{
   public class AddressBook
{

   public Dictionary <string, Contact> AddressList = new Dictionary<string, Contact>();



    public void AddContact(Contact ContactName) {
            AddressList.Add(ContactName.Email, ContactName);
        }
   public Contact GetByEmail(string EmailAddress) {
            return AddressList[EmailAddress];
        }

}


}

