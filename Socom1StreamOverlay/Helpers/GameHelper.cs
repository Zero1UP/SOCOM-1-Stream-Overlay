using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Socom1StreamOverlay.Helpers
{
    public static class GameHelper
    {
        //Player Object Data
        public static  IntPtr PLAYER_POINTER_ADDRESS = new IntPtr(0x2048D548);
        public const int PLAYER_NAME_OFFSET = 0x14;
        public const int PLAYER_TEAMID_OFFSET = 0xC4;
        public const int PLAYER_HEALTH_OFFSET = 0xED0;

        //Player index
        //Notes (Thanks to harry for the original code from S2)
        //Functions the same as SOCOM 2
        //0x0 = Next player in the index (if the index = memory address then we are done)
        //0x8 = Player pointer
        public static IntPtr PLAYER_INDEX_POINTER_ADDRESS = new IntPtr(0x204D46A4);
        public const int PLAYER_INDEX_PLAYER_POINTER_OFFSET = 8;


        //Game information
        public static IntPtr ROUND_TIMER = new IntPtr(0x20578100);

        public static IntPtr SEAL_WIN_COUNTER_ADDRESS = new IntPtr(0x205D7514);
        public static IntPtr TERR_WIN_COUNTER_ADDRESS = new IntPtr(0x205D7528);
        public static IntPtr SEALS_ALIVE_COUNTER_ADDRESS = new IntPtr(0x205D70DC);
        public static IntPtr TERR_ALIVE_COUNTER_ADDRESS = new IntPtr(0x205D70F0);

        public static IntPtr DISABLE_SPEC_LETTERBOX = new IntPtr(0x203DD2A4);

        //Don't currently have
        public static IntPtr GAME_ENDED_ADDRESS = new IntPtr(0x205D708C);

        //This has some issues with the camera repositioning when swaping to a new player. Need to look further into
        public static IntPtr SPECTATOR_CAMERA_POINTER_ADDRESS = new IntPtr(0x2048D488);
        public const int SPECTATOR_CAMERA_POINTER_OFFSET1 = 0x3C; //Write player pointer
        public const int SPECTATOR_CAMERA_POINTER_OFFSET2 = 0x40; //Write ??


        //Game has no concept of a sepctator
        public static string GetTeamName(string value)
        {
            if (value == "40000001")
            {
                return "SEALS";
            }
            else if (value == "80000100")
            {
                return "TERRORISTS";
            }
            else
            {
                return "N/A";
            }
        }
    }
}
