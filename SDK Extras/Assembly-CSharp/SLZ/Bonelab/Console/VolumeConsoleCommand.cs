using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "volume", "Set/Get Volume settings: volume master|music|sfx #")]
	internal class VolumeConsoleCommand : BaseConsoleCommand
	{

		public VolumeConsoleCommand()
			: base()
		{
		}
	}
}
