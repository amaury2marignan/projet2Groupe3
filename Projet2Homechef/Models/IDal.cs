﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2Homechef.Models
{
    public interface IDal: IDisposable
    {
        void DeleteCreateDatabase();
        /*List<Sejour> ObtientTousLesSejours();
        int CreerSejour(string lieu, string telephone);
        void ModifierSejour(int id, string lieu, string telephone);*/

        //void SupprimerSejour(int id);

    }
}
