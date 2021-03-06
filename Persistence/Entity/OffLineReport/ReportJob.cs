using System;
using System.Collections;
using Dndp.Persistence.Entity.Security;
using System.Collections.Generic;

//TODO: Add other using statements here

namespace Dndp.Persistence.Entity.OffLineReport
{
    [Serializable]
    public class ReportJob : EntityBase
    {
        #region O/R Mapping Properties

        private ReportBatch _theBatch;
        public ReportBatch TheBatch
		{
			get
			{
				return _theBatch;
			}
			set
			{
				_theBatch = value;
			}
		}
		
		private DateTime _startTime;
		public DateTime StartTime
		{
			get
			{
				return _startTime;
			}
			set
			{
				_startTime = value;
			}
		}
		
		private DateTime _endTime;
		public DateTime EndTime
		{
			get
			{
				return _endTime;
			}
			set
			{
				_endTime = value;
			}
		}

        private DateTime _reportDate;
        public DateTime ReportDate
        {
            get
            {
                return _reportDate;
            }
            set
            {
                _reportDate = value;
            }
        }

		private string _status;
		public string Status
		{
			get
			{
				return _status;
			}
			set
			{
				_status = value;
			}
		}

        private string _needSendMail;
        public string NeedSendMail
        {
            get
            {
                return _needSendMail;
            }
            set
            {
                _needSendMail = value;
            }
        }

        private string _eMailSubject;
        public string EMailSubject
        {
            get
            {
                return _eMailSubject;
            }
            set
            {
                _eMailSubject = value;
            }
        }

        private string _emailBody;
        public string EmailBody
        {
            get
            {
                return _emailBody;
            }
            set
            {
                _emailBody = value;
            }
        }

        private string _jobDescription;
        public string JobDescription
        {
            get
            {
                return _jobDescription;
            }
            set
            {
                _jobDescription = value;
            }
        }

        private string _appendDateToFileName;
        public string AppendDateToFileName
        {
            get
            {
                return _appendDateToFileName;
            }
            set
            {
                _appendDateToFileName = value;
            }
        }

        private string _runPreSQL;
        public string RunPreSQL
        {
            get
            {
                return _runPreSQL;
            }
            set
            {
                _runPreSQL = value;
            }
        }

        private string _appendUserNameToFileName;
        public string AppendUserNameToFileName
        {
            get
            {
                return _appendUserNameToFileName;
            }
            set
            {
                _appendUserNameToFileName = value;
            }
        }

        private string _needCreateSubFolder;
        public string NeedCreateSubFolder
        {
            get
            {
                return _needCreateSubFolder;
            }
            set
            {
                _needCreateSubFolder = value;
            }
        }

        private string _needUploadToPortal;
        public string NeedUploadToPortal
        {
            get
            {
                return _needUploadToPortal;
            }
            set
            {
                _needUploadToPortal = value;
            }
        }

