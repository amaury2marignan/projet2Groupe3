﻿namespace Projet2Homechef.Models.Prestation
{
    public class Devis
    {
        public int Id { get; set; }
        public Service2 Service { get; set; }
        public Chef Chef { get; set; }
        public float Cout { get; set; }
    }
}
