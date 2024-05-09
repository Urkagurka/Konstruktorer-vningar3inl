using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorerövning3inl
{
    class Person
    {
        private string förnamn;
        private string efternamn;
        private string fullnamn;
        private DateTime födelsedatum;

        public Person(string F, string E, int födelseår, int födelsemånad, int födelsedag)
        {
            förnamn = F;
            efternamn = E;
            födelsedatum = new DateTime(födelseår, födelsemånad, födelsedag);
            fullnamn = förnamn + " " + efternamn;
        }
        public string getFullnamn() { return fullnamn; }

        public bool isMyndig()
        {
            DateTime eiten = DateTime.Today.AddYears(-18);
            if (födelsedatum.CompareTo(eiten) <= 0) 
            { 
                return true; 
            }

            return false;
        }
    }
}