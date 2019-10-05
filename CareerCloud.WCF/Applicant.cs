using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class Applicant : IApplicant
    {
        public void AddAppliantSkills(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic
                 (
                new EFGenericRepository<ApplicantSkillPoco>()
               );
            logic.Add(items);
        }

        public void AddAppliantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic
                (
               new EFGenericRepository<ApplicantWorkHistoryPoco>()
              );
            logic.Add(items);
        }

        public void AddApplicantEducation(ApplicantEducationPoco[] items)
        {
            //One Way
            //EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>();
            //ApplicantEducationLogic logic = new ApplicantEducationLogic(repo);

            //Another Way 
            var logic = new ApplicantEducationLogic
                 (
                new EFGenericRepository<ApplicantEducationPoco>()
               );
            logic.Add(items);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic
                (
               new EFGenericRepository<ApplicantJobApplicationPoco>()
              );
            logic.Add(items);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic
                (
               new EFGenericRepository<ApplicantProfilePoco>()
              );
            logic.Add(items);
        }

        public void AddApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic
                (
               new EFGenericRepository<ApplicantResumePoco>()
              );
            logic.Add(items);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            var logic = new ApplicantEducationLogic
            (new EFGenericRepository<ApplicantEducationPoco>(false));
            return logic.GetAll();  
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            //var logic = new ApplicantJobApplicationLogic
            //    (
            //   new EFGenericRepository<ApplicantJobApplicationPoco>(false)
            //  );
            //logic.Add(items);
            var logic = new ApplicantJobApplicationLogic
           (new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            return logic.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            throw new NotImplementedException();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            throw new NotImplementedException();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            throw new NotImplementedException();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            ApplicantEducationLogic logic = new ApplicantEducationLogic
                 (new EFGenericRepository<ApplicantEducationPoco>(false));
           return logic.Get(Guid.Parse(Id)); 
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            throw new NotImplementedException();
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            throw new NotImplementedException();
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            throw new NotImplementedException();
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>());
            logic.Delete(items);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveApplicantSkills(ApplicantSkillPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateAppliantSkills(ApplicantSkillPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateAppliantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>());
            logic.Update(items);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}