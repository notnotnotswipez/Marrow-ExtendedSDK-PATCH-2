using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EyeTarget : sbyte
	{
		Left = 0,
		Right = 1,
		Center = 2
	}
}
