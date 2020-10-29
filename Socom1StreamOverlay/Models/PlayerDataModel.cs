using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socom1StreamOverlay.Models
{
    public class PlayerDataModel
    {
        public string _PlayerName { get; set; }
        public string _Team { get; set; }
        public string _LivingStatus { get; set; }
        public decimal _PlayerHealth { get; set; }
        public IntPtr _pointerAddress { get; set; }
        public int _hasMPBomb { get; set; }
    }
}
