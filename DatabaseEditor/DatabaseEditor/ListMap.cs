using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEditor
{
    public class ListMap
    {
        public Type type;
        public string name;
        public List<object> list;
        public FieldInfo[] fields;

        public ListMap(List<object> list, object listObject)
        {
            this.list = list;
            this.type = listObject.GetType();
            this.name = type.Name;
            this.fields = type.GetFields();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
