using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FoveatedRenderingMode : sbyte
	{
		RDM = 0,
		VRS = 1
	}
}
