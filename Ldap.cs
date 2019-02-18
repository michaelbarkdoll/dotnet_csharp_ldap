using System;
using System.Collections.Generic;

using Novell.Directory.Ldap;

namespace ldapauth {
    

    public class CSAuth {
        public int candy () {

            LdapConnection ldapConn = new LdapConnection();
            ldapConn.SecureSocketLayer=true;
            int ldapVersion = LdapConnection.LdapV3;

            try {

                //ldapConn.Connect("AD.SIU.EDU", 389);
                ldapConn.Connect("AD.SIU.EDU", 636);
                var sdn = ldapConn.GetSchemaDn();

                // Anonymous bind
                //ldapConn.Bind(null,null);

                // Authentication bind
                ldapConn.Bind(ldapVersion, "AD\\siu85XXXXXXX", "Plain_Text_Password");
                
            }
            catch (LdapException e) {
                Console.WriteLine("Error: " + e.ToString());
            }

            return 0;
        }

    }
}