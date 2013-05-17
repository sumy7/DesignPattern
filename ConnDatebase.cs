using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DesignPattern
{
    abstract class connDatebase
    {
        public abstract bool connection();
        public abstract bool disConnection();
        public abstract string getSummer(string name);
        public abstract string getText(string name);
        public abstract Image getUML(string name);
        public abstract List< KeyValuePair<string,int> > getLevel();
        public abstract string getCode(string name);
    }
}
