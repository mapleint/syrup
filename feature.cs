using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace BeanAssembly
{
    abstract class feature
    {
        public string name;

        public bool activated;

        public virtual void OnGUI()
        {

        }
        public virtual void Update()
        {

        }

        public virtual void FixedUpdate()
        {

        }
        protected void LoadDefaults<T>(T obj)
        {
            FieldInfo[] fields = GetType().GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo field in fields)
                typeof(T).GetField(field.Name, BindingFlags.Instance | BindingFlags.Public).SetValue(obj, field.GetValue(this));
        }
        protected void StoreDefaults<T>(T src, ref T dest)
        {
            if (src.Equals(dest))
                return; 
            dest = src;

            var fields = GetType().GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            foreach (var field in fields)
                field.SetValue(this, typeof(T).GetField(field.Name,
            BindingFlags.Instance | BindingFlags.Public).GetValue(src));
        }
    }
}
