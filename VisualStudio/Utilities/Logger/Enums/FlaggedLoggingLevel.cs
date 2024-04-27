// ---------------------------------------------
// FlaggedLoggingLevel - by The Illusion
// ---------------------------------------------
// Reusage Rights ------------------------------
// You are free to use this script or portions of it in your own mods, provided you give me credit in your description and maintain this section of comments in any released source code
//
// Warning !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// Ensure you change the namespace to whatever namespace your mod uses, so it doesnt conflict with other mods
// ---------------------------------------------

namespace DeveloperConsolePlus.Utilities.Logger.Enums
{
	/// <summary>
	/// 
	/// </summary>
	[System.Flags]
	public enum FlaggedLoggingLevel : int
	{
		/// <summary>
		/// 
		/// </summary>
		None 		= 0,
		/// <summary>
		/// 
		/// </summary>
		Trace 		= 1,
		/// <summary>
		/// 
		/// </summary>
		Debug 		= 2,
		/// <summary>
		/// 
		/// </summary>
		Verbose 	= 4,
		/// <summary>
		/// 
		/// </summary>
		Warning 	= 8,
		/// <summary>
		/// 
		/// </summary>
		Error 		= 16,
		/// <summary>
		/// 
		/// </summary>
		Critical 	= 32,
		/// <summary>
		/// 
		/// </summary>
		Exception	= 64,
		/// <summary>
		/// 
		/// </summary>
		All 		= None & Trace & Debug & Verbose & Warning & Error & Critical & Exception
	}
}
