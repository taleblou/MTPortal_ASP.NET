

using System;
using System.Collections.Generic;

namespace PayaDB 
{
    // Generated by Telerik OpenAccess
    // Used template: c:\program files\telerik\openaccess orm\sdk\IDEIntegrations\templates\PCClassGeneration\cs\templates\classgen\class\partialdesignerdefault.vm
    [Telerik.OpenAccess.Persistent(IdentityField="settingID")]
    public partial class TModuleDefSetting 
    {
        private int settingID; // pk 

        private string defValue;

        private int moduleDefID;

        private string settingName;

        private string settingValues;

        private TModuleDef tModuleDef;


        

        
    }
}

#region main class file contents
/*


using System;
using System.Collections.Generic;

namespace PayaDB 
{
    //Generated by Telerik OpenAccess
    public partial class TModuleDefSetting 
    {
        //The 'no-args' constructor required by OpenAccess. 
        public TModuleDefSetting() 
        {
        }
    
        [Telerik.OpenAccess.FieldAlias("settingID")]
        public int SettingID
        {
            get { return settingID; }
            set { this.settingID = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("defValue")]
        public string DefValue
        {
            get { return defValue; }
            set { this.defValue = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("moduleDefID")]
        public int ModuleDefID
        {
            get { return moduleDefID; }
            set { this.moduleDefID = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("settingName")]
        public string SettingName
        {
            get { return settingName; }
            set { this.settingName = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("settingValues")]
        public string SettingValues
        {
            get { return settingValues; }
            set { this.settingValues = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("tModuleDef")]
        public TModuleDef TModuleDef
        {
            get { return tModuleDef; }
            set { this.tModuleDef = value; }
        }
 

    }
}
*/
#endregion //main class file contents
