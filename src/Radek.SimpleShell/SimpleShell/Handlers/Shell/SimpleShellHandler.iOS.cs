﻿#if __IOS__ || MACCATALYST

using Microsoft.Maui.Handlers;
using UIKit;

namespace Radek.SimpleShell.Handlers
{
    public partial class SimpleShellHandler : ViewHandler<ISimpleShell, UIView>
    {
        protected virtual UIView GetNavigationHostContent()
        {
            throw new NotImplementedException();
            //return (navigationHost?.Handler as SimpleNavigationHostHandler)?.Container?.Child as UIView;
        }
    }
}

#endif