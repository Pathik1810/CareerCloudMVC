using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface ISecurity
    {
        [OperationContract]
        void AddSecurityLogin(SecurityLoginPoco items);
        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco items);
        [OperationContract]
        void RemoveSecurityLogin (SecurityLoginPoco items);
        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(string Id);
        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();

        [OperationContract]
        void AddSecurityLoginLog(SecurityLoginsLogPoco items);
        [OperationContract]
        void UpdateSecurityLoginLog(SecurityLoginsLogPoco items);
        [OperationContract]
        void RemoveSecurityLoginLog(SecurityLoginsLogPoco items);
        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginLog(string Id);
        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginLog();

        [OperationContract]
        void AddSecurityRole(SecurityRolePoco items);
        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco items);
        [OperationContract]
        void RemoveSecurityRole(SecurityRolePoco items);
        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(string Id);
        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();
    }
}
