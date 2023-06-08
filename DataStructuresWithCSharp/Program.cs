namespace DataStructuresWithCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list data types
            string[] dataTypes =
            {
                "value types",

                "floating-point types",
                "float",
                "double",
                "decimal",

                "integral types",
                "byte",
                "short",
                "integer",
                "long",
                "bool",

                "character",

                "enumerable",


                "reference types",

                "object",
                "string",
                "dynamic",
                
                "array types",
                "integer array",
                "character array",
                "list",


                ""
            };

            // list definition types
            string[] definitionTypes = {
                    "definition",
                    "specifications in C#",
                    "example"
            };

            // define data types
            //TODO: expand dictionary to match possible types
            var dataTypeDefinition = new Dictionary<string, string>(){
                {"floating-point types", "Type used to display numbers catering toward range rather than precission. Saved as scientific notation. " +
                "First bit denotes the sign, then part of remaining bits denote the exponent and the rest denote the mantissa."},
                {"float", ""},
                {"double", ""},
                {"decimal", ""},
                {"integral types", ""},
                {"long", ""},
                {"integer", ""},
                {"string", ""},
                {"character", ""},
                {"integer array", ""},
                {"character array", ""},
                {"list", ""},
                {"enumerable", ""}
            };
            // describe data types in c#
            //TODO: expand dictionary to match possible types
            var dataTypesInCSharp = new Dictionary<string, string>(){
                {"floating-point types", "System.Single, System.Double, System.Decimal"},
                {"float", "System.Single, 4 Bytes, precision ~ 6-9 digits"},
                {"double", "System.Double"},
                {"decimal", "System.Decimal"},
                {"integral types", "System., System., System." },
                {"byte", "System." },
                {"short", "System." },
                {"integer", ""},
                {"long", ""},
                {"nint", ""},
                {"bool", ""},
                {"string", ""},
                {"character", ""},
                {"enumeration types", ""},
                {"integer array", ""},
                {"character array", ""},
                {"list", ""}
            };
            // show data type examples
            //TODO: expand dictionary to match possible types
            var dataTypeCSharpExample = new Dictionary<string, dynamic>()
            {
                {"floating-point", 1.23123123123f},
                {"float", 1.123123123123f},
                {"double", 1.123123123123d},
                {"decimal", 1.123123123123m},
                {"long", 123123L},
                {"integer", 123},
                {"string", "123"},
                {"character", '1'},
                {"integer array", new int[1,2,3]},
                {"character array", new char['1', '2', '3']},
                {"list", new List<string> {"1", "2", "3" } },
                {"enumerable", ""}
            };
            // combine dictionaries into one
            var dataTypeFullDictionary = new Dictionary<string, dynamic[]>();

            for (int i = 0;  i < dataTypes.Length; i ++)
            {
                var dataType = dataTypes[i];
                var definitions = new dynamic[]
                {
                    dataTypeDefinition[dataType],
                    dataTypesInCSharp[dataType],
                    dataTypeCSharpExample[dataType]
                };

                dataTypeFullDictionary.Add(dataType, definitions);
            }


            // main
            bool viewingDataStructures = true;
            while (viewingDataStructures){

                string dataTypeOutput = getDataTypeInput();
                int definitionSelection = getDefinitionOutputSelection();
                int definitionOutput = dataTypeFullDictionary[dataTypeOutput][definitionSelection];

                string finalOutput = $"{dataTypeOutput} {definitionTypes[definitionSelection]}: {definitionOutput}";

                Console.WriteLine(finalOutput);

            }

            // functions
            // TODO: input verification
            string getDataTypeInput()
            {
                Console.WriteLine("What data type do you want to view?");
                string dataTypeInput = Console.ReadLine();
                return dataTypeInput.ToLower();
            }
            // TODO: input verification
            int getDefinitionOutputSelection()
            {
                Console.WriteLine("what information about {dataTypeInput} would you like to view");
                string definitionSelectionInput = Console.ReadLine();
                int.TryParse(definitionSelectionInput, out int definitionSelection);
                return definitionSelection;
            }

        }
    }
}