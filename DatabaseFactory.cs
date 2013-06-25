using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    abstract class DatabaseFactory
    {
        public abstract connDatebase getFactory();
    }
    class AccessDBFactory : DatabaseFactory
    {
        public override connDatebase getFactory()
        {
            return (new AccessDB());
        }
    }
}
