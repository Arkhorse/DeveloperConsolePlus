namespace DeveloperConsolePlus
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public class Settings : JsonModSettings
	{
		internal static Settings Instance { get; } = new();


#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		// this is used to set things when user clicks confirm. If you dont need this ability, dont include this method
		/// <inheritdoc/>
		protected override void OnConfirm()
		{
			base.OnConfirm();

		}

		// this is called whenever there is a change. Ensure it contains the null bits that the base method has
		/// <inheritdoc/>
		protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
		{
			base.OnChange(field, oldValue, newValue);
		}

		// This is used to load the settings
		internal static void OnLoad()
		{
			Instance.AddToModSettings(BuildInfo.GUIName);
			Instance.RefreshGUI();
		}
	}
}
