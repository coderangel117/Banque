﻿using System;
using Banque;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteB Compte1 = new CompteB(10, "PERINO","€", 123456);
            Compte1.Crediter(10);
            Compte1.ConsulterSolde();
        }
    }
}