

using System;
using System.Collections.Generic;

namespace PayaDB 
{
    // Generated by Telerik OpenAccess
    // Used template: c:\program files\telerik\openaccess orm\sdk\IDEIntegrations\templates\PCClassGeneration\cs\templates\classgen\class\partialdesignerdefault.vm
    [Telerik.OpenAccess.Persistent(IdentityField="userID")]
    public partial class TUser 
    {
        private int userID; // pk 

        private string email;

        private string firstName;

        private bool isLocked;

        private bool isSuperUser;

        private string lastName;

        private int? portalID;

        private string userName;

        private string userPass;

        private string userStyle;

        private TPortal tPortal;


        

        
    }
}

#region main class file contents
/*


using System;
using System.Collections.Generic;

namespace PayaDB 
{
    //Generated by Telerik OpenAccess
    public partial class TUser 
    {
        //The 'no-args' constructor required by OpenAccess. 
        public TUser() 
        {
        }
    
        [Telerik.OpenAccess.FieldAlias("userID")]
        public int UserID
        {
            get { return userID; }
            set { this.userID = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("email")]
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("firstName")]
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("isLocked")]
        public bool IsLocked
        {
            get { return isLocked; }
            set { this.isLocked = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("isSuperUser")]
        public bool IsSuperUser
        {
            get { return isSuperUser; }
            set { this.isSuperUser = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("lastName")]
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("portalID")]
        public int PortalID
        {
            get { return portalID; }
            set { this.portalID = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("userName")]
        public string UserName
        {
            get { return userName; }
            set { this.userName = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("userPass")]
        public string UserPass
        {
            get { return userPass; }
            set { this.userPass = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("userStyle")]
        public string UserStyle
        {
            get { return userStyle; }
            set { this.userStyle = value; }
        }
 
        [Telerik.OpenAccess.FieldAlias("tPortal")]
        public TPortal TPortal
        {
            get { return tPortal; }
            set { this.tPortal = value; }
        }
 

    }
}
*/
#endregion //main class file contents
