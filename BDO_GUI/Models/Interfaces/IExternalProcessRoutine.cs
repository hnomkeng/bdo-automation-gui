﻿using System.Collections.Generic;

namespace BDO_GUI.Models.Interfaces
{
    public interface IExternalProcessRoutine
    {
        bool UseVenecil { get; set; }
        bool UseContainer { get; set; }
        IList<IList<string>> Processable { get; set; }
        IList<IList<string>> Items { get; set; }
    }
}
