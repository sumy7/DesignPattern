using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DesignPattern
{
    abstract class connDatebase
    {
        public abstract void execQuery(string name);
        public abstract string getSummer();
        public abstract string getText();
        public abstract Image getUML();
        public abstract List< KeyValuePair<string,int> > getLevel();
        public abstract string getCode();
        public abstract bool ishasUML();
        public abstract bool ishasCode();
    }
}
