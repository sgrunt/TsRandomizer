﻿using System;
using System.Collections.Generic;
using Timespinner.GameAbstractions.Gameplay;
using Timespinner.GameObjects.BaseClasses;
using TsRandomizer.Extensions;
using TsRandomizer.Randomisation;

namespace TsRandomizer.LevelObjects
{
    class DialogueReplacer
    {
        public Dictionary<Roomkey, Action> Overrides;
        public DialogueReplacer(Level level, SeedOptions options)
        {
			Overrides.Add(new Roomkey(16, 27), () =>
			{
				int concussions = level.GameSave.GetConcussionCount();
				string replacement = "What—? I know I didn't hit my head...";
				switch (concussions)
				{
					case 1:
						replacement = "What—? I feel like I've suffered a concussion...";
						break;
					case int c when (c > 1):
						replacement =
							string.Format("What—? I feel like I've suffered {0} concussions...",
							concussions);
						break;
				}
				TimeSpinnerGame.Localizer.OverrideKey("cs_tem_1_lun_01", replacement);
			});
			Overrides.Add(new Roomkey(2, 51), () =>
			{
				if (options.GyreArchives)
				{
					TimeSpinnerGame.Localizer.OverrideKey("cs_pro_lun_02",
					"Yorne? Oh... not quite. Is this... his memory?");
					TimeSpinnerGame.Localizer.OverrideKey("cs_pro_yor_03",
						"I still can't believe they picked *her*, I deserved this.");
					TimeSpinnerGame.Localizer.OverrideKey("cs_pro_lun_04",
						"*sigh* Even as just a reflection... Yorne is still as Yorne as ever.");
					TimeSpinnerGame.Localizer.OverrideKey("cs_pro_yor_05",
						"I have to find where that Kobo has run off to.");
					TimeSpinnerGame.Localizer.OverrideKey("cs_pro_lun_06",
						"'Kobo'... There's no one in our village by that name... I don't think this 'memory' is real.");
				}
			});
			Overrides.Add(new Roomkey(11, 4), () =>
			{
				if (options.GyreArchives)
					TimeSpinnerGame.Localizer.OverrideKey("q_ram_4_lun_29alt",
						"It says, 'Redacted Temporal Research: Lord of Ravens'. Maybe I should ask the crow about this...");
			});
		}
    }
}
