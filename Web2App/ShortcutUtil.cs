using IWshRuntimeLibrary;

namespace Web2App
{
    class ShortcutUtil
    {
        public static string CreateShortcut(string shortcutName, string shortcutPath, string targetFilePath, string iconPath, string arguments)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");

            WshShell shell = new WshShell();
            
            IWshShortcut shortcut = (IWshShortcut) shell.CreateShortcut(shortcutLocation);

            shortcut.Description = shortcutName;

            if(!string.IsNullOrWhiteSpace(iconPath))
            {
                shortcut.IconLocation = iconPath;
            }
  
            shortcut.TargetPath = targetFilePath;

            if(!string.IsNullOrWhiteSpace(arguments))
            {
                shortcut.Arguments = arguments;
            }

            shortcut.Save();

            return shortcutLocation;
        }
    }
}
