﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    class WinForms
    {
        private static Form main;

        public static Form Main
        {
            get
            {
                if (main == null)
                {
                    main = new frmMain();
                }
                return main;
            }
        }
    }
}