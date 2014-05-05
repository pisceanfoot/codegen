using System;
using System.ComponentModel;
using System.Globalization;

namespace ChinaBest.SQLServer.SmoUtilities
{
    public class IdentifierConverter : ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType)
        {
            if (destinationType == typeof(ChinaBest.SQLServer.SmoUtilities.Identifier))
                return true;

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType)
        {
            if (destinationType == typeof(System.String) && value is ChinaBest.SQLServer.SmoUtilities.Identifier)
            {
                ChinaBest.SQLServer.SmoUtilities.Identifier so = (ChinaBest.SQLServer.SmoUtilities.Identifier)value;

                return so.IsIdentifier.ToString() + "," + so.IdentifierSeed.ToString() + "," + so.IdentifierStep.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                try
                {
                    string s = (string)value;
                    string[] tmp = s.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (tmp.Length == 3)
                    {
                        ChinaBest.SQLServer.SmoUtilities.Identifier so = new ChinaBest.SQLServer.SmoUtilities.Identifier();

                        so.IsIdentifier = Convert.ToBoolean(tmp[0]);
                        so.IdentifierStep = Convert.ToInt32(tmp[2]);
                        so.IdentifierSeed = Convert.ToInt32(tmp[1]);
                        return so;
                    }
                }
                catch
                {
                    throw new ArgumentException(
                    "无法将“" + (string)value +
                    "”转换为 Identifier 类型");
                }
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}