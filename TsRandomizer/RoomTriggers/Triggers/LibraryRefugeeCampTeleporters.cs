﻿using Timespinner.GameAbstractions.Inventory;
using TsRandomizer.Extensions;

namespace TsRandomizer.RoomTriggers.Triggers
{
	[RoomTriggerTrigger(2, 54)]
	class LibraryTeleporter : RoomTrigger
	{
		public override void OnRoomLoad(RoomState roomState)
		{
			if (roomState.SeedOptions.Inverted
			    || roomState.Level.GameSave.HasRelic(EInventoryRelicType.PyramidsKey)
			    || !roomState.Level.GameSave.DataKeyBools.ContainsKey("HasUsedCityTS")) 
				return;

			RoomTriggerHelper.CreateSimpleOneWayWarp(roomState.Level, 3, 6);
		}
	}

	[RoomTriggerTrigger(3, 6)]
	class RefugeeCampTeleporter : RoomTrigger
	{
		public override void OnRoomLoad(RoomState roomState)
		{
			if (roomState.SeedOptions.Inverted 
			    || roomState.Level.GameSave.HasRelic(EInventoryRelicType.PyramidsKey)) 
				return;
			
			RoomTriggerHelper.CreateSimpleOneWayWarp(roomState.Level, 2, 54);
		}
	}
}