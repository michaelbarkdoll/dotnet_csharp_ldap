using System;

namespace ldapauth {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            var csauth = new CSAuth();
            var returncode = csauth.candy();
            Console.WriteLine(returncode);
        }

    }
}