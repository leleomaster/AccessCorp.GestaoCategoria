using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain.Enum
{
    public enum TipoCampos
    {
        [Description("checkbox")]
        CheckBox = 1,

        [Description("radio")]
        Radio = 2,

        [Description("text")]
        Text = 3,

        [Description("textarea")]
        TextArea = 4,

        [Description("select")]
        Select = 5
    }
}
