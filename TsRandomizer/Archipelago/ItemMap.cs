﻿using System;
using System.Collections.Generic;
using Timespinner.GameAbstractions.Inventory;
using Timespinner.GameObjects.BaseClasses;
using TsRandomizer.IntermediateObjects;
using TsRandomizer.IntermediateObjects.CustomItems;

namespace TsRandomizer.Archipelago
{
	static class ItemMap
	{
		static readonly Dictionary<long, ItemIdentifier> MapItemIdToItemItemIdentifier;
		static readonly Dictionary<ItemIdentifier, long> MapItemIdentifierToItemId;

		static ItemMap()
		{
			MapItemIdToItemItemIdentifier = new Dictionary<long, ItemIdentifier>(182) {
				{1337000, new ItemIdentifier(EInventoryEquipmentType.EternalTiara)},
				{1337001, new ItemIdentifier(EInventoryEquipmentType.SecurityVisor)},
				{1337002, new ItemIdentifier(EInventoryEquipmentType.EngineerGoggles)},
				{1337003, new ItemIdentifier(EInventoryEquipmentType.LeatherHelmet)},
				{1337004, new ItemIdentifier(EInventoryEquipmentType.CopperHelmet)},
				{1337005, new ItemIdentifier(EInventoryEquipmentType.PointyHat)},
				{1337006, new ItemIdentifier(EInventoryEquipmentType.CalvaryHelmet)},
				{1337007, new ItemIdentifier(EInventoryEquipmentType.BuckleHat)},
				{1337008, new ItemIdentifier(EInventoryEquipmentType.AdvisorHat)},
				{1337009, new ItemIdentifier(EInventoryEquipmentType.LibrarianHat)},
				{1337010, new ItemIdentifier(EInventoryEquipmentType.CombatHelmet)},
				{1337011, new ItemIdentifier(EInventoryEquipmentType.CaptainsCap)},
				{1337012, new ItemIdentifier(EInventoryEquipmentType.LabGlasses)},
				{1337013, new ItemIdentifier(EInventoryEquipmentType.LachiemCrown)},
				{1337014, new ItemIdentifier(EInventoryEquipmentType.VileteCrown)},
				{1337015, new ItemIdentifier(EInventoryEquipmentType.Sunglasses)},
				{1337016, new ItemIdentifier(EInventoryEquipmentType.OldCoat)},
				{1337017, new ItemIdentifier(EInventoryEquipmentType.TrendyJacket)},
				{1337018, new ItemIdentifier(EInventoryEquipmentType.SecurityVest)},
				{1337019, new ItemIdentifier(EInventoryEquipmentType.LeatherArmor)},
				{1337020, new ItemIdentifier(EInventoryEquipmentType.CopperArmor)},
				{1337021, new ItemIdentifier(EInventoryEquipmentType.TravelersCloak)},
				{1337022, new ItemIdentifier(EInventoryEquipmentType.CalvaryArmor)},
				{1337023, new ItemIdentifier(EInventoryEquipmentType.MidnightCloak)},
				{1337024, new ItemIdentifier(EInventoryEquipmentType.AdvisorRobe)},
				{1337025, new ItemIdentifier(EInventoryEquipmentType.LibrarianRobe)},
				{1337026, new ItemIdentifier(EInventoryEquipmentType.MilitaryArmor)},
				{1337027, new ItemIdentifier(EInventoryEquipmentType.CaptainsJacket)},
				{1337028, new ItemIdentifier(EInventoryEquipmentType.LabCoat)},
				{1337029, new ItemIdentifier(EInventoryEquipmentType.EmpressCoat)},
				{1337030, new ItemIdentifier(EInventoryEquipmentType.VileteDress)},
				{1337031, new ItemIdentifier(EInventoryEquipmentType.EternalCoat)},
				{1337032, new ItemIdentifier(EInventoryEquipmentType.SyntheticPlume)},
				{1337033, new ItemIdentifier(EInventoryEquipmentType.CheveuxPlume)},
				{1337034, new ItemIdentifier(EInventoryEquipmentType.MetalWristband)},
				{1337035, new ItemIdentifier(EInventoryEquipmentType.SirenHairband)},
				{1337036, new ItemIdentifier(EInventoryEquipmentType.MotherOfPearl)},
				{1337037, new ItemIdentifier(EInventoryEquipmentType.BirdStatue)},
				{1337038, new ItemIdentifier(EInventoryEquipmentType.DemonStole)},
				{1337039, new ItemIdentifier(EInventoryEquipmentType.Pendulum)},
				{1337040, new ItemIdentifier(EInventoryEquipmentType.DemonHorn)},
				{1337041, new ItemIdentifier(EInventoryEquipmentType.FiligreeClasp)},
				{1337042, new ItemIdentifier(EInventoryEquipmentType.AzureStole)},
				{1337043, new ItemIdentifier(EInventoryEquipmentType.LuckyCoin)},
				{1337044, new ItemIdentifier(EInventoryEquipmentType.ShinyRock)},
				{1337045, new ItemIdentifier(EInventoryEquipmentType.NelisteEarring)},
				{1337046, new ItemIdentifier(EInventoryEquipmentType.SelenBangle)},
				{1337047, new ItemIdentifier(EInventoryEquipmentType.GlassPumpkin)},
				{1337048, new ItemIdentifier(EInventoryEquipmentType.FamiliarEgg)},
				{1337049, new ItemIdentifier(EInventoryFamiliarType.Meyef)},
				{1337050, new ItemIdentifier(EInventoryFamiliarType.Griffin)},
				{1337051, new ItemIdentifier(EInventoryFamiliarType.MerchantCrow)},
				{1337052, new ItemIdentifier(EInventoryFamiliarType.Kobo)},
				{1337053, new ItemIdentifier(EInventoryFamiliarType.Sprite)},
				{1337054, new ItemIdentifier(EInventoryFamiliarType.Demon)},
				{1337055, new ItemIdentifier(EInventoryUseItemType.Potion)},
				{1337056, new ItemIdentifier(EInventoryUseItemType.Ether)},
				{1337057, new ItemIdentifier(EInventoryUseItemType.SandBottle)},
				{1337058, new ItemIdentifier(EInventoryUseItemType.HiPotion)},
				{1337059, new ItemIdentifier(EInventoryUseItemType.HiEther)},
				{1337060, new ItemIdentifier(EInventoryUseItemType.HiSandBottle)},
				{1337061, new ItemIdentifier(EInventoryUseItemType.FuturePotion)},
				{1337062, new ItemIdentifier(EInventoryUseItemType.FutureHiPotion)},
				{1337063, new ItemIdentifier(EInventoryUseItemType.FutureEther)},
				{1337064, new ItemIdentifier(EInventoryUseItemType.FutureHiEther)},
				{1337065, new ItemIdentifier(EInventoryUseItemType.Antidote)},
				{1337066, new ItemIdentifier(EInventoryUseItemType.ChaosHeal)},
				{1337067, new ItemIdentifier(EInventoryUseItemType.WarpCard)},
				{1337068, new ItemIdentifier(EInventoryUseItemType.FamiliarTreat)},
				{1337069, new ItemIdentifier(EInventoryUseItemType.PlaceHolderItem1)},
				{1337070, new ItemIdentifier(EInventoryUseItemType.LachiemiSun)},
				{1337071, new ItemIdentifier(EInventoryUseItemType.Jerky)},
				{1337072, new ItemIdentifier(EInventoryUseItemType.Biscuit)},
				{1337073, new ItemIdentifier(EInventoryUseItemType.FriedCheveux)},
				{1337074, new ItemIdentifier(EInventoryUseItemType.SauteedTail)},
				{1337075, new ItemIdentifier(EInventoryUseItemType.UnagiRoll)},
				{1337076, new ItemIdentifier(EInventoryUseItemType.CheveuxAuVin)},
				{1337077, new ItemIdentifier(EInventoryUseItemType.Casserole)},
				{1337078, new ItemIdentifier(EInventoryUseItemType.Spaghetti)},
				{1337079, new ItemIdentifier(EInventoryUseItemType.PlumpMaggot)},
				{1337080, new ItemIdentifier(EInventoryUseItemType.OrangeJuice)},
				{1337081, new ItemIdentifier(EInventoryUseItemType.FiligreeTea)},
				{1337082, new ItemIdentifier(EInventoryUseItemType.EmpressCake)},
				{1337083, new ItemIdentifier(EInventoryUseItemType.RottenTail)},
				{1337084, new ItemIdentifier(EInventoryUseItemType.AlchemistTools)},
				{1337085, new ItemIdentifier(EInventoryUseItemType.GalaxyStone)},
				{1337086, new ItemIdentifier(EInventoryUseItemType.MagicMarbles)},
				{1337087, new ItemIdentifier(EInventoryUseItemType.EssenceCrystal)},
				{1337088, new ItemIdentifier(EInventoryUseItemType.GoldRing)},
				{1337089, new ItemIdentifier(EInventoryUseItemType.GoldNecklace)},
				{1337090, new ItemIdentifier(EInventoryUseItemType.Herb)},
				{1337091, new ItemIdentifier(EInventoryUseItemType.Mushroom)},
				{1337092, new ItemIdentifier(EInventoryUseItemType.RadiationCrystal)},
				{1337093, new ItemIdentifier(EInventoryUseItemType.PlasmaIV)},
				{1337094, new ItemIdentifier(EInventoryUseItemType.Drumstick)},
				{1337095, new ItemIdentifier(EInventoryUseItemType.WyvernTail)},
				{1337096, new ItemIdentifier(EInventoryUseItemType.EelMeat)},
				{1337097, new ItemIdentifier(EInventoryUseItemType.CheveuxBreast)},
				{1337098, new ItemIdentifier(EInventoryUseItemType.FoodSynth)},
				{1337099, new ItemIdentifier(EInventoryUseItemType.CheveuxFeather)},
				{1337100, new ItemIdentifier(EInventoryUseItemType.SirenInk)},
				{1337101, new ItemIdentifier(EInventoryUseItemType.PlasmaCore)},
				{1337102, new ItemIdentifier(EInventoryUseItemType.SilverOre)},
				{1337103, new ItemIdentifier(EInventoryUseItemType.HistoricalDocuments)},
				{1337104, new ItemIdentifier(EInventoryUseItemType.MapReveal0)},
				{1337105, new ItemIdentifier(EInventoryUseItemType.MapReveal1)},
				{1337106, new ItemIdentifier(EInventoryUseItemType.MapReveal2)},
				{1337107, new ItemIdentifier(EInventoryRelicType.TimespinnerWheel)},
				{1337108, new ItemIdentifier(EInventoryRelicType.TimespinnerSpindle)},
				{1337109, new ItemIdentifier(EInventoryRelicType.TimespinnerGear1)},
				{1337110, new ItemIdentifier(EInventoryRelicType.TimespinnerGear2)},
				{1337111, new ItemIdentifier(EInventoryRelicType.TimespinnerGear3)},
				{1337112, new ItemIdentifier(EInventoryRelicType.PyramidsKey)},
				{1337113, new ItemIdentifier(EInventoryRelicType.EssenceOfSpace)},
				{1337114, new ItemIdentifier(EInventoryRelicType.DoubleJump)},
				{1337115, new ItemIdentifier(EInventoryRelicType.Dash)},
				{1337116, new ItemIdentifier(EInventoryRelicType.WaterMask)},
				{1337117, new ItemIdentifier(EInventoryRelicType.AirMask)},
				{1337118, new ItemIdentifier(EInventoryRelicType.FoeScanner)},
				{1337119, new ItemIdentifier(EInventoryRelicType.ScienceKeycardA)},
				{1337120, new ItemIdentifier(EInventoryRelicType.ScienceKeycardB)},
				{1337121, new ItemIdentifier(EInventoryRelicType.ScienceKeycardC)},
				{1337122, new ItemIdentifier(EInventoryRelicType.ScienceKeycardD)},
				{1337123, new ItemIdentifier(EInventoryRelicType.ScienceKeycardV)},
				{1337124, new ItemIdentifier(EInventoryRelicType.Tablet)},
				{1337125, new ItemIdentifier(EInventoryRelicType.ElevatorKeycard)},
				{1337126, new ItemIdentifier(EInventoryRelicType.JewelryBox)},
				{1337127, new ItemIdentifier(EInventoryRelicType.EternalBrooch)},
				{1337128, new ItemIdentifier(EInventoryRelicType.FamiliarAltMeyef)},
				{1337129, new ItemIdentifier(EInventoryRelicType.FamiliarAltCrow)},
				{1337130, new ItemIdentifier(EInventoryRelicType.EmpireBrooch)},
				{1337131, new ItemIdentifier(EInventoryOrbType.Blue, EOrbSlot.Melee)},
				{1337132, new ItemIdentifier(EInventoryOrbType.Blade, EOrbSlot.Melee)},
				{1337133, new ItemIdentifier(EInventoryOrbType.Flame, EOrbSlot.Melee)},
				{1337134, new ItemIdentifier(EInventoryOrbType.Pink, EOrbSlot.Melee)},
				{1337135, new ItemIdentifier(EInventoryOrbType.Iron, EOrbSlot.Melee)},
				{1337136, new ItemIdentifier(EInventoryOrbType.Ice, EOrbSlot.Melee)},
				{1337137, new ItemIdentifier(EInventoryOrbType.Wind, EOrbSlot.Melee)},
				{1337138, new ItemIdentifier(EInventoryOrbType.Gun, EOrbSlot.Melee)},
				{1337139, new ItemIdentifier(EInventoryOrbType.Umbra, EOrbSlot.Melee)},
				{1337140, new ItemIdentifier(EInventoryOrbType.Empire, EOrbSlot.Melee)},
				{1337141, new ItemIdentifier(EInventoryOrbType.Eye, EOrbSlot.Melee)},
				{1337142, new ItemIdentifier(EInventoryOrbType.Blood, EOrbSlot.Melee)},
				{1337143, new ItemIdentifier(EInventoryOrbType.Book, EOrbSlot.Melee)},
				{1337144, new ItemIdentifier(EInventoryOrbType.Moon, EOrbSlot.Melee)},
				{1337145, new ItemIdentifier(EInventoryOrbType.Nether, EOrbSlot.Melee)},
				{1337146, new ItemIdentifier(EInventoryOrbType.Barrier, EOrbSlot.Melee)},
				{1337147, new ItemIdentifier(EInventoryOrbType.Blue, EOrbSlot.Spell)},
				{1337148, new ItemIdentifier(EInventoryOrbType.Blade, EOrbSlot.Spell)},
				{1337149, new ItemIdentifier(EInventoryOrbType.Flame, EOrbSlot.Spell)},
				{1337150, new ItemIdentifier(EInventoryOrbType.Pink, EOrbSlot.Spell)},
				{1337151, new ItemIdentifier(EInventoryOrbType.Iron, EOrbSlot.Spell)},
				{1337152, new ItemIdentifier(EInventoryOrbType.Ice, EOrbSlot.Spell)},
				{1337153, new ItemIdentifier(EInventoryOrbType.Wind, EOrbSlot.Spell)},
				{1337154, new ItemIdentifier(EInventoryOrbType.Gun, EOrbSlot.Spell)},
				{1337155, new ItemIdentifier(EInventoryOrbType.Umbra, EOrbSlot.Spell)},
				{1337156, new ItemIdentifier(EInventoryOrbType.Empire, EOrbSlot.Spell)},
				{1337157, new ItemIdentifier(EInventoryOrbType.Eye, EOrbSlot.Spell)},
				{1337158, new ItemIdentifier(EInventoryOrbType.Blood, EOrbSlot.Spell)},
				{1337159, new ItemIdentifier(EInventoryOrbType.Book, EOrbSlot.Spell)},
				{1337160, new ItemIdentifier(EInventoryOrbType.Moon, EOrbSlot.Spell)},
				{1337161, new ItemIdentifier(EInventoryOrbType.Nether, EOrbSlot.Spell)},
				{1337162, new ItemIdentifier(EInventoryOrbType.Barrier, EOrbSlot.Spell)},
				{1337163, new ItemIdentifier(EInventoryOrbType.Blue, EOrbSlot.Passive)},
				{1337164, new ItemIdentifier(EInventoryOrbType.Blade, EOrbSlot.Passive)},
				{1337165, new ItemIdentifier(EInventoryOrbType.Flame, EOrbSlot.Passive)},
				{1337166, new ItemIdentifier(EInventoryOrbType.Pink, EOrbSlot.Passive)},
				{1337167, new ItemIdentifier(EInventoryOrbType.Iron, EOrbSlot.Passive)},
				{1337168, new ItemIdentifier(EInventoryOrbType.Ice, EOrbSlot.Passive)},
				{1337169, new ItemIdentifier(EInventoryOrbType.Wind, EOrbSlot.Passive)},
				{1337170, new ItemIdentifier(EInventoryOrbType.Gun, EOrbSlot.Passive)},
				{1337171, new ItemIdentifier(EInventoryOrbType.Umbra, EOrbSlot.Passive)},
				{1337172, new ItemIdentifier(EInventoryOrbType.Empire, EOrbSlot.Passive)},
				{1337173, new ItemIdentifier(EInventoryOrbType.Eye, EOrbSlot.Passive)},
				{1337174, new ItemIdentifier(EInventoryOrbType.Blood, EOrbSlot.Passive)},
				{1337175, new ItemIdentifier(EInventoryOrbType.Book, EOrbSlot.Passive)},
				{1337176, new ItemIdentifier(EInventoryOrbType.Moon, EOrbSlot.Passive)},
				{1337177, new ItemIdentifier(EInventoryOrbType.Nether, EOrbSlot.Passive)},
				{1337178, new ItemIdentifier(EInventoryOrbType.Barrier, EOrbSlot.Passive)},
				{1337179, new ItemIdentifier(EItemType.MaxHP)},
				{1337180, new ItemIdentifier(EItemType.MaxAura)},

				{1337181, CustomItem.GetIdentifier(CustomItemType.TimewornWarpBeacon)},
				{1337182, CustomItem.GetIdentifier(CustomItemType.ModernWarpBeacon)},
				{1337183, CustomItem.GetIdentifier(CustomItemType.MysteriousWarpBeacon)},
				{1337184, CustomItem.GetIdentifier(CustomItemType.MeteorSparrowTrap)},
				{1337185, CustomItem.GetIdentifier(CustomItemType.PoisonTrap)},
				{1337186, CustomItem.GetIdentifier(CustomItemType.ChaosTrap)},
				{1337187, CustomItem.GetIdentifier(CustomItemType.NeurotoxinTrap)},
				{1337188, CustomItem.GetIdentifier(CustomItemType.BeeTrap)},

				// 1337189 - 1337248 Reserved

				{1337249, new ItemIdentifier(EItemType.MaxSand)}
			};

			MapItemIdentifierToItemId = new Dictionary<ItemIdentifier, long>(MapItemIdToItemItemIdentifier.Count);

			foreach (var kvp in MapItemIdToItemItemIdentifier)
				MapItemIdentifierToItemId.Add(kvp.Value, kvp.Key);
		}

		public static long GetItemId(ItemIdentifier itemIdentifier) =>
			MapItemIdentifierToItemId.TryGetValue(itemIdentifier, out var locationId)
				? locationId
				: throw new Exception("itemIdentifier does not map to Archipelago itemId");


		public static ItemIdentifier GetItemIdentifier(long itemId) =>
			MapItemIdToItemItemIdentifier.TryGetValue(itemId, out var key)
				? key
				: new ItemIdentifier(EInventoryUseItemType.EssenceCrystal);
	}
}
