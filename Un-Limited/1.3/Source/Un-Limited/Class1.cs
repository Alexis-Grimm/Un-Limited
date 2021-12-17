using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;

namespace Grimm_UnLimited {
	[StaticConstructorOnStartup]
    public class ULSettings : ModSettings {

		//Stats Apparel
		public static bool ArmorRatingBase_Max = true;

		//Combat Stats
		public static bool MeleeHitChance_Caps = true;
		public static bool MeleeDodgeChance_Caps = true;
		public static bool ShootingAccuracyPawn_Caps = true;

		//Stats Pawns General
		public static bool ForagedNutrition_Caps = true;

		//Stats Pawns Social
		public static bool NegotiationAbility_Caps = true;
		public static bool ArrestSuccessChance_Caps = true;
		public static bool SocialImpact_Caps = true;
		public static bool TameAnimalChance_Caps = true;
		public static bool TrainAnimalChance_Caps = true;

		//Stats Pawn Work General
		public static bool MiningSpeed_Caps = true;
		public static bool DeepDrillingSpeed_Caps = true;
		public static bool MiningYield_Max = false;
		public static bool MiningYield_Caps = true;
		public static bool SmoothingSpeed_Caps = true;
		public static bool ResearchSpeed_Caps = true;
		public static bool AnimalGatherSpeed_Caps = true;
		public static bool AnimalGatherYield_Max = false;
		public static bool AnimalGatherYield_Caps = true;
		public static bool PlantWorkSpeed_Caps = true;
		public static bool PlantHarvestYield_Max = true;
		public static bool PlantHarvestYield_Caps = true;
		public static bool DrugHarvestYield_Max = true;
		public static bool ConstructionSpeed_Caps = true;
		public static bool ConstructSuccessChance_Caps = true;
		public static bool ConstructSuccessChance_Max = true;
		public static bool FixSuccessChance_Caps = true;
		public static bool FixSuccessChance_Max = true;

		//Stats Pawn Work Medical
		public static bool TendSpeed_Caps = true;
		public static bool TendQuality_Caps = true;
		public static bool OperationSpeed_Caps = true;
		public static bool SurgerySuccessChance_Caps = true;

		//Stats Pawn Work Recipes
		public static bool SmeltingSpeed_Caps = true;
		public static bool GeneralLaborSpeed_Caps = true;
		public static bool DrugSynthesisSpeed_Caps = true;
		public static bool CookSpeed_Caps = true;
		public static bool DrugCookingSpeed_Caps = true;
		public static bool ButcherySpeed_Caps = true;
		public static bool ButcheryEfficiency_Caps = true;
		public static bool ButcheryEfficiencyFlesh_Max = false;
		public static bool ButcheryEfficiencyMechanoid_Max = false;

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
			list.Label("Restart the game after changing any value. Checked means limit is removed, unchecked means it is not.");

