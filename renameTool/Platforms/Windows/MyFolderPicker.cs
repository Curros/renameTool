using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFolderPicker = Windows.Storage.Pickers.FolderPicker;

namespace renameTool.Platforms.Windows
{
    public class MyFolderPicker : IFolderPicker
    {
        public string MyPickFolder()
        {
            var folderPicker = new WindowsFolderPicker();

            // Get the current window's HWND by passing in the Window object
            var hwnd = ((MauiWinUIWindow)App.Current.Windows[0].Handler.PlatformView).WindowHandle;

            // Associate the HWND with the file picker
            WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hwnd);

            var result = folderPicker.PickSingleFolderAsync().GetAwaiter().GetResult();

            return result?.Path;
        }
    }
}
