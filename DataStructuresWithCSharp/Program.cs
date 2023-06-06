namespace DataStructuresWithCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var DataTypeDefinition = new Dictionary<string, string>(){
                {"floating-point", "Type used to display numbers catering toward range rather than precission. Saved as scientific notation. " +
                "First bit denotes the sign, then part of remaining bits denote the exponent and the rest denote the mantissa."},
                {"float", ""},
                {"double", ""},
                {"decimal", ""},
                {"long", ""},
                {"integer", ""},
                {"string", ""},
                {"character", ""},
                {"integer array", ""},
                {"character array", ""},
                {"list", ""},
                {"enumerable", ""}
            };

            var DataTypesInCSharp = new Dictionary<string, string>(){
                {"floating-point", "System.Single, System.Double, System.Decimal"},
                {"float", "System.Single, 4 Bytes, precision ~ 6-9 digits"},
                {"double", "System.Double"},
                {"decimal", "System.Decimal"},
                {"long", ""},
                {"integer", ""},
                {"string", ""},
                {"character", ""},
                {"integer array", ""},
                {"character array", ""},
                {"list", ""},
                {"enumerable", ""}
            };

            var DataTypeCSharpExample = new Dictionary<string, dynamic>()
            {
                {"floating-point", ""},
                {"float", ""},
                {"long", ""},
                {"integer", ""},
                {"string", ""},
                {"character", ""},
                {"integer array", ""},
                {"character array", ""},
                {"list", ""},
                {"enumerable", ""}
            };
        }
    }
}