			list.Label("Combat Stats");
			list.GapLine(0);
			list.CheckboxLabeled("Armor Rating Base Max", ref ArmorRatingBase_Max, "Remove limit for Armor Rating Base");
			list.CheckboxLabeled("Melee Hit Chance Caps", ref MeleeHitChance_Caps, "Remove limit for how much capacities can improve Melee Hit Chance");
			list.CheckboxLabeled("Melee Dodge Chance Caps", ref MeleeDodgeChance_Caps, "Remove limit for how much capacities can improve Melee Dodge Chance");
			list.CheckboxLabeled("Shooting Accuracy Caps", ref ShootingAccuracyPawn_Caps, "Remove limit for how much capacities can improve Shooting Accuracy");
			list.Gap(3);
			list.Label("Miscellaneous Stats");
			list.GapLine(0);
			list.CheckboxLabeled("Foraged Nutrition Per Day Caps", ref ForagedNutrition_Caps, "Remove limit for how much capacities can improve Foraged Nutrition Per Day");
			list.Gap(3);
			list.Label("Social Stats");
			list.GapLine(0);
			list.CheckboxLabeled("Negotiation Ability Caps", ref NegotiationAbility_Caps, "Remove limit for how much capacities can improve Negotiation Ability");
			list.CheckboxLabeled("Arrest Success Chance Caps", ref ArrestSuccessChance_Caps, "Remove limit for how much capacities can improve Arrest Success Chance");
			list.CheckboxLabeled("Social Impact Day Caps", ref SocialImpact_Caps, "Remove limit for how much capacities can improve Social Impact");
			list.CheckboxLabeled("Tame Animal Chance Caps", ref TameAnimalChance_Caps, "Remove limit for how much capacities can improve Tame Animal Chance");
			list.CheckboxLabeled("Train Animal Chance Caps", ref TrainAnimalChance_Caps, "Remove limit for how much capacities can improve Train Animal Chance");
			list.Gap(3);
			list.Label("General Work Stats");
			list.GapLine(0);
			list.CheckboxLabeled("Mining Speed Caps", ref MiningSpeed_Caps, "Remove limit for how much capacities can improve Mining Speed");
			list.CheckboxLabeled("Deep Drilling Speed Caps", ref DeepDrillingSpeed_Caps, "Remove limit for how much capacities can improve Deep Drilling Speed");
			list.CheckboxLabeled("Mining Yield Max", ref MiningYield_Max, "Remove limit for Mining Yield");
			list.CheckboxLabeled("Mining Yield Caps", ref MiningYield_Caps, "Remove limit for how much capacities can improve Mining Yield");
			list.CheckboxLabeled("Smoothing Speed Caps", ref SmoothingSpeed_Caps, "Remove limit for how much capacities can improve Smoothing Speed");
			list.CheckboxLabeled("Research Speed Caps", ref ResearchSpeed_Caps, "Remove limit for how much capacities can improve Research Speed");
			list.CheckboxLabeled("Animal Gather Speed Caps", ref AnimalGatherSpeed_Caps, "Remove limit for how much capacities can improve Animal Gather Speed");
			list.CheckboxLabeled("Animal Gather Yield Max", ref AnimalGatherYield_Max, "Remove limit for Animal Gather Yield");
			list.CheckboxLabeled("Animal Gather Yield Caps", ref AnimalGatherYield_Caps, "Remove limit for how much capacities can improve Animal Gather Yield");
			list.CheckboxLabeled("Plant Work Speed Caps", ref PlantWorkSpeed_Caps, "Remove limit for how much capacities can improve Plant Work Speed");
			list.CheckboxLabeled("Plant Harvest Yield Max", ref PlantHarvestYield_Max, "Remove limit for Plant Harvest Yield. Confusingly, this will not change the maximum yield of a crop, only the chances of getting the maximum yield");
			list.CheckboxLabeled("Plant Harvest Yield Caps", ref PlantHarvestYield_Caps, "Remove limit for how much capacities can improve Plant Harvest Yield");
			list.CheckboxLabeled("Drug Harvest Yield Max", ref DrugHarvestYield_Max, "Remove limit for Drug Harvest Yield, this is Plant Harvest Yield but for drug plants specifically");
			list.CheckboxLabeled("Construction Speed Caps", ref ConstructionSpeed_Caps, "Remove limit for how much capacities can improve Construction Speed");
			list.CheckboxLabeled("Construct Success Chance Caps", ref ConstructSuccessChance_Caps, "Remove limit for how much capacities can improve Construct Success Chance");
			list.CheckboxLabeled("Construct Success Chance Max", ref ConstructSuccessChance_Max, "Remove limit for Construct Success Chance");
			list.CheckboxLabeled("Repair Success Chance Caps", ref FixSuccessChance_Caps, "Remove limit for how much capacities can improve Repair Success Chance");
			list.CheckboxLabeled("Repair Success Chance Max", ref FixSuccessChance_Max, "Remove limit for Repair Success Chance");
			list.Gap(3);
			list.Label("Medical Work Stats");
			list.GapLine(0);
			list.CheckboxLabeled("Tend Speed Caps", ref TendSpeed_Caps, "Remove limit for how much capacities can improve Tend Speed");
			list.CheckboxLabeled("Tend Quality Caps", ref TendQuality_Caps, "Remove limit for how much capacities can improve Tend Quality");
			list.CheckboxLabeled("Operation Speed Caps", ref OperationSpeed_Caps, "Remove limit for how much capacities can improve Operation Speed");
			list.CheckboxLabeled("Surgery Success Chance Caps", ref SurgerySuccessChance_Caps, "Remove limit for how much capacities can improve Surgery Success Chance");
			list.Gap(3);
			list.Label("Recipe Work Stats");
			list.GapLine(0);
			list.CheckboxLabeled("Smelting Speed Caps", ref SmeltingSpeed_Caps, "Remove limit for how much capacities can improve Smelting Speed");
			list.CheckboxLabeled("General Labor Speed Caps", ref GeneralLaborSpeed_Caps, "Remove limit for how much capacities can improve General Labor Speed");
			list.CheckboxLabeled("Drug Synthesis Speed Caps", ref DrugSynthesisSpeed_Caps, "Remove limit for how much capacities can improve Drug Synthesis Speed");
			list.CheckboxLabeled("Cook Speed Caps", ref CookSpeed_Caps, "Remove limit for how much capacities can improve Cooking Speed");
			list.CheckboxLabeled("Drug Cooking Speed Caps", ref DrugCookingSpeed_Caps, "Remove limit for how much capacities can improve Drug Cooking Speed");
			list.CheckboxLabeled("ButcherySpeed_Caps", ref ButcherySpeed_Caps, "Remove limit for how much capacities can improve Butchery Speed");
			list.CheckboxLabeled("Butchery Efficiency Caps", ref ButcheryEfficiency_Caps, "Remove limit for how much capacities can improve Butchery Efficiency");
			list.CheckboxLabeled("Flesh Butchery Efficiency Max", ref ButcheryEfficiencyFlesh_Max, "Remove limit for Flesh Butchery Efficiency");
			list.CheckboxLabeled("Mechanoid Butchery Efficiency Max", ref ButcheryEfficiencyMechanoid_Max, "Remove limit for Mechanoid Butchery Efficiency");

