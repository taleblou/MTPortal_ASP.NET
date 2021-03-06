using System;

namespace PayaDB
{
    // Generated by Telerik OpenAccess
    // Used template: c:\program files (x86)\telerik\openaccess orm\sdk\IDEIntegrations\templates\PCClassGeneration\cs\templates\classgen\class\partialuserdefault.vm
    // NOTE: Field declarations and 'Object ID' class implementation are added to the 'designer' file.
    //       Changes made to the 'designer' file will be overwritten by the wizard.  	
    public partial class TUserCustomProfile
    {
        //The 'no-args' constructor required by OpenAccess. 
        public TUserCustomProfile()
        {
        }

        [Telerik.OpenAccess.FieldAlias("userID")]
        public int UserID
        {
            get { return userID; }
            set { this.userID = value; }
        }

        [Telerik.OpenAccess.FieldAlias("address")]
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }

        [Telerik.OpenAccess.FieldAlias("birthDate")]
        public DateTime? BirthDate
        {
            get { return birthDate; }
            set { this.birthDate = value; }
        }

        [Telerik.OpenAccess.FieldAlias("certificateNumber")]
        public string CertificateNumber
        {
            get { return certificateNumber; }
            set { this.certificateNumber = value; }
        }

        [Telerik.OpenAccess.FieldAlias("failedPasswordAttemptCount")]
        public int? FailedPasswordAttemptCount
        {
            get { return failedPasswordAttemptCount; }
            set { this.failedPasswordAttemptCount = value; }
        }

        [Telerik.OpenAccess.FieldAlias("failedPasswordAttemptStart")]
        public DateTime? FailedPasswordAttemptStart
        {
            get { return failedPasswordAttemptStart; }
            set { this.failedPasswordAttemptStart = value; }
        }

        [Telerik.OpenAccess.FieldAlias("hasChangedPassword")]
        public bool HasChangedPassword
        {
            get { return hasChangedPassword; }
            set { this.hasChangedPassword = value; }
        }

        [Telerik.OpenAccess.FieldAlias("lastLockoutDate")]
        public DateTime? LastLockoutDate
        {
            get { return lastLockoutDate; }
            set { this.lastLockoutDate = value; }
        }

        [Telerik.OpenAccess.FieldAlias("lastLoginDate")]
        public DateTime? LastLoginDate
        {
            get { return lastLoginDate; }
            set { this.lastLoginDate = value; }
        }

        [Telerik.OpenAccess.FieldAlias("lastPasswordChangeDate")]
        public DateTime? LastPasswordChangeDate
        {
            get { return lastPasswordChangeDate; }
            set { this.lastPasswordChangeDate = value; }
        }

        [Telerik.OpenAccess.FieldAlias("mobile")]
        public string Mobile
        {
            get { return mobile; }
            set { this.mobile = value; }
        }

        [Telerik.OpenAccess.FieldAlias("nationalNumber")]
        public string NationalNumber
        {
            get { return nationalNumber; }
            set { this.nationalNumber = value; }
        }

        [Telerik.OpenAccess.FieldAlias("picture")]
        public byte[] Picture
        {
            get { return picture; }
            set { this.picture = value; }
        }

        [Telerik.OpenAccess.FieldAlias("sex")]
        public bool Sex
        {
            get { return sex; }
            set { this.sex = value; }
        }

        [Telerik.OpenAccess.FieldAlias("tel")]
        public string Tel
        {
            get { return tel; }
            set { this.tel = value; }
        }

        [Telerik.OpenAccess.FieldAlias("zipCode")]
        public string ZipCode
        {
            get { return zipCode; }
            set { this.zipCode = value; }
        }

        [Telerik.OpenAccess.FieldAlias("tUser")]
        public TUser TUser
        {
            get { return tUser; }
            set { this.tUser = value; }
        }


    }
}
