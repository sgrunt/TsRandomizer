﻿using System;
using System.Collections.Generic;
using TsRandomizer.Settings.GameSettingObjects;

namespace TsRandomizer.Settings
{
	public class SettingCollection
	{
		public static readonly GameSettingCategoryInfo[] Categories = {
			new GameSettingCategoryInfo { Name = "Stats", Description = "Settings related to player and enemy stat scaling.",
				SettingsPerCategory = new List<Func<SettingCollection, GameSetting>> {
					s => s.DamageRando, s => s.MaxHP
				}},
			new GameSettingCategoryInfo { Name = "Loot", Description = "Settings related to shop inventory and loot.",
				SettingsPerCategory = new List<Func<SettingCollection, GameSetting>> {
					s => s.ShopFill, s => s.ShopMultiplier, s => s.ShopWarpShards, s => s.LootPool
				}},
			new GameSettingCategoryInfo { Name = "Minimap", Description = "Settings related to minimap colors.",
				SettingsPerCategory = new List<Func<SettingCollection, GameSetting>> {
					s => s.PastMinimapColor, s => s.PresentMinimapColor, s => s.PyramidMinimapColor,
					s => s.LootMinimapColor, s => s.SpecailLootMinimapColor,
					s => s.SaveStatueMinimapColor, s => s.PresentTransitionMinimapColor, s => s.PastTransitionMinimapColor
				}},
			new GameSettingCategoryInfo { Name = "Archipelago", Description = "Settings related to games with the Archipelago multiworld.",
				SettingsPerCategory = new List<Func<SettingCollection, GameSetting>> {
					s => s.NumberOfOnScreenLogLines, s => s.OnScreenLogLineScreenTime, s => s.ShowSendItemsFromMe, s => s.ShowReceivedItemsFromMe,
					s => s.ShowSendGenericItems, s => s.ShowSendImportantItems, s => s.ShowSendProgressionItems, s => s.ShowSendTrapItems,
					s => s.ShowSystemMessages, s => s.DeathLink
				}},
			new GameSettingCategoryInfo { Name = "Other", Description = "Miscellaneous settings",
				SettingsPerCategory = new List<Func<SettingCollection, GameSetting>> {
					s => s.ShowBestiary
				}}
		};

		public OnOffGameSetting DamageRando = new OnOffGameSetting("Damage Randomizer",
			"Adds a high chance to make orb damage very low, and a low chance to make orb damage very, very high", false);

		public SpecificValuesGameSetting MaxHP = new SpecificValuesGameSetting("Max HP", "Sets the maximum HP Lunais is allowed to have",
			new List<string> { "1", "64", "128", "192", "256", "999" }, "999", false);

		public OnOffGameSetting ShowBestiary = new OnOffGameSetting("Show Bestiary",
			"All bestiary entries in the journal are visible by default.", false, false);

		public SpecificValuesGameSetting LootPool = new SpecificValuesGameSetting("Loot Pool",
			"Sets which items enemies will drop: [Vanilla, Random, Empty]",
			new List<string> { "Vanilla", "Random", "Empty" }, "Vanilla", true);


		public SpecificValuesGameSetting ShopFill = new SpecificValuesGameSetting("Shop Inventory",
			"Sets the items for sale in Merchant Crow's shops. Options: [Default,Random,Vanilla,Empty]",
			new List<string> { "Default", "Random", "Vanilla", "Empty" }, "Default", true);

		public NumberGameSetting ShopMultiplier = new NumberGameSetting("Shop Price Multiplier",
			"Multiplier for the cost of items in the shop. Set to 0 for free shops", 0, 10, 1, 1);

		public OnOffGameSetting ShopWarpShards = new OnOffGameSetting("Always Sell Warp Shards",
			"Shops always sell warp shards (when keys possessed), ignoring inventory setting.", false);

		public NumberGameSetting NumberOfOnScreenLogLines = new NumberGameSetting("Log Number of Lines",
			"Max number of messages to show at the bottom left of the screen, 0 to turn onscreen log off", 0, 25, 1, 3, true);

		public NumberGameSetting OnScreenLogLineScreenTime = new NumberGameSetting("Log Line ScreenTime",
			"How long does a single line shown at the bottom left of the screen stay visible", 1, 10, 0.5, 8, true);

		public OnOffGameSetting ShowSendItemsFromMe = new OnOffGameSetting("Log Items sent by you",
			"Logs items sent from the you to other players", true, true);

		public OnOffGameSetting ShowReceivedItemsFromMe = new OnOffGameSetting("Log Items received by you",
			"Logs items you receive from other players", false, true);

		public OnOffGameSetting ShowSendGenericItems = new OnOffGameSetting("Log Generic Items",
			"Logs Generic items sent between other players", false, true);

		public OnOffGameSetting ShowSendImportantItems = new OnOffGameSetting("Log Important Items",
			"Logs Important items sent between other players", false, true);

		public OnOffGameSetting ShowSendProgressionItems = new OnOffGameSetting("Log Progression Items",
			"Logs Progression items sent between other players", true, true);

		public OnOffGameSetting ShowSendTrapItems = new OnOffGameSetting("Log Trap Items",
			"Logs Traps sent between other players", true, true);

		public OnOffGameSetting ShowSystemMessages = new OnOffGameSetting("Log System Message",
			"Logs System messages, like who connected/left and who changed tags", true, true);

		public ColorGameSetting PastMinimapColor = new ColorGameSetting("Past color",
			"Sets the default color for past minimap rooms", "#486090", true);

		public ColorGameSetting PresentMinimapColor = new ColorGameSetting("Present color",
			"Sets the default color for present minimap rooms", "#802880", true);

		public ColorGameSetting PyramidMinimapColor = new ColorGameSetting("Pyramid color",
			"Sets the default color for ancient pyramid minimap rooms", "#609030", true);

		public ColorGameSetting LootMinimapColor = new ColorGameSetting("Loot color",
			"Sets the color for rooms that have items in them for you", "#C5782A", true);

		public ColorGameSetting SpecailLootMinimapColor = new ColorGameSetting("Special Loot color",
			"Sets the color for rooms that have items in them for you and that are also special rooms like a boss room or transition room", "#F0D840", true);

		public ColorGameSetting SaveStatueMinimapColor = new ColorGameSetting("Save statue color",
			"Sets the color for rooms that have items in them for you", "#D04040", true);

		public ColorGameSetting PresentTransitionMinimapColor = new ColorGameSetting("Present transition color",
			"Sets the color for rooms that have items in them for you", "#1A52FB", true);

		public ColorGameSetting PastTransitionMinimapColor = new ColorGameSetting("Past transition color",
			"Sets the color for rooms that have items in them for you", "#9712C2", true);

		public OnOffGameSetting DeathLink = new OnOffGameSetting("DeathLink",
			"Sets whether DeathLink is on or off", false, true);
	}
}