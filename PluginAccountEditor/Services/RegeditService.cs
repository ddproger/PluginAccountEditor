using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAccountEditor.Services
{
    public class RegeditService
    {
        RegistryKey reg = Registry.CurrentUser;
        private const string OPEN_FILE_PATH = "OpenFilePath";
        private const string PATH_TO_RESOURCE = "ResourceFilePath";
        private const string PATH_TO_NEW_FILE = "NewFilePath";

        public string getOpenFilePath()
        {
            return getKeyValue(OPEN_FILE_PATH);
        }

        public void setOpenFilePath(string path)
        {
            setKeyValue(OPEN_FILE_PATH, path);
        }
        public string getResourceFilePath()
        {
            return getKeyValue(PATH_TO_RESOURCE);
        }

        public void setResourceFilePath(string path)
        {
            setKeyValue(PATH_TO_RESOURCE, path);
        }
        public string getNewFilePath()
        {
            return getKeyValue(PATH_TO_NEW_FILE);
        }

        public void setNewFilePath(string path)
        {
            setKeyValue(PATH_TO_NEW_FILE, path);
        }
        private string getKeyValue(String key)
        {
            return (String)reg.GetValue(key, "");
        }
        private void setKeyValue(String key, string value)
        {
            if (key == null || value == null || key.Equals("") || value.Equals("")) return;

            reg.SetValue(key, value, RegistryValueKind.String);
        }
    }
}
