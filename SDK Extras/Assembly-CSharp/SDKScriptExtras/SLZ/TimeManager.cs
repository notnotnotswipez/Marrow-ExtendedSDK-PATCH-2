using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ
{
	[MarrowPlugin("SLZ.Marrow.Plugins", "Time Manager", "0.0.1")]
	public class TimeManager : IMarrowPluginRunCallbacks, IMarrowPlugin, IMarrowPluginLevelCallbacks
	{
		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		public void OnMarrowPluginLoad()
		{
		}

		public void OnMarrowPluginStart()
		{
		}

		public void OnMarrowPluginStop()
		{
		}

		public void OnBeforeLevelLoad(LevelCrateReference level)
		{
		}

		public void OnBeforeLevelUnload()
		{
		}

		public void OnAfterLevelLoad(LevelCrateReference level)
		{
		}

		public void OnAfterLevelUnload()
		{
		}

		public void OnUpdate()
		{
		}

		public TimeManager()
			: base()
		{
		}
	}
}
