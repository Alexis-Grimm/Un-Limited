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
	[StaticConstructorOnStartup]
    public class ULSettings : ModSettings
	{
		//Misc Stats
		public static bool FNPD_Manip = true;

		//Work Speed Stats
		public static bool MS_Sight = true;
		public static bool DDS_Sight = true;
		public static bool SS_Sight = true;
		public static bool RS_Manip = true;
		public static bool RS_Sight = true;
		public static bool AGS_Sight = true;
		public static bool PWS_Sight = true;
		public static bool CS_Sight = true;
		public static bool CSC_Sight = true;
		public static bool CSC_Max = false;

		//Work Yield Stats
		public static bool MY_Manip = true;
		public static bool MY_Sight = true;
		public static bool MY_Max = false;
		public static bool AGY_Sight = true;
		public static bool AGY_Max = false;
		public static bool PWY_Sight = true;
		public static bool PWY_Max = false;
		public static bool DHY_Max = false;

		//Medical Stats

		//Combat Stats
		public static bool ARB_Max = true;
		public static bool MHC_Manip = true;
		public static bool MHC_Sight = true;
		public static bool MDC_Sight = true;
		public static bool SAP_Sight = true;
		public static bool SAP_Manip = true;

		//Social Stats
		public static bool NA_Talk = true;
		public static bool NA_Hear = true;
		public static bool ASC_Manip = true;
		public static bool SI_Talk = true;
		public static bool SI_Hear = true;
		public static bool TAC_Talk = true;
		public static bool TAC_Hear = true;
		public static bool TAC_Manip = true;
		public static bool TrAC_Talk = true;
		public static bool TrAC_Hear = true;
		public static bool TrAC_Manip = true;

		//Modded Stats

		//Capacity Stats

		public static bool WSCapLimit = true;
		public static bool WSHardCaps = true;
		public static bool MEDHardCaps = true;
		public static bool MEDCapCaps = true;

		public static Vector2 scrollPosition = Vector2.zero;

		/// <summary>
		/// Gui Portion of the Settings
		/// </summary>
		/// <param name="inRect">A Unity Rect with the size of the settings window.</param>
		public static void DoSettingsWindowContents(Rect inRect) {
			inRect.yMin += 15f;
			inRect.yMax -= 15f;

			var defaultColumnWidth = (inRect.width - 50);
			Listing_Standard list = new Listing_Standard() { ColumnWidth = defaultColumnWidth };

			var outRect = new Rect(inRect.x, inRect.y, inRect.width, inRect.height);
			var scrollRect = new Rect(0f, 0f, inRect.width - 16f, inRect.height * 12f);
			Widgets.BeginScrollView(outRect, ref scrollPosition, scrollRect, true);

			list.Begin(scrollRect);

			list.CheckboxLabeled("Work Speed Capacity Limit", ref WSCapLimit, "Removes Capacity limitations for work speed stats");
			list.End();
			Widgets.EndScrollView();
		}

		/// <summary>
		/// Exposing settings data
		/// </summary>
		public override void ExposeData() {
			base.ExposeData();

			Scribe_Values.Look<bool>(ref WSCapLimit, "WSCapLimit", true);
		}
	}

	public class UnLimited : Mod
	{
		/// <summary>
		/// constructor for reference to settings
		/// </summary>
		/// <param name="content"></param>
		public UnLimited(ModContentPack content) : base(content) {
			base.GetSettings<ULSettings>();
		}

		public void Save() {
			LoadedModManager.GetMod<UnLimited>().GetSettings<ULSettings>().Write();
		}

		/// <summary>
		/// SettingsCategory Override
		/// </summary>
		/// <returns>The mod name</returns>
		public override string SettingsCategory() {
			return "Unlimited";
		}

		public override void DoSettingsWindowContents(Rect inRect) {
			ULSettings.DoSettingsWindowContents(inRect);
		}

	}

}