			list.End();
			Widgets.EndScrollView();
		}

		/// <summary>
		/// Exposing settings data
		/// </summary>
		public override void ExposeData() {
			base.ExposeData();

			Scribe_Values.Look<bool>(ref ArmorRatingBase_Max, "ArmorRatingBase_Max", true);
			Scribe_Values.Look<bool>(ref MeleeHitChance_Caps, "MeleeHitChance_Caps", true);
			Scribe_Values.Look<bool>(ref MeleeDodgeChance_Caps, "MeleeDodgeChance_Caps", true);
			Scribe_Values.Look<bool>(ref ShootingAccuracyPawn_Caps, "ShootingAccuracyPawn_Caps", true);

			Scribe_Values.Look<bool>(ref ForagedNutrition_Caps, "ForagedNutrition_Caps", true);

			Scribe_Values.Look<bool>(ref NegotiationAbility_Caps, "NegotiationAbility_Caps", true);
			Scribe_Values.Look<bool>(ref ArrestSuccessChance_Caps, "ArrestSuccessChance_Caps", true);
			Scribe_Values.Look<bool>(ref SocialImpact_Caps, "SocialImpact_Caps", true);
			Scribe_Values.Look<bool>(ref TameAnimalChance_Caps, "TameAnimalChance_Caps", true);
			Scribe_Values.Look<bool>(ref TrainAnimalChance_Caps, "TrainAnimalChance_Caps", true);

			Scribe_Values.Look<bool>(ref MiningSpeed_Caps, "MiningSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref DeepDrillingSpeed_Caps, "DeepDrillingSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref MiningYield_Max, "MiningYield_Max", false);
			Scribe_Values.Look<bool>(ref MiningYield_Caps, "MiningYield_Caps", true);
			Scribe_Values.Look<bool>(ref SmoothingSpeed_Caps, "SmoothingSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref ResearchSpeed_Caps, "ResearchSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref AnimalGatherSpeed_Caps, "AnimalGatherSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref AnimalGatherYield_Max, "AnimalGatherYield_Max", false);
			Scribe_Values.Look<bool>(ref AnimalGatherYield_Caps, "AnimalGatherYield_Caps", true);
			Scribe_Values.Look<bool>(ref PlantWorkSpeed_Caps, "PlantWorkSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref PlantHarvestYield_Max, "PlantHarvestYield_Max", true);
			Scribe_Values.Look<bool>(ref PlantHarvestYield_Caps, "PlantHarvestYield_Caps", true);
			Scribe_Values.Look<bool>(ref DrugHarvestYield_Max, "DrugHarvestYield_Max", true);
			Scribe_Values.Look<bool>(ref ConstructionSpeed_Caps, "ConstructionSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref ConstructSuccessChance_Caps, "ConstructSuccessChance_Caps", true);
			Scribe_Values.Look<bool>(ref ConstructSuccessChance_Max, "ConstructSuccessChance_Max", true);
			Scribe_Values.Look<bool>(ref FixSuccessChance_Caps, "FixSuccessChance_Caps", true);
			Scribe_Values.Look<bool>(ref FixSuccessChance_Max, "FixSuccessChance_Max", true);

			Scribe_Values.Look<bool>(ref TendSpeed_Caps, "TendSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref TendQuality_Caps, "TendQuality_Caps", true);
			Scribe_Values.Look<bool>(ref OperationSpeed_Caps, "OperationSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref SurgerySuccessChance_Caps, "SurgerySuccessChance_Caps", true);

			Scribe_Values.Look<bool>(ref SmeltingSpeed_Caps, "SmeltingSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref GeneralLaborSpeed_Caps, "GeneralLaborSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref DrugSynthesisSpeed_Caps, "DrugSynthesisSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref CookSpeed_Caps, "CookSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref DrugCookingSpeed_Caps, "DrugCookingSpeed_Caps", true);
			Scribe_Values.Look<bool>(ref ButcherySpeed_Caps, "ButcherySpeed_Caps", true);
			Scribe_Values.Look<bool>(ref ButcheryEfficiency_Caps, "ButcheryEfficiency_Caps", true);
			Scribe_Values.Look<bool>(ref ButcheryEfficiencyFlesh_Max, "ButcheryEfficiencyFlesh_Max", false);
			Scribe_Values.Look<bool>(ref ButcheryEfficiencyMechanoid_Max, "ButcheryEfficiencyMechanoid_Max", false);

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