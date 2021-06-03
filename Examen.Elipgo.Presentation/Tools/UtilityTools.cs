using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Tools
{
    public class UtilityTools
    {
        public static void CenterX(Control Parent, Control Child)
        {
            int x = 0;
            x = (Parent.Width / 2) - (Child.Width / 2);
            Child.Location = new System.Drawing.Point(x, Child.Location.Y);
        }

        public static void CenterXY(Control Parent, Control Child)
        {
            int x = 0;
            int y = 0;
            x = (Parent.Width / 2) - (Child.Width / 2);
            y = (Parent.Height / 2) - (Child.Height / 2);
            Child.Location = new System.Drawing.Point(x, y);
        }

        public static IEnumerable<T> FindControls<T>(Control control) where T : Control
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => FindControls<T>(ctrl))
                .Concat(controls)
                .Where(c => c.GetType() == typeof(T)).Cast<T>();
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
