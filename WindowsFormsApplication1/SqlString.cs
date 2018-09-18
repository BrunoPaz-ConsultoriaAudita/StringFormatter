using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class SqlString
	{
		public string[] text { get; set; }
        //Batata
		public SqlString(string[] txt)
		{
			text = txt;
		}
        //XYZ
		public string[] trim()
		{
            for (int c = 0; c < text.Length; c++)
            {
                text[c] = text[c].Trim();
            }
            while (true)
            {
                break;
            }
            return text;
		}

		public string removeLineBreak()
		{
			string str = "";
			for (int c = 0; c < text.Length; c++)
			{
				text[c] = text[c].Replace("\n", "");
				str += text[c];
			}
			return str;
		}

		public string[] format2()
		{
			for (int c = 0; c < text.Length; c++)
			{
				text[c] = text[c].Replace(",", "");
				text[c] = text[c].Replace("[", "");
				text[c] = text[c].Replace("]", "");
				text[c] = text[c].Replace("(", "");
				text[c] = text[c].Replace(")", "");
			}
			return text;
		}

        public string[] replace(string[] befrep, string[] aftrep, string[] txt)
        {
            for (int i = 0; i < befrep.Length; i++)
            {
                for (int c = 0; c < txt.Length; c++)
                {
                    txt[c] = txt[c].Replace(befrep[i], aftrep[i]);
                }
            }
            return txt;
        }

        public string[] replace(string[] befrep, string[] aftrep)
        {
			if (befrep.Length != aftrep.Length) {
				string[] err = { "Elementos discrepantes" };
				return err;
			}
            string[] txt = this.text;
            for (int i = 0; i < befrep.Length; i++)
            {
                for (int c = 0; c < txt.Length; c++)
                {
					if (txt[c].Replace(befrep[i], aftrep[i]) != "")
						txt[c] = txt[c].Replace(befrep[i], aftrep[i]);
					else
						txt[c] = "Erro";
                }
            }
            return txt;
        }

		public string classToDao(string[] input, string table, string schema, string _class)
		{
			string str = "";
			string values = "strQuery += string.Format(\"VALUES (";
			for(int i = 0; i < input.Length; i++)
			{
				input[i] = input[i].Replace("public","");
				input[i] = input[i].Replace("get", "");
				input[i] = input[i].Replace("set", "");
				input[i] = input[i].Replace(";", "");
				input[i] = input[i].Replace("{", "");
				input[i] = input[i].Replace("}", "");
				if (input[i].Contains("string"))
				{
					values += "'{" + i + "}'";
					input[i] = input[i].Replace("string", "");
				}
				else if (input[i].Contains("int")||input[i].Contains("double"))
				{
					values += "{" + i + "}";
					input[i] = input[i].Replace("int", "");
					input[i] = input[i].Replace("double", "");
				}
				else if (input[i].Contains("DateTime"))
				{
					values += "'{" + i + ": yyyy-MM-dd}'";
					input[i] = input[i].Replace("DateTime", "");
				}
				else
				{
					values += "'{" + i + "}'";
				}
				input[i] = input[i].Trim();
				values += (i < input.Length - 1 ? "," :"");
			}
			values += ")\",\n";
			str += "string strQuery = \"INSERT INTO [" + schema + "].["+table+"](";
			for (int i = 0;i<input.Length;i++)
			{
				str += "["+input[i]+"]";
				str += (i < input.Length - 1 ? "," : "");
			}
			str += ")\";\n";
			str += values;
			for(int i = 0; i < input.Length; i++)
			{
				str += "	"+_class+""+"."+input[i];
				str += (i < input.Length - 1 ? ",\n" : "");
			}
			str += "\n);";
			return str;
		}

		public string classToCaseXml(string[] input, string _object, string reader)
		{
			string str = "";

			for (int i = 0; i < input.Length; i++)
			{
				input[i] = input[i].Replace("public", "");
				input[i] = input[i].Replace("get", "");
				input[i] = input[i].Replace("set", "");
				input[i] = input[i].Replace(";", "");
				input[i] = input[i].Replace("{", "");
				input[i] = input[i].Replace("}", "");
				input[i] = input[i].Trim();
				if (input[i].Contains("string"))
				{
					input[i] = input[i].Replace("string", "");
					input[i] = input[i].Trim();
					str += "case \""+input[i]+"\":\n";
					str += _object + "." + input[i] +" = "+reader+ ".ReadString();\nbreak;";
					
				}
				else if (input[i].Contains("double"))
				{
					input[i] = input[i].Replace("double", "");
					input[i] = input[i].Trim();
					str += "case \"" + input[i] + "\":\n";
					str += _object + "." + input[i] + " = double.Parse(" + reader + ".ReadString());\nbreak;";
				}
				else if (input[i].Contains("int")){
					input[i] = input[i].Replace("int", "");
					input[i] = input[i].Trim();
					str += "case \"" + input[i] + "\":\n";
					str += _object + "." + input[i] + " = int.Parse(" + reader + ".ReadString());\nbreak;";
				}
				else if (input[i].Contains("DateTime"))
				{
					input[i] = input[i].Replace("DateTime", "");
					input[i] = input[i].Trim();
					str += "case \""+input[i]+"\":\n";
					str += _object + "." + input[i] + " = DateTime.Parse(" + reader + ".ReadString());\nbreak;";

				}
				else
				{
					input[i] = input[i].Trim();
					str += "case \"" + input[i] + "\":\n";
					str += _object + "." + input[i] + " = " + reader + ".ReadString();\nbreak;";
				}
			}
			return str;
		}
    }
}
