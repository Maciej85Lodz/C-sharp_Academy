﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Car
    {
        public NameChangedDelegate NameChanged;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if(_name !=value)
                {
                    var oldName = _name;
                    _name = value;
                    if(NameChanged != null)
                        NameChanged(oldName, value);
                }
            }
        }
    }
}
