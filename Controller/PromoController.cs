﻿using System;
using System.Collections.Generic;
using System.Text;
using Warung.Jenis;

namespace Warung.Controller
{
    class PromoController
    {
        public List<Diskon> diskon;

        public PromoController()
        {
            diskon = new List<Diskon>();
        }

        public void addPromo(Diskon diskon)
        {
            this.diskon.Add(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.diskon;
        }
    }
}
