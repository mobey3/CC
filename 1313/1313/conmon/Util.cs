using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1313.conmon
{
    class Util
    {
        public static void initTheme(Form form)
        {
            var mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(form as MaterialForm);
            mgr.Theme =
                MaterialSkinManager.Themes.LIGHT;
            mgr.ColorScheme =
                new ColorScheme(Primary.Grey400,
                Primary.Grey400,    // 경계선 밑 
                Primary.Grey400,
                Accent.Indigo700,
                TextShade.WHITE);
        }
    }
}
