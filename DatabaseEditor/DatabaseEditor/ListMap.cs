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
        public string name;
        public List<object> list;
        public FieldInfo[] fields;

        public ListMap(string name, List<object> list, object listObject)
        {
            this.name = name;
            this.list = list;
            this.fields = listObject.GetType().GetFields();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
