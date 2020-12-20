using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Insert(InsertUser user); //membuat method insert

        [OperationContract]
        GetTestData GetInfo(); //membuat method getinfo

        [OperationContract]
        string Update(UpdateUser u); //membuat method update

        [OperationContract]
        string Delete(DeleteUser d); //membuat method delete
        // TODO: Add your service operations here
    }

    [DataContract]
    public class GetTestData //membuat class getTestData 
    {
        [DataMember]
        public DataTable userTable //membuat properties userTable
        {
            get;
            set;
        }

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class InsertUser //membuat class InsertUser 
    {
        string name = string.Empty;
        string email = string.Empty;

        [DataMember]
        public string Name //membuat properties Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Email //membuat properties Email
        {
            get { return email; }
            set { email = value; }
        }
    }

    [DataContract]
    public class UpdateUser //membuat class UpdateUser 
    {
        int uID;
        string name;
        string email;

        [DataMember]
        public int UID //membuat properties UID
        {
           get { return uID; }
           set { uID = value; }
        }

        [DataMember]
        public string Name //membuat properties Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Email //membuat properties Email
        {
            get { return email; }
            set { email = value; }
        }
    }

    [DataContract]
    public class DeleteUser //membuat class DeleteUser 
    {
        int uID;

        [DataMember]
        public int UID //membuat properties UID
        {
            get { return uID; }
            set { uID = value; }
        }
    }
}