        private string _uploadFolder;
        public string UploadFolder
        {
            get
            {
                return _uploadFolder;
            }
            set
            {
                _uploadFolder = value;
            }
        }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                _createDate = value;
            }
        }

        private User _createUser;
        public User CreateUser
        {
            get
            {
                return _createUser;
            }
            set
            {
                _createUser = value;
            }
        }

        private DateTime _updateDate;
        public DateTime UpdateDate
        {
            get
            {
                return _updateDate;
            }
            set
            {
                _updateDate = value;
            }
        }

        private User _updateUser;
        public User UpdateUser
        {
            get
            {
                return _updateUser;
            }
            set
            {
                _updateUser = value;
            }
        }

        private int _errors;
        public int Errors
        {
            get
            {
                return _errors;
            }
            set
            {
                _errors = value;
            }
        }

        private int _problems;
        public int Problems
        {
            get
            {
                return _problems;
            }
            set
            {
                _problems = value;
            }
        }

        private int _warnings;
        public int Warnings
        {
            get
            {
                return _warnings;
            }
            set
            {
                _warnings = value;
            }
        }
        private string _validateStatus;
        public string ValidateStatus
        {
            get
            {
                return _validateStatus;
            }
            set
            {
                _validateStatus = value;
            }
        }
        #endregion

        #region Non O/R Mapping Properties
        // Modified by vincent at 2007-10-30 Begin
        public const string REPORT_JOB_STATUS_RUNNING = "Running";
        // Modified by vincent at 2007-10-30 Begin
        public const string REPORT_JOB_STATUS_PENDING = "Pending";
        public const string REPORT_JOB_STATUS_SUBMIT = "Submit";
        public const string REPORT_JOB_STATUS_SUCCESS = "Success";
        public const string REPORT_JOB_STATUS_FAILED = "Failed";
        public const string REPORT_JOB_STATUS_CANCEL = "Canceled";

        public const string REPORT_JOB_VALIDATE_STATUS_WaitingValidate = "Waiting Validate";
        public const string REPORT_JOB_VALIDATE_STATUS_ValidatedFailed = "Validate Failed";
        public const string REPORT_JOB_VALIDATE_STATUS_ValidatedPassed = "Validate Passed";
        
        //TODO: Add Non O/R Mapping Properties here. 
        private IList _reportList;
        public IList ReportList
        {
            get
            {
                return _reportList;
            }
            set
            {
                _reportList = value;
            }
        }

        private IList _userList;
        public IList UserList
        {
            get
            {
                return _userList;
            }
            set
            {
                _userList = value;
            }
        }

        private IList _ruleList;
        public IList RuleList
        {
            get
            {
                return _ruleList;
            }
            set
            {
                _ruleList = value;
            }
        }

        public IList<ReportJobValidationResult> ErrorReportJobValidationResultList
        {
            get
            {
                if (RuleList != null)
                {
                    IList<ReportJobValidationResult> list = new List<ReportJobValidationResult>();
                    foreach (ReportJobValidationResult result in RuleList)
                    {
                        if (result.TheRule.Type.ToUpper().Equals("ERROR"))
                        {
                            list.Add(result);
                        }
                    }

                    return list;
                }
                else
                {
                    return null;
                }
            }
        }

        public IList<ReportJobValidationResult> ProblemReportJobValidationResultList
        {
            get
            {
                if (RuleList != null)
                {
                    IList<ReportJobValidationResult> list = new List<ReportJobValidationResult>();
                    foreach (ReportJobValidationResult result in RuleList)
                    {
                        if (result.TheRule.Type.ToUpper().Equals("PROBLEM"))
                        {
                            list.Add(result);
                        }
                    }

                    return list;
                }
                else
                {
                    return null;
                }
            }
        }

        public IList<ReportJobValidationResult> WarningReportJobValidationResultList
        {
            get
            {
                if (RuleList != null)
                {
                    IList<ReportJobValidationResult> list = new List<ReportJobValidationResult>();
                    foreach (ReportJobValidationResult result in RuleList)
                    {
                        if (result.TheRule.Type.ToUpper().Equals("WARNING"))
                        {
                            list.Add(result);
                        }
                    }

                    return list;
                }
                else
                {
                    return null;
                }
            }
        }

        public string ReportJobValidationResultIds
        {
            get
            {
                if (RuleList != null)
                {
                    string ids = "";
                    foreach (ReportJobValidationResult result in RuleList)
                    {
                        ids += "," + result.Id.ToString();
                    }

                    return ids.Trim(',');
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        #endregion

        public override int GetHashCode()
        {
            if (Id > 0)
            {
                return Id;
            }
            else
            {
                return base.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            ReportJob another = obj as ReportJob;
			
            if (another == null)
            {
                return false;
            }
            else
            {
                // Modified By Vincent 2006-09-05 Begin
                return (this.Id == another.Id) && (this.TheBatch == another.TheBatch) && (this.StartTime == another.StartTime) && (this.EndTime == another.EndTime) && (this.Status == another.Status) && (this.NeedSendMail == another.NeedSendMail);
                // Modified By Vincent 2006-09-05 End
            }
        } 
    }
	
}
