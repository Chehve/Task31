/*using static GameController;
using static UtilityFunctions;
using static GameResources;
using static DeploymentController;
using static DiscoveryController;
using static EndingGameController;
using static MenuController;
using static HighScoreController;
*/
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;
namespace BattleShips
{
	static class GameLogic
	{
		public static void Main ()
		{
			//Opens a new Graphics Window
			SwinGame.OpenGraphicsWindow ("Battle Ships", 800, 600);

			//Load Resources
			GameResources.LoadResources ();

			SwinGame.PlayMusic (GameResources.GameMusic ("Background"));

			//Game Loop
			do {
				GameController.HandleUserInput ();
				GameController.DrawScreen ();
			} while (!(SwinGame.WindowCloseRequested () == true | GameController.CurrentState == GameState.Quitting));

			SwinGame.StopMusic ();

			//Free Resources and Close Audio, to end the program.
			GameResources.FreeResources ();
		}
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
