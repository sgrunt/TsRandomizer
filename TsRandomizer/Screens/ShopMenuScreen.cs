﻿using System.Collections;
using System.Linq;
using System.Collections.Generic;
using Timespinner.GameStateManagement.ScreenManager;
using TsRandomizer.Extensions;
using TsRandomizer.IntermediateObjects;
using TsRandomizer.Screens.Menu;
using TsRandomizer.Screens.Settings;

namespace TsRandomizer.Screens
{
	[TimeSpinnerType("Timespinner.GameStateManagement.Screens.Shop.ShopMenuScreen")]
	// ReSharper disable once UnusedMember.Global
	class ShopMenuScreen : Screen
	{
		public ShopMenuScreen(ScreenManager screenManager, GameScreen screen) : base(screenManager, screen)
		{
			GameSettingsCollection gameSettings = new GameSettingsCollection();
			gameSettings.LoadSettingsFromFile();
			double shopMultiplier = (double)gameSettings.ShopMultiplier.CurrentValue;
			// Menu count varies on relics/items/equipment etc. being in inventory
			// Last menu is always helper functions that don't have an _items
			// but aren't otherwise distinguishable
			foreach (int i in Enumerable.Range(0, ((IList)Dynamic._subMenuCollections).Count - 1))
			{
				var shopMenu = ((IList)Dynamic._subMenuCollections)[i].AsDynamic();
				foreach (object shopMenuEntry in shopMenu._items)
				{
					int currentPrice = shopMenuEntry.AsDynamic().ShopPrice;
					if (currentPrice == 0)
					{
						// Set a price for "priceless" items
						shopMenuEntry.AsDynamic().ShopPrice = 2000;
						currentPrice = shopMenuEntry.AsDynamic().ShopPrice;
					}
					shopMenuEntry.AsDynamic().ShopPrice = (int)(currentPrice * shopMultiplier);
				}
			}
		}
	}
}
