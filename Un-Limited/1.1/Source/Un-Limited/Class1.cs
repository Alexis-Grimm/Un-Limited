using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;

namespace Grimm_UnLimited
{
    public class ULSettings : ModSettings
	{
        /// <summary>
        /// The settings for this mod
        /// </summary>
        public bool WSCapLimit;
		public bool WSHardCaps;
		public bool MEDHardCaps;
		public bool MEDCapCaps;

		/// <summary>
		/// scribe values of mod settings
		/// </summary>
		public override void ExposeData()
		{
			Scribe_Values.Look(ref WSCapLimit, "WSCapLimit");
			base.ExposeData();
		}
	}

	public class UnLimited : Mod
	{
		/// <summary>
		/// Reference the settings
		/// </summary>
		ULSettings settings;

		/// <summary>
		/// constructor for reference to settings
		/// </summary>
		/// <param name="content"></param>
		public UnLimited(ModContentPack content) :base(content)
		{
			this.settings = GetSettings<ULSettings>();
		}

		/// <summary>
		/// Gui Portion of the Settings
		/// </summary>
		/// <param name="inRect">A Unity Rect with the size of the settings window.</param>
		public override void DoSettingsWindowContents(Rect inRect)
		{
			Listing_Standard listingStandard = new Listing_Standard();
			listingStandard.Begin(inRect);
			listingStandard.CheckboxLabeled("Work Speed Capacity Limit", ref settings.WSCapLimit, "Removes Capacity limitations for work speed stats");
			listingStandard.End();
			base.DoSettingsWindowContents(inRect);
		}

		/// <summary>
		/// SettingsCategory Override
		/// </summary>
		/// <returns>The translated mod name</returns>
		public override string SettingsCategory()
		{
			return "Grimm_UnLimited".Translate();
		}
	}
}
