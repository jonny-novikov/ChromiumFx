﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chromium.Remote.Event {

    // this is a hack to make the shared mayblock event work in the remote interface.
    // it works because there are no out parameters in that event.

    partial class CfrMayBlockEventArgs {
        internal CfrMayBlockEventArgs(CfxWriteHandlerMayBlockRemoteEventCall call) {
            this.call = new CfxReadHandlerMayBlockRemoteEventCall();
        }
    }
}