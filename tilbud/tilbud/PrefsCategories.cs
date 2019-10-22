using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class PrefsCategories
    {
        public string Username { get; set; }
        public string Category { get; set; }

        public virtual Users UsernameNavigation { get; set; }
    }
}
