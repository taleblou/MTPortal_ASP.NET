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
    public partial class TBannedIpNetwork
    {
        //The 'no-args' constructor required by OpenAccess. 
        public TBannedIpNetwork()
        {
        }

        #region Properties

        [Telerik.OpenAccess.FieldAlias("id")]
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        [Telerik.OpenAccess.FieldAlias("comment")]
        public string Comment
        {
            get { return comment; }
            set { this.comment = value; }
        }

        [Telerik.OpenAccess.FieldAlias("createdOn")]
        public DateTime CreatedOn
        {
            get { return createdOn; }
            set { this.createdOn = value; }
        }

        [Telerik.OpenAccess.FieldAlias("endIpAddress")]
        public string EndIpAddress
        {
            get { return endIpAddress; }
            set { this.endIpAddress = value; }
        }

        [Telerik.OpenAccess.FieldAlias("ipException")]
        public string IpException
        {
            get { return ipException; }
            set { this.ipException = value; }
        }

        [Telerik.OpenAccess.FieldAlias("startIpAddress")]
        public string StartIpAddress
        {
            get { return startIpAddress; }
            set { this.startIpAddress = value; }
        }

        [Telerik.OpenAccess.FieldAlias("updatedOn")]
        public DateTime? UpdatedOn
        {
            get { return updatedOn; }
            set { this.updatedOn = value; }
        }

        #endregion

        #region Method

        public static int Add(string startIpAddress, string endIpAddress, string ipException, string comment, DateTime createdOn)
        {
            IObjectScope scopeProvider = PayaScopeProvider1.GetNewObjectScope();
            try
            {
                scopeProvider.Transaction.Begin();
                var tab = new TBannedIpNetwork
                {
                    StartIpAddress = startIpAddress,
                    EndIpAddress = endIpAddress,
                    IpException = ipException,
                    Comment = comment,
                    CreatedOn = createdOn
                };
                scopeProvider.Add(tab);
                scopeProvider.Transaction.Commit();

                return int.Parse(scopeProvider.GetObjectId(tab).ToString());
            }
            catch (Exception)
            {
                if (scopeProvider.Transaction.IsActive)
                    scopeProvider.Transaction.Rollback();
                return 0;
            }
        }

        public static bool Delete(int id)
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            try
            {
                var o = scope.Extent<TBannedIpNetwork>().Single(emp => emp.Id == id);
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

        public static bool Update(int id, string startIpAddress, string endIpAddress, string ipException, string comment, DateTime updatedOn)
        {
            IObjectScope scope = PayaScopeProvider1.GetNewObjectScope();
            try
            {
                var o = scope.Extent<TBannedIpNetwork>().Single(emp => emp.Id == id);
                if (o != null)
                {
                    scope.Transaction.Begin();
                    o.StartIpAddress = startIpAddress;
                    o.EndIpAddress = endIpAddress;
                    o.IpException = ipException;
                    o.Comment = comment;
                    o.UpdatedOn = updatedOn;
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

        public static IEnumerable<TBannedIpNetwork> GetAll()
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            return scope.Extent<TBannedIpNetwork>().ToList();
        }

        public static TBannedIpNetwork GetSingleByID(int id)
        {
            var scope = PayaScopeProvider1.GetNewObjectScope();
            return scope.Extent<TBannedIpNetwork>().SingleOrDefault(o => o.Id == id);

        }

        #endregion
    }
}