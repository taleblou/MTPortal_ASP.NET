using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.OpenAccess;

namespace PayaDB
{
    // Generated by Telerik OpenAccess
    // Used template: c:\program files (x86)\telerik\openaccess orm\sdk\IDEIntegrations\templates\PCClassGeneration\cs\templates\classgen\class\partialuserdefault.vm
    // NOTE: Field declarations and 'Object ID' class implementation are added to the 'designer' file.
    //       Changes made to the 'designer' file will be overwritten by the wizard.  	
    public partial class TRegisterReq
    {
        //The 'no-args' constructor required by OpenAccess. 
        public TRegisterReq()
        {
        }

        #region Properties

        [Telerik.OpenAccess.FieldAlias("reqID")]
        public int ReqID
        {
            get { return reqID; }
            set { this.reqID = value; }
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

        [Telerik.OpenAccess.FieldAlias("lastName")]
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        [Telerik.OpenAccess.FieldAlias("phoneNo")]
        public string PhoneNo
        {
            get { return phoneNo; }
            set { this.phoneNo = value; }
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

        #endregion

        #region Method

        public static TRegisterReq GetSingleByID(int reqId)
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            return scope.Extent<TRegisterReq>().SingleOrDefault(o => o.ReqID == reqId);
        }

        public static List<TRegisterReq> GetAll()
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            return scope.Extent<TRegisterReq>().ToList();
        }

        public static bool Update(int reqId, string userName, string firstName, string lastName, string email, string phoneNumber, int portalId)
        {
            IObjectScope scope = PayaScopeProvider1.GetNewObjectScope();
            try
            {
                var o = scope.Extent<TRegisterReq>().Single(emp => emp.ReqID == reqId);
                if (o != null)
                {
                    scope.Transaction.Begin();
                    o.UserName = userName;
                    o.FirstName = firstName;
                    o.LastName = lastName;
                    o.Email = email;
                    o.PhoneNo = phoneNumber;
                    o.PortalID = portalId;
                    scope.Transaction.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                if (scope.Transaction.IsActive)
                    scope.Transaction.Rollback();
                return false;
            }
        }

        public static bool Delete(int reqId)
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            try
            {
                var o = scope.Extent<TRegisterReq>().Single(emp => emp.ReqID == reqId);
                scope.Transaction.Begin();
                scope.Remove(o);
                scope.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (scope.Transaction.IsActive)
                    scope.Transaction.Rollback();
                return false;
            }
        }

        public static int Add(string userName, string firstName, string lastName, string email, string phoneNumber, int portalId)
        {
            IObjectScope scopeProvider = PayaScopeProvider1.GetNewObjectScope();
            try
            {
                scopeProvider.Transaction.Begin();
                var user = new TRegisterReq
                               {
                                   UserName = userName,
                                   FirstName = firstName,
                                   LastName = lastName,
                                   Email = email,
                                   PhoneNo = phoneNumber,
                                   PortalID = portalId
                               };
                scopeProvider.Add(user);
                scopeProvider.Transaction.Commit();

                return int.Parse(scopeProvider.GetObjectId(user).ToString());
            }
            catch (Exception)
            {
                if (scopeProvider.Transaction.IsActive)
                    scopeProvider.Transaction.Rollback();
                return 0;
            }
        }

        public static List<TRegisterReq> GetAllRegisterReqs(string userName, string firstName, string lastName, string email, int portalId)
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            return
                scope.Extent<TRegisterReq>().Where(
                    o =>
                    o.UserName.Contains(userName)   && o.FirstName.Contains(firstName) && o.LastName.Contains(lastName) && o.Email.Contains(email) &&
                    o.PortalID == portalId).ToList();
        }
        
        #endregion
        
    }
}