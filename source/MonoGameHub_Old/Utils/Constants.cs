using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameHub.Utils
{
    internal static class Constants
    {
        //---------------------------------------------------
        //  Guid References
        //---------------------------------------------------
        public static readonly string GUID_CSHARP = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";

        //---------------------------------------------------
        //  File IO References
        //---------------------------------------------------
        public static readonly string DATA_ROOT_DIR =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MonoGameHub");

        public static readonly string DATA_PROJECTS_FILENAME = "projects_list.bin";
    }
}
