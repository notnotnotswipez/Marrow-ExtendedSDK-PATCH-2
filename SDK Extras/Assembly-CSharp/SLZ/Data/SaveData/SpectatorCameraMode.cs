using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpectatorCameraMode : sbyte
	{
		Passthrough = 0,
		Fisheye = 1,
		Void = 2
	}
}
