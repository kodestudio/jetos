using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace JetOS
{
    class SystemProcess
    {
        public void InitFileSystem()
        {
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }
    }
}
