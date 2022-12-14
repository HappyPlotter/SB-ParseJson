using System.IO;
using Newtonsoft.Json;

public class CPHInline
{
    public bool Execute()
    {

	string json = args.ContainsKey("json") ? args["json"].ToString().Trim() : "" ;
	string prefix = args.ContainsKey("parsePrefix") ? args["parsePrefix"].ToString() : "parse" ;

	if (json == "")
	{
		CPH.LogInfo("JSON is EMPTY") ;
		return false ;
	}

	CPH.LogDebug(json) ;

        JsonTextReader reader = new JsonTextReader(new StringReader(json));
        while (reader.Read())
        {
			string Path = reader.Path.Replace("[", "").Replace("]", "") ;
			string ArgumentName = prefix + "." + Path ;

            if (reader.Value != null)
            {
				if (reader.TokenType.ToString() != "PropertyName")
				{
					CPH.LogDebug(prefix + "." + Path + " = "  + reader.Value) ;
					CPH.SetArgument(ArgumentName, reader.Value) ;
				}
            }

        }

        return true;
    }
}

