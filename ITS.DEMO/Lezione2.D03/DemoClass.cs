using System;
using System.ComponentModel;
using System.Reflection;

namespace Lezione2.D03
{
    public static class DemoClass
    {
        public enum States
        {
            California,
            [Description("New Mexico")]
            NewMexico,
            [Description("New York")]
            NewYork,
            [Description("South Carolina")]
            SouthCarolina,
            [Description("Tennessee")]
            Tennessee,
            [Description("Washington DC")]
            Washington
        }

        public static String GetEnumDescription(String stateEnumName)
        {
            String description = stateEnumName;
            
            //  Restituisce il valore di un campo supportato da un determinato oggetto.
            FieldInfo fi = typeof(States).GetField(stateEnumName);

            // Specifica la descrizione per una proprietà o evento
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                description = attributes[0].Description;

            return description;
        }
    }
}
