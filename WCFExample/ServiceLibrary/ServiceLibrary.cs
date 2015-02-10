using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Clinic.Models;
using Clinic.BLL;


namespace ServiceLibrary
{
    // You have created a class library to define and implement your WCF service.
    // You will need to add a reference to this library from another project and add 
    // the code to that project to host the service as described below.  Another way
    // to create and host a WCF service is by using the Add New Item, WCF Service 
    // template within an existing project such as a Console Application or a Windows 
    // Application.

    [ServiceContract(CallbackContract = typeof(IMessageCallback))]
    public interface IMessage
    {
        [OperationContract]
        void AddMessage(Guid doctorId);

        [OperationContract]
        bool Subscribe();

        [OperationContract]
        bool Unsubscribe();
    }

    [ServiceContract()]
    public interface IService1
    {
        

        #region CONSULTATION

        [OperationContract]
        void AddConsultation(Consultation consultation);
        [OperationContract]
        void UpdateConsultation(Consultation consultation);
        [OperationContract]
        void DeleteConsultation(Guid consultationId);
        [OperationContract]
        List<Consultation> GetAllConsultations();
        [OperationContract]
        Consultation getConsultationById(Guid consultationId);
        [OperationContract]
        List<Consultation> GetConsultationsByPatientId(Guid patientId);
        [OperationContract]
        List<Consultation> GetConsultationsByDoctorId(Guid doctorId);

        #endregion

        #region PATIENT
        [OperationContract]
        void AddPatient(Patient patient);
        [OperationContract]
        void UpdatePatient(Patient patient);
        [OperationContract]
        void DeletePatient(Guid patientId);
        [OperationContract]
        Patient GetPatientById(Guid id);
        [OperationContract]
        List<Patient> GetAllPatients();
        #endregion

        #region DOCTOR
        [OperationContract]
        void AddDoctor(Doctor doctor);
        [OperationContract]
        void UpdateDoctor(Doctor doctor);
        [OperationContract]
        void DeleteDoctor(Guid doctorId);
        [OperationContract]
        List<Doctor> GetAllDoctors();
        [OperationContract]
        Doctor GetDoctorById(Guid doctorId);
        [OperationContract]
        Doctor GetDoctorByUserId(Guid userId);
        #endregion

        #region SECRETARY
        [OperationContract]
        void AddSecretary(Secretary secretary);
        [OperationContract]
        void UpdateSecretary(Secretary secretary);
        [OperationContract]
        void DeleteSecretary(Guid secretaryId);
        [OperationContract]
        List<Secretary> GetAllSecretaries();
        [OperationContract]
        Secretary GetSecretaryById(Guid secretaryId);
        [OperationContract]
        Secretary GetSecretaryByUserId(Guid userId);
        #endregion

        #region User
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void UpdateUser(User user);
        [OperationContract]
        void DeleteUser(Guid userId);
        [OperationContract]
        List<User> GetAllUsers();
        [OperationContract]
        User GetUserById(Guid userId);
        [OperationContract]
        User GetUserByName(String userName);
        [OperationContract]
        string checkLogedInUser(String username, String password);


        #endregion


    }

    public class service1 : IService1,IMessage
    {
        
        private PatientBLL pBll = new PatientBLL();
        private ConsultationBLL cBll = new ConsultationBLL();
        private DoctorBLL dBll = new DoctorBLL();
        private SecretaryBLL sBll = new SecretaryBLL();
        private UserBLL uBll = new UserBLL();
        #region PATIENT
        public void AddPatient(Patient patient)
        {
            pBll.AddPatient(patient);
        }
        public void UpdatePatient(Patient patient)
        {
            pBll.UpdatePatient(patient);
        }
        public void DeletePatient(Guid patientId)
        {
            pBll.DeletePatient(patientId);
        }
        public List<Patient> GetAllPatients()
        {

            return pBll.GetAllPatients();

        }
        public Patient GetPatientById(Guid id)
        {
            return pBll.GetPatientById(id);
        }
        #endregion

        #region CONSULTATION

        public void AddConsultation(Consultation consultation)
        {
            cBll.AddConsultation(consultation);
        }

        public void UpdateConsultation(Consultation consultation)
        {
            cBll.UpdateConsultation(consultation);
        }

        public void DeleteConsultation(Guid consultationId)
        {
            cBll.DeleteConsultation(consultationId);
        }

        public List<Consultation> GetAllConsultations()
        {
            return cBll.GetAllConsultations();
        }

        public Consultation getConsultationById(Guid consultationId)
        {
            return cBll.GetConsultationById(consultationId);
        }
        public List<Consultation> GetConsultationsByPatientId(Guid patientId)
        {
            return cBll.GetConsultationsByPatientId(patientId);
        }
        public List<Consultation> GetConsultationsByDoctorId(Guid doctorId)
        {
            return cBll.GetConsultationsByDoctorId(doctorId);
        }
        #endregion

        #region DOCTOR

        public void AddDoctor(Doctor doctor)
        {
            dBll.AddDoctor(doctor);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            dBll.UpdateDoctor(doctor);
        }

        public void DeleteDoctor(Guid doctorId)
        {
            dBll.DeleteDoctor(doctorId);
        }

        public List<Doctor> GetAllDoctors()
        {
            return dBll.GetAllDoctors();
        }

        public Doctor GetDoctorById(Guid doctorId)
        {
            return dBll.GetDoctorById(doctorId);
        }
        public Doctor GetDoctorByUserId(Guid userId)
        {
            return dBll.GetDoctorByUserId(userId);
        }
        #endregion

        #region SECRETARY

        public void AddSecretary(Secretary secretary)
        {

            sBll.AddSecretary(secretary);
        }

        public void UpdateSecretary(Secretary secretary)
        {
            sBll.UpdateSecretary(secretary);
        }

        public void DeleteSecretary(Guid secretaryId)
        {
            sBll.DeleteSecretary(secretaryId);
        }

        public List<Secretary> GetAllSecretaries()
        {
            return sBll.GetAllSecretarys();
        }

        public Secretary GetSecretaryById(Guid secretaryId)
        {
            return sBll.GetSecretaryById(secretaryId);
        }

        public Secretary GetSecretaryByUserId(Guid userId)
        {
            return sBll.GetSecretaryById(userId);
        }
        #endregion

        #region User

        public void AddUser(User user)
        {
            uBll.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            uBll.UpdateUser(user);
        }

        public void DeleteUser(Guid userId)
        {
            uBll.DeleteUser(userId);
        }

        public List<User> GetAllUsers()
        {
            return uBll.GetAllUsers();
        }

        public User GetUserById(Guid userId)
        {
            return uBll.GetUserById(userId);
        }

        public User GetUserByName(String userName)
        {
            return uBll.GetUserByName(userName);
        }

        public string checkLogedInUser(String username, String password)
        {
            return uBll.checkLogedInUser(username, password);
        }

        #endregion

        #region Observer
        private static readonly List<IMessageCallback> subscribers = new List<IMessageCallback>();

        public void AddMessage(Guid doctorId)
        {
            subscribers.ForEach(delegate(IMessageCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.OnMessageAdded(doctorId);
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });
        }

        public bool Subscribe()
        {
            try
            {
                IMessageCallback callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                if (!subscribers.Contains(callback))
                    subscribers.Add(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Unsubscribe()
        {
            try
            {
                IMessageCallback callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                if (!subscribers.Contains(callback))
                    subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }

    
}
