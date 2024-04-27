#region System Directives
global using System;
global using System.Text;
global using System.Text.RegularExpressions;
#endregion
#region Il2Cpp Directives
global using Il2CppTLD.AddressableAssets;
global using Il2CppInterop.Runtime;
global using Il2CppTLD.Gear;
#endregion
#region Unity Directives
global using UnityEngine.AddressableAssets;
#endregion
#region Mod Directives
global using DeveloperConsolePlus.Utilities;
global using DeveloperConsolePlus.Utilities.Enums;
global using DeveloperConsolePlus.Utilities.Exceptions;
global using DeveloperConsolePlus.Utilities.JSON;
global using DeveloperConsolePlus.Utilities.Logger;
global using DeveloperConsolePlus.Utilities.Logger.Enums;
#endregion

using Il2CppTLD.Scenes;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace DeveloperConsolePlus
{

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public class Main : MelonMod
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	{
		/// <summary>
		/// 
		/// </summary>
		public static ComplexLogger<Main> Logger = new();

		public static Il2CppSystem.Collections.Generic.List<IResourceLocation> Scenes;
		public static List<string> SceneName;

		/// <inheritdoc/>
		public override void OnInitializeMelon()
		{
			bool build = false;
			try
			{
				Scenes = AssetHelper.FindAllAssetsLocations<SceneSet>().Cast<Il2CppSystem.Collections.Generic.List<IResourceLocation>>();
				build = true;
			}
			catch (InvalidCastException e)
			{
				Logger.Log($"Attempting to build list of Scenes failed", e, FlaggedLoggingLevel.Exception);
			}

			if (build)
			{
				foreach (IResourceLocation location in Scenes)
				{
					SceneName.Add(location.PrimaryKey);

					Logger.Log($"Add {location.PrimaryKey} to SceneName", FlaggedLoggingLevel.Verbose|FlaggedLoggingLevel.Trace);
				}

				SceneName.Sort();
			}

			Settings.OnLoad();
		}
	}
}
