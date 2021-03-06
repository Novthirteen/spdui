using System;
using System.Collections;

//TODO: Add other using statements here

namespace Dndp.Persistence.Entity.Dui
{
    [Serializable]
    public class DataSourceField : EntityBase
    {
        #region O/R Mapping Properties
		
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
		
		private string _description;
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}
		
		private string _fieldType;
		public string FieldType
		{
			get
			{
				return _fieldType;
			}
			set
			{
				_fieldType = value;
			}
		}
		
		private int _sequenceNo;
		public int SequenceNo
		{
			get
			{
				return _sequenceNo;
			}
			set
			{
				_sequenceNo = value;
			}
		}
		
		private string _fieldLength;
		public string FieldLength
		{
			get
			{
				return _fieldLength;
			}
			set
			{
				_fieldLength = value;
			}
		}
		
		private bool _isDataKey;
		public bool IsDataKey
		{
			get
			{
				return _isDataKey;
			}
			set
			{
				_isDataKey = value;
			}
		}
		
		private bool _isNullable;
		public bool IsNullable
		{
			get
			{
				return _isNullable;
			}
			set
			{
				_isNullable = value;
			}
		}

        private DataSource _theDataSource;
        public DataSource TheDataSource
        {
            get
            {
                return _theDataSource;
            }
            set
            {
                _theDataSource = value;
            }
        }
        
        #endregion

        #region Non O/R Mapping Properties

        //TODO: Add Non O/R Mapping Properties here. 

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
            DataSourceField another = obj as DataSourceField;
			
            if (another == null)
            {
                return false;
            }
            else
            {
            	return (this.Id == another.Id) && (this.Name == another.Name) && (this.Description == another.Description) && (this.FieldType == another.FieldType) && (this.SequenceNo == another.SequenceNo) && (this.FieldLength == another.FieldLength) && (this.IsDataKey == another.IsDataKey) && (this.IsNullable == another.IsNullable);
            }
        } 
    }
	